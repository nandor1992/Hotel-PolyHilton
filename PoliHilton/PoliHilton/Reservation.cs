using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliHilton
{
    public class Reservation
    {
        int room_id;
        //use Datetime with DateTime Picker as:
        //DateTime t1=dateTimePicker1.Value.Date;
        DateTime start;
        DateTime end;

        public void assign(int room_id, DateTime start, DateTime end)
        {
            this.room_id = room_id;
            this.start = start;
            this.end = end;
        }
    }
}
