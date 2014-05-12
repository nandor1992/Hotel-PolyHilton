using System;
using System.Collections.Generic;
using System.Data;
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
     String username;
      
        
       public Users(int id,String firstname,String lastname,String username,Database db1,System.Windows.Forms.Label l1)
        {
           
           this.db1=db1;
            this.id = id;
              this.firstname = firstname;
            this.lastname = lastname;
           this.username = username;
           l1.Text = username;
        }

       public DataSet list_current_reservations(System.Windows.Forms.ListBox l1)
       {
           l1.Items.Clear();
           DataSet ds_reservations = new DataSet();
           String command_cleaner = "SELECT * FROM [polihilton].[dbo].[Rezervations] WHERE u_id='" + id + "'";
           DataSet ds1 = db1.Read(command_cleaner);
           foreach (DataRow dr in ds1.Tables[0].Rows)
           {
               char[] separator = { ' ' };
               string[] words1 = dr.ItemArray.GetValue(3).ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
               string[] words2 = dr.ItemArray.GetValue(4).ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
               String line = "room: " + dr.ItemArray.GetValue(2).ToString() + "  start date: " + words1[0]
                   + "  end date: " + words2[0] + "  price: " + dr.ItemArray.GetValue(5).ToString();
               l1.Items.Add(line);
           }
           return ds_reservations;


       }
       public void cancel_reservation(System.Windows.Forms.ListBox l1)
       {
           char[] separator = { ' ' };
           try
           {
               string[] words = l1.SelectedItem.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
               String command = "DELETE FROM [polihilton].[dbo].[Rezervations] WHERE r_id = '" + int.Parse(words[1]) + "'";
               db1.Command(command);
           }
           catch (Exception e)
           {
               Console.WriteLine("{0} Exception caught.", e);
           }
       }
       public void new_reservation()
       {
           
       }

       public void log_out()
       {
           Form1 f1 = new Form1(this.db1);
           Form5.ActiveForm.Hide();
           f1.Show();
       }




    }
}
