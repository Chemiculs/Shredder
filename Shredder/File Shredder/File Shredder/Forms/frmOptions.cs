using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace File_Shredder.Forms
{
    public partial class frmOptions : Form
    {
        int CurrentPasses = Globalvariables.Passes.Count;
        public frmOptions()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globalvariables.Delete = checkBox1.Checked;
            Globalvariables.FullBuffer = checkFull.Checked;
            Globalvariables.OneByte = checkOne.Checked;
            Globalvariables.CustomBuffer = checkBuff.Checked;
            if (checkBuff.Checked)
            {
                Globalvariables.BufferSize = (int)numericUpDown2.Value;
            }
            DialogResult = DialogResult.OK;
        }
        private void frmOptions_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            checkBox1.Checked = Globalvariables.Delete;
            checkBuff.Checked = Globalvariables.CustomBuffer;
            checkFull.Checked = Globalvariables.FullBuffer;
            checkOne.Checked = Globalvariables.OneByte;
            for (int i = 0; i < Globalvariables.Passes.Count; i++)
            {
                string Name = "Pass " + (i + 1).ToString();
                ListViewItem Item = new ListViewItem(Name);
                Item.Tag = i;
                listView1.Items.Add(Item);
            }
            listView1.Select();
            listView1.Items[0].Selected = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Name = "Pass " + (Globalvariables.Passes.Count + 1).ToString();
            ListViewItem Item = new ListViewItem(Name);
            Item.Tag = Globalvariables.Passes.Count + 1;
            Globalvariables.Passes.Add(0);
            listView1.Items.Add(Item);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                Globalvariables.Passes.RemoveAt(listView1.SelectedIndices[0]);
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                btnDelete.Enabled = listView1.SelectedItems[0].Text == "Pass 1" ? false : true;
                numericUpDown1.Enabled = true;
                numericUpDown1.Value = Globalvariables.Passes[listView1.SelectedIndices[0]];
            }
            else
            {
                numericUpDown1.Enabled = false;
                numericUpDown1.Value = 0;
                btnDelete.Enabled = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (numericUpDown1.Value <= 255 && numericUpDown1.Value > -1)
                {
                    Globalvariables.Passes[listView1.SelectedIndices[0]] = (byte)numericUpDown1.Value;
                }
                else
                {
                    Globalvariables.Passes[(int)listView1.SelectedItems[0].Tag] = 255;
                }
            }
        }

        private void checkBuff_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton b = (RadioButton)sender;
            if (b.Checked)
            {
                label3.Enabled = true;
                numericUpDown2.Enabled = true;
            }
        }

        private void checkFull_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton b = (RadioButton)sender;
            if (b.Checked)
            {
                label3.Enabled = false;
                numericUpDown2.Enabled = false;
            }
        }

        private void checkOne_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton b = (RadioButton)sender;
            if (b.Checked)
            {
                label3.Enabled = false;
                numericUpDown2.Enabled = false;
            }
        }

    }
}
