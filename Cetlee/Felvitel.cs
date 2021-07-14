using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.DirectoryServices;


namespace Cetlee
{
    public partial class Felvitel : Form
    {
        public string szallito, Szertek, deviza, bruttoFKSZ, Sor1, Sor2, Sor3, fksz;
        private string user, eredeti_zoldszam;
        private int milyen, karx, kary, barx, bary, hasonmin, hasonmax;
        private double afa, arfolyam, Eltsz, Kulonb;
        private DataGridView.HitTestInfo kat;
      //  DataGridViewPrinter MyDataGridViewPrinter;

        public Felvitel()
        {
            InitializeComponent();
            //this.MyPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MyPrintDocument_PrintPage);
        }

        private void Felvitel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'felvitelDataSet.VF_GL0303XX_CodingSegments_ktsgh' table. You can move, or remove it, as needed.
            this.vF_GL0303XX_CodingSegments_ktsghTableAdapter.Fill(this.felvitelDataSet.VF_GL0303XX_CodingSegments_ktsgh);
            // TODO: This line of code loads data into the 'felvitelDataSet.VNB_GL5303XX_AccountShedule_CetLee' table. You can move, or remove it, as needed.
            this.vNB_GL5303XX_AccountShedule_CetLeeTableAdapter.Fill(this.felvitelDataSet.VNB_GL5303XX_AccountShedule_CetLee);
            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            user = de.Properties["fullName"].Value.ToString();
            label2.Text = "";
            label4.Text = "";
            richTextBox1.Rtf = "";
            textBox1.Select();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.vF_PL030300_PurchaseLedgerTableAdapter.Fill(this.felvitelDataSet.VF_PL030300_PurchaseLedger, textBox1.Text.Trim());
                int ZoldFound = VF_PL030300_PurchaseLedgerBindingSource.Count;
                if (ZoldFound > 0)
                {
                    ZoldFound = 0;
                    this.vF_SYCH0300_DevizaTableAdapter.Fill(this.felvitelDataSet.VF_SYCH0300_Deviza, Convert.ToDateTime(felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["InvoiceDate1"].ToString()));
                    if (felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["CurrencyDescription"].ToString().Trim() != "EUR")
                    {
                        int arfFound =VF_SYCH0300_DevizaBindingSource.Count;
                        if (arfFound >= 0)
                            arfolyam = Convert.ToDouble(felvitelDataSet.Tables["VF_SYCH0300_Deviza"].Rows[0]["RateSell"].ToString().Trim());
                        else
                        {
                            MessageBox.Show("Nincs Árfolyam !");
                            textBox1.Clear();
                            textBox1.Select();
                        }
                    }
                    else
                        arfolyam = 1;
                    Sor2 =felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["InvoiceDate1"].ToString().Substring(0, 10);
                    Sor3 = " ¤ " +felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["Netto"].ToString().Trim() + " " +
                                  felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["CurrencyDescription"].ToString().Trim() + " ¤ " +
                                   arfolyam.ToString();
                    //  dataSet34.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["ExchgRate1ByAmo"].ToString().Trim();
                    label2.Text =felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["SupplierCode"].ToString().Trim() + " ¤ " +
                                felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["SupplierName"].ToString().Trim();
                    Sor1 =felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["InvoiceNo"].ToString().Trim() + " ¤ ";
                    var sb = new StringBuilder();
                    sb.Append(@"{\rtf1\ansi ");
                    sb.Append(Sor1);
                    //  sb.Append(@"\line ");
                    sb.Append(@"\b ");
                    sb.Append(Sor2);
                    sb.Append(@"\b0 ");
                    //   sb.Append(@"\b ID Number: \b0 ");
                    sb.Append(Sor3);
                    // sb.Append(@" \line \line ");
                    sb.Append(@"}");

                    richTextBox1.Rtf = sb.ToString();
                    eredeti_zoldszam =felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["InternRefNo"].ToString().Trim();
                    szallito =felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["SupplierCode"].ToString().Trim();
                    Szertek =felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["Netto"].ToString().Trim();
                    deviza =felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["CurrencyDescription"].ToString().Trim();
                    //   arfolyam = Convert.ToDouble(dataSet34.Tables["VF_SYCH0300_Deviza"].Rows[0]["RateSell"].ToString().Trim());
                    this.rendelesekSzolgaltatasokTableAdapter.Fill(this.felvitelDataSet.RendelesekSzolgaltatasok, szallito);
                    dataGridView1.Select();
                    label4.Text = "Áfa (" +felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() + " ¤ " +
                       felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATDesc"].ToString().Trim() + ")";

                    if (felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "46" ||
                       felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "47" ||
                       felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "08" ||
                       felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "23" ||
                       felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "40" ||
                       felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "98" ||
                       felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["VATCode"].ToString().Trim() == "50")
                        afa = 0;
                    else
                        afa = Convert.ToDouble(felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["Percentage"].ToString().Trim());

                    if (felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["AccString"].ToString().Trim() == "4543")
                        bruttoFKSZ = "04543";
                    else
                        bruttoFKSZ = felvitelDataSet.Tables["VF_PL030300_PurchaseLedger"].Rows[ZoldFound]["AccString"].ToString().Trim();
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
            dataGridView2.Rows.Clear();
            dataGridView1.EndEdit();
            string foki;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Column1"].Value))
                    {
                        if (dataGridView1.Rows[i].Cells["rendelesSzamDataGridViewTextBoxColumn"].Value.ToString().Substring(0, 1) == "5")
                        {
                            foki = "2640";
                        }
                        else
                        {
                            foki = "";
                        }
                        if (dataGridView1.Rows[i].Cells["Tipus"].Value.ToString() == "S")
                        {
                            dataGridView2.Rows.Add(dataGridView1.Rows[i].Cells["rendelesSzamDataGridViewTextBoxColumn"].Value,
                            dataGridView1.Rows[i].Cells["rendSorszamDataGridViewTextBoxColumn"].Value, dataGridView1.Rows[i].Cells["megjegyzesDataGridViewTextBoxColumn"].Value,
                            "", dataGridView1.Rows[i].Cells["beruszamRACFDataGridViewTextBoxColumn"].Value, dataGridView1.Rows[i].Cells["arDataGridViewTextBoxColumn"].Value,
                            dataGridView1.Rows[i].Cells["arDataGridViewTextBoxColumn"].Value, 1,
                            dataGridView1.Rows[i].Cells["arDataGridViewTextBoxColumn"].Value,
                            dataGridView1.Rows[i].Cells["devizaDataGridViewTextBoxColumn"].Value, dataGridView1.Rows[i].Cells["Koltseghely"].Value, "", foki, "",
                             dataGridView1.Rows[i].Cells["IDS"].Value,"","");
                        }
                        else
                        {
                            dataGridView2.Rows.Add(dataGridView1.Rows[i].Cells["rendelesSzamDataGridViewTextBoxColumn"].Value,
                            dataGridView1.Rows[i].Cells["rendSorszamDataGridViewTextBoxColumn"].Value, dataGridView1.Rows[i].Cells["megjegyzesDataGridViewTextBoxColumn"].Value,
                            "", dataGridView1.Rows[i].Cells["beruszamRACFDataGridViewTextBoxColumn"].Value, dataGridView1.Rows[i].Cells["Price"].Value,
                            dataGridView1.Rows[i].Cells["Price"].Value, dataGridView1.Rows[i].Cells["Qty"].Value,
                            dataGridView1.Rows[i].Cells["arDataGridViewTextBoxColumn"].Value,
                            dataGridView1.Rows[i].Cells["devizaDataGridViewTextBoxColumn"].Value, "", "", foki, "", "",
                            dataGridView1.Rows[i].Cells["gepSzerszamDataGridViewTextBoxColumn"].Value, dataGridView1.Rows[i].Cells["Szalllevel"].Value);
                        }

                    }
                }
                catch (Exception)
                {
                }
            }
            textBox3.Text = textBox2.Text;
            textBox6.Text = textBox2.Text;
            textBox4.Text = (Convert.ToDouble(Szertek) - Convert.ToDouble(textBox2.Text)).ToString("N2");
            textBox5.Text = (Convert.ToDouble(textBox3.Text) * (afa / 100)).ToString("N2");
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
            if (this.dataGridView2.CurrentRow.Cells["Column16"].Value == null)
                this.dataGridView2.CurrentRow.Cells["Column16"].Value = "";

            if (!String.IsNullOrEmpty(this.dataGridView2.CurrentRow.Cells["Column16"].Value.ToString()))
            {
                int FkszFound =vNBGL5303XXAccountSheduleCetLeeBindingSource.Find("AccountNo", this.dataGridView2.CurrentRow.Cells["Column16"].Value.ToString().Trim());
                if (FkszFound < 0)
                {
                    MessageBox.Show("Nincs ilyen Főkönyvi szám !!", "Figyelmeztetés",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    this.dataGridView2.CurrentRow.Cells["Column16"].Value = "";
                    this.dataGridView2.CurrentRow.Cells["Column16"].Selected = true;
                }
            }
            double ertek2 = 0, ertek3 = 0;
            for (int x = 0; x < dataGridView2.RowCount; x++)
            {
                dataGridView2.Rows[x].Cells["Column5"].Value = (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column12"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column13"].Value));
                ertek2 = ertek2 + (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column12"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column13"].Value));
                ertek3 = ertek3 + (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column17"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column13"].Value));
            }
            textBox3.Text = ertek2.ToString();
            textBox6.Text = ertek3.ToString();
            textBox5.Text = (Convert.ToDouble(textBox3.Text) * (afa / 100)).ToString("N2");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = (Convert.ToDouble(Szertek) - Convert.ToDouble(textBox3.Text)).ToString("N2");
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
            dataGridView2.Rows.Add("", "Egyéb", "", "", "", "0", "1", "1", "1", deviza, "", "", "", "", "","","");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Torol();
        }
        private void Torol()
        {
            textBox1.Clear();
            label2.Text = "";
            richTextBox1.SelectAll();
            richTextBox1.Text = " ";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox5.Text = "0";
            Szertek = "0";
            szallito = "";
            this.rendelesekSzolgaltatasokTableAdapter.Fill(this.felvitelDataSet.RendelesekSzolgaltatasok, szallito);
            dataGridView2.Rows.Clear();
            richTextBox1.Clear();
            textBox4.Text = "0";
            textBox1.Select();
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("", "Fuvar", "", "", "", "0", "1", "1", "1", deviza, "", "", "5217", "Fuvar", "","","");
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
            e.Control.KeyPress -= new KeyPressEventHandler(Column2_KeyPress);
            e.Control.KeyPress -= new KeyPressEventHandler(Column3_KeyPress);

            if (dataGridView2.CurrentCell.ColumnIndex == 5 || dataGridView2.CurrentCell.ColumnIndex == 6) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }

            if (dataGridView2.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column2_KeyPress);
                }
            }
            if (dataGridView2.CurrentCell.ColumnIndex == 8) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column3_KeyPress);
                }
            }
            if (dataGridView2.CurrentCell.ColumnIndex == 9) //Desired Column
            {
                ComboBox cb = e.Control as ComboBox;
                if (cb != null)
                {
                    if (this.dataGridView2.CurrentRow.Cells["Column3"].Value.ToString().Length != 0)
                    {
                        if (this.dataGridView2.CurrentRow.Cells["Column3"].Value.ToString().Substring(0, 1) == "5")
                        {
                            this.dataGridView2.CurrentRow.Cells["Column7"].ReadOnly = true;
                        }
                    }
                }
            }

            if (dataGridView2.CurrentCell.ColumnIndex == 12) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    if (this.dataGridView2.CurrentRow.Cells["Column3"].Value.ToString().Length != 0)
                    {
                        if (this.dataGridView2.CurrentRow.Cells["Column3"].Value.ToString().Substring(0, 1) == "5")
                        {
                            this.dataGridView2.CurrentRow.Cells["Column16"].ReadOnly = true;
                        }
                    }
                    else
                    {
                        if (this.dataGridView2.CurrentRow.Cells["Column4"].Value.ToString().Trim() == "Fuvar")
                        {
                            this.dataGridView2.CurrentRow.Cells["Column16"].ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') || (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Column2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Column3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.dataGridView2.CurrentRow.Cells["Column3"].Value.ToString().Trim() == ""
                && this.dataGridView2.CurrentRow.Cells["Column4"].Value.ToString().Trim() == "")
                this.dataGridView2.CurrentRow.Cells["Column16"].ReadOnly = false;
            else
                this.dataGridView2.CurrentRow.Cells["Column16"].ReadOnly = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            milyen = 0;
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                if (this.dataGridView2.Rows[j].Cells["Column4"].Value.ToString().Trim() == "Fuvar" &&
                this.dataGridView2.Rows[j].Cells["Column7"].Value.ToString().Trim() == "")
                    milyen = 1;

                if (this.dataGridView2.Rows[j].Cells["Column7"].Value.ToString().Trim() != "")
                {
                    this.dataGridView2.Rows[j].Cells["Column14"].Value = this.dataGridView2.Rows[j].Cells["Column7"].Value.ToString().Trim();
                }
            }
            if (milyen == 0)
            {
                this.dataGridView2.Columns["Column7"].Visible = false;
                this.dataGridView2.Columns["Column14"].Visible = true;
                Elteres();
                //  Nyomisz();
                CetlleeBeir();
                this.dataGridView2.Columns["Column7"].Visible = true;
                this.dataGridView2.Columns["Column14"].Visible = false;
            }
            else
                MessageBox.Show("Költséghely !!");
        }

        private void Nyomisz()
        {
            //this.dataGridView2.Columns["Column11"].Visible = false;
            //SetupThePrintingPDF();

            //SetupThePrinting();

            //PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
            //MyPrintPreviewDialog.Document = MyPrintDocument;
            //MyPrintPreviewDialog.ShowDialog();
            //this.dataGridView2.Columns["Column11"].Visible = true;
            //DialogResult dialogResult = MessageBox.Show("Beruházás/Szolgáltatás Lezárható ?", "Lezárható ?", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    Lezaras();
            //}
            ////else if (dialogResult == DialogResult.No)
            ////{
            ////    //do something else
            ////}

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex] == this.Column11)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                double ertek2 = 0, ertek3 = 0;
                for (int x = 0; x < dataGridView2.RowCount; x++)
                {
                    ertek2 = ertek2 + Convert.ToDouble(dataGridView2.Rows[x].Cells["Column5"].Value);
                    ertek3 = ertek3 + (Convert.ToDouble(dataGridView2.Rows[x].Cells["Column17"].Value) * Convert.ToDouble(dataGridView2.Rows[x].Cells["Column13"].Value));
                }
                textBox3.Text = ertek2.ToString();
                textBox6.Text = ertek3.ToString();
                textBox5.Text = (Convert.ToDouble(textBox3.Text) * (afa / 100)).ToString("N2");
            }
        }

        //private bool SetupThePrinting()
        //{
        //    //PrintDialog MyPrintDialog = new PrintDialog();
        //    //MyPrintDialog.AllowCurrentPage = false;
        //    //MyPrintDialog.AllowPrintToFile = false;
        //    //MyPrintDialog.AllowSelection = false;
        //    //MyPrintDialog.AllowSomePages = true; //false;
        //    //MyPrintDialog.PrintToFile = false;
        //    //MyPrintDialog.ShowHelp = false;
        //    //MyPrintDialog.ShowNetwork = false;

        //    //if (MyPrintDialog.ShowDialog() != DialogResult.OK)
        //    //    return false;

        //    //MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;

        //    //MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
        //    //this.MyPrintDocument.DefaultPageSettings.Landscape = true;
        //    //MyPrintDocument.DefaultPageSettings.Margins = new Margins(5, 5, 230, 1);

        //    //MyDataGridViewPrinter = new DataGridViewPrinter(dataGridView2, MyPrintDocument, true, true, "", new Font("Verdana", 16, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

        //    //return true;
        //}

        //private bool SetupThePrintingPDF()
        //{
        //    //MyPrintDocument.PrinterSettings = new PrinterSettings()
        //    //{
        //    //    PrinterName = "Microsoft Print to PDF",
        //    //    PrintToFile = true,
        //    //    PrintFileName = Path.Combine(@"\\fs\anyagigenyles\_non-BOM_CETLI\" + textBox1.Text.Trim() + ".pdf"),
        //    //};
        //    //this.MyPrintDocument.DefaultPageSettings.Landscape = true;
        //    //MyPrintDocument.DefaultPageSettings.Margins = new Margins(5, 5, 230, 1);

        //    //MyDataGridViewPrinter = new DataGridViewPrinter(dataGridView2, MyPrintDocument, true, true, "", new Font("Verdana", 16, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

        //    //MyPrintDocument.Print();

        //    //return true;
        //}
        //private void MyPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    Image newImage = Image.FromFile("Logo_FT.jpg");
        //    Point ulCorner = new Point(20, 20);
        //    string mystring = Convert.ToString(DateTime.Now);
        //    System.Drawing.Graphics g = e.Graphics;
        //    StringFormat format2 = new StringFormat(StringFormatFlags.NoClip);
        //    format2.LineAlignment = StringAlignment.Center;
        //    format2.Alignment = StringAlignment.Far;

        //    StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
        //    format1.LineAlignment = StringAlignment.Center;
        //    format1.Alignment = StringAlignment.Near;

        //    StringFormat format3 = new StringFormat(StringFormatFlags.NoClip);
        //    format3.LineAlignment = StringAlignment.Center;
        //    format3.Alignment = StringAlignment.Far;
        //    format3.FormatFlags = StringFormatFlags.DirectionVertical;

        //    g.DrawString("Kaposvár," + mystring.Substring(0, 11), new System.Drawing.Font("Verdana", 8F), new SolidBrush(Color.Black), new Point(750, 70), format2);
        //    g.DrawString("Ügyintéző : " + user, new System.Drawing.Font("Verdana", 8F), new SolidBrush(Color.Black), new Point(750, 90), format2);
        //    g.DrawString(textBox1.Text.Trim(), new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(250, 90), format1);
        //    g.DrawString(label2.Text.Trim(), new System.Drawing.Font("Verdana", 9F), new SolidBrush(Color.Black), new Point(250, 110), format1);

        //    int charpos = 0, xkord = 250;
        //    while (charpos < richTextBox1.Text.Length)
        //    {
        //        richTextBox1.Select(charpos, 1);
        //        g.DrawString(richTextBox1.SelectedText, richTextBox1.SelectionFont, new SolidBrush(richTextBox1.SelectionColor), new Point(xkord, 120));
        //        xkord = xkord + 8;
        //        charpos++;
        //    }
        //    g.DrawString("Nettó összesen : ", new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(120, 150), format1);
        //    g.DrawString(Convert.ToDouble(textBox3.Text).ToString("N2") + " " + deviza, new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(520, 150), format2);
        //    g.DrawString((Convert.ToDouble(textBox3.Text) * arfolyam).ToString("N2") + " EUR", new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(720, 150), format2);
        //    g.DrawString(label4.Text.Trim() + " : ", new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(120, 170), format1);
        //    g.DrawString(Convert.ToDouble(textBox5.Text).ToString("N2") + " " + deviza, new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(520, 170), format2);
        //    g.DrawString((Convert.ToDouble(textBox5.Text) * arfolyam).ToString("N2") + " EUR", new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(720, 170), format2);
        //    g.DrawString("Bruttó összesen (" + bruttoFKSZ + ") : ", new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(120, 190), format1);
        //    g.DrawString((Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox5.Text)).ToString("N2") + " " + deviza, new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(520, 190), format2);
        //    g.DrawString(((Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox5.Text)) * arfolyam).ToString("N2") + " EUR", new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(720, 190), format2);


        //    g.DrawString(textBox1.Text.Trim(), new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(1110, 780), format3);
        //    g.DrawString(Sor2.Trim(), new System.Drawing.Font("Verdana", 10F, FontStyle.Regular), new SolidBrush(Color.Black), new Point(1090, 780), format3);
        //    if ((Kulonb >= hasonmin && Kulonb <= hasonmax) && (Eltsz >= FixErtekek.eltermin && Eltsz <= FixErtekek.eltermax))
        //    {
        //        label3.Text = "Jó";
        //    }
        //    else
        //    {
        //        g.DrawString("Eltérés : ", new System.Drawing.Font("Verdana", 10F, FontStyle.Italic), new SolidBrush(Color.Black), new Point(120, 210), format1);
        //        g.DrawString(Kulonb.ToString("N2") + " " + deviza + " ¤ " + Eltsz.ToString("N2") + " %", new System.Drawing.Font("Verdana", 10F, FontStyle.Italic), new SolidBrush(Color.Black), new Point(420, 210), format2);
        //    }
        //    g.DrawImage(newImage, ulCorner);

        //    bool more = MyDataGridViewPrinter.DrawDataGridView(g);
        //    if (more == true)
        //        e.HasMorePages = true;
        //}

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)// && dataGridView2.HitTest(e.X, e.Y).RowIndex >= 0)
            {
                karx = e.X;
                kary = e.Y;
                kat = dataGridView2.HitTest(karx, kary);
                int AktSor = kat.RowIndex;
                if (AktSor >= 0)
                {
                    dataGridView3.Visible = true;
                }
            }
            else
                dataGridView3.Visible = false;
        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {
            barx = e.X;
            bary = e.Y;
            DataGridView.HitTestInfo bat = dataGridView3.HitTest(barx, bary);
            int AktSor = bat.RowIndex;
            if (AktSor >= 0)
                this.dataGridView2.Rows[kat.RowIndex].Cells["Column16"].Value = dataGridView3.Rows[bat.RowIndex].Cells["accountNoDataGridViewTextBoxColumn"].Value.ToString().Trim();
            dataGridView3.Visible = false;
            dataGridView2.Select();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lezaras();
        }

        private void Lezaras()
        {
            dataGridView2.EndEdit();
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=Termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();

            for (int x = 0; x < dataGridView2.RowCount; x++)
            {
                if (!String.IsNullOrEmpty(dataGridView2.Rows[x].Cells["Column8"].Value.ToString()))
                {
                    mySqlCommand.CommandText = " update NBSzolgaltatas set Statusz=5 where IDS=@Sorszam ";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@Sorszam", SqlDbType.Int);
                    mySqlCommand.Parameters["@Sorszam"].Value = dataGridView2.Rows[x].Cells["Column8"].Value;
                    mySqlCommand.ExecuteNonQuery();
                }
            }
            connection.Close();
            Torol();
        }

        private void Elteres()
        {
            if (deviza == "HUF")
            {
                hasonmin = Convert.ToInt32(FixErtekek.hasonmin * FixErtekek.eurovalt);
                hasonmax = Convert.ToInt32(FixErtekek.hasonmax * FixErtekek.eurovalt);
            }
            else
            {
                hasonmin = FixErtekek.hasonmin;
                hasonmax = FixErtekek.hasonmax;
            }
            Kulonb = Convert.ToDouble(textBox3.Text) - Convert.ToDouble(textBox6.Text);
            if (Convert.ToDouble(textBox6.Text) == 0)
                Eltsz = 100;
            else
                Eltsz = Convert.ToDouble(textBox3.Text) / Convert.ToDouble(textBox6.Text) * 100;
            if ((Kulonb >= hasonmin && Kulonb <= hasonmax) && (Eltsz >= FixErtekek.eltermin && Eltsz <= FixErtekek.eltermax))
            {
                label3.Text = "Jó";
            }
            else
            {
                label3.Text = "Eltérés";
                //System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                //message.IsBodyHtml = true;
                //string fajl = @"\\fs\anyagigenyles\_non-BOM_CETLI\" + textBox1.Text.Trim() + ".pdf";
                //message.To.Add("damjan.nemeth@fusetech.hu");
                //message.To.Add("istvan.fejes@fusetech.hu");
                //message.To.Add("anett.koleszar@fusetech.hu");
                //message.CC.Add("laszlo.fazekas@fusetech.hu");
                //message.Subject = "Cetlee ELTÉRÉS !!";
                //message.From = new System.Net.Mail.MailAddress("NonBom.Cetlee@fusetech.hu");
                //message.Body = "<br/>A kövezkező CetLee nem felelt meg az előre megadott kritériumoknak :" + textBox1.Text.Trim() +
                //   "<br/><br/>Problémás Cetlee itt ! <a href=\"" + @"\\fs\anyagigenyles\_non-BOM_CETLI\" + textBox1.Text.Trim() + ".pdf\">  " + textBox1.Text + ".pdf</a>" +
                //   "<br/><br/> Üdvözlettel:<br/>    NonBom";
                //System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("mail.fusetech.hu");
                //smtp.Send(message);

            }
        }

        private void CetlleeBeir()
        {
            if (dataGridView2.RowCount >= 1)
            {
                SqlConnection mySqlConnection = new SqlConnection("Data Source=scala1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
                mySqlConnection.Open();
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = "delete NBCetLeeFej where TranzakcioSzam=@TranSzam " +
                    "delete NBCetLeeSor where TranzakcioSzam=@TranSzam " +
                    "INSERT INTO NBCetLeeFej" +
                     "(TranzakcioSzam,Szallito,Osszeg,Arfolyam,Netto,Afa,BruttoFKSZ,Elteres_O,Elteres_Sz,Statusz,LetrehozasIdeje,Keszitette,Deviza,Orig_TranzakcioSzam,Tipus)" +
                     "VALUES (@TranSzam,@Szallito,@Szertek,@Arfolyam,@Netto,@Afa,@Brutto,@ElterO,@ElterSz,@Status,CURRENT_TIMESTAMP,@Keszito,@Deviza,@eredetizold,'NonBom')";
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
                if ((Kulonb >= hasonmin && Kulonb <= hasonmax) && (Eltsz >= FixErtekek.eltermin && Eltsz <= FixErtekek.eltermax))
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
                           "(TranzakcioSzam,Sorszam,BeszRendSzam,BeszRendSorSzam,Megjegyzes,TetelSzam,RACF,BeszAr,EgysAr,Mennyiseg,Koltseghely,FKSZ,Leiras,Cikkszam,SzallLevel)" +
                    "VALUES (@TranSzam,@Sorszam,@BeszRendSzam,@RendSorszam,@Megjegyzes,@TetelSzam,@RACF,@BeszAr,@EgysAr,@Menny,@Koltseg,@FKSZ,@Leiras,@cikkszam,@szalllev)";
                    mySqlCommand.Parameters.Clear();
                    mySqlCommand.Parameters.Add("@TranSzam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@TranSzam"].Value = textBox1.Text.Trim();
                    mySqlCommand.Parameters.Add("@Sorszam", SqlDbType.Int);
                    mySqlCommand.Parameters["@Sorszam"].Value = i+1;
                    mySqlCommand.Parameters.Add("@BeszRendSzam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@BeszRendSzam"].Value = dataGridView2.Rows[i].Cells["Column3"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@RendSorszam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@RendSorszam"].Value = dataGridView2.Rows[i].Cells["Column4"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Megjegyzes", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Megjegyzes"].Value = dataGridView2.Rows[i].Cells["Column15"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@TetelSzam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@TetelSzam"].Value = dataGridView2.Rows[i].Cells["Column2"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@RACF", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@RACF"].Value = dataGridView2.Rows[i].Cells["Column10"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@BeszAr", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@BeszAr"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column17"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@EgysAr", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@EgysAr"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column12"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@Menny", SqlDbType.Decimal);
                    mySqlCommand.Parameters["@Menny"].Value = Convert.ToDecimal(dataGridView2.Rows[i].Cells["Column13"].Value.ToString().Trim());
                    mySqlCommand.Parameters.Add("@Koltseg", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Koltseg"].Value = dataGridView2.Rows[i].Cells["Column14"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@FKSZ", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@FKSZ"].Value = dataGridView2.Rows[i].Cells["Column16"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@Leiras", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@Leiras"].Value = dataGridView2.Rows[i].Cells["Column9"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@cikkszam", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@cikkszam"].Value = dataGridView2.Rows[i].Cells["Column18"].Value.ToString().Trim();
                    mySqlCommand.Parameters.Add("@szalllev", SqlDbType.NVarChar);
                    mySqlCommand.Parameters["@szalllev"].Value = dataGridView2.Rows[i].Cells["Column19"].Value.ToString().Trim();
                    mySqlCommand.ExecuteNonQuery();
                }
                mySqlConnection.Close();
            }
            Torol();
        }



    }
}
