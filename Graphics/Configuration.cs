using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Graphics
{
    public partial class Configuration : Form
    {
        public int multiplicador = 1000;
        bool ShowSMR = true;
        bool ShowMLAT = true;
        bool ShowADSB = true;
        string map;

        public Configuration()
        {
            InitializeComponent();
        }

        public int GetMultiplicador()
        {
            return multiplicador;
        }

        public bool GetSMR()
        {
            return ShowSMR;
        }

        public bool GetMLAT()
        {
            return ShowMLAT;
        }

        public bool GetADSB()
        {
            return ShowADSB;
        }

        public string GetMAP()
        {
            return map;
        }

        public void setMultiplicador(int multiplicador)
        {
            this.multiplicador = multiplicador;
        }

        public void setSMR(bool SMR)
        {
            this.ShowSMR = SMR;
        }

        public void setMLAT(bool MLAT)
        {
            this.ShowMLAT = MLAT;
        }

        public void setADSB(bool ADSB)
        {
            this.ShowADSB = ADSB;
        }
        public void setMAP(string map)
        {
            this.map = map;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Configuration_Load(object sender, EventArgs e)
        {
            if (this.multiplicador == 1000)
            {
                buttonX1.BackColor = Color.Azure;
            }
            if (this.multiplicador == 500)
            {
                buttonX2.BackColor = Color.Azure;
            }
            if (this.multiplicador == 200)
            {
                buttonX5.BackColor = Color.Azure;
            }
            if (this.multiplicador == 100)
            {
                buttonX10.BackColor = Color.Azure;
            }
            if (this.multiplicador == 50)
            {
                buttonX20.BackColor = Color.Azure;
            }
            if (this.ShowSMR == true)
            {
                checkBoxSMR.Checked = true;
            }
            else
            {
                checkBoxSMR.Checked = false;
            }
            if (this.ShowMLAT == true)
            {
                checkBoxMLAT.Checked = true;
            }
            else
            {
                checkBoxMLAT.Checked = false;
            }
            if (this.ShowADSB == true)
            {
                checkBoxADSB.Checked = true;
            }
            else
            {
                checkBoxADSB.Checked = false;
            }
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

        private void checkBoxSMR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSMR.Checked == true)
            {
                this.ShowSMR = true;
            }
            else
            {
                this.ShowSMR = false;
            }
        }

        private void checkBoxMLAT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMLAT.Checked == true)
            {
                this.ShowMLAT = true;
            }
            else
            {
                this.ShowMLAT = false;
            }
        }

        private void checkBoxADSB_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxADSB.Checked == true)
            {
                this.ShowADSB = true;
            }
            else
            {
                this.ShowADSB = false;
            }
        }

        private void buttonSAT_Click(object sender, EventArgs e)
        {
            this.map = "SAT";
        }

        private void buttonORIG_Click(object sender, EventArgs e)
        {
            this.map = "ORI";
        }

        private void buttonREL_Click(object sender, EventArgs e)
        {
            this.map = "REL";
        }
    }
}
