using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool dragging;
        Point offset;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            panel8.Visible = true;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            timer1.Enabled = true;
            timer1.Start();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            button1.ForeColor = Color.LightBlue;
            panel8.Visible = true;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            button2.ForeColor = Color.LightBlue;
            panel8.Visible = false;
            panel9.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.LightBlue;
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            button2.ForeColor = Color.LightBlue;
            panel8.Visible = false;
            panel9.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.LightBlue;
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            button1.ForeColor = Color.LightBlue;
            panel8.Visible = true;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            button3.ForeColor = Color.LightBlue;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = true;
            panel11.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.LightBlue;
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            button3.ForeColor = Color.LightBlue;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = true;
            panel11.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.LightBlue;
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
            button4.ForeColor = Color.LightBlue;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
            button4.ForeColor = Color.LightBlue;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = true;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

        private void panel5_DoubleClick(object sender, EventArgs e)
        {
           
            
            this.WindowState = FormWindowState.Maximized;
        }


        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(44, 41, 51);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(44, 41, 51);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.FromArgb(44, 41, 51);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.FromArgb(44, 41, 51);
        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_MouseHover_2(object sender, EventArgs e)
        {
            pictureBox1.Image = Dosyalar.exitw;
        }

        private void pictureBox1_MouseLeave_2(object sender, EventArgs e)
        {
            pictureBox1.Image = Dosyalar.exit;
        }

        private void pictureBox2_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox2.Image = Dosyalar.diminish__1_;
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.Image = Dosyalar.diminish;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = Dosyalar.menubar;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Dosyalar.menubarstop;
        }

        /* null functions is deleted */

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
            }
        }

     

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random rd = new Random();
            pictureBox8.Left += rd.Next(0, 4);
           


        }
    }
    }

