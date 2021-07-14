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
    public partial class BomFelvitel : Form
    {
        public string szallito, deviza, bruttoFKSZ, Sor1, Sor2, Sor3, fksz, Fertek;
        private string user, eredeti_zoldszam;
        private int milyen,  hasonmin, hasonmax;
        private double afa, arfolyam, Eltsz, Kulonb, tizezer,Szertek,Eertek;
//        private DataGridView.HitTestInfo kat;

        public BomFelvitel()
        {
            InitializeComponent();
        }

        private void BomFelvitel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bomDataSet.VNB_GL5303XX_AccountShedule_CetLee' table. You can move, or remove it, as needed.
            this.vNB_GL5303XX_AccountShedule_CetLeeTableAdapter.Fill(this.bomDataSet.VNB_GL5303XX_AccountShedule_CetLee);
            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            user = de.Properties["fullName"].Value.ToString();

            DgvFilterManager fm = new DgvFilterManager();
            //  fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);
            fm.DataGridView = dataGridView1;

            label2.Text = "";
            label4.Text = "";
            richTextBox1.Rtf = "";
            textBox1.Select();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.vF_PL030300_PurchaseLedgerTableAdapter.Fill(this.bomDataSet.VF_PL030300_PurchaseLedger, textBox1.Text.Trim());
                int ZoldFound = VF_PL030300_PurchaseLedgerBindingSource.Count;
                if (ZoldFound > 0)
                {
                    this.nBCetLeeFejTableAdapter.Fill(this.bomDataSet.NBCetLeeFej, textBox1.Text.Trim());
                    int CetleeFound = NBCetLeeFejBindingSource.Count;
                    if (CetleeFound <= 0)
                    {
                        textBox1.Enabled = false;
                        ZoldFound = 0;
                        this.vF_SYCH0300_DevizaTableAdapter.Fill(this.bomDataSet.VF_SYCH0300_Deviza, Convert.ToDateTime(bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["InvoiceDate1"].ToString()));
                        if (bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["CurrencyDescription"].ToString().Trim() != "EUR")
                        {
                            int arfFound = VF_SYCH0300_DevizaBindingSource.Count;
                            if (arfFound >= 0)
                                arfolyam = Convert.ToDouble(bomDataSet.Tables["VF_SYCH0300_Deviza"].Rows[0]["RateSell"].ToString().Trim());
                            else
                            {
                                MessageBox.Show("Nincs Árfolyam !");
                                textBox1.Clear();
                                textBox1.Select();
                            }
                        }
                        else
                            arfolyam = 1;
                        Sor2 = bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["InvoiceDate1"].ToString().Substring(0, 10);
                        Sor3 = " ¤ " + bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["Netto"].ToString().Trim() + " " +
                                     bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["CurrencyDescription"].ToString().Trim() + " ¤ " +
                                       arfolyam.ToString();
                        label2.Text = bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["SupplierCode"].ToString().Trim() + " ¤ " +
                                    bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["SupplierName"].ToString().Trim();
                        Sor1 = bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["InvoiceNo"].ToString().Trim() + " ¤ ";
                        var sb = new StringBuilder();
                        sb.Append(@"{\rtf1\ansi ");
                        sb.Append(Sor1);
                        sb.Append(@"\b ");
                        sb.Append(Sor2);
                        sb.Append(@"\b0 ");
                        sb.Append(Sor3);
                        sb.Append(@"}");

                        richTextBox1.Rtf = sb.ToString();
                        eredeti_zoldszam = bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["InternRefNo"].ToString().Trim();
                        szallito = bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["SupplierCode"].ToString().Trim();
                        Fertek = bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["Netto"].ToString().Trim();
                        deviza = bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["CurrencyDescription"].ToString().Trim();
                        //   arfolyam = Convert.ToDouble(dataSet34.Tables["VF_SYCH0300_Deviza"].Rows[0]["RateSell"].ToString().Trim());
                        this.rendelesekTableAdapter.Fill(this.bomDataSet.Rendelesek, szallito);
                        dataGridView1.Select();
                        label4.Text = "Áfa (" + bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() + " ¤ " +
                         bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATDesc"].ToString().Trim() + ")";

                        if (bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "46" ||
                           bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "47" ||
                           bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "08" ||
                           bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "23" ||
                           bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "40" ||
                           bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "98" ||
                           bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "50")
                            afa = 0;
                        else
                            afa = Convert.ToDouble(bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["Percentage"].ToString().Trim());

                        if (bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["AccString"].ToString().Trim() == "4543")
                            bruttoFKSZ = "04543";
                        else
                            bruttoFKSZ = bomDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["AccString"].ToString().Trim();
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Már van ilyen Cetlee !!    Törlöjem ?", "Most Mi Legyen ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                CetleeTorol();
                                break;
                            case DialogResult.No:
                                textBox1.Clear();
                                textBox1.Select();
                                break;
                        }

                    }
                }
                else
                {
                    textBox1.Clear();
                    textBox1.Select();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dataGridView2.Rows.Clear();
            Szertek = 0;
            Eertek = 0;
            dataGridView1.EndEdit();
            string foki;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Column1"].Value))
                    {
                        if (dataGridView1.Rows[i].Cells["rendelesSzamDataGridViewTextBoxColumn"].Value.ToString().Substring(0, 1) != "")
                        {
                            foki = "2611";
                        }
                        else
                        {
                            foki = "";
                        }
                        dataGridView2.Rows.Add(dataGridView1.Rows[i].Cells["rendelesSzamDataGridViewTextBoxColumn"].Value,
                        dataGridView1.Rows[i].Cells["rendSorszamDataGridViewTextBoxColumn"].Value, dataGridView1.Rows[i].Cells["stockCodeDataGridViewTextBoxColumn"].Value,
                        dataGridView1.Rows[i].Cells["megnevezesDataGridViewTextBoxColumn"].Value, dataGridView1.Rows[i].Cells["priceDataGridViewTextBoxColumn"].Value,
                        dataGridView1.Rows[i].Cells["priceDataGridViewTextBoxColumn"].Value,"0","0", dataGridView1.Rows[i].Cells["qtyDataGridViewTextBoxColumn"].Value,
                        dataGridView1.Rows[i].Cells["arDataGridViewTextBoxColumn"].Value, dataGridView1.Rows[i].Cells["currencyDescriptionDataGridViewTextBoxColumn"].Value, foki,
                        "Anyag beszerzés technikai", dataGridView1.Rows[i].Cells["szalllevelDataGridViewTextBoxColumn"].Value.ToString().Trim(),
                        dataGridView1.Rows[i].Cells["BatchNumber"].Value.ToString().Trim(),dataGridView1.Rows[i].Cells["arDataGridViewTextBoxColumn"].Value);
                    }
                }
                catch (Exception)
                {
                }
            }
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                if (!String.IsNullOrEmpty(dataGridView2.Rows[j].Cells["Column16"].Value.ToString()))
                {
                    for (int k = 0; k < dataGridView1.RowCount; k++)
                    {
                        if (dataGridView2.Rows[j].Cells["Column16"].Value.ToString() == dataGridView1.Rows[k].Cells["BatchNumber"].Value.ToString())
                            dataGridView1.Rows.Remove(dataGridView1.Rows[k]);
                    }
                }
                Szertek = Szertek + Convert.ToDouble(dataGridView2.Rows[j].Cells["Column8"].Value);
                Eertek = Eertek + Convert.ToDouble(dataGridView2.Rows[j].Cells["Column18"].Value);
            }
            dataGridView1.EndEdit();
            textBox3.Text = Eertek.ToString("N2");
            textBox4.Text = (Convert.ToDouble(Fertek)- Convert.ToDouble(Szertek)).ToString("N2");
            textBox5.Text = (Convert.ToDouble(Szertek) * (afa / 100)).ToString("N2");
            textBox6.Text = Eertek.ToString("N2");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.EndEdit();
            double ertek = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Column1"].Value))
                {
                    ertek = ertek + Convert.ToDouble(dataGridView1.Rows[i].Cells["arDataGridViewTextBoxColumn"].Value);
                }
            }
            textBox2.Text = ertek.ToString();
        }
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.EndEdit();
            if (this.dataGridView2.CurrentRow.Cells["Column11"].Value == null)
                this.dataGridView2.CurrentRow.Cells["Column11"].Value = "";

            if (!String.IsNullOrEmpty(this.dataGridView2.CurrentRow.Cells["Column11"].Value.ToString()))
            {
                int FkszFound = VNB_GL5303XX_AccountShedule_CetLeeBindingSource.Find("AccountNo", this.dataGridView2.CurrentRow.Cells["Column11"].Value.ToString().Trim());
                if (FkszFound < 0)
                {
                    MessageBox.Show("Nincs ilyen Főkönyvi szám !!", "Figyelmeztetés",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    this.dataGridView2.CurrentRow.Cells["Column11"].Value = "";
                    this.dataGridView2.CurrentRow.Cells["Column11"].Selected = true;
                }
            }
            double ertek2 = 0, ertek3 = 0;
            for (int x = 0; x < dataGridView2.RowCount; x++)
            {
                dataGridView2.Rows[x].Cells["Column8"].Value = (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column6"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value))+
                    (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column15"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value))+
                     (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column17"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value));
                ertek2 = ertek2 + (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column6"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value)) +
                    (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column15"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value))+
                     (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column17"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value));
                ertek3 = ertek3 + (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column5"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value));
            }
            textBox3.Text = ertek2.ToString();
            textBox6.Text = ertek3.ToString();
            textBox5.Text = (Convert.ToDouble(textBox3.Text) * (afa / 100)).ToString("N2");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = (Convert.ToDouble(Fertek) - Convert.ToDouble(textBox3.Text)).ToString("N2");
            textBox5.Text = (Convert.ToDouble(textBox3.Text) * (afa / 100)).ToString("N2");
            if (Convert.ToDouble(textBox4.Text) < -1)
                textBox3.BackColor = Color.Red;
            if (Convert.ToDouble(textBox4.Text) > -1 && Convert.ToDouble(textBox4.Text) < 1)
                textBox3.BackColor = Color.Green;
            if (Convert.ToDouble(textBox4.Text) > 1)
                textBox3.BackColor = Color.Orange;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("", "", "", "Fuvar", "0", "1","0","0", "1", "1", deviza, "5212", "Fuv. kts anyagszáll.","","");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("", "", "", "Göngyöleg", "0", "1","0","0,", "1", "1", deviza, "2612", "Áru beszerzés technikai","", "");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("", "", "", "Csomagolás", "0", "1","0","0", "1", "1", deviza, "5211", "Anyagszáll egyéb költsége","", "");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Torol();
        }
        private void Torol()
        {
            textBox1.Enabled = true;
            textBox1.Clear();
            label2.Text = "";
            label3.Text = "";
            richTextBox1.SelectAll();
            richTextBox1.Text = " ";
            textBox2.Text = "0";
            textBox2.BackColor = Color.White;
            textBox3.Text = "0";
            textBox3.BackColor = Color.White;
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            Szertek = 0;
            szallito = "";
            this.rendelesekTableAdapter.Fill(this.bomDataSet.Rendelesek, szallito);
            dataGridView2.Rows.Clear();
            richTextBox1.Clear();
            textBox4.Text = "0";
            textBox1.Select();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value))
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            else
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            if (Convert.ToDouble(Szertek) < Convert.ToDouble(textBox2.Text.Trim()))
                textBox2.BackColor = Color.Red;
            else
                textBox2.BackColor = Color.White;
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dataGridView2.CurrentCell.ColumnIndex == 5 || dataGridView2.CurrentCell.ColumnIndex == 6 || dataGridView2.CurrentCell.ColumnIndex == 7 || dataGridView2.CurrentCell.ColumnIndex == 8) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',') || (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                           || (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
                e.KeyChar = '.';

        }
        private void button5_Click(object sender, EventArgs e)
        {
            //milyen = 0;
            //for (int j = 0; j < dataGridView2.RowCount; j++)
            //{
            //    if (this.dataGridView2.Rows[j].Cells["Column10"].Value.ToString().Trim() == "")
            //        milyen = 1;
            //}
            //if (milyen == 0)
            //{
                Elteres();
                CetlleeBeir();
            //}
            //else
            //    MessageBox.Show("Költséghely !!");
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex] == this.Column14)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                this.rendelesekTableAdapter.Fill(this.bomDataSet.Rendelesek, szallito);
                double ertek2 = 0, ertek3 = 0;
                for (int x = 0; x < dataGridView2.RowCount; x++)
                {
                    ertek2 = ertek2 + (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column6"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value)) +
                    (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column15"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value))+
                     (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column17"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value));
                    ertek3 = ertek3 + (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column5"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value));
                    if (!String.IsNullOrEmpty(dataGridView2.Rows[x].Cells["Column16"].Value.ToString()))
                    {
                        for (int t = 0; t < dataGridView1.RowCount; t++)
                        {
                            if (dataGridView2.Rows[x].Cells["Column16"].Value.ToString() == dataGridView1.Rows[t].Cells["BatchNumber"].Value.ToString())
                                dataGridView1.Rows.Remove(dataGridView1.Rows[t]);
                        }
                    }
                }
                textBox3.Text = ertek2.ToString();
                textBox4.Text = (Convert.ToDouble(Fertek) - Convert.ToDouble(ertek3)).ToString("N2");
                textBox6.Text = ertek3.ToString();
                textBox5.Text = (Convert.ToDouble(textBox3.Text) * (afa / 100)).ToString("N2");
            }
        }
        private void Elteres()
        {
            if (deviza != "EUR")
            {
                hasonmin = Convert.ToInt32(FixErtekek.hasonminB * FixErtekek.eurovaltB);
                hasonmax = Convert.ToInt32(FixErtekek.hasonmaxB * FixErtekek.eurovaltB);
                tizezer = Convert.ToDouble(textBox3.Text) / FixErtekek.eurovaltB;
            }
            else
            {
                hasonmin = FixErtekek.hasonminB;
                hasonmax = FixErtekek.hasonmaxB;
                tizezer = Convert.ToDouble(textBox3.Text);
            }
            Kulonb = Convert.ToDouble(textBox3.Text) - Convert.ToDouble(textBox6.Text);
            if (Convert.ToDouble(textBox6.Text) == 0)
                Eltsz = 100;
            else
                Eltsz = Convert.ToDouble(textBox3.Text) / Convert.ToDouble(textBox6.Text) * 100;
            if ((Kulonb >= hasonmin && Kulonb <= hasonmax) && (Eltsz >= FixErtekek.elterminB && Eltsz <= FixErtekek.eltermaxB) && tizezer < FixErtekek.felsohatertB)
            {
                label5.Text = "Jó";
            }
            else
            {
                label5.Text = "Eltérés";
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor = new int[dataGridView1.SelectedCells.Count];
            int sorindex = 0, a;
            int szam;
            double orm = 0, rm;

            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                a = sorindex - 1;
                while (a > -1 && cell.RowIndex != sor[a]) a--;
                if (a == -1)
                {
                    if (Int32.TryParse(dataGridView1.Rows[cell.RowIndex].Cells[1].Value.ToString(), out szam))
                    {
                        double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells["qtyDataGridViewTextBoxColumn"].Value.ToString(), out rm);

                        orm += rm;

                        this.textBox7.Text = orm.ToString("N2");


                    }
                    sor[sorindex] = cell.RowIndex;
                    sorindex++;
                }
            }
        }
        private void CetleeTorol()
        {
            SqlConnection mySqlConnection = new SqlConnection("Data Source=scala1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            mySqlConnection.Open();
            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
            mySqlCommand.CommandText = "delete NBCetLeeFej where TranzakcioSzam=@TranSzam " +
                "delete NBCetLeeSor where TranzakcioSzam=@TranSzam ";
            mySqlCommand.Parameters.Clear();
            mySqlCommand.Parameters.Add("@TranSzam", SqlDbType.NVarChar);
            mySqlCommand.Parameters["@TranSzam"].Value = textBox1.Text.Trim();
            mySqlCommand.ExecuteNonQuery();
        }
        private void CetlleeBeir()
        {
            if (dataGridView2.RowCount >= 1)
            {
                SqlConnection mySqlConnection = new SqlConnection("Data Source=scala1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
                mySqlConnection.Open();
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                //"delete NBCetLeeFej where TranzakcioSzam=@TranSzam delete NBCetLeeSor where TranzakcioSzam=@TranSzam " +
                mySqlCommand.CommandText = "INSERT INTO NBCetLeeFej" +
                     "(TranzakcioSzam,Szallito,Osszeg,Arfolyam,Netto,Afa,BruttoFKSZ,Elteres_O,Elteres_Sz,Statusz,LetrehozasIdeje,Keszitette,Deviza,Orig_TranzakcioSzam,Tipus)" +
                     "VALUES (@TranSzam,@Szallito,@Szertek,@Arfolyam,@Netto,@Afa,@Brutto,@ElterO,@ElterSz,@Status,CURRENT_TIMESTAMP,@Keszito,@Deviza,@eredetizold,'Bom')";
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add("@TranSzam", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@TranSzam"].Value = textBox1.Text.Trim();
                mySqlCommand.Parameters.Add("@Szallito", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Szallito"].Value = szallito.Trim();
                mySqlCommand.Parameters.Add("@Szertek", SqlDbType.Decimal);
                mySqlCommand.Parameters["@Szertek"].Value = Convert.ToDecimal(Szertek);
                mySqlCommand.Parameters.Add("@Arfolyam", SqlDbType.Decimal);
                mySqlCommand.Parameters["@Arfolyam"].Value = Convert.ToDecimal(arfolyam);
                mySqlCommand.Parameters.Add("@Netto", SqlDbType.Decimal);
                mySqlCommand.Parameters["@Netto"].Value = Convert.ToDecimal(textBox3.Text).ToString("N2");
                mySqlCommand.Parameters.Add("@Afa", SqlDbType.Decimal);
                mySqlCommand.Parameters["@Afa"].Value = Convert.ToDecimal(textBox5.Text).ToString("N2");
                mySqlCommand.Parameters.Add("@Brutto", SqlDbType.Decimal);
                mySqlCommand.Parameters["@Brutto"].Value = bruttoFKSZ.ToString().Trim();
                mySqlCommand.Parameters.Add("@ElterO", SqlDbType.Decimal);
                mySqlCommand.Parameters["@ElterO"].Value = Convert.ToDecimal(Kulonb.ToString("N2"));
                mySqlCommand.Parameters.Add("@ElterSz", SqlDbType.Decimal);
                mySqlCommand.Parameters["@ElterSz"].Value = Convert.ToDecimal(Eltsz.ToString("N2"));
                mySqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar);
                if ((Kulonb >= hasonmin && Kulonb <= hasonmax) && (Eltsz >= FixErtekek.elterminB && Eltsz <= FixErtekek.eltermaxB) && tizezer < FixErtekek.felsohatertB)
                {
                    mySqlCommand.Parameters["@Status"].Value = "0";
                }
                else
                {
                    mySqlCommand.Parameters["@Status"].Value = "1";
                }
                mySqlCommand.Parameters.Add("@Keszito", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Keszito"].Value = user.Trim();
                mySqlCommand.Parameters.Add("@Deviza", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Deviza"].Value = deviza.Trim();
                mySqlCommand.Parameters.Add("@eredetizold", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@eredetizold"].Value = eredeti_zoldszam.Trim();
                mySqlCommand.ExecuteNonQuery();

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    mySqlCommand.CommandText = "INSERT INTO NBCetLeeSor " +
                           "(TranzakcioSzam,Sorszam,BeszRendSzam,BeszRendSorSzam,Megjegyzes,BeszAr,EgysAr,Mennyiseg,FKSZ,Leiras,BatchNumber,Cikkszam,SzallLevel,EzustAr,RezAr )" +
                    "VALUES (@TranSzam,@Sorszam,@BeszRendSzam,@RendSorszam,@Megjegyzes,@BeszAr,@EgysAr,@Menny,@FKSZ,@Leiras,@BatchSzam,@cikkszam,@szalllev,@AgAr,@RezAr)";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@TranSzam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@TranSzam"].Value = textBox1.Text.Trim();
                    mySqlCommand.Parameters.Add("@Sorszam", SqlDbType.Int);
                    mySqlCommand.Parameters["@Sorszam"].Value = i + 1;
                    mySqlCommand.Parameters.Add("@BeszRendSzam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@BeszRendSzam"].Value = dataGridView2.Rows[i].Cells["Column2"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@RendSorszam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@RendSorszam"].Value = dataGridView2.Rows[i].Cells["Column3"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Megjegyzes", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Megjegyzes"].Value = dataGridView2.Rows[i].Cells["Column4"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@BeszAr", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@BeszAr"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column5"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@EgysAr", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@EgysAr"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column6"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@Menny", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@Menny"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column7"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@FKSZ", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@FKSZ"].Value = dataGridView2.Rows[i].Cells["Column11"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Leiras", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Leiras"].Value = dataGridView2.Rows[i].Cells["Column12"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@BatchSzam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@BatchSzam"].Value = dataGridView2.Rows[i].Cells["Column16"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@cikkszam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@cikkszam"].Value = dataGridView2.Rows[i].Cells["Column10"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@szalllev", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@szalllev"].Value = dataGridView2.Rows[i].Cells["Column13"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@AgAr", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@AgAr"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column15"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@RezAr", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@RezAr"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column17"].Value.ToString().Trim());
                    mySqlCommand.ExecuteNonQuery();
                }
                mySqlConnection.Close();
            }
            Torol();
        }
    }
}
