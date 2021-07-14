using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;


namespace Cetlee
{
    public partial class Számlák : Form
    {
        public Számlák()
        {
            InitializeComponent();
        }

        private void Számlák_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'szamlak.VF_PL030300_PurchaseLedger' table. You can move, or remove it, as needed.
            this.vF_PL030300_PurchaseLedgerTableAdapter.Fill(this.szamlak.VF_PL030300_PurchaseLedger);
            DgvFilterManager fm = new DgvFilterManager();
            fm.DataGridView = dataGridView1;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["statuszDataGridViewTextBoxColumn"].Value.ToString() == "0")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleGreen;
            if (dataGridView1.Rows[e.RowIndex].Cells["statuszDataGridViewTextBoxColumn"].Value.ToString() == "1")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
            if (dataGridView1.Rows[e.RowIndex].Cells["statuszDataGridViewTextBoxColumn"].Value.ToString() == "2")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkGray;
        }
    }
}
