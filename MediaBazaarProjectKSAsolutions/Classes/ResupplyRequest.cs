using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    public class ResupplyRequest
    {
        public int RequestID { get; set; }
        public User Whe { get; set; } // da li mi treba vrednost int ili tipa User
        public User Dm { get; set; }
        public Stock Stock { get; set; }
        public int AmountRequested { get; set; }
        public int AmountFulfilled { get; set; }
        public RequestStatus RequestStatus { get; set; }

        public ResupplyRequest(int requestId,User wheId,User dmId,Stock stockId,int amountRequested,int amountfulfiled,RequestStatus requestStatus)
        {
            this.RequestID = requestId;
            this.Whe = wheId;
            this.Dm = dmId;
            this.Stock = stockId;
            this.AmountRequested += amountRequested;
            this.AmountFulfilled = amountfulfiled;
            this.RequestStatus = requestStatus;
        }
        public ResupplyRequest()
        {

        }
        public override string ToString()
        {
            return Whe + " - " + Dm + " - " + Stock + " - " + AmountRequested + " - " + RequestStatus;
        }



    }
}
