using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliHilton
{
    //We need functions for all the buttons/actions posssible selected
    //Initalization is done and log out
    public class Cleaning
    {
         Database db1;
     int id;
     String firstname;
     String lastname;
     Form3 f3;
        
       public Cleaning(int id,String firstname,String lastname,Database db1)
        {
        this.db1=db1;
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        }

       public void init(Form3 f3)
       {
           this.f3 = f3;
           //initialize initial stuff
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
            this.f3.Close();
            Form1 f1 = new Form1(this.db1);
        }


    }
}
