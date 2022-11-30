
namespace Graphics
{
    partial class Mapa
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
            this.components = new System.ComponentModel.Container();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonConfig = new System.Windows.Forms.Button();
            this.buttonLEBL = new System.Windows.Forms.Button();
            this.buttonBCN = new System.Windows.Forms.Button();
            this.buttonCAT = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonInitialH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxHH = new System.Windows.Forms.ListBox();
            this.listBoxMM = new System.Windows.Forms.ListBox();
            this.listBoxSS = new System.Windows.Forms.ListBox();
            this.trackBarZOOM = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewINFO = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZOOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewINFO)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 55);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1351, 587);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(12, 648);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(101, 30);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Location = new System.Drawing.Point(119, 655);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(46, 17);
            this.labelTiempo.TabIndex = 2;
            this.labelTiempo.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(12, 694);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(101, 32);
            this.buttonConfig.TabIndex = 3;
            this.buttonConfig.Text = "Configuration";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonLEBL
            // 
            this.buttonLEBL.Location = new System.Drawing.Point(1126, 777);
            this.buttonLEBL.Name = "buttonLEBL";
            this.buttonLEBL.Size = new System.Drawing.Size(75, 23);
            this.buttonLEBL.TabIndex = 5;
            this.buttonLEBL.Text = "LEBL";
            this.buttonLEBL.UseVisualStyleBackColor = true;
            this.buttonLEBL.Click += new System.EventHandler(this.buttonLEBL_Click);
            // 
            // buttonBCN
            // 
            this.buttonBCN.Location = new System.Drawing.Point(1207, 777);
            this.buttonBCN.Name = "buttonBCN";
            this.buttonBCN.Size = new System.Drawing.Size(75, 23);
            this.buttonBCN.TabIndex = 6;
            this.buttonBCN.Text = "BCN";
            this.buttonBCN.UseVisualStyleBackColor = true;
            this.buttonBCN.Click += new System.EventHandler(this.buttonBCN_Click);
            // 
            // buttonCAT
            // 
            this.buttonCAT.Location = new System.Drawing.Point(1288, 777);
            this.buttonCAT.Name = "buttonCAT";
            this.buttonCAT.Size = new System.Drawing.Size(75, 23);
            this.buttonCAT.TabIndex = 7;
            this.buttonCAT.Text = "CAT";
            this.buttonCAT.UseVisualStyleBackColor = true;
            this.buttonCAT.Click += new System.EventHandler(this.buttonCAT_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 743);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 29);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonInitialH
            // 
            this.buttonInitialH.Location = new System.Drawing.Point(263, 790);
            this.buttonInitialH.Name = "buttonInitialH";
            this.buttonInitialH.Size = new System.Drawing.Size(75, 23);
            this.buttonInitialH.TabIndex = 9;
            this.buttonInitialH.Text = "Accept";
            this.buttonInitialH.UseVisualStyleBackColor = true;
            this.buttonInitialH.Click += new System.EventHandler(this.buttonInitialH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 793);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Initial hour:";
            // 
            // listBoxHH
            // 
            this.listBoxHH.FormattingEnabled = true;
            this.listBoxHH.ItemHeight = 16;
            this.listBoxHH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.listBoxHH.Location = new System.Drawing.Point(106, 793);
            this.listBoxHH.Name = "listBoxHH";
            this.listBoxHH.Size = new System.Drawing.Size(49, 20);
            this.listBoxHH.TabIndex = 12;
            // 
            // listBoxMM
            // 
            this.listBoxMM.FormattingEnabled = true;
            this.listBoxMM.ItemHeight = 16;
            this.listBoxMM.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.listBoxMM.Location = new System.Drawing.Point(161, 793);
            this.listBoxMM.Name = "listBoxMM";
            this.listBoxMM.Size = new System.Drawing.Size(45, 20);
            this.listBoxMM.TabIndex = 13;
            // 
            // listBoxSS
            // 
            this.listBoxSS.FormattingEnabled = true;
            this.listBoxSS.ItemHeight = 16;
            this.listBoxSS.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.listBoxSS.Location = new System.Drawing.Point(212, 793);
            this.listBoxSS.Name = "listBoxSS";
            this.listBoxSS.Size = new System.Drawing.Size(45, 20);
            this.listBoxSS.TabIndex = 14;
            // 
            // trackBarZOOM
            // 
            this.trackBarZOOM.Location = new System.Drawing.Point(1370, 55);
            this.trackBarZOOM.Maximum = 24;
            this.trackBarZOOM.Name = "trackBarZOOM";
            this.trackBarZOOM.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarZOOM.Size = new System.Drawing.Size(56, 587);
            this.trackBarZOOM.TabIndex = 15;
            this.trackBarZOOM.ValueChanged += new System.EventHandler(this.trackBarZOOM_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1370, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Zoom:";
            // 
            // dataGridViewINFO
            // 
            this.dataGridViewINFO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewINFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewINFO.Location = new System.Drawing.Point(305, 669);
            this.dataGridViewINFO.Name = "dataGridViewINFO";
            this.dataGridViewINFO.ReadOnly = true;
            this.dataGridViewINFO.RowHeadersWidth = 51;
            this.dataGridViewINFO.RowTemplate.Height = 24;
            this.dataGridViewINFO.Size = new System.Drawing.Size(1058, 102);
            this.dataGridViewINFO.TabIndex = 17;
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 898);
            this.Controls.Add(this.dataGridViewINFO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarZOOM);
            this.Controls.Add(this.listBoxSS);
            this.Controls.Add(this.listBoxMM);
            this.Controls.Add(this.listBoxHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInitialH);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCAT);
            this.Controls.Add(this.buttonBCN);
            this.Controls.Add(this.buttonLEBL);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Mapa";
            this.Text = "Mapa";
            this.Load += new System.EventHandler(this.Mapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZOOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewINFO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Button buttonLEBL;
        private System.Windows.Forms.Button buttonBCN;
        private System.Windows.Forms.Button buttonCAT;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonInitialH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxHH;
        private System.Windows.Forms.ListBox listBoxMM;
        private System.Windows.Forms.ListBox listBoxSS;
        private System.Windows.Forms.TrackBar trackBarZOOM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewINFO;
    }
}