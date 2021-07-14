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
    public partial class Lekerdezes : Form
    {
        public Lekerdezes()
        {
            InitializeComponent();
        }

        private void Lekerdezes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lekérdezés.Cetleek' table. You can move, or remove it, as needed.
            this.cetleekTableAdapter.Fill(this.lekérdezés.Cetleek);
            DgvFilterManager fm = new DgvFilterManager();
          //  fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);
            fm.DataGridView = dataGridView1;

        }
        //void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        //{
        //    switch (e.Column.Name)
        //    {
        //        case "TextDescription":
        //        case "Purchaser":
        //        case "AlternSuppl":
        //        case "StatCodeExte":
        //        case "ExtProGroup":
        //        case "Port":
        //            e.ColumnFilter = new DgvComboBoxColumnFilter();
        //            break;
        //    }
        //}
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dataGridView1.HitTest(e.X, e.Y).RowIndex >= 0)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.HitTest(e.X, e.Y).RowIndex].Cells[0];
                CetleeSorok();
            }
        }

        private void CetleeSorok()
        {
            int AktSor = dataGridView1.CurrentCell.RowIndex;
            CetleeKep cetleeKep = new CetleeKep();
            cetleeKep.Ugyintez = this.dataGridView1.CurrentRow.Cells["keszitetteDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.LetrehozIdo = this.dataGridView1.CurrentRow.Cells["letrehozasIdejeDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.Tranzsz = this.dataGridView1.CurrentRow.Cells["tranzakcioSzamDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.Szall = this.dataGridView1.CurrentRow.Cells["szallitoDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.SzallNev = this.dataGridView1.CurrentRow.Cells["supplierNameDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.Szlaszam = this.dataGridView1.CurrentRow.Cells["invoiceNoDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.Szlaido = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells["invoiceDate1DataGridViewTextBoxColumn"].Value).ToString("yyyy.MM.dd");
            cetleeKep.Osszeg = this.dataGridView1.CurrentRow.Cells["osszegDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.Arfoly = this.dataGridView1.CurrentRow.Cells["arfolyamDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.Netto = this.dataGridView1.CurrentRow.Cells["nettoDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.Deviza = this.dataGridView1.CurrentRow.Cells["devizaDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.Afakod = this.dataGridView1.CurrentRow.Cells["vATCodeDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.Afa = this.dataGridView1.CurrentRow.Cells["afaDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.AfaNev = this.dataGridView1.CurrentRow.Cells["vATDescDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.Fksz = this.dataGridView1.CurrentRow.Cells["bruttoFKSZDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.ElterO = this.dataGridView1.CurrentRow.Cells["elteresODataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.ElterSz = this.dataGridView1.CurrentRow.Cells["elteresSzDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.Enged = this.dataGridView1.CurrentRow.Cells["engedelyezoDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.EngedIdo = this.dataGridView1.CurrentRow.Cells["engedIdejeDataGridViewTextBoxColumn"].Value.ToString();
            cetleeKep.ShowDialog();
            dataGridView1.CurrentCell = dataGridView1[0, AktSor];
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["tipusDataGridViewTextBoxColumn"].Value.ToString() == "NonBom")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Wheat;
            if (dataGridView1.Rows[e.RowIndex].Cells["tipusDataGridViewTextBoxColumn"].Value.ToString() == "Alváll")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
            if (dataGridView1.Rows[e.RowIndex].Cells["tipusDataGridViewTextBoxColumn"].Value.ToString() == "Bom")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink;
        }
    }
}
