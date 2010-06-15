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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
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
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 240);
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
            this.tabPage1.Size = new System.Drawing.Size(276, 214);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attendance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(276, 214);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
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
    }
}

