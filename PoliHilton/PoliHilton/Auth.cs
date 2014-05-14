using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PoliHilton
{
    public class Auth
    {
        Database db1;
        public Auth(Database db1)
        {
        this.db1=db1;
        }

        public int login(String username, String password)
        { 
         String db_command="SELECT * FROM [polihilton].[dbo].[Users] Where username='"+username+"' AND password='"+password+"'";
         DataSet ds1=db1.Read(db_command);
         if (ds1.Tables[0].Rows.Count == 0)
         {
             MessageBox.Show("User and Pass combination not found");
             return 0;
         }
             else
             {
                 DataRow dr1 = ds1.Tables[0].Rows[0];
                 return int.Parse(dr1["u_type_id"].ToString());
         }
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
            int u_type_id = 1;
            String db_command="SELECT * FROM [polihilton].[dbo].[Users] Where username='"+username+"'";
            DataSet ds1=db1.Read(db_command);
            if (ds1.Tables[0].Rows.Count != 0) 
            {
                MessageBox.Show("User already taken");
            }
            else 
            {
                try
                {
                    String db_command1 = "INSERT INTO [polihilton].[dbo].[Users] (u_type_id,username,password,firstName,lastName)Values('" + u_type_id + "','" + username + "','" + password + "','" + firstname + "','" + lastname + "')";
                    db1.Command(db_command1);
                    MessageBox.Show("User created succesfully!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Insert" + e.ToString());
                }
            }
        }

      

    }
}
