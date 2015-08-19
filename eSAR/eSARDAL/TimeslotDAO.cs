using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSARBDO;

namespace eSARDAL
{
    public class TimeslotDAO
    {
        public TimeslotBDO GetTimeslotBDO(string timeslotCode)
        {
            TimeslotBDO timeslotBDO = null;
            using (var DCEnt = new DCFIEntities())
            {
                Timeslot timeslot = new Timeslot();
                    timeslot = (from t in DCEnt.Timeslots
                             where t.TimeSlotCode == timeslotCode
                             select t).FirstOrDefault();

                if (timeslot != null)
                {
                    timeslotBDO = new TimeslotBDO()
                    {
                        TimeSlotCode = timeslot.TimeSlotCode,
                        TimeStart = timeslot.TimeStart,
                        TimeEnd = timeslot.TimeEnd,
                        Days = timeslot.Days,
                        Deactivated = timeslot.Deactivated
                    };
                }
            }
            return timeslotBDO;
        }

        public Timeslot GetTimeSlot(string timeslotCode)
        {
            Timeslot timeslot = new Timeslot();
            timeslot = null;

            using (var DCEnt = new DCFIEntities())
            {
                timeslot = (from t in DCEnt.Timeslots
                        where t.TimeSlotCode == timeslotCode
                        select t).FirstOrDefault();

            }

            return timeslot;

        }

        public List<TimeslotBDO> GetAllTimeslot()
        {
            List<Timeslot> timeslotList = new List<Timeslot>();
            using (var DCEnt = new DCFIEntities())
            {
                var allTimeslot = (DCEnt.Timeslots);
                timeslotList = allTimeslot.ToList<Timeslot>();
            }

            List<TimeslotBDO> timeslotBDOList = new List<TimeslotBDO>();
            foreach (Timeslot t in timeslotList)
            {
                TimeslotBDO timeslotBDO = new TimeslotBDO();
                ConvertTimeslotToTimeslotBDO(t, timeslotBDO);
                timeslotBDOList.Add(timeslotBDO);
            }
            return timeslotBDOList;
        }

        private void ConvertTimeslotToTimeslotBDO(Timeslot timeslot, TimeslotBDO tBDO)
        {
            tBDO.TimeSlotCode = timeslot.TimeSlotCode;
            tBDO.TimeStart = timeslot.TimeStart;
            tBDO.TimeEnd = timeslot.TimeEnd;
            tBDO.Days = timeslot.Days;
            tBDO.Deactivated = timeslot.Deactivated;

        }

        public Boolean CreateTimeslot(ref TimeslotBDO tBDO, ref string message)
        {
            message = "Timeslot Added Successfully";
            bool ret = true;

            Timeslot t = new Timeslot()
            {
                TimeSlotCode = tBDO.TimeSlotCode,
                TimeStart = tBDO.TimeStart,
                TimeEnd = tBDO.TimeEnd,
                Days = tBDO.Days
            };

            using (var DCEnt = new DCFIEntities())
            {
                DCEnt.Timeslots.Attach(t);
                DCEnt.Entry(t).State = System.Data.Entity.EntityState.Added;
                int num = DCEnt.SaveChanges();
                tBDO.TimeSlotCode = t.TimeSlotCode;

                if (num != 1)
                {
                    ret = false;
                    message = "Adding of Timeslot failed";
                }
            }
            return ret;
        }

        public Boolean UpdateTimeslot(ref TimeslotBDO tBDO, ref string message)
        {
            message = "Timeslot updated successfully.";
            Boolean ret = true;
            using (var DCEnt = new DCFIEntities())
            {
                var timeslotCode = tBDO.TimeSlotCode;
                Timeslot timeslotInDB = (from t in DCEnt.Timeslots
                                 where t.TimeSlotCode == timeslotCode
                                 select t).FirstOrDefault();
                if (timeslotInDB == null)
                {
                    throw new Exception("No timeslot with code " + tBDO.TimeSlotCode);
                }
                DCEnt.Timeslots.Remove(timeslotInDB);

                timeslotInDB.TimeStart = tBDO.TimeStart;
                timeslotInDB.TimeEnd = tBDO.TimeEnd;
                timeslotInDB.Days = tBDO.Days;

                DCEnt.Timeslots.Attach(timeslotInDB);
                DCEnt.Entry(timeslotInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();

                if (num != 1)
                {
                    ret = false;
                    message = "No timeslot is updated.";
                }
            }
            return ret;

        }

        public Boolean DeactivateTimeslot(string timeslotCode, ref string message)
        {
            message = "Timeslot deactivated successfully.";
            Boolean ret = true;

            using (var DCEnt = new DCFIEntities())
            {
                Timeslot timeslotInDB = (from t in DCEnt.Timeslots
                                 where t.TimeSlotCode == timeslotCode
                                 select t).FirstOrDefault();

                if (timeslotInDB == null)
                {
                    throw new Exception("No timeslot with code " + timeslotCode);
                }

                DCEnt.Timeslots.Remove(timeslotInDB);

                timeslotInDB.Deactivated = true;

                DCEnt.Timeslots.Attach(timeslotInDB);
                DCEnt.Entry(timeslotInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    message = "Deactivation Failed.";
                }
            }
            return ret;

        }

        public Boolean ActivateTimeslot(string timeslotCode, ref string message)
        {
            message = "Timeslot Activated successfully.";
            Boolean ret = true;

            using (var DCEnt = new DCFIEntities())
            {
                Timeslot tInDB = (from t in DCEnt.Timeslots
                                 where t.TimeSlotCode == timeslotCode
                                 select t).FirstOrDefault();

                if (tInDB == null)
                {
                    throw new Exception("No timeslot with code " + tInDB);
                }

                DCEnt.Timeslots.Remove(tInDB);

                tInDB.Deactivated = false;

                DCEnt.Timeslots.Attach(tInDB);
                DCEnt.Entry(tInDB).State = System.Data.Entity.EntityState.Modified;
                int num = DCEnt.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    message = "Activation Failed.";
                }
            }
            return ret;

        }
        public Boolean DeleteTimeslot(string timeslotCode, ref string message)
        {
            message = "Timeslot Deleted successfully.";
            Boolean ret = true;

            using (var DCEnt = new DCFIEntities())
            {
                Timeslot tInDB = (from t in DCEnt.Timeslots
                                 where t.TimeSlotCode == timeslotCode
                                 select t).FirstOrDefault();

                if (tInDB == null)
                {
                    throw new Exception("No timeslot with code " + tInDB);
                }

                DCEnt.Timeslots.Remove(tInDB);
                DCEnt.Entry(tInDB).State = System.Data.Entity.EntityState.Deleted;
                int num = DCEnt.SaveChanges();
                if (num != 1)
                {
                    ret = false;
                    message = "Deletion of Timeslot Failed.";
                }
            }
            return ret;
        }

    }
}
