
namespace Graphics
{
    partial class table2
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
            this.filtSMRbutton = new System.Windows.Forms.Button();
            this.filtMLATbutton = new System.Windows.Forms.Button();
            this.filt21button = new System.Windows.Forms.Button();
            this.filtAllButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filtFieldsBox = new System.Windows.Forms.ComboBox();
            this.filtTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // filtSMRbutton
            // 
            this.filtSMRbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filtSMRbutton.Location = new System.Drawing.Point(12, 415);
            this.filtSMRbutton.Name = "filtSMRbutton";
            this.filtSMRbutton.Size = new System.Drawing.Size(102, 23);
            this.filtSMRbutton.TabIndex = 1;
            this.filtSMRbutton.Text = "SMR";
            this.filtSMRbutton.UseVisualStyleBackColor = true;
            this.filtSMRbutton.Click += new System.EventHandler(this.filtSMRbutton_Click);
            // 
            // filtMLATbutton
            // 
            this.filtMLATbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filtMLATbutton.Location = new System.Drawing.Point(120, 415);
            this.filtMLATbutton.Name = "filtMLATbutton";
            this.filtMLATbutton.Size = new System.Drawing.Size(102, 23);
            this.filtMLATbutton.TabIndex = 2;
            this.filtMLATbutton.Text = "MLAT";
            this.filtMLATbutton.UseVisualStyleBackColor = true;
            this.filtMLATbutton.Click += new System.EventHandler(this.filtMLATbutton_Click);
            // 
            // filt21button
            // 
            this.filt21button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filt21button.Location = new System.Drawing.Point(228, 415);
            this.filt21button.Name = "filt21button";
            this.filt21button.Size = new System.Drawing.Size(102, 23);
            this.filt21button.TabIndex = 3;
            this.filt21button.Text = "ADBS";
            this.filt21button.UseVisualStyleBackColor = true;
            this.filt21button.Click += new System.EventHandler(this.filt21button_Click);
            // 
            // filtAllButton
            // 
            this.filtAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filtAllButton.Location = new System.Drawing.Point(336, 415);
            this.filtAllButton.Name = "filtAllButton";
            this.filtAllButton.Size = new System.Drawing.Size(102, 23);
            this.filtAllButton.TabIndex = 4;
            this.filtAllButton.Text = "ALL";
            this.filtAllButton.UseVisualStyleBackColor = true;
            this.filtAllButton.Click += new System.EventHandler(this.filtAllButton_Click);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(493, 418);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(62, 17);
            this.filterLabel.TabIndex = 5;
            this.filterLabel.Text = "Filter by:";
            // 
            // filtFieldsBox
            // 
            this.filtFieldsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filtFieldsBox.FormattingEnabled = true;
            this.filtFieldsBox.Location = new System.Drawing.Point(561, 415);
            this.filtFieldsBox.Name = "filtFieldsBox";
            this.filtFieldsBox.Size = new System.Drawing.Size(121, 24);
            this.filtFieldsBox.TabIndex = 6;
            // 
            // filtTextBox
            // 
            this.filtTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filtTextBox.Location = new System.Drawing.Point(688, 415);
            this.filtTextBox.Name = "filtTextBox";
            this.filtTextBox.Size = new System.Drawing.Size(100, 22);
            this.filtTextBox.TabIndex = 7;
            this.filtTextBox.TextChanged += new System.EventHandler(this.filtTextBox_TextChanged);
            // 
            // table2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filtTextBox);
            this.Controls.Add(this.filtFieldsBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filtAllButton);
            this.Controls.Add(this.filt21button);
            this.Controls.Add(this.filtMLATbutton);
            this.Controls.Add(this.filtSMRbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "table2";
            this.Text = "table2";
            this.Load += new System.EventHandler(this.table2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button filtSMRbutton;
        private System.Windows.Forms.Button filtMLATbutton;
        private System.Windows.Forms.Button filt21button;
        private System.Windows.Forms.Button filtAllButton;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox filtFieldsBox;
        private System.Windows.Forms.TextBox filtTextBox;
    }
}