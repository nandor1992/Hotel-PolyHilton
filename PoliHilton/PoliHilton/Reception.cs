using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliHilton
{
   public class Reception
    {
        //We need functions for all the buttons/actions posssible selected
        //Initalization is done and log out
        Database db1;
     int id;
     String firstname;
     String lastname;
     Form4 f4;
        
       public Reception(int id,String firstname,String lastname,Database db1)
        {
        this.db1=db1;
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        
        }

       public void log_out()
       {
           this.f4.Close();
           Form1 f1 = new Form1(this.db1);
       }

    }
}
