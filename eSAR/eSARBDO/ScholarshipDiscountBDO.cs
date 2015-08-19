using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSARBDO
{
    public class ScholarshipDiscountBDO
    {
        public string ScholarshipFeeCode { get; set; }
        public string ScholarshipCode { get; set; }
        public string FeeCode { get; set; }
        public Nullable<double> Discount { get; set; }
        public bool Deactivated { get; set; }

        public virtual FeeBDO Fee { get; set; }
        public virtual ScholarshipBDO Scholarship { get; set; }
    }
}
