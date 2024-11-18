using System;
using System.Windows.Forms;

namespace EmlakOtomasyonuUI
{
    public partial class SorgulamaForm : Form
    {
        

        private void InitializeComponent()
        {
            this.labelOdaSayisi = new System.Windows.Forms.Label();
            this.labelAlan = new System.Windows.Forms.Label();
            this.textBoxMinAlan = new System.Windows.Forms.TextBox();
            this.labelMinAlan = new System.Windows.Forms.Label();
            this.textBoxMaxAlan = new System.Windows.Forms.TextBox();
            this.labelMaxAlan = new System.Windows.Forms.Label();
            this.labelSemt = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.textBoxMinFiyat = new System.Windows.Forms.TextBox();
            this.labelMinFiyat = new System.Windows.Forms.Label();
            this.textBoxMaxFiyat = new System.Windows.Forms.TextBox();
            this.labelMaxFiyat = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtOdaSayisi = new System.Windows.Forms.TextBox();
            this.txtSemt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelOdaSayisi
            // 
            this.labelOdaSayisi.AutoSize = true;
            this.labelOdaSayisi.Location = new System.Drawing.Point(13, 13);
            this.labelOdaSayisi.Name = "labelOdaSayisi";
            this.labelOdaSayisi.Size = new System.Drawing.Size(76, 16);
            this.labelOdaSayisi.TabIndex = 0;
            this.labelOdaSayisi.Text = "Oda Sayısı:";
            // 
            // labelAlan
            // 
            this.labelAlan.AutoSize = true;
            this.labelAlan.Location = new System.Drawing.Point(13, 40);
            this.labelAlan.Name = "labelAlan";
            this.labelAlan.Size = new System.Drawing.Size(37, 16);
            this.labelAlan.TabIndex = 2;
            this.labelAlan.Text = "Alan:";
            // 
            // textBoxMinAlan
            // 
            this.textBoxMinAlan.Location = new System.Drawing.Point(120, 37);
            this.textBoxMinAlan.Name = "textBoxMinAlan";
            this.textBoxMinAlan.Size = new System.Drawing.Size(50, 22);
            this.textBoxMinAlan.TabIndex = 3;
            // 
            // labelMinAlan
            // 
            this.labelMinAlan.AutoSize = true;
            this.labelMinAlan.Location = new System.Drawing.Point(176, 40);
            this.labelMinAlan.Name = "labelMinAlan";
            this.labelMinAlan.Size = new System.Drawing.Size(31, 16);
            this.labelMinAlan.TabIndex = 4;
            this.labelMinAlan.Text = "Min:";
            // 
            // textBoxMaxAlan
            // 
            this.textBoxMaxAlan.Location = new System.Drawing.Point(250, 37);
            this.textBoxMaxAlan.Name = "textBoxMaxAlan";
            this.textBoxMaxAlan.Size = new System.Drawing.Size(50, 22);
            this.textBoxMaxAlan.TabIndex = 5;
            // 
            // labelMaxAlan
            // 
            this.labelMaxAlan.AutoSize = true;
            this.labelMaxAlan.Location = new System.Drawing.Point(306, 40);
            this.labelMaxAlan.Name = "labelMaxAlan";
            this.labelMaxAlan.Size = new System.Drawing.Size(35, 16);
            this.labelMaxAlan.TabIndex = 6;
            this.labelMaxAlan.Text = "Max:";
            // 
            // labelSemt
            // 
            this.labelSemt.AutoSize = true;
            this.labelSemt.Location = new System.Drawing.Point(13, 70);
            this.labelSemt.Name = "labelSemt";
            this.labelSemt.Size = new System.Drawing.Size(41, 16);
            this.labelSemt.TabIndex = 7;
            this.labelSemt.Text = "Semt:";
            // 
            // labelFiyat
            // 
            this.labelFiyat.AutoSize = true;
            this.labelFiyat.Location = new System.Drawing.Point(13, 100);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(39, 16);
            this.labelFiyat.TabIndex = 9;
            this.labelFiyat.Text = "Fiyat:";
            // 
            // textBoxMinFiyat
            // 
            this.textBoxMinFiyat.Location = new System.Drawing.Point(120, 97);
            this.textBoxMinFiyat.Name = "textBoxMinFiyat";
            this.textBoxMinFiyat.Size = new System.Drawing.Size(50, 22);
            this.textBoxMinFiyat.TabIndex = 10;
            // 
            // labelMinFiyat
            // 
            this.labelMinFiyat.AutoSize = true;
            this.labelMinFiyat.Location = new System.Drawing.Point(176, 100);
            this.labelMinFiyat.Name = "labelMinFiyat";
            this.labelMinFiyat.Size = new System.Drawing.Size(31, 16);
            this.labelMinFiyat.TabIndex = 11;
            this.labelMinFiyat.Text = "Min:";
            // 
            // textBoxMaxFiyat
            // 
            this.textBoxMaxFiyat.Location = new System.Drawing.Point(250, 97);
            this.textBoxMaxFiyat.Name = "textBoxMaxFiyat";
            this.textBoxMaxFiyat.Size = new System.Drawing.Size(50, 22);
            this.textBoxMaxFiyat.TabIndex = 12;
            // 
            // labelMaxFiyat
            // 
            this.labelMaxFiyat.AutoSize = true;
            this.labelMaxFiyat.Location = new System.Drawing.Point(306, 100);
            this.labelMaxFiyat.Name = "labelMaxFiyat";
            this.labelMaxFiyat.Size = new System.Drawing.Size(35, 16);
            this.labelMaxFiyat.TabIndex = 13;
            this.labelMaxFiyat.Text = "Max:";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(120, 130);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(121, 23);
            this.btnListele.TabIndex = 14;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtOdaSayisi
            // 
            this.txtOdaSayisi.Location = new System.Drawing.Point(120, 10);
            this.txtOdaSayisi.Name = "txtOdaSayisi";
            this.txtOdaSayisi.Size = new System.Drawing.Size(50, 22);
            this.txtOdaSayisi.TabIndex = 15;
            // 
            // txtSemt
            // 
            this.txtSemt.Location = new System.Drawing.Point(120, 64);
            this.txtSemt.Name = "txtSemt";
            this.txtSemt.Size = new System.Drawing.Size(121, 22);
            this.txtSemt.TabIndex = 16;
            // 
            // SorgulamaForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.txtSemt);
            this.Controls.Add(this.txtOdaSayisi);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.labelMaxFiyat);
            this.Controls.Add(this.textBoxMaxFiyat);
            this.Controls.Add(this.labelMinFiyat);
            this.Controls.Add(this.textBoxMinFiyat);
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.labelSemt);
            this.Controls.Add(this.labelMaxAlan);
            this.Controls.Add(this.textBoxMaxAlan);
            this.Controls.Add(this.labelMinAlan);
            this.Controls.Add(this.textBoxMinAlan);
            this.Controls.Add(this.labelAlan);
            this.Controls.Add(this.labelOdaSayisi);
            this.Name = "SorgulamaForm";
            this.Text = "Ev Sorgulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label labelOdaSayisi;
        private Label labelAlan;
        private TextBox textBoxMinAlan;
        private Label labelMinAlan;
        private TextBox textBoxMaxAlan;
        private Label labelMaxAlan;
        private Label labelSemt;
        private Label labelFiyat;
        private TextBox textBoxMinFiyat;
        private Label labelMinFiyat;
        private TextBox textBoxMaxFiyat;
        private Label labelMaxFiyat;
        private Button btnListele;
        private TextBox txtOdaSayisi;
        private TextBox txtSemt;
    }
}
