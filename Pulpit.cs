using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsAppCalkowanieNumeryczne
{
    public partial class Pulpit : Form
    {
        int stopienWielomianu = 2;
        int liczbaPrzedzialow = 10;
        double[,] wyniki; 
        public Pulpit()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 15;
            for (int i = 0; i <= stopienWielomianu; i++)
                dataGridView1.Columns[i].HeaderText = "a" + (stopienWielomianu - i).ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= stopienWielomianu; i++)
                dataGridView1.Columns[i].HeaderText = "";
            stopienWielomianu = Convert.ToInt32(stWiellomianu.Value);
            for (int i = 0; i <= stopienWielomianu; i++)
                dataGridView1.Columns[i].HeaderText = "a" + (stopienWielomianu - i).ToString();
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
          
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double dx = (b - a) / liczbaPrzedzialow;
            int[] tab = new int[stopienWielomianu + 1];
            for (int i = 0; i < tab.Length; i++) 
                tab[i] = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
            wyniki = new double[2, liczbaPrzedzialow];
            double x = a + dx / 2;
            if (rbMetodaProstokatow.Checked == true)
            {
                CalkaProstokat(a, b, tab);
                dataGridView1.Rows.Add(CalkaProstokat(a, b, tab).ToString());
                lblMetoda.Text = "Metoda prostokątów";
                lblLiczbaPrzedzialow.Text = liczbaPrzedzialow.ToString();
                lblWartoscCalki.Text = CalkaProstokat(a, b, tab).ToString();
                lblWartoscAnalityczna.Text = CalkaAnalitycznie(a, b, tab).ToString();
            }
            else if (rbMetodaTrapezow.Checked == true)
            {
                CalkaTrapez(a, b, tab);
                dataGridView1.Rows.Add(CalkaTrapez(a, b, tab).ToString());
                lblMetoda.Text = "Metoda trapezów";
                lblLiczbaPrzedzialow.Text = liczbaPrzedzialow.ToString();
                lblWartoscCalki.Text = CalkaTrapez(a, b, tab).ToString();
                lblWartoscAnalityczna.Text = CalkaAnalitycznie(a, b, tab).ToString();
            }
            else if (rbMetodaAnalityczna.Checked == true)
            {
                CalkaAnalitycznie(a, b, tab);
                dataGridView1.Rows.Add(CalkaAnalitycznie(a, b, tab).ToString());
                lblMetoda.Text = "Metoda analityczna";
                lblLiczbaPrzedzialow.Text = liczbaPrzedzialow.ToString();
                lblWartoscCalki.Text = CalkaAnalitycznie(a, b, tab).ToString();
                lblWartoscAnalityczna.Text = CalkaAnalitycznie(a, b, tab).ToString();
            }
            else
            {
                errorProvider1.SetError(gbMetodyObliczania, "Musisz wybrać jedną z opcji");
            }
            

        }

        private void btnZmienLiczbePrzedzialow_Click(object sender, EventArgs e)
        {
            if (liczbaPrzedzialow == 10) liczbaPrzedzialow = 100;
            else if (liczbaPrzedzialow == 100) liczbaPrzedzialow = 1000;
            else liczbaPrzedzialow = 10;
            labelLiczbaPrzedzialow.Text = liczbaPrzedzialow.ToString();
        }
        
        private void btnWykres_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double dx = (b - a) / liczbaPrzedzialow;
            int[] tab = new int[stopienWielomianu + 1];
            for (int i = 0; i < tab.Length; i++)
                tab[i] = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
            Form2 formWykres = new Form2();
            formWykres.chart1.Series.Clear();
            formWykres.chart1.Series.Add("dx");
            formWykres.chart1.Series[0].ChartType = SeriesChartType.Column;
            formWykres.chart1.Series[0].Color = Color.Green;
            formWykres.chart1.Series.Add("f(x)*dx");
            formWykres.chart1.Series[1].ChartType = SeriesChartType.Line;
            formWykres.chart1.Series[1].BorderWidth = 4;
            formWykres.chart1.Series[1].Color = Color.Red;
            for (int i = 0; i < wyniki.GetLength(1); i++)
            {
                formWykres.chart1.Series[0].Points.AddXY(wyniki[0, i], wyniki[1, i]);
                formWykres.chart1.Series[1].Points.AddXY(wyniki[0, i], wyniki[1, i]);

            }
            if (rbMetodaProstokatow.Checked == true)
            {
                formWykres.lblMetoda.Text = "Metoda prostokątów";
                formWykres.lblLiczbaPrzedzialow.Text = liczbaPrzedzialow.ToString();
                formWykres.lblWartoscCalki.Text = CalkaProstokat(a, b, tab).ToString();
                formWykres.labelWartoscAnalityczna.Text = CalkaAnalitycznie(a, b, tab).ToString();
            }
            else if (rbMetodaTrapezow.Checked == true)
            {
                formWykres.lblMetoda.Text = "Metoda trapezów";
                formWykres.lblLiczbaPrzedzialow.Text = liczbaPrzedzialow.ToString();
                formWykres.lblWartoscCalki.Text = CalkaTrapez(a, b, tab).ToString();
                formWykres.labelWartoscAnalityczna.Text = CalkaAnalitycznie(a, b, tab).ToString();
            }
            else if (rbMetodaAnalityczna.Checked == true)
            {
                formWykres.lblMetoda.Text = "Metoda analityczna";
                formWykres.lblLiczbaPrzedzialow.Text = liczbaPrzedzialow.ToString();
                formWykres.lblWartoscCalki.Text = CalkaAnalitycznie(a, b, tab).ToString();
                formWykres.labelWartoscAnalityczna.Text = CalkaAnalitycznie(a, b, tab).ToString();
            }
            else
            {
                errorProvider1.SetError(gbMetodyObliczania, "Musisz wybrać jedną z opcji");
            }
            formWykres.Show();
            
        }
        private double CalkaProstokat(double a, double b, int[] tab)
        {
            a = Convert.ToDouble(textBoxA.Text);
            b = Convert.ToDouble(textBoxB.Text);
            double dx = (b - a) / liczbaPrzedzialow;
            tab = new int[stopienWielomianu + 1];
            for (int i = 0; i < tab.Length; i++)
                tab[i] = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
            double x = a + dx / 2;
            errorProvider1.Dispose();
            wyniki[0, 0] = x;
            wyniki[1, 0] = Funkcje.wielomian(tab, x);
            double calka = wyniki[1, 0] * dx;
            for (int i = 2; i <= liczbaPrzedzialow; i++)
            {
                x += dx;
                wyniki[0, i - 1] = x;
                wyniki[1, i - 1] = Funkcje.wielomian(tab, x);
                calka += wyniki[1, i - 1] * dx;
            }
            return calka;
        }
        private double CalkaAnalitycznie(double a, double b, int[] tab)
        {
            a = Convert.ToDouble(textBoxA.Text);
            b = Convert.ToDouble(textBoxB.Text);
            double[] TabPom = new double[Convert.ToInt32(stWiellomianu.Value) + 1];
            TabPom = FunkcjaPierwotna(tab);
            int stopien = Convert.ToInt32(stWiellomianu.Value) + 1;
            double calka, calka1 = 0, calka2 = 0;
            for (int i = 0; i < TabPom.Length; i++)
            {
                
                calka2 += TabPom[i] * Math.Pow(b, stopien);
                stopien--;
            }
            stopien = Convert.ToInt32(stWiellomianu.Value) + 1;
            for (int i = 0; i < TabPom.Length; i++)
            {
                calka1 += TabPom[i] * Math.Pow(a, stopien);
                stopien--;
            }
            calka = calka2 - calka1;
            return calka;
        }
        //private double CalkaTrapez(double a, double b, int[] tab)
        //{
        //    a = Convert.ToDouble(textBoxA.Text);
        //    b = Convert.ToDouble(textBoxB.Text);
        //    double dx = (b - a) / liczbaPrzedzialow;
        //    tab = new int[stopienWielomianu + 1];
        //    for (int i = 0; i < tab.Length; i++)
        //        tab[i] = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
        //    double x = a + dx / 2;
        //    errorProvider1.Dispose();
        //    wyniki[0, 0] = a;
        //    wyniki[1, 0] = Funkcje.wielomian(tab, a);
        //    wyniki[1, 1] = Funkcje.wielomian(tab, a + dx);
        //    double calka = (wyniki[1, 0] + wyniki[1, 1]) * dx / 2;
        //    for (int i = 2; i <= liczbaPrzedzialow; i++)
        //    {
        //        x += dx;
        //        wyniki[0, i - 1] = x;
        //        wyniki[1, i - 2] = Funkcje.wielomian(tab, x - dx);
        //        wyniki[1, i - 1] = Funkcje.wielomian(tab, x + dx);
        //        calka += ((wyniki[1, i - 2] + wyniki[1, i - 1]) / 2) * dx;

        //    }
        //    return calka;
        //}
        private double CalkaTrapez(double a, double b, int[] tab)
        {
            a = Convert.ToDouble(textBoxA.Text);
            b = Convert.ToDouble(textBoxB.Text);
            double dx;

            dx = (b - a) / liczbaPrzedzialow;
            tab = new int[stopienWielomianu + 1];
            for (int i = 0; i < tab.Length; i++)
                tab[i] = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
            double x = a + dx / 2;
            errorProvider1.Dispose();
            double calka = 0;

            wyniki[0, 0] = a;
            wyniki[1, 0] = Funkcje.wielomian(tab, a);
            wyniki[1, 1] = Funkcje.wielomian(tab, a + dx);
            for (int i = 2; i <= liczbaPrzedzialow; i++)
            {
                x += dx;
                wyniki[0, i - 1] = x;

                wyniki[1, i - 1] = Funkcje.wielomian(tab, x + dx);

            }

            for (int i = 1; i < liczbaPrzedzialow; i++)
            {
                calka += Funkcje.wielomian(tab, a + i * dx);

            }
            
            calka += (Funkcje.wielomian(tab,a) + Funkcje.wielomian(tab,b)) / 2;
            calka *= dx;

            return calka;
        }

        private double[] FunkcjaPierwotna(int[] tab)// metoda ktora zwraca funkcje pierwotna calki
        {
            double[] TabWynik = new double[Convert.ToInt32(stWiellomianu.Value)+1];
            int stopien = Convert.ToInt32(stWiellomianu.Value)+1;
            for (int i = 0; i < TabWynik.Length; i++)
                tab[i] = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
            for (int i = 0; i < TabWynik.Length; i++)
            {
                if (i == TabWynik.Length-1)
                {
                    if (tab[i] == 0)
                    {
                        TabWynik[i] = 0;
                    }
                    else
                        TabWynik[i] = tab[i];
                }
                else if (tab[i] == 0)
                {
                    TabWynik[i] = 0;
                }
                else
                    TabWynik[i] = (double)tab[i] / stopien;
                stopien--;
            }
            return TabWynik;
        }
        private string[] FunkcjaPierwotnaSTR(int[] tab)// metoda ktora zwraca funkcje pierwotna calki
        {
            string[] TabWynik = new string[Convert.ToInt32(stWiellomianu.Value) + 1];
            int stopien = Convert.ToInt32(stWiellomianu.Value) + 1;
            for (int i = 0; i < TabWynik.Length; i++)
                tab[i] = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
            for (int i = 0; i < TabWynik.Length; i++)
            {
                if (i == TabWynik.Length - 1)
                {
                    if (tab[i] == 0)
                    {
                        TabWynik[i] = "";
                    }
                    else
                        TabWynik[i] = tab[i].ToString();
                }
                else if (tab[i] == 0)
                {
                    TabWynik[i] = "";
                }
                else
                    TabWynik[i] = tab[i] +"/" +stopien;
                stopien--;
            }
            return TabWynik;
        }

        private void rbMetodaAnalityczna_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnFunkcjaPierwotna_Click(object sender, EventArgs e)
        {
            int[] tabliczka = new int[Convert.ToInt32(stWiellomianu.Value) + 1];
            string[] tab2 = new string[Convert.ToInt32(stWiellomianu.Value) + 1];
            tab2 = FunkcjaPierwotnaSTR(tabliczka);
            int stopien = Convert.ToInt32(stWiellomianu.Value) + 1;
            for (int i = 0; i < tabliczka.Length; i++)
            {
                if (tab2[i] == "")
                {
                    dataGridView1.Rows[1].Cells[i].Value = "";
                }
                else
                    dataGridView1.Rows[1].Cells[i].Value = tab2[i] + " * X^"+stopien;
                stopien--; 
            }
            
        }
        

        private void Pulpit_Load(object sender, EventArgs e)
        {

        }
    }
}
