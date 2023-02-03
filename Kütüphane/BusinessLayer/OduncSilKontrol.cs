using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLayer
{
   public class OduncSilKontrol:OduncKontrol
    {
        public override Boolean borrowedCheck(BaseDAO baseDAO, int id, int tip)
        {
            if (tip == 1)
            {
                return baseDAO.odunc_kitap_varMi(id); // kitap varsa true döndürür
                //kitap yoksa false döner
            }
            else
            {
                return baseDAO.odunc_ogrenci_varMi(id); // öğrenci varsa true döndürür
                //öğrenci yoksa false döndürür
            }
        }
    }
}
