
namespace Cetlee
{
    partial class Konyvelheto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Konyvelheto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.statuszDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letrehozasIdejeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keszitetteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttoFKSZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cetLeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engedelyezoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engedIdejeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Engedelyezo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngedIdeje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBCetLeeFejBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.konyvDataSet = new Cetlee.KonyvDataSet();
            this.nBCetLeeFejTableAdapter = new Cetlee.KonyvDataSetTableAdapters.NBCetLeeFejTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBCetLeeFejBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konyvDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1294, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton1.Text = "Frissítés";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.statuszDataGridViewTextBoxColumn,
            this.letrehozasIdejeDataGridViewTextBoxColumn,
            this.keszitetteDataGridViewTextBoxColumn,
            this.bruttoFKSZDataGridViewTextBoxColumn,
            this.vATCodeDataGridViewTextBoxColumn,
            this.vATDescDataGridViewTextBoxColumn,
            this.percentageDataGridViewTextBoxColumn,
            this.cetLeeIDDataGridViewTextBoxColumn,
            this.engedelyezoDataGridViewTextBoxColumn,
            this.engedIdejeDataGridViewTextBoxColumn,
            this.Tipus,
            this.Engedelyezo,
            this.EngedIdeje});
            this.dataGridView1.DataSource = this.nBCetLeeFejBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Size = new System.Drawing.Size(1294, 528);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // tranzakcioSzamDataGridViewTextBoxColumn
            // 
            this.tranzakcioSzamDataGridViewTextBoxColumn.DataPropertyName = "TranzakcioSzam";
            this.tranzakcioSzamDataGridViewTextBoxColumn.HeaderText = "Tranzakció Szám";
            this.tranzakcioSzamDataGridViewTextBoxColumn.Name = "tranzakcioSzamDataGridViewTextBoxColumn";
            this.tranzakcioSzamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szallitoDataGridViewTextBoxColumn
            // 
            this.szallitoDataGridViewTextBoxColumn.DataPropertyName = "Szallito";
            this.szallitoDataGridViewTextBoxColumn.HeaderText = "Száll. Kód";
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
            this.supplierNameDataGridViewTextBoxColumn.Width = 220;
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
            this.invoiceDate1DataGridViewTextBoxColumn.HeaderText = "Számla Dátum";
            this.invoiceDate1DataGridViewTextBoxColumn.Name = "invoiceDate1DataGridViewTextBoxColumn";
            this.invoiceDate1DataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceDate1DataGridViewTextBoxColumn.Width = 120;
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
            this.arfolyamDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.arfolyamDataGridViewTextBoxColumn.HeaderText = "Árfolyam";
            this.arfolyamDataGridViewTextBoxColumn.Name = "arfolyamDataGridViewTextBoxColumn";
            this.arfolyamDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.elteresODataGridViewTextBoxColumn.Width = 120;
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
            this.elteresSzDataGridViewTextBoxColumn.Width = 90;
            // 
            // statuszDataGridViewTextBoxColumn
            // 
            this.statuszDataGridViewTextBoxColumn.DataPropertyName = "Statusz";
            this.statuszDataGridViewTextBoxColumn.HeaderText = "Statusz";
            this.statuszDataGridViewTextBoxColumn.Name = "statuszDataGridViewTextBoxColumn";
            this.statuszDataGridViewTextBoxColumn.ReadOnly = true;
            this.statuszDataGridViewTextBoxColumn.Visible = false;
            // 
            // letrehozasIdejeDataGridViewTextBoxColumn
            // 
            this.letrehozasIdejeDataGridViewTextBoxColumn.DataPropertyName = "LetrehozasIdeje";
            this.letrehozasIdejeDataGridViewTextBoxColumn.HeaderText = "Létrehoz. Idő";
            this.letrehozasIdejeDataGridViewTextBoxColumn.Name = "letrehozasIdejeDataGridViewTextBoxColumn";
            this.letrehozasIdejeDataGridViewTextBoxColumn.ReadOnly = true;
            this.letrehozasIdejeDataGridViewTextBoxColumn.Width = 120;
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
            this.vATCodeDataGridViewTextBoxColumn.HeaderText = "VATCode";
            this.vATCodeDataGridViewTextBoxColumn.Name = "vATCodeDataGridViewTextBoxColumn";
            this.vATCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vATCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // vATDescDataGridViewTextBoxColumn
            // 
            this.vATDescDataGridViewTextBoxColumn.DataPropertyName = "VATDesc";
            this.vATDescDataGridViewTextBoxColumn.HeaderText = "VATDesc";
            this.vATDescDataGridViewTextBoxColumn.Name = "vATDescDataGridViewTextBoxColumn";
            this.vATDescDataGridViewTextBoxColumn.ReadOnly = true;
            this.vATDescDataGridViewTextBoxColumn.Visible = false;
            // 
            // percentageDataGridViewTextBoxColumn
            // 
            this.percentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage";
            this.percentageDataGridViewTextBoxColumn.HeaderText = "Percentage";
            this.percentageDataGridViewTextBoxColumn.Name = "percentageDataGridViewTextBoxColumn";
            this.percentageDataGridViewTextBoxColumn.ReadOnly = true;
            this.percentageDataGridViewTextBoxColumn.Visible = false;
            // 
            // cetLeeIDDataGridViewTextBoxColumn
            // 
            this.cetLeeIDDataGridViewTextBoxColumn.DataPropertyName = "CetLeeID";
            this.cetLeeIDDataGridViewTextBoxColumn.HeaderText = "CetLeeID";
            this.cetLeeIDDataGridViewTextBoxColumn.Name = "cetLeeIDDataGridViewTextBoxColumn";
            this.cetLeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cetLeeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // engedelyezoDataGridViewTextBoxColumn
            // 
            this.engedelyezoDataGridViewTextBoxColumn.DataPropertyName = "Engedelyezo";
            this.engedelyezoDataGridViewTextBoxColumn.HeaderText = "Engedelyezo";
            this.engedelyezoDataGridViewTextBoxColumn.Name = "engedelyezoDataGridViewTextBoxColumn";
            this.engedelyezoDataGridViewTextBoxColumn.ReadOnly = true;
            this.engedelyezoDataGridViewTextBoxColumn.Visible = false;
            // 
            // engedIdejeDataGridViewTextBoxColumn
            // 
            this.engedIdejeDataGridViewTextBoxColumn.DataPropertyName = "EngedIdeje";
            this.engedIdejeDataGridViewTextBoxColumn.HeaderText = "EngedIdeje";
            this.engedIdejeDataGridViewTextBoxColumn.Name = "engedIdejeDataGridViewTextBoxColumn";
            this.engedIdejeDataGridViewTextBoxColumn.ReadOnly = true;
            this.engedIdejeDataGridViewTextBoxColumn.Visible = false;
            // 
            // Tipus
            // 
            this.Tipus.DataPropertyName = "Tipus";
            this.Tipus.HeaderText = "Tipus";
            this.Tipus.Name = "Tipus";
            this.Tipus.ReadOnly = true;
            // 
            // Engedelyezo
            // 
            this.Engedelyezo.DataPropertyName = "Engedelyezo";
            this.Engedelyezo.HeaderText = "Engedélyező";
            this.Engedelyezo.Name = "Engedelyezo";
            this.Engedelyezo.ReadOnly = true;
            // 
            // EngedIdeje
            // 
            this.EngedIdeje.DataPropertyName = "EngedIdeje";
            this.EngedIdeje.HeaderText = "Eng.Ideje";
            this.EngedIdeje.Name = "EngedIdeje";
            this.EngedIdeje.ReadOnly = true;
            // 
            // nBCetLeeFejBindingSource
            // 
            this.nBCetLeeFejBindingSource.DataMember = "NBCetLeeFej";
            this.nBCetLeeFejBindingSource.DataSource = this.konyvDataSet;
            // 
            // konyvDataSet
            // 
            this.konyvDataSet.DataSetName = "KonyvDataSet";
            this.konyvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nBCetLeeFejTableAdapter
            // 
            this.nBCetLeeFejTableAdapter.ClearBeforeFill = true;
            // 
            // Konyvelheto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1294, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Konyvelheto";
            this.Text = "Könyvelhető Cetlee-k";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Konyvelheto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBCetLeeFejBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konyvDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KonyvDataSet konyvDataSet;
        private System.Windows.Forms.BindingSource nBCetLeeFejBindingSource;
        private KonyvDataSetTableAdapters.NBCetLeeFejTableAdapter nBCetLeeFejTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn statuszDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn letrehozasIdejeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keszitetteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttoFKSZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cetLeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engedelyezoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engedIdejeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Engedelyezo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngedIdeje;
    }
}