using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using com.google.zxing;
using com.google.zxing.common;
using com.google.zxing.client;
using com.google.zxing.qrcode;


using AForge.Video;
using AForge.Video.DirectShow;

namespace HvZplayer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
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
                toolStripStatusLabel1.Text = "Scan a Player ID";
            }
            else
            {
                String[] items = (decodedString).Split('|');

                this.Invoke((MethodInvoker)delegate//run on UI thread
                {
                    label_Name.Text = "Name: " + items[0];
                    label_Kill.Text = "Kill ID: " + items[1];
                    toolStripStatusLabel1.Text = "Decoded";
                });
            }
            
            
            
        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                videoSource.Stop();
            }
        }

        private FilterInfoCollection videoCaptureDevices;
        private VideoCaptureDevice videoSource;

       
        static BackgroundWorker decoder = new BackgroundWorker();
        


        private void Form1_Load(object sender, EventArgs e)
        {
            decoder.DoWork += new DoWorkEventHandler(decoder_DoWork);

            tabControl1.Dock = DockStyle.Fill;
            toolStripStatusLabel1.Text = "";
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            
            videoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            
            foreach (FilterInfo videoCaptureDevice in videoCaptureDevices)
            {
                comboBox1.Items.Add(videoCaptureDevice.Name);
            }
            comboBox1.SelectedIndex = 0;
             

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String encoding = textBox_Name.Text + "|" + textBox_Kill.Text;

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
            build.DrawImage(scaleByPercent(qrCodeBmp, 50), 75, -12);
            build.DrawString(textBox_Name.Text, new Font("Arial", 12), new SolidBrush(System.Drawing.Color.Black), 6, 80);
            build.DrawString(textBox_Kill.Text, new Font("Arial", 12), new SolidBrush(System.Drawing.Color.Black), 6, 95);

            toolStripStatusLabel1.Text = "Encoded";

            saveFileDialog1.Filter = "jpeg files (*.jpeg)|*.jpeg";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && saveFileDialog1.FileName.Length > 0)
            {

                genID.Save(saveFileDialog1.FileName,ImageFormat.Jpeg);

                toolStripStatusLabel1.Text = "ID saved";
            }
        }



        

        private void button3_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoCaptureDevices[comboBox1.SelectedIndex].MonikerString);

            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);

            videoSource.Start();
        }

 
        void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            
            decoder.RunWorkerAsync((Bitmap) eventArgs.Frame.Clone());

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
