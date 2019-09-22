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

        double Topla(double sayi1, double sayi2)
        {
            return (sayi1 + sayi2);
        }
        private void BtnTopla_Click(object sender, EventArgs e)
        {
            double birinciSayi, ikinciSayi, toplam;

            birinciSayi = Convert.ToDouble(txtBirinciSayi.Text);
            ikinciSayi = Convert.ToDouble(txtIkinciSayi.Text);

            toplam = Topla(birinciSayi, ikinciSayi);

            MessageBox.Show(Convert.ToString("Sonucunuz: " + toplam));



        }
    }
}
