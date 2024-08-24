using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validasyon;


namespace OgrenciForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci
            {
                Adı = txtAd.Text,
                Soyadı = txtSoyad.Text,
                Bolum = txtBolum.Text,
            };

            Student student = new Student()
            {
                FirstName = txtAd.Text,
                LastName = txtSoyad.Text,
                Department = txtBolum.Text

            };

            List<string> missingFields = RequiredFieldValidator.Validate(student);

            if (missingFields.Count > 0)
            {
                string missingFieldMessage = "Lütfen aşağıdaki alanları doldurunuz:\n" + string.Join("\n", missingFields);
                MessageBox.Show(missingFieldMessage, "Eksik Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }





            if (!ZorunlulukKontrolu.Dogrula(ogrenci))
            {
                MessageBox.Show("Lütfen tüm alanları giriniz ogrenci");
                return;
            }


            if (!ZorunlulukKontrolu.Dogrula(student))
            {
                MessageBox.Show("Lütfen tüm alanları giriniz student");
                return;
            }


            MessageBox.Show($"Adı: {ogrenci.Adı}\nSoyadı: {ogrenci.Soyadı}\nBölüm: {ogrenci.Bolum}", "Kayıt Bilgisi32");
            MessageBox.Show("Selam");

        }
    }
}
