using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarProjectKSAsolutions.Classes
{
     public class NotStringException : Exception
    {


        public NotStringException(string message) : base($" pLEASE ENTER [A-Z] for {message}")
        {

        }
    }
}
