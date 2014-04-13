using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliHilton
{
   public  class Admin
    {
     Database db1;
     int id;
     String firstname;
     String lastname;
     Form2 f2;
        
       public Admin(int id,String firstname,String lastname,Database db1)
        {
        this.db1=db1;
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        }

       public void init(Form2 f2)
       {
           this.f2 = f2;
           //initialize initial stuff
       }

       public void log_out()
       {
           this.f2.Close();
           Form1 f1 = new Form1(this.db1);
       }

    }
}
