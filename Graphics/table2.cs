using ClassLib;
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
    public partial class table2 : Form
    {
        AsterixFile asterixFile;
        DataTable tableCatAll;
        public table2(AsterixFile asterixFile)
        {
            InitializeComponent();
            this.asterixFile = asterixFile;
        }

        private void table2_Load(object sender, EventArgs e)
        {
            asterixFile.tabulateCatAll();
            this.tableCatAll = asterixFile.getTableCatAll();
            dataGridView1.DataSource = tableCatAll;
            filtFieldsBox.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int iiDtCol = 0; iiDtCol < tableCatAll.Columns.Count; iiDtCol++)
            {
                filtFieldsBox.Items.Add(tableCatAll.Columns[iiDtCol].ColumnName);
            }
            filtFieldsBox.SelectedIndex = 0;
        }

        private void filtSMRbutton_Click(object sender, EventArgs e)
        {
            tableCatAll.DefaultView.RowFilter = "Category = 'SMR'";
        }

        private void filtMLATbutton_Click(object sender, EventArgs e)
        {
            tableCatAll.DefaultView.RowFilter = "Category = 'MLAT'";
        }

        private void filt21button_Click(object sender, EventArgs e)
        {
            tableCatAll.DefaultView.RowFilter = "Category = 'ADSB'";
        }

        private void filtAllButton_Click(object sender, EventArgs e)
        {
            tableCatAll.DefaultView.RowFilter = "";
        }

        private void filtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (filtTextBox.Text != "")
            { tableCatAll.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}*'", filtFieldsBox.SelectedItem, filtTextBox.Text); }
            else { tableCatAll.DefaultView.RowFilter = ""; }
        }
    }
}
