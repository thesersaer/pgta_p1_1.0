using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;

namespace Graphics
{
    public partial class Form1 : Form
    {
        AsterixFile asterixFile = new AsterixFile();
        int ex;
        int ey;
        bool Arrastre = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome to Asterix Decoder!" + "\n" + "In this program you will be able to load files in asterix format and decode it to see the messages." + "\n" + "Also, you can see them located on the map." + "\n" + "If you have any questions about the operation of the program, go to the help tab." + "\n" + "Enjoy the program!";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter ;
            label2.Text = "Developed by Sergio Sanchez and Gerard Fontarnau";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ast files (.ast)|*.ast";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileStatusLabel.Text = "Loading file... please wait"; fileStatusLabel.Update();
                //Get the path of specified file
                asterixFile = new AsterixFile();
                asterixFile.setFilepath(openFileDialog.FileName);
                asterixFile.readFile();
                fileStatusLabel.Text = "File loaded."; fileStatusLabel.Update();
            }
        }

        private void showData2_Click(object sender, EventArgs e)
        {
            if (asterixFile.getListCatAll().Count != 0)
            {
                table2 table2form = new table2(asterixFile);
                table2form.Show();
            }
            else
            {
                MessageBox.Show("File not loaded, select a file");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (asterixFile.getListCatAll().Count != 0)
            {
                Mapa mapa = new Mapa();
                mapa.setAsterix(asterixFile);
                mapa.ShowDialog();
            }
            else
            {
                MessageBox.Show("File not loaded, select a file");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelFons_MouseDown(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            Arrastre = true;
        }

        private void panelFons_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastre = false;
        }

        private void panelFons_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Arrastre == true)
            {
                this.SetDesktopLocation(MousePosition.X - ex, MousePosition.Y - ey);
            } 
        }

        private void panelBajo_MouseDown(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            Arrastre = true;
        }

        private void panelBajo_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastre = false;
        }

        private void panelBajo_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Arrastre == true)
            {
                this.SetDesktopLocation(MousePosition.X - ex, MousePosition.Y - ey);
            }
        }

        private void panelTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastre = false;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            Arrastre = true;
        }

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Arrastre == true)
            {
                this.SetDesktopLocation(MousePosition.X - ex, MousePosition.Y - ey);
            }
        }
    }
}
