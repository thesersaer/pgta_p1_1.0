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
        int Page = 0;

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
                    //    var decodificado=asterixFile.getListCat21()[i];
                    //    decodificado.decodeDataFields();
                    //    object dataSourceItem = decodificado.getDecodedField("DataSourceIdentification");
                    //    var algo = (FlightDataLib.DataSourceIdentification)dataSourceItem;
                    //    dataGridView1[2, i].Value = algo.getSac();
                    //    //    int index = asterixFile.getListCatAll()[i].NumLlista;
                    //    //    dataGridView1[0, i].Value = i;
                    //    //    dataGridView1[1, i].Value = "CAT 10 MLAT";
                    //    //    dataGridView1[2, i].Value = asterixFile.getListCat21()[index].SAC;
                    //    //    dataGridView1[3, i].Value = asterixFile.getListCat21()[index].SIC;
                    //    //    dataGridView1[4, i].Value = asterixFile.getListCat21()[index].TargetID;
                    //    //    dataGridView1[5, i].Value = asterixFile.getListCat21()[index].TrackNumber;
                    //    //    dataGridView1[6, i].Value = asterixFile.getListCat21()[index].TimeOfDay;
                    //    //    dataGridView1[7, i].Value = asterixFile.getListCat21()[index].TargetAddress;
                    //    i++;
                    //}
                }
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
                else if(asterixFile.getListCatAll()[rowindex].CATMode == "MLAT")
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
            }
            else if(Mode == 1)
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
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
            dataGridView1.Rows.Clear();
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
            dataGridView1.Rows.Clear();
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
                else if(Page == 1)
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
                else if(Page == 2)
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
                else if(Page == 3)
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string busca = textBoxBuscar.Text;
            if (0 < asterixFile.getListCat10SMR().Count)
            {
                i = 0;
                int rownum = 0;
                dataGridView1.RowCount = asterixFile.getListCat10SMR().Count;
                while (i < asterixFile.getListCat10SMR().Count)
                {
                    if (asterixFile.getListCat10SMR()[i].TrackNumber == busca)
                    {
                        dataGridView1[0, rownum].Value = i;
                        dataGridView1[1, rownum].Value = "CAT 10 SMR";
                        dataGridView1[2, rownum].Value = asterixFile.getListCat10SMR()[i].SAC;
                        dataGridView1[3, rownum].Value = asterixFile.getListCat10SMR()[i].SIC;
                        dataGridView1[4, rownum].Value = asterixFile.getListCat10SMR()[i].TargetID;
                        dataGridView1[5, rownum].Value = asterixFile.getListCat10SMR()[i].TrackNumber;
                        dataGridView1[6, rownum].Value = asterixFile.getListCat10SMR()[i].TimeOfDay;
                        dataGridView1[7, rownum].Value = asterixFile.getListCat10SMR()[i].TargetAddress;
                        rownum++;
                    }
                    i++;
                }
            }
            if (0 < asterixFile.getListCat10MLAT().Count)
            {
                i = 0;
                int rownum = 0;
                dataGridView1.RowCount = asterixFile.getListCat10MLAT().Count;
                while (i < asterixFile.getListCat10MLAT().Count)
                {
                    if (asterixFile.getListCat10MLAT()[i].TrackNumber == busca)
                    {
                        dataGridView1[0, rownum].Value = i;
                        dataGridView1[1, rownum].Value = "CAT 10 MLAT";
                        dataGridView1[2, rownum].Value = asterixFile.getListCat10MLAT()[i].SAC;
                        dataGridView1[3, rownum].Value = asterixFile.getListCat10MLAT()[i].SIC;
                        dataGridView1[4, rownum].Value = asterixFile.getListCat10MLAT()[i].TargetID;
                        dataGridView1[5, rownum].Value = asterixFile.getListCat10MLAT()[i].TrackNumber;
                        dataGridView1[6, rownum].Value = asterixFile.getListCat10MLAT()[i].TimeOfDay;
                        dataGridView1[7, rownum].Value = asterixFile.getListCat10MLAT()[i].TargetAddress;
                        rownum++;
                    }
                    i++;
                }
            }
        }
    }
}
