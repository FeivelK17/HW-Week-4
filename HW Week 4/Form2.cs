using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Week_4
{
    public partial class Second_Form : Form
    {
        public Second_Form()
        {
            InitializeComponent();
        }

        private void button_Magic_Click(object sender, EventArgs e)
        {
            Main_Form form1 = (Main_Form)this.Owner;
            
            bool backColor = true;
            bool txtColor = true;
            
            if (radioButton_Red1.Checked == false && radioButton_Blue1.Checked == false && radioButton_Green1.Checked == false && radioButton_Orange1.Checked == false && radioButton_Purple1.Checked == false)
            {
                backColor = false;
            }
            if (radioButton_Red2.Checked == false && radioButton_Green2.Checked == false && radioButton_Black2.Checked == false)
            {
                txtColor = false;
            }

            if (backColor == true || txtColor == true)
            {
                if (radioButton_Red1.Checked)
                {
                    form1.BackColor = Color.Red;
                }
                if (radioButton_Green1.Checked)
                {
                    form1.BackColor = Color.Green;
                }
                if (radioButton_Blue1.Checked)
                {
                    form1.BackColor = Color.Blue;
                }
                if (radioButton_Purple1.Checked)
                {
                    form1.BackColor = Color.Purple;
                }
                if (radioButton_Orange1.Checked)
                {
                    form1.BackColor = Color.Orange;
                }

                if (radioButton_Red2.Checked)
                {
                    form1.ForeColor = Color.Red;
                }
                if (radioButton_Green2.Checked)
                {
                    form1.ForeColor = Color.Green;
                }
                if (radioButton_Black2.Checked)
                {
                    form1.ForeColor = Color.Black;
                }
                
            }
        }

        private void checkBox_Agree2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Agree2.Checked && checkBox_True2.Checked)
            {
                button_Magic.Enabled = true;
            }
            if (checkBox_Agree2.Checked == false && checkBox_True2.Checked == false)
            {
                button_Magic.Enabled = false;
            }
        }

        private void checkBox_True2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Agree2.Checked && checkBox_True2.Checked)
            {
                button_Magic.Enabled = true;
            }
            if (checkBox_Agree2.Checked == false && checkBox_True2.Checked == false)
            {
                button_Magic.Enabled = false;
            }
        }

        public void labelTerisi (string Name, string ArtistName)
        {
            label_Hasil.Text = ("Hi, my name is " + Name + " and my favorite artist is " + ArtistName);
        }
    }
}
