namespace BestellProgrammMitSenf
{
    partial class View
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bestellungen = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bESTELLNRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kUNDENNRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zAHLUNGSARTNRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIEFERADRESSNRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bESTELLUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BestellProgrammMitSenf.DataSet1();
            this.Kunden = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kUNDENNRDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESSENRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRMIERUNGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONNUMMERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kUNDEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Finanzen = new System.Windows.Forms.TabPage();
            this.bESTELLUNGTableAdapter = new BestellProgrammMitSenf.DataSet1TableAdapters.BESTELLUNGTableAdapter();
            this.kUNDETableAdapter = new BestellProgrammMitSenf.DataSet1TableAdapters.KUNDETableAdapter();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Bestellungen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bESTELLUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.Kunden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kUNDEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.Bestellungen);
            this.tabControl1.Controls.Add(this.Kunden);
            this.tabControl1.Controls.Add(this.Finanzen);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 459);
            this.tabControl1.TabIndex = 2;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.Control;
            this.Home.Controls.Add(this.label3);
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Cursor = System.Windows.Forms.Cursors.Default;
            this.Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(802, 433);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(507, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "ABS OHG Bestell-Software";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(369, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Bestellungen
            // 
            this.Bestellungen.BackColor = System.Drawing.SystemColors.Control;
            this.Bestellungen.Controls.Add(this.label1);
            this.Bestellungen.Controls.Add(this.button1);
            this.Bestellungen.Controls.Add(this.button2);
            this.Bestellungen.Controls.Add(this.dataGridView1);
            this.Bestellungen.Location = new System.Drawing.Point(4, 22);
            this.Bestellungen.Name = "Bestellungen";
            this.Bestellungen.Padding = new System.Windows.Forms.Padding(3);
            this.Bestellungen.Size = new System.Drawing.Size(802, 433);
            this.Bestellungen.TabIndex = 0;
            this.Bestellungen.Text = "Bestellungen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bestellungen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bestellung hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "Bestellung löschen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bESTELLNRDataGridViewTextBoxColumn,
            this.kUNDENNRDataGridViewTextBoxColumn,
            this.zAHLUNGSARTNRDataGridViewTextBoxColumn,
            this.lIEFERADRESSNRDataGridViewTextBoxColumn,
            this.dATUMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bESTELLUNGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // bESTELLNRDataGridViewTextBoxColumn
            // 
            this.bESTELLNRDataGridViewTextBoxColumn.DataPropertyName = "BESTELLNR";
            this.bESTELLNRDataGridViewTextBoxColumn.HeaderText = "BESTELLNR";
            this.bESTELLNRDataGridViewTextBoxColumn.Name = "bESTELLNRDataGridViewTextBoxColumn";
            // 
            // kUNDENNRDataGridViewTextBoxColumn
            // 
            this.kUNDENNRDataGridViewTextBoxColumn.DataPropertyName = "KUNDENNR";
            this.kUNDENNRDataGridViewTextBoxColumn.HeaderText = "KUNDENNR";
            this.kUNDENNRDataGridViewTextBoxColumn.Name = "kUNDENNRDataGridViewTextBoxColumn";
            // 
            // zAHLUNGSARTNRDataGridViewTextBoxColumn
            // 
            this.zAHLUNGSARTNRDataGridViewTextBoxColumn.DataPropertyName = "ZAHLUNGSARTNR";
            this.zAHLUNGSARTNRDataGridViewTextBoxColumn.HeaderText = "ZAHLUNGSARTNR";
            this.zAHLUNGSARTNRDataGridViewTextBoxColumn.Name = "zAHLUNGSARTNRDataGridViewTextBoxColumn";
            // 
            // lIEFERADRESSNRDataGridViewTextBoxColumn
            // 
            this.lIEFERADRESSNRDataGridViewTextBoxColumn.DataPropertyName = "LIEFERADRESSNR";
            this.lIEFERADRESSNRDataGridViewTextBoxColumn.HeaderText = "LIEFERADRESSNR";
            this.lIEFERADRESSNRDataGridViewTextBoxColumn.Name = "lIEFERADRESSNRDataGridViewTextBoxColumn";
            // 
            // dATUMDataGridViewTextBoxColumn
            // 
            this.dATUMDataGridViewTextBoxColumn.DataPropertyName = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.HeaderText = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.Name = "dATUMDataGridViewTextBoxColumn";
            // 
            // bESTELLUNGBindingSource
            // 
            this.bESTELLUNGBindingSource.DataMember = "BESTELLUNG";
            this.bESTELLUNGBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Kunden
            // 
            this.Kunden.BackColor = System.Drawing.SystemColors.Control;
            this.Kunden.Controls.Add(this.label2);
            this.Kunden.Controls.Add(this.button3);
            this.Kunden.Controls.Add(this.button4);
            this.Kunden.Controls.Add(this.dataGridView2);
            this.Kunden.Location = new System.Drawing.Point(4, 22);
            this.Kunden.Name = "Kunden";
            this.Kunden.Padding = new System.Windows.Forms.Padding(3);
            this.Kunden.Size = new System.Drawing.Size(802, 433);
            this.Kunden.TabIndex = 1;
            this.Kunden.Text = "Kunden";
            this.Kunden.Click += new System.EventHandler(this.Kunden_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kunden";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 53);
            this.button3.TabIndex = 5;
            this.button3.Text = "Kunden hinzufügen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(106, 374);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 53);
            this.button4.TabIndex = 6;
            this.button4.Text = "Kunden löschen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kUNDENNRDataGridViewTextBoxColumn1,
            this.aDRESSENRDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.vORNAMEDataGridViewTextBoxColumn,
            this.fIRMIERUNGDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.tELEFONNUMMERDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.kUNDEBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 313);
            this.dataGridView2.TabIndex = 0;
            // 
            // kUNDENNRDataGridViewTextBoxColumn1
            // 
            this.kUNDENNRDataGridViewTextBoxColumn1.DataPropertyName = "KUNDENNR";
            this.kUNDENNRDataGridViewTextBoxColumn1.HeaderText = "KUNDENNR";
            this.kUNDENNRDataGridViewTextBoxColumn1.Name = "kUNDENNRDataGridViewTextBoxColumn1";
            // 
            // aDRESSENRDataGridViewTextBoxColumn
            // 
            this.aDRESSENRDataGridViewTextBoxColumn.DataPropertyName = "ADRESSENR";
            this.aDRESSENRDataGridViewTextBoxColumn.HeaderText = "ADRESSENR";
            this.aDRESSENRDataGridViewTextBoxColumn.Name = "aDRESSENRDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // vORNAMEDataGridViewTextBoxColumn
            // 
            this.vORNAMEDataGridViewTextBoxColumn.DataPropertyName = "VORNAME";
            this.vORNAMEDataGridViewTextBoxColumn.HeaderText = "VORNAME";
            this.vORNAMEDataGridViewTextBoxColumn.Name = "vORNAMEDataGridViewTextBoxColumn";
            // 
            // fIRMIERUNGDataGridViewTextBoxColumn
            // 
            this.fIRMIERUNGDataGridViewTextBoxColumn.DataPropertyName = "FIRMIERUNG";
            this.fIRMIERUNGDataGridViewTextBoxColumn.HeaderText = "FIRMIERUNG";
            this.fIRMIERUNGDataGridViewTextBoxColumn.Name = "fIRMIERUNGDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // tELEFONNUMMERDataGridViewTextBoxColumn
            // 
            this.tELEFONNUMMERDataGridViewTextBoxColumn.DataPropertyName = "TELEFONNUMMER";
            this.tELEFONNUMMERDataGridViewTextBoxColumn.HeaderText = "TELEFONNUMMER";
            this.tELEFONNUMMERDataGridViewTextBoxColumn.Name = "tELEFONNUMMERDataGridViewTextBoxColumn";
            // 
            // kUNDEBindingSource
            // 
            this.kUNDEBindingSource.DataMember = "KUNDE";
            this.kUNDEBindingSource.DataSource = this.dataSet1;
            // 
            // Finanzen
            // 
            this.Finanzen.BackColor = System.Drawing.SystemColors.Control;
            this.Finanzen.Location = new System.Drawing.Point(4, 22);
            this.Finanzen.Name = "Finanzen";
            this.Finanzen.Size = new System.Drawing.Size(802, 433);
            this.Finanzen.TabIndex = 3;
            this.Finanzen.Text = "Finanzen";
            // 
            // bESTELLUNGTableAdapter
            // 
            this.bESTELLUNGTableAdapter.ClearBeforeFill = true;
            // 
            // kUNDETableAdapter
            // 
            this.kUNDETableAdapter.ClearBeforeFill = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 483);
            this.Controls.Add(this.tabControl1);
            this.Name = "View";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.View_Load);
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Bestellungen.ResumeLayout(false);
            this.Bestellungen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bESTELLUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.Kunden.ResumeLayout(false);
            this.Kunden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kUNDEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Bestellungen;
        private System.Windows.Forms.TabPage Kunden;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bESTELLUNGBindingSource;
        private DataSet1TableAdapters.BESTELLUNGTableAdapter bESTELLUNGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bESTELLNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kUNDENNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zAHLUNGSARTNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIEFERADRESSNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource kUNDEBindingSource;
        private DataSet1TableAdapters.KUNDETableAdapter kUNDETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kUNDENNRDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSENRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRMIERUNGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONNUMMERDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage Finanzen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

