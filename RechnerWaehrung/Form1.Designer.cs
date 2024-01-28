namespace RechnerWaehrung
{
    partial class Form1
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
            this.rateFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rateTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.calculated = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // rateFrom
            // 
            this.rateFrom.FormattingEnabled = true;
            this.rateFrom.Items.AddRange(new object[] {
            "CHF",
            "USD",
            "JPY",
            "EUR"});
            this.rateFrom.Location = new System.Drawing.Point(298, 48);
            this.rateFrom.Name = "rateFrom";
            this.rateFrom.Size = new System.Drawing.Size(135, 24);
            this.rateFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Betrag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Währung";
            // 
            // rateTo
            // 
            this.rateTo.FormattingEnabled = true;
            this.rateTo.Items.AddRange(new object[] {
            "CHF",
            "USD",
            "JPY",
            "EUR"});
            this.rateTo.Location = new System.Drawing.Point(561, 48);
            this.rateTo.Name = "rateTo";
            this.rateTo.Size = new System.Drawing.Size(121, 24);
            this.rateTo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zielwährung";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(715, 40);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(132, 38);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Umrechnen";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // calculated
            // 
            this.calculated.AutoSize = true;
            this.calculated.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculated.Location = new System.Drawing.Point(31, 101);
            this.calculated.Name = "calculated";
            this.calculated.Size = new System.Drawing.Size(0, 54);
            this.calculated.TabIndex = 7;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(99, 47);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(97, 22);
            this.amount.TabIndex = 8;
            this.amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 195);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.calculated);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rateTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rateFrom);
            this.Name = "Form1";
            this.Text = "Währungsrechner";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox rateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox rateTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label calculated;
        private System.Windows.Forms.NumericUpDown amount;
    }
}

