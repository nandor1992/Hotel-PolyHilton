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
 

        public DataSet list_assigned_rooms(System.Windows.Forms.ListBox l1)
        {
            l1.Items.Clear();
            DataSet ds_rooms = new DataSet();
            String command_cleaner = "SELECT * FROM [polihilton].[dbo].[Cleaning] WHERE u_id='3'";
            DataSet ds1 = db1.Read(command_cleaner);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                String line = "room id: " + dr.ItemArray.GetValue(1).ToString() + "  status: " + dr.ItemArray.GetValue(3).ToString();
                l1.Items.Add(line);
            }
           
            return ds_rooms;
        
           
        }
        public void in_progress(System.Windows.Forms.ListBox l1)
        {
            char[] separator = { ' ' };
            string[] words = l1.SelectedItem.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            String command = "UPDATE [polihilton].[dbo].[Cleaning] SET status = 'in progress' WHERE r_id = '4'";
            db1.Command(command);
        }
        public void cleaned(System.Windows.Forms.ListBox l1)
        {
            char[] separator = { ' ' };
            string[] words = l1.SelectedItem.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            String command = "UPDATE [polihilton].[dbo].[Cleaning] SET status = 'cleaned' WHERE r_id = '4'";
            db1.Command(command);
            //update room as cleaned in status and refresh list_assigned_rooms();
        }

        public void log_out()
        {
            f3.Close();
            Form1 f1 = new Form1(this.db1);
        }


    }
}
