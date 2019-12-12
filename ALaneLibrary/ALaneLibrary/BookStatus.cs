using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALaneLibrary
{
    public class BookStatus
    {
        public enum BOOK_STATUS
        {
            ON_HOLD = 0,
            CHECKED_OUT,
            AVAILABLE,
            NOT_AVAILABLE,
            IN_TRANSIT,
            WAITLIST
        }
    }
}
