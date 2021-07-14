using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Data.SqlClient;
using DgvFilterPopup;

namespace Cetlee
{
    public partial class AlvallFelvitel : Form
    {
        public string szallito, deviza, bruttoFKSZ, Sor1, Sor2, Sor3, fksz,bacsszam, Fertek;
        private string user, eredeti_zoldszam;
        private int milyen, karx, kary, barx, bary, hasonmin, hasonmax;
        private double afa, arfolyam, Eltsz, Kulonb, tizezer, Szertek, Eertek;
        private DataGridView.HitTestInfo kat;
      
        public AlvallFelvitel()
        {
            InitializeComponent();
        }

        private void AlvallFelvitel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alVallDataSet.NBCetLeeFej' table. You can move, or remove it, as needed.
           // this.nBCetLeeFejTableAdapter.Fill(this.alVallDataSet.NBCetLeeFej);
            // TODO: This line of code loads data into the 'alVallDataSet.VF_GL0303XX_CodingSegments_termek' table. You can move, or remove it, as needed.
            this.vF_GL0303XX_CodingSegments_termekTableAdapter.Fill(this.alVallDataSet.VF_GL0303XX_CodingSegments_termek);
            // TODO: This line of code loads data into the 'alVallDataSet1.VF_GL5303XX_AccountShedule' table. You can move, or remove it, as needed.
            this.vF_GL5303XX_AccountSheduleTableAdapter.Fill(this.alVallDataSet.VF_GL5303XX_AccountShedule);
            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            user = de.Properties["fullName"].Value.ToString();
            DgvFilterManager fm = new DgvFilterManager();
            //  fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);
            fm.DataGridView = dataGridView1;

            label2.Text = "";
            label3.Text = "";
            richTextBox1.Rtf = "";
            textBox1.Select();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.vF_PL030300_PurchaseLedgerTableAdapter.Fill(this.alVallDataSet.VF_PL030300_PurchaseLedger, textBox1.Text.Trim());
                int ZoldFound = VF_PL030300_PurchaseLedgerBindingSource.Count;
                if (ZoldFound > 0)
                {
                    this.nBCetLeeFejTableAdapter.Fill(this.alVallDataSet.NBCetLeeFej, textBox1.Text.Trim());
                    int CetleeFound = NBCetLeeFejBindingSource.Count;
                    if (CetleeFound <= 0)
                    {
                        textBox1.Enabled = false;
                        ZoldFound = 0;
                        this.vF_SYCH0300_DevizaTableAdapter.Fill(this.alVallDataSet.VF_SYCH0300_Deviza, Convert.ToDateTime(alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["InvoiceDate1"].ToString()));
                        if (alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["CurrencyDescription"].ToString().Trim() != "EUR")
                        {
                            int arfFound = VF_SYCH0300_DevizaBindingSource.Count;
                            if (arfFound >= 0)
                                arfolyam = Convert.ToDouble(alVallDataSet.Tables["VF_SYCH0300_Deviza"].Rows[0]["RateSell"].ToString().Trim());
                            else
                            {
                                MessageBox.Show("Nincs Árfolyam !");
                                textBox1.Clear();
                                textBox1.Select();
                            }
                        }
                        else
                            arfolyam = 1;
                        Sor2 = alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["InvoiceDate1"].ToString().Substring(0, 10);
                        Sor3 = " ¤ " + alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["Netto"].ToString().Trim() + " " +
                                     alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["CurrencyDescription"].ToString().Trim() + " ¤ " +
                                       arfolyam.ToString();
                        label2.Text = alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["SupplierCode"].ToString().Trim() + " ¤ " +
                                    alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["SupplierName"].ToString().Trim();
                        Sor1 = alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["InvoiceNo"].ToString().Trim() + " ¤ ";
                        var sb = new StringBuilder();
                        sb.Append(@"{\rtf1\ansi ");
                        sb.Append(Sor1);
                        sb.Append(@"\b ");
                        sb.Append(Sor2);
                        sb.Append(@"\b0 ");
                        sb.Append(Sor3);
                        sb.Append(@"}");

                        richTextBox1.Rtf = sb.ToString();
                        eredeti_zoldszam = alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["InternRefNo"].ToString().Trim();
                        szallito = alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["SupplierCode"].ToString().Trim();
                        Fertek = alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["Netto"].ToString().Trim();
                        deviza = alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["CurrencyDescription"].ToString().Trim();
                        //arfolyam = Convert.ToDouble(alVallDataSet.Tables["VF_SYCH0300_Deviza"].Rows[0]["RateSell"].ToString().Trim());
                        this.rendelesekTableAdapter.Fill(this.alVallDataSet.Rendelesek, szallito);
                        dataGridView1.Select();
                        label3.Text = "Áfa (" + alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() + " ¤ " +
                          alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATDesc"].ToString().Trim() + ")";

                        if (alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "46" ||
                           alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "47" ||
                           alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "08" ||
                           alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "23" ||
                           alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "40" ||
                           alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "98" ||
                           alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "50")
                            afa = 0;
                        else
                            afa = Convert.ToDouble(alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["Percentage"].ToString().Trim());

                        if (alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["AccString"].ToString().Trim() == "4543")
                            bruttoFKSZ = "04543";
                        else
                            bruttoFKSZ = alVallDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["AccString"].ToString().Trim();
                    }
                    else
                    {
                       DialogResult dr= MessageBox.Show("Már van ilyen Cetlee !!    Törlöjem ?","Most Mi Legyen ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                        switch(dr)
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
            string foki,foki2;
            int FKSZFound;
   
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Column1"].Value))
                    {
                        if (dataGridView1.Rows[i].Cells["WorkCenter"].Value.ToString().Trim().Substring(0, 1) == "G")
                            foki = "528";
                         else
                            foki = "5282";
                        FKSZFound = VF_GL5303XX_AccountSheduleBindingSource.Find("AccountNo", foki);
                        foki2 = alVallDataSet.Tables["VF_GL5303XX_AccountShedule"].Rows[FKSZFound]["AccountName"].ToString().Trim();
                        DataGridViewComboBoxCell CBCell = new DataGridViewComboBoxCell();
                        CBCell.DisplayMember = foki2;
                        CBCell.ValueMember = foki2;
                        dataGridView2.Rows.Add(dataGridView1.Rows[i].Cells["orderNumberDataGridViewTextBoxColumn"].Value,
                       dataGridView1.Rows[i].Cells["stockCodeDataGridViewTextBoxColumn"].Value, dataGridView1.Rows[i].Cells["description1DataGridViewTextBoxColumn"].Value,
                        dataGridView1.Rows[i].Cells["description2DataGridViewTextBoxColumn"].Value, dataGridView1.Rows[i].Cells["descriptionDataGridViewTextBoxColumn"].Value,
                      Convert.ToDouble(dataGridView1.Rows[i].Cells["subcontrCostDataGridViewTextBoxColumn"].Value)/arfolyam,
                       Convert.ToDouble(dataGridView1.Rows[i].Cells["subcontrCostDataGridViewTextBoxColumn"].Value)/arfolyam,"0",
                       dataGridView1.Rows[i].Cells["qtyDataGridViewTextBoxColumn"].Value,
                       (Convert.ToDouble(dataGridView1.Rows[i].Cells["subcontrCostDataGridViewTextBoxColumn"].Value)/arfolyam) * Convert.ToDouble(dataGridView1.Rows[i].Cells["qtyDataGridViewTextBoxColumn"].Value),
                       deviza, dataGridView1.Rows[i].Cells["accCodStringDataGridViewTextBoxColumn"].Value, foki,foki2, dataGridView1.Rows[i].Cells["FIFOBatchID"].Value,
                       dataGridView1.Rows[i].Cells["FelulkezelSzalllevel"].Value,
                       (Convert.ToDouble(dataGridView1.Rows[i].Cells["subcontrCostDataGridViewTextBoxColumn"].Value) / arfolyam) * Convert.ToDouble(dataGridView1.Rows[i].Cells["qtyDataGridViewTextBoxColumn"].Value));
                       dataGridView1.Rows[i].Cells["Column1"].Value = false;
                    }
                }
                catch (Exception)
                {
                }
            }
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                if (!String.IsNullOrEmpty(dataGridView2.Rows[j].Cells["Column15"].Value.ToString()))
                {
                    for (int k = 0; k < dataGridView1.RowCount; k++)
                    {
                        if (dataGridView2.Rows[j].Cells["Column15"].Value.ToString() == dataGridView1.Rows[k].Cells["FIFOBatchID"].Value.ToString())
                            dataGridView1.Rows.Remove(dataGridView1.Rows[k]);
                    }
                }
                Szertek = Szertek + Convert.ToDouble(dataGridView2.Rows[j].Cells["Column8"].Value);
                Eertek = Eertek + Convert.ToDouble(dataGridView2.Rows[j].Cells["Column20"].Value);
            }
            dataGridView1.EndEdit();
            textBox3.Text = Eertek.ToString("N2");
            textBox4.Text = (Convert.ToDouble(Fertek) - Convert.ToDouble(Szertek)).ToString("N2");
            textBox5.Text = (Convert.ToDouble(Szertek) * (afa / 100)).ToString("N2");
            textBox6.Text = Eertek.ToString("N2");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.EndEdit();
            double ertek = 0;
            for (int a = 0; a < dataGridView1.RowCount; a++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[a].Cells["Column1"].Value))
                {
                    ertek = ertek + ((Convert.ToDouble(dataGridView1.Rows[a].Cells["subcontrCostDataGridViewTextBoxColumn"].Value)/arfolyam) * Convert.ToDouble(dataGridView1.Rows[a].Cells["qtyDataGridViewTextBoxColumn"].Value));
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
                int FkszFound = VF_GL5303XX_AccountSheduleBindingSource.Find("AccountNo", this.dataGridView2.CurrentRow.Cells["Column11"].Value.ToString().Trim());
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
                dataGridView2.Rows[x].Cells["Column8"].Value = (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column6"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value)+
                                                               ( Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column19"].Value)));
                ertek2 = ertek2 + (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column6"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value) +
                                  (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column19"].Value)));
                ertek3 = ertek3 + (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column5"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value));
            }
            textBox3.Text = ertek2.ToString("N2");
            textBox6.Text = ertek3.ToString("N2");
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
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("", "", "", "", "Egyéb", "0", "1","0", "1", "1", deviza, "", "5282", "Bérmunka Egyéb","","","");
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
            this.rendelesekTableAdapter.Fill(this.alVallDataSet.Rendelesek, szallito);
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
            if (dataGridView2.CurrentCell.ColumnIndex == 6 || dataGridView2.CurrentCell.ColumnIndex == 7 ||dataGridView2.CurrentCell.ColumnIndex == 8) //Desired Column
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
            milyen = 0;
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                if (this.dataGridView2.Rows[j].Cells["Column10"].Value.ToString().Trim() == "")
                    milyen = 1;
            }
            if (milyen == 0)
            {
                Elteres();
                CetlleeBeir();
            }
            else
                MessageBox.Show("Költséghely !!");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex] == this.Column16)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                this.rendelesekTableAdapter.Fill(this.alVallDataSet.Rendelesek, szallito);
                double ertek2 = 0, ertek3 = 0;
                for (int x = 0; x < dataGridView2.RowCount; x++)
                {
                    ertek2 = ertek2 + (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column6"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value) +
                                 (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column19"].Value)));
                    ertek3 = ertek3 + (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column5"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column7"].Value));
                    if (!String.IsNullOrEmpty(dataGridView2.Rows[x].Cells["Column15"].Value.ToString()))
                    {
                        for (int t = 0; t < dataGridView1.RowCount; t++)
                        {
                            if (dataGridView2.Rows[x].Cells["Column15"].Value.ToString() == dataGridView1.Rows[t].Cells["FIFOBatchID"].Value.ToString())
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

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)// && dataGridView2.HitTest(e.X, e.Y).RowIndex >= 0)
            {
                karx = e.X;
                kary = e.Y;
                kat = dataGridView2.HitTest(karx, kary);
                int AktSor = kat.RowIndex;
                int Aktoszl = kat.ColumnIndex;
                if (AktSor >= 0 && Aktoszl == 12)
                {
                    dataGridView3.Visible = true;
                }
                if (AktSor >= 0 && Aktoszl == 11)
                {
                    dataGridView4.Visible = true;
                }
            }
            else
            {
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
            }
        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            barx = e.X;
            bary = e.Y;
            DataGridView.HitTestInfo bat = dataGridView3.HitTest(barx, bary);
            int AktSor = bat.RowIndex;
            if (AktSor >= 0)
            {
                this.dataGridView2.Rows[kat.RowIndex].Cells["Column11"].Value = dataGridView3.Rows[bat.RowIndex].Cells["accountNoDataGridViewTextBoxColumn"].Value.ToString().Trim();
                this.dataGridView2.Rows[kat.RowIndex].Cells["Column12"].Value = dataGridView3.Rows[bat.RowIndex].Cells["accountNameDataGridViewTextBoxColumn"].Value.ToString().Trim();
            }
          dataGridView3.Visible = false;
            dataGridView2.Select();
        }
        private void dataGridView4_MouseClick(object sender, MouseEventArgs e)
        {
            barx = e.X;
            bary = e.Y;
            DataGridView.HitTestInfo bat = dataGridView4.HitTest(barx, bary);
            int AktSor = bat.RowIndex;
            if (AktSor >= 0)
            {
                this.dataGridView2.Rows[kat.RowIndex].Cells["Column10"].Value = dataGridView4.Rows[bat.RowIndex].Cells["costCentreDataGridViewTextBoxColumn"].Value.ToString().Trim();
            }
            dataGridView4.Visible = false;
            dataGridView2.Select();
        }
        private void Elteres()
        {
          
            if (deviza == "HUF")
            {
                hasonmin = Convert.ToInt32(FixErtekek.hasonminAl * FixErtekek.eurovaltAl);
                hasonmax = Convert.ToInt32(FixErtekek.hasonmaxAl * FixErtekek.eurovaltAl);
                tizezer = Convert.ToDouble(textBox3.Text) / FixErtekek.eurovaltAl;
             }
            else
            {
                hasonmin = FixErtekek.hasonminAl;
                hasonmax = FixErtekek.hasonmaxAl;
                tizezer = Convert.ToDouble(textBox3.Text);
            }
            Kulonb = Convert.ToDouble(textBox3.Text) - Convert.ToDouble(textBox6.Text);
            if (Convert.ToDouble(textBox6.Text) == 0)
                Eltsz = 100;
            else
                Eltsz = Convert.ToDouble(textBox3.Text) / Convert.ToDouble(textBox6.Text) * 100;
            if ((Kulonb >= hasonmin && Kulonb <= hasonmax) && (Eltsz >= FixErtekek.elterminAl && Eltsz <= FixErtekek.eltermaxAl) && tizezer<FixErtekek.felsohatert)
            {
                label5.Text = "Jó";
            }
            else
            {
                label5.Text = "Eltérés";
            }
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
                     "VALUES (@TranSzam,@Szallito,@Szertek,@Arfolyam,@Netto,@Afa,@Brutto,@ElterO,@ElterSz,@Status,CURRENT_TIMESTAMP,@Keszito,@Deviza,@eredetizold,'Alváll')";
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
                if ((Kulonb >= hasonmin && Kulonb <= hasonmax) && (Eltsz >= FixErtekek.elterminAl && Eltsz <= FixErtekek.eltermaxAl) && tizezer < FixErtekek.felsohatert)
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
                           "(TranzakcioSzam,Sorszam,BeszRendSzam,Megjegyzes,BeszAr,EgysAr,Mennyiseg,Koltseghely,FKSZ,Leiras,BatchNumber,Cikkszam,SzallLevel,EzustAr )" +
                    "VALUES (@TranSzam,@Sorszam,@BeszRendSzam,@Megjegyzes,@BeszAr,@EgysAr,@Menny,@Koltseg,@FKSZ,@Leiras,@BatchSzam,@cikkszam,@szalllev,@AgAr)";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@TranSzam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@TranSzam"].Value = textBox1.Text.Trim();
                    mySqlCommand.Parameters.Add("@Sorszam", SqlDbType.Int);
                    mySqlCommand.Parameters["@Sorszam"].Value = i+1;
                    mySqlCommand.Parameters.Add("@BeszRendSzam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@BeszRendSzam"].Value = dataGridView2.Rows[i].Cells["Column13"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Megjegyzes", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Megjegyzes"].Value = dataGridView2.Rows[i].Cells["Column14"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@BeszAr", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@BeszAr"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column5"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@EgysAr", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@EgysAr"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column6"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@Menny", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@Menny"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column7"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@Koltseg", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Koltseg"].Value = dataGridView2.Rows[i].Cells["Column10"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@FKSZ", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@FKSZ"].Value = dataGridView2.Rows[i].Cells["Column11"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Leiras", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Leiras"].Value = dataGridView2.Rows[i].Cells["Column12"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@BatchSzam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@BatchSzam"].Value = dataGridView2.Rows[i].Cells["Column15"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@cikkszam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@cikkszam"].Value = dataGridView2.Rows[i].Cells["Column2"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@szalllev", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@szalllev"].Value = dataGridView2.Rows[i].Cells["Column18"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@AgAr", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@AgAr"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column19"].Value.ToString().Trim());
                    mySqlCommand.ExecuteNonQuery();
                }
                mySqlConnection.Close();
            }
            Torol();
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



    }
    }
