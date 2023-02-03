using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
   public class KitapKontrol
    {
        //Kitabı kontrol etmek için kullandığımız metod
        public virtual Boolean checkBook(BaseDAO baseDAO, String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi)
        {
            return true;
        }

    }
}
