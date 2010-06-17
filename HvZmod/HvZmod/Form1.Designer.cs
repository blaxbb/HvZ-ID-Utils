namespace HvZmod
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_Save = new System.Windows.Forms.Label();
            this.label_outLoc = new System.Windows.Forms.Label();
            this.label_list = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_outLocation = new System.Windows.Forms.Button();
            this.button_list = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox_Setup = new System.Windows.Forms.PictureBox();
            this.comboBox_videoSource = new System.Windows.Forms.ComboBox();
            this.button_selectWebcam = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_Attend_Absent = new System.Windows.Forms.Label();
            this.label_Attend_Present = new System.Windows.Forms.Label();
            this.label_Attend_Picture = new System.Windows.Forms.Label();
            this.button_Save_Attend = new System.Windows.Forms.Button();
            this.button_Attend_Present = new System.Windows.Forms.Button();
            this.textBox_Kill_Attend = new System.Windows.Forms.TextBox();
            this.textBox_Name_Attend = new System.Windows.Forms.TextBox();
            this.listView_Attend_Absent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Attend_Present = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Kill_Attend = new System.Windows.Forms.Label();
            this.label_Name_Attend = new System.Windows.Forms.Label();
            this.pictureBox_ScanAttend = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label_Kill_List = new System.Windows.Forms.Label();
            this.label_Name_List = new System.Windows.Forms.Label();
            this.pictureBox_CreateList = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listView_List = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_List_Add = new System.Windows.Forms.Button();
            this.textBox_Kill_Add = new System.Windows.Forms.TextBox();
            this.textBox_Name_Add = new System.Windows.Forms.TextBox();
            this.button_List_Save = new System.Windows.Forms.Button();
            this.label_List_List = new System.Windows.Forms.Label();
            this.label_Picture_List = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Setup)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ScanAttend)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CreateList)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(353, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 434);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_Save);
            this.tabPage1.Controls.Add(this.label_outLoc);
            this.tabPage1.Controls.Add(this.label_list);
            this.tabPage1.Controls.Add(this.button_save);
            this.tabPage1.Controls.Add(this.button_outLocation);
            this.tabPage1.Controls.Add(this.button_list);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(345, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_Save
            // 
            this.label_Save.AutoSize = true;
            this.label_Save.Location = new System.Drawing.Point(106, 72);
            this.label_Save.Name = "label_Save";
            this.label_Save.Size = new System.Drawing.Size(0, 13);
            this.label_Save.TabIndex = 3;
            // 
            // label_outLoc
            // 
            this.label_outLoc.AutoSize = true;
            this.label_outLoc.Location = new System.Drawing.Point(107, 42);
            this.label_outLoc.Name = "label_outLoc";
            this.label_outLoc.Size = new System.Drawing.Size(0, 13);
            this.label_outLoc.TabIndex = 3;
            // 
            // label_list
            // 
            this.label_list.AutoSize = true;
            this.label_list.Location = new System.Drawing.Point(107, 12);
            this.label_list.Name = "label_list";
            this.label_list.Size = new System.Drawing.Size(0, 13);
            this.label_list.TabIndex = 3;
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(9, 67);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(91, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Batch Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_outLocation
            // 
            this.button_outLocation.Enabled = false;
            this.button_outLocation.Location = new System.Drawing.Point(9, 37);
            this.button_outLocation.Name = "button_outLocation";
            this.button_outLocation.Size = new System.Drawing.Size(91, 23);
            this.button_outLocation.TabIndex = 1;
            this.button_outLocation.Text = "Output Location";
            this.button_outLocation.UseVisualStyleBackColor = true;
            this.button_outLocation.Click += new System.EventHandler(this.button_imageOutLocation_Click);
            // 
            // button_list
            // 
            this.button_list.Location = new System.Drawing.Point(9, 7);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(91, 23);
            this.button_list.TabIndex = 0;
            this.button_list.Text = "Master List";
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox_Setup);
            this.tabPage4.Controls.Add(this.comboBox_videoSource);
            this.tabPage4.Controls.Add(this.button_selectWebcam);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(345, 408);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Webcam Setup";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Setup
            // 
            this.pictureBox_Setup.Location = new System.Drawing.Point(9, 41);
            this.pictureBox_Setup.Name = "pictureBox_Setup";
            this.pictureBox_Setup.Size = new System.Drawing.Size(132, 98);
            this.pictureBox_Setup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Setup.TabIndex = 11;
            this.pictureBox_Setup.TabStop = false;
            // 
            // comboBox_videoSource
            // 
            this.comboBox_videoSource.FormattingEnabled = true;
            this.comboBox_videoSource.Location = new System.Drawing.Point(8, 13);
            this.comboBox_videoSource.Name = "comboBox_videoSource";
            this.comboBox_videoSource.Size = new System.Drawing.Size(267, 21);
            this.comboBox_videoSource.TabIndex = 10;
            // 
            // button_selectWebcam
            // 
            this.button_selectWebcam.Location = new System.Drawing.Point(147, 40);
            this.button_selectWebcam.Name = "button_selectWebcam";
            this.button_selectWebcam.Size = new System.Drawing.Size(121, 23);
            this.button_selectWebcam.TabIndex = 9;
            this.button_selectWebcam.Text = "Select Device";
            this.button_selectWebcam.UseVisualStyleBackColor = true;
            this.button_selectWebcam.Click += new System.EventHandler(this.button_selectWebcam_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label_Attend_Absent);
            this.tabPage2.Controls.Add(this.label_Attend_Present);
            this.tabPage2.Controls.Add(this.label_Attend_Picture);
            this.tabPage2.Controls.Add(this.button_Save_Attend);
            this.tabPage2.Controls.Add(this.button_Attend_Present);
            this.tabPage2.Controls.Add(this.textBox_Kill_Attend);
            this.tabPage2.Controls.Add(this.textBox_Name_Attend);
            this.tabPage2.Controls.Add(this.listView_Attend_Absent);
            this.tabPage2.Controls.Add(this.listView_Attend_Present);
            this.tabPage2.Controls.Add(this.label_Kill_Attend);
            this.tabPage2.Controls.Add(this.label_Name_Attend);
            this.tabPage2.Controls.Add(this.pictureBox_ScanAttend);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(345, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attendance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_Attend_Absent
            // 
            this.label_Attend_Absent.AutoSize = true;
            this.label_Attend_Absent.Location = new System.Drawing.Point(182, 172);
            this.label_Attend_Absent.Name = "label_Attend_Absent";
            this.label_Attend_Absent.Size = new System.Drawing.Size(40, 13);
            this.label_Attend_Absent.TabIndex = 13;
            this.label_Attend_Absent.Text = "Absent";
            // 
            // label_Attend_Present
            // 
            this.label_Attend_Present.AutoSize = true;
            this.label_Attend_Present.Location = new System.Drawing.Point(7, 172);
            this.label_Attend_Present.Name = "label_Attend_Present";
            this.label_Attend_Present.Size = new System.Drawing.Size(43, 13);
            this.label_Attend_Present.TabIndex = 13;
            this.label_Attend_Present.Text = "Present";
            // 
            // label_Attend_Picture
            // 
            this.label_Attend_Picture.AutoSize = true;
            this.label_Attend_Picture.Location = new System.Drawing.Point(7, 105);
            this.label_Attend_Picture.Name = "label_Attend_Picture";
            this.label_Attend_Picture.Size = new System.Drawing.Size(13, 13);
            this.label_Attend_Picture.TabIndex = 12;
            this.label_Attend_Picture.Text = "_";
            // 
            // button_Save_Attend
            // 
            this.button_Save_Attend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save_Attend.Location = new System.Drawing.Point(236, 379);
            this.button_Save_Attend.Name = "button_Save_Attend";
            this.button_Save_Attend.Size = new System.Drawing.Size(101, 23);
            this.button_Save_Attend.TabIndex = 11;
            this.button_Save_Attend.Text = "Save Absentees";
            this.button_Save_Attend.UseVisualStyleBackColor = true;
            this.button_Save_Attend.Click += new System.EventHandler(this.button_Save_Attend_Click);
            // 
            // button_Attend_Present
            // 
            this.button_Attend_Present.Location = new System.Drawing.Point(262, 96);
            this.button_Attend_Present.Name = "button_Attend_Present";
            this.button_Attend_Present.Size = new System.Drawing.Size(75, 23);
            this.button_Attend_Present.TabIndex = 10;
            this.button_Attend_Present.Text = "Remove";
            this.button_Attend_Present.UseVisualStyleBackColor = true;
            this.button_Attend_Present.Click += new System.EventHandler(this.button_Attend_Present_Click);
            // 
            // textBox_Kill_Attend
            // 
            this.textBox_Kill_Attend.Location = new System.Drawing.Point(200, 70);
            this.textBox_Kill_Attend.Name = "textBox_Kill_Attend";
            this.textBox_Kill_Attend.Size = new System.Drawing.Size(137, 20);
            this.textBox_Kill_Attend.TabIndex = 9;
            // 
            // textBox_Name_Attend
            // 
            this.textBox_Name_Attend.Location = new System.Drawing.Point(200, 41);
            this.textBox_Name_Attend.Name = "textBox_Name_Attend";
            this.textBox_Name_Attend.Size = new System.Drawing.Size(137, 20);
            this.textBox_Name_Attend.TabIndex = 9;
            // 
            // listView_Attend_Absent
            // 
            this.listView_Attend_Absent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_Attend_Absent.Location = new System.Drawing.Point(185, 191);
            this.listView_Attend_Absent.Name = "listView_Attend_Absent";
            this.listView_Attend_Absent.Size = new System.Drawing.Size(152, 182);
            this.listView_Attend_Absent.TabIndex = 8;
            this.listView_Attend_Absent.UseCompatibleStateImageBehavior = false;
            this.listView_Attend_Absent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kill ID";
            this.columnHeader2.Width = 58;
            // 
            // listView_Attend_Present
            // 
            this.listView_Attend_Present.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_ID});
            this.listView_Attend_Present.Location = new System.Drawing.Point(6, 191);
            this.listView_Attend_Present.Name = "listView_Attend_Present";
            this.listView_Attend_Present.Size = new System.Drawing.Size(152, 182);
            this.listView_Attend_Present.TabIndex = 8;
            this.listView_Attend_Present.UseCompatibleStateImageBehavior = false;
            this.listView_Attend_Present.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 88;
            // 
            // columnHeader_ID
            // 
            this.columnHeader_ID.Text = "Kill ID";
            this.columnHeader_ID.Width = 63;
            // 
            // label_Kill_Attend
            // 
            this.label_Kill_Attend.AutoSize = true;
            this.label_Kill_Attend.Location = new System.Drawing.Point(198, 22);
            this.label_Kill_Attend.Name = "label_Kill_Attend";
            this.label_Kill_Attend.Size = new System.Drawing.Size(37, 13);
            this.label_Kill_Attend.TabIndex = 7;
            this.label_Kill_Attend.Text = "Kill ID:";
            // 
            // label_Name_Attend
            // 
            this.label_Name_Attend.AutoSize = true;
            this.label_Name_Attend.Location = new System.Drawing.Point(197, 6);
            this.label_Name_Attend.Name = "label_Name_Attend";
            this.label_Name_Attend.Size = new System.Drawing.Size(38, 13);
            this.label_Name_Attend.TabIndex = 6;
            this.label_Name_Attend.Text = "Name:";
            // 
            // pictureBox_ScanAttend
            // 
            this.pictureBox_ScanAttend.Location = new System.Drawing.Point(6, 6);
            this.pictureBox_ScanAttend.Name = "pictureBox_ScanAttend";
            this.pictureBox_ScanAttend.Size = new System.Drawing.Size(152, 92);
            this.pictureBox_ScanAttend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ScanAttend.TabIndex = 4;
            this.pictureBox_ScanAttend.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label_Picture_List);
            this.tabPage3.Controls.Add(this.button_List_Save);
            this.tabPage3.Controls.Add(this.button_List_Add);
            this.tabPage3.Controls.Add(this.textBox_Kill_Add);
            this.tabPage3.Controls.Add(this.textBox_Name_Add);
            this.tabPage3.Controls.Add(this.listView_List);
            this.tabPage3.Controls.Add(this.label_List_List);
            this.tabPage3.Controls.Add(this.label_Kill_List);
            this.tabPage3.Controls.Add(this.label_Name_List);
            this.tabPage3.Controls.Add(this.pictureBox_CreateList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(345, 408);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label_Kill_List
            // 
            this.label_Kill_List.AutoSize = true;
            this.label_Kill_List.Location = new System.Drawing.Point(164, 29);
            this.label_Kill_List.Name = "label_Kill_List";
            this.label_Kill_List.Size = new System.Drawing.Size(37, 13);
            this.label_Kill_List.TabIndex = 10;
            this.label_Kill_List.Text = "Kill ID:";
            // 
            // label_Name_List
            // 
            this.label_Name_List.AutoSize = true;
            this.label_Name_List.Location = new System.Drawing.Point(164, 6);
            this.label_Name_List.Name = "label_Name_List";
            this.label_Name_List.Size = new System.Drawing.Size(38, 13);
            this.label_Name_List.TabIndex = 9;
            this.label_Name_List.Text = "Name:";
            // 
            // pictureBox_CreateList
            // 
            this.pictureBox_CreateList.Location = new System.Drawing.Point(6, 6);
            this.pictureBox_CreateList.Name = "pictureBox_CreateList";
            this.pictureBox_CreateList.Size = new System.Drawing.Size(152, 92);
            this.pictureBox_CreateList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CreateList.TabIndex = 8;
            this.pictureBox_CreateList.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView_List
            // 
            this.listView_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView_List.Location = new System.Drawing.Point(6, 142);
            this.listView_List.Name = "listView_List";
            this.listView_List.Size = new System.Drawing.Size(152, 276);
            this.listView_List.TabIndex = 11;
            this.listView_List.UseCompatibleStateImageBehavior = false;
            this.listView_List.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kill ID";
            this.columnHeader4.Width = 58;
            // 
            // button_List_Add
            // 
            this.button_List_Add.Location = new System.Drawing.Point(226, 100);
            this.button_List_Add.Name = "button_List_Add";
            this.button_List_Add.Size = new System.Drawing.Size(75, 23);
            this.button_List_Add.TabIndex = 14;
            this.button_List_Add.Text = "Add";
            this.button_List_Add.UseVisualStyleBackColor = true;
            this.button_List_Add.Click += new System.EventHandler(this.button_List_Add_Click);
            // 
            // textBox_Kill_Add
            // 
            this.textBox_Kill_Add.Location = new System.Drawing.Point(164, 74);
            this.textBox_Kill_Add.Name = "textBox_Kill_Add";
            this.textBox_Kill_Add.Size = new System.Drawing.Size(137, 20);
            this.textBox_Kill_Add.TabIndex = 13;
            // 
            // textBox_Name_Add
            // 
            this.textBox_Name_Add.Location = new System.Drawing.Point(164, 45);
            this.textBox_Name_Add.Name = "textBox_Name_Add";
            this.textBox_Name_Add.Size = new System.Drawing.Size(137, 20);
            this.textBox_Name_Add.TabIndex = 12;
            // 
            // button_List_Save
            // 
            this.button_List_Save.Location = new System.Drawing.Point(262, 382);
            this.button_List_Save.Name = "button_List_Save";
            this.button_List_Save.Size = new System.Drawing.Size(75, 23);
            this.button_List_Save.TabIndex = 14;
            this.button_List_Save.Text = "Save";
            this.button_List_Save.UseVisualStyleBackColor = true;
            // 
            // label_List_List
            // 
            this.label_List_List.AutoSize = true;
            this.label_List_List.Location = new System.Drawing.Point(121, 126);
            this.label_List_List.Name = "label_List_List";
            this.label_List_List.Size = new System.Drawing.Size(37, 13);
            this.label_List_List.TabIndex = 10;
            this.label_List_List.Text = "Kill ID:";
            // 
            // label_Picture_List
            // 
            this.label_Picture_List.AutoSize = true;
            this.label_Picture_List.Location = new System.Drawing.Point(8, 100);
            this.label_Picture_List.Name = "label_Picture_List";
            this.label_Picture_List.Size = new System.Drawing.Size(13, 13);
            this.label_Picture_List.TabIndex = 15;
            this.label_Picture_List.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 456);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Setup)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ScanAttend)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CreateList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label_Save;
        private System.Windows.Forms.Label label_outLoc;
        private System.Windows.Forms.Label label_list;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_outLocation;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox_Setup;
        private System.Windows.Forms.ComboBox comboBox_videoSource;
        private System.Windows.Forms.Button button_selectWebcam;
        private System.Windows.Forms.Label label_Kill_Attend;
        private System.Windows.Forms.PictureBox pictureBox_ScanAttend;
        private System.Windows.Forms.Label label_Kill_List;
        private System.Windows.Forms.Label label_Name_List;
        private System.Windows.Forms.PictureBox pictureBox_CreateList;
        private System.Windows.Forms.ListView listView_Attend_Present;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_ID;
        private System.Windows.Forms.TextBox textBox_Kill_Attend;
        private System.Windows.Forms.TextBox textBox_Name_Attend;
        private System.Windows.Forms.Button button_Attend_Present;
        private System.Windows.Forms.Button button_Save_Attend;
        private System.Windows.Forms.ListView listView_Attend_Absent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label_Name_Attend;
        private System.Windows.Forms.Label label_Attend_Picture;
        private System.Windows.Forms.Label label_Attend_Absent;
        private System.Windows.Forms.Label label_Attend_Present;
        private System.Windows.Forms.Button button_List_Save;
        private System.Windows.Forms.Button button_List_Add;
        private System.Windows.Forms.TextBox textBox_Kill_Add;
        private System.Windows.Forms.TextBox textBox_Name_Add;
        private System.Windows.Forms.ListView listView_List;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label_List_List;
        private System.Windows.Forms.Label label_Picture_List;
    }
}

