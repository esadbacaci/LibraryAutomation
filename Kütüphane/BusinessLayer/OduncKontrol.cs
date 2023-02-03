using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLayer
{
 public  class OduncKontrol
    {
        //Ödünç kontrol etmek için kulllandığımız metod
        public virtual Boolean borrowedCheck(BaseDAO baseDAO, int id, int tip)
        {
            return true;
        }
    }
}
