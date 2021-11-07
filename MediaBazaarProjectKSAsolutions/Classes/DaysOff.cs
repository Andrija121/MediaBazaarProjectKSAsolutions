using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    class DaysOff
    {
        public int RequestId { get; set; }
        public int HRManagerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public RequestStatus RequestStatus { get; set; }


        public DaysOff(int requestId,int hrManagerId,DateTime startDate,DateTime endDate,string reason,RequestStatus requestStatus)
        {
            this.RequestId = requestId;
            this.HRManagerId = hrManagerId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Reason = reason;
            this.RequestStatus = requestStatus;
        }
        public DaysOff()
        {

        }

        public override string ToString()
        {
            return Reason;
        }
    }
}
