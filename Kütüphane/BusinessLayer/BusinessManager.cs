using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace BusinessLayer
{
    public class BusinessManager
    {
        // Programın işlemlerini Business katmanında yapacağız 
        // Presentation Layer(Sunum) katmanında buradaki işlemleri çağıracağız

        private BaseDAO baseDAO; // İstedigimiz veritabanını new xDAO(connectionString) şeklinde gonderecegiz.
        private OgrenciKontrol studentCheck;    // Öğrenci kontrolü sağlayacak
        private KitapKontrol bookCheck;        // Kitap kontrolü sağlayacak
        private OduncKontrol borrowedCheck;   // Ödünç kontrolü sağlayacak



        // Constructor kullanarak yapacağımız veritabanı ve kontrol işlemleri
        public BusinessManager  (BaseDAO baseDAO, OgrenciKontrol studentCheck, KitapKontrol bookCheck, OduncKontrol borrowedCheck)
        {
            this.baseDAO = baseDAO;
            this.studentCheck = studentCheck;
            this.bookCheck = bookCheck;
            this.borrowedCheck = borrowedCheck;
        }

        ///  Öğrenci İşlemlerini aşağıdaki satırlarda yapacağız  ///


        // Öğrenci kontrolünü student check ile sağlayacağız bu işlem aynı öğrenciyi eklemeyi engelleyecek 
        
        public Boolean ogrenci_ekle(String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet)
        {
            if (studentCheck.checkStudent(baseDAO, ogrenci_adi, ogrenci_soyadi, ogrenci_bolumu, ogrenci_tcNo, ogrenci_okulNo, ogrenci_cinsiyet))
            {
                return true;
            }
            else
            {
                baseDAO.ogrenci_ekle(ogrenci_adi, ogrenci_soyadi, ogrenci_bolumu, ogrenci_tcNo, ogrenci_okulNo, ogrenci_cinsiyet);
                return false;
            }

        }
        // Öğrenci silineceği zaman OduncKontrol ile ödunc tablosu ile kontrol sağlanacak (Öğrencinin aldığı kitap varsa silme işlemi yapılmayacak bunu daha sonra messagebox kontrolü ile emin misiniz şeklinde soracağız)
      
        public Boolean ogrenci_sil(int ogrenci_id)
        {
            if (borrowedCheck.borrowedCheck(baseDAO, ogrenci_id, 2))
            {
                return true;
            }
            else
            {
                baseDAO.ogrenci_sil(ogrenci_id);
                return false;
            }
        }
        // Öğrenci güncelleme işlemlerini yapacağımız kısım
        public Boolean ogrenci_guncelle(int ogrenci_id, String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet)
        {
            baseDAO.ogrenci_guncelle(ogrenci_id, ogrenci_adi, ogrenci_soyadi, ogrenci_bolumu, ogrenci_tcNo, ogrenci_okulNo, ogrenci_cinsiyet);
            return false;
        }
        // Öğrenci adı ve id ye göre filtrelemeli arama yapacağız
        public DataSet ogrenci_ara(String id_veya_adi)
        {
            return baseDAO.ogrenci_ara(id_veya_adi);
        }
        // Bütün öğrencileri listeleyecek.
        public DataSet ogrenci_listele()
        {
            return baseDAO.ogrenci_listele();
        }

        ///  Kitap İşlemlerimiz  ///

        // Kitap kontrolünü bookcheck ile sağlayacağız bu işlem aynı kitabı eklemeyi engelleyecek

        public Boolean kitap_ekle(String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi, int kitap_adeti)
        {
            if (bookCheck.checkBook(baseDAO, kitap_ismi, kitap_turu, kitap_yazari, kitap_yayinevi, kitap_sayfasi))
            {
                return true;
            }
            else
            {
                baseDAO.kitap_ekle(kitap_ismi, kitap_turu, kitap_yazari, kitap_yayinevi, kitap_sayfasi, kitap_adeti);
                return false;
            }

        }
        // Tüm kitaplar listelenecek.
        public DataSet kitap_listele()
        {
            return baseDAO.kitap_listele();
        }
        // Kitap güncelleme işlemlerini yaptığımız kısım
        public void kitap_guncelle(int kitap_id, String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi, int kitap_adeti)
        {

            baseDAO.kitap_guncelle(kitap_id, kitap_ismi, kitap_turu, kitap_yazari, kitap_yayinevi, kitap_sayfasi, kitap_adeti);


        }
        // Kitap adı ve id sine göre filtrelemeli  arama yapacağız.
        public DataSet kitap_ara(String id_veya_ismi)
        {
            return baseDAO.kitap_ara(id_veya_ismi);
        }
        
        // borrowedChecek ile eğer bu kitap daha önceden ödünç alındıysa yani ödünç tablosunda var ise kitabı silmez(true döndürür)
        
        public Boolean kitap_sil(int kitap_id)
        {
            if (borrowedCheck.borrowedCheck(baseDAO, kitap_id, 1))
            {
                return true;
            }
            else
            {
                baseDAO.kitap_sil(kitap_id);
                return false;
            }
        }

        //Kitap sayısını kontrol edeceğimiz kısım(BaseDAO)
        public Boolean kitap_sayisi_kontrolEt(int kitap_id)
        {
            return baseDAO.kitap_sayisi_kontrolEt(kitap_id);
        }



        ///  Ödünç Kitap İşlemleri  ///
        // Öğrenci kitap alacağı zaman eğer teslim edilmemiş bir kitabı bulunuyorsa kitap alamayacak ve false dönecek.
        // Öğrencinin teslim etmediği kitap bulunmuyorsa kitap alabilecek ve true dönecek.
        public Boolean odunc_ekle(int ogrenci_id, int kitap_id, String odunc_alma_tarihi)
        {
            if (baseDAO.odunc_teslim_edildiMi(ogrenci_id))
            {
                baseDAO.odunc_ekle(ogrenci_id, kitap_id, odunc_alma_tarihi);
                baseDAO.odunc_kitap_adet_azalt(kitap_id);
                return true;
            }
            else
            {
                return false;
            }
        }
        // Tüm Ödünç tablosu listelenecek.
        public DataSet odunc_listele()
        {
            return baseDAO.odunc_listele();
        }
        // Ödünç tablosundan istediğimiz öğrenciye ait ödünç alma bilgilerini yazdıracak.
        public DataSet odunc_ogrenci_listele(int ogrenci_id)
        {
            return baseDAO.odunc_ogrenci_listele(ogrenci_id);
        }
        // İstediğimiz kitaba ait ödünç alma bilgilerini yazdıracak.
        public DataSet odunc_kitap_listele(int kitap_id)
        {
            return baseDAO.odunc_kitap_listele(kitap_id);
        }
        //  Ödünç iadesi yaparken ilk olarak ,
        //  odunc_id ve odunc_teslim_tarihi ile ödünç tablosundaki teslim edilme tarihini güncelleyeceğiz.
        //  kitap_id ile teslim edilen kitabın stok sayısı 1 artacak.
        //  odunc_id ile ödünç tablosundaki ögrencinin borcunu sıfırlayacağız, ogrenci_id ile öğrenci tablosundaki ögrencinin borcunu sıfırlayacağız.

        
        public void odunc_iade(int odunc_id, int ogrenci_id, int kitap_id, String odunc_teslim_tarihi)
        {
            baseDAO.odunc_teslim_tarihi_guncelle(odunc_id, odunc_teslim_tarihi); //Ödünç teslim tarihini güncellemek için tarih güncelleme metodunu cağrıyoruz.
            baseDAO.odunc_kitap_adet_arttir(kitap_id);//Ödünç kitap adetini arttırmak için kitap adet arttır metodunu cağrıyoruz.
            baseDAO.odunc_ogrenci_borc_guncelle(odunc_id, 0);//Ödünç öğrenci borcunu güncellemek için öğrenci borç güncelleme metodunu çağrıyoruz.
            baseDAO.ogrenci_borc_guncelle(ogrenci_id, 0);//Öğrenci borcunu güncellemek için öğrenci borç güncelle metodunu cağrıyoruz.
        }
        // Eğer kitap teslim edilmezse teslim etme zamanını kontrol edeceğiz.
        public int odunc_teslim_zaman_kontrol(int odunc_id)
        {
            return baseDAO.odunc_teslim_zaman_kontrol(odunc_id);
        }
        // Öğrencinin kitabı teslim etti mi etmedi mi bilgisi için kontrol sağlaycağız.
        public Boolean odunc_teslim_edildiMi(int ogrenci_id)
        {
            if (baseDAO.odunc_teslim_edildiMi(ogrenci_id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Kitap teslimi yapmayan öğrenci var mı yok mu kontrol ediyoruz.
        public Boolean odunc_kitap_teslim_edildiMi(int kitap_id)
        {
            if (baseDAO.odunc_kitap_teslim_edildiMi(kitap_id))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Ödünç ID ye göre teslim edildi mi edilmedi mi kontrol
        public Boolean odunc_id_teslim_edildiMi(int odunc_id)
        {
            if (baseDAO.odunc_id_teslim_edildiMi(odunc_id))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Ödunç listesinden öğrenciyi siliyoruz
        public void odunc_ogrenci_sil(int ogrenci_id)
        {
            baseDAO.odunc_ogrenci_sil(ogrenci_id);
        }
        // Ödünç tablosundan kitabı siliyoruz
        public void odunc_kitap_sil(int kitap_id)
        {
            baseDAO.odunc_kitap_sil(kitap_id);
        }
        // Ödünç tablosundaki borcu güncelliyoruz
        public void odunc_ogrenci_borc_guncelle(int odunc_id, int odunc_ogrenci_borc)
        {
            baseDAO.odunc_ogrenci_borc_guncelle(odunc_id, odunc_ogrenci_borc);
        }
        // Öğrenci tablosundaki öğrencinin borcunu güncelliyoruz
        public void ogrenci_borc_guncelle(int ogrenci_id, int ogrenci_borc)
        {
            baseDAO.ogrenci_borc_guncelle(ogrenci_id, ogrenci_borc);
        }
        // Ödünç tablosunda id ye ve isme göre arama yapıyoruz
        public DataSet odunc_ara(String id_ad_isim)
        {
            return baseDAO.odunc_ara(id_ad_isim);
        }

        ///  Zedgraph işlemleri için metodlar (adet ve sayı miktarı)  ///

        //Kütüphanedeki toplam kitap sayısı
        public int ogrenci_sayisi_ogren()
        {
            return baseDAO.ogrenci_sayisi();
        }

        // Kütüphanedeki toplam kitap sayısı
        public int kitap_sayisi_ogren()
        {
            return baseDAO.kitap_sayisi();
        }
     
        // Ödünç alınan kitap sayısı
        public int odunc_alinan_kitap_sayisi()
        {
            return baseDAO.odunc_alinan_kitap_sayisi();
        }
        // Ödünç tablosunda olup teslim edilmeyen kitap sayısı
        public int odunc_teslim_edilmeyen_kitap_sayisi()
        {
            return baseDAO.odunc_teslim_edilmeyen_kitap_sayisi();
        }
        // Ödünç tablosunda olup teslim edilen kitap sayısı
        public int odunc_teslim_edilen_kitap_sayisi()
        {
            return odunc_alinan_kitap_sayisi() - odunc_teslim_edilmeyen_kitap_sayisi();
        }
        // öğrencinin kaç tane kitabı ödünç aldığı sayısını döndürecek.
        public int odunc_ogrenci_kitap_sayisi(int ogrenci_id)
        {
            return baseDAO.odunc_ogrenci_kitap_sayisi(ogrenci_id);
        }
        // bu kitabı kaç tane öğrencei aldığının sayısını döndürecek.
        public int odunc_kitap_ogrenci_sayisi(int kitap_id)
        {
            return baseDAO.odunc_kitap_ogrenci_sayisi(kitap_id);
        }
    }
}
