using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyonuUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            // Doğru dosya yolunu ayarlama
            string dosyaYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt");

            // Dosya mevcutsa işlem yap
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);
                bool girisBasarili = satirlar.Any(satir =>
                {
                    var parcalar = satir.Split(',');
                    return parcalar[0].Trim() == kullaniciAdi && parcalar[1].Trim() == sifre;
                });

                if (girisBasarili)
                {
                    MessageBox.Show("Giriş başarılı!");
                    // Ana formu aç
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                }
            }
            else
            {
                MessageBox.Show("users.txt dosyası bulunamadı.");
            }
        }

    }
}
