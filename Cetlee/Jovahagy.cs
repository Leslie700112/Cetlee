using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.DirectoryServices;
using DgvFilterPopup;

namespace Cetlee
{
    public partial class Jovahagy : Form
    {
        private string Kerelmezo;
        public Jovahagy()
        {
            InitializeComponent();
        }

        private void Jovahagy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jovahagyas.NBCetLeeFej' table. You can move, or remove it, as needed.
            this.nBCetLeeFejTableAdapter.Fill(this.jovahagyas.NBCetLeeFej);
            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            Kerelmezo = de.Properties["fullName"].Value.ToString();
            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);
            fm.DataGridView = dataGridView1;
        }
             void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "Tipus":
                //case "Purchaser":
                //case "AlternSuppl":
                //case "StatCodeExte":
                //case "ExtProGroup":
                //case "Port":
                    e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }

        private void Frissit()
        {
            this.nBCetLeeFejTableAdapter.Fill(this.jovahagyas.NBCetLeeFej);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frissit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    try
                    {
                        if (!Convert.ToBoolean(dataGridView1.Rows[cell.RowIndex].Cells["Column1"].Value))
                            dataGridView1.Rows[cell.RowIndex].Cells["Column1"].Value = true;
                        else
                            dataGridView1.Rows[cell.RowIndex].Cells["Column1"].Value = false;
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                try
                {
                    if (!Convert.ToBoolean(dataGridView1.Rows[j].Cells["Column1"].Value))
                        dataGridView1.Rows[j].Cells["Column1"].Value = true;
                    else
                        dataGridView1.Rows[j].Cells["Column1"].Value = false;
                }
                catch (Exception)
                {
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();
            for (int q = 0; q < dataGridView1.RowCount; q++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[q].Cells["Column1"].Value))
                {
                    mySqlCommand.CommandText = "UPDATE NBCetLeeFej SET Statusz='0',Engedelyezo=@Enged,EngedIdeje=CURRENT_TIMESTAMP where CetLeeID=@Sor";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                    mySqlCommand.Parameters["@Sor"].Value = Convert.ToInt32(dataGridView1.Rows[q].Cells["cetLeeIDDataGridViewTextBoxColumn"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@Enged", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Enged"].Value = Kerelmezo.Trim();
                    mySqlCommand.ExecuteNonQuery();
                }
            }
            connection.Close();
            Frissit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();
            for (int q = 0; q < dataGridView1.RowCount; q++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[q].Cells["Column1"].Value))
                {
                    mySqlCommand.CommandText = "UPDATE NBCetLeeFej SET Statusz='2',Engedelyezo=@Enged,EngedIdeje=CURRENT_TIMESTAMP where CetLeeID=@Sor";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@Sor", SqlDbType.Int);
                    mySqlCommand.Parameters["@Sor"].Value = Convert.ToInt32(dataGridView1.Rows[q].Cells["cetLeeIDDataGridViewTextBoxColumn"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@Enged", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Enged"].Value = Kerelmezo.Trim();
                    mySqlCommand.ExecuteNonQuery();
                }
            }
            connection.Close();
            Frissit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] == this.Column2)
            {
                CetleeSorok();
            }
        }
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
           CetleeKep  cetleeKep = new CetleeKep();
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
            cetleeKep.Enged = "Vár";
            cetleeKep.ShowDialog();
            dataGridView1.CurrentCell = dataGridView1[0, AktSor];
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["Tipus"].Value.ToString()=="NonBom")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Wheat;
            if (dataGridView1.Rows[e.RowIndex].Cells["Tipus"].Value.ToString() == "Alváll")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
            if (dataGridView1.Rows[e.RowIndex].Cells["Tipus"].Value.ToString() == "Bom")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink;

            if (dataGridView1.Rows[e.RowIndex].Cells["devizaDataGridViewTextBoxColumn"].Value.ToString() == "EUR")
            {
                if (Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["nettoDataGridViewTextBoxColumn"].Value.ToString()) >= FixErtekek.felsohatert)
                    this.dataGridView1.Rows[e.RowIndex].Cells["nettoDataGridViewTextBoxColumn"].Style.BackColor = Color.Magenta;
            }
            else
            {
                if (Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["nettoDataGridViewTextBoxColumn"].Value.ToString())/FixErtekek.eurovaltAl >= FixErtekek.felsohatert)
                    this.dataGridView1.Rows[e.RowIndex].Cells["nettoDataGridViewTextBoxColumn"].Style.BackColor = Color.Magenta;
            }
        }
    }
}
