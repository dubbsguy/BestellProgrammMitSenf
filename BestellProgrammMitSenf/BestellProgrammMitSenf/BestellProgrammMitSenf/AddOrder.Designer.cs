namespace BestellProgrammMitSenf
{
    partial class AddOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kundenNrTxtBox = new System.Windows.Forms.TextBox();
            this.zahlungsartNrTxtBox = new System.Windows.Forms.TextBox();
            this.lieferadressNrTxtBox = new System.Windows.Forms.TextBox();
            this.AbortBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bestellung hinzufügen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "KundenNr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ZahlungsartNr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, -16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "LieferadressNr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "LieferadressNr";
            // 
            // kundenNrTxtBox
            // 
            this.kundenNrTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kundenNrTxtBox.Location = new System.Drawing.Point(19, 115);
            this.kundenNrTxtBox.Multiline = true;
            this.kundenNrTxtBox.Name = "kundenNrTxtBox";
            this.kundenNrTxtBox.Size = new System.Drawing.Size(266, 38);
            this.kundenNrTxtBox.TabIndex = 13;
            // 
            // zahlungsartNrTxtBox
            // 
            this.zahlungsartNrTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zahlungsartNrTxtBox.Location = new System.Drawing.Point(19, 191);
            this.zahlungsartNrTxtBox.Multiline = true;
            this.zahlungsartNrTxtBox.Name = "zahlungsartNrTxtBox";
            this.zahlungsartNrTxtBox.Size = new System.Drawing.Size(266, 38);
            this.zahlungsartNrTxtBox.TabIndex = 14;
            // 
            // lieferadressNrTxtBox
            // 
            this.lieferadressNrTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lieferadressNrTxtBox.Location = new System.Drawing.Point(349, 115);
            this.lieferadressNrTxtBox.Multiline = true;
            this.lieferadressNrTxtBox.Name = "lieferadressNrTxtBox";
            this.lieferadressNrTxtBox.Size = new System.Drawing.Size(266, 38);
            this.lieferadressNrTxtBox.TabIndex = 15;
            // 
            // AbortBtn
            // 
            this.AbortBtn.BackColor = System.Drawing.Color.Transparent;
            this.AbortBtn.BackgroundImage = global::BestellProgrammMitSenf.Properties.Resources.baseline_cancel_black_36dp;
            this.AbortBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AbortBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.AbortBtn.FlatAppearance.BorderSize = 2;
            this.AbortBtn.Location = new System.Drawing.Point(525, 323);
            this.AbortBtn.Name = "AbortBtn";
            this.AbortBtn.Size = new System.Drawing.Size(107, 53);
            this.AbortBtn.TabIndex = 12;
            this.AbortBtn.UseVisualStyleBackColor = false;
            this.AbortBtn.Click += new System.EventHandler(this.AbortBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.BackgroundImage = global::BestellProgrammMitSenf.Properties.Resources.baseline_save_black_36dp;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.Location = new System.Drawing.Point(349, 323);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 53);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Datum";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(349, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(698, 409);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lieferadressNrTxtBox);
            this.Controls.Add(this.zahlungsartNrTxtBox);
            this.Controls.Add(this.kundenNrTxtBox);
            this.Controls.Add(this.AbortBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddOrder";
            this.Text = "Bestellung hinzufügen";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button AbortBtn;
        private System.Windows.Forms.TextBox kundenNrTxtBox;
        private System.Windows.Forms.TextBox zahlungsartNrTxtBox;
        private System.Windows.Forms.TextBox lieferadressNrTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}