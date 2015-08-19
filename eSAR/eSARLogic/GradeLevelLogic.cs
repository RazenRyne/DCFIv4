using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARDAL;
using eSARBDO;
namespace eSARLogic
{
    public class GradeLevelLogic
    {
        GradeLevelDAO gdao = new GradeLevelDAO();
        public List<GradeLevelBDO> GetAllGradeLevels() {
            return gdao.GetAllGradeLevels();
        }
    }
}
