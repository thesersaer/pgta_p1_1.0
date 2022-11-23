
namespace Graphics
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOfDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonCAT10SMR = new System.Windows.Forms.Button();
            this.buttonCAT10MLAT = new System.Windows.Forms.Button();
            this.buttonCAT21ADSB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTargetRepDescrip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelMessageType = new System.Windows.Forms.Label();
            this.labelPreprogrammedMessage = new System.Windows.Forms.Label();
            this.labelFleetID = new System.Windows.Forms.Label();
            this.labelSystemStatus = new System.Windows.Forms.Label();
            this.labelSizeOrientation = new System.Windows.Forms.Label();
            this.labelVeloPolar = new System.Windows.Forms.Label();
            this.labelVeloCart = new System.Windows.Forms.Label();
            this.labelPosPolar = new System.Windows.Forms.Label();
            this.labelPosCart = new System.Windows.Forms.Label();
            this.labelPosWGS84 = new System.Windows.Forms.Label();
            this.labelTrackStatus = new System.Windows.Forms.Label();
            this.labelFL = new System.Windows.Forms.Label();
            this.labelCalculatedAccel = new System.Windows.Forms.Label();
            this.labelPresence = new System.Windows.Forms.Label();
            this.labelStandardDevi = new System.Windows.Forms.Label();
            this.labelModeS = new System.Windows.Forms.Label();
            this.labelMode3A = new System.Windows.Forms.Label();
            this.labelMeasuredHeight = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelPAM = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelTituloPage = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelPage = new System.Windows.Forms.Label();
            this.buttonMap = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Category,
            this.SAC,
            this.SIC,
            this.TargetID,
            this.TrackNumber,
            this.TimeOfDay,
            this.TargetAddress});
            this.dataGridView1.Location = new System.Drawing.Point(13, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(840, 674);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Number
            // 
            this.Number.FillWeight = 273.0359F;
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 112;
            this.Number.Name = "Number";
            this.Number.Width = 112;
            // 
            // Category
            // 
            this.Category.FillWeight = 244.9939F;
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 101;
            this.Category.Name = "Category";
            this.Category.Width = 101;
            // 
            // SAC
            // 
            this.SAC.FillWeight = 219.8951F;
            this.SAC.HeaderText = "SAC";
            this.SAC.MinimumWidth = 90;
            this.SAC.Name = "SAC";
            this.SAC.Width = 90;
            // 
            // SIC
            // 
            this.SIC.FillWeight = 197.4305F;
            this.SIC.HeaderText = "SIC";
            this.SIC.MinimumWidth = 90;
            this.SIC.Name = "SIC";
            this.SIC.Width = 90;
            // 
            // TargetID
            // 
            this.TargetID.FillWeight = 177.3237F;
            this.TargetID.HeaderText = "Target Identification";
            this.TargetID.MinimumWidth = 101;
            this.TargetID.Name = "TargetID";
            this.TargetID.Width = 101;
            // 
            // TrackNumber
            // 
            this.TrackNumber.FillWeight = 159.3273F;
            this.TrackNumber.HeaderText = "Track Number";
            this.TrackNumber.MinimumWidth = 90;
            this.TrackNumber.Name = "TrackNumber";
            this.TrackNumber.Width = 90;
            // 
            // TimeOfDay
            // 
            this.TimeOfDay.FillWeight = 104.3601F;
            this.TimeOfDay.HeaderText = "Time of Day";
            this.TimeOfDay.MinimumWidth = 101;
            this.TimeOfDay.Name = "TimeOfDay";
            this.TimeOfDay.Width = 101;
            // 
            // TargetAddress
            // 
            this.TargetAddress.FillWeight = 46.42459F;
            this.TargetAddress.HeaderText = "Target Address";
            this.TargetAddress.MinimumWidth = 101;
            this.TargetAddress.Name = "TargetAddress";
            this.TargetAddress.Width = 101;
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(13, 7);
            this.buttonAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(75, 23);
            this.buttonAll.TabIndex = 1;
            this.buttonAll.Text = "ALL";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonCAT10SMR
            // 
            this.buttonCAT10SMR.Location = new System.Drawing.Point(93, 7);
            this.buttonCAT10SMR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCAT10SMR.Name = "buttonCAT10SMR";
            this.buttonCAT10SMR.Size = new System.Drawing.Size(108, 23);
            this.buttonCAT10SMR.TabIndex = 2;
            this.buttonCAT10SMR.Text = "CAT 10 SMR";
            this.buttonCAT10SMR.UseVisualStyleBackColor = true;
            this.buttonCAT10SMR.Click += new System.EventHandler(this.buttonCAT10SMR_Click);
            // 
            // buttonCAT10MLAT
            // 
            this.buttonCAT10MLAT.Location = new System.Drawing.Point(208, 7);
            this.buttonCAT10MLAT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCAT10MLAT.Name = "buttonCAT10MLAT";
            this.buttonCAT10MLAT.Size = new System.Drawing.Size(121, 23);
            this.buttonCAT10MLAT.TabIndex = 3;
            this.buttonCAT10MLAT.Text = "CAT 10 MLAT";
            this.buttonCAT10MLAT.UseVisualStyleBackColor = true;
            this.buttonCAT10MLAT.Click += new System.EventHandler(this.buttonCAT10MLAT_Click);
            // 
            // buttonCAT21ADSB
            // 
            this.buttonCAT21ADSB.Location = new System.Drawing.Point(335, 7);
            this.buttonCAT21ADSB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCAT21ADSB.Name = "buttonCAT21ADSB";
            this.buttonCAT21ADSB.Size = new System.Drawing.Size(115, 23);
            this.buttonCAT21ADSB.TabIndex = 4;
            this.buttonCAT21ADSB.Text = "CAT 21 ADSB";
            this.buttonCAT21ADSB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(889, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Target Report Descriptor:";
            // 
            // labelTargetRepDescrip
            // 
            this.labelTargetRepDescrip.AutoSize = true;
            this.labelTargetRepDescrip.Location = new System.Drawing.Point(1066, 55);
            this.labelTargetRepDescrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTargetRepDescrip.Name = "labelTargetRepDescrip";
            this.labelTargetRepDescrip.Size = new System.Drawing.Size(13, 17);
            this.labelTargetRepDescrip.TabIndex = 6;
            this.labelTargetRepDescrip.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(889, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Message Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(889, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Flight Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(889, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Track Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(889, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Position in WGS-84 Coordinates:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(889, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Position in Cartesian Coordiantes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(889, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Position in Polar Coordianets:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(889, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Pre-programmed Message:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(890, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Vehicle Fleet Identification:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(889, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "System Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(889, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Target Size and Orientation:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(889, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(233, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Track Velocity in Polar Coordinates:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(889, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(260, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Track Velocity in Cartesian Coordinates:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(889, 485);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Measured Height:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(889, 515);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Calculated Acceleration:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(889, 296);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "Presence:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(889, 268);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(203, 17);
            this.label18.TabIndex = 22;
            this.label18.Text = "Standard Deviation of Position:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(890, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 17);
            this.label19.TabIndex = 21;
            this.label19.Text = "Mode S MB data:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(890, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 17);
            this.label20.TabIndex = 20;
            this.label20.Text = "Mode 3A Code:";
            // 
            // labelMessageType
            // 
            this.labelMessageType.AutoSize = true;
            this.labelMessageType.Location = new System.Drawing.Point(1001, 55);
            this.labelMessageType.Name = "labelMessageType";
            this.labelMessageType.Size = new System.Drawing.Size(13, 17);
            this.labelMessageType.TabIndex = 26;
            this.labelMessageType.Text = "-";
            // 
            // labelPreprogrammedMessage
            // 
            this.labelPreprogrammedMessage.AutoSize = true;
            this.labelPreprogrammedMessage.Location = new System.Drawing.Point(1075, 236);
            this.labelPreprogrammedMessage.Name = "labelPreprogrammedMessage";
            this.labelPreprogrammedMessage.Size = new System.Drawing.Size(13, 17);
            this.labelPreprogrammedMessage.TabIndex = 27;
            this.labelPreprogrammedMessage.Text = "-";
            // 
            // labelFleetID
            // 
            this.labelFleetID.AutoSize = true;
            this.labelFleetID.Location = new System.Drawing.Point(1067, 285);
            this.labelFleetID.Name = "labelFleetID";
            this.labelFleetID.Size = new System.Drawing.Size(13, 17);
            this.labelFleetID.TabIndex = 28;
            this.labelFleetID.Text = "-";
            // 
            // labelSystemStatus
            // 
            this.labelSystemStatus.AutoSize = true;
            this.labelSystemStatus.Location = new System.Drawing.Point(997, 112);
            this.labelSystemStatus.Name = "labelSystemStatus";
            this.labelSystemStatus.Size = new System.Drawing.Size(13, 17);
            this.labelSystemStatus.TabIndex = 29;
            this.labelSystemStatus.Text = "-";
            // 
            // labelSizeOrientation
            // 
            this.labelSizeOrientation.AutoSize = true;
            this.labelSizeOrientation.Location = new System.Drawing.Point(1082, 84);
            this.labelSizeOrientation.Name = "labelSizeOrientation";
            this.labelSizeOrientation.Size = new System.Drawing.Size(13, 17);
            this.labelSizeOrientation.TabIndex = 30;
            this.labelSizeOrientation.Text = "-";
            // 
            // labelVeloPolar
            // 
            this.labelVeloPolar.AutoSize = true;
            this.labelVeloPolar.Location = new System.Drawing.Point(1128, 459);
            this.labelVeloPolar.Name = "labelVeloPolar";
            this.labelVeloPolar.Size = new System.Drawing.Size(13, 17);
            this.labelVeloPolar.TabIndex = 31;
            this.labelVeloPolar.Text = "-";
            // 
            // labelVeloCart
            // 
            this.labelVeloCart.AutoSize = true;
            this.labelVeloCart.Location = new System.Drawing.Point(1155, 430);
            this.labelVeloCart.Name = "labelVeloCart";
            this.labelVeloCart.Size = new System.Drawing.Size(13, 17);
            this.labelVeloCart.TabIndex = 32;
            this.labelVeloCart.Text = "-";
            // 
            // labelPosPolar
            // 
            this.labelPosPolar.AutoSize = true;
            this.labelPosPolar.Location = new System.Drawing.Point(1089, 402);
            this.labelPosPolar.Name = "labelPosPolar";
            this.labelPosPolar.Size = new System.Drawing.Size(13, 17);
            this.labelPosPolar.TabIndex = 33;
            this.labelPosPolar.Text = "-";
            // 
            // labelPosCart
            // 
            this.labelPosCart.AutoSize = true;
            this.labelPosCart.Location = new System.Drawing.Point(1116, 373);
            this.labelPosCart.Name = "labelPosCart";
            this.labelPosCart.Size = new System.Drawing.Size(13, 17);
            this.labelPosCart.TabIndex = 34;
            this.labelPosCart.Text = "-";
            // 
            // labelPosWGS84
            // 
            this.labelPosWGS84.AutoSize = true;
            this.labelPosWGS84.Location = new System.Drawing.Point(1110, 343);
            this.labelPosWGS84.Name = "labelPosWGS84";
            this.labelPosWGS84.Size = new System.Drawing.Size(13, 17);
            this.labelPosWGS84.TabIndex = 35;
            this.labelPosWGS84.Text = "-";
            // 
            // labelTrackStatus
            // 
            this.labelTrackStatus.AutoSize = true;
            this.labelTrackStatus.Location = new System.Drawing.Point(987, 93);
            this.labelTrackStatus.Name = "labelTrackStatus";
            this.labelTrackStatus.Size = new System.Drawing.Size(13, 17);
            this.labelTrackStatus.TabIndex = 36;
            this.labelTrackStatus.Text = "-";
            // 
            // labelFL
            // 
            this.labelFL.AutoSize = true;
            this.labelFL.Location = new System.Drawing.Point(979, 55);
            this.labelFL.Name = "labelFL";
            this.labelFL.Size = new System.Drawing.Size(13, 17);
            this.labelFL.TabIndex = 37;
            this.labelFL.Text = "-";
            // 
            // labelCalculatedAccel
            // 
            this.labelCalculatedAccel.AutoSize = true;
            this.labelCalculatedAccel.Location = new System.Drawing.Point(1055, 515);
            this.labelCalculatedAccel.Name = "labelCalculatedAccel";
            this.labelCalculatedAccel.Size = new System.Drawing.Size(13, 17);
            this.labelCalculatedAccel.TabIndex = 38;
            this.labelCalculatedAccel.Text = "-";
            // 
            // labelPresence
            // 
            this.labelPresence.AutoSize = true;
            this.labelPresence.Location = new System.Drawing.Point(967, 296);
            this.labelPresence.Name = "labelPresence";
            this.labelPresence.Size = new System.Drawing.Size(13, 17);
            this.labelPresence.TabIndex = 40;
            this.labelPresence.Text = "-";
            // 
            // labelStandardDevi
            // 
            this.labelStandardDevi.AutoSize = true;
            this.labelStandardDevi.Location = new System.Drawing.Point(1098, 268);
            this.labelStandardDevi.Name = "labelStandardDevi";
            this.labelStandardDevi.Size = new System.Drawing.Size(13, 17);
            this.labelStandardDevi.TabIndex = 41;
            this.labelStandardDevi.Text = "-";
            // 
            // labelModeS
            // 
            this.labelModeS.AutoSize = true;
            this.labelModeS.Location = new System.Drawing.Point(1012, 84);
            this.labelModeS.Name = "labelModeS";
            this.labelModeS.Size = new System.Drawing.Size(13, 17);
            this.labelModeS.TabIndex = 42;
            this.labelModeS.Text = "-";
            // 
            // labelMode3A
            // 
            this.labelMode3A.AutoSize = true;
            this.labelMode3A.Location = new System.Drawing.Point(1001, 55);
            this.labelMode3A.Name = "labelMode3A";
            this.labelMode3A.Size = new System.Drawing.Size(13, 17);
            this.labelMode3A.TabIndex = 43;
            this.labelMode3A.Text = "-";
            // 
            // labelMeasuredHeight
            // 
            this.labelMeasuredHeight.AutoSize = true;
            this.labelMeasuredHeight.Location = new System.Drawing.Point(1015, 485);
            this.labelMeasuredHeight.Name = "labelMeasuredHeight";
            this.labelMeasuredHeight.Size = new System.Drawing.Size(13, 17);
            this.labelMeasuredHeight.TabIndex = 44;
            this.labelMeasuredHeight.Text = "-";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(1463, 700);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(109, 29);
            this.buttonNext.TabIndex = 45;
            this.buttonNext.Text = "Next Page";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(1348, 700);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(109, 29);
            this.buttonPrevious.TabIndex = 46;
            this.buttonPrevious.Text = "Previous Page";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelPAM
            // 
            this.labelPAM.AutoSize = true;
            this.labelPAM.Location = new System.Drawing.Point(1065, 324);
            this.labelPAM.Name = "labelPAM";
            this.labelPAM.Size = new System.Drawing.Size(13, 17);
            this.labelPAM.TabIndex = 48;
            this.labelPAM.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(889, 324);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(170, 17);
            this.label21.TabIndex = 47;
            this.label21.Text = "Amplitude of Primary Plot:";
            // 
            // labelTituloPage
            // 
            this.labelTituloPage.AutoSize = true;
            this.labelTituloPage.Location = new System.Drawing.Point(889, 13);
            this.labelTituloPage.Name = "labelTituloPage";
            this.labelTituloPage.Size = new System.Drawing.Size(75, 17);
            this.labelTituloPage.TabIndex = 49;
            this.labelTituloPage.Text = "Navigation";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(12, 764);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(340, 22);
            this.textBoxBuscar.TabIndex = 50;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(358, 764);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 51;
            this.buttonBuscar.Text = "Search";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Location = new System.Drawing.Point(1446, 732);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(28, 17);
            this.labelPage.TabIndex = 52;
            this.labelPage.Text = "1/4";
            // 
            // buttonMap
            // 
            this.buttonMap.Location = new System.Drawing.Point(1348, 788);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(224, 53);
            this.buttonMap.TabIndex = 53;
            this.buttonMap.Text = "MAP";
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.buttonMap_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 806);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 54;
            this.label16.Text = "Search by:";
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.ItemHeight = 16;
            this.listBoxSearch.Items.AddRange(new object[] {
            "Track Number",
            "Target Address",
            "Number"});
            this.listBoxSearch.Location = new System.Drawing.Point(93, 806);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(120, 68);
            this.listBoxSearch.TabIndex = 55;
            this.listBoxSearch.Click += new System.EventHandler(this.listBoxSearch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 806);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 56;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 1055);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxSearch);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonMap);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.labelTituloPage);
            this.Controls.Add(this.labelPAM);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelMeasuredHeight);
            this.Controls.Add(this.labelMode3A);
            this.Controls.Add(this.labelModeS);
            this.Controls.Add(this.labelStandardDevi);
            this.Controls.Add(this.labelPresence);
            this.Controls.Add(this.labelCalculatedAccel);
            this.Controls.Add(this.labelFL);
            this.Controls.Add(this.labelTrackStatus);
            this.Controls.Add(this.labelPosWGS84);
            this.Controls.Add(this.labelPosCart);
            this.Controls.Add(this.labelPosPolar);
            this.Controls.Add(this.labelVeloCart);
            this.Controls.Add(this.labelVeloPolar);
            this.Controls.Add(this.labelSizeOrientation);
            this.Controls.Add(this.labelSystemStatus);
            this.Controls.Add(this.labelFleetID);
            this.Controls.Add(this.labelPreprogrammedMessage);
            this.Controls.Add(this.labelMessageType);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTargetRepDescrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCAT21ADSB);
            this.Controls.Add(this.buttonCAT10MLAT);
            this.Controls.Add(this.buttonCAT10SMR);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonCAT10SMR;
        private System.Windows.Forms.Button buttonCAT10MLAT;
        private System.Windows.Forms.Button buttonCAT21ADSB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTargetRepDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOfDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelMessageType;
        private System.Windows.Forms.Label labelPreprogrammedMessage;
        private System.Windows.Forms.Label labelFleetID;
        private System.Windows.Forms.Label labelSystemStatus;
        private System.Windows.Forms.Label labelSizeOrientation;
        private System.Windows.Forms.Label labelVeloPolar;
        private System.Windows.Forms.Label labelVeloCart;
        private System.Windows.Forms.Label labelPosPolar;
        private System.Windows.Forms.Label labelPosCart;
        private System.Windows.Forms.Label labelPosWGS84;
        private System.Windows.Forms.Label labelTrackStatus;
        private System.Windows.Forms.Label labelFL;
        private System.Windows.Forms.Label labelCalculatedAccel;
        private System.Windows.Forms.Label labelPresence;
        private System.Windows.Forms.Label labelStandardDevi;
        private System.Windows.Forms.Label labelModeS;
        private System.Windows.Forms.Label labelMode3A;
        private System.Windows.Forms.Label labelMeasuredHeight;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Label labelPAM;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelTituloPage;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.Button button1;
    }
}