
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
            this.dataGridView1.Location = new System.Drawing.Point(10, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 501);
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
            this.buttonAll.Location = new System.Drawing.Point(10, 6);
            this.buttonAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(56, 19);
            this.buttonAll.TabIndex = 1;
            this.buttonAll.Text = "ALL";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonCAT10SMR
            // 
            this.buttonCAT10SMR.Location = new System.Drawing.Point(70, 6);
            this.buttonCAT10SMR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCAT10SMR.Name = "buttonCAT10SMR";
            this.buttonCAT10SMR.Size = new System.Drawing.Size(81, 19);
            this.buttonCAT10SMR.TabIndex = 2;
            this.buttonCAT10SMR.Text = "CAT 10 SMR";
            this.buttonCAT10SMR.UseVisualStyleBackColor = true;
            this.buttonCAT10SMR.Click += new System.EventHandler(this.buttonCAT10SMR_Click);
            // 
            // buttonCAT10MLAT
            // 
            this.buttonCAT10MLAT.Location = new System.Drawing.Point(156, 6);
            this.buttonCAT10MLAT.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCAT10MLAT.Name = "buttonCAT10MLAT";
            this.buttonCAT10MLAT.Size = new System.Drawing.Size(91, 19);
            this.buttonCAT10MLAT.TabIndex = 3;
            this.buttonCAT10MLAT.Text = "CAT 10 MLAT";
            this.buttonCAT10MLAT.UseVisualStyleBackColor = true;
            this.buttonCAT10MLAT.Click += new System.EventHandler(this.buttonCAT10MLAT_Click);
            // 
            // buttonCAT21ADSB
            // 
            this.buttonCAT21ADSB.Location = new System.Drawing.Point(251, 6);
            this.buttonCAT21ADSB.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCAT21ADSB.Name = "buttonCAT21ADSB";
            this.buttonCAT21ADSB.Size = new System.Drawing.Size(86, 19);
            this.buttonCAT21ADSB.TabIndex = 4;
            this.buttonCAT21ADSB.Text = "CAT 21 ADSB";
            this.buttonCAT21ADSB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(867, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Target Report Descriptor:";
            // 
            // labelTargetRepDescrip
            // 
            this.labelTargetRepDescrip.AutoSize = true;
            this.labelTargetRepDescrip.Location = new System.Drawing.Point(1000, 45);
            this.labelTargetRepDescrip.Name = "labelTargetRepDescrip";
            this.labelTargetRepDescrip.Size = new System.Drawing.Size(10, 13);
            this.labelTargetRepDescrip.TabIndex = 6;
            this.labelTargetRepDescrip.Text = "-";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 663);
            this.Controls.Add(this.labelTargetRepDescrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCAT21ADSB);
            this.Controls.Add(this.buttonCAT10MLAT);
            this.Controls.Add(this.buttonCAT10SMR);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}