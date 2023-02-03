using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BaseDAO
    {
        // Ana veritabanı erişim sınıfımız.
        // Farklı veritabanlarını bu sınıf ile kalıtım aldırıp  bu metotların içlerini veritabanları için oluşturduğumuz sınıflarda dolduracağız.
        

        private String connectionString; // bağlantı stringimiz için değişken oluşturduk
        public BaseDAO(String connectionString)
        {
            this.connectionString = connectionString; // bağlantı stringimizi constructor yardımıyla alıyoruz.
        }

        // Buradaki metotları method overriding yapabilmek için virtual tanımlıyoruz ve içerisinde bi işlem yapmacağımız için boş bırakıyoruz.

        /// Öğrenci tablosu metodları ///

        // Öğrenci ekleme işlemi
        public virtual void ogrenci_ekle(String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet) // ekleme metodumuz
        {

        }
        // Öğrenci silme işlemi
        public virtual void ogrenci_sil(int ogrenci_id)
        {

        }
        // Öğrenci güncelleme işlemi
        public virtual void ogrenci_guncelle(int ogrenci_id, String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet)
        {

        }
        // Öğrenci bilgilerini listeleme işlemi
        public virtual DataSet ogrenci_listele()
        {
            return null;
        }
        // Öğrenciyi adı veya tc numarası ile arama işlemi
        public virtual DataSet ogrenci_ara(String adi_veya_tcNo)
        {
            return null;
        }
        // Öğrenci var mı kontrol işlemi (tc)
        public virtual Boolean ogrenci_varMi_tcNo(String ogrenci_tcNo)
        {
            return true;
        }
        // Öğrenci var mı kontrol işlemi (okulno)
        public virtual Boolean ogrenci_varMi_okulNo(String ogrenci_okulNo)
        {
            return true;
        }



        /// Kitaplar Tablosu Metodları ///

        // Ekleme metodu
        public virtual void kitap_ekle(String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi, int kitap_adeti)
        {

        }
        // Güncelleme metodu
        public virtual void kitap_guncelle(int kitap_id, String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi, int kitap_adeti)
        {

        }
        // Listeleme metodu
        public virtual DataSet kitap_listele()
        {
            return null;
        }
        // Kitap arama metodu
        public virtual DataSet kitap_ara(String id_veya_adi)
        {
            return null;  
        }
        // Kitap var mı kontrol(tüm parametrelere göre)
        public virtual Boolean kitap_varMi(String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi)
        {
            return true;
        }
        // Silme metodu(kitap id)
        public virtual void kitap_sil(int kitap_id)
        {

        }
        //Ödünç tablosunda kitap var mı kontrol
        public virtual Boolean odunc_kitap_varMi(int kitap_id) // kitap silerken bu kitap ödünç listesinde var mı diye kontrol edecek.
        {
            return true;
        }
        // Ödünç tablosunda bu öğrenci var mı kontrol
        public virtual Boolean odunc_ogrenci_varMi(int ogrenci_id) // öğrenci silerken bu  öğrenci ödünç listesinde var mı diye kotnrol edecek.
        {
            return true;
        }
        public virtual Boolean kitap_sayisi_kontrolEt(int kitap_id)
        {
            return true;
        }



        /// Ödünç Tablosu Metodları ///

        // Ödünç eklerken öğrenciid ve kitapid alıyoruz ayrıyetten ödünç alma tarihinide ekiyoruz(ödünç tablosuna)
        public virtual void odunc_ekle(int ogrenci_id, int kitap_id, String odunc_alma_tarihi)
        {

        }
        // tüm ödünçleri listelediğimiz metod
        public virtual DataSet odunc_listele()
        {
            return null;
        }
        // Kitabı teslim edince güncellediğimiz tarih
        public virtual void odunc_teslim_tarihi_guncelle(int odunc_id, String odunc_teslim_tarihi)
        {

        }
        // Öğrenci tablosundakiöğrencinin borcunu güncelleyeceğimiz metod
        public virtual void ogrenci_borc_guncelle(int ogrenci_id, int ogrenci_borc)
        {

        }
        // Ödünç tablosundaki borcu güncelleyeceğimiz metod
        public virtual void odunc_ogrenci_borc_guncelle(int ogrenci_id, int odunc_ogrenci_borc)
        {

        }
        // kitap iade edilirse kitap adetini 1 arttırır
        public virtual void odunc_kitap_adet_arttir(int kitap_id)
        {

        }
        // kitap ödünç alınırsa kitap adetini 1 adet azaltır
        public virtual void odunc_kitap_adet_azalt(int kitap_id)
        {

        }
        // öğrencinin aldığı kitapları listeleyen metod
        public virtual DataSet odunc_ogrenci_listele(int ogrenci_id)
        {
            return null;
        }
        // ödünç kitapları listeleyen metod
        public virtual DataSet odunc_kitap_listele(int kitap_id)
        {
            return null;
        }
        // öğrencinin iade etmediği kitap varsa yeni kitap verilmeyecek
        public virtual Boolean odunc_teslim_edildiMi(int ogrenci_id)
        {
            return true;
        }
        // kitabı teslim etmeyen var mı kontrol işlemi
        public virtual Boolean odunc_kitap_teslim_edildiMi(int kitap_id)
        {
            return true;
        }
        // ödünç id kontrol iade edilmiş mi edilmemiş mi
        public virtual Boolean odunc_id_teslim_edildiMi(int odunc_id)
        {
            return true;
        }
        // eğer öğrenci kitabı teslim etmediyse öğrencinin gecikme süresini hesaplayacağız
        public virtual int odunc_teslim_zaman_kontrol(int odunc_id)
        {
            return 0;
        }
        // ödünç tablosundan öğrenciyi siliyoruz
        public virtual void odunc_ogrenci_sil(int ogrenci_id)
        {

        }
        // ödünç tablosundan kitabı siliyoruz
        public virtual void odunc_kitap_sil(int kitap_id)
        {

        }
        // ödünç tablosunda arama işlemi yapıyoruz
        public virtual DataSet odunc_ara(String id_ad_isim)
        {
            return null;
        }



        /// Zedgraph işlemleri için metodlar ///

        // Kitaplar tablosundaki toplam kitap sayısını alacağız
        public virtual int kitap_sayisi()
        {
            return 0;
        }
        public virtual int ogrenci_sayisi()
        {
            return 0;
        }
        // Ödünç tablosundaki toplam ödünç alınan kitap sayısını alacağız
        public virtual int odunc_alinan_kitap_sayisi()
        {
            return 0;
        }
        // Ödünç tablosundaki teslim edilmeyen kitap sayısını alacağız
        public virtual int odunc_teslim_edilmeyen_kitap_sayisi()
        {
            return 0;
        }
        // öğrencinin kaç tane ödünç kitap aldığını sayacak.
        public virtual int odunc_ogrenci_kitap_sayisi(int ogrenci_id)
        {
            return 0;
        }// kitabın kaç tane öğrenciye verildiğinin sayısını döndürecek.
        public virtual int odunc_kitap_ogrenci_sayisi(int kitap_id)
        {
            return 0;
        }

    }
}
