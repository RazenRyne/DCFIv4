using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSARBDO
{
    public class GradeLevelBDO
    {
        List<TraitBDO> traits = new List<TraitBDO>();
        List<FeeBDO> studFees = new List<FeeBDO>();
        public string GradeLev{ get; set; }
        public string Description { get; set; }
        public List<FeeBDO> StudentFees {
            get { return studFees; }
            set { studFees = value; }
        }
        public List<TraitBDO> Traits {
            get { return this.traits; }
            set { this.traits = value; }
        }
    }
}
