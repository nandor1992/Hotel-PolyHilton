using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliHilton
{
    public class Users
    {
     Database db1;
     int id;
     String firstname;
     String lastname;
     Form5 f5;
     Form6 f6;
     Form7 f7;
     Form8 f8;
        
       public Users(int id,String firstname,String lastname,Database db1)
        {
        this.db1=db1;
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        }

       public Database get_Database()
       {
           return db1;
       }

       public void create_f6()
       {
           Form6 f6 = new Form6(this);
           this.f6 = f6;
       }

       public void create_f7()
       {
           Form7 f7 = new Form7(this);
           this.f7= f7;
       }

       public void create_f8()
       {
           //need more info about the reservation itself from from 7/6
           Form8 f8 = new Form8(this);
           this.f8 = f8;
       }


       public void init_f5(Form5 f5)
       {
           this.f5 = f5;
           //initialize initial stuff for form 5
       }

       public void log_out()
       {
            Form1 f1 = new Form1(this.db1);
           this.f5.Close();
           this.f6.Close();
           this.f7.Close();
           this.f8.Close();
          
       }

    }
}
