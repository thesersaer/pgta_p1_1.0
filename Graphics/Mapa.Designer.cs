
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZOOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewINFO)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gMapControl1.AutoSize = true;
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 55);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaximumSize = new System.Drawing.Size(1600, 587);
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
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(106)))));
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPlay.Location = new System.Drawing.Point(12, 648);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(101, 30);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.buttonConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(106)))));
            this.buttonConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonConfig.Location = new System.Drawing.Point(12, 694);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(101, 32);
            this.buttonConfig.TabIndex = 3;
            this.buttonConfig.Text = "Configuration";
            this.buttonConfig.UseVisualStyleBackColor = false;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // buttonLEBL
            // 
            this.buttonLEBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(106)))));
            this.buttonLEBL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonLEBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLEBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLEBL.Location = new System.Drawing.Point(1126, 777);
            this.buttonLEBL.Name = "buttonLEBL";
            this.buttonLEBL.Size = new System.Drawing.Size(75, 33);
            this.buttonLEBL.TabIndex = 5;
            this.buttonLEBL.Text = "LEBL";
            this.buttonLEBL.UseVisualStyleBackColor = false;
            this.buttonLEBL.Click += new System.EventHandler(this.buttonLEBL_Click);
            // 
            // buttonBCN
            // 
            this.buttonBCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(106)))));
            this.buttonBCN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonBCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBCN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBCN.Location = new System.Drawing.Point(1207, 777);
            this.buttonBCN.Name = "buttonBCN";
            this.buttonBCN.Size = new System.Drawing.Size(75, 33);
            this.buttonBCN.TabIndex = 6;
            this.buttonBCN.Text = "BCN";
            this.buttonBCN.UseVisualStyleBackColor = false;
            this.buttonBCN.Click += new System.EventHandler(this.buttonBCN_Click);
            // 
            // buttonCAT
            // 
            this.buttonCAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(106)))));
            this.buttonCAT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonCAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCAT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCAT.Location = new System.Drawing.Point(1288, 777);
            this.buttonCAT.Name = "buttonCAT";
            this.buttonCAT.Size = new System.Drawing.Size(75, 33);
            this.buttonCAT.TabIndex = 7;
            this.buttonCAT.Text = "CAT";
            this.buttonCAT.UseVisualStyleBackColor = false;
            this.buttonCAT.Click += new System.EventHandler(this.buttonCAT_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(106)))));
            this.buttonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReset.Location = new System.Drawing.Point(12, 743);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 29);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonInitialH
            // 
            this.buttonInitialH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(106)))));
            this.buttonInitialH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.buttonInitialH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInitialH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInitialH.Location = new System.Drawing.Point(263, 788);
            this.buttonInitialH.Name = "buttonInitialH";
            this.buttonInitialH.Size = new System.Drawing.Size(88, 26);
            this.buttonInitialH.TabIndex = 9;
            this.buttonInitialH.Text = "Accept";
            this.buttonInitialH.UseVisualStyleBackColor = false;
            this.buttonInitialH.Click += new System.EventHandler(this.buttonInitialH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.trackBarZOOM.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1370, 38);
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
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelTitulo.Controls.Add(this.label3);
            this.panelTitulo.Controls.Add(this.pictureBox4);
            this.panelTitulo.Controls.Add(this.pictureBox3);
            this.panelTitulo.Controls.Add(this.pictureBox2);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1441, 35);
            this.panelTitulo.TabIndex = 18;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseMove);
            this.panelTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "MAP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1182, 816);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 84);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Graphics.Properties.Resources.Captura_de_pantalla_2022_12_07_095752;
            this.pictureBox5.Location = new System.Drawing.Point(106, 36);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Graphics.Properties.Resources.Captura_de_pantalla_2022_12_07_095631;
            this.pictureBox6.Location = new System.Drawing.Point(148, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(21, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Graphics.Properties.Resources.Captura_de_pantalla_2022_12_07_095653;
            this.pictureBox1.Location = new System.Drawing.Point(54, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Graphics.Properties.Resources.png_transparent_minimize_expand_reduce_screen_resize_arrows_icon;
            this.pictureBox4.Location = new System.Drawing.Point(1373, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Graphics.Properties.Resources.png_transparent_minimize_minus_remove_line_basic_user_interface_elements_icon;
            this.pictureBox3.Location = new System.Drawing.Point(1342, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Graphics.Properties.Resources.png_transparent_maximize_full_screen_zoom_expand_wirecons_free_vector_icons_icon_thumbnail;
            this.pictureBox2.Location = new System.Drawing.Point(1373, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Graphics.Properties.Resources.png_clipart_maine_computer_icons_close_icon_logo_law_thumbnail;
            this.btnCerrar.Location = new System.Drawing.Point(1404, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "SMR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(93, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "MLAT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(51, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "ADSB:";
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1441, 898);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitulo);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1441, 898);
            this.Name = "Mapa";
            this.Text = "Mapa";
            this.Load += new System.EventHandler(this.Mapa_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mapa_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mapa_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mapa_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZOOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewINFO)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
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
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}