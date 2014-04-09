using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliHilton
{
    class Cleaning
    {
        Database db1;
        int userID;
        String firstname;
        String lastname;
        
        public Cleaning(Database db1, int userID,String firstname,String lastname)
        {
            this.db1 = db1;
            this.userID = userID;
            this.firstname=firstname;
            this.lastname = lastname;
        }

        public void init()
        {
            //set Hello user
            //get cleaning requirements from db
        }

        public DataSet list_assigned_rooms()
        {
            DataSet ds_rooms = new DataSet();
            //get assigned rooms and list them to box
            return ds_rooms;
        }

        public void cleaned(int room_id)
        {
            //update room as cleaned in status and refresh list_assigned_rooms();
        }

        public void log_out()
        {
            //go back to login
        }


    }
}
