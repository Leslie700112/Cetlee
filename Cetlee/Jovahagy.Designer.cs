
namespace Cetlee
{
    partial class Jovahagy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jovahagy));
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nBCetLeeFejBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jovahagyas = new Cetlee.Jovahagyas();
            this.nBCetLeeFejTableAdapter = new Cetlee.JovahagyasTableAdapters.NBCetLeeFejTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cetLeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vATCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBCetLeeFejBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jovahagyas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1308, 25);
            this.toolStrip1.TabIndex = 1;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton2.Text = "Kijelöltek";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(136, 22);
            this.toolStripButton3.Text = "Összes kijelölése";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(115, 22);
            this.toolStripButton4.Text = "Engedélyezés";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(118, 22);
            this.toolStripButton5.Text = "Visszautasítás";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
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
            this.Column1,
            this.cetLeeIDDataGridViewTextBoxColumn,
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
            this.Column2,
            this.vATCodeDataGridViewTextBoxColumn,
            this.vATDescDataGridViewTextBoxColumn,
            this.percentageDataGridViewTextBoxColumn,
            this.Tipus});
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1308, 425);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // nBCetLeeFejBindingSource
            // 
            this.nBCetLeeFejBindingSource.DataMember = "NBCetLeeFej";
            this.nBCetLeeFejBindingSource.DataSource = this.jovahagyas;
            // 
            // jovahagyas
            // 
            this.jovahagyas.DataSetName = "Jovahagyas";
            this.jovahagyas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nBCetLeeFejTableAdapter
            // 
            this.nBCetLeeFejTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.TrueValue = "true";
            this.Column1.Width = 40;
            // 
            // cetLeeIDDataGridViewTextBoxColumn
            // 
            this.cetLeeIDDataGridViewTextBoxColumn.DataPropertyName = "CetLeeID";
            this.cetLeeIDDataGridViewTextBoxColumn.HeaderText = "CetLeeID";
            this.cetLeeIDDataGridViewTextBoxColumn.Name = "cetLeeIDDataGridViewTextBoxColumn";
            this.cetLeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cetLeeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tranzakcioSzamDataGridViewTextBoxColumn
            // 
            this.tranzakcioSzamDataGridViewTextBoxColumn.DataPropertyName = "TranzakcioSzam";
            this.tranzakcioSzamDataGridViewTextBoxColumn.HeaderText = "Tranzakció Szám";
            this.tranzakcioSzamDataGridViewTextBoxColumn.Name = "tranzakcioSzamDataGridViewTextBoxColumn";
            this.tranzakcioSzamDataGridViewTextBoxColumn.Width = 135;
            // 
            // szallitoDataGridViewTextBoxColumn
            // 
            this.szallitoDataGridViewTextBoxColumn.DataPropertyName = "Szallito";
            this.szallitoDataGridViewTextBoxColumn.HeaderText = "Száll. Kód";
            this.szallitoDataGridViewTextBoxColumn.Name = "szallitoDataGridViewTextBoxColumn";
            this.szallitoDataGridViewTextBoxColumn.Width = 90;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Szállító";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.Width = 220;
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "Számlaszám";
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
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
            this.osszegDataGridViewTextBoxColumn.Width = 80;
            // 
            // arfolyamDataGridViewTextBoxColumn
            // 
            this.arfolyamDataGridViewTextBoxColumn.DataPropertyName = "Arfolyam";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.arfolyamDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.arfolyamDataGridViewTextBoxColumn.HeaderText = "Árfolyam";
            this.arfolyamDataGridViewTextBoxColumn.Name = "arfolyamDataGridViewTextBoxColumn";
            this.arfolyamDataGridViewTextBoxColumn.Visible = false;
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
            this.afaDataGridViewTextBoxColumn.Width = 80;
            // 
            // devizaDataGridViewTextBoxColumn
            // 
            this.devizaDataGridViewTextBoxColumn.DataPropertyName = "Deviza";
            this.devizaDataGridViewTextBoxColumn.HeaderText = "Deviza";
            this.devizaDataGridViewTextBoxColumn.Name = "devizaDataGridViewTextBoxColumn";
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
            this.elteresSzDataGridViewTextBoxColumn.Width = 90;
            // 
            // statuszDataGridViewTextBoxColumn
            // 
            this.statuszDataGridViewTextBoxColumn.DataPropertyName = "Statusz";
            this.statuszDataGridViewTextBoxColumn.HeaderText = "Státusz";
            this.statuszDataGridViewTextBoxColumn.Name = "statuszDataGridViewTextBoxColumn";
            this.statuszDataGridViewTextBoxColumn.Visible = false;
            // 
            // letrehozasIdejeDataGridViewTextBoxColumn
            // 
            this.letrehozasIdejeDataGridViewTextBoxColumn.DataPropertyName = "LetrehozasIdeje";
            this.letrehozasIdejeDataGridViewTextBoxColumn.HeaderText = "Létrehoz. Idő";
            this.letrehozasIdejeDataGridViewTextBoxColumn.Name = "letrehozasIdejeDataGridViewTextBoxColumn";
            this.letrehozasIdejeDataGridViewTextBoxColumn.Width = 120;
            // 
            // keszitetteDataGridViewTextBoxColumn
            // 
            this.keszitetteDataGridViewTextBoxColumn.DataPropertyName = "Keszitette";
            this.keszitetteDataGridViewTextBoxColumn.HeaderText = "Készítette";
            this.keszitetteDataGridViewTextBoxColumn.Name = "keszitetteDataGridViewTextBoxColumn";
            this.keszitetteDataGridViewTextBoxColumn.Width = 120;
            // 
            // bruttoFKSZDataGridViewTextBoxColumn
            // 
            this.bruttoFKSZDataGridViewTextBoxColumn.DataPropertyName = "BruttoFKSZ";
            this.bruttoFKSZDataGridViewTextBoxColumn.HeaderText = "BruttoFKSZ";
            this.bruttoFKSZDataGridViewTextBoxColumn.Name = "bruttoFKSZDataGridViewTextBoxColumn";
            this.bruttoFKSZDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CetLee";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Text = "CetLee";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 80;
            // 
            // vATCodeDataGridViewTextBoxColumn
            // 
            this.vATCodeDataGridViewTextBoxColumn.DataPropertyName = "VATCode";
            this.vATCodeDataGridViewTextBoxColumn.HeaderText = "VATCode";
            this.vATCodeDataGridViewTextBoxColumn.Name = "vATCodeDataGridViewTextBoxColumn";
            this.vATCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // vATDescDataGridViewTextBoxColumn
            // 
            this.vATDescDataGridViewTextBoxColumn.DataPropertyName = "VATDesc";
            this.vATDescDataGridViewTextBoxColumn.HeaderText = "VATDesc";
            this.vATDescDataGridViewTextBoxColumn.Name = "vATDescDataGridViewTextBoxColumn";
            this.vATDescDataGridViewTextBoxColumn.Visible = false;
            // 
            // percentageDataGridViewTextBoxColumn
            // 
            this.percentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage";
            this.percentageDataGridViewTextBoxColumn.HeaderText = "Percentage";
            this.percentageDataGridViewTextBoxColumn.Name = "percentageDataGridViewTextBoxColumn";
            this.percentageDataGridViewTextBoxColumn.Visible = false;
            // 
            // Tipus
            // 
            this.Tipus.DataPropertyName = "Tipus";
            this.Tipus.HeaderText = "Tipus";
            this.Tipus.Name = "Tipus";
            // 
            // Jovahagy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1308, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Jovahagy";
            this.Text = "Cetlee Jóváhagyás";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Jovahagy_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBCetLeeFejBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jovahagyas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Jovahagyas jovahagyas;
        private System.Windows.Forms.BindingSource nBCetLeeFejBindingSource;
        private JovahagyasTableAdapters.NBCetLeeFejTableAdapter nBCetLeeFejTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cetLeeIDDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipus;
    }
}