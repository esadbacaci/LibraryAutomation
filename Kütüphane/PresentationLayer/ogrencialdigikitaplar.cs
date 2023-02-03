using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class ogrencialdigikitaplar : Form
    {
        public ogrencialdigikitaplar()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=library.mdb"), new OgrenciKontrolKarma(), new KitapKontrolTumu(), new OduncSilKontrol());
        private void ogrencialdigikitaplar_Load(object sender, EventArgs e)
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



        }

        private void odunc_listesini_goster()
        {

            if (businessManager.odunc_ogrenci_kitap_sayisi(int.Parse(label_id.Text)) == 0)
            {
                datagridalinan.DataSource = "";
                label_bilgilendirme.Text = "Öğrencinin Ödünç Aldığı Kitap Yok.";
                label_bilgilendirme.Visible = true; // ekranda bilgi gözükecek
            }
            else
            {
                datagridalinan.DataSource = businessManager.odunc_ogrenci_listele(int.Parse(datagridogr.CurrentRow.Cells[0].Value.ToString())).Tables[0];
                datagridalinan.Columns[0].HeaderText = "Ödünç ID";
                datagridalinan.Columns[1].HeaderText = "Öğrenci ID";
                datagridalinan.Columns[2].HeaderText = "Kitap ID";
                datagridalinan.Columns[3].HeaderText = "Ödünç Alma Tarihi";
                datagridalinan.Columns[4].HeaderText = "Teslim Etme Tarihi";
                datagridalinan.Columns[5].HeaderText = "Öğrenci Borcu";
         
                datagridalinan.Columns[0].Width = 50;
                datagridalinan.Columns[1].Width = 50;
                datagridalinan.Columns[2].Width = 50;
                datagridalinan.Columns[3].Width = 100;
                datagridalinan.Columns[4].Width = 100;
                datagridalinan.Columns[5].Width = 100;
                datagridalinan.ClearSelection();

                label_bilgilendirme.Visible = false;

            }
        }
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


        private void datagridogr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

         
            if (datagridogr.SelectedRows.Count > 0)
            {


                odunc_listesini_goster(); // Öğrenciye ait ödünç listesi listeleniyor.
                grid_renkleri_degistir(datagridalinan); //renkler aynı şekilde gözüksün


            }
            else
            {
                MessageBox.Show("Kitap bilgilerini görmek istediğiniz ödünç alma bilgisini seçiniz.");
            }

        }

        private void datagridogr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id.Text = datagridogr.CurrentRow.Cells[0].Value.ToString();
        }

        int m;
        int Mouse_X;
        int Mouse_Y;
        private void ogrencialdigikitaplar_MouseDown(object sender, MouseEventArgs e)
        {

            m = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void ogrencialdigikitaplar_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void ogrencialdigikitaplar_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
