namespace WindowsFormsAppCalkowanieNumeryczne
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelWartoscAnalityczna = new System.Windows.Forms.Label();
            this.lblWartoscCalki = new System.Windows.Forms.Label();
            this.lblLiczbaPrzedzialow = new System.Windows.Forms.Label();
            this.lblMetoda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(42, 169);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(625, 312);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(72, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 34);
            this.label9.TabIndex = 35;
            this.label9.Text = "Wartość całki\r\nanalitycznie   ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(72, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Wartość całki";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(72, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Liczba przedziałów";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(72, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Metoda obliczenia:";
            // 
            // labelWartoscAnalityczna
            // 
            this.labelWartoscAnalityczna.AutoSize = true;
            this.labelWartoscAnalityczna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWartoscAnalityczna.Location = new System.Drawing.Point(215, 127);
            this.labelWartoscAnalityczna.Name = "labelWartoscAnalityczna";
            this.labelWartoscAnalityczna.Size = new System.Drawing.Size(0, 17);
            this.labelWartoscAnalityczna.TabIndex = 31;
            // 
            // lblWartoscCalki
            // 
            this.lblWartoscCalki.AutoSize = true;
            this.lblWartoscCalki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWartoscCalki.Location = new System.Drawing.Point(215, 83);
            this.lblWartoscCalki.Name = "lblWartoscCalki";
            this.lblWartoscCalki.Size = new System.Drawing.Size(0, 17);
            this.lblWartoscCalki.TabIndex = 30;
            // 
            // lblLiczbaPrzedzialow
            // 
            this.lblLiczbaPrzedzialow.AutoSize = true;
            this.lblLiczbaPrzedzialow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLiczbaPrzedzialow.Location = new System.Drawing.Point(215, 57);
            this.lblLiczbaPrzedzialow.Name = "lblLiczbaPrzedzialow";
            this.lblLiczbaPrzedzialow.Size = new System.Drawing.Size(0, 17);
            this.lblLiczbaPrzedzialow.TabIndex = 29;
            // 
            // lblMetoda
            // 
            this.lblMetoda.AutoSize = true;
            this.lblMetoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMetoda.Location = new System.Drawing.Point(215, 32);
            this.lblMetoda.Name = "lblMetoda";
            this.lblMetoda.Size = new System.Drawing.Size(0, 17);
            this.lblMetoda.TabIndex = 28;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 514);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelWartoscAnalityczna);
            this.Controls.Add(this.lblWartoscCalki);
            this.Controls.Add(this.lblLiczbaPrzedzialow);
            this.Controls.Add(this.lblMetoda);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Wykres ";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label labelWartoscAnalityczna;
        public System.Windows.Forms.Label lblWartoscCalki;
        public System.Windows.Forms.Label lblLiczbaPrzedzialow;
        public System.Windows.Forms.Label lblMetoda;
    }
}