using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSARBDO
{
    public class ScholarshipBDO
    {
        List<ScholarshipDiscountBDO> scholarDiscounts = new List<ScholarshipDiscountBDO>();
        List<StudentBDO> scholars = new List<StudentBDO>();
        public string ScholarshipCode { get; set; }
        public string Description { get; set; }
        public string Privilege { get; set; }
        public string Condition { get; set; }
        public bool Deactivated { get; set; }

        public List<ScholarshipDiscountBDO> ScholarshipDiscounts
        {
            get { return scholarDiscounts; }
            set { scholarDiscounts = value; }
        }

        public List<StudentBDO> Scholars
        {
            get { return scholars; }
            set { scholars = value; }
        }
    }

}
