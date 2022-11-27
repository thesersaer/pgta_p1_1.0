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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (asterixFile.getListCatAll().Count != 0)
            {
                Form2 form2 = new Form2();
                form2.setAsterix(asterixFile);
                form2.ShowDialog();
            }
            else
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
        }

        private void showData2_Click(object sender, EventArgs e)
        {

        }
    }
}
