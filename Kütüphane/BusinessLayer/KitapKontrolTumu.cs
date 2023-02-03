using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLayer
{
   public class KitapKontrolTumu:KitapKontrol
    {
        public override Boolean checkBook(BaseDAO baseDAO, String kitap_ismi, String kitap_turu, String kitap_yazari, String kitap_yayinevi, int kitap_sayfasi)
        {
            return baseDAO.kitap_varMi(kitap_ismi, kitap_turu, kitap_yazari, kitap_yayinevi, kitap_sayfasi);
        }
    }
}
