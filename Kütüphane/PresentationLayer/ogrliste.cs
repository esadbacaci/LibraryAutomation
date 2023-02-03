using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLayer;


namespace PresentationLayer
{
    public partial class ogrliste : Form
    {
        public ogrliste()
        {
            InitializeComponent();
        }
        //Form elipse kullandığım için formu hareket ettirmemi sağlayan kodlar
        int m;
        int Mouse_X;
        int Mouse_Y;
       
    
        
        private void ogrliste_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }

        }

        private void ogrliste_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void ogrliste_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }
       

        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=library.mdb"), new OgrenciKontrolKarma(), new KitapKontrolTumu(), new OduncSilKontrol());
        private void grid_renkleri_degistir(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle(); // istediğimiz renkleri atayacağımız nesne
                if (!(dataGridView.Rows[i].Cells["odunc_teslim_tarihi"].Value.ToString()).Equals("Teslim edilmedi"))
                {  
                    //Kitap teslim edildiyse
                    renk.BackColor = Color.Green; // yeşil tonu arka plan
                    renk.ForeColor = Color.White; // beyaz tonu yazı rengi
                }
                else
                {
                   //15 günlük teslim süresi var
                    int gecen_zaman = businessManager.odunc_teslim_zaman_kontrol(int.Parse(dataGridView.Rows[i].Cells["odunc_id"].Value.ToString()));

                    if (gecen_zaman > 15) //eğer 15 günü geçtiyse
                    {
                        renk.BackColor = Color.Red; //arkaplan kırmızı renk olacak
                        renk.ForeColor = Color.White; //yazı rengi beyaz olacak

                        int ogrenci_borc = gecen_zaman - 15; // öğrencinin borcunu güncelliyoruz

                        businessManager.odunc_ogrenci_borc_guncelle(int.Parse(dataGridView.Rows[i].Cells["odunc_id"].Value.ToString()), ogrenci_borc);
                        businessManager.ogrenci_borc_guncelle(int.Parse(dataGridView.Rows[i].Cells["ogrenci_id"].Value.ToString()), ogrenci_borc);
                    }
                    else if (gecen_zaman >= 13) // Kitap teslimine 2 gün yada daha az kaldıysa
                    {
                        renk.BackColor = Color.Yellow; //arkaplanı sarı renk yapıyoruz
                        renk.ForeColor = Color.Black; 

                    }
                }
                dataGridView.Rows[i].DefaultCellStyle = renk; // ilgili satırın rengini değiştir
            }
        }
        private void ogrliste_Load(object sender, EventArgs e)
        {
            
            //form load olduktan sonra tablolarımız otomatik gelecek

            datagrid_odunc.DataSource = businessManager.odunc_listele().Tables[0];
            datagrid_odunc.Columns[0].HeaderText = "Ödünç ID";
            datagrid_odunc.Columns[1].HeaderText = "Öğrenci ID";
            datagrid_odunc.Columns[2].HeaderText = "Kitap ID";
            datagrid_odunc.Columns[3].HeaderText = "Ödünç Alma Tarihi";
            datagrid_odunc.Columns[4].HeaderText = "Teslim Etme Tarihi";
            datagrid_odunc.Columns[5].HeaderText = "Öğrenci Borcu";

            grid_renkleri_degistir(datagrid_odunc);


            if (businessManager.ogrenci_sayisi_ogren() == 0) // eğer öğrenciler tablosunda öğrenci yoksa 
            {
                datagridogr.DataSource = "";
                label_bilgi.Text = "Kütüphanede kayıtlı öğrenci yok.";
                label_bilgi.Visible = true; // ödünç alan öğrenci yoksa, ekranda bilgilendirme mesajı olacak.
            }
            else
            {
                datagridogr.DataSource = businessManager.ogrenci_listele().Tables[0];
                datagridogr.Columns[0].HeaderText = "Öğrenci ID";
                datagridogr.Columns[1].HeaderText = "Öğrenci Adı";
                datagridogr.Columns[2].HeaderText = "Öğrenci Soyadı";
                datagridogr.Columns[3].HeaderText = "Öğrenci Bölümü";
                datagridogr.Columns[4].HeaderText = "Öğrenci Tc Numarası";
                datagridogr.Columns[5].HeaderText = "Öğrenci Okul Numarası";
                datagridogr.Columns[6].HeaderText = "Öğrenci Cinsiyeti";
                datagridogr.Columns[7].HeaderText = "Öğrenci Borcu";
                label_bilgi.Visible = false;
                // öğrencileri listele ve header başlıklarını değiştir
            }

                datagridktp.DataSource = businessManager.kitap_listele().Tables[0];
                datagridktp.Columns[0].HeaderText = "Kitap ID";
                datagridktp.Columns[1].HeaderText = "Kitap İsmi";
                datagridktp.Columns[2].HeaderText = "Kitap Türü";
                datagridktp.Columns[3].HeaderText = "Kitap Yazarı";
                datagridktp.Columns[4].HeaderText = "Kitap Yayınevi";
                datagridktp.Columns[5].HeaderText = "Kitap Sayfası";
                datagridktp.Columns[6].HeaderText = "Kitap Adeti";
                //datagrid boyutları
                datagridktp.Columns[0].Width = 50;
                datagridktp.Columns[1].Width = 130;
                datagridktp.Columns[2].Width = 130;
                datagridktp.Columns[3].Width = 130;
                datagridktp.Columns[4].Width = 130;
                datagridktp.Columns[5].Width = 110;
                datagridogr.Columns[7].Width = 80;

                 datagrid_odunc.Columns[0].Width = 50;
                datagrid_odunc.Columns[1].Width = 150;
                datagrid_odunc.Columns[2].Width = 150;
                datagrid_odunc.Columns[3].Width = 150;
                datagrid_odunc.Columns[4].Width = 150;
                datagrid_odunc.Columns[5].Width = 130;


    
        }

        
      

        //Başta hiçbir satır seçili gelmesin istedim
        private void ogrliste_Shown(object sender, EventArgs e)
        {
            datagridktp.ClearSelection();
            datagridogr.ClearSelection();
            datagrid_odunc.ClearSelection();
        }
        //textboxlarda filtrelemeli arama
        private void ograra_TextChanged(object sender, EventArgs e)
        {
            datagridogr.DataSource = businessManager.ogrenci_ara(ograra.Text).Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            datagridktp.DataSource = businessManager.kitap_ara(textBox1.Text).Tables[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            datagrid_odunc.DataSource = businessManager.odunc_ara(textBox2.Text).Tables[0];
        }

        //kitap alma butonu
        private void btn_kitapal_Click(object sender, EventArgs e)
        {
            if (datagridogr.SelectedRows.Count > 0) // öğrenci seçildiyse
            {

                DateTime dateTime = DateTime.Now;
                if (businessManager.kitap_sayisi_kontrolEt(int.Parse(datagridktp.CurrentRow.Cells[0].Value.ToString()))) // kitabın stoğu müsaitse.

                    if (businessManager.odunc_ekle(int.Parse(datagridogr.CurrentRow.Cells[0].Value.ToString()), int.Parse(datagridktp.CurrentRow.Cells[0].Value.ToString()), dateTime.ToString("d")))
                    { // İşlem başarılıysa
                        MessageBox.Show("Ödünç verme işlemi başarılı.");

                        datagridktp.DataSource = businessManager.kitap_listele().Tables[0];
                        datagrid_odunc.DataSource = businessManager.odunc_listele().Tables[0];
                        grid_renkleri_degistir(datagrid_odunc);
                    }
                    else
                    { // öğrencinin iade etmediği kitap bulunuyorsa
                        MessageBox.Show("Öğrencinin teslim etmediği kitap bulunduğu için ödünç veremezsiniz.");
                    }

                else
                {
                    MessageBox.Show("Kitap stokta yok");
                }



            }
            else
            { // seçim yapmak zorunda
                MessageBox.Show("Ödünç İşlemleri yapmak istediğiniz öğrenciyi seçiniz.");
            }

        }
        //form kapatma kodu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_iadeet_Click(object sender, EventArgs e)
        {
            if (datagrid_odunc.SelectedRows.Count > 0) // kitap stokta var mı
            {
                DateTime dateTime = DateTime.Now;
                if (!businessManager.odunc_id_teslim_edildiMi(int.Parse(datagrid_odunc.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("Bu kitap zaten iade alındı."); // kitap 1 kere iade alındıysa birdaha alınamaz
                }
                else
                {
                    businessManager.odunc_iade(int.Parse(datagrid_odunc.CurrentRow.Cells[0].Value.ToString()), int.Parse(datagrid_odunc.CurrentRow.Cells[1].Value.ToString()), int.Parse(datagrid_odunc.CurrentRow.Cells[2].Value.ToString()), dateTime.ToString("d"));
                    MessageBox.Show("İade işlemi başarılı.");

                    //tüm tabloları tekrardan güncelle
                    datagridogr.DataSource = businessManager.ogrenci_listele().Tables[0];
                    datagrid_odunc.DataSource = businessManager.odunc_listele().Tables[0];
                    datagridktp.DataSource = businessManager.kitap_listele().Tables[0];
                    grid_renkleri_degistir(datagrid_odunc);
                }
            }
            else
            { // Bir seçim yapılmadıysa
                MessageBox.Show("İade işlemi için ödünç tablosundan seçim yapınız.");
            }
        }

        private void datagridogr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }
    }


    
}


