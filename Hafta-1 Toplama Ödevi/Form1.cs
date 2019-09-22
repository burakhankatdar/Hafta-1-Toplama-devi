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

        void LogYaz(string Mesaj)
        {
            lvLog.Items.Add(Mesaj);
        }

        

        double Topla(double sayi1, double sayi2)
        {
            return (sayi1 + sayi2);
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
        private void BtnTopla_Click(object sender, EventArgs e)
        {



            if (Dogrula())
            {
            double birinciSayi, ikinciSayi, toplam;

            birinciSayi = Convert.ToDouble(txtBirinciSayi.Text);
            ikinciSayi = Convert.ToDouble(txtIkinciSayi.Text);

            toplam = Topla(birinciSayi, ikinciSayi);

            MessageBox.Show(Convert.ToString("Sonucunuz: " + toplam));
                LogYaz("Sonucunuz: " + toplam);
            }
            else
            {
                MessageBox.Show("Girdiğiniz Değer Hatalı! Lütfen Tekrar Deneyiniz ");
                LogYaz("Hatalı Giriş!");
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

        private void TxtBirinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsLetter(e.KeyChar)
                
                )
                e.Handled = true;
        }

        private void TxtIkinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) 

                )
                e.Handled = true;
        }
    }
}
