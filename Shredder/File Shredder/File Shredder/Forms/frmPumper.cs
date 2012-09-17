using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Chemiculs.IO;
namespace File_Shredder.Forms
{
    public partial class frmPumper : Form
    {
        private byte _Value;
        private long _Size;
        private string _Path = "";
        public frmPumper()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Registering settings...";
            if (_Path.Length > 0)
            {
                if (System.IO.File.Exists(_Path))
                {
                    if (cBytes.Checked)
                    {
                        _Size = (long)numSize.Value;
                    }
                    if (cKilobytes.Checked)
                    {
                        _Size = (long)(numSize.Value * 1000);
                    }
                    if (cMegabytes.Checked)
                    {
                        _Size = (long)(numSize.Value * 1000000);
                    }
                    if (cGigs.Checked)
                    {
                        _Size = (long)(numSize.Value * 1000000000);
                    }
                    if (cValue.Checked)
                    {
                        _Value = (byte)numValue.Value;
                    }
                    if (cRand.Checked)
                    {
                        _Value = (byte)(new Random().Next(0, 255));
                    }
                    lblStatus.Text = "Pumping file, Size = " + Utils.GetLength(_Size) + " , Value = 0x" + _Value.ToString("X2");
                    button2.Enabled = false;
                    BWPumper.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("File does not exist");
                }
            }
            else
            {
                MessageBox.Show("Open a file first");
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _Path = ofd.FileName;
                txtFile.Text = _Path;
            }
        }
        private void BWPumper_DoWork(object sender, DoWorkEventArgs e)
        {
            using (FileStreamEx Pumper = new FileStreamEx(_Path, System.IO.FileMode.Open))
            {
                long Progress = 0;
                int Blocksize = 65536;
                byte[] buffer = new byte[Blocksize];
                Pumper.Position = Pumper.Length;
                Utils.FillBuffer(ref buffer, _Value);
                while (Progress < _Size)
                {
                    if (Progress + Blocksize <= Pumper.Length)
                    {
                        Pumper.Write(buffer);
                        Progress += Blocksize;
                    }
                    else
                    {
                        int Remaining = (int)(_Size - Progress);
                        byte[] LastBuffer = new byte[Remaining];
                        Utils.FillBuffer(ref LastBuffer, _Value);
                        Pumper.Write(LastBuffer);
                        Progress += Remaining;
                    }
                }
            }
        }
        private void frmPumper_Load(object sender, EventArgs e)
        {
            numSize.Maximum = long.MaxValue;
        }
        private void cValue_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            if (btn.Checked)
            {
                numValue.Enabled = true;
            }
            else
            {
                numValue.Enabled = false;
            }
        }

        private void BWPumper_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "File Pumped, Idle";
            button2.Enabled = true;
        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
