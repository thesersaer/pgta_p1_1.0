﻿
namespace Graphics
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileStatusLabel = new System.Windows.Forms.Label();
            this.showData2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar Fichero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mostrar Tabla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileStatusLabel
            // 
            this.fileStatusLabel.AutoSize = true;
            this.fileStatusLabel.Location = new System.Drawing.Point(463, 181);
            this.fileStatusLabel.Name = "fileStatusLabel";
            this.fileStatusLabel.Size = new System.Drawing.Size(105, 17);
            this.fileStatusLabel.TabIndex = 2;
            this.fileStatusLabel.Text = "No file selected";
            // 
            // showData2
            // 
            this.showData2.Location = new System.Drawing.Point(462, 256);
            this.showData2.Name = "showData2";
            this.showData2.Size = new System.Drawing.Size(126, 23);
            this.showData2.TabIndex = 3;
            this.showData2.Text = "Show DataTable";
            this.showData2.UseVisualStyleBackColor = true;
            this.showData2.Click += new System.EventHandler(this.showData2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Mostrar Mapa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(311, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 51);
            this.button4.TabIndex = 5;
            this.button4.Text = "HELP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.showData2);
            this.Controls.Add(this.fileStatusLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label fileStatusLabel;
        private System.Windows.Forms.Button showData2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

