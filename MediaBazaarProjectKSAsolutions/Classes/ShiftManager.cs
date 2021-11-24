using System;
using System.Collections.Generic;
using System.Text;
using MediaBazaarProjectKSAsolutions.Classes;

namespace MediaBazaarProjectKSAsolutions.Classes
{
     public class ShiftManager
    {
        private List<Shift> shifts = new List<Shift>();

        private ShiftManagments shiftcon = new ShiftManagments();

        public void AddShifts( Shift s)
        {
            shifts.Add(s); //This add shifts.
            shiftcon.AddShift(s);
        }

        public ShiftManager()
        {
            this.shifts = shiftcon.GetAllShifts();
        }

        public void UpdateShift(Shift shift) //Update shift
        {
            this.shiftcon.UpdateShifts(shift);
        }

        public List<Shift> GetShiftByUserID( int id)
        {
            return shiftcon.GetShiftbyEmployyeID(id);
        }

    }
}
