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
           //g1.Items.Add("1");
           //g1.Items.Add("2");
           
           //g1.DataSource = ds1.Tables["Rooms"];
           foreach (DataTable table in ds1.Tables)
           {
               //cmbTripName.Items.Add(drd["FleetName"].ToString());
              // g1.Items.Add(ds1.ToString());
               g1.DataSource = ds1;
           }
       }

       public void log_out()
       {
           this.f4.Close();
           Form1 f1 = new Form1(this.db1);
       }

    }
}
