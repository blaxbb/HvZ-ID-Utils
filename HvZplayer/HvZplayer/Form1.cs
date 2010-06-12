using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DataMatrix.net;
using WinFormCharpWebCam;

namespace HvZplayer
{
    public partial class Form1 : Form
    {
        WebCam webcam;
        public Form1()
        {
            InitializeComponent();

            tabControl1.Dock = DockStyle.Fill;
            label3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("GOOD");
            webcam = new WebCam();
            webcam.InitializeWebCam(ref pictureBox1);
            webcam.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap blankID = new Bitmap("images/hvzid02.jpg");

            DmtxImageEncoder encoder = new DmtxImageEncoder();
            DmtxImageEncoderOptions options = new DmtxImageEncoderOptions();
            options.ModuleSize = 8;
            options.MarginSize = 4;
            options.BackColor = Color.White;
            options.ForeColor = Color.Black;

            Bitmap codeBitmap = encoder.EncodeImage(textBox1.Text + "|" + textBox2.Text);

            Bitmap genID = new Bitmap(234, 126);
            Graphics build = Graphics.FromImage(genID);
            build.DrawImage(blankID, 0, 0);
            build.DrawImage(scaleByPercent(codeBitmap, 50), 85, 4);
            build.DrawString(textBox1.Text, new Font("Arial", 12), new SolidBrush(Color.Black), 6, 73);
            build.DrawString(textBox2.Text, new Font("Arial", 12), new SolidBrush(Color.Black), 6, 88);

            saveFileDialog1.Filter = "jpeg files (*.jpeg)|*.jpeg";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && saveFileDialog1.FileName.Length > 0)
            {

                genID.Save(saveFileDialog1.FileName,ImageFormat.Jpeg);
                label3.Text = "ID successfully generated";
            }


            //genID.Save("newID.jpg");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Image captured = pictureBox1.Image;

            DmtxImageDecoder decoder = new DmtxImageDecoder();
            List<string> codes = decoder.DecodeImage((Bitmap)captured, 1, new TimeSpan(0, 0, 3));
            StringBuilder builder = new StringBuilder();
            foreach (string code in codes)
            {
                builder.Append(code);
            }
            
            string result = builder.ToString();
            if (result == "")
            {
                label4.Text = ("Name: " + "error");
                label5.Text = ("Kill ID: " + "error");
            }
            else
            {
                //result = "Brian|ABDKJV";
                String[] items = result.Split('|');

                label4.Text = label4.Text + items[0];
                label5.Text = label5.Text + items[1];
                
            }

        }
    }
}
