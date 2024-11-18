using EmlakLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace EmlakOtomasyonuUI
{
    public partial class MainForm : Form
    {
        private BindingList<Ev> bindingList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Uygulama açıldığında evleri dosyadan yükle
            LoadEvFromFile();
            Console.WriteLine(EmlakYonetimi.EvListesi.Count);
            bindingList = new BindingList<Ev>(EmlakYonetimi.EvListesi);  // BindingList oluşturuluyor
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = bindingList;
            dataGridViewEmlaklar.DataSource = bindingSource;
        }

        // Ev verilerini dosyadan okuma
        private void LoadEvFromFile()
        {
            string dosyaYolu = "emlakler.txt";
            EmlakYonetimi.EvListesi.Clear();

            if (File.Exists(dosyaYolu))
            {
                string[] emlakVerileri = File.ReadAllLines(dosyaYolu);

                foreach (var emlakVerisi in emlakVerileri)
                {
                    var veriler = emlakVerisi.Split(',');

                    if (veriler.Length >= 10)
                    {
                        try
                        {
                            int emlakNumarasi = Convert.ToInt32(veriler[0]);
                            int odaSayisi = Convert.ToInt32(veriler[1]);
                            double alan = Convert.ToDouble(veriler[2]);
                            double fiyat = Convert.ToDouble(veriler[3]);
                            int katNumarasi = Convert.ToInt32(veriler[4]);
                            string semt = veriler[5];
                            string tur = veriler[6];
                            string emlakTur = veriler[7];
                            DateTime yapimTarihi = Convert.ToDateTime(veriler[8]);
                            bool aktif = Convert.ToBoolean(veriler[9]);

                            Ev ev = new Ev(emlakNumarasi, odaSayisi, katNumarasi, semt, alan, yapimTarihi, emlakTur, tur, aktif, fiyat);
                            EmlakYonetimi.EvEkle(ev);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Veri işlenirken bir hata oluştu: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Dosya bulunamadı.");
            }
        }


        // Ev ekleme butonuna tıklanınca yeni form açılır
        private void btnEvEkle_Click(object sender, EventArgs e)
        {
            // Yeni ev ekleme formunu aç
            EvEkleForm evEkleForm = new EvEkleForm();
            evEkleForm.ShowDialog(); // ShowDialog() kullanarak kullanıcı formu tamamlayana kadar bekleriz

            // Evleri dosyadan yeniden yükle
            LoadEvFromFile();  // Bu satırı ekleyin
            btnListele_Click(sender, e); // Listeyi güncelle
        }


        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadEvFromFile();  // Dosyadaki evleri yeniden yükle
            bindingList = new BindingList<Ev>(EmlakYonetimi.EvListesi);  // Güncellenen listeyi bindingList'e at
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = bindingList;
            dataGridViewEmlaklar.DataSource = bindingSource;

            if (bindingList.Count == 0)
            {
                MessageBox.Show("EvListesi boş.");
            }
            dataGridViewEmlaklar.Refresh();  // DataGridView'i yenile

        }








        // Ev sorgulama butonuna tıklanınca belirli bir kritere göre evleri listele
        private void btnSorgula_Click(object sender, EventArgs e)
        {
            SorgulamaForm sorgulamaForm = new SorgulamaForm(this);
            sorgulamaForm.Show();
        }


        // Ev silme butonuna tıklanınca seçilen ev silinsin
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmlaklar.SelectedRows.Count > 0)
            {
                var secilenSatir = dataGridViewEmlaklar.SelectedRows[0];

                // null kontrolü yapalım
                if (secilenSatir.Cells["emlakNumarasi"].Value != null)
                {
                    var secilenEvNumarasi = (int)secilenSatir.Cells["emlakNumarasi"].Value;

                    var evToRemove = EmlakYonetimi.EvListesi.FirstOrDefault(ev => ev.EmlakNumarasi == secilenEvNumarasi);
                    if (evToRemove != null)
                    {
                        EmlakYonetimi.EvSil(evToRemove);
                        bindingList.Remove(evToRemove);
                    }

                    // Dosyayı kaydet
                    SaveEvToFile();
                }
                else
                {
                    MessageBox.Show("Geçersiz veri. Lütfen geçerli bir ev seçin.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ev seçin.");
            }
        }

        // Evleri dosyaya kaydetme fonksiyonu
        private void SaveEvToFile()
        {
            string dosyaYolu = "emlakler.txt";
            List<string> emlakVerileri = new List<string>();

            foreach (var ev in EmlakYonetimi.EvListesi)
            {
                string[] evVerisi = new string[] {
                    ev.OdaSayisi.ToString(),
                    ev.Alan.ToString(),
                    ev.Fiyat.ToString(),
                    ev.KatNumarasi.ToString(),
                    ev.Semt,
                    ev.EmlakTur,
                    ev.YapimTarihi.ToShortDateString(),
                    ev.Aktif.ToString(),
                    ev.EmlakNumarasi.ToString()
                };

                emlakVerileri.Add(string.Join(",", evVerisi));
            }

            File.WriteAllLines(dosyaYolu, emlakVerileri);
        }
        public void ListeyiGuncelle(List<Ev> evler)
        {
            // Yeni bir BindingList oluştur ve evleri ekle
            BindingList<Ev> updatedList = new BindingList<Ev>(evler);

            // DataGridView'in veri kaynağını güncelle
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = updatedList;
            dataGridViewEmlaklar.DataSource = bindingSource;

            // Eğer liste boşsa kullanıcıyı bilgilendir
            if (updatedList.Count == 0)
            {
                MessageBox.Show("Hiçbir ev bulunamadı.");
            }
        }




    }
}
