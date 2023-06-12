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
    public partial class resetPassword : Form
    {
        public resetPassword()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_newpass.PasswordChar = '\0';
                txt_confirmnew.PasswordChar = '\0';
            }
            else
            {
                txt_newpass.PasswordChar = '*';
                txt_confirmnew .PasswordChar = '*'; 
            }
        }
    }
}
