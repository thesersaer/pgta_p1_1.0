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
    public partial class Configuration : Form
    {
        public int multiplicador = 1;

        public Configuration()
        {
            InitializeComponent();
        }

        public int GetMultiplicador()
        {
            return multiplicador;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            buttonX1.BackColor = Color.Azure;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.multiplicador = 1000;
            buttonX1.BackColor = Color.Azure;
            buttonX2.BackColor = SystemColors.Control;
            buttonX5.BackColor = SystemColors.Control;
            buttonX10.BackColor = SystemColors.Control;
            buttonX20.BackColor = SystemColors.Control;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.multiplicador = 500;
            buttonX1.BackColor = SystemColors.Control;
            buttonX2.BackColor = Color.Azure;
            buttonX5.BackColor = SystemColors.Control;
            buttonX10.BackColor = SystemColors.Control;
            buttonX20.BackColor = SystemColors.Control;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.multiplicador =200;
            buttonX1.BackColor = SystemColors.Control;
            buttonX2.BackColor = SystemColors.Control;
            buttonX5.BackColor = Color.Azure;
            buttonX10.BackColor = SystemColors.Control;
            buttonX20.BackColor = SystemColors.Control;
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            this.multiplicador = 100;
            buttonX1.BackColor = SystemColors.Control;
            buttonX2.BackColor = SystemColors.Control;
            buttonX5.BackColor = SystemColors.Control;
            buttonX10.BackColor = Color.Azure;
            buttonX20.BackColor = SystemColors.Control;
        }

        private void buttonX20_Click(object sender, EventArgs e)
        {
            this.multiplicador = 50;
            buttonX1.BackColor = SystemColors.Control;
            buttonX2.BackColor = SystemColors.Control;
            buttonX5.BackColor = SystemColors.Control;
            buttonX10.BackColor = SystemColors.Control;
            buttonX20.BackColor = Color.Azure;
        }
    }
}
