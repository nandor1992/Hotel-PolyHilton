using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliHilton
{
    public class Auth
    {
        Database db1;
        public Auth(Database db1)
        {
        this.db1=db1;
        }

        public void login(String username, String password)
        { 
        //TO DO: Verify if any fields are empty
        //TO DO: Verify if present in Database, if present Switch() to required form, pass forward DB an create Object for type
        //go to either of the ligin forms Functions given
        //Example for  Different logins for admin user and others
            //login_admin(1, "Test", "TestLast");
            //login_user(1, "Test", "TestLast");
            //login_cleaner(1, "Test", "TestLast");
            //login_reception(1, "Test", "TestLast");
        }

        public void create_user(String username, String password, String firstname, String lastname)
        {
            //TO DO: Verify if any fields are empty
            //Insert into users new user
        }

        public void login_user(int id,String firstname,String lastname)
        {
            Form5 f5 = new Form5(new Users(id, firstname, lastname,this.db1));
        }
        public void login_admin(int id, String firstname, String lastname)
        {
             Form2 f2 = new Form2(new Admin(id, firstname, lastname,this.db1));
        }
        public void login_cleaner(int id, String firstname, String lastname)
        {
           Form3 f3 = new Form3(new Cleaning(id, firstname, lastname,this.db1));
        }
        public void login_reception(int id, String firstname, String lastname)
        {
            Form4 f4 = new Form4(new Reception(id, firstname, lastname,this.db1));
        }

    }
}
