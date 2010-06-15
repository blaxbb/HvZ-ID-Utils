using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using com.google.zxing;
using com.google.zxing.qrcode;

using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using HtmlAgilityPack;
using System.Reflection;
using System.IO;


namespace HvZmod
{
    public partial class Form1 : Form
    {
        string htmlLocation = "";
        string imageSaveLocation = "";

        List<player> players = new List<player>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("players.csv"))
            {
                putCSV(new StreamReader("players.csv"));
                enableControls();

            }
        }

        private void enableControls()
        {
            button_outLocation.Enabled = true;
            
        }

        public class player
        {
            public string name;
            public string killid;
            public string email;

            public player(string name, string killid, string email)
            {
                this.name = name;
                this.killid = killid;
                this.email = email;
            }
        }

        private void button_list_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && openFileDialog1.FileName.Length > 0)
            {
                toolStripStatusLabel1.Text = "HTML Loaded";
                htmlLocation = openFileDialog1.FileName.ToString();
                
                
                string[] parsedHtml = parseHtml(htmlLocation);

                int skippedHeader = 0;

                foreach (string parse in parsedHtml)
                {
                    if (skippedHeader == 0)
                    {
                        skippedHeader++;
                    }
                    else
                    {
                        try
                        {
                            string[] splitParse = (parse.ToString()).Split('|');
                            players.Add(new player(splitParse[0], splitParse[1],splitParse[2]));                         
                        }
                        catch (Exception excep)
                        {
                            MessageBox.Show(excep.Message);
                            break;
                        }



                    }
                    
                }

                StreamWriter sw = new StreamWriter("players.csv");
                sw.WriteLine("Name,KillID,Email");
                players.ForEach(delegate(player p)
                {
                    sw.WriteLine(p.name + "," + p.killid + "," + p.email);
                });
                sw.Close();
                label_list.Text = htmlLocation;

                button_outLocation.Enabled = true;
            }
        }

        private void button_imageOutLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && folderBrowserDialog1.SelectedPath.ToString().Length > 0)
            {
                toolStripStatusLabel1.Text = "Folder Selected";
                imageSaveLocation = folderBrowserDialog1.SelectedPath.ToString();
                label_outLoc.Text = imageSaveLocation;
                button_save.Enabled = true;
            }
        }
        
        private void button_save_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Processing";

            players.ForEach(delegate(player p)
            {
                generateID(p.name, p.killid).Save(imageSaveLocation + @"\" + p.name + "_ID.jpeg", ImageFormat.Jpeg);
                Console.WriteLine("Generated " + p.name + "'s ID");
            });
            //string[] parsedHtml =  parseHtml(htmlLocation);
            
            //int skippedHeader = 0;

            //foreach (string parse in parsedHtml)
            //{
            //    if (skippedHeader ==0)
            //    {
            //        skippedHeader++;
            //    }
            //    else
            //    {
            //        try
            //        {
            //            string[] splitParse = (parse.ToString()).Split('|');
            //            Console.WriteLine("Generating" + splitParse[0]);
            //            generateID(splitParse[0], splitParse[1]).Save(imageSaveLocation + @"\" + splitParse[0] + "_ID.jpeg", ImageFormat.Jpeg);
            //        }
            //        catch (Exception excep)
            //        {
            //            MessageBox.Show(excep.Message);
            //            return;
            //        }
            //    }
            //}

        }

        private String[] parseHtml(string filename)
        {
            
            
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            
            doc.Load(filename);

            String[] procTable = new string[5000];
            int rowNumb = 0;

            StringBuilder sb = new StringBuilder();           
            

            foreach (HtmlNode table in doc.DocumentNode.SelectNodes("//table"))
            {
                Console.WriteLine("Found: " + table.Id);
                foreach (HtmlNode row in table.SelectNodes("tr"))
                {
                    Console.WriteLine("row "+ rowNumb.ToString());
                    
                    foreach (HtmlNode cell in row.SelectNodes("th|td"))
                    {

                        
                        Console.WriteLine("cell: " + cell.InnerText);

                        sb.Append(cell.InnerText);
                        sb.Append("|");
                    }
                    sb.Remove((sb.Length - 1), 1);
                    procTable[rowNumb] = sb.ToString();
                    sb.Remove(0, sb.Length);
                    rowNumb++;
                }
            }

            return procTable;
        }

        public static string getCSV<T>(List<string> list)
        {
            string[] array = list.ToArray();
            return (string.Join(",", array));
        }

        public void putCSV(StreamReader file)
        {
            try
            {

                int firstLine = 0;
                string line;
                string[] row;

                while ((line = file.ReadLine()) != null)
                {
                    if (firstLine == 0) { firstLine++; }
                    else
                    {
                        row = line.Split(',');
                        players.Add(new player(row[0], row[1], row[2]));
                    }
                }

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

        }

        private Image generateID(string name, string ID)
        {
            String encoding = name + "|" + ID;

            com.google.zxing.qrcode.QRCodeWriter qrCode = new com.google.zxing.qrcode.QRCodeWriter();
            com.google.zxing.common.ByteMatrix byteIMG = qrCode.encode(encoding, com.google.zxing.BarcodeFormat.QR_CODE, 200, 200);

            sbyte[][] img = byteIMG.Array;

            Bitmap qrCodeBmp = new Bitmap(200, 200);
            Graphics g = Graphics.FromImage(qrCodeBmp);

            g.Clear(Color.White);

            for (int i = 0; i <= img.Length - 1; i++)
            {
                for (int j = 0; j <= img[i].Length - 1; j++)
                {
                    if (img[i][j] == 0)
                    {
                        g.FillRectangle(Brushes.Black, j, i, 1, 1);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.White, j, i, 1, 1);
                    }
                }
            }


            Bitmap blankID = new Bitmap("hvzid02.jpg");
            Bitmap genID = new Bitmap(234, 126);

            Graphics build = Graphics.FromImage(genID);
            build.DrawImage(blankID, 0, 0);



            build.DrawString(name, new Font("Arial", 10), new SolidBrush(System.Drawing.Color.Black), 6, 80);
            build.DrawString(ID, new Font("Arial", 10), new SolidBrush(System.Drawing.Color.Black), 6, 95);

            build.DrawImage(scaleByPercent(qrCodeBmp, 75), 95, -12);

            toolStripStatusLabel1.Text = "Encoded";

            return genID;
        }

        static Image scaleByPercent(Image imgPhoto, int Percent)
        {
            float nPercent = ((float)Percent / 100);

            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;

            int destX = 0;
            int destY = 0;
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(destWidth, destHeight,
                                     PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                                    imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

    }
}
