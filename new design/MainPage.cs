using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_design
{
    public partial class MainPage : Form
    {
        private Size formOriginalSize;

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
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

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
                if (userContainer.Height >= 160)
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
                if (menuPanel.Width <= 70)
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
        
        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
        
        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            loadform(new ProfileNew());
            
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            loadform(new SettingsNew());
        }

        private void btn_album_Click(object sender, EventArgs e)
        {
            loadform(new AlbumNew());
        }

        private void btn_artist_Click(object sender, EventArgs e)
        {
            loadform(new ArtistNew());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            loadform(new HomeNew());
        }

        private void btn_playlist_Click(object sender, EventArgs e)
        {
            loadform(new PlaylistNew());
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

