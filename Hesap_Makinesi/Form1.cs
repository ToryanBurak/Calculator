using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {

        public double? sayi1, sayi2,sonuc;
        bool islem=false;
            
        
            private void bir_button_Click(object sender, EventArgs e)
            {
            
            sonuc_label.Text += "1";
            
            }

            private void iki_button_Click(object sender, EventArgs e)
            {
            
            sonuc_label.Text += "2";
            }

            private void uc_button_Click(object sender, EventArgs e)
            {
            
            sonuc_label.Text += "3";
            }

            private void dort_button_Click(object sender, EventArgs e)
            {
            
            sonuc_label.Text += "4";
            }

            private void bes_button_Click(object sender, EventArgs e)
            {
            
            sonuc_label.Text += "5";
            }

            private void alti_button_Click(object sender, EventArgs e)
            {
            
            sonuc_label.Text += "6";
            }

            private void yedi_button_Click(object sender, EventArgs e)
            {
            
            sonuc_label.Text += "7";
            }

            private void sekiz_button_Click(object sender, EventArgs e)
            {
            
            sonuc_label.Text += "8";
            }

            private void dokuz_button_Click(object sender, EventArgs e)
            {
            
            sonuc_label.Text += "9";
            }

            private void sifir_button_Click(object sender, EventArgs e)
            {
            
            sonuc_label.Text += "0";
            }

        private void carpim_button_Click(object sender, EventArgs e)
        {
            if (islem == true)
            {
                sifirla();
                sonuc_label.Text = Convert.ToString(sonuc);               
            }
            else if (sonuc_label.Text == "")
            {
                MessageBox.Show("Bir değer Giriniz!");
                goto gidis;
            }
            sayi1 = Convert.ToDouble(sonuc_label.Text);
            isaret_label.Text = "X";
            sayi1_label.Text = sonuc_label.Text;
            sonuc_label.Text = null;
            inaktif();
            
            islem =false;
        gidis: return;

        }
        private void bolum_button_Click(object sender, EventArgs e)
        {
            if (islem == true)
            {
                sifirla();
                sonuc_label.Text = Convert.ToString(sonuc);
            }
            else if (sonuc_label.Text == "")
            {
                MessageBox.Show("Bir değer Giriniz!");
                goto gidis;
            }
            sayi1 = Convert.ToDouble(sonuc_label.Text);
            isaret_label.Text = "%";
            sayi1_label.Text = sonuc_label.Text;
            sonuc_label.Text = "\0";
            inaktif();
            
            islem =false;
        gidis: return;
        }

        private void toplam_button_Click(object sender, EventArgs e)
        {
            if (islem == true)
            {
                sifirla();
                sonuc_label.Text = Convert.ToString(sonuc);
            }
           else if (sonuc_label.Text== "")
            {
                sonuc_label.Text = "+";
                goto gidis;
            }
            sayi1 = Convert.ToDouble(sonuc_label.Text);
            isaret_label.Text = "+";
            sayi1_label.Text = sonuc_label.Text;
            sonuc_label.Text = "\0";
            islem=false;
            
            inaktif();
        gidis: return;


        }
        
        private void sifirla()
        {
            bolum_button.Enabled = true;
            carpim_button.Enabled = true;
            toplam_button.Enabled = true;
            cikarma_button.Enabled = true;
            sayi1_label.Text = "";
            sayi2_label.Text = "";
            sayi1 = null;
            sayi2 = null;
            isaret_label.Text = "";
            sonuc_label.Text = "";
            
        }
        private void sifirlama_button_Click(object sender, EventArgs e)
        {
            
            sifirla();
            sonuc = 0;
        }
        
        private void sonuc_button_Click(object sender, EventArgs e)
        {
            if (sonuc_label.Text == "")
            {
                MessageBox.Show("Bir değer Giriniz!");
                goto gidis;
            }
            else if (islem == true)
            {
                MessageBox.Show("işlem zaten yapıldı!");
                goto gidis;
            }
            if (sayi1_label.Text == "")
            {
                MessageBox.Show("Değerleri Eksik Girdiniz!");
                goto gidis;
            }
            AcceptButton = sonuc_button;
            sayi2_label.Text = sonuc_label.Text;
            sayi2 = Convert.ToDouble(sonuc_label.Text);
            sonuc_label.Text = "\0";
            if (isaret_label.Text == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (isaret_label.Text == "-")
            {
                sonuc=sayi1 - sayi2;
            }
            else if (isaret_label.Text == "X")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (isaret_label.Text == "%")
            {
                sonuc = sayi1 / sayi2;
            }
            
            sonuc_label.Text =("= "+ Convert.ToString(sonuc));
            aktif();
            sayi1=null;
            islem=true;
        gidis: return;
        }

        private void cikarma_button_Click(object sender, EventArgs e)
        {
            if (islem == true)
            {
                sifirla();
                sonuc_label.Text = Convert.ToString(sonuc);
            }
            else if (sonuc_label.Text == "")
            {
                sonuc_label.Text = "-";
                goto gidis;
            }
            sayi1 = Convert.ToDouble(sonuc_label.Text);
            isaret_label.Text = "-";
            sayi1_label.Text = sonuc_label.Text;
            sonuc_label.Text = "\0";
            
            inaktif();
            islem = false;
        gidis: return;
      
        }
        private void inaktif()
        {
            carpim_button.Enabled = false;
            bolum_button.Enabled = false;
            cikarma_button.Enabled = false;
            toplam_button.Enabled = false;
        }
        private void aktif()
        {
            carpim_button.Enabled = true;
            bolum_button.Enabled = true;
            cikarma_button.Enabled = true;
            toplam_button.Enabled=true;
        }


        public Form1()
        {
            InitializeComponent();
            
            

        }

    }
}
