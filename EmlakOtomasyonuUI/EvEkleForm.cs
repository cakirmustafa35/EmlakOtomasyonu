using System;
using System.IO;
using System.Windows.Forms;
using EmlakLib;
using static EmlakOtomasyonuUI.MainForm;

namespace EmlakOtomasyonuUI
{
    public partial class EvEkleForm : Form
    {
        public EvEkleForm()
        {
            InitializeComponent();
        }

        private void EvEkleForm_Load(object sender, EventArgs e)
        {
            // Semt ve Emlak Türü seçeneklerini combo box'a ekleme
            cmbSemt.Items.Add("İstanbul");
            cmbSemt.Items.Add("Ankara");
            cmbSemt.Items.Add("İzmir");

            cmbTur.Items.Add("Kiralık");
            cmbTur.Items.Add("Satılık");

            cmbEmlakTur.Items.Add("Daire");
            cmbEmlakTur.Items.Add("Müstakil");
            cmbEmlakTur.Items.Add("Dubleks");
            cmbEmlakTur.Items.Add("Bahçeli");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan veriler
            double alan = Convert.ToDouble(txtAlan.Text);
            int odaSayisi = Convert.ToInt32(txtOdaSayisi.Text);
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            int katNumarasi = Convert.ToInt32(txtKatNumarasi.Text);
            string semt = cmbSemt.SelectedItem.ToString();
            string emlakTur = cmbEmlakTur.SelectedItem.ToString();
            string tur = cmbTur.SelectedItem.ToString();
            DateTime yapimTarihi = dateYapimTarihi.Value;
            bool aktifMi = chkAktif.Checked;
            int emlakNumarasi = new Random().Next(1000, 9999); // Benzersiz numara

            // Yeni bir Ev nesnesi oluşturuluyor
            Ev yeniEv;

            if (tur == "Kiralık")  // Bu kısmı doğru kontrol etmek için 'tur' değil, 'emlakTur' kullanılmalı
            {
                double aylikKira = Convert.ToDouble(txtFiyat.Text);
                yeniEv = new KiralikEv(emlakNumarasi, odaSayisi, katNumarasi, semt, alan, yapimTarihi,  emlakTur,tur, aktifMi, aylikKira);
            }
            else if (tur == "Satılık")
            {
                yeniEv = new SatilikEv(emlakNumarasi, odaSayisi, katNumarasi, semt, alan, yapimTarihi,  emlakTur,tur, aktifMi, fiyat);
            }
            else
            {
                MessageBox.Show("Geçersiz ev türü!");
                return;
            }

            SaveEmlakToFile(yeniEv);
            MessageBox.Show("Emlak başarıyla kaydedildi!");
            ClearFormFields();
        }

        private void SaveEmlakToFile(Ev ev)
        {
            string dosyaYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "emlakler.txt");

            // Hata ayıklamak için dosya yolunu gösterelim
            MessageBox.Show("Dosya Yolu: " + dosyaYolu);

            // Emlak bilgilerini formatlı şekilde yazıyoruz
            string emlakVerisi = $"{ev.EmlakNumarasi},{ev.OdaSayisi},{ev.Alan},{ev.Fiyat},{ev.KatNumarasi},{ev.Semt},{ev.EmlakTur},{ev.Tur},{ev.YapimTarihi:yyyy-MM-dd},{ev.Aktif}";

            try
            {
                // Dosyanın varlığı kontrolü
                if (!File.Exists(dosyaYolu))
                {
                    // Dosya yoksa oluşturulur
                    File.Create(dosyaYolu).Close();
                }

                // Dosyaya veri ekleniyor
                File.AppendAllText(dosyaYolu, emlakVerisi + Environment.NewLine);
                MessageBox.Show("Emlak başarıyla kaydedildi!");
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("Dosyaya yazılırken bir hata oluştu: " + ioEx.Message);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                MessageBox.Show("Dosyaya yazma izniniz yok: " + uaEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message);
            }
        }


        private void ClearFormFields()
        {
            txtOdaSayisi.Clear();
            txtKatNumarasi.Clear();
            txtAlan.Clear();
            txtFiyat.Clear();
            cmbSemt.SelectedIndex = -1;
            cmbTur.SelectedIndex = -1;
            cmbEmlakTur.SelectedIndex = -1;
            chkAktif.Checked = false;
            dateYapimTarihi.Value = DateTime.Now;
        }
    }
}
