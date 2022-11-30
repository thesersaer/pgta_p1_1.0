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

        public table2(AsterixFile asterixFile)
        {
            InitializeComponent();
            this.asterixFile = asterixFile;
        }

        private void table2_Load(object sender, EventArgs e)
        {
            asterixFile.tabulateCatAll();
            this.tableCatAll = asterixFile.getTableCatAll();
            dataGridView1.DataSource = tableCatAll;
            filtFieldsBox.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int iiDtCol = 0; iiDtCol < tableCatAll.Columns.Count; iiDtCol++)
            {
                filtFieldsBox.Items.Add(tableCatAll.Columns[iiDtCol].ColumnName);
            }
            filtFieldsBox.SelectedIndex = 0;
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
            else
            {
                MessageBox.Show("Minimum pages reached");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (Page < 3 && Page >= 0)
            {
                Page = Page + 1;
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
            else
            {
                MessageBox.Show("There are no more pages");
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
                    labelTargetRepDescrip.Text = TargetDevolver(asterixFile, e.RowIndex);
                    if (asterixFile.getListCat21()[e.RowIndex].flightLevel != null) { labelFL.Text = "FL " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].flightLevel.flightLevel); }
                    if (asterixFile.getListCat21()[e.RowIndex].positionWGS84 != null)
                    {
                        labelPosWGS84.Text = Convert.ToString(asterixFile.getListCat21()[e.RowIndex].positionWGS84.latitude) + "º, " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].positionWGS84.longitude) + "º";
                    }
                    if (asterixFile.getListCat21()[e.RowIndex].trueAirspeed != null)
                    {
                        label16.Text = "Airspeed: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].trueAirspeed.trueAirspeed);
                    }
                    if (asterixFile.getListCat21()[e.RowIndex].targetStatus != null)
                    {
                        label22.Text = "Surveillance Status: " + asterixFile.getListCat21()[e.RowIndex].targetStatus.surveillanceStatus + "\n" + "Priority Status: " + asterixFile.getListCat21()[e.RowIndex].targetStatus.priorityStatus;
                    }
                    if (asterixFile.getListCat21()[e.RowIndex].timeOfApplicabilityPosition != null) { label23.Text = "Time Of Applicability Position: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].timeOfApplicabilityPosition.toaSeconds) + " s"; }
                    if (asterixFile.getListCat21()[e.RowIndex].timeOfMessageReceptionPosition != null) { label24.Text = "Time Of Message Reception Position: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].timeOfMessageReceptionPosition.tomSeconds) + " s"; }
                    if (asterixFile.getListCat21()[e.RowIndex].trackAngleRate != null) { label25.Text = "Track Angle Rate: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].trackAngleRate.trackAngleRate) + " º/s"; }




                }
            }
            else if (Mode == 1)
            {
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
                labelTargetRepDescrip.Text = TargetDevolver(asterixFile, e.RowIndex);
                if (asterixFile.getListCat21()[e.RowIndex].flightLevel != null) { labelFL.Text = "FL " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].flightLevel.flightLevel); }
                labelPosWGS84.Text = Convert.ToString(asterixFile.getListCat21()[e.RowIndex].positionWGS84.latitude) + "º, " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].positionWGS84.longitude) + "º";
                label16.Text = "Airspeed: " + Convert.ToString(asterixFile.getListCat21()[e.RowIndex].trueAirspeed.trueAirspeed);
                label22.Text = "Surveillance Status: " + asterixFile.getListCat21()[e.RowIndex].targetStatus.surveillanceStatus +"\n" +"Priority Status: "+asterixFile.getListCat21()[e.RowIndex].targetStatus.priorityStatus;

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
    }
}
