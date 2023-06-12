using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_design
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_password.PasswordChar = '\0';
                txt_confirm.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
                txt_confirm .PasswordChar = '*';
            }
        }

        private void checkBox_male_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_male.Checked)
            {
                checkBox_female.Enabled = false;
                checkBox_other.Enabled = false;
            }
            else
            {
                checkBox_female.Enabled = true;
                checkBox_other.Enabled = true;
            }
        }

        private void checkBox_female_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_female.Checked)
            {
                checkBox_male.Enabled = false;
                checkBox_other.Enabled = false;
            }
            else
            {
                checkBox_male.Enabled = true;
                checkBox_other.Enabled = true;
            }
        }

        private void checkBox_other_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_other.Checked)
            {
                checkBox_male.Enabled = false;
                checkBox_female.Enabled = false;
            }
            else
            {
                checkBox_male.Enabled = true;
                checkBox_female.Enabled = true;
            }
        }
    }
}
