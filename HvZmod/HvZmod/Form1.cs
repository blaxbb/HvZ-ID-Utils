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
using com.google.zxing.common;


namespace HvZmod
{
    public partial class Form1 : Form
    {
        string htmlLocation = "";
        string imageSaveLocation = "";

        private FilterInfoCollection videoCaptureDevices;
        private VideoCaptureDevice videoSource;

        static BackgroundWorker decoder = new BackgroundWorker();

        List<player> players = new List<player>();
        List<player> absent = new List<player>();
        List<player> present = new List<player>();
        List<player> arbit= new List<player>();
        List<player> arbitSource = new List<player>();

        int debugI= 1;

        public class player
        {
            public string name;
            public string killid;

            public player(string name, string killid)
            {
                this.name = name;
                this.killid = killid;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            decoder.DoWork += new DoWorkEventHandler(decoder_DoWork);

            if (File.Exists("players.csv"))
            {
                putCSV(new StreamReader("players.csv"));
                enableControls();
                label_HTML_loc.Text = "Player List loaded";
                label_outLoc.Text = "Select Image Folder";
            }

            videoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo videoCaptureDevice in videoCaptureDevices)
            {
                comboBox_videoSource.Items.Add(videoCaptureDevice.Name);
                
            }
            comboBox_videoSource.SelectedIndex = 0;

            toolStripStatusLabel1.Text = "";
        }

        void decoder_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap bmp = (Bitmap)e.Argument;
            
            QRCodeReader reader = new QRCodeReader();
            RGBLuminanceSource source = new RGBLuminanceSource(bmp, bmp.Width, bmp.Height);

            BinaryBitmap binDecode = new BinaryBitmap(new HybridBinarizer(source));

            String decodedString = "";
            Result result;

            try
            {
                result = (Result)reader.decode(binDecode);
                decodedString = result.Text;
            }

            catch (ReaderException)
            {
                decodedString = "";
            }

            if (decodedString == "")
            {

            }

            else
            {
                String[] items = (decodedString).Split('|');

                this.Invoke((MethodInvoker)delegate//run on UI thread
                {
                        playerPresent(items[0], items[1]);
                    
                });
            }
        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {

            try
            {
                if (videoSource.IsRunning)
                {
                    videoSource.Stop();
                }
            }
            catch (Exception) { }
        }

        private void enableControls()
        {
            button_outLocation.Enabled = true;
            button_Attend_Present.Enabled = true;
            button_List_Add.Enabled = true;
            button_Save_Attend.Enabled = true;
            button_List_Save.Enabled = true;
            
        }

        private void button_list_Click(object sender, EventArgs e)
        {
            players.RemoveRange(0, players.Count);

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

                            //[4] = "<a href='admin/edit_player.php?id=GWKPIL'>edit</a>"

                            string ID = splitParse[4].ToString().Remove(0, 34);
                            

                            //string[] idURL = splitParse[4].ToString().Split('=');
                            players.Add(new player(splitParse[0], ID.Remove(6, 10)));                         
                        }
                        catch (Exception excep)
                        {
                            break;
                        }



                    }
                    
                }

                absent = players;

                absent.ForEach(delegate(player p)
                {
                    ListViewItem item = new ListViewItem(p.name);
                    item.SubItems.Add(p.killid);
                    listView_Attend_Absent.Items.Add(item);
                });


                try
                {
                    StreamWriter sw = new StreamWriter("players.csv");
                    sw.WriteLine("Name,KillID");
                    players.ForEach(delegate(player p)
                    {
                        sw.WriteLine(p.name + "," + p.killid);
                        Console.WriteLine(p.name + "," + p.killid);
                    });
                    sw.Close();
                    label_HTML_loc.Text = htmlLocation;

                    button_outLocation.Enabled = true;

                    enableControls();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }

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
                label_Save.Text = "Save images to folder";
                button_save.Enabled = true;
            }
        }
        
        private void button_save_Click(object sender, EventArgs e)
        {
            

            int i = 1;
            players.ForEach(delegate(player p)
            {
                Image gen = generateID(p.name, p.killid);
                if (File.Exists(imageSaveLocation + @"\" + p.name + "_ID.jpeg"))//prevent duplicate names from overlapping files
                {
                    gen.Save(imageSaveLocation + @"\" + p.name + "_" + i.ToString() + "_ID.jpeg", ImageFormat.Jpeg);
                }
                else
                {
                    gen.Save(imageSaveLocation + @"\" + p.name + "_ID.jpeg", ImageFormat.Jpeg);
                }
                i++;
            });

            toolStripStatusLabel1.Text = "Generated images";
            
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
                    int colNumb = 0;
                    foreach (HtmlNode cell in row.SelectNodes("th|td"))
                    {
                        switch (colNumb)
                        {
                            case 4:
								Console.WriteLine("cell: " + cell.InnerHtml);
						        sb.Append(cell.InnerHtml);
						        sb.Append("|");
                                break;
                            case 5:
                                Console.WriteLine("cell: " + cell.InnerText);
                                sb.Append(cell.InnerText);
                                break;

                            default:
                                Console.WriteLine("cell: " + cell.InnerText);
                                sb.Append(cell.InnerText);
                                sb.Append("|");
                                break;

                        }
                        colNumb++;
                    }
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
                int lineNumb = 0;

                while ((line = file.ReadLine()) != null)
                {
                    if (firstLine == 0) { firstLine++; }
                    else
                    {
                        row = line.Split(',');
                        players.Add(new player(row[0], row[1]));
                        Console.WriteLine(lineNumb.ToString());
                        lineNumb++;
                    }
                }

                players.ForEach(delegate(player p)
                {
                    arbitSource.Add(p);
                    absent.Add(p);
                });

                //arbitSource = absent = players;

                absent.ForEach(delegate(player p)
                {
                    ListViewItem item = new ListViewItem(p.name);
                    item.SubItems.Add(p.killid);

                    listView_Attend_Absent.Items.Add(item);
                });

            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            file.Close();

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

            Console.WriteLine(debugI.ToString());
            debugI++;

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

        public void playerPresent(string name, string ID)
        {
            player find = new player(name, ID);

            switch (tabControl1.SelectedIndex)
            {
                case 2:
                    if (absent.Exists(delegate(player p) { return ((p.name == name) && (p.killid == ID)); }))
                    {

                        //add to the Present List
                        present.Add(find);

                        ListViewItem item = new ListViewItem(find.name);
                        item.SubItems.Add(find.killid);
                        listView_Attend_Present.Items.Add(item);


                        //remove from Absent List
                        absent.RemoveAll((delegate(player p) { return p.killid == ID; }));

                        ListViewItem i = listView_Attend_Absent.FindItemWithText(name, false, 0, false);
                        listView_Attend_Absent.Items.Remove(i);

                        textBox_Name_Attend.Text = "";
                        textBox_Kill_Attend.Text = "";

                        //update GUI
                        toolStripStatusLabel1.Text = name + " Accounted for";

                        label_Attend_Absent.Text = "Absent " + absent.Count.ToString();
                        label_Attend_Present.Text = "Present " + present.Count.ToString();

                        label_Name_Attend.Text = "Name: " + name;
                        label_Kill_Attend.Text = "KillID: " + ID;
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "SOMETHING IS WRONG WITH ID OR ALREADY SCANNED?";
                    }
                    break;

                case 3:
                    if (arbitSource.Exists(delegate(player p) { return ((p.name == name) && (p.killid == ID)); }))
                    {

                        //add to the Arbit List
                        arbit.Add(find);

                        ListViewItem item = new ListViewItem(find.name);
                        item.SubItems.Add(find.killid);
                        listView_List.Items.Add(item);

                        //remove from arbit source
                        arbitSource.RemoveAll((delegate(player p) { return p.killid == ID; }));

                        //update GUI
                        toolStripStatusLabel1.Text = name + " Accounted for";

                        label_List_List.Text = "Players " + arbit.Count.ToString();
                        //label_Attend_Absent.Text = "Absent " + absent.Count.ToString();

                        
                        label_Name_List.Text = "Name: " + name;
                        label_Kill_List.Text = "KillID: " + ID;
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "SOMETHING IS WRONG WITH ID - ALREADY SCANNED?";
                    }
                    break;

            }


            

        }

        private void button_selectWebcam_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoCaptureDevices[comboBox_videoSource.SelectedIndex].MonikerString);

            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);

            videoSource.Start();

            label_Attend_Picture.Text = label_Picture_List.Text = "Scan an ID";
        }

        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox_CreateList.Image = pictureBox_ScanAttend.Image = pictureBox_Setup.Image = (Bitmap)eventArgs.Frame.Clone();



            this.Invoke((MethodInvoker)delegate//run on UI thread
                {
                    if (tabControl1.SelectedIndex >= 2)
                    {
                    decoder.RunWorkerAsync((Bitmap)eventArgs.Frame.Clone());
                    }
                });

            //decoder.RunWorkerAsync((Bitmap)eventArgs.Frame.Clone());
        }

        private void button_Attend_Present_Click(object sender, EventArgs e)
        {
            playerPresent(textBox_Name_Attend.Text, textBox_Kill_Attend.Text);
        }

        private void button_Save_Attend_Click(object sender, EventArgs e)
        {
            string absentFile = "Absent " + DateTime.Now.ToString("MM-dd-yy hh.mm.ss") + ".csv";
            string presentFile = "Present " + DateTime.Now.ToString("MM-dd-yy hh.mm.ss") + ".csv";
            StreamWriter swAbsent = new StreamWriter(absentFile);
            swAbsent.WriteLine("Name,KillID");
            absent.ForEach(delegate(player p)
            {
                swAbsent.WriteLine(p.name + "," + p.killid);
                Console.WriteLine(p.name + "," + p.killid);
            });
            swAbsent.Close();

            StreamWriter swPresent = new StreamWriter(presentFile);
            swPresent.WriteLine("Name,KillID");
            present.ForEach(delegate(player p)
            {
                swPresent.WriteLine(p.name + "," + p.killid);
                Console.WriteLine(p.name + "," + p.killid);
            });
            swPresent.Close();

            toolStripStatusLabel1.Text = "Lists saved";
        }

        private void button_List_Add_Click(object sender, EventArgs e)
        {
            playerPresent(textBox_Name_Add.Text, textBox_Kill_Add.Text);
        }

        private void button_List_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string arbitFile = saveFileDialog1.FileName;
            StreamWriter swAbsent = new StreamWriter(arbitFile);
            swAbsent.WriteLine("Name,KillID");
            arbit.ForEach(delegate(player p)
            {
                swAbsent.WriteLine(p.name + "," + p.killid);
                Console.WriteLine(p.name + "," + p.killid);
            });
            swAbsent.Close();

            toolStripStatusLabel1.Text = "List saved";
        }

        private void richTextBox2_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

    }
}
