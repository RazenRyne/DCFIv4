using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARDAL;
using eSARBDO;
namespace eSARLogic
{
    public class FeeLogic
    {
        FeeDAO fDao = new FeeDAO();
        public List<FeeBDO> GetAllFees() {
            return fDao.GetAllFees();
        }


        public Boolean CreateFee(ref FeeBDO fbdo, ref string message) {
            return fDao.CreateFee(ref fbdo, ref message);
        }

        public Boolean UpdateFee(ref FeeBDO fbdo, ref string message) {
            return fDao.UpdateFee(ref fbdo, ref message);
        }
    }

     
}
