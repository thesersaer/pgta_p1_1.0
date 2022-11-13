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
    public partial class Form2 : Form
    {
        AsterixFile asterixFile = new AsterixFile();
        int i = 0;
        int Mode = 0;

        public Form2()
        {
            InitializeComponent();
        }

        public void setAsterix(AsterixFile asterix)
        {
            this.asterixFile = asterix;
        } 


        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            i = 0;
            Mode = 0;
            if (asterixFile.getListCatAll().Count > 0)
            {
                dataGridView1.RowCount = asterixFile.getListCatAll().Count;
                while (i < asterixFile.getListCatAll().Count)
                {
                    if (asterixFile.getListCatAll()[i].CATMode == "SMR")
                    {
                        int index = asterixFile.getListCatAll()[i].NumLlista;
                        dataGridView1[0, i].Value = i;
                        dataGridView1[1, i].Value = "CAT 10 SMR";
                        dataGridView1[2, i].Value = asterixFile.getListCat10SMR()[index].SAC;
                        dataGridView1[3, i].Value = asterixFile.getListCat10SMR()[index].SIC;
                        dataGridView1[4, i].Value = asterixFile.getListCat10SMR()[index].TargetID;
                        dataGridView1[5, i].Value = asterixFile.getListCat10SMR()[index].TrackNumber;
                        dataGridView1[6, i].Value = asterixFile.getListCat10SMR()[index].TimeOfDay;
                        dataGridView1[7, i].Value = asterixFile.getListCat10SMR()[index].TargetAddress;
                        i++;
                    }
                    else if(asterixFile.getListCatAll()[i].CATMode == "MLAT")
                    {
                        int index = asterixFile.getListCatAll()[i].NumLlista;
                        dataGridView1[0, i].Value = i;
                        dataGridView1[1, i].Value = "CAT 10 MLAT";
                        dataGridView1[2, i].Value = asterixFile.getListCat10MLAT()[index].SAC;
                        dataGridView1[3, i].Value = asterixFile.getListCat10MLAT()[index].SIC;
                        dataGridView1[4, i].Value = asterixFile.getListCat10MLAT()[index].TargetID;
                        dataGridView1[5, i].Value = asterixFile.getListCat10MLAT()[index].TrackNumber;
                        dataGridView1[6, i].Value = asterixFile.getListCat10MLAT()[index].TimeOfDay;
                        dataGridView1[7, i].Value = asterixFile.getListCat10MLAT()[index].TargetAddress;
                        i++;
                    }
                    //else if(asterixFile.getListCatAll()[i].CATMode == "ADSB")
                    //{
                    //    int index = asterixFile.getListCatAll()[i].NumLlista;
                    //    dataGridView1[0, i].Value = i;
                    //    dataGridView1[1, i].Value = "CAT 10 MLAT";
                    //    dataGridView1[2, i].Value = asterixFile.getListCat21()[index].SAC;
                    //    dataGridView1[3, i].Value = asterixFile.getListCat21()[index].SIC;
                    //    dataGridView1[4, i].Value = asterixFile.getListCat21()[index].TargetID;
                    //    dataGridView1[5, i].Value = asterixFile.getListCat21()[index].TrackNumber;
                    //    dataGridView1[6, i].Value = asterixFile.getListCat21()[index].TimeOfDay;
                    //    dataGridView1[7, i].Value = asterixFile.getListCat21()[index].TargetAddress;
                    //    i++;
                    //}
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (Mode == 0)
            {
                int indexValor = asterixFile.getListCatAll()[rowindex].NumLlista;
                if (asterixFile.getListCatAll()[rowindex].CATMode == "SMR")
                {
                    labelTargetRepDescrip.Text = asterixFile.getListCat10SMR()[indexValor].TargetReportCharacteristicsDATA;
                }
                else if(asterixFile.getListCatAll()[rowindex].CATMode == "MLAT")
                {
                    labelTargetRepDescrip.Text = asterixFile.getListCat10MLAT()[indexValor].TargetReportCharacteristicsDATA;
                }
            }
            else if(Mode == 1)
            {
                labelTargetRepDescrip.Text = asterixFile.getListCat10SMR()[e.RowIndex].TargetReportCharacteristicsDATA;
            }
            else if (Mode == 2)
            {
                labelTargetRepDescrip.Text = asterixFile.getListCat10MLAT()[e.RowIndex].TargetReportCharacteristicsDATA;
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            i = 0;
            Mode = 0;
            if (asterixFile.getListCatAll().Count > 0)
            {
                dataGridView1.RowCount = asterixFile.getListCatAll().Count;
                while (i < asterixFile.getListCatAll().Count)
                {
                    if (asterixFile.getListCatAll()[i].CATMode == "SMR")
                    {
                        int index = asterixFile.getListCatAll()[i].NumLlista;
                        dataGridView1[0, i].Value = i;
                        dataGridView1[1, i].Value = "CAT 10 SMR";
                        dataGridView1[2, i].Value = asterixFile.getListCat10SMR()[index].SAC;
                        dataGridView1[3, i].Value = asterixFile.getListCat10SMR()[index].SIC;
                        dataGridView1[4, i].Value = asterixFile.getListCat10SMR()[index].TargetID;
                        dataGridView1[5, i].Value = asterixFile.getListCat10SMR()[index].TrackNumber;
                        dataGridView1[6, i].Value = asterixFile.getListCat10SMR()[index].TimeOfDay;
                        dataGridView1[7, i].Value = asterixFile.getListCat10SMR()[index].TargetAddress;
                        i++;
                    }
                    else if (asterixFile.getListCatAll()[i].CATMode == "MLAT")
                    {
                        int index = asterixFile.getListCatAll()[i].NumLlista;
                        dataGridView1[0, i].Value = i;
                        dataGridView1[1, i].Value = "CAT 10 MLAT";
                        dataGridView1[2, i].Value = asterixFile.getListCat10MLAT()[index].SAC;
                        dataGridView1[3, i].Value = asterixFile.getListCat10MLAT()[index].SIC;
                        dataGridView1[4, i].Value = asterixFile.getListCat10MLAT()[index].TargetID;
                        dataGridView1[5, i].Value = asterixFile.getListCat10MLAT()[index].TrackNumber;
                        dataGridView1[6, i].Value = asterixFile.getListCat10MLAT()[index].TimeOfDay;
                        dataGridView1[7, i].Value = asterixFile.getListCat10MLAT()[index].TargetAddress;
                        i++;
                    }
                    //else if(asterixFile.getListCatAll()[i].CATMode == "ADSB")
                    //{
                    //    int index = asterixFile.getListCatAll()[i].NumLlista;
                    //    dataGridView1[0, i].Value = i;
                    //    dataGridView1[1, i].Value = "CAT 21 ADSB";
                    //    dataGridView1[2, i].Value = asterixFile.getListCat21()[index].SAC;
                    //    dataGridView1[3, i].Value = asterixFile.getListCat21()[index].SIC;
                    //    dataGridView1[4, i].Value = asterixFile.getListCat21()[index].TargetID;
                    //    dataGridView1[5, i].Value = asterixFile.getListCat21()[index].TrackNumber;
                    //    dataGridView1[6, i].Value = asterixFile.getListCat21()[index].TimeOfDay;
                    //    dataGridView1[7, i].Value = asterixFile.getListCat21()[index].TargetAddress;
                    //    i++;
                    //}
                }
            }
        }

        private void buttonCAT10SMR_Click(object sender, EventArgs e)
        {
            i = 0;
            Mode = 1;
            if (asterixFile.getListCat10SMR().Count > 0)
            {
                dataGridView1.RowCount = asterixFile.getListCat10SMR().Count;
                while (i < asterixFile.getListCat10SMR().Count)
                {
                    dataGridView1[0, i].Value = i;
                    dataGridView1[1, i].Value = "CAT 10 SMR";
                    dataGridView1[2, i].Value = asterixFile.getListCat10SMR()[i].SAC;
                    dataGridView1[3, i].Value = asterixFile.getListCat10SMR()[i].SIC;
                    dataGridView1[4, i].Value = asterixFile.getListCat10SMR()[i].TargetID;
                    dataGridView1[5, i].Value = asterixFile.getListCat10SMR()[i].TrackNumber;
                    dataGridView1[6, i].Value = asterixFile.getListCat10SMR()[i].TimeOfDay;
                    dataGridView1[7, i].Value = asterixFile.getListCat10SMR()[i].TargetAddress;
                    i++;
                }
            }
        }

        private void buttonCAT10MLAT_Click(object sender, EventArgs e)
        {
            i = 0;
            Mode = 2;
            if (asterixFile.getListCat10MLAT().Count > 0)
            {
                dataGridView1.RowCount = asterixFile.getListCat10MLAT().Count;
                while (i < asterixFile.getListCat10MLAT().Count)
                {
                    dataGridView1[0, i].Value = i;
                    dataGridView1[1, i].Value = "CAT 10 MLAT";
                    dataGridView1[2, i].Value = asterixFile.getListCat10MLAT()[i].SAC;
                    dataGridView1[3, i].Value = asterixFile.getListCat10MLAT()[i].SIC;
                    dataGridView1[4, i].Value = asterixFile.getListCat10MLAT()[i].TargetID;
                    dataGridView1[5, i].Value = asterixFile.getListCat10MLAT()[i].TrackNumber;
                    dataGridView1[6, i].Value = asterixFile.getListCat10MLAT()[i].TimeOfDay;
                    dataGridView1[7, i].Value = asterixFile.getListCat10MLAT()[i].TargetAddress;
                    i++;
                }
            }
        }
    }
}
