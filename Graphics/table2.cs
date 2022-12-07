using ClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class table2 : Form
    {
        AsterixFile asterixFile;
        DataTable tableCatAll;
        int Mode = 0;
        int Page = 0;
        int CAT = 10;
        int ex;
        int ey;
        int dataAgeRowInt = -1;
        bool Arrastre = false;

        public table2(AsterixFile asterixFile)
        {
            InitializeComponent();
            this.asterixFile = asterixFile;
        }

        private void table2_Load(object sender, EventArgs e)
        {
            this.tableCatAll = asterixFile.getTableCatAll();
            dataGridView1.DataSource = tableCatAll;
            filtFieldsBox.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int iiDtCol = 0; iiDtCol < tableCatAll.Columns.Count; iiDtCol++)
            {
                filtFieldsBox.Items.Add(tableCatAll.Columns[iiDtCol].ColumnName);
            }
            filtFieldsBox.SelectedIndex = 0;
            if (asterixFile.getListCatAll()[0].CATMode=="SMR"|| asterixFile.getListCatAll()[0].CATMode == "MLAT")
            {
                this.CAT = 10;
            }
            else
            {
                this.CAT = 21;
            }
            labelTituloPage.Text = "NAVIGATION";
            labelPage.Text = "1/4";
            if (this.CAT == 10)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = true;
                labelTargetRepDescrip.Visible = false;
                labelMessageType.Visible = false;
                labelFL.Visible = true;
                labelTrackStatus.Visible = true;
                labelPosWGS84.Visible = true;
                labelPosCart.Visible = true;
                labelPosPolar.Visible = true;
                labelVeloCart.Visible = true;
                labelVeloPolar.Visible = true;
                labelSizeOrientation.Visible = false;
                labelSystemStatus.Visible = false;
                labelFleetID.Visible = false;
                labelPreprogrammedMessage.Visible = false;
                labelMeasuredHeight.Visible = true;
                labelMode3A.Visible = false;
                labelModeS.Visible = false;
                labelStandardDevi.Visible = false;
                labelPresence.Visible = false;
                labelCalculatedAccel.Visible = false;
                labelPAM.Visible = true;
                label23.Visible = false;
                label26.Visible = false;
                label16.Visible = false;
                label24.Visible = false;
                label27.Visible = false;
                label28.Visible = false;
                label32.Visible = false;
                label33.Visible = false;
                label34.Visible = false;
                label35.Visible = false;
                label36.Visible = false;
                label25.Visible = false;
                label39.Visible = false;
                label40.Visible = false;
                label51.Visible = false;
                label37.Visible = false;
                label48.Visible = false;
                label31.Visible = false;
                label45.Visible = false;
                label50.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label22.Visible = false;
                label38.Visible = false;
                label41.Visible = false;
                label42.Visible = false;
                label43.Visible = false;
                label44.Visible = false;
                label47.Visible = false;
                label49.Visible = false;
            }
            else if (this.CAT == 21)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                labelTargetRepDescrip.Visible = false;
                labelMessageType.Visible = false;
                labelFL.Visible = false;
                labelTrackStatus.Visible = false;
                labelPosWGS84.Visible = false;
                labelPosCart.Visible = false;
                labelPosPolar.Visible = false;
                labelVeloCart.Visible = false;
                labelVeloPolar.Visible = false;
                labelSizeOrientation.Visible = false;
                labelSystemStatus.Visible = false;
                labelFleetID.Visible = false;
                labelPreprogrammedMessage.Visible = false;
                labelMeasuredHeight.Visible = false;
                labelMode3A.Visible = false;
                labelModeS.Visible = false;
                labelStandardDevi.Visible = false;
                labelPresence.Visible = false;
                labelCalculatedAccel.Visible = false;
                labelPAM.Visible = false;
                label3.Visible = true;
                label5.Visible = true;
                labelFL.Visible = true;
                labelPosWGS84.Visible = true;
                label23.Visible = true;
                label26.Visible = true;
                label16.Visible = true;
                label24.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
                label32.Visible = true;
                label33.Visible = true;
                label34.Visible = true;
                label35.Visible = true;
                label36.Visible = true;
                label25.Visible = true;
                label39.Visible = true;
                label40.Visible = true;
                label51.Visible = false;
                label37.Visible = false;
                label48.Visible = false;
                label31.Visible = false;
                label45.Visible = false;
                label50.Visible = false;
                label29.Visible = false;
                label30.Visible = false;
                label22.Visible = false;
                label38.Visible = false;
                label41.Visible = false;
                label42.Visible = false;
                label43.Visible = false;
                label44.Visible = false;
                label47.Visible = false;
                label49.Visible = false;

            }
        }

        private void filtSMRbutton_Click(object sender, EventArgs e)
        {
            tableCatAll.DefaultView.RowFilter = "Category = 'SMR'";
            Mode = 1;
        }

        private void filtMLATbutton_Click(object sender, EventArgs e)
        {
            tableCatAll.DefaultView.RowFilter = "Category = 'MLAT'";
            Mode = 2;
        }

        private void filt21button_Click(object sender, EventArgs e)
        {
            tableCatAll.DefaultView.RowFilter = "Category = 'ADSB'";
            Mode = 3;
        }

        private void filtAllButton_Click(object sender, EventArgs e)
        {
            tableCatAll.DefaultView.RowFilter = "";
            Mode = 0;
        }

        private void filtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (filtTextBox.Text != "")
            { tableCatAll.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}*'", filtFieldsBox.SelectedItem, filtTextBox.Text); }
            else { tableCatAll.DefaultView.RowFilter = ""; }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (Page <= 3 && Page > 0)
            {
                Page = Page - 1;
                if (this.CAT == 10)
                {
                    label23.Visible = false;
                    label26.Visible = false;
                    label16.Visible = false;
                    label24.Visible = false;
                    label27.Visible = false;
                    label28.Visible = false;
                    label32.Visible = false;
                    label33.Visible = false;
                    label34.Visible = false;
                    label35.Visible = false;
                    label36.Visible = false;
                    label25.Visible = false;
                    label39.Visible = false;
                    label40.Visible = false;
                    label51.Visible = false;
                    label37.Visible = false;
                    label48.Visible = false;
                    label31.Visible = false;
                    label45.Visible = false;
                    label50.Visible = false;
                    label29.Visible = false;
                    label30.Visible = false;
                    label22.Visible = false;
                    label38.Visible = false;
                    label41.Visible = false;
                    label42.Visible = false;
                    label43.Visible = false;
                    label44.Visible = false;
                    label47.Visible = false;
                    label49.Visible = false;



                    if (Page == 0)
                    {
                        labelPage.Text = "1/4";
                        labelTituloPage.Text = "NAVIGATION";
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = true;
                        label13.Visible = true;
                        label14.Visible = true;
                        label15.Visible = true;
                        label17.Visible = false;
                        label18.Visible = false;
                        label19.Visible = false;
                        label20.Visible = false;
                        label21.Visible = false;
                        labelTargetRepDescrip.Visible = false;
                        labelMessageType.Visible = false;
                        labelFL.Visible = true;
                        labelTrackStatus.Visible = true;
                        labelPosWGS84.Visible = true;
                        labelPosCart.Visible = true;
                        labelPosPolar.Visible = true;
                        labelVeloCart.Visible = true;
                        labelVeloPolar.Visible = true;
                        labelSizeOrientation.Visible = false;
                        labelSystemStatus.Visible = false;
                        labelFleetID.Visible = false;
                        labelPreprogrammedMessage.Visible = false;
                        labelMeasuredHeight.Visible = true;
                        labelMode3A.Visible = false;
                        labelModeS.Visible = false;
                        labelStandardDevi.Visible = false;
                        labelPresence.Visible = false;
                        labelCalculatedAccel.Visible = true;
                        labelPAM.Visible = false;

                    }
                    else if (Page == 1)
                    {
                        labelPage.Text = "2/4";
                        labelTituloPage.Text = "IDENTIFIERS";
                        label1.Visible = true;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = true;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        label15.Visible = false;
                        label17.Visible = false;
                        label18.Visible = false;
                        label19.Visible = false;
                        label20.Visible = false;
                        label21.Visible = false;
                        labelTargetRepDescrip.Visible = true;
                        labelMessageType.Visible = false;
                        labelFL.Visible = false;
                        labelTrackStatus.Visible = false;
                        labelPosWGS84.Visible = false;
                        labelPosCart.Visible = false;
                        labelPosPolar.Visible = false;
                        labelVeloCart.Visible = false;
                        labelVeloPolar.Visible = false;
                        labelSizeOrientation.Visible = false;
                        labelSystemStatus.Visible = false;
                        labelFleetID.Visible = true;
                        labelPreprogrammedMessage.Visible = false;
                        labelMeasuredHeight.Visible = false;
                        labelMode3A.Visible = false;
                        labelModeS.Visible = false;
                        labelStandardDevi.Visible = false;
                        labelPresence.Visible = false;
                        labelCalculatedAccel.Visible = false;
                        labelPAM.Visible = false;
                    }
                    else if (Page == 2)
                    {
                        labelPage.Text = "3/4";
                        labelTituloPage.Text = "ADS-B";
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        label15.Visible = false;
                        label17.Visible = false;
                        label18.Visible = false;
                        label19.Visible = true;
                        label20.Visible = true;
                        label21.Visible = false;
                        labelTargetRepDescrip.Visible = false;
                        labelMessageType.Visible = false;
                        labelFL.Visible = false;
                        labelTrackStatus.Visible = false;
                        labelPosWGS84.Visible = false;
                        labelPosCart.Visible = false;
                        labelPosPolar.Visible = false;
                        labelVeloCart.Visible = false;
                        labelVeloPolar.Visible = false;
                        labelSizeOrientation.Visible = false;
                        labelSystemStatus.Visible = false;
                        labelFleetID.Visible = false;
                        labelPreprogrammedMessage.Visible = false;
                        labelMeasuredHeight.Visible = false;
                        labelMode3A.Visible = true;
                        labelModeS.Visible = true;
                        labelStandardDevi.Visible = false;
                        labelPresence.Visible = false;
                        labelCalculatedAccel.Visible = false;
                        labelPAM.Visible = false;
                    }
                    else if (Page == 3)
                    {
                        labelPage.Text = "4/4";
                        labelTituloPage.Text = "MISCELANEOUS";
                        label1.Visible = false;
                        label2.Visible = true;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = true;
                        label9.Visible = false;
                        label10.Visible = true;
                        label11.Visible = true;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        label15.Visible = false;
                        label17.Visible = true;
                        label18.Visible = true;
                        label19.Visible = false;
                        label20.Visible = false;
                        label21.Visible = true;
                        labelTargetRepDescrip.Visible = false;
                        labelMessageType.Visible = true;
                        labelFL.Visible = false;
                        labelTrackStatus.Visible = false;
                        labelPosWGS84.Visible = false;
                        labelPosCart.Visible = false;
                        labelPosPolar.Visible = false;
                        labelVeloCart.Visible = false;
                        labelVeloPolar.Visible = false;
                        labelSizeOrientation.Visible = true;
                        labelSystemStatus.Visible = false;
                        labelFleetID.Visible = false;
                        labelPreprogrammedMessage.Visible = true;
                        labelMeasuredHeight.Visible = false;
                        labelMode3A.Visible = false;
                        labelModeS.Visible = false;
                        labelStandardDevi.Visible = true;
                        labelPresence.Visible = true;
                        labelCalculatedAccel.Visible = false;
                        labelPAM.Visible = true;
                    }
                }
                else if(this.CAT == 21)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    label19.Visible = false;
                    label20.Visible = false;
                    label21.Visible = false;
                    labelTargetRepDescrip.Visible = false;
                    labelMessageType.Visible = false;
                    labelFL.Visible = false;
                    labelTrackStatus.Visible = false;
                    labelPosWGS84.Visible = false;
                    labelPosCart.Visible = false;
                    labelPosPolar.Visible = false;
                    labelVeloCart.Visible = false;
                    labelVeloPolar.Visible = false;
                    labelSizeOrientation.Visible = false;
                    labelSystemStatus.Visible = false;
                    labelFleetID.Visible = false;
                    labelPreprogrammedMessage.Visible = false;
                    labelMeasuredHeight.Visible = false;
                    labelMode3A.Visible = false;
                    labelModeS.Visible = false;
                    labelStandardDevi.Visible = false;
                    labelPresence.Visible = false;
                    labelCalculatedAccel.Visible = false;
                    labelPAM.Visible = false;
                    if (Page == 0)
                    {
                        labelPage.Text = "1/4";
                        labelTituloPage.Text = "NAVIGATION";
                        label3.Visible = true;
                        label5.Visible = true;
                        labelFL.Visible = true;
                        labelPosWGS84.Visible = true;
                        label23.Visible = true;
                        label26.Visible = true;
                        label16.Visible = true;
                        label24.Visible = true;
                        label27.Visible = true;
                        label28.Visible = true;
                        label32.Visible = true;
                        label33.Visible = true;
                        label34.Visible = true;
                        label35.Visible = true;
                        label36.Visible = true;
                        label25.Visible = true;
                        label39.Visible = true;
                        label40.Visible = true;
                        label51.Visible = false;
                        label37.Visible = false;
                        label48.Visible = false;
                        label31.Visible = false;
                        label45.Visible = false;
                        label50.Visible = false;
                        label29.Visible = false;
                        label30.Visible = false;
                        label22.Visible = false;
                        label38.Visible = false;
                        label41.Visible = false;
                        label42.Visible = false;
                        label43.Visible = false;
                        label44.Visible = false;
                        label47.Visible = false;
                        label49.Visible = false;

                    }
                    else if (Page == 1)
                    {
                        labelPage.Text = "2/4";
                        labelTituloPage.Text = "IDENTIFIERS";
                        label3.Visible = false;
                        label5.Visible = false;
                        labelFL.Visible = false;
                        labelPosWGS84.Visible = false;
                        label23.Visible = false;
                        label26.Visible = false;
                        label16.Visible = false;
                        label24.Visible = false;
                        label27.Visible = false;
                        label28.Visible = false;
                        label32.Visible = false;
                        label33.Visible = false;
                        label34.Visible = false;
                        label35.Visible = false;
                        label36.Visible = false;
                        label25.Visible = false;
                        label39.Visible = false;
                        label40.Visible = false;
                        label51.Visible = true;
                        label37.Visible = true;
                        label48.Visible = true;
                        label31.Visible = false;
                        label45.Visible = false;
                        label50.Visible = false;
                        label29.Visible = false;
                        label30.Visible = false;
                        label22.Visible = false;
                        label38.Visible = false;
                        label41.Visible = false;
                        label42.Visible = false;
                        label43.Visible = false;
                        label44.Visible = false;
                        label47.Visible = false;
                        label49.Visible = false;
                    }
                    else if (Page == 2)
                    {
                        labelPage.Text = "3/4";
                        labelTituloPage.Text = "ADS-B";
                        label3.Visible = false;
                        label5.Visible = false;
                        labelFL.Visible = false;
                        labelPosWGS84.Visible = false;
                        label23.Visible = false;
                        label26.Visible = false;
                        label16.Visible = false;
                        label24.Visible = false;
                        label27.Visible = false;
                        label28.Visible = false;
                        label32.Visible = false;
                        label33.Visible = false;
                        label34.Visible = false;
                        label35.Visible = false;
                        label36.Visible = false;
                        label25.Visible = false;
                        label39.Visible = false;
                        label40.Visible = false;
                        label51.Visible = false;
                        label37.Visible = false;
                        label48.Visible = false;
                        label31.Visible = true;
                        label45.Visible = true;
                        label50.Visible = false;
                        label29.Visible = false;
                        label30.Visible = false;
                        label22.Visible = false;
                        label38.Visible = false;
                        label41.Visible = false;
                        label42.Visible = false;
                        label43.Visible = false;
                        label44.Visible = false;
                        label47.Visible = false;
                        label49.Visible = false;
                    }
                    else if (Page == 3)
                    {
                        labelPage.Text = "4/4";
                        labelTituloPage.Text = "MISCELANEOUS";
                        
                        label3.Visible = false;
                        label5.Visible = false;                       
                        labelFL.Visible = false;
                        labelPosWGS84.Visible = false;
                        label23.Visible = false;
                        label26.Visible = false;
                        label16.Visible = false;
                        label24.Visible = false;
                        label27.Visible = false;
                        label28.Visible = false;
                        label32.Visible = false;
                        label33.Visible = false;
                        label34.Visible = false;
                        label35.Visible = false;
                        label36.Visible = false;
                        label25.Visible = false;
                        label39.Visible = false;
                        label40.Visible = false;
                        label51.Visible = false;
                        label37.Visible = false;
                        label48.Visible = false;
                        label31.Visible = false;
                        label45.Visible = false;
                        label50.Visible = true;
                        label29.Visible = true;
                        label30.Visible = true;
                        label22.Visible = true;
                        label38.Visible = true;
                        label41.Visible = true;
                        label42.Visible = true;
                        label43.Visible = true;
                        label44.Visible = true;
                        label47.Visible = true;
                        label49.Visible = true;

                    }
                }
                else
                {
                    MessageBox.Show("Minimum pages reached");
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (Page < 3 && Page >= 0)
            {
                Page = Page + 1;
                if (this.CAT == 10)
                {
                    label23.Visible = false;
                    label26.Visible = false;
                    label16.Visible = false;
                    label24.Visible = false;
                    label27.Visible = false;
                    label28.Visible = false;
                    label32.Visible = false;
                    label33.Visible = false;
                    label34.Visible = false;
                    label35.Visible = false;
                    label36.Visible = false;
                    label25.Visible = false;
                    label39.Visible = false;
                    label40.Visible = false;
                    label51.Visible = false;
                    label37.Visible = false;
                    label48.Visible = false;
                    label31.Visible = false;
                    label45.Visible = false;
                    label50.Visible = false;
                    label29.Visible = false;
                    label30.Visible = false;
                    label22.Visible = false;
                    label38.Visible = false;
                    label41.Visible = false;
                    label42.Visible = false;
                    label43.Visible = false;
                    label44.Visible = false;
                    label47.Visible = false;
                    label49.Visible = false;
                    if (Page == 0)
                    {
                        labelPage.Text = "1/4";
                        labelTituloPage.Text = "NAVIGATION";
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = true;
                        label13.Visible = true;
                        label14.Visible = true;
                        label15.Visible = true;
                        label17.Visible = false;
                        label18.Visible = false;
                        label19.Visible = false;
                        label20.Visible = false;
                        label21.Visible = false;
                        labelTargetRepDescrip.Visible = false;
                        labelMessageType.Visible = false;
                        labelFL.Visible = true;
                        labelTrackStatus.Visible = true;
                        labelPosWGS84.Visible = true;
                        labelPosCart.Visible = true;
                        labelPosPolar.Visible = true;
                        labelVeloCart.Visible = true;
                        labelVeloPolar.Visible = true;
                        labelSizeOrientation.Visible = false;
                        labelSystemStatus.Visible = false;
                        labelFleetID.Visible = false;
                        labelPreprogrammedMessage.Visible = false;
                        labelMeasuredHeight.Visible = true;
                        labelMode3A.Visible = false;
                        labelModeS.Visible = false;
                        labelStandardDevi.Visible = false;
                        labelPresence.Visible = false;
                        labelCalculatedAccel.Visible = true;
                        labelPAM.Visible = false;

                    }
                    else if (Page == 1)
                    {
                        labelPage.Text = "2/4";
                        labelTituloPage.Text = "IDENTIFIERS";
                        label1.Visible = true;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = true;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        label15.Visible = false;
                        label17.Visible = false;
                        label18.Visible = false;
                        label19.Visible = false;
                        label20.Visible = false;
                        label21.Visible = false;
                        labelTargetRepDescrip.Visible = true;
                        labelMessageType.Visible = false;
                        labelFL.Visible = false;
                        labelTrackStatus.Visible = false;
                        labelPosWGS84.Visible = false;
                        labelPosCart.Visible = false;
                        labelPosPolar.Visible = false;
                        labelVeloCart.Visible = false;
                        labelVeloPolar.Visible = false;
                        labelSizeOrientation.Visible = false;
                        labelSystemStatus.Visible = false;
                        labelFleetID.Visible = true;
                        labelPreprogrammedMessage.Visible = false;
                        labelMeasuredHeight.Visible = false;
                        labelMode3A.Visible = false;
                        labelModeS.Visible = false;
                        labelStandardDevi.Visible = false;
                        labelPresence.Visible = false;
                        labelCalculatedAccel.Visible = false;
                        labelPAM.Visible = false;
                    }
                    else if (Page == 2)
                    {
                        labelPage.Text = "3/4";
                        labelTituloPage.Text = "ADS-B";
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        label15.Visible = false;
                        label17.Visible = false;
                        label18.Visible = false;
                        label19.Visible = true;
                        label20.Visible = true;
                        label21.Visible = false;
                        labelTargetRepDescrip.Visible = false;
                        labelMessageType.Visible = false;
                        labelFL.Visible = false;
                        labelTrackStatus.Visible = false;
                        labelPosWGS84.Visible = false;
                        labelPosCart.Visible = false;
                        labelPosPolar.Visible = false;
                        labelVeloCart.Visible = false;
                        labelVeloPolar.Visible = false;
                        labelSizeOrientation.Visible = false;
                        labelSystemStatus.Visible = false;
                        labelFleetID.Visible = false;
                        labelPreprogrammedMessage.Visible = false;
                        labelMeasuredHeight.Visible = false;
                        labelMode3A.Visible = true;
                        labelModeS.Visible = true;
                        labelStandardDevi.Visible = false;
                        labelPresence.Visible = false;
                        labelCalculatedAccel.Visible = false;
                        labelPAM.Visible = false;
                    }
                    else if (Page == 3)
                    {
                        labelPage.Text = "4/4";
                        labelTituloPage.Text = "MISCELANEOUS";
                        label1.Visible = false;
                        label2.Visible = true;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = true;
                        label9.Visible = false;
                        label10.Visible = true;
                        label11.Visible = true;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        label15.Visible = false;
                        label17.Visible = true;
                        label18.Visible = true;
                        label19.Visible = false;
                        label20.Visible = false;
                        label21.Visible = true;
                        labelTargetRepDescrip.Visible = false;
                        labelMessageType.Visible = true;
                        labelFL.Visible = false;
                        labelTrackStatus.Visible = false;
                        labelPosWGS84.Visible = false;
                        labelPosCart.Visible = false;
                        labelPosPolar.Visible = false;
                        labelVeloCart.Visible = false;
                        labelVeloPolar.Visible = false;
                        labelSizeOrientation.Visible = true;
                        labelSystemStatus.Visible = false;
                        labelFleetID.Visible = false;
                        labelPreprogrammedMessage.Visible = true;
                        labelMeasuredHeight.Visible = false;
                        labelMode3A.Visible = false;
                        labelModeS.Visible = false;
                        labelStandardDevi.Visible = true;
                        labelPresence.Visible = true;
                        labelCalculatedAccel.Visible = false;
                        labelPAM.Visible = true;
                    }
                }
                else if (this.CAT == 21)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    label19.Visible = false;
                    label20.Visible = false;
                    label21.Visible = false;
                    labelTargetRepDescrip.Visible = false;
                    labelMessageType.Visible = false;
                    labelFL.Visible = false;
                    labelTrackStatus.Visible = false;
                    labelPosWGS84.Visible = false;
                    labelPosCart.Visible = false;
                    labelPosPolar.Visible = false;
                    labelVeloCart.Visible = false;
                    labelVeloPolar.Visible = false;
                    labelSizeOrientation.Visible = false;
                    labelSystemStatus.Visible = false;
                    labelFleetID.Visible = false;
                    labelPreprogrammedMessage.Visible = false;
                    labelMeasuredHeight.Visible = false;
                    labelMode3A.Visible = false;
                    labelModeS.Visible = false;
                    labelStandardDevi.Visible = false;
                    labelPresence.Visible = false;
                    labelCalculatedAccel.Visible = false;
                    labelPAM.Visible = false;
                    if (Page == 0)
                    {
                        labelPage.Text = "1/4";
                        labelTituloPage.Text = "NAVIGATION";
                        label3.Visible = true;
                        label5.Visible = true;
                        labelFL.Visible = true;
                        labelPosWGS84.Visible = true;
                        label23.Visible = true;
                        label26.Visible = true;
                        label16.Visible = true;
                        label24.Visible = true;
                        label27.Visible = true;
                        label28.Visible = true;
                        label32.Visible = true;
                        label33.Visible = true;
                        label34.Visible = true;
                        label35.Visible = true;
                        label36.Visible = true;
                        label25.Visible = true;
                        label39.Visible = true;
                        label40.Visible = true;
                        label51.Visible = false;
                        label37.Visible = false;
                        label48.Visible = false;
                        label31.Visible = false;
                        label45.Visible = false;
                        label50.Visible = false;
                        label29.Visible = false;
                        label30.Visible = false;
                        label22.Visible = false;
                        label38.Visible = false;
                        label41.Visible = false;
                        label42.Visible = false;
                        label43.Visible = false;
                        label44.Visible = false;
                        label47.Visible = false;
                        label49.Visible = false;

                    }
                    else if (Page == 1)
                    {
                        labelPage.Text = "2/4";
                        labelTituloPage.Text = "IDENTIFIERS";
                        label3.Visible = false;
                        label5.Visible = false;
                        labelFL.Visible = false;
                        labelPosWGS84.Visible = false;
                        label23.Visible = false;
                        label26.Visible = false;
                        label16.Visible = false;
                        label24.Visible = false;
                        label27.Visible = false;
                        label28.Visible = false;
                        label32.Visible = false;
                        label33.Visible = false;
                        label34.Visible = false;
                        label35.Visible = false;
                        label36.Visible = false;
                        label25.Visible = false;
                        label39.Visible = false;
                        label40.Visible = false;
                        label51.Visible = true;
                        label37.Visible = true;
                        label48.Visible = true;
                        label31.Visible = false;
                        label45.Visible = false;
                        label50.Visible = false;
                        label29.Visible = false;
                        label30.Visible = false;
                        label22.Visible = false;
                        label38.Visible = false;
                        label41.Visible = false;
                        label42.Visible = false;
                        label43.Visible = false;
                        label44.Visible = false;
                        label47.Visible = false;
                        label49.Visible = false;
                    }
                    else if (Page == 2)
                    {
                        labelPage.Text = "3/4";
                        labelTituloPage.Text = "ADS-B";
                        label3.Visible = false;
                        label5.Visible = false;
                        labelFL.Visible = false;
                        labelPosWGS84.Visible = false;
                        label23.Visible = false;
                        label26.Visible = false;
                        label16.Visible = false;
                        label24.Visible = false;
                        label27.Visible = false;
                        label28.Visible = false;
                        label32.Visible = false;
                        label33.Visible = false;
                        label34.Visible = false;
                        label35.Visible = false;
                        label36.Visible = false;
                        label25.Visible = false;
                        label39.Visible = false;
                        label40.Visible = false;
                        label51.Visible = false;
                        label37.Visible = false;
                        label48.Visible = false;
                        label31.Visible = true;
                        label45.Visible = true;
                        label50.Visible = false;
                        label29.Visible = false;
                        label30.Visible = false;
                        label22.Visible = false;
                        label38.Visible = false;
                        label41.Visible = false;
                        label42.Visible = false;
                        label43.Visible = false;
                        label44.Visible = false;
                        label47.Visible = false;
                        label49.Visible = false;
                    }
                    else if (Page == 3)
                    {
                        labelPage.Text = "4/4";
                        labelTituloPage.Text = "MISCELANEOUS";

                        label3.Visible = false;
                        label5.Visible = false;
                        labelFL.Visible = false;
                        labelPosWGS84.Visible = false;
                        label23.Visible = false;
                        label26.Visible = false;
                        label16.Visible = false;
                        label24.Visible = false;
                        label27.Visible = false;
                        label28.Visible = false;
                        label32.Visible = false;
                        label33.Visible = false;
                        label34.Visible = false;
                        label35.Visible = false;
                        label36.Visible = false;
                        label25.Visible = false;
                        label39.Visible = false;
                        label40.Visible = false;
                        label51.Visible = false;
                        label37.Visible = false;
                        label48.Visible = false;
                        label31.Visible = false;
                        label45.Visible = false;
                        label50.Visible = true;
                        label29.Visible = true;
                        label30.Visible = true;
                        label22.Visible = true;
                        label38.Visible = true;
                        label41.Visible = true;
                        label42.Visible = true;
                        label43.Visible = true;
                        label44.Visible = true;
                        label47.Visible = true;
                        label49.Visible = true;

                    }
                }
                else
                {
                    MessageBox.Show("There are no more pages");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (asterixFile.getListCatAll()[rowindex].CATMode == "SMR" || asterixFile.getListCatAll()[0].CATMode == "MLAT")
            {
                this.CAT = 10;
            }
            else
            {
                this.CAT = 21;
            }
            if (Mode == 0)
            {
                int indexValor = asterixFile.getListCatAll()[rowindex].NumLlista;
                if (asterixFile.getListCatAll()[rowindex].CATMode == "SMR")
                {
                    this.CAT = 10;
                    labelTargetRepDescrip.Text = asterixFile.getListCat10SMR()[indexValor].TargetReportCharacteristicsDATA;
                    labelMessageType.Text = asterixFile.getListCat10SMR()[indexValor].MessageType;
                    labelFL.Text = asterixFile.getListCat10SMR()[indexValor].FLXXX;
                    labelTrackStatus.Text = asterixFile.getListCat10SMR()[indexValor].TrackStatusData;
                    labelPosWGS84.Text = asterixFile.getListCat10SMR()[indexValor].PositionInWGS84;
                    labelPosCart.Text = asterixFile.getListCat10SMR()[indexValor].PositionInCartesian;
                    labelPosPolar.Text = asterixFile.getListCat10SMR()[indexValor].PositionInPolar;
                    labelVeloCart.Text = asterixFile.getListCat10SMR()[indexValor].VeloInCartesian;
                    labelVeloPolar.Text = asterixFile.getListCat10SMR()[indexValor].VeloInPolar;
                    labelSizeOrientation.Text = asterixFile.getListCat10SMR()[indexValor].TargetSize;
                    labelSystemStatus.Text = asterixFile.getListCat10SMR()[indexValor].SystemStatus;
                    labelFleetID.Text = Convert.ToString(asterixFile.getListCat10SMR()[indexValor].VehicleFleetId) + asterixFile.getListCat10SMR()[indexValor].VFI;
                    labelPreprogrammedMessage.Text = asterixFile.getListCat10SMR()[indexValor].PreProgrammedMessage;
                    labelMeasuredHeight.Text = asterixFile.getListCat10SMR()[indexValor].MeasuredHeight;
                    labelMode3A.Text = asterixFile.getListCat10SMR()[indexValor].Mode3A;
                    labelModeS.Text = asterixFile.getListCat10SMR()[indexValor].ModeS;
                    labelStandardDevi.Text = asterixFile.getListCat10SMR()[indexValor].StandardDEVI;
                    labelPresence.Text = asterixFile.getListCat10SMR()[indexValor].Presence;
                    labelCalculatedAccel.Text = asterixFile.getListCat10SMR()[indexValor].CalculatedAccel;
                    labelPAM.Text = asterixFile.getListCat10SMR()[indexValor].PAM;

                }
                else if (asterixFile.getListCatAll()[rowindex].CATMode == "MLAT")
                {
                    this.CAT = 10;
                    labelTargetRepDescrip.Text = asterixFile.getListCat10MLAT()[indexValor].TargetReportCharacteristicsDATA;
                    labelMessageType.Text = asterixFile.getListCat10MLAT()[indexValor].MessageType;
                    labelFL.Text = asterixFile.getListCat10MLAT()[indexValor].FLXXX;
                    labelTrackStatus.Text = asterixFile.getListCat10MLAT()[indexValor].TrackStatusData;
                    labelPosWGS84.Text = asterixFile.getListCat10MLAT()[indexValor].PositionInWGS84;
                    labelPosCart.Text = asterixFile.getListCat10MLAT()[indexValor].PositionInCartesian;
                    labelPosPolar.Text = asterixFile.getListCat10MLAT()[indexValor].PositionInPolar;
                    labelVeloCart.Text = asterixFile.getListCat10MLAT()[indexValor].VeloInCartesian;
                    labelVeloPolar.Text = asterixFile.getListCat10MLAT()[indexValor].VeloInPolar;
                    labelSizeOrientation.Text = asterixFile.getListCat10MLAT()[indexValor].TargetSize;
                    labelSystemStatus.Text = asterixFile.getListCat10MLAT()[indexValor].SystemStatus;
                    labelFleetID.Text = Convert.ToString(asterixFile.getListCat10MLAT()[indexValor].VehicleFleetId) + asterixFile.getListCat10MLAT()[indexValor].VFI;
                    labelPreprogrammedMessage.Text = asterixFile.getListCat10MLAT()[indexValor].PreProgrammedMessage;
                    labelMeasuredHeight.Text = asterixFile.getListCat10MLAT()[indexValor].MeasuredHeight;
                    labelMode3A.Text = asterixFile.getListCat10MLAT()[indexValor].Mode3A;
                    labelModeS.Text = asterixFile.getListCat10MLAT()[indexValor].ModeS;
                    labelStandardDevi.Text = asterixFile.getListCat10MLAT()[indexValor].StandardDEVI;
                    labelPresence.Text = asterixFile.getListCat10MLAT()[indexValor].Presence;
                    labelCalculatedAccel.Text = asterixFile.getListCat10MLAT()[indexValor].CalculatedAccel;
                    labelPAM.Text = asterixFile.getListCat10MLAT()[indexValor].PAM;
                }
                else if (asterixFile.getListCatAll()[rowindex].CATMode == "ADSB")
                {
                    this.CAT = 21;
                    if (asterixFile.getListCat21()[e.RowIndex].flightLevel != null) { labelFL.Text = "FL " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].flightLevel.flightLevel); } else { labelFL.Text = ""; }
                    if (asterixFile.getListCat21()[e.RowIndex].positionWGS84 != null) { labelPosWGS84.Text = Convert.ToString(asterixFile.getListCat21()[e.RowIndex].positionWGS84.latitude) + "º, " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].positionWGS84.longitude) + "º"; } else { labelPosWGS84.Text = ""; }
                    if (asterixFile.getListCat21()[e.RowIndex].trueAirspeed != null) { label16.Text = "Airspeed: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].trueAirspeed.trueAirspeed); } else { label16.Text = "Airspeed: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].targetStatus != null) { label22.Text = "Surveillance Status: " + asterixFile.getListCat21()[e.RowIndex].targetStatus.surveillanceStatus + "\n" + "Priority Status: " + asterixFile.getListCat21()[e.RowIndex].targetStatus.priorityStatus; } else { label22.Text = "Surveillance Status: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].timeOfApplicabilityPosition != null) { label23.Text = "Time Of Applicability Position: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].timeOfApplicabilityPosition.toaSeconds) + " s"; } else { label23.Text = "Time Of Applicability Position: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].timeOfMessageReceptionPosition != null) { label24.Text = "Time Of Message Reception Position: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].timeOfMessageReceptionPosition.tomSeconds) + " s"; } else { label24.Text = "Time Of Message Reception Position: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].trackAngleRate != null) { label25.Text = "Track Angle Rate: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].trackAngleRate.trackAngleRate) + " º/s"; } else { label25.Text = "Track Angle Rate: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].timeOfApplicabilityVelocity != null) { label26.Text = "Time Of Applicability Velocity: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].timeOfApplicabilityVelocity.toaSeconds) + " s"; } else { label23.Text = "Time Of Applicability Velocity: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].timeOfMessageReceptionVelocity != null) { label27.Text = "Time Of Message Reception Velocity: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].timeOfMessageReceptionVelocity.tomSeconds) + " s"; } else { label24.Text = "Time Of Message Reception Velocity: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].geometricHeight != null) { label28.Text = "Geometric Height: " + asterixFile.getListCat21()[e.RowIndex].geometricHeight.geometricHeight + "m"; } else { label28.Text = "Geometric Height: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].qualityIndicators != null) { label29.Text = "Quality indicatos: " + QualityIndicatorsDec(asterixFile, e.RowIndex); } else { label29.Text = "Quality indicatos: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].mOPSVersion != null) { label30.Text = "MOPS Version: " + MOPSDEC(asterixFile, e.RowIndex); } else { label30.Text = "MOPS Version: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].mode3ACode != null) { label31.Text = "Mode 3A Code: " + asterixFile.getListCat21()[e.RowIndex].mode3ACode.replyCode; } else { label30.Text = "Mode 3A Code: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].rollAngle != null) { label32.Text = "Roll Angle: " + asterixFile.getListCat21()[e.RowIndex].rollAngle.rollAngle; } else { label32.Text = "Roll Angle: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].magneticHeading != null) { label33.Text = "Magnetic Heading: " + asterixFile.getListCat21()[e.RowIndex].magneticHeading.magneticHeading; } else { label33.Text = "Magnetic Heading: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].barometricVerticalRate != null) { label34.Text = "Barometric Vertical Rate: " + asterixFile.getListCat21()[e.RowIndex].barometricVerticalRate.barometricVerticalRateFtPerMin; } else { label34.Text = "Barometric Vertical Rate: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].geometricVerticalRate != null) { label35.Text = "Geometric Vertical Rate: " + asterixFile.getListCat21()[e.RowIndex].geometricVerticalRate.geometricVerticalRateFtPerMin; } else { label35.Text = "Geometric Vertical Rate: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].airborneGroundVector != null) { label36.Text = "Airborne Ground Vector: " + GroundVector(asterixFile, e.RowIndex); } else { label36.Text = "Airborne Ground Vector: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].emitterCategory != null) { label37.Text = "Emitter Category: " + asterixFile.getListCat21()[e.RowIndex].emitterCategory.emitterCategory; } else { label37.Text = "Emitter Category: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].metInformation != null) { label38.Text = "Met Information: " + METinfoDEC(asterixFile, e.RowIndex); } else { label38.Text = "Met Information: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].selectedAltitude != null) { label39.Text = "Selected Altitude: " + asterixFile.getListCat21()[e.RowIndex].selectedAltitude.altitude; } else{label39.Text = "Selected Altitude: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].trajectoryIntent != null) { label40.Text = "Trajectory Intent: " + TrajectoryDEC(asterixFile, e.RowIndex); } else { label40.Text = "Trajectory Intent: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].serviceManagement != null) { label41.Text = "Service Management: " + asterixFile.getListCat21()[e.RowIndex].serviceManagement.reportPeriod; } else { label41.Text = "Service Management: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].aircraftOperationalStatus != null) { label42.Text = "Aircraft Operational Status: " + OperationalStatusDEC(asterixFile, e.RowIndex); } else { label42.Text = "Aircraft Operational Status: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].surfaceCapabilitiesAndCharacteristics != null) { label43.Text = "Surface Capabilities And Characteristics: " + SurfaceDEC(asterixFile, e.RowIndex); } else { label43.Text = "Surface Capabilities And Characteristics: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].messageAmplitude != null) { label44.Text = "Message Amplitude: " + asterixFile.getListCat21()[e.RowIndex].messageAmplitude.messageAmplitudedBm; } else { label44.Text = "Message Amplitude: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].modeSMBData != null) { label45.Text = "Mode S MB Data: " + asterixFile.getListCat21()[e.RowIndex].modeSMBData.bdsList; } else { label45.Text = "Mode S MB Data: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].aCASResolutionAdvisoryReport != null) { label47.Text = "ACAS Resolution Advisory Report: " + ACASResolDEC(asterixFile, e.RowIndex); } else { label47.Text = "ACAS Resolution Advisory Report: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].receiverId != null) { label48.Text = "Receiver ID: " + asterixFile.getListCat21()[e.RowIndex].receiverId.receiverId; } else { label48.Text = "Receiver ID: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].dataAges != null) { dataAgeRowInt = e.RowIndex; label49.Text = "Data Ages: double click to see info"; } else { dataAgeRowInt = -1; label49.Text = "Data Ages: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].targetReportDescriptor != null) { label50.Text = "Target Report Description: " + TargetDevolver(asterixFile, e.RowIndex); } else { label50.Text = "Target Report Description: "; }
                    if (asterixFile.getListCat21()[e.RowIndex].serviceIdentification != null) { label51.Text = "Service Identification: " + asterixFile.getListCat21()[e.RowIndex].serviceIdentification.serviceIdentification; } else { label51.Text = "Service Identification: "; }
                }
            }
            else if (Mode == 1)
            {
                this.CAT = 10;
                labelTargetRepDescrip.Text = asterixFile.getListCat10SMR()[e.RowIndex].TargetReportCharacteristicsDATA;
                labelMessageType.Text = asterixFile.getListCat10SMR()[e.RowIndex].MessageType;
                labelFL.Text = asterixFile.getListCat10SMR()[e.RowIndex].FLXXX;
                labelTrackStatus.Text = asterixFile.getListCat10SMR()[e.RowIndex].TrackStatusData;
                labelPosWGS84.Text = asterixFile.getListCat10SMR()[e.RowIndex].PositionInWGS84;
                labelPosCart.Text = asterixFile.getListCat10SMR()[e.RowIndex].PositionInCartesian;
                labelPosPolar.Text = asterixFile.getListCat10SMR()[e.RowIndex].PositionInPolar;
                labelVeloCart.Text = asterixFile.getListCat10SMR()[e.RowIndex].VeloInCartesian;
                labelVeloPolar.Text = asterixFile.getListCat10SMR()[e.RowIndex].VeloInPolar;
                labelSizeOrientation.Text = asterixFile.getListCat10SMR()[e.RowIndex].TargetSize;
                labelSystemStatus.Text = asterixFile.getListCat10SMR()[e.RowIndex].SystemStatus;
                labelFleetID.Text = Convert.ToString(asterixFile.getListCat10SMR()[e.RowIndex].VehicleFleetId) + asterixFile.getListCat10SMR()[e.RowIndex].VFI;
                labelPreprogrammedMessage.Text = asterixFile.getListCat10SMR()[e.RowIndex].PreProgrammedMessage;
                labelMeasuredHeight.Text = asterixFile.getListCat10SMR()[e.RowIndex].MeasuredHeight;
                labelMode3A.Text = asterixFile.getListCat10SMR()[e.RowIndex].Mode3A;
                labelModeS.Text = asterixFile.getListCat10SMR()[e.RowIndex].ModeS;
                labelStandardDevi.Text = asterixFile.getListCat10SMR()[e.RowIndex].StandardDEVI;
                labelPresence.Text = asterixFile.getListCat10SMR()[e.RowIndex].Presence;
                labelCalculatedAccel.Text = asterixFile.getListCat10SMR()[e.RowIndex].CalculatedAccel;
                labelPAM.Text = asterixFile.getListCat10SMR()[e.RowIndex].PAM;
            }
            else if (Mode == 2)
            {
                this.CAT = 10;
                labelTargetRepDescrip.Text = asterixFile.getListCat10MLAT()[e.RowIndex].TargetReportCharacteristicsDATA;
                labelMessageType.Text = asterixFile.getListCat10MLAT()[e.RowIndex].MessageType;
                labelFL.Text = asterixFile.getListCat10MLAT()[e.RowIndex].FLXXX;
                labelTrackStatus.Text = asterixFile.getListCat10MLAT()[e.RowIndex].TrackStatusData;
                labelPosWGS84.Text = asterixFile.getListCat10MLAT()[e.RowIndex].PositionInWGS84;
                labelPosCart.Text = asterixFile.getListCat10MLAT()[e.RowIndex].PositionInCartesian;
                labelPosPolar.Text = asterixFile.getListCat10MLAT()[e.RowIndex].PositionInPolar;
                labelVeloCart.Text = asterixFile.getListCat10MLAT()[e.RowIndex].VeloInCartesian;
                labelVeloPolar.Text = asterixFile.getListCat10MLAT()[e.RowIndex].VeloInPolar;
                labelSizeOrientation.Text = asterixFile.getListCat10MLAT()[e.RowIndex].TargetSize;
                labelSystemStatus.Text = asterixFile.getListCat10MLAT()[e.RowIndex].SystemStatus;
                labelFleetID.Text = Convert.ToString(asterixFile.getListCat10MLAT()[e.RowIndex].VehicleFleetId) + asterixFile.getListCat10MLAT()[e.RowIndex].VFI;
                labelPreprogrammedMessage.Text = asterixFile.getListCat10MLAT()[e.RowIndex].PreProgrammedMessage;
                labelMeasuredHeight.Text = asterixFile.getListCat10MLAT()[e.RowIndex].MeasuredHeight;
                labelMode3A.Text = asterixFile.getListCat10MLAT()[e.RowIndex].Mode3A;
                labelModeS.Text = asterixFile.getListCat10MLAT()[e.RowIndex].ModeS;
                labelStandardDevi.Text = asterixFile.getListCat10MLAT()[e.RowIndex].StandardDEVI;
                labelPresence.Text = asterixFile.getListCat10MLAT()[e.RowIndex].Presence;
                labelCalculatedAccel.Text = asterixFile.getListCat10MLAT()[e.RowIndex].CalculatedAccel;
                labelPAM.Text = asterixFile.getListCat10MLAT()[e.RowIndex].PAM;
            }
            else if(Mode == 3)
            {
                this.CAT = 21;
                if (asterixFile.getListCat21()[e.RowIndex].flightLevel != null) { labelFL.Text = "FL " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].flightLevel.flightLevel); } else { labelFL.Text = ""; }
                if (asterixFile.getListCat21()[e.RowIndex].positionWGS84 != null) { labelPosWGS84.Text = Convert.ToString(asterixFile.getListCat21()[e.RowIndex].positionWGS84.latitude) + "º, " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].positionWGS84.longitude) + "º"; } else { labelPosWGS84.Text = ""; }
                if (asterixFile.getListCat21()[e.RowIndex].trueAirspeed != null) { label16.Text = "Airspeed: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].trueAirspeed.trueAirspeed); } else { label16.Text = "Airspeed: "; }
                if (asterixFile.getListCat21()[e.RowIndex].targetStatus != null) { label22.Text = "Surveillance Status: " + asterixFile.getListCat21()[e.RowIndex].targetStatus.surveillanceStatus + "\n" + "Priority Status: " + asterixFile.getListCat21()[e.RowIndex].targetStatus.priorityStatus; } else { label22.Text = "Surveillance Status: "; }
                if (asterixFile.getListCat21()[e.RowIndex].timeOfApplicabilityPosition != null) { label23.Text = "Time Of Applicability Position: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].timeOfApplicabilityPosition.toaSeconds) + " s"; } else { label23.Text = "Time Of Applicability Position: "; }
                if (asterixFile.getListCat21()[e.RowIndex].timeOfMessageReceptionPosition != null) { label24.Text = "Time Of Message Reception Position: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].timeOfMessageReceptionPosition.tomSeconds) + " s"; } else { label24.Text = "Time Of Message Reception Position: "; }
                if (asterixFile.getListCat21()[e.RowIndex].trackAngleRate != null) { label25.Text = "Track Angle Rate: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].trackAngleRate.trackAngleRate) + " º/s"; } else { label25.Text = "Track Angle Rate: "; }
                if (asterixFile.getListCat21()[e.RowIndex].timeOfApplicabilityVelocity != null) { label26.Text = "Time Of Applicability Velocity: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].timeOfApplicabilityVelocity.toaSeconds) + " s"; } else { label23.Text = "Time Of Applicability Velocity: "; }
                if (asterixFile.getListCat21()[e.RowIndex].timeOfMessageReceptionVelocity != null) { label27.Text = "Time Of Message Reception Velocity: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].timeOfMessageReceptionVelocity.tomSeconds) + " s"; } else { label24.Text = "Time Of Message Reception Velocity: "; }
                if (asterixFile.getListCat21()[e.RowIndex].geometricHeight != null) { label28.Text = "Geometric Height: " + asterixFile.getListCat21()[e.RowIndex].geometricHeight.geometricHeight + "m"; } else { label28.Text = "Geometric Height: "; }
                if (asterixFile.getListCat21()[e.RowIndex].qualityIndicators != null) { label29.Text = "Quality indicatos: " + QualityIndicatorsDec(asterixFile, e.RowIndex); } else { label29.Text = "Quality indicatos: "; }
                if (asterixFile.getListCat21()[e.RowIndex].mOPSVersion != null) { label30.Text = "MOPS Version: " + MOPSDEC(asterixFile, e.RowIndex); } else { label30.Text = "MOPS Version: "; }
                if (asterixFile.getListCat21()[e.RowIndex].mode3ACode != null) { label31.Text = "Mode 3A Code: " + asterixFile.getListCat21()[e.RowIndex].mode3ACode.replyCode; } else { label30.Text = "Mode 3A Code: "; }
                if (asterixFile.getListCat21()[e.RowIndex].rollAngle != null) { label32.Text = "Roll Angle: " + asterixFile.getListCat21()[e.RowIndex].rollAngle.rollAngle; } else { label32.Text = "Roll Angle: "; }
                if (asterixFile.getListCat21()[e.RowIndex].magneticHeading != null) { label33.Text = "Magnetic Heading: " + asterixFile.getListCat21()[e.RowIndex].magneticHeading.magneticHeading; } else { label33.Text = "Magnetic Heading: "; }
                if (asterixFile.getListCat21()[e.RowIndex].barometricVerticalRate != null) { label34.Text = "Barometric Vertical Rate: " + asterixFile.getListCat21()[e.RowIndex].barometricVerticalRate.barometricVerticalRateFtPerMin; } else { label34.Text = "Barometric Vertical Rate: "; }
                if (asterixFile.getListCat21()[e.RowIndex].geometricVerticalRate != null) { label35.Text = "Geometric Vertical Rate: " + asterixFile.getListCat21()[e.RowIndex].geometricVerticalRate.geometricVerticalRateFtPerMin; } else { label35.Text = "Geometric Vertical Rate: "; }
                if (asterixFile.getListCat21()[e.RowIndex].airborneGroundVector != null) { label36.Text = "Airborne Ground Vector: " + GroundVector(asterixFile, e.RowIndex); } else { label36.Text = "Airborne Ground Vector: "; }
                if (asterixFile.getListCat21()[e.RowIndex].emitterCategory != null) { label37.Text = "Emitter Category: " + asterixFile.getListCat21()[e.RowIndex].emitterCategory.emitterCategory; } else { label37.Text = "Emitter Category: "; }
                if (asterixFile.getListCat21()[e.RowIndex].metInformation != null) { label38.Text = "Met Information: " + METinfoDEC(asterixFile, e.RowIndex); } else { label38.Text = "Met Information: "; }
                if (asterixFile.getListCat21()[e.RowIndex].selectedAltitude != null) { label39.Text = "Selected Altitude: " + asterixFile.getListCat21()[e.RowIndex].selectedAltitude.altitude; } else { label39.Text = "Selected Altitude: "; }
                if (asterixFile.getListCat21()[e.RowIndex].trajectoryIntent != null) { label40.Text = "Trajectory Intent: " + TrajectoryDEC(asterixFile, e.RowIndex); } else { label40.Text = "Trajectory Intent: "; }
                if (asterixFile.getListCat21()[e.RowIndex].serviceManagement != null) { label41.Text = "Service Management: " + asterixFile.getListCat21()[e.RowIndex].serviceManagement.reportPeriod; } else { label41.Text = "Service Management: "; }
                if (asterixFile.getListCat21()[e.RowIndex].aircraftOperationalStatus != null) { label42.Text = "Aircraft Operational Status: " + OperationalStatusDEC(asterixFile, e.RowIndex); } else { label42.Text = "Aircraft Operational Status: "; }
                if (asterixFile.getListCat21()[e.RowIndex].surfaceCapabilitiesAndCharacteristics != null) { label43.Text = "Surface Capabilities And Characteristics: " + SurfaceDEC(asterixFile, e.RowIndex); } else { label43.Text = "Surface Capabilities And Characteristics: "; }
                if (asterixFile.getListCat21()[e.RowIndex].messageAmplitude != null) { label44.Text = "Message Amplitude: " + asterixFile.getListCat21()[e.RowIndex].messageAmplitude.messageAmplitudedBm; } else { label44.Text = "Message Amplitude: "; }
                if (asterixFile.getListCat21()[e.RowIndex].modeSMBData != null) { label45.Text = "Mode S MB Data: " + asterixFile.getListCat21()[e.RowIndex].modeSMBData.bdsList; } else { label45.Text = "Mode S MB Data: "; }
                if (asterixFile.getListCat21()[e.RowIndex].aCASResolutionAdvisoryReport != null) { label47.Text = "ACAS Resolution Advisory Report: " + ACASResolDEC(asterixFile, e.RowIndex); } else { label47.Text = "ACAS Resolution Advisory Report: "; }
                if (asterixFile.getListCat21()[e.RowIndex].receiverId != null) { label48.Text = "Receiver ID: " + asterixFile.getListCat21()[e.RowIndex].receiverId.receiverId; } else { label48.Text = "Receiver ID: "; }
                if (asterixFile.getListCat21()[e.RowIndex].dataAges != null) {dataAgeRowInt = e.RowIndex; label49.Text = "Data Ages: double click to see info"; } else { dataAgeRowInt = -1; label49.Text = "Data Ages: "; }
                if (asterixFile.getListCat21()[e.RowIndex].targetReportDescriptor != null) { label50.Text = "Target Report Description: " + TargetDevolver(asterixFile, e.RowIndex); } else { label50.Text = "Target Report Description: "; }
                if (asterixFile.getListCat21()[e.RowIndex].serviceIdentification != null) { label51.Text = "Service Identification: " + asterixFile.getListCat21()[e.RowIndex].serviceIdentification.serviceIdentification; } else { label51.Text = "Service Identification: "; }
            }
        }

        public string TargetDevolver(AsterixFile asterix, int index)
        {
            string total = "";
            total = total + "\n" + asterix.getListCat21()[index].targetReportDescriptor.addressType;
            total = total + "\n" + asterix.getListCat21()[index].targetReportDescriptor.altitudeReportingCapability;
            total = total + "\n" + asterix.getListCat21()[index].targetReportDescriptor.rangeCheck;
            total = total + "\n" + asterix.getListCat21()[index].targetReportDescriptor.reportType;
            if (asterix.getListCat21()[index].targetReportDescriptor.diferentialCorrectionADSB == true) { total = total + "\n" + "Difernetial Correction ADSB"; }
            if (asterix.getListCat21()[index].targetReportDescriptor.groundBitSet == true) { total = total + "\n" + "Ground Bit Set"; }
            if (asterix.getListCat21()[index].targetReportDescriptor.simulatedTarget == true) { total = total + "\n" + "Simulated Target"; }
            if (asterix.getListCat21()[index].targetReportDescriptor.testTarget == true) { total = total + "\n" + "Test Target"; }
            if (asterix.getListCat21()[index].targetReportDescriptor.selectedAltitudeAvailable == true) { total = total + "\n" + "Selected Altitude Available"; }
            total = total + "\n" + asterix.getListCat21()[index].targetReportDescriptor.confidenceLevel;
            if (asterix.getListCat21()[index].targetReportDescriptor.independentPositionCheckFailed == true) { total = total + "\n" + "Independent Position Check Failed"; }
            if (asterix.getListCat21()[index].targetReportDescriptor.nogoBitSet == true) { total = total + "\n" + "No go Bit Set"; }
            if (asterix.getListCat21()[index].targetReportDescriptor.compactPositionReportingValidationFailed == true) { total = total + "\n" + "Compact Position Reporting Validation Failed"; }
            if (asterix.getListCat21()[index].targetReportDescriptor.localDecodingPositionJumpDetected == true) { total = total + "\n" + "Local Decoding Position Jump Detected"; }
            if (asterix.getListCat21()[index].targetReportDescriptor.rangeCheckFailed == true) { total = total + "\n" + "Range Check Failed"; }
            return total;
        }

        public string QualityIndicatorsDec(AsterixFile asterix, int index)
        {
            string global = "";
            global = "Navigation Accuracy Category Velocity: " + Convert.ToString(asterix.getListCat21()[index].qualityIndicators.navigationAccuracyCategoryVelocity) + "\n" + "Navigation Integrity Category Position: " + Convert.ToString(asterix.getListCat21()[index].qualityIndicators.navigationIntegrityCategoryPosition);
            global = global + "\n" + "Navigation Integrity Category Baro Altitud: " + Convert.ToString(asterix.getListCat21()[index].qualityIndicators.navigationIntegrityCategoryBaroAlt) + "\n" + "Surveillance Integrity Level: " + Convert.ToString(asterix.getListCat21()[index].qualityIndicators.surveillanceIntegrityLevel) + "\n" + "Navigation Accuracy Category Position: " + Convert.ToString(asterix.getListCat21()[index].qualityIndicators.navigationAccuracyCategoryPosition);
            global = global + "SIL-Supplement: " + asterix.getListCat21()[index].qualityIndicators.silSupplement + "\n" + "Horizontal Position System Design Assurance Level: " + Convert.ToString(asterix.getListCat21()[index].qualityIndicators.horizontalPositionSystemDesignAssuranceLevel) + "\n" + "Geometric Altitude Accuracy Category: " + Convert.ToString(asterix.getListCat21()[index].qualityIndicators.geometricAltitudeAccuracyCategory);
            global = global + "\n" + "Position Integrity Category: " + Convert.ToString(asterix.getListCat21()[index].qualityIndicators.positionIntegrityCategory);
            return global;
        }

        public string MOPSDEC(AsterixFile asterix, int index)
        {
            string global = "";
            global = "Version Not Supported: " + asterix.getListCat21()[index].mOPSVersion.versionNotSupported + "\n" + "Version NUmber " + asterix.getListCat21()[index].mOPSVersion.versionNumber + "\n" + "Link Technology Type: " + asterix.getListCat21()[index].mOPSVersion.linkTechnologyType;
            return global;
        }

        public string GroundVector(AsterixFile asterix,int index)
        {
            string global = "";
            global = "Range Exceeded: " + asterix.getListCat21()[index].airborneGroundVector.rangeExceeded + "\n" + "Ground Speed: " + asterix.getListCat21()[index].airborneGroundVector.groundSpeed + "\n" + "Track Angle: " + asterix.getListCat21()[index].airborneGroundVector.trackAngle;
            return global;
        }

        public string METinfoDEC(AsterixFile asterix, int index)
        {
            string global = "";
            global = global + "Wind Speed: " + asterix.getListCat21()[index].metInformation.windSpeed + "\n";
            global = global + "Wind Direction: " + asterix.getListCat21()[index].metInformation.windDirection + "\n";
            global = global + "Temperature: " + asterix.getListCat21()[index].metInformation.temperature + "\n";
            global = global + "Turbulance: " + asterix.getListCat21()[index].metInformation.turbulence + "\n";
            return global;
        }

        public string TrajectoryDEC(AsterixFile asterix, int index)
        {
            string global = "";
            global = "Trajectory Intent Data Not Available: " + asterix.getListCat21()[index].trajectoryIntent.trajectoryIntentDataNotAvailable + "\n" + "Trajectory Intent Data Not Valid: " + asterix.getListCat21()[index].trajectoryIntent.trajectoryIntentDataNotValid;
            return global;
        }

        public string OperationalStatusDEC(AsterixFile asterix, int index)
        {
            string global = "";
            global = "Tcas Resolution Advisory Active: " + asterix.getListCat21()[index].aircraftOperationalStatus.tcasResolutionAdvisoryActive + "\n" + "Target Trajectory Change Report Capability: " + asterix.getListCat21()[index].aircraftOperationalStatus.targetTrajectoryChangeReportCapability + "\n" + "Target State Report Capability: " + asterix.getListCat21()[index].aircraftOperationalStatus.targetStateReportCapability + "\n" + "Air Referenced Velocity Report Capability: " + asterix.getListCat21()[index].aircraftOperationalStatus.airReferencedVelocityReportCapability + "\n" + "CDTI Operational: " + asterix.getListCat21()[index].aircraftOperationalStatus.cdtiOperational + "\n" + "Tcas Not Operational: " + asterix.getListCat21()[index].aircraftOperationalStatus.tcasNotOperational + "\n" + "Single Antenna: " + asterix.getListCat21()[index].aircraftOperationalStatus.singleAntenna;
            return global;
        }

        public string SurfaceDEC(AsterixFile asterix, int index)
        {
            string global = "";
            global = "Position In ADSB Reference Point: " + asterix.getListCat21()[index].surfaceCapabilitiesAndCharacteristics.positionIsADSBReferencePoint + "\n" + "CDTI Operational: " + asterix.getListCat21()[index].surfaceCapabilitiesAndCharacteristics.cdtiOperational + "\n" + "B2 Low Power: " + asterix.getListCat21()[index].surfaceCapabilitiesAndCharacteristics.b2LowPower + "\n" + "Receiving Atc Services: " + asterix.getListCat21()[index].surfaceCapabilitiesAndCharacteristics.receivingAtcServices + "\n" + "Ident Switch Active: " + asterix.getListCat21()[index].surfaceCapabilitiesAndCharacteristics.identSwitchActive;
            global = global + "\n" + "Length Width: " + asterix.getListCat21()[index].surfaceCapabilitiesAndCharacteristics.lengthWidth;
            return global;
        }

        public string ACASResolDEC(AsterixFile asterix, int index)
        {
            string global = "";
            global = "Message Type: " + asterix.getListCat21()[index].aCASResolutionAdvisoryReport.messageType + "\n" + "Message Subtype: " + asterix.getListCat21()[index].aCASResolutionAdvisoryReport.messageSubtype + "\n" + "Active Resolution Advisories: " + asterix.getListCat21()[index].aCASResolutionAdvisoryReport.activeResolutionAdvisories + "\n" + "RA Complement Record: " + asterix.getListCat21()[index].aCASResolutionAdvisoryReport.raComplementRecord + "\n" + "RA Terminated: " + asterix.getListCat21()[index].aCASResolutionAdvisoryReport.raTerminated + "\n" + "Multiple Threat Encounter: " + asterix.getListCat21()[index].aCASResolutionAdvisoryReport.multipleThreatEncounter + "\n" + "Threat Type Indicator: " + asterix.getListCat21()[index].aCASResolutionAdvisoryReport.threatTypeIndicator + "\n" + "Threat Identity Data: " + asterix.getListCat21()[index].aCASResolutionAdvisoryReport.threatIdentityData;
            return global;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
        }

        private void table2_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastre = false;
        }

        private void table2_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Arrastre == true)
            {
                this.SetDesktopLocation(MousePosition.X - ex, MousePosition.Y - ey);
            }
        }

        private void table2_MouseDown(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            Arrastre = true;
        }

        private void panelTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastre = false;
        }

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Arrastre == true)
            {
                this.SetDesktopLocation(MousePosition.X - ex, MousePosition.Y - ey);
            }
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            Arrastre = true;
        }

        private void label49_DoubleClick(object sender, EventArgs e)
        {
            if (dataAgeRowInt != null)
            {
                var dataAges = asterixFile.getListCat21()[dataAgeRowInt].dataAges.ageItems;
                string boxString = "AGES IN SECONDS: \n";
                foreach (var iiItem in dataAges)
                {
                    boxString += String.Format("{0}: {1}\n", iiItem.itemClass, iiItem.age);
                }
                MessageBox.Show(String.Format(boxString));
            }
        }
    }
}
