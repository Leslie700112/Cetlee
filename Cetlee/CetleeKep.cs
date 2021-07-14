using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace Cetlee
{
    public partial class CetleeKep : Form
    {
        DataGridViewPrinter MyDataGridViewPrinter;
        public string Ugyintez, LetrehozIdo, Tranzsz, Szall, SzallNev, Szlaszam, Szlaido, Osszeg, Arfoly, Netto, Deviza, Afakod, Afa, AfaNev;

      

        public string Fksz, ElterO, ElterSz, Enged, EngedIdo,jogi, Kihivta;
        public CetleeKep()
        {
            InitializeComponent();
           this.MyPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MyPrintDocument_PrintPage);
        }
        private void CetleeKep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cetleeKepDataSet.VF_GL0303XX_CodingSegments_ktsgh' table. You can move, or remove it, as needed.
            this.vF_GL0303XX_CodingSegments_ktsghTableAdapter.Fill(this.cetleeKepDataSet.VF_GL0303XX_CodingSegments_ktsgh);
            // TODO: This line of code loads data into the 'cetleeKepDataSet.VNB_GL5303XX_AccountShedule_CetLee' table. You can move, or remove it, as needed.
            this.vNB_GL5303XX_AccountShedule_CetLeeTableAdapter.Fill(this.cetleeKepDataSet.VNB_GL5303XX_AccountShedule_CetLee);
            // TODO: This line of code loads data into the 'cetleeKepDataSet.NBCetLeeSorFKSZ' table. You can move, or remove it, as needed.
         
            int hasonmin, hasonmax;
            this.nBCetLeeSorTableAdapter.Fill(this.cetleeKepDataSet.NBCetLeeSor, Tranzsz);
            this.nBCetLeeSorFKSZTableAdapter.Fill(this.cetleeKepDataSet.NBCetLeeSorFKSZ, Arfoly, Tranzsz);
            label3.Text = "Kaposvár, " + LetrehozIdo;
            label4.Text = "Ügyintéző : " + Ugyintez;
            label1.Text = Tranzsz;
            label2.Text = Szall + " ¤ " + SzallNev;
            label5.Text = Szlaszam + " ¤ " + Szlaido + " ¤ " + Osszeg + " " + Deviza + " ¤ " + Arfoly;
            label6.Text = "Nettó összesen: ";
            label7.Text = "Áfa (" + Afakod + " ¤ " + AfaNev + ") :";
            label8.Text = "Bruttó összesen (" + Fksz + ") :";
            textBox1.Text = Convert.ToDouble(Netto).ToString("N2") + " " + Deviza;
            textBox4.Text = (Convert.ToDouble(Netto) * Convert.ToDouble(Arfoly)).ToString("N2") + " EUR";
            textBox2.Text = Convert.ToDouble(Afa).ToString("N2") + " " + Deviza;
            textBox5.Text = (Convert.ToDouble(Afa) * Convert.ToDouble(Arfoly)).ToString("N2") + " EUR";
            textBox3.Text = (Convert.ToDouble(Netto) + Convert.ToDouble(Afa)).ToString("N2") + " " + Deviza;
            textBox6.Text = ((Convert.ToDouble(Netto) + Convert.ToDouble(Afa)) * Convert.ToDouble(Arfoly)).ToString("N2") + " EUR";
            if ((Form1.Jogok.jog == "K"  || Form1.Jogok.jog == "A") && Kihivta=="1" )
            {
                dataGridView1.Columns["koltseghelyDataGridViewTextBoxColumn"].DefaultCellStyle.BackColor = Color.PaleGreen;
                dataGridView1.Columns["fKSZDataGridViewTextBoxColumn"].DefaultCellStyle.BackColor = Color.PaleGreen;
                dataGridView1.Columns["leirasDataGridViewTextBoxColumn"].DefaultCellStyle.BackColor = Color.PaleGreen;
                dataGridView1.Columns["koltseghelyDataGridViewTextBoxColumn"].ReadOnly =false;
                dataGridView1.Columns["fKSZDataGridViewTextBoxColumn"].ReadOnly = false;
                dataGridView1.Columns["leirasDataGridViewTextBoxColumn"].ReadOnly = false;
              
            }
            if (Deviza == "HUF")
            {
                hasonmin = Convert.ToInt32(FixErtekek.hasonmin* FixErtekek.eurovalt);
                hasonmax = Convert.ToInt32(FixErtekek.hasonmax * FixErtekek.eurovalt);
            }
            else
            {
                hasonmin = FixErtekek.hasonmin;
                hasonmax = FixErtekek.hasonmax;
            }
            if ((Convert.ToDouble(ElterO) >= hasonmin && Convert.ToDouble(ElterO) <= hasonmax)
                && (Convert.ToDouble(ElterSz) >= FixErtekek.eltermin && Convert.ToDouble(ElterSz) <= FixErtekek.eltermax))
            {
                label9.Visible = false;
                label10.Visible = false;
            }
            else
            {
                label9.Text = "Eltérés : " + ElterO + " " + Deviza + " ¤ " + ElterSz + " %";
                if (Enged != "Vár")
                {
                    label10.Text = "Jóváhagyta : " + Enged + " ¤ " + EngedIdo;
                }
                else
                {
                    label10.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nyomisz();
            this.dataGridView1.Columns["leirasDataGridViewTextBoxColumn"].Visible = true;
            this.dataGridView1.Columns["MMK"].Visible = true;
            this.dataGridView1.Columns["EzustAr"].Visible = true;
            this.dataGridView1.Columns["RezAr"].Visible = true;
            
        }
        private void Nyomisz()
        {
            this.dataGridView1.Columns["leirasDataGridViewTextBoxColumn"].Visible = false;
            this.dataGridView1.Columns["MMK"].Visible = false;
            this.dataGridView1.Columns["EzustAr"].Visible = false;
            this.dataGridView1.Columns["RezAr"].Visible = false;
            
            
            SetupThePrinting();

            PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
            MyPrintPreviewDialog.ClientSize = new System.Drawing.Size(1200, 800);
            MyPrintPreviewDialog.Document = MyPrintDocument;
            MyPrintPreviewDialog.ShowDialog();
        }

        private bool SetupThePrinting()
        {
            PrintDialog MyPrintDialog = new PrintDialog();

            //if (MyPrintDialog.ShowDialog() != DialogResult.OK)
            //    return false;

            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;

            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            this.MyPrintDocument.DefaultPageSettings.Landscape = true;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(5, 5, 230, 1);

            MyDataGridViewPrinter = new DataGridViewPrinter(dataGridView1, MyPrintDocument, true, true, "", new Font("Verdana", 16, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
        }
        private void MyPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int hasonmin, hasonmax;
            Image newImage = Image.FromFile("Logo_FT.jpg");
            Point ulCorner = new Point(20, 20);
            string mystring = Convert.ToString(DateTime.Now);
            System.Drawing.Graphics g = e.Graphics;
            StringFormat format2 = new StringFormat(StringFormatFlags.NoClip);
            format2.LineAlignment = StringAlignment.Center;
            format2.Alignment = StringAlignment.Far;

            StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
            format1.LineAlignment = StringAlignment.Center;
            format1.Alignment = StringAlignment.Near;

            StringFormat format3 = new StringFormat(StringFormatFlags.NoClip);
            format3.LineAlignment = StringAlignment.Center;
            format3.Alignment = StringAlignment.Far;
            format3.FormatFlags = StringFormatFlags.DirectionVertical;

            g.DrawString("Kaposvár," + LetrehozIdo, new System.Drawing.Font("Verdana", 8F), new SolidBrush(Color.Black), new Point(750, 70), format2);
            g.DrawString("Ügyintéző : " + Ugyintez, new System.Drawing.Font("Verdana", 8F), new SolidBrush(Color.Black), new Point(750, 90), format2);
            g.DrawString(Tranzsz, new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(250, 90), format1);
            g.DrawString(Szall + " ¤ " + SzallNev, new System.Drawing.Font("Verdana", 9F), new SolidBrush(Color.Black), new Point(250, 110), format1);
            g.DrawString(Szlaszam + " ¤ " + Convert.ToDateTime(Szlaido).ToString("yyyy.MM.dd") + " ¤ " + Osszeg + " " + Deviza + " ¤ " + Arfoly
                           , new System.Drawing.Font("Verdana", 9F), new SolidBrush(Color.Black), new Point(250, 130), format1);
            g.DrawString("Nettó összesen : ", new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(120, 150), format1);
            g.DrawString(Convert.ToDouble(Netto).ToString("N2") + " " + Deviza, new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(520, 150), format2);
            g.DrawString((Convert.ToDouble(Netto) * Convert.ToDouble(Arfoly)).ToString("N2") + " EUR",
                new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(720, 150), format2);
            g.DrawString("Áfa (" + Afakod + " ¤ " + AfaNev + ") : ", new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(120, 170), format1);
            g.DrawString(Convert.ToDouble(Afa).ToString("N2") + " " + Deviza, new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(520, 170), format2);
            g.DrawString((Convert.ToDouble(Afa) * Convert.ToDouble(Arfoly)).ToString("N2") + " EUR",
                new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(720, 170), format2);
            g.DrawString("Bruttó összesen (" + Fksz + ") : ", new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(120, 190), format1);
            g.DrawString((Convert.ToDouble(Netto) + Convert.ToDouble(Afa)).ToString("N2") + " " + Deviza,
                new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(520, 190), format2);
            g.DrawString(((Convert.ToDouble(Netto) + Convert.ToDouble(Afa)) * Convert.ToDouble(Arfoly)).ToString("N2") + " EUR",
                new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(720, 190), format2);

            g.DrawString(Tranzsz, new System.Drawing.Font("Verdana", 10F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(1110, 780), format3);
            g.DrawString(Convert.ToDateTime(Szlaido).ToString("yyyy.MM.dd"), new System.Drawing.Font("Verdana", 10F, FontStyle.Regular), new SolidBrush(Color.Black), new Point(1090, 780), format3);

            if (Deviza == "HUF")
            {
                hasonmin = Convert.ToInt32(FixErtekek.hasonmin * FixErtekek.eurovalt);
                hasonmax = Convert.ToInt32(FixErtekek.hasonmax * FixErtekek.eurovalt);
            }
            else
            {
                hasonmin = FixErtekek.hasonmin;
                hasonmax = FixErtekek.hasonmax;
            }
            if ((Convert.ToDouble(ElterO) >= hasonmin && Convert.ToDouble(ElterO) <= hasonmax)
                && (Convert.ToDouble(ElterSz) >= FixErtekek.eltermin && Convert.ToDouble(ElterSz) <= FixErtekek.eltermax))
            {
                // label3.Text = "Jó";
            }
            else
            {
                g.DrawString("Eltérés : ", new System.Drawing.Font("Verdana", 10F, FontStyle.Italic), new SolidBrush(Color.Black), new Point(120, 210), format1);
                g.DrawString(ElterO + " " + Deviza + " ¤ " + ElterSz + " %", new System.Drawing.Font("Verdana", 10F, FontStyle.Italic), new SolidBrush(Color.Black), new Point(420, 210), format2);
                if (Enged != "Vár")
                {
                    g.DrawString("Jóváhagyta : ", new System.Drawing.Font("Verdana", 10F, FontStyle.Italic), new SolidBrush(Color.Black), new Point(500, 210), format1);
                    g.DrawString(Enged + " ¤ " + EngedIdo,
                        new System.Drawing.Font("Verdana", 10F, FontStyle.Italic), new SolidBrush(Color.Black), new Point(600, 210), format1);
                }
            }

            g.DrawImage(newImage, ulCorner);
            bool more = MyDataGridViewPrinter.DrawDataGridView(g);
            if (more == true)
                e.HasMorePages = true;
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.EndEdit();
            int josag = 0;
            int FkszFound =VNB_GL5303XX_AccountShedule_CetLeeBbindingSource.Find("AccountNo", this.dataGridView1.CurrentRow.Cells["fKSZDataGridViewTextBoxColumn"].Value.ToString().Trim());
            int KTSGHFound = VF_GL0303XX_CodingSegments_ktsghBindingSource.Find("CostCentre", dataGridView1.CurrentRow.Cells["koltseghelyDataGridViewTextBoxColumn"].Value.ToString().Trim());
            if (FkszFound < 0)
            {
                MessageBox.Show("Nincs ilyen Főkönyvi szám !!", "Figyelmeztetés",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
                josag++;
            if (KTSGHFound < 0)
            {
                MessageBox.Show("Nincs ilyen Költséghely !!", "Figyelmeztetés",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
                josag++;
            if (josag ==2)
            {
                SqlConnection mySqlConnection = new SqlConnection("Data Source=scala1;Initial Catalog=Fusetech;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
                mySqlConnection.Open();
                SqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandText = "UPDATE NBCetLeeSor SET FKSZ=@FKSZ,Koltseghely=@KTSGH,Leiras=@Megj where CetLeeISorID=@CetleeID";
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.Add("@CetleeID", SqlDbType.Int);
                mySqlCommand.Parameters["@CetleeID"].Value = dataGridView1.CurrentRow.Cells["cetLeeISorIDDataGridViewTextBoxColumn"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@FKSZ", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@FKSZ"].Value = dataGridView1.CurrentRow.Cells["fKSZDataGridViewTextBoxColumn"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@KTSGH", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@KTSGH"].Value = dataGridView1.CurrentRow.Cells["koltseghelyDataGridViewTextBoxColumn"].Value.ToString().Trim();
                mySqlCommand.Parameters.Add("@Megj", SqlDbType.NVarChar);
                mySqlCommand.Parameters["@Megj"].Value = dataGridView1.CurrentRow.Cells["leirasDataGridViewTextBoxColumn"].Value.ToString().Trim();
                mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
        }

      

    }
}
