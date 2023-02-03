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
    public partial class kitapislem : Form
    {
        public kitapislem()
        {
            InitializeComponent();
        }
     


        private void kitapislem_Load(object sender, EventArgs e)
        {
            //listeleme için kullandığımız kod


                datagrid_kitap.DataSource = businessManager.kitap_listele().Tables[0];
                //datagridview başlıkları
                datagrid_kitap.Columns[0].HeaderText = "Kitap ID";
                datagrid_kitap.Columns[1].HeaderText = "Kitap İsmi";
                datagrid_kitap.Columns[2].HeaderText = "Kitap Türü";
                datagrid_kitap.Columns[3].HeaderText = "Kitap Yazarı";
                datagrid_kitap.Columns[4].HeaderText = "Kitap Yayınevi";
                datagrid_kitap.Columns[5].HeaderText = "Kitap Sayfası";
                datagrid_kitap.Columns[6].HeaderText = "Kitap Adeti";

                datagrid_kitap.Columns[0].Width = 52;
                datagrid_kitap.Columns[1].Width = 150;
                datagrid_kitap.Columns[2].Width = 150;
                datagrid_kitap.Columns[3].Width = 150;
                datagrid_kitap.Columns[4].Width = 150;
                datagrid_kitap.Columns[5].Width = 150;
                datagrid_kitap.Columns[6].Width = 150;


            

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int m;
        int Mouse_X;
        int Mouse_Y;

        private void kitapislem_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void kitapislem_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void kitapislem_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }


        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=library.mdb"), new OgrenciKontrolKarma(), new KitapKontrolTumu(), new OduncSilKontrol());
        //textboxların boş bırakılmamsı için gereken kodlar
        public Boolean textler_bosMu()
        {
            if (txtkitapad.Equals("") || combokitap.Text.Equals("") ||txtkitapyazari.Text.Equals("") || txtkitapyayinevi.Text.Equals("") || txtkitapsayfa.Text.Equals("") || txtkitapadet.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       

       

        private void datagrid_kitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //seçtiğimiz kitap bilgileri textboxlara gelecekbu güncelleme işlemi yaparken bize kolaylık sağlaycak
            gtxtkitapad.Text = datagrid_kitap.Rows[e.RowIndex].Cells[1].Value.ToString();
            gcombobox.Text = datagrid_kitap.Rows[e.RowIndex].Cells[2].Value.ToString();
            gtxtkitapyazari.Text = datagrid_kitap.Rows[e.RowIndex].Cells[3].Value.ToString();
            gtxtyayinevi.Text = datagrid_kitap.Rows[e.RowIndex].Cells[4].Value.ToString();  
            gtxtsayfasayisi.Text = datagrid_kitap.Rows[e.RowIndex].Cells[5].Value.ToString();
            gtxtkitapadet.Text = datagrid_kitap.Rows[e.RowIndex].Cells[6].Value.ToString();
            label_id.Text= datagrid_kitap.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        //eğer textboxlar boş ise güncelleme işlemi gerçekleşmeyecek
        public Boolean textler_bosMuGuncelleme()
        {
            if (gtxtkitapad.Text.Equals("") || gcombobox.Text.Equals("") || gtxtkitapyazari.Text.Equals("") || gtxtkitapyazari.Text.Equals("") || gtxtsayfasayisi.Text.Equals("") || gtxtkitapadet.Text.Equals(""))
            {
                return true;
            }
            return false;
        }
       
        //filtrelemeli güncelleme işlemi
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            datagrid_kitap.DataSource = businessManager.kitap_ara(textBox1.Text).Tables[0];
           
        }

     
        //kitap ekleme butonu için gerekli kod
        private void btn_kitapekle_Click(object sender, EventArgs e)
        {
            if (textler_bosMu())
            {
                //TextBox kontrol
                MessageBox.Show("Boşta alan kalmasın. Ekleme işlemi başarısız.");
            }
            else
            {
                if (businessManager.kitap_ekle(txtkitapad.Text, combokitap.Text, txtkitapyazari.Text, txtkitapyayinevi.Text, int.Parse(txtkitapsayfa.Text), int.Parse(txtkitapadet.Text)))
                {
                    //aynı kitaptan varsa ekleme işlemi yapmayacak
                    MessageBox.Show("Bu bilgilere ait kitap zaten var. Ekleme işlemi başarısız.");
                }
                else
                {
                  
                    MessageBox.Show("Ekleme işlemi başarılı.");
                    //ekleme işleminden sonra tabloyu yenileyecek
                    datagrid_kitap.DataSource = businessManager.kitap_listele().Tables[0];
                }
            }
        }

    
        private void btn_kitapsil_Click(object sender, EventArgs e)
        {
            if (datagrid_kitap.SelectedRows.Count > 0)
            {
                // id'yi birden çok kullanacağımız için bi değişkene atadık.
                int id = int.Parse(datagrid_kitap.CurrentRow.Cells[0].Value.ToString());

                // eğer kitabı teslim etmeyen öğrenci varsa uyarı mesajı gönderecek ve soracak.
                if (businessManager.odunc_kitap_teslim_edildiMi(id))
                {
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = MessageBox.Show("Bu kitabı teslim etmeyen öğrenci bulunuyor. Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        businessManager.odunc_kitap_sil(id);
                        businessManager.kitap_sil(id); // her iki tablodan da kitap silindi.
                        MessageBox.Show("Kitap her iki tablodan da silindi.");
                        datagrid_kitap.DataSource = businessManager.kitap_listele().Tables[0];


                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi yapılmadı.");
                    }
                }
                else
                { // direkt kitap tablosundan silinecek.
                    businessManager.odunc_kitap_sil(id);
                    businessManager.kitap_sil(id);
                    MessageBox.Show("Kitap silindi.");
                    //kitap silinince tabloyu yenile
                    datagrid_kitap.DataSource = businessManager.kitap_listele().Tables[0];

                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz öğrenceiyi seçiniz.");
            }
        }

       
        //formu kapatma kodu
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //kitap güncelleme butno içine yazdığımız kodlar
        private void btn_kitapguncelle_Click(object sender, EventArgs e)
        {
            if (textler_bosMuGuncelleme())
            {
                //textboxlar boş ise güncelleme yapmayacak
                MessageBox.Show("Boşta alan kalmasın. Güncelleme işlemi başarısız.");
            }
            else
            {
                businessManager.kitap_guncelle(int.Parse(label_id.Text), gtxtkitapad.Text, gcombobox.Text, gtxtkitapyazari.Text, gtxtyayinevi.Text, int.Parse(gtxtsayfasayisi.Text), int.Parse(gtxtkitapadet.Text));

                MessageBox.Show("Güncelleme işlemi başarılı.");
                //güncelleme işlemi bitince tabloyu güncelleyecek
                datagrid_kitap.DataSource = businessManager.kitap_listele().Tables[0];
            }

        }
    }
    
}
