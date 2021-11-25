using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes.Shift
{
    public class ShiftManagement
    {
        private List<Shift> shifts = new List<Shift>();
        private ShiftDAL shiftCon = new ShiftDAL();

        public Shift AddSchedule(Shift s)
        {
       //     shifts.Add(s);
          s=  shiftCon.AddShift(s);
            return s;
        }

        public ShiftManagement() //The shift shiftManagment stores all GetAlls
        {
            this.shifts = shiftCon.GetAllShifts();
        }

        public void UpdateSHift(Shift shift)
        {
            this.shiftCon.UpdateShifts(shift);
        }
        public List<Shift> GetShiftByDate(DateTime date)
        {
            return shiftCon.GetShiftByDate(date);
        }
        public Shift GetShiftById(int id)
        {
            return shiftCon.GetShiftById(id);
        }
        public List<Shift> GetAllShifts()
        {
            return shiftCon.GetAllShifts();
        }
        //public List<Shift> GetShiftByEmplooyeeId(int id)
        //{
        //    return shiftCon.GetShiftByEmployeeId(int id);
        //}

    }
}
