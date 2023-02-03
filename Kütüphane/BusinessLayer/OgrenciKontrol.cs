using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class OgrenciKontrol
    {
        //öğrenci kontrol için kullandığımız metod
        public virtual Boolean checkStudent(BaseDAO baseDAO, String ogrenci_adi, String ogrenci_soyadi, String ogrenci_bolumu, String ogrenci_tcNo, String ogrenci_okulNo, String ogrenci_cinsiyet)
        {
            return true;
        }
    }
}
