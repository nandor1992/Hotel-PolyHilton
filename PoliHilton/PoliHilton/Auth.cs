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
        
        }

        public void create_user(String username, String password, String firstname, String lastname)
        {
            //TO DO: Verify if any fields are empty
            //Insert into users new user
        }


    }
}
