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
    public partial class Main_Form : Form
    {
        public bool Second_Form = false;
        Second_Form form2 = new Second_Form();
        public Main_Form()
        {
            InitializeComponent();
        }

        private void checkBox_True1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_True1.Checked)
            {
                button_Submit.Enabled = true;
            }
            else if (checkBox_True1.Checked == false)
            {
                button_Submit.Enabled = false;
            }
        }

        private void button_NextForm_Click(object sender, EventArgs e)
        {
            form2.Show(this);
            Second_Form = true;
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (Second_Form == true && textBox_Name.Text != "" && textBox_FavArtist.Text != "")
            {
                
                form2.labelTerisi(textBox_Name.Text, textBox_FavArtist.Text);
            }
            else
            {
                MessageBox.Show("PLEASE ENTER THE CORRECT INPUT");
            }
        }
    }
}
