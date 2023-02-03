using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ogrislem : Form
    {
        public ogrislem()
        {
            InitializeComponent();
        }
        //Formu Hareket Ettirmek İçin Kullandığım Kodlar
        int m;
        int Mouse_X;
        int Mouse_Y;

        private void ogrislem_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void ogrislem_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }

        }

        private void ogrislem_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }


        private void ogrislem_Load(object sender, EventArgs e)
        {
          
            //tabloları form load olur olmaz çağırıyoruz

            dataGridView1.DataSource = businessManager.ogrenci_listele().Tables[0];
            dataGridView1.Columns[0].HeaderText = "Öğrenci ID";
            dataGridView1.Columns[1].HeaderText = "Öğrenci Adı";
            dataGridView1.Columns[2].HeaderText = "Öğrenci Soyadı";
            dataGridView1.Columns[3].HeaderText = "Bölümü";
            dataGridView1.Columns[4].HeaderText = "Öğrenci Tc";
            dataGridView1.Columns[5].HeaderText = "Okul No";
            dataGridView1.Columns[6].HeaderText = "Cinsiyet";
            dataGridView1.Columns[7].HeaderText = "Borç";

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 125;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 125;
            dataGridView1.Columns[4].Width = 125;
            dataGridView1.Columns[5].Width = 125;
            dataGridView1.Columns[6].Width = 125;
            dataGridView1.DataSource = businessManager.ogrenci_listele().Tables[0];

        }
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=library.mdb"), new OgrenciKontrolKarma(), new KitapKontrol(), new OduncSilKontrol());
        public Boolean textler_bosMu()
        {
            //textboxlar boş mu kontrol işlemi
            if (txtad.Text.Equals("") || txtsoyad.Text.Equals("") || txttc.Text.Equals("") || txtbolum.Text.Equals("") || txtokuno.Text.Equals("") || cinsiyetbox.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
       
      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //öğrenciye tıklayınca textboxlara bilgileri gelecek

            label_id.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            gtxtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            gtxtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            gtxtbolum.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            gtxttc.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            gtxtokulno.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            gcombobox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        
        }
       
        //filtrelemeli arama
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = businessManager.ogrenci_ara(textBox1.Text).Tables[0];
        }

        private void btn_ogrekle_Click(object sender, EventArgs e)
        {
            if (textler_bosMu())
            {
                MessageBox.Show("Boşta alan kalmasın. Ekleme işlemi başarısız.");
            }
            else
            {
                if (txttc.Text.Length != 11)
                { // tc numarası, okul numarsı ve cinsiyet doğru girilmediyse uyarı mesajı
                    MessageBox.Show("Tc Numarası 11 haneli olmalı. Ekleme işlemi başarısız.");
                }


                else
                { // doğru girildiyse ekleme işlemlerini sorgula
                    if (businessManager.ogrenci_ekle(txtad.Text, txtsoyad.Text, txtbolum.Text, txttc.Text, txtokuno.Text, cinsiyetbox.Text))
                    {
                        MessageBox.Show("Bu bilgilere ait öğrenci zaten var. Ekleme işlemi başarısız.");
                    }
                    else
                    {

                        MessageBox.Show("Ekleme işlemi başarılı.");
                        //işlemden sonra tekrardan tabloyu yenileyecek
                        dataGridView1.DataSource = businessManager.ogrenci_listele().Tables[0];

                    }
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // seçili öğrenci vrasa
            {
                // id'yi birden çok kullanacağımız için bi değişkene atadık.
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                // eğer öğrencinin teslim etmediği kitap varsa uyarı mesajı gönderecek ve soracak.
                if (!businessManager.odunc_teslim_edildiMi(id))
                {
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = MessageBox.Show("Bu öğrencinin teslim etmediği kitap bulunuyor. Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        businessManager.odunc_ogrenci_sil(id);
                        businessManager.ogrenci_sil(id); // her iki tablodan da öğrenci silindi.
                        MessageBox.Show("Öğrenci her iki tablodan da silindi.");

                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi yapılmadı.");
                    }
                }
                else
                { // direkt öğrenci tablosundan silinecek.

                    businessManager.odunc_ogrenci_sil(id);
                    businessManager.ogrenci_sil(id);
                    MessageBox.Show("Öğrenci silindi.");
                    dataGridView1.DataSource = businessManager.ogrenci_listele().Tables[0];

                }

            }
            else
            {
                MessageBox.Show("Silmek istediğiniz öğrenceiyi seçiniz.");
            }
        }

        private void btn_ogrguncelle_Click(object sender, EventArgs e)
        {

            { // bütün durumlar sağlanıyorsa öğrenci güncelleme işlemini sorgula.
                if (businessManager.ogrenci_guncelle(int.Parse(label_id.Text), gtxtad.Text, gtxtsoyad.Text, gtxtbolum.Text, gtxttc.Text, gtxtokulno.Text, gcombobox.Text))
                {
                    MessageBox.Show("Bu bilgilere ait öğrenci zaten var. Güncelleme işlemi başarısız.");
                }
                else
                { // tekardan businessManager.ogrenci_guncelle'yi kullanmaya gerek var mı kontrol etmeyi unutma !!!!!
                    businessManager.ogrenci_guncelle(int.Parse(label_id.Text), gtxtad.Text, gtxtsoyad.Text, gtxtbolum.Text, gtxttc.Text, gtxtokulno.Text, gcombobox.Text);
                    MessageBox.Show("Güncelleme işlemi başarılı.");
                    dataGridView1.DataSource = businessManager.ogrenci_listele().Tables[0];

                }
            }
        }

        //delete icon formu kapatma
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
