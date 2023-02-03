using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AccessDAO : BaseDAO // AccessDAO ya erişebilmek için kalıtım alıyoruz.
    {
    
        // Access bağlantısı için komutları tanımlıyoruz
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter adapter;
        OleDbDataReader dataReader;


        /// Veritabanı bağlantısı için constructor yardımıyla bağlantı stringimizi alıyoruz. ///

        // constructor olarak üst sınıfın constructoruna erişerek BaseDAO nun connectionStringini atadık.
        public AccessDAO(String connectionString) : base(connectionString)
        {
            baglanti = new OleDbConnection(connectionString);
        }


        /// Ogrenci ///

        // Başlangıç olarak öğrenci borcuna 0 ekledik.
        public override void ogrenci_ekle(String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet) // override edilmiş ekle metodumuz. 
        {
            baglanti.Open();
            komut = new OleDbCommand("insert into Ogrenci (ogrenci_adi, ogrenci_soyadi, ogrenci_bolumu, ogrenci_tcNo, ogrenci_okulNo, ogrenci_cinsiyet) " +
                                                "values (@ogrenci_adi, @ogrenci_soyadi, @ogrenci_bolumu, @ogrenci_tcNo, @ogrenci_okulNo, @ogrenci_cinsiyet)", baglanti);
            komut.Parameters.AddWithValue("@ogrenci_adi", ogrenci_adi);
            komut.Parameters.AddWithValue("@ogrenci_soyadi", ogrenci_soyadi);
            komut.Parameters.AddWithValue("@ogrenci_bolumu", ogrenci_bolumu);
            komut.Parameters.AddWithValue("@ogrenci_tcNo", ogrenci_tcNo);
            komut.Parameters.AddWithValue("@ogrenci_okulNo", ogrenci_okulNo);
            komut.Parameters.AddWithValue("@ogrenci_cinsiyet", ogrenci_cinsiyet);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // Öğrenci Silme İşlemi
        public override void ogrenci_sil(int ogrenci_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("delete * from Ogrenci where ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("@ogrenci_id", ogrenci_id);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        // Öğrenci Güncelleme İşlemi
        public override void ogrenci_guncelle(int ogrenci_id, String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Ogrenci set ogrenci_adi = '" + ogrenci_adi + "', ogrenci_soyadi = '" + ogrenci_soyadi + "', ogrenci_bolumu = '" + ogrenci_bolumu + "', ogrenci_tcNo = '" + ogrenci_tcNo + "', ogrenci_okulNo = '" + ogrenci_okulNo + "', ogrenci_cinsiyet = '" + ogrenci_cinsiyet + "'  where ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("ogrenci_id", ogrenci_id.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // Öğrenci Listeleme İşlemi
        public override DataSet ogrenci_listele()
        {
            baglanti.Open();
            DataSet dataSet = new DataSet();
            adapter = new OleDbDataAdapter("select * from Ogrenci", baglanti);
            adapter.Fill(dataSet);
            baglanti.Close();
            return dataSet;
        }
        // Öğrenci Arama İşlemi tc no veya isme göre listeleyeceğiz
        public override DataSet ogrenci_ara(String adi_veya_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Ogrenci where ogrenci_adi like '%" + adi_veya_id + "%' or ogrenci_tcNo like '%" + adi_veya_id + "%' ", baglanti);
            adapter = new OleDbDataAdapter(komut);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            baglanti.Close();
            return dataSet;
        }
        //Öğrenci var mı yok mu kontrol işlemi tc ye göre
        public override Boolean ogrenci_varMi_tcNo(string ogrenci_tcNo)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select ogrenci_tcNo from Ogrenci where ogrenci_tcNo = '" + ogrenci_tcNo + "'", baglanti);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }
        // Aynı okul nosu var mı kontrol
        public override Boolean ogrenci_varMi_okulNo(string ogrenci_okulNo)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select ogrenci_okulNo from Ogrenci where ogrenci_okulNo = '" + ogrenci_okulNo + "'", baglanti);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }


        }


        



        


        /// Kitap İşlemleri ///

        // Kitap ekleme işlemi (access veritabanı).
        public override void kitap_ekle(String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi, int kitap_adeti)
        {
            baglanti.Open();
            komut = new OleDbCommand("insert into Kitaplar (kitap_ismi, kitap_turu, kitap_yazari, kitap_yayinevi, kitap_sayfasi, kitap_adeti) " +
                                                "values (@kitap_ismi, @kitap_turu, @kitap_yazari, @kitap_yayinevi, @kitap_sayfasi, @kitap_adeti)", baglanti);
            komut.Parameters.AddWithValue("@kitap_ismi", kitap_ismi);
            komut.Parameters.AddWithValue("@kitap_turu", kitap_turu);
            komut.Parameters.AddWithValue("@kitap_yazari", kitap_yazari);
            komut.Parameters.AddWithValue("@kitap_yayinevi", kitap_yayinevi);
            komut.Parameters.AddWithValue("@kitap_sayfasi", kitap_sayfasi);
            komut.Parameters.AddWithValue("@kitap_adeti", kitap_adeti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // Kitap listeleme işlemi
        public override DataSet kitap_listele()
        {

            baglanti.Open();
            DataSet dataSet = new DataSet();
            adapter = new OleDbDataAdapter("select * from Kitaplar", baglanti);
            adapter.Fill(dataSet);
            baglanti.Close();
            return dataSet;
        }
        // Access veritabanında kitap güncelleme işlemi.
        public override void kitap_guncelle(int kitap_id, String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi, int kitap_adeti)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Kitaplar set kitap_ismi = '" + kitap_ismi + "', kitap_turu = '" + kitap_turu + "', kitap_yazari = '" + kitap_yazari + "', kitap_yayinevi = '" + kitap_yayinevi + "', kitap_sayfasi = '" + kitap_sayfasi + "', kitap_adeti = '" + kitap_adeti + "'  where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("kitap_id", kitap_id.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // Filtrelemeli kitap arama işlemi
        public override DataSet kitap_ara(String id_veya_ismi)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Kitaplar where kitap_id like '%" + id_veya_ismi + "%' or kitap_ismi like '%" + id_veya_ismi + "%'", baglanti);
            adapter = new OleDbDataAdapter(komut);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            baglanti.Close();
            return dataSet;
        }
        // Parametreleri kontrol edecek (aynı kitap var mı yok mu).
        public override Boolean kitap_varMi(string kitap_ismi, string kitap_turu, string kitap_yazari, string kitap_yayinevi, int kitap_sayfasi)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Kitaplar where kitap_ismi = @kitap_ismi and kitap_turu = @kitap_turu and kitap_yazari = @kitap_yazari and kitap_yayinevi = @kitap_yayinevi and kitap_sayfasi = @kitap_sayfasi", baglanti);
            komut.Parameters.AddWithValue("kitap_ismi", kitap_ismi);
            komut.Parameters.AddWithValue("kitap_turu", kitap_turu);
            komut.Parameters.AddWithValue("kitap_yazari", kitap_yazari);
            komut.Parameters.AddWithValue("kitap_yayinevi", kitap_yayinevi);
            komut.Parameters.AddWithValue("kitap_sayfasi", kitap_sayfasi);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }
        // Kitap Silme İşlemi

        public override void kitap_sil(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("delete * from Kitaplar where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("@kitap_id", kitap_id.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //Stokta kitap var mı yok mu.
        public override Boolean kitap_sayisi_kontrolEt(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Kitaplar where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("odunc_id", kitap_id);
            dataReader = komut.ExecuteReader();

            int kitap_sayisi = 0;

            while (dataReader.Read()) // odunc_alma_tairhi bilgisini oluşturduğumuz DateTime nesnesine aktarıyoruz.
            {
                kitap_sayisi = int.Parse(dataReader["kitap_adeti"].ToString());
            }

            baglanti.Close();

            if (kitap_sayisi > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public override Boolean odunc_kitap_varMi(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("@kitap_id", kitap_id);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }
        //Ödünç tablosunda öğrenci var mı yok mu kontrol
        public override Boolean odunc_ogrenci_varMi(int ogrenci_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("@ogrenci_id", ogrenci_id);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }



        /// Ödünç İşlemleri ///

        // Teslim tarihinde Teslim edilmedi yazacak ve Borç başlangıç olarak 0 olacak.
        public override void odunc_ekle(int ogrenci_id, int kitap_id, String odunc_alma_tarihi)

        {
            baglanti.Open();
            komut = new OleDbCommand("insert into Odunc (ogrenci_id, kitap_id, odunc_alma_tarihi, odunc_teslim_tarihi, odunc_ogrenci_borc) " +
                                                "values (@ogrenci_id, @kitap_id, @odunc_alma_tarihi, @odunc_teslim_tarihi, @odunc_ogrenci_borc)", baglanti);
            komut.Parameters.AddWithValue("@ogrenci_id", ogrenci_id);
            komut.Parameters.AddWithValue("@kitap_id", kitap_id);
            komut.Parameters.AddWithValue("@odunc_alma_tarihi", odunc_alma_tarihi);
            komut.Parameters.AddWithValue("@odunc_teslim_tarihi", "Teslim edilmedi");
            komut.Parameters.AddWithValue("@odunc_ogrenci_borc", 0);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //Dataset dönecek
        public override DataSet odunc_listele()
        {
            baglanti.Open();
            DataSet dataSet = new DataSet();
            adapter = new OleDbDataAdapter("Select * from Odunc", baglanti);
            adapter.Fill(dataSet);
            baglanti.Close();
            return dataSet;
        }
        // Teslim Tarihi güncelleyecek
        public override void odunc_teslim_tarihi_guncelle(int odunc_id, String odunc_teslim_tarihi)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Odunc set odunc_teslim_tarihi = @odunc_teslim_tarihi where odunc_id = @odunc_id", baglanti);
            komut.Parameters.AddWithValue("odunc_teslim_tarihi", odunc_teslim_tarihi);
            komut.Parameters.AddWithValue("odunc_id", odunc_id);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        // Öğrencinin borcu güncellenecek (öğrenci tablosundaki).
        public override void ogrenci_borc_guncelle(int ogrenci_id, int ogrenci_borc)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Ogrenci set ogrenci_borc = @ogrenci_borc where ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("ogrenci_borc", ogrenci_borc);
            komut.Parameters.AddWithValue("ogrenci_id", ogrenci_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //Ödünç tablosundaki öğrencinin borcunu güncelleyecek
        public override void odunc_ogrenci_borc_guncelle(int odunc_id, int odunc_ogrenci_borc)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Odunc set odunc_ogrenci_borc = @odunc_ogrenci_borc where odunc_id = @odunc_id", baglanti);
            komut.Parameters.AddWithValue("odunc_ogrenci_borc", odunc_ogrenci_borc);
            komut.Parameters.AddWithValue("odunc_id", odunc_id);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        // Ödünç iade işlemi yapıldıysa stok sayısı artacak
        public override void odunc_kitap_adet_arttir(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Kitaplar set kitap_adeti = kitap_adeti+1 where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("kitap_id", kitap_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // Kitap ödünç alındıysa stoktaki kitap 1 düşecek
        public override void odunc_kitap_adet_azalt(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("update Kitaplar set kitap_adeti = kitap_adeti-1 where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("kitap_id", kitap_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // Ödünç tablosundaki bu kitaba ait ödünç verme bilgileri listenecek.
        public override DataSet odunc_kitap_listele(int kitap_id)
        {
            baglanti.Open();
            DataSet dataSet = new DataSet();
            adapter = new OleDbDataAdapter("select * from Odunc where kitap_id =" + kitap_id + " ", baglanti);
            adapter.Fill(dataSet);
            //dataGridView1.DataSource = dataSet.Tables[0]; // 0. indisten itibaren bana verileri doldur
            baglanti.Close();
            return dataSet;
        }
        // Ödünç tablosunda bu öğrenciye ait ödünç alma bilgileri listenecek
        public override DataSet odunc_ogrenci_listele(int ogrenci_id)
        {
            baglanti.Open();
            DataSet dataSet = new DataSet();
            adapter = new OleDbDataAdapter("select * from Odunc where ogrenci_id =" + ogrenci_id + " ", baglanti);
            adapter.Fill(dataSet);
            baglanti.Close();
            return dataSet;
        }
        // Ödünç işlemi oldu mu olmadı mı kontrol işlemi
        public override Boolean odunc_teslim_edildiMi(int ogrenci_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where odunc_teslim_tarihi = @odunc_teslim_tarihi and ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("odunc_teslim_tarihi", "Teslim edilmedi");
            komut.Parameters.AddWithValue("ogrenci_id", ogrenci_id);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return false;
            }
            else
            {
                baglanti.Close();
                return true;
            }
        }
        // Kitabı teslim etmeyen öğrenciler
        
        public override Boolean odunc_kitap_teslim_edildiMi(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where odunc_teslim_tarihi = @odunc_teslim_tarihi and kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("odunc_teslim_tarihi", "Teslim edilmedi");
            komut.Parameters.AddWithValue("kitap_id", kitap_id);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return false;
            }
            else
            {
                baglanti.Close();
                return true;
            }
        }
        // Ödünç ID teslim edildi mi edilmedi mi
      
        public override Boolean odunc_id_teslim_edildiMi(int odunc_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where odunc_teslim_tarihi = @odunc_teslim_tarihi and odunc_id = @odunc_id", baglanti);
            komut.Parameters.AddWithValue("odunc_teslim_tarihi", "Teslim edilmedi");
            komut.Parameters.AddWithValue("odunc_id", odunc_id);
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                baglanti.Close();
                return false;
            }
            else
            {
                baglanti.Close();
                return true;
            }
        }
        // Teslim Tarihi Kontrol
        public override int odunc_teslim_zaman_kontrol(int odunc_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where odunc_id = @odunc_id", baglanti);
            komut.Parameters.AddWithValue("odunc_id", odunc_id);
            dataReader = komut.ExecuteReader();

            DateTime odunc_alma_tarihi = new DateTime();
            DateTime odunc_teslim_tarihi = new DateTime(); // bugünün zamanı ile teslim alınan zamanı karşılaştıracağımız DateTime

            odunc_teslim_tarihi = DateTime.Parse(DateTime.Now.ToString("d")); // bugünü atıyoruz

            while (dataReader.Read()) // odunc_alma_tairhi bilgisini oluşturduğumuz DateTime nesnesine aktarıyoruz.
            {
                odunc_alma_tarihi = DateTime.Parse(dataReader["odunc_alma_tarihi"].ToString());
            }
            TimeSpan span = odunc_teslim_tarihi.Subtract(odunc_alma_tarihi); // iki tarih arasındaki farkı alıyoruz.

            baglanti.Close();

            return int.Parse(span.TotalDays.ToString()); // kitabı aldıktan sonra kaç gün geçtiğinin bilgisi
        }
        // Ödünç tablosundaki öğrenci silme işlemi
        public override void odunc_ogrenci_sil(int ogrenci_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("delete * from Odunc where ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("@ogrenci_id", ogrenci_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // Ödünç tablosundaki kitabı silme işlemi
        public override void odunc_kitap_sil(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("delete * from Odunc where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("@kitap_id", kitap_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        // Ödünç arama işlemi (filtreleyerek)
        public override DataSet odunc_ara(String id_ad_isim)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select * from Odunc where odunc_id like '%" + id_ad_isim + "%' or ogrenci_id like '%" + id_ad_isim + "%' or kitap_id like '%" + id_ad_isim + "%'", baglanti);
            adapter = new OleDbDataAdapter(komut);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            baglanti.Close();
            return dataSet;
        }




        /// Zedgraph sayma işlemi ///

        // Kütüphanedeki tüm kitapların sayısı
        public override int kitap_sayisi()
        {
            baglanti.Open();
            komut = new OleDbCommand("Select count(*) from Kitaplar", baglanti);
            dataReader = komut.ExecuteReader();

            int sayi = 0;
            while (dataReader.Read())
            {
                sayi = int.Parse(dataReader[0].ToString()); 
            }

            baglanti.Close();

            return sayi;
        }
        // Kütüphandeki tüm öğrencilerin sayısı
        public override int ogrenci_sayisi()
        {
            baglanti.Open();
            komut = new OleDbCommand("Select count(*) from Ogrenci", baglanti);
            dataReader = komut.ExecuteReader();

            int sayi = 0;
            while (dataReader.Read())
            {
                sayi = int.Parse(dataReader[0].ToString()); 
            }

            baglanti.Close();

            return sayi;
        }
        // Bugüne kadar kütüphanede kaç tane kitap alındı
        public override int odunc_alinan_kitap_sayisi()
        {
            baglanti.Open();
            komut = new OleDbCommand("Select count(*) from Odunc", baglanti);
            dataReader = komut.ExecuteReader();

            int sayi = 0;
            while (dataReader.Read())
            {
                sayi = int.Parse(dataReader[0].ToString());
            }
            baglanti.Close();

            return sayi;
        }
        // Teslim edilmemiş kitap sayısı
        public override int odunc_teslim_edilmeyen_kitap_sayisi()
        {
            baglanti.Open();
            komut = new OleDbCommand("Select count(*) from Odunc where odunc_teslim_tarihi = @odunc_teslim_tarihi", baglanti);
            komut.Parameters.AddWithValue("odunc_teslim_tarihi", "Teslim edilmedi");
            dataReader = komut.ExecuteReader();

            int sayi = 0;
            while (dataReader.Read())
            {
                sayi = int.Parse(dataReader[0].ToString());
            }

            baglanti.Close();

            return sayi;
        }
        // Bu öğrenci kaç kitap aldı bilgisi
        public override int odunc_ogrenci_kitap_sayisi(int ogrenci_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select count(*) from Odunc where ogrenci_id = @ogrenci_id", baglanti);
            komut.Parameters.AddWithValue("ogrenci_id", ogrenci_id);
            dataReader = komut.ExecuteReader();

            int sayi = 0;
            while (dataReader.Read())
            {
                sayi = int.Parse(dataReader[0].ToString());
            }

            baglanti.Close();

            return sayi;
        }
        // Bu kitabı kaç tane öğrenci ödünç aldı bilgisi
        public override int odunc_kitap_ogrenci_sayisi(int kitap_id)
        {
            baglanti.Open();
            komut = new OleDbCommand("Select count(*) from Odunc where kitap_id = @kitap_id", baglanti);
            komut.Parameters.AddWithValue("kitap_id", kitap_id);
            dataReader = komut.ExecuteReader();

            int sayi = 0;
            while (dataReader.Read())
            {
                sayi = int.Parse(dataReader[0].ToString());
            }

            baglanti.Close();

            return sayi;
        }
      
      

    }
}