namespace EmlakOtomasyonuUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // form elemanları
        private System.Windows.Forms.Button btnEvEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridViewEmlaklar;
        private System.Windows.Forms.Button btnEvDüzenle;


        // Formu temizlemek için kullanılan metod
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Tasarım öğelerini buraya ekleyebilirsiniz
        private void InitializeComponent()
        {
            this.btnEvEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridViewEmlaklar = new System.Windows.Forms.DataGridView();
            this.btnDuzenleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmlaklar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEvEkle
            // 
            this.btnEvEkle.Location = new System.Drawing.Point(12, 12);
            this.btnEvEkle.Name = "btnEvEkle";
            this.btnEvEkle.Size = new System.Drawing.Size(100, 30);
            this.btnEvEkle.TabIndex = 0;
            this.btnEvEkle.Text = "Ev Ekle";
            this.btnEvEkle.UseVisualStyleBackColor = true;
            this.btnEvEkle.Click += new System.EventHandler(this.btnEvEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(12, 60);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(100, 30);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(12, 108);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(100, 30);
            this.btnSorgula.TabIndex = 2;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 207);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridViewEmlaklar
            // 
            this.dataGridViewEmlaklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmlaklar.Location = new System.Drawing.Point(130, 12);
            this.dataGridViewEmlaklar.Name = "dataGridViewEmlaklar";
            this.dataGridViewEmlaklar.RowHeadersWidth = 51;
            this.dataGridViewEmlaklar.RowTemplate.Height = 24;
            this.dataGridViewEmlaklar.Size = new System.Drawing.Size(600, 400);
            this.dataGridViewEmlaklar.TabIndex = 4;
            // 
            // btnDuzenleme
            // 
            this.btnDuzenleme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDuzenleme.Location = new System.Drawing.Point(12, 154);
            this.btnDuzenleme.Name = "btnDuzenleme";
            this.btnDuzenleme.Size = new System.Drawing.Size(100,30);
            this.btnDuzenleme.TabIndex = 5;
            this.btnDuzenleme.Text = "Düzenleme";
            this.btnDuzenleme.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDuzenleme);
            this.Controls.Add(this.dataGridViewEmlaklar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnEvEkle);
            this.Name = "MainForm";
            this.Text = "Emlak Otomasyonu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmlaklar)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnDuzenleme;
    }
}
