using EmlakLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace EmlakOtomasyonuUI
{
    public partial class SorgulamaForm : Form
    {
        private MainForm _mainForm;

        public SorgulamaForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // Filtre kriterlerini alalım
            string odaSayisi = txtOdaSayisi.Text;
            string minAlan = textBoxMinAlan.Text;
            string maxAlan = textBoxMaxAlan.Text;
            string semt = txtSemt.Text;
            string minFiyat = textBoxMinFiyat.Text;
            string maxFiyat = textBoxMaxFiyat.Text;

            // Filtreleme yapılacak listeyi alalım
            var filteredEvler = EmlakYonetimi.EvListesi.Where(ev =>
                (string.IsNullOrEmpty(odaSayisi) || ev.OdaSayisi == Convert.ToInt32(odaSayisi)) &&  // Oda sayısını sayısal olarak kontrol edelim
                (string.IsNullOrEmpty(minAlan) || ev.Alan >= int.Parse(minAlan)) &&
                (string.IsNullOrEmpty(maxAlan) || ev.Alan <= int.Parse(maxAlan)) &&
                (string.IsNullOrEmpty(semt) || ev.Semt == semt) &&
                (string.IsNullOrEmpty(minFiyat) || ev.Fiyat >= double.Parse(minFiyat)) &&
                (string.IsNullOrEmpty(maxFiyat) || ev.Fiyat <= double.Parse(maxFiyat))
            ).ToList();

            // Listeyi MainForm'da güncelle
            _mainForm.ListeyiGuncelle(filteredEvler);

            // Eğer hiçbir ev bulunmazsa bilgilendirme mesajı göster
            if (filteredEvler.Count == 0)
            {
                MessageBox.Show("Kriterlere uygun ev bulunamadı.");
            }
            else
            {
                MessageBox.Show("Liste güncellenmiştir.");
            }

            this.Close();
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();  // Formu kapat
        }
    }
}
