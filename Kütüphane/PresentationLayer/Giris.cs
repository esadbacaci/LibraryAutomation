using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        //Formu Hareket Ettirmek İçin Kullandığım Kodlar
        int m;
        int Mouse_X;
        int Mouse_Y;
        private void Giris_MouseUp_1(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Giris_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }

        }

        private void Giris_MouseDown_1(object sender, MouseEventArgs e)
        {
            m = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

       

        //yeni forma geçiş kodları (butonlar)
        private void ogrislem_Click(object sender, EventArgs e)
        {
            ogrislem ogris = new ogrislem();
            ogris.Show();
        }

        private void kitapislem_Click(object sender, EventArgs e)
        {

            kitapislem kitapis = new kitapislem();
            kitapis.Show();
        }

        private void oduncliste_Click(object sender, EventArgs e)
        {
            ogrliste ogrlis = new ogrliste();
            ogrlis.Show();
        }

        private void grafik_Click(object sender, EventArgs e)
        {
            zedgraph grafik = new zedgraph();
            grafik.Show();
        }

        //delete iconun içine form kapatma kodu yazdım
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrencialdigikitaplar ogrkitap = new ogrencialdigikitaplar();
            ogrkitap.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kitabialanlarbilgisi ktpalan = new kitabialanlarbilgisi();
            ktpalan.Show();
        }
    }
}
