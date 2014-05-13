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
       public void init_form7_fields(System.Windows.Forms.ComboBox c1, System.Windows.Forms.ComboBox c2, 
           System.Windows.Forms.ComboBox c3,System.Windows.Forms.Label l1)
       {
           l1.Text = username;
           DataSet ds_reservations = new DataSet();
           String command = "SELECT * FROM [polihilton].[dbo].[RoomTypes] ";
           DataSet ds1 = db1.Read(command);
           foreach (DataRow dr in ds1.Tables[0].Rows)
           {
               c1.Items.Add(dr.ItemArray.GetValue(2));
               c3.Items.Add(dr.ItemArray.GetValue(1));
           }
           c2.Items.Add("1-50");
           c2.Items.Add("50-100");
           c2.Items.Add("100-150");
           c2.Items.Add("150-200");
           c2.Items.Add("200-999");
       }
       public void log_out(int nr)
       {
           Form1 f1 = new Form1(this.db1);
           if (nr==1)
               Form5.ActiveForm.Hide();
           else
               Form7.ActiveForm.Hide();
           f1.Show();
       }
       public void search_rooms(System.Windows.Forms.ComboBox c1, System.Windows.Forms.ComboBox c2,
            System.Windows.Forms.ComboBox c3, System.Windows.Forms.DateTimePicker d1,
            System.Windows.Forms.DateTimePicker d2,System.Windows.Forms.ListBox l1)
       {
           l1.Items.Clear();
           try
           {
               String type = c1.SelectedItem.ToString();
               char[] separator = { '-' };
               string[] price = c2.SelectedItem.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
               String capacity = c3.SelectedItem.ToString();
               DateTime dateStart = d1.Value.Date;
               DateTime dateEnd = d2.Value.Date;
            
               //DataSet ds= new DataSet();
               //String command = "SELECT t2.r_number, t1.price, t3.start_date, t3.end_date FROM [polihilton].[dbo].[RoomType] t1 JOIN (SELECT * FROM [polihilton].[dbo].[Rooms] t2 JOIN [polihilton].[dbo].[Rezervations] t3 ON t2.r_id = t3.r_id WHERE DATEDIFF(day,'" + dateStart + "',t3.start_date)>0 AND DATEDIFF(day,'" + dateEnd + "',t3.end_date)>0 ) ON t1.r_type_id = t2.r_type_id WHERE t1.name = '" + type + "' AND t1.capacity = '" + capacity + "' AND t1.price BETWEEN '" + price[0] + "' AND '" + price[1] + "'";
               //String command = "SELECT t2.r_type_id, t2.r_number FROM [polihilton].[dbo].[Rooms] t2 JOIN [polihilton].[dbo].[Rezervations] t3 ON t2.r_id=t3.r_id WHERE (DATEDIFF(day,'" + dateStart + "',t3.start_date)>0 AND DATEDIFF(day,'" + dateEnd + "',t3.start_date)>0) OR (DATEDIFF(day,'" + dateStart + "',t3.end_date)<0 AND DATEDIFF(day,'" + dateEnd + "',t3.end_date)>0)";
               //String command = "SELECT t3.start_date, t3.end_date FROM [polihilton].[dbo].[Rooms] t2 JOIN [polihilton].[dbo].[Rezervations] t3 ON t2.r_id=t3.r_id DATEDIFF(day,'" + dateStart + "',t3.start_date)<0";
               //String command = "SELECT DATEDIFF(day,convert(datetime,'"+dateStart+"',5),convert(datetime,'"+dateEnd+"',5)) AS DiffDate";
               String command = "SELECT t1.capacity, t1.name, t1.price, t2.r_number FROM [polihilton].[dbo].[RoomTypes] t1 JOIN [polihilton].[dbo].[Rooms] t2 ON t1.r_type_id=t2.r_type_id WHERE t1.name = '" + type + "' AND t1.capacity = '" + capacity + "' AND t1.price BETWEEN '" + price[0] + "' AND '" + price[1] + "'";
               DataSet ds1 = db1.Read(command);            
               System.Windows.Forms.MessageBox.Show(dateStart + " " + dateEnd);
               foreach (DataRow dr in ds1.Tables[0].Rows)
               {
                       //String line = "Number:" + dr.ItemArray.GetValue(0).ToString() + "  Type:" + type + "  Capacity:" + capacity + "  Price:" + dr.ItemArray.GetValue(1).ToString();
                   String line = "number: " + dr.ItemArray.GetValue(3).ToString() + "  capacity: " + dr.ItemArray.GetValue(0).ToString() + "  type: " + dr.ItemArray.GetValue(1).ToString() + "  price: " + dr.ItemArray.GetValue(2).ToString();
                   l1.Items.Add(line);   
               }
           }
           catch (Exception e)
           {
               Console.WriteLine("{0} Exception caught.", e);
           }
       }

       public int reserve_room(System.Windows.Forms.ListBox l1)
       {
           char[] separator = { ' ' };
           string[] words = l1.SelectedItem.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
           int room_number = int.Parse(words[1]);
           return room_number;
       }

       public void final_reserve_room(Users u,int room_number)
       {
           Form8 f8 = new Form8(u,room_number);
           Form7.ActiveForm.Hide();
           f8.Show();
       }

        public void fill_room_fields_final(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4, 
            System.Windows.Forms.TextBox t5, System.Windows.Forms.TextBox t6, System.Windows.Forms.TextBox t7, System.Windows.Forms.TextBox t8, System.Windows.Forms.TextBox t9,int room_number)
        {
            String command = "SELECT t1.name, t2.r_number, t2.r_floor, t1.capacity, t2.surface, t2.orientation, t1.price FROM [polihilton].[dbo].[RoomTypes] t1 JOIN [polihilton].[dbo].[Rooms] t2 ON t1.r_type_id=t2.r_type_id WHERE t2.r_number='"+room_number+"'";
            DataSet ds1 = db1.Read(command);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                t1.Text = dr.ItemArray.GetValue(0).ToString();
                t2.Text = dr.ItemArray.GetValue(1).ToString();
                t3.Text = dr.ItemArray.GetValue(2).ToString();
                t4.Text = dr.ItemArray.GetValue(3).ToString();
                t5.Text = dr.ItemArray.GetValue(4).ToString();
                t6.Text = dr.ItemArray.GetValue(5).ToString();
                t7.Text = dr.ItemArray.GetValue(6).ToString();
                t8.Text = "0";
                t9.Text = dr.ItemArray.GetValue(6).ToString();
            }
        }

       




    }
}
