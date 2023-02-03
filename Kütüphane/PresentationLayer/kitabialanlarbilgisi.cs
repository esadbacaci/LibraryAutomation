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
    public partial class kitabialanlarbilgisi : Form
    {
        public kitabialanlarbilgisi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=library.mdb"), new OgrenciKontrolKarma(), new KitapKontrolTumu(), new OduncSilKontrol());

        int m;
        int Mouse_X;
        int Mouse_Y;
        private void kitabialanlarbilgisi_Load(object sender, EventArgs e)
        {


            datagridktp.DataSource = businessManager.kitap_listele().Tables[0];
            //datagridview başlıkları
            datagridktp.Columns[0].HeaderText = "Kitap ID";
            datagridktp.Columns[1].HeaderText = "Kitap İsmi";
            datagridktp.Columns[2].HeaderText = "Kitap Türü";
            datagridktp.Columns[3].HeaderText = "Kitap Yazarı";
            datagridktp.Columns[4].HeaderText = "Kitap Yayınevi";
            datagridktp.Columns[5].HeaderText = "Kitap Sayfası";
            datagridktp.Columns[6].HeaderText = "Kitap Adeti";

            datagridktp.Columns[0].Width = 55;
            datagridktp.Columns[1].Width = 130;
            datagridktp.Columns[2].Width = 130;
            datagridktp.Columns[3].Width = 130;
            datagridktp.Columns[4].Width = 130;
            datagridktp.Columns[5].Width = 110;
            datagridktp.Columns[6].Width = 110;


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
        private void odunc_listesini_goster()
        {
            if (businessManager.odunc_ogrenci_kitap_sayisi(int.Parse(label_id.Text)) == 0)
            {
                datagridalinanktp.DataSource = "";
                label_bilgilendirme.Text = "Kitabı Henüz Hiçbir Öğrenci Ödünç Almadı.";
                label_bilgilendirme.Visible = true; // ekranda bilgi gözükecek
            }
            else
            {
                datagridalinanktp.DataSource = businessManager.odunc_kitap_listele(int.Parse(datagridktp.CurrentRow.Cells[0].Value.ToString())).Tables[0];
                datagridalinanktp.Columns[0].HeaderText = "Ödünç ID";
                datagridalinanktp.Columns[1].HeaderText = "Öğrenci ID";
                datagridalinanktp.Columns[2].HeaderText = "Kitap ID";
                datagridalinanktp.Columns[3].HeaderText = "Ödünç Alma Tarihi";
                datagridalinanktp.Columns[4].HeaderText = "Teslim Etme Tarihi";
                datagridalinanktp.Columns[5].HeaderText = "Öğrenci Borcu";

                datagridalinanktp.Columns[0].Width = 50;
                datagridalinanktp.Columns[1].Width = 50;
                datagridalinanktp.Columns[2].Width = 50;
                datagridalinanktp.Columns[3].Width = 100;
                datagridalinanktp.Columns[4].Width = 100;
                datagridalinanktp.Columns[5].Width = 100;
                datagridalinanktp.ClearSelection();

                label_bilgilendirme.Visible = false;
            }

    
        }

        private void datagridktp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (datagridktp.SelectedRows.Count > 0)
            {


                odunc_listesini_goster(); // Öğrenciye ait ödünç listesi listeleniyor.
                grid_renkleri_degistir(datagridalinanktp);//kitabı teslim edip etmeyenleri listeler


            }
            else
            {
                MessageBox.Show("Kitap bilgilerini görmek istediğiniz ödünç alma bilgisini seçiniz.");
            }

        }

        private void kitabialanlarbilgisi_MouseMove(object sender, MouseEventArgs e)
        {

            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void kitabialanlarbilgisi_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void kitabialanlarbilgisi_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void datagridktp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_id.Text = datagridktp.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
