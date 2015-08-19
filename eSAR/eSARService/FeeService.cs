using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARLogic;
using eSARBDO;

namespace eSARService
{
    public class FeeService : IFeeService
    {
        FeeLogic flogic = new FeeLogic();
        public bool CreateFee(ref Fee fee, ref string message)
        {
            FeeBDO fbdo = new FeeBDO();
            TranslateFeeToFeeBDO(fee, fbdo);
            return flogic.CreateFee(ref fbdo, ref message);
        }

        public List<Fee> GetAllFees()
        {
            List<Fee> flist = new List<Fee>();
            foreach (FeeBDO fbdo in flogic.GetAllFees())
            {
                Fee f = new Fee();
                TranslateFeeBDOToFee(fbdo, f);
                flist.Add(f);
            }
            return flist;
        }

        public bool UpdateFee(ref Fee fee, ref string message)
        {
            FeeBDO fbdo = new FeeBDO();
            TranslateFeeToFeeBDO(fee, fbdo);
            return flogic.UpdateFee(ref fbdo, ref message);
        }

        public void TranslateFeeBDOToFee(FeeBDO fbdo, Fee f) {
            f.Deactivated = fbdo.Deactivated;
            f.FeeCode = fbdo.FeeCode;
            f.FeeDescription = fbdo.FeeDescription;
            f.Unit = fbdo.Unit;
            f.Amount = fbdo.Amount;
            f.DateSet = fbdo.DateSet;
            f.GradeLevel = fbdo.GradeLevel;
            f.SYImplemented = fbdo.SYImplemented;
            
        }

        public void TranslateFeeToFeeBDO(Fee f, FeeBDO fbdo)
        {
            fbdo.Deactivated = f.Deactivated;
            fbdo.FeeCode = f.FeeCode;
            fbdo.FeeDescription = f.FeeDescription;
            fbdo.Unit = f.Unit;
            fbdo.Amount = f.Amount;
            fbdo.DateSet = f.DateSet;
            fbdo.GradeLevel = f.GradeLevel;
            fbdo.SYImplemented = f.SYImplemented;

        }

        public List<FeeBDO> ToFeeBDOList(List<Fee> fList) {
            List<FeeBDO> feeList = new List<FeeBDO>();
            foreach (Fee f in fList) {
                FeeBDO fbdo = new FeeBDO();
                TranslateFeeToFeeBDO(f, fbdo);
                feeList.Add(fbdo);
            }
            return feeList;
        }
    }
}
