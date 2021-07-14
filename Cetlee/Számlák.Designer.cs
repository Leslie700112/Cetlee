
namespace Cetlee
{
    partial class Számlák
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.szamlak = new Cetlee.Szamlak();
            this.vFPL030300PurchaseLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vF_PL030300_PurchaseLedgerTableAdapter = new Cetlee.SzamlakTableAdapters.VF_PL030300_PurchaseLedgerTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.internRefNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDate1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookenrDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invAmoLocCurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invAmoOriCurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTermsCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vATDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranzakcioSzamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuszDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elteresODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elteresSzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szamlak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFPL030300PurchaseLedgerBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.internRefNoDataGridViewTextBoxColumn,
            this.supplierCodeDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.invoiceNoDataGridViewTextBoxColumn,
            this.invoiceDate1DataGridViewTextBoxColumn,
            this.bookenrDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.invAmoLocCurDataGridViewTextBoxColumn,
            this.invAmoOriCurDataGridViewTextBoxColumn,
            this.currencyDescriptionDataGridViewTextBoxColumn,
            this.paymentTermsCodeDataGridViewTextBoxColumn,
            this.vATCodeDataGridViewTextBoxColumn,
            this.vATDescDataGridViewTextBoxColumn,
            this.percentageDataGridViewTextBoxColumn,
            this.tranzakcioSzamDataGridViewTextBoxColumn,
            this.statuszDataGridViewTextBoxColumn,
            this.elteresODataGridViewTextBoxColumn,
            this.elteresSzDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vFPL030300PurchaseLedgerBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(800, 428);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // szamlak
            // 
            this.szamlak.DataSetName = "Szamlak";
            this.szamlak.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vFPL030300PurchaseLedgerBindingSource
            // 
            this.vFPL030300PurchaseLedgerBindingSource.DataMember = "VF_PL030300_PurchaseLedger";
            this.vFPL030300PurchaseLedgerBindingSource.DataSource = this.szamlak;
            // 
            // vF_PL030300_PurchaseLedgerTableAdapter
            // 
            this.vF_PL030300_PurchaseLedgerTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.PaleGreen;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel1.Text = "Könyvelhető";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ActiveLinkColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.OrangeRed;
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "Jóváhagyásra vár";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.DarkGray;
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel3.Text = "Visszautasítva";
            // 
            // internRefNoDataGridViewTextBoxColumn
            // 
            this.internRefNoDataGridViewTextBoxColumn.DataPropertyName = "InternRefNo";
            this.internRefNoDataGridViewTextBoxColumn.HeaderText = "Tranz.szám";
            this.internRefNoDataGridViewTextBoxColumn.Name = "internRefNoDataGridViewTextBoxColumn";
            this.internRefNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierCodeDataGridViewTextBoxColumn
            // 
            this.supplierCodeDataGridViewTextBoxColumn.DataPropertyName = "SupplierCode";
            this.supplierCodeDataGridViewTextBoxColumn.HeaderText = "Száll.Kód";
            this.supplierCodeDataGridViewTextBoxColumn.Name = "supplierCodeDataGridViewTextBoxColumn";
            this.supplierCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierCodeDataGridViewTextBoxColumn.Width = 80;
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
            this.invoiceDate1DataGridViewTextBoxColumn.HeaderText = "Számla Dátum";
            this.invoiceDate1DataGridViewTextBoxColumn.Name = "invoiceDate1DataGridViewTextBoxColumn";
            this.invoiceDate1DataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceDate1DataGridViewTextBoxColumn.Width = 80;
            // 
            // bookenrDateDataGridViewTextBoxColumn
            // 
            this.bookenrDateDataGridViewTextBoxColumn.DataPropertyName = "BookenrDate";
            this.bookenrDateDataGridViewTextBoxColumn.HeaderText = "Iktatás Dátum";
            this.bookenrDateDataGridViewTextBoxColumn.Name = "bookenrDateDataGridViewTextBoxColumn";
            this.bookenrDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookenrDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "Esed.Dátum";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invAmoLocCurDataGridViewTextBoxColumn
            // 
            this.invAmoLocCurDataGridViewTextBoxColumn.DataPropertyName = "InvAmoLocCur";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.invAmoLocCurDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.invAmoLocCurDataGridViewTextBoxColumn.HeaderText = "Összeg €";
            this.invAmoLocCurDataGridViewTextBoxColumn.Name = "invAmoLocCurDataGridViewTextBoxColumn";
            this.invAmoLocCurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invAmoOriCurDataGridViewTextBoxColumn
            // 
            this.invAmoOriCurDataGridViewTextBoxColumn.DataPropertyName = "InvAmoOriCur";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.invAmoOriCurDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.invAmoOriCurDataGridViewTextBoxColumn.HeaderText = "Össz.Ered.Dev.";
            this.invAmoOriCurDataGridViewTextBoxColumn.Name = "invAmoOriCurDataGridViewTextBoxColumn";
            this.invAmoOriCurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currencyDescriptionDataGridViewTextBoxColumn
            // 
            this.currencyDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CurrencyDescription";
            this.currencyDescriptionDataGridViewTextBoxColumn.HeaderText = "Dev";
            this.currencyDescriptionDataGridViewTextBoxColumn.Name = "currencyDescriptionDataGridViewTextBoxColumn";
            this.currencyDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyDescriptionDataGridViewTextBoxColumn.Width = 50;
            // 
            // paymentTermsCodeDataGridViewTextBoxColumn
            // 
            this.paymentTermsCodeDataGridViewTextBoxColumn.DataPropertyName = "PaymentTermsCode";
            this.paymentTermsCodeDataGridViewTextBoxColumn.HeaderText = "Fiz.Idő";
            this.paymentTermsCodeDataGridViewTextBoxColumn.Name = "paymentTermsCodeDataGridViewTextBoxColumn";
            this.paymentTermsCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentTermsCodeDataGridViewTextBoxColumn.Width = 50;
            // 
            // vATCodeDataGridViewTextBoxColumn
            // 
            this.vATCodeDataGridViewTextBoxColumn.DataPropertyName = "VATCode";
            this.vATCodeDataGridViewTextBoxColumn.HeaderText = "Áfa Kód";
            this.vATCodeDataGridViewTextBoxColumn.Name = "vATCodeDataGridViewTextBoxColumn";
            this.vATCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vATCodeDataGridViewTextBoxColumn.Width = 50;
            // 
            // vATDescDataGridViewTextBoxColumn
            // 
            this.vATDescDataGridViewTextBoxColumn.DataPropertyName = "VATDesc";
            this.vATDescDataGridViewTextBoxColumn.HeaderText = "Áfa ";
            this.vATDescDataGridViewTextBoxColumn.Name = "vATDescDataGridViewTextBoxColumn";
            this.vATDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percentageDataGridViewTextBoxColumn
            // 
            this.percentageDataGridViewTextBoxColumn.DataPropertyName = "Percentage";
            this.percentageDataGridViewTextBoxColumn.HeaderText = "Áfa %";
            this.percentageDataGridViewTextBoxColumn.Name = "percentageDataGridViewTextBoxColumn";
            this.percentageDataGridViewTextBoxColumn.ReadOnly = true;
            this.percentageDataGridViewTextBoxColumn.Width = 50;
            // 
            // tranzakcioSzamDataGridViewTextBoxColumn
            // 
            this.tranzakcioSzamDataGridViewTextBoxColumn.DataPropertyName = "TranzakcioSzam";
            this.tranzakcioSzamDataGridViewTextBoxColumn.HeaderText = "CetLee";
            this.tranzakcioSzamDataGridViewTextBoxColumn.Name = "tranzakcioSzamDataGridViewTextBoxColumn";
            this.tranzakcioSzamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statuszDataGridViewTextBoxColumn
            // 
            this.statuszDataGridViewTextBoxColumn.DataPropertyName = "Statusz";
            this.statuszDataGridViewTextBoxColumn.HeaderText = "Státusz";
            this.statuszDataGridViewTextBoxColumn.Name = "statuszDataGridViewTextBoxColumn";
            this.statuszDataGridViewTextBoxColumn.ReadOnly = true;
            this.statuszDataGridViewTextBoxColumn.Width = 50;
            // 
            // elteresODataGridViewTextBoxColumn
            // 
            this.elteresODataGridViewTextBoxColumn.DataPropertyName = "Elteres_O";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.elteresODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.elteresODataGridViewTextBoxColumn.HeaderText = "Eltérés Összeg";
            this.elteresODataGridViewTextBoxColumn.Name = "elteresODataGridViewTextBoxColumn";
            this.elteresODataGridViewTextBoxColumn.ReadOnly = true;
            this.elteresODataGridViewTextBoxColumn.Width = 80;
            // 
            // elteresSzDataGridViewTextBoxColumn
            // 
            this.elteresSzDataGridViewTextBoxColumn.DataPropertyName = "Elteres_Sz";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.elteresSzDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.elteresSzDataGridViewTextBoxColumn.HeaderText = "Eltérés %";
            this.elteresSzDataGridViewTextBoxColumn.Name = "elteresSzDataGridViewTextBoxColumn";
            this.elteresSzDataGridViewTextBoxColumn.ReadOnly = true;
            this.elteresSzDataGridViewTextBoxColumn.Width = 80;
            // 
            // Számlák
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Számlák";
            this.Text = "Számlák";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Számlák_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szamlak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFPL030300PurchaseLedgerBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Szamlak szamlak;
        private System.Windows.Forms.BindingSource vFPL030300PurchaseLedgerBindingSource;
        private SzamlakTableAdapters.VF_PL030300_PurchaseLedgerTableAdapter vF_PL030300_PurchaseLedgerTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRefNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDate1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookenrDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invAmoLocCurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invAmoOriCurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTermsCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vATDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranzakcioSzamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuszDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elteresODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elteresSzDataGridViewTextBoxColumn;
    }
}