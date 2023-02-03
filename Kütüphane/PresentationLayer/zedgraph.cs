using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using BusinessLayer;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class zedgraph : Form
    {
        public zedgraph()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // çalışmasını istediğimiz iş katmanı metotları.
        BusinessManager businessManager = new BusinessManager(new AccessDAO("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=library.mdb"), new OgrenciKontrolKarma(), new KitapKontrolTumu(), new OduncSilKontrol());

        public void graphOlustur(ZedGraphControl zg1)
        { //hazır internetten bulduğum zedgraph kodları
            GraphPane myPane = zg1.GraphPane;


            // değerler
            double[] y = { businessManager.kitap_sayisi_ogren() };
            double[] y2 = { businessManager.ogrenci_sayisi_ogren() };
            double[] y3 = { businessManager.odunc_alinan_kitap_sayisi() };
            double[] y4 = { businessManager.odunc_teslim_edilmeyen_kitap_sayisi() };





            // Generate a red bar with "Curve 1" in the legend
            BarItem myBar = myPane.AddBar("Kitap Çeşidi", null, y,
                                                        Color.Red);
            myBar.Bar.Fill = new Fill(Color.Red);

            // Generate a blue bar with "Curve 2" in the legend
            myBar = myPane.AddBar("Öğrenci Sayısı", null, y2, Color.Blue);
            myBar.Bar.Fill = new Fill(Color.Blue);

            // Generate a green bar with "Curve 3" in the legend
            myBar = myPane.AddBar("Ödünç Alınan Kitap Sayısı", null, y3, Color.Green);
            myBar.Bar.Fill = new Fill(Color.Green
                                                       );
            // Generate a green bar with "Curve 4" in the legend
            myBar = myPane.AddBar("Teslim Edilmeyen Kitap Sayısı", null, y4, Color.Yellow);
            myBar.Bar.Fill = new Fill(Color.Yellow);

            // Draw the X tics between the labels instead of 
            // at the labels
            myPane.XAxis.MajorTic.IsBetweenLabels = true;

            // Set the XAxis labels
            //myPane.XAxis.Scale.TextLabels = labels;

            // Set the XAxis to Text type
            myPane.XAxis.Type = AxisType.Text;

            // Fill the Axis and Pane backgrounds
            //myPane.Chart.Fill = new Fill(Color.White,
            //      Color.FromArgb(255, 255, 166), 90F);
            myPane.Chart.Fill = new Fill(Color.WhiteSmoke, Color.WhiteSmoke);
            myPane.Fill = new Fill(Color.WhiteSmoke);
            myPane.Title.Text = "Kütüphane Bilgileri (Grafik)";
            myPane.XAxis.Title.Text = "Kütüphane Grafik Genel Analizi";
            myPane.YAxis.Title.Text = "Sayısal Değerler";
            myPane.Border.IsVisible = false;
            myPane.Legend.Position = LegendPos.TopCenter;
            myPane.Title.IsVisible = false;

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zg1.AxisChange();

        }

       
        private void zedgraph_Load(object sender, EventArgs e)
        {
            graphOlustur(zedGraphControl1); // oluşturduğumuz fonksiyonu bu form açılırken çağırıyoruz.
        }
        int m;
        int Mouse_X;
        int Mouse_Y;

        private void zedgraph_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void zedgraph_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void zedgraph_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
