using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Chemiculs.IO;
using System.IO;
namespace File_Shredder.Forms
{
    public partial class frmComparer : Form
    {
        public frmComparer()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                if (textBox1.Text != textBox2.Text)
                {
                    bool Same = Utils.FileCompare(textBox1.Text, textBox2.Text);
                    switch (Same)
                    { 
                        case true:
                            MessageBox.Show("The chosen files are identical");
                            break;
                        case false:
                            MessageBox.Show("The chosen files are not the same");
                            break;
                    }
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Source and target files cannot be the same!");
                }
            }
            else
            {
                MessageBox.Show("Please select two files!");
            }
        }
    }
}
