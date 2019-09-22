using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_1_Toplama_Ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void EkranHazirla()
        {
            txtBirinciSayi.Text = "0";
            txtIkinciSayi.Text = "0";
            txtBirinciSayi.Focus();

        }

        Boolean Dogrula()
        {

            try
            {
                Convert.ToDouble(txtBirinciSayi.Text);
                Convert.ToDouble(txtIkinciSayi.Text);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        double Topla(double sayi1, double sayi2)
        {
            return (sayi1 + sayi2);
        }
        private void BtnTopla_Click(object sender, EventArgs e)
        {



            if (Dogrula())
            {
            double birinciSayi, ikinciSayi, toplam;

            birinciSayi = Convert.ToDouble(txtBirinciSayi.Text);
            ikinciSayi = Convert.ToDouble(txtIkinciSayi.Text);

            toplam = Topla(birinciSayi, ikinciSayi);

            MessageBox.Show(Convert.ToString("Sonucunuz: " + toplam));

            }
            else
            {
                MessageBox.Show("Girdiğiniz Değer Hatalı! Lütfen Tekrar Deneyiniz");
            }
                
                



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EkranHazirla();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            EkranHazirla();
        }
    }
}
