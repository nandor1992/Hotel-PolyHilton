using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

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
       public void reception_dataset_populate(ComboBox g1)
       {
           String command_cleaner = "SELECT r_number FROM [polihilton].[dbo].[Rooms]";
           DataSet ds1 = db1.Read(command_cleaner);
           //am modificat sa ia fiecare row din tabel si sa le adauge, se poate si cu source cred dar asa e mai simplu
           foreach (DataTable table in ds1.Tables)
           {
               foreach (DataRow dr in table.Rows)
               {
                g1.Items.Add(dr["r_number"].ToString());

               }
           }
       }
       public void create_user(String username, String password, String firstname, String lastname, int u_type_id)
       {
           String db_command = "SELECT * FROM [polihilton].[dbo].[Users] Where username='" + username + "'";
           DataSet ds1 = db1.Read(db_command);
           if (ds1.Tables[0].Rows.Count != 0)
           {
               MessageBox.Show("User already taken");
           }
           else if(u_type_id==2)
           {
               MessageBox.Show("You cannot create an administrator account");
           }
           else if (username=="" ||lastname=="" ||firstname=="" ||password=="" )
           {
               MessageBox.Show("No field should be left NULL");
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

       public void log_out()
       {
           this.f4.Close();
           Form1 f1 = new Form1(this.db1);
       }

    }
}
