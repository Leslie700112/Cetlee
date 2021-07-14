
namespace Cetlee
{
    partial class Lekerdezes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cetleekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lekérdezés = new Cetlee.Lekérdezés();
            this.cetleekTableAdapter = new Cetlee.LekérdezésTableAdapters.CetleekTableAdapter();
            this.tranzakcioSzamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szallitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDate1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osszegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arfolyamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elteresODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elteresSzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letrehozasIdejeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keszitetteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttoFKSZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engedelyezoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engedIdejeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuszDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetleekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekérdezés)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tranzakcioSzamDataGridViewTextBoxColumn,
            this.szallitoDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.invoiceNoDataGridViewTextBoxColumn,
            this.invoiceDate1DataGridViewTextBoxColumn,
            this.osszegDataGridViewTextBoxColumn,
            this.arfolyamDataGridViewTextBoxColumn,
            this.nettoDataGridViewTextBoxColumn,
            this.afaDataGridViewTextBoxColumn,
            this.devizaDataGridViewTextBoxColumn,
            this.elteresODataGridViewTextBoxColumn,
            this.elteresSzDataGridViewTextBoxColumn,
            this.letrehozasIdejeDataGridViewTextBoxColumn,
            this.keszitetteDataGridViewTextBoxColumn,
            this.bruttoFKSZDataGridViewTextBoxColumn,
            this.vATCodeDataGridViewTextBoxColumn,
            this.vATDescDataGridViewTextBoxColumn,
            this.percentageDataGridViewTextBoxColumn,
            this.engedelyezoDataGridViewTextBoxColumn,
            this.engedIdejeDataGridViewTextBoxColumn,
            this.tipusDataGridViewTextBoxColumn,
            this.statuszDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cetleekBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1308, 561);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // cetleekBindingSource
            // 
            this.cetleekBindingSource.DataMember = "Cetleek";
            this.cetleekBindingSource.DataSource = this.lekérdezés;
            // 
            // lekérdezés
            // 
            this.lekérdezés.DataSetName = "Lekérdezés";
            this.lekérdezés.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cetleekTableAdapter
            // 
            this.cetleekTableAdapter.ClearBeforeFill = true;
            // 
            // tranzakcioSzamDataGridViewTextBoxColumn
            // 
            this.tranzakcioSzamDataGridViewTextBoxColumn.DataPropertyName = "TranzakcioSzam";
            this.tranzakcioSzamDataGridViewTextBoxColumn.HeaderText = "Tranz. Szám";
            this.tranzakcioSzamDataGridViewTextBoxColumn.Name = "tranzakcioSzamDataGridViewTextBoxColumn";
            this.tranzakcioSzamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szallitoDataGridViewTextBoxColumn
            // 
            this.szallitoDataGridViewTextBoxColumn.DataPropertyName = "Szallito";
            this.szallitoDataGridViewTextBoxColumn.HeaderText = "Szállito Kód";
            this.szallitoDataGridViewTextBoxColumn.Name = "szallitoDataGridViewTextBoxColumn";
            this.szallitoDataGridViewTextBoxColumn.ReadOnly = true;
            this.szallitoDataGridViewTextBoxColumn.Width = 90;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Szállító";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "Számlaszám";
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
            this.invoiceNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceNoDataGridViewTextBoxColumn.Width = 120;
            // 
            // invoiceDate1DataGridViewTextBoxColumn
            // 
            this.invoiceDate1DataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate1";
            this.invoiceDate1DataGridViewTextBoxColumn.HeaderText = "Szla. Dátum";
            this.invoiceDate1DataGridViewTextBoxColumn.Name = "invoiceDate1DataGridViewTextBoxColumn";
            this.invoiceDate1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // osszegDataGridViewTextBoxColumn
            // 
            this.osszegDataGridViewTextBoxColumn.DataPropertyName = "Osszeg";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.osszegDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.osszegDataGridViewTextBoxColumn.HeaderText = "Összeg";
            this.osszegDataGridViewTextBoxColumn.Name = "osszegDataGridViewTextBoxColumn";
            this.osszegDataGridViewTextBoxColumn.ReadOnly = true;
            this.osszegDataGridViewTextBoxColumn.Width = 80;
            // 
            // arfolyamDataGridViewTextBoxColumn
            // 
            this.arfolyamDataGridViewTextBoxColumn.DataPropertyName = "Arfolyam";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N4";
            dataGridViewCellStyle3.NullValue = null;
            this.arfolyamDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.arfolyamDataGridViewTextBoxColumn.HeaderText = "Árfolyam";
            this.arfolyamDataGridViewTextBoxColumn.Name = "arfolyamDataGridViewTextBoxColumn";
            this.arfolyamDataGridViewTextBoxColumn.ReadOnly = true;
            this.arfolyamDataGridViewTextBoxColumn.Width = 80;
            // 
            // nettoDataGridViewTextBoxColumn
            // 
            this.nettoDataGridViewTextBoxColumn.DataPropertyName = "Netto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.nettoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.nettoDataGridViewTextBoxColumn.HeaderText = "Nettó";
            this.nettoDataGridViewTextBoxColumn.Name = "nettoDataGridViewTextBoxColumn";
            this.nettoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nettoDataGridViewTextBoxColumn.Width = 80;
            // 
            // afaDataGridViewTextBoxColumn
            // 
            this.afaDataGridViewTextBoxColumn.DataPropertyName = "Afa";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.afaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.afaDataGridViewTextBoxColumn.HeaderText = "Áfa";
            this.afaDataGridViewTextBoxColumn.Name = "afaDataGridViewTextBoxColumn";
            this.afaDataGridViewTextBoxColumn.ReadOnly = true;
            this.afaDataGridViewTextBoxColumn.Width = 80;
            // 
            // devizaDataGridViewTextBoxColumn
            // 
            this.devizaDataGridViewTextBoxColumn.DataPropertyName = "Deviza";
            this.devizaDataGridViewTextBoxColumn.HeaderText = "Deviza";
            this.devizaDataGridViewTextBoxColumn.Name = "devizaDataGridViewTextBoxColumn";
            this.devizaDataGridViewTextBoxColumn.ReadOnly = true;
            this.devizaDataGridViewTextBoxColumn.Width = 60;
            // 
            // elteresODataGridViewTextBoxColumn
            // 
            this.elteresODataGridViewTextBoxColumn.DataPropertyName = "Elteres_O";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.elteresODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.elteresODataGridViewTextBoxColumn.HeaderText = "Eltérés Összeg";
            this.elteresODataGridViewTextBoxColumn.Name = "elteresODataGridViewTextBoxColumn";
            this.elteresODataGridViewTextBoxColumn.ReadOnly = true;
            this.elteresODataGridViewTextBoxColumn.Width = 90;
            // 
            // elteresSzDataGridViewTextBoxColumn
            // 
            this.elteresSzDataGridViewTextBoxColumn.DataPropertyName = "Elteres_Sz";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.elteresSzDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.elteresSzDataGridViewTextBoxColumn.HeaderText = "Eltérés %";
            this.elteresSzDataGridViewTextBoxColumn.Name = "elteresSzDataGridViewTextBoxColumn";
            this.elteresSzDataGridViewTextBoxColumn.ReadOnly = true;
            this.elteresSzDataGridViewTextBoxColumn.Width = 80;
            // 
            // letrehozasIdejeDataGridViewTextBoxColumn
            // 
            this.letrehozasIdejeDataGridViewTextBoxColumn.DataPropertyName = "LetrehozasIdeje";
            this.letrehozasIdejeDataGridViewTextBoxColumn.HeaderText = "Létrehoz.Idő";
            this.letrehozasIdejeDataGridViewTextBoxColumn.Name = "letrehozasIdejeDataGridViewTextBoxColumn";
            this.letrehozasIdejeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keszitetteDataGridViewTextBoxColumn
            // 
            this.keszitetteDataGridViewTextBoxColumn.DataPropertyName = "Keszitette";
            this.keszitetteDataGridViewTextBoxColumn.HeaderText = "Készítette";
            this.keszitetteDataGridViewTextBoxColumn.Name = "keszitetteDataGridViewTextBoxColumn";
            this.keszitetteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bruttoFKSZDataGridViewTextBoxColumn
            // 
            this.bruttoFKSZDataGridViewTextBoxColumn.DataPropertyName = "BruttoFKSZ";
            this.bruttoFKSZDataGridViewTextBoxColumn.HeaderText = "FKSZ";
            this.bruttoFKSZDataGridViewTextBoxColumn.Name = "bruttoFKSZDataGridViewTextBoxColumn";
            this.bruttoFKSZDataGridViewTextBoxColumn.ReadOnly = true;
            this.bruttoFKSZDataGridViewTextBoxColumn.Width = 80;
            // 
            // vATCodeDataGridViewTextBoxColumn
            // 
            this.vATCodeDataGridViewTextBoxColumn.DataPropertyName = "VATCode";
            this.vATCodeDataGridViewTextBoxColumn.HeaderText = "Áfa Kód";
            this.vATCodeDataGridViewTextBoxColumn.Name = "vATCodeDataGridViewTextBoxColumn";
            this.vATCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vATCodeDataGridViewTextBoxColumn.Width = 60;
            // 
            // vATDescDataGridViewTextBoxColumn
            // 
            this.vATDescDataGridViewTextBoxColumn.DataPropertyName = "VATDesc";
            this.vATDescDataGridViewTextBoxColumn.HeaderText = "Áfa";
            this.vATDescDataGridViewTextBoxColumn.Name = "vATDescDataGridViewTextBoxColumn";
            this.vATDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percentageDataGridViewTextBoxColumn
            // 
            this.percentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage";
            this.percentageDataGridViewTextBoxColumn.HeaderText = "Áfa %";
            this.percentageDataGridViewTextBoxColumn.Name = "percentageDataGridViewTextBoxColumn";
            this.percentageDataGridViewTextBoxColumn.ReadOnly = true;
            this.percentageDataGridViewTextBoxColumn.Width = 60;
            // 
            // engedelyezoDataGridViewTextBoxColumn
            // 
            this.engedelyezoDataGridViewTextBoxColumn.DataPropertyName = "Engedelyezo";
            this.engedelyezoDataGridViewTextBoxColumn.HeaderText = "Engedélyező";
            this.engedelyezoDataGridViewTextBoxColumn.Name = "engedelyezoDataGridViewTextBoxColumn";
            this.engedelyezoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engedIdejeDataGridViewTextBoxColumn
            // 
            this.engedIdejeDataGridViewTextBoxColumn.DataPropertyName = "EngedIdeje";
            this.engedIdejeDataGridViewTextBoxColumn.HeaderText = "Enged.Ideje";
            this.engedIdejeDataGridViewTextBoxColumn.Name = "engedIdejeDataGridViewTextBoxColumn";
            this.engedIdejeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipusDataGridViewTextBoxColumn
            // 
            this.tipusDataGridViewTextBoxColumn.DataPropertyName = "Tipus";
            this.tipusDataGridViewTextBoxColumn.HeaderText = "Tipus";
            this.tipusDataGridViewTextBoxColumn.Name = "tipusDataGridViewTextBoxColumn";
            this.tipusDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipusDataGridViewTextBoxColumn.Width = 60;
            // 
            // statuszDataGridViewTextBoxColumn
            // 
            this.statuszDataGridViewTextBoxColumn.DataPropertyName = "Statusz";
            this.statuszDataGridViewTextBoxColumn.HeaderText = "Statusz";
            this.statuszDataGridViewTextBoxColumn.Name = "statuszDataGridViewTextBoxColumn";
            this.statuszDataGridViewTextBoxColumn.ReadOnly = true;
            this.statuszDataGridViewTextBoxColumn.Visible = false;
            this.statuszDataGridViewTextBoxColumn.Width = 60;
            // 
            // Lekerdezes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1308, 561);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lekerdezes";
            this.Text = "Cetlee-k Lekérdezése";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lekerdezes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetleekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekérdezés)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Lekérdezés lekérdezés;
        private System.Windows.Forms.BindingSource cetleekBindingSource;
        private LekérdezésTableAdapters.CetleekTableAdapter cetleekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranzakcioSzamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szallitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDate1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osszegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arfolyamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elteresODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elteresSzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn letrehozasIdejeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keszitetteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttoFKSZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engedelyezoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engedIdejeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuszDataGridViewTextBoxColumn;
    }
}