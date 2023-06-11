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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        bool menuExpand = true;
        bool artistExpand = true;
        private void artistTransition_Tick(object sender, EventArgs e)
        {
            if (artistExpand == false)
            {
                userContainer.Height += 10;
                if (userContainer.Height >= 270)
                {
                    artistTransition.Stop();
                    artistExpand = true;
                }
            }
            else
            {
                userContainer.Height -= 10;
                if (userContainer.Height <= 45)
                {
                    artistTransition.Stop();
                    artistExpand = false;
                }
            }
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                menuPanel.Width -= 10;
                if (menuPanel.Width <= 60)
                {
                    menuExpand = false;
                    menuTransition.Stop();
                }
            }
            else
            {
                menuPanel.Width += 10;
                if (menuPanel.Width >= 220)
                {
                    menuExpand = true;
                    menuTransition.Stop();
                }
            }
        }
    }
}
