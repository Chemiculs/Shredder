namespace File_Shredder.Forms
{
    partial class frmPumper
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cGigs = new System.Windows.Forms.RadioButton();
            this.cMegabytes = new System.Windows.Forms.RadioButton();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.cBytes = new System.Windows.Forms.RadioButton();
            this.cKilobytes = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numValue = new System.Windows.Forms.NumericUpDown();
            this.cRand = new System.Windows.Forms.RadioButton();
            this.cValue = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BWPumper = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(236, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 21);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(6, 19);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(224, 20);
            this.txtFile.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFile);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cGigs);
            this.groupBox2.Controls.Add(this.cMegabytes);
            this.groupBox2.Controls.Add(this.numSize);
            this.groupBox2.Controls.Add(this.cBytes);
            this.groupBox2.Controls.Add(this.cKilobytes);
            this.groupBox2.Location = new System.Drawing.Point(1, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 65);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size Info";
            // 
            // cGigs
            // 
            this.cGigs.AutoSize = true;
            this.cGigs.Location = new System.Drawing.Point(253, 42);
            this.cGigs.Name = "cGigs";
            this.cGigs.Size = new System.Drawing.Size(72, 17);
            this.cGigs.TabIndex = 4;
            this.cGigs.Text = "Gigabytes";
            this.cGigs.UseVisualStyleBackColor = true;
            // 
            // cMegabytes
            // 
            this.cMegabytes.AutoSize = true;
            this.cMegabytes.Location = new System.Drawing.Point(177, 42);
            this.cMegabytes.Name = "cMegabytes";
            this.cMegabytes.Size = new System.Drawing.Size(77, 17);
            this.cMegabytes.TabIndex = 3;
            this.cMegabytes.Text = "Megabytes";
            this.cMegabytes.UseVisualStyleBackColor = true;
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(11, 28);
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(160, 20);
            this.numSize.TabIndex = 2;
            this.numSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
            // 
            // cBytes
            // 
            this.cBytes.AutoSize = true;
            this.cBytes.Location = new System.Drawing.Point(177, 19);
            this.cBytes.Name = "cBytes";
            this.cBytes.Size = new System.Drawing.Size(51, 17);
            this.cBytes.TabIndex = 1;
            this.cBytes.Text = "Bytes";
            this.cBytes.UseVisualStyleBackColor = true;
            // 
            // cKilobytes
            // 
            this.cKilobytes.AutoSize = true;
            this.cKilobytes.Checked = true;
            this.cKilobytes.Location = new System.Drawing.Point(252, 19);
            this.cKilobytes.Name = "cKilobytes";
            this.cKilobytes.Size = new System.Drawing.Size(67, 17);
            this.cKilobytes.TabIndex = 0;
            this.cKilobytes.TabStop = true;
            this.cKilobytes.Text = "Kilobytes";
            this.cKilobytes.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numValue);
            this.groupBox3.Controls.Add(this.cRand);
            this.groupBox3.Controls.Add(this.cValue);
            this.groupBox3.Location = new System.Drawing.Point(1, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 67);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pumper value";
            // 
            // numValue
            // 
            this.numValue.Enabled = false;
            this.numValue.Location = new System.Drawing.Point(6, 41);
            this.numValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(305, 20);
            this.numValue.TabIndex = 4;
            // 
            // cRand
            // 
            this.cRand.AutoSize = true;
            this.cRand.Checked = true;
            this.cRand.Location = new System.Drawing.Point(170, 19);
            this.cRand.Name = "cRand";
            this.cRand.Size = new System.Drawing.Size(141, 17);
            this.cRand.TabIndex = 3;
            this.cRand.TabStop = true;
            this.cRand.Text = "Pump with random value";
            this.cRand.UseVisualStyleBackColor = true;
            // 
            // cValue
            // 
            this.cValue.AutoSize = true;
            this.cValue.Location = new System.Drawing.Point(6, 19);
            this.cValue.Name = "cValue";
            this.cValue.Size = new System.Drawing.Size(128, 17);
            this.cValue.TabIndex = 2;
            this.cValue.Text = "Pump with this value :";
            this.cValue.UseVisualStyleBackColor = true;
            this.cValue.CheckedChanged += new System.EventHandler(this.cValue_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Pump";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "&Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BWPumper
            // 
            this.BWPumper.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWPumper_DoWork);
            this.BWPumper.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWPumper_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 223);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(329, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Status : ";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 17);
            this.lblStatus.Text = "Idle";
            // 
            // frmPumper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 245);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPumper";
            this.Text = "File Pumper";
            this.Load += new System.EventHandler(this.frmPumper_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton cGigs;
        private System.Windows.Forms.RadioButton cMegabytes;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.RadioButton cBytes;
        private System.Windows.Forms.RadioButton cKilobytes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numValue;
        private System.Windows.Forms.RadioButton cRand;
        private System.Windows.Forms.RadioButton cValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker BWPumper;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}