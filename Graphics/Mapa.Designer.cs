
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
            this.dataGridViewINFO = new System.Windows.Forms.DataGridView();
            this.Target_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Target_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Track_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLEBL = new System.Windows.Forms.Button();
            this.buttonBCN = new System.Windows.Forms.Button();
            this.buttonCAT = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
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
            // dataGridViewINFO
            // 
            this.dataGridViewINFO.AllowUserToAddRows = false;
            this.dataGridViewINFO.AllowUserToDeleteRows = false;
            this.dataGridViewINFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewINFO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Target_ID,
            this.Target_Address,
            this.Track_Number,
            this.CAT,
            this.SIC,
            this.SAC,
            this.Time,
            this.FL});
            this.dataGridViewINFO.Location = new System.Drawing.Point(310, 648);
            this.dataGridViewINFO.Name = "dataGridViewINFO";
            this.dataGridViewINFO.ReadOnly = true;
            this.dataGridViewINFO.RowHeadersWidth = 51;
            this.dataGridViewINFO.RowTemplate.Height = 24;
            this.dataGridViewINFO.Size = new System.Drawing.Size(1053, 93);
            this.dataGridViewINFO.TabIndex = 4;
            // 
            // Target_ID
            // 
            this.Target_ID.HeaderText = "Target ID";
            this.Target_ID.MinimumWidth = 6;
            this.Target_ID.Name = "Target_ID";
            this.Target_ID.ReadOnly = true;
            this.Target_ID.Width = 125;
            // 
            // Target_Address
            // 
            this.Target_Address.HeaderText = "Target Address";
            this.Target_Address.MinimumWidth = 6;
            this.Target_Address.Name = "Target_Address";
            this.Target_Address.ReadOnly = true;
            this.Target_Address.Width = 125;
            // 
            // Track_Number
            // 
            this.Track_Number.HeaderText = "Track Number";
            this.Track_Number.MinimumWidth = 6;
            this.Track_Number.Name = "Track_Number";
            this.Track_Number.ReadOnly = true;
            this.Track_Number.Width = 125;
            // 
            // CAT
            // 
            this.CAT.HeaderText = "CAT";
            this.CAT.MinimumWidth = 6;
            this.CAT.Name = "CAT";
            this.CAT.ReadOnly = true;
            this.CAT.Width = 125;
            // 
            // SIC
            // 
            this.SIC.HeaderText = "SIC";
            this.SIC.MinimumWidth = 6;
            this.SIC.Name = "SIC";
            this.SIC.ReadOnly = true;
            this.SIC.Width = 125;
            // 
            // SAC
            // 
            this.SAC.HeaderText = "SAC";
            this.SAC.MinimumWidth = 6;
            this.SAC.Name = "SAC";
            this.SAC.ReadOnly = true;
            this.SAC.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // FL
            // 
            this.FL.HeaderText = "Flight Level";
            this.FL.MinimumWidth = 6;
            this.FL.Name = "FL";
            this.FL.ReadOnly = true;
            this.FL.Width = 125;
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
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 898);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCAT);
            this.Controls.Add(this.buttonBCN);
            this.Controls.Add(this.buttonLEBL);
            this.Controls.Add(this.dataGridViewINFO);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.labelTiempo);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Mapa";
            this.Text = "Mapa";
            this.Load += new System.EventHandler(this.Mapa_Load);
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
        private System.Windows.Forms.DataGridView dataGridViewINFO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Target_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Target_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Track_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn FL;
        private System.Windows.Forms.Button buttonLEBL;
        private System.Windows.Forms.Button buttonBCN;
        private System.Windows.Forms.Button buttonCAT;
        private System.Windows.Forms.Button buttonReset;
    }
}