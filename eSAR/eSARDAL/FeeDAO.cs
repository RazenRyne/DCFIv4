using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;
namespace eSARDAL
{
    public class FeeDAO
    {
        public List<FeeBDO> GetAllFees()
        {
            List<Fee> fList = new List<Fee>();
            using (var DCEnt = new DCFIEntities())
            {
                var allFees = (DCEnt.Fees);
                fList = allFees.ToList<Fee>();
            }

            List<FeeBDO> fBDOList = new List<FeeBDO>();
            foreach (Fee f in fList)
            {
                FeeBDO fBDO = new FeeBDO();
                ConvertFeeToFeeBDO(f, fBDO);
                fBDOList.Add(fBDO);
            }
            return fBDOList;
        }

        

        public Boolean CreateFee(ref FeeBDO fBDO, ref string message)
        {
            message = "Fee Added Successfully";
            bool ret = true;

            Fee f = new Fee();
            ConvertFeeBDOToFee(fBDO, f);
            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.Fees.Attach(f);
                DCEnt.Entry(f).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "Adding of Fee failed";
                }
            }
            return ret;
        }



        public Boolean UpdateFee(ref FeeBDO fBDO, ref string message)
        {
            message = "Fee updated successfully.";
            Boolean ret = true;
            using (var DCEnt = new DCFIEntities())
            {
                var fCode = fBDO.FeeCode;
                Fee fInDB = (from f in DCEnt.Fees
                                    where f.FeeCode == fCode
                                    select f).FirstOrDefault();
                if (fInDB == null)
                {
                    throw new Exception("No Fee " + fBDO.FeeCode);
                }
                DCEnt.Fees.Remove(fInDB);
                fInDB.Deactivated = fBDO.Deactivated;
                fInDB.FeeCode = fBDO.FeeCode;
                fInDB.FeeDescription = fBDO.FeeDescription;
                fInDB.Unit = fBDO.Unit;
                fInDB.Amount = fBDO.Amount;
                fInDB.DateSet = fBDO.DateSet;
                fInDB.GradeLevel = fBDO.GradeLevel;
                fInDB.SYImplemented = fBDO.SYImplemented;

                DCEnt.Fees.Attach(fInDB);
                DCEnt.Entry(fInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "No fee is updated.";
                }
            }
            return ret;

        }


        private void ConvertFeeToFeeBDO(Fee f, FeeBDO fBDO)
        {
            fBDO.Deactivated = f.Deactivated;
            fBDO.FeeCode = f.FeeCode;
            fBDO.FeeDescription = f.FeeDescription;
            fBDO.Unit = f.Unit;
            fBDO.Amount = f.Amount;
            fBDO.DateSet = f.DateSet;
            fBDO.GradeLevel = f.GradeLevel;
            fBDO.SYImplemented = f.SYImplemented;
        }

        private void ConvertFeeBDOToFee(FeeBDO fbdo, Fee f)
        {
            f.Deactivated = fbdo.Deactivated;
            f.FeeCode = fbdo.FeeCode;
            f.FeeDescription = fbdo.FeeDescription;
            f.Unit = fbdo.Unit;
            f.Amount = fbdo.Amount;
            f.DateSet = fbdo.DateSet;
            f.GradeLevel = fbdo.GradeLevel;
            f.SYImplemented = fbdo.SYImplemented;
        }
    }
}
