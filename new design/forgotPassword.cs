﻿using System;
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
    public partial class forgotPassword : Form
    {
        ApiService apiService = new ApiService();
        public static string enteredEmail { get; set; }
        public forgotPassword()
        {
            InitializeComponent();
        }

        private async void btn_send_Click(object sender, EventArgs e)
        {
            bool resetRes = await apiService.ForgotPassword(txt_email.Text);
            enteredEmail = txt_email.Text;

            if (resetRes)
            {
                OTP authOTP = new OTP();
                authOTP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
