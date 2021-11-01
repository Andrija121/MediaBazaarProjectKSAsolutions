using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
    public class ResupplyRequest
    {
        public int WheId { get; set; } // da li mi treba vrednost int ili tipa User
        public int DmId { get; set; }
        public int StockId { get; set; }
        public int Amount { get; set; }
        public RequestStatus RequestStatus { get; set; }

        public ResupplyRequest(int wheId,int dmId,int stockId,int amount,RequestStatus requestStatus)
        {
            this.WheId = wheId;
            this.DmId = dmId;
            this.StockId = stockId;
            this.Amount += amount;
            this.RequestStatus = requestStatus;
        }
        public ResupplyRequest()
        {

        }
        public override string ToString()
        {
            return WheId + " - " + DmId + " - " + StockId + " - " + Amount + " - " + RequestStatus;
        }



    }
}
