using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Chemiculs.IO;
using System.IO;
namespace File_Shredder
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void OpenAndShred(string Filepath)
        {
            Globalvariables.Filepath = Filepath;
            Log(Filepath + " Opened");
            FileInfo f = new FileInfo(Filepath);
            Log("File size -  " + Utils.GetLength(f.Length));
            Log("Extension -  " + f.Extension);
            Log("Starting wipe...");
            ShredderBW.RunWorkerAsync();
        }
        public void ClearLog()
        {
            richTextBox1.Invoke(new MethodInvoker(delegate
            {
                richTextBox1.Text = "";
            }));
        }
        public void Log(string Text)
        {
            richTextBox1.Invoke(new MethodInvoker(delegate
            {
                richTextBox1.Text += (Text + Environment.NewLine);
            }));
        }
        private void ShredderBW_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Globalvariables.Filepath.Length == 0)
            {
                Log("No file open!");
            }
            else
            {
                Log("Initializing stream...");
                for (int i = 0; i < Globalvariables.Passes.Count; i++)
                {
                    byte val = Globalvariables.Passes[i];
                    using (FileStreamEx Wiper = new FileStreamEx(Globalvariables.Filepath, System.IO.FileMode.Open))
                    {
                        Log("Executing Pass " + (i + 1).ToString() + " - 0x" + val.ToString("X2"));
                        if (Globalvariables.FullBuffer)
                        {
                            byte[] buffer = new byte[Wiper.Length];
                            Utils.FillBuffer(ref buffer, val);
                            Wiper.Write(buffer);
                        }
                        if(Globalvariables.CustomBuffer)
                        {
                            int Blocksize = Globalvariables.BufferSize;
                            long Progress = 0;
                            byte[] buffer = new byte[Blocksize];
                            Utils.FillBuffer(ref buffer, val);
                            while (Progress < Wiper.Length)
                            {
                                if ((Progress + Blocksize) <= Wiper.Length)
                                {
                                    Wiper.Write(buffer);
                                    Progress += Blocksize;
                                }
                                else
                                {
                                    int Remaining = (int)(Wiper.Length - Progress);
                                    byte[] FinalBlock = new byte[Remaining];
                                    Utils.FillBuffer(ref FinalBlock, val);
                                    Wiper.Write(FinalBlock);
                                    Progress += Remaining;
                                }
                            }
                        }
                        if (Globalvariables.OneByte)
                        {
                            while (!Wiper.eof())
                            {
                                Wiper.Write(val);
                            }
                        }
                    }
                }
            }
        }
        private void ShredderBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Log("File succesfully wiped!");
            if (Globalvariables.Delete)
            {
                File.Delete(Globalvariables.Filepath);
                Globalvariables.Filepath = "";
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Globalvariables.Passes.Add(0);
            Log("Welcome to the file shredder!" + " Version : " + Application.ProductVersion);
            Log("Writing Mode : Buffered");
        }
        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            { 
                e.Effect = DragDropEffects.All; 
            }
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] Files = (string[])e.Data.GetData(DataFormats.FileDrop);
            OpenAndShred(Files[0]);
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition);
            }
        }
        private void menuItem11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Chemiculs from HF");
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            new Forms.frmOptions().ShowDialog();
        }
        private void menuItem9_Click(object sender, EventArgs e)
        {
            ClearLog();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenAndShred(ofd.FileName);
            }
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            new Forms.frmComparer().ShowDialog();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            new Forms.frmPumper().ShowDialog();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
