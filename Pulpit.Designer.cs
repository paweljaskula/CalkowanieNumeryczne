namespace WindowsFormsAppCalkowanieNumeryczne
{
    partial class Pulpit
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
            this.stWiellomianu = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelLiczbaPrzedzialow = new System.Windows.Forms.Label();
            this.btnZmienLiczbePrzedzialow = new System.Windows.Forms.Button();
            this.btnWykres = new System.Windows.Forms.Button();
            this.rbMetodaProstokatow = new System.Windows.Forms.RadioButton();
            this.rbMetodaTrapezow = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbMetodaAnalityczna = new System.Windows.Forms.RadioButton();
            this.gbMetodyObliczania = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFunkcjaPierwotna = new System.Windows.Forms.Button();
            this.lblMetoda = new System.Windows.Forms.Label();
            this.lblLiczbaPrzedzialow = new System.Windows.Forms.Label();
            this.lblWartoscCalki = new System.Windows.Forms.Label();
            this.lblWartoscAnalityczna = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stWiellomianu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbMetodyObliczania.SuspendLayout();
            this.SuspendLayout();
            // 
            // stWiellomianu
            // 
            this.stWiellomianu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stWiellomianu.Location = new System.Drawing.Point(213, 133);
            this.stWiellomianu.Margin = new System.Windows.Forms.Padding(2);
            this.stWiellomianu.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stWiellomianu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stWiellomianu.Name = "stWiellomianu";
            this.stWiellomianu.Size = new System.Drawing.Size(57, 26);
            this.stWiellomianu.TabIndex = 0;
            this.stWiellomianu.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.stWiellomianu.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 295);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(581, 261);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnOblicz
            // 
            this.btnOblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOblicz.Location = new System.Drawing.Point(12, 254);
            this.btnOblicz.Margin = new System.Windows.Forms.Padding(2);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(109, 32);
            this.btnOblicz.TabIndex = 4;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "a =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(141, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "b =";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxA.Location = new System.Drawing.Point(55, 216);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(68, 26);
            this.textBoxA.TabIndex = 7;
            this.textBoxA.Text = "0";
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxB.Location = new System.Drawing.Point(176, 216);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(68, 26);
            this.textBoxB.TabIndex = 8;
            this.textBoxB.Text = "10";
            // 
            // labelLiczbaPrzedzialow
            // 
            this.labelLiczbaPrzedzialow.AutoSize = true;
            this.labelLiczbaPrzedzialow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLiczbaPrzedzialow.ForeColor = System.Drawing.Color.Red;
            this.labelLiczbaPrzedzialow.Location = new System.Drawing.Point(160, 31);
            this.labelLiczbaPrzedzialow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLiczbaPrzedzialow.Name = "labelLiczbaPrzedzialow";
            this.labelLiczbaPrzedzialow.Size = new System.Drawing.Size(30, 24);
            this.labelLiczbaPrzedzialow.TabIndex = 9;
            this.labelLiczbaPrzedzialow.Text = "10";
            // 
            // btnZmienLiczbePrzedzialow
            // 
            this.btnZmienLiczbePrzedzialow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZmienLiczbePrzedzialow.Location = new System.Drawing.Point(228, 30);
            this.btnZmienLiczbePrzedzialow.Margin = new System.Windows.Forms.Padding(2);
            this.btnZmienLiczbePrzedzialow.Name = "btnZmienLiczbePrzedzialow";
            this.btnZmienLiczbePrzedzialow.Size = new System.Drawing.Size(90, 28);
            this.btnZmienLiczbePrzedzialow.TabIndex = 10;
            this.btnZmienLiczbePrzedzialow.Text = "Zmień";
            this.btnZmienLiczbePrzedzialow.UseVisualStyleBackColor = true;
            this.btnZmienLiczbePrzedzialow.Click += new System.EventHandler(this.btnZmienLiczbePrzedzialow_Click);
            // 
            // btnWykres
            // 
            this.btnWykres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWykres.Location = new System.Drawing.Point(139, 254);
            this.btnWykres.Margin = new System.Windows.Forms.Padding(2);
            this.btnWykres.Name = "btnWykres";
            this.btnWykres.Size = new System.Drawing.Size(119, 32);
            this.btnWykres.TabIndex = 11;
            this.btnWykres.Text = "Wykres";
            this.btnWykres.UseVisualStyleBackColor = true;
            this.btnWykres.Click += new System.EventHandler(this.btnWykres_Click);
            // 
            // rbMetodaProstokatow
            // 
            this.rbMetodaProstokatow.AutoSize = true;
            this.rbMetodaProstokatow.Location = new System.Drawing.Point(6, 42);
            this.rbMetodaProstokatow.Name = "rbMetodaProstokatow";
            this.rbMetodaProstokatow.Size = new System.Drawing.Size(171, 21);
            this.rbMetodaProstokatow.TabIndex = 12;
            this.rbMetodaProstokatow.TabStop = true;
            this.rbMetodaProstokatow.Text = "Metoda prostokatów";
            this.rbMetodaProstokatow.UseVisualStyleBackColor = true;
            // 
            // rbMetodaTrapezow
            // 
            this.rbMetodaTrapezow.AutoSize = true;
            this.rbMetodaTrapezow.Location = new System.Drawing.Point(6, 65);
            this.rbMetodaTrapezow.Name = "rbMetodaTrapezow";
            this.rbMetodaTrapezow.Size = new System.Drawing.Size(149, 21);
            this.rbMetodaTrapezow.TabIndex = 13;
            this.rbMetodaTrapezow.TabStop = true;
            this.rbMetodaTrapezow.Text = "Metoda trapezów";
            this.rbMetodaTrapezow.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rbMetodaAnalityczna
            // 
            this.rbMetodaAnalityczna.AutoSize = true;
            this.rbMetodaAnalityczna.Location = new System.Drawing.Point(6, 88);
            this.rbMetodaAnalityczna.Name = "rbMetodaAnalityczna";
            this.rbMetodaAnalityczna.Size = new System.Drawing.Size(168, 21);
            this.rbMetodaAnalityczna.TabIndex = 14;
            this.rbMetodaAnalityczna.TabStop = true;
            this.rbMetodaAnalityczna.Text = "Całka - analitycznie";
            this.rbMetodaAnalityczna.UseVisualStyleBackColor = true;
            this.rbMetodaAnalityczna.CheckedChanged += new System.EventHandler(this.rbMetodaAnalityczna_CheckedChanged);
            // 
            // gbMetodyObliczania
            // 
            this.gbMetodyObliczania.Controls.Add(this.rbMetodaAnalityczna);
            this.gbMetodyObliczania.Controls.Add(this.rbMetodaProstokatow);
            this.gbMetodyObliczania.Controls.Add(this.rbMetodaTrapezow);
            this.gbMetodyObliczania.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbMetodyObliczania.Location = new System.Drawing.Point(392, 148);
            this.gbMetodyObliczania.Name = "gbMetodyObliczania";
            this.gbMetodyObliczania.Size = new System.Drawing.Size(200, 139);
            this.gbMetodyObliczania.TabIndex = 15;
            this.gbMetodyObliczania.TabStop = false;
            this.gbMetodyObliczania.Text = "Metody obliczania całki";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(51, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Przedział całkowania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(62, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Stopień wielomianu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Liczba przedziałów";
            // 
            // btnFunkcjaPierwotna
            // 
            this.btnFunkcjaPierwotna.AutoSize = true;
            this.btnFunkcjaPierwotna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFunkcjaPierwotna.Location = new System.Drawing.Point(284, 236);
            this.btnFunkcjaPierwotna.Margin = new System.Windows.Forms.Padding(2);
            this.btnFunkcjaPierwotna.Name = "btnFunkcjaPierwotna";
            this.btnFunkcjaPierwotna.Size = new System.Drawing.Size(90, 50);
            this.btnFunkcjaPierwotna.TabIndex = 19;
            this.btnFunkcjaPierwotna.Text = "Funkcja \r\nPierwotna\r\n";
            this.btnFunkcjaPierwotna.UseVisualStyleBackColor = true;
            this.btnFunkcjaPierwotna.Click += new System.EventHandler(this.btnFunkcjaPierwotna_Click);
            // 
            // lblMetoda
            // 
            this.lblMetoda.AutoSize = true;
            this.lblMetoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMetoda.Location = new System.Drawing.Point(522, 22);
            this.lblMetoda.Name = "lblMetoda";
            this.lblMetoda.Size = new System.Drawing.Size(0, 17);
            this.lblMetoda.TabIndex = 20;
            // 
            // lblLiczbaPrzedzialow
            // 
            this.lblLiczbaPrzedzialow.AutoSize = true;
            this.lblLiczbaPrzedzialow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLiczbaPrzedzialow.Location = new System.Drawing.Point(522, 47);
            this.lblLiczbaPrzedzialow.Name = "lblLiczbaPrzedzialow";
            this.lblLiczbaPrzedzialow.Size = new System.Drawing.Size(0, 17);
            this.lblLiczbaPrzedzialow.TabIndex = 21;
            // 
            // lblWartoscCalki
            // 
            this.lblWartoscCalki.AutoSize = true;
            this.lblWartoscCalki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWartoscCalki.Location = new System.Drawing.Point(522, 73);
            this.lblWartoscCalki.Name = "lblWartoscCalki";
            this.lblWartoscCalki.Size = new System.Drawing.Size(0, 17);
            this.lblWartoscCalki.TabIndex = 22;
            // 
            // lblWartoscAnalityczna
            // 
            this.lblWartoscAnalityczna.AutoSize = true;
            this.lblWartoscAnalityczna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWartoscAnalityczna.Location = new System.Drawing.Point(522, 117);
            this.lblWartoscAnalityczna.Name = "lblWartoscAnalityczna";
            this.lblWartoscAnalityczna.Size = new System.Drawing.Size(0, 17);
            this.lblWartoscAnalityczna.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(395, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Metoda obliczenia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(395, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Liczba przedziałów";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(395, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Wartość całki";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(395, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 34);
            this.label9.TabIndex = 27;
            this.label9.Text = "Wartość całki\r\nanalitycznie   ";
            // 
            // Pulpit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 571);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblWartoscAnalityczna);
            this.Controls.Add(this.lblWartoscCalki);
            this.Controls.Add(this.lblLiczbaPrzedzialow);
            this.Controls.Add(this.lblMetoda);
            this.Controls.Add(this.btnFunkcjaPierwotna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbMetodyObliczania);
            this.Controls.Add(this.btnWykres);
            this.Controls.Add(this.btnZmienLiczbePrzedzialow);
            this.Controls.Add(this.labelLiczbaPrzedzialow);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stWiellomianu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pulpit";
            this.Text = "Obliczanie całki";
            this.Load += new System.EventHandler(this.Pulpit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stWiellomianu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbMetodyObliczania.ResumeLayout(false);
            this.gbMetodyObliczania.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown stWiellomianu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelLiczbaPrzedzialow;
        private System.Windows.Forms.Button btnZmienLiczbePrzedzialow;
        private System.Windows.Forms.Button btnWykres;
        private System.Windows.Forms.RadioButton rbMetodaProstokatow;
        private System.Windows.Forms.RadioButton rbMetodaTrapezow;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbMetodyObliczania;
        private System.Windows.Forms.RadioButton rbMetodaAnalityczna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFunkcjaPierwotna;
        private System.Windows.Forms.Label lblWartoscAnalityczna;
        private System.Windows.Forms.Label lblWartoscCalki;
        private System.Windows.Forms.Label lblLiczbaPrzedzialow;
        private System.Windows.Forms.Label lblMetoda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

