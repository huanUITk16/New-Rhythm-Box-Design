using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_design
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private int borderSize = 2;
        private Size formSize;
        private Panel leftBorderBtn;
       
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
          

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel_introduction_Paint(object sender, PaintEventArgs e)
        {

        }
        bool userExpand = true;
        private void menu_transition_Tick(object sender, EventArgs e)
        {
            
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_user_Click_1(object sender, EventArgs e)
        {
            userTransition.Start();
        }

        private void userTransition_Tick(object sender, EventArgs e)
        {
            if (userExpand == false)
            {
                userContainer.Height += 10;
                if (userContainer.Height >= 173)
                {
                    userTransition.Stop();
                    userExpand = true;
                }
            }
            else
            {
                userContainer.Height -= 10;
                if (userContainer.Height <= 45)
                {
                    userTransition.Stop();
                    userExpand = false;
                }
            }
        }
        bool menuExpand = true;
        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                menuPanel.Width -= 10;
                if (menuPanel.Width <= 65)
                {
                    menuExpand = false;
                    menuTransition.Stop();
                }
            }
            else 
            {
                menuPanel.Width += 10;
                if (menuPanel.Width >= 200)
                {
                    menuExpand = true;
                    menuTransition.Stop();
                }
            }
                
            }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

