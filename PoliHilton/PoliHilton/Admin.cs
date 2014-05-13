using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliHilton
{
    //We need functions for all the buttons/actions posssible selected
    //Initalization is done and log out
   public  class Admin
    {
     Database db1;
     int id;
     String firstname;
     String lastname;
        
       public Admin(int id,String firstname,String lastname,Database db1)
        {
        this.db1=db1;
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        }

       public String getName()
       {
           return "" + firstname + " " + lastname;
       }

       public void dataset_populate(System.Windows.Forms.DataGridView g1,int type)
       {
           String command_cleaner = "SELECT * FROM [polihilton].[dbo].[Users] WHERE u_type_id='" + type + "'";
           DataSet ds1 = db1.Read(command_cleaner);
           foreach (DataTable table in ds1.Tables)
           {
               g1.DataSource = table;
           }
       }

       public void dataset_select(System.Windows.Forms.DataGridView g1,System.Windows.Forms.TextBox t1,System.Windows.Forms.TextBox t2,System.Windows.Forms.TextBox t3,System.Windows.Forms.TextBox t4)
       {
           if (g1.SelectedRows.Count != 0)
           {
               DataGridViewRow row = g1.SelectedRows[0];
               t1.Text=row.Cells["firstName"].Value.ToString();
               t2.Text=row.Cells["lastName"].Value.ToString();
               t3.Text=row.Cells["username"].Value.ToString();
               t4.Text=row.Cells["password"].Value.ToString();
               
           }
       }

       public void modify_user(System.Windows.Forms.DataGridView g1, System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4)
       {
            if (g1.SelectedRows.Count != 0)
           {
               DataGridViewRow row = g1.SelectedRows[0];
               int id=int.Parse(row.Cells["u_id"].Value.ToString());
               String db_command="UPDATE [polihilton].[dbo].[Users] SET username='"+t3.Text+"',password='"+t4.Text+"',firstName='"+t1.Text+"',lastName='"+t2.Text+"' WHERE u_id='"+id+"'";
               db1.Command(db_command);
            }
                
       }

       public void promote_admin(System.Windows.Forms.DataGridView g1)
       {
           if (g1.SelectedRows.Count != 0)
           {
               DataGridViewRow row = g1.SelectedRows[0];
               int id = int.Parse(row.Cells["u_id"].Value.ToString());
               String db_command = "UPDATE [polihilton].[dbo].[Users] SET u_type_id='2' WHERE u_id='" + id + "'";
               db1.Command(db_command);
           }
       }

       public void demote_admin(System.Windows.Forms.DataGridView g1)
       {
           if (g1.SelectedRows.Count != 0)
           {
               DataGridViewRow row = g1.SelectedRows[0];
               int id = int.Parse(row.Cells["u_id"].Value.ToString());
               String db_command = "UPDATE [polihilton].[dbo].[Users] SET u_type_id='1' WHERE u_id='" + id + "'";
               db1.Command(db_command);
           }
       }

       public void adding_user(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4, int type)
       {
            String db_command= "SELECT * FROM [polihilton].[dbo].[Users] WHERE username='"+t1.Text+"'";
           DataSet ds1=db1.Read(db_command);
           if (ds1.Tables[0].Rows.Count == 0)
           {
               String db_command1 = "INSERT INTO [polihilton].[dbo].[Users] (u_type_id,username,password,firstName,lastName)Values('" + type + "','" + t1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Text + "')";
               db1.Command(db_command1);
               MessageBox.Show("User created succesfully!");
           }
           else
           {
               MessageBox.Show("User Already Exists");
           }
       }

       public void delete_user(System.Windows.Forms.DataGridView g1)
       {
           if (g1.SelectedRows.Count != 0)
           {
               DataGridViewRow row = g1.SelectedRows[0];
               if (int.Parse(row.Cells["u_id"].Value.ToString()) == this.id)
               {
                   MessageBox.Show("Can't Delete Yourself");
               }
               else
               {
                   //TO-DO: Add deletion of everything adjecent

                   String db_command1 = "DELETE FROM [polihilton].[dbo].[Users] WHERE u_id='" + int.Parse(row.Cells["u_id"].Value.ToString()) + "' ON DELETE CASCADE";
                   db1.Command(db_command1);
               }
           }
       }

       public void prices_udpate(System.Windows.Forms.DataGridView g1,System.Windows.Forms.DataGridView g2)
       {
           String command_cleaner = "SELECT * FROM [polihilton].[dbo].[RoomTypes] ";
           DataSet ds1 = db1.Read(command_cleaner);
           foreach (DataTable table in ds1.Tables)
           {
               g1.DataSource = table;
           }
           command_cleaner = "SELECT * FROM [polihilton].[dbo].[Discounts] ";
           ds1 = db1.Read(command_cleaner);
           foreach (DataTable table in ds1.Tables)
           {
               g2.DataSource = table;
           }
       }

       public void room_info_update(System.Windows.Forms.DataGridView g1)
       {
           String command_cleaner = "SELECT * FROM [polihilton].[dbo].[Rooms] INNER JOIN [polihilton].[dbo].[Rezervations] ON Rooms.r_id=Rezervations.r_id ";
           DataSet ds1 = db1.Read(command_cleaner);
           foreach (DataTable table in ds1.Tables)
           {
               g1.DataSource = table;
           }
       }

       public void prices_selected(System.Windows.Forms.DataGridView g1, System.Windows.Forms.TextBox t1)
       {
           if (g1.SelectedRows.Count != 0)
           {
               DataGridViewRow row = g1.SelectedRows[0];
               t1.Text = row.Cells["price"].Value.ToString();
               
            }
       }

       public void prices_new_update(System.Windows.Forms.DataGridView g1, System.Windows.Forms.TextBox t1)
       {
           if (g1.SelectedRows.Count != 0)
           {
               DataGridViewRow row = g1.SelectedRows[0];
               int id= int.Parse(row.Cells["r_type_id"].Value.ToString());
               String db_command = "UPDATE [polihilton].[dbo].[RoomTypes] SET price='"+int.Parse(t1.Text)+"' WHERE r_type_id='" + id + "'";
               db1.Command(db_command);
           }
       }

       public void delete_discount(System.Windows.Forms.DataGridView g1)
       {
           if (g1.SelectedRows.Count != 0)
           {
               DataGridViewRow row = g1.SelectedRows[0];
               int id = int.Parse(row.Cells["d_id"].Value.ToString());
               String db_command1 = "DELETE FROM [polihilton].[dbo].[Discounts] WHERE d_id='" + id + "'";
               db1.Command(db_command1);
           }
       }

       public void populate_discount_drop_type(System.Windows.Forms.ComboBox c1)
       {
           String command_cleaner = "SELECT name FROM [polihilton].[dbo].[RoomTypes]";
           DataSet ds1 = db1.Read(command_cleaner);
           foreach (DataTable table in ds1.Tables)
           {
               foreach (DataRow dr in table.Rows)
               {
                   c1.Items.Add(dr["name"].ToString());
               }
           }
       }

       public void populate_discount_drop_room(System.Windows.Forms.ComboBox c1, System.Windows.Forms.TextBox t1, String type)
       {
           String command_cleaner = "SELECT * FROM [polihilton].[dbo].[RoomTypes] Where name='"+type+"'";
           DataSet ds1 = db1.Read(command_cleaner);
           int id_type=0;
           foreach (DataTable table in ds1.Tables)
           {
               foreach (DataRow dr in table.Rows)
               {
                   id_type=int.Parse(dr["r_type_id"].ToString());
                   t1.Text = dr["price"].ToString();
               }
           }
           command_cleaner = "SELECT * FROM [polihilton].[dbo].[Rooms] Where r_type_id='"+id_type+"'";
           ds1 = db1.Read(command_cleaner);
           foreach (DataTable table in ds1.Tables)
           {
               foreach (DataRow dr in table.Rows)
               {
                   c1.Items.Add(dr["r_number"].ToString());
               }
           }

       }

       public void add_discount(System.Windows.Forms.ComboBox c2, System.Windows.Forms.TextBox t1)
       {
           String command_cleaner = "SELECT * FROM [polihilton].[dbo].[Rooms] Where r_number='" + c2.Text + "'";
           DataSet ds1 = db1.Read(command_cleaner);
           int id_type = 0;
           foreach (DataTable table in ds1.Tables)
           {
               foreach (DataRow dr in table.Rows)
               {
                   id_type = int.Parse(dr["r_id"].ToString());
               }
           }
           String db_command1 = "INSERT INTO [polihilton].[dbo].[Discounts] (r_id,price)Values('"+id_type+"','"+t1.Text+"')";
           db1.Command(db_command1);
       }

       public void delete_rezervation(System.Windows.Forms.DataGridView g1)
       {
           if (g1.SelectedRows.Count != 0)
           {
               DataGridViewRow row = g1.SelectedRows[0];
               int id = int.Parse(row.Cells["rez_id"].Value.ToString());
               String db_command1 = "DELETE FROM [polihilton].[dbo].[Rezervations] WHERE rez_id='" + id + "'";
               db1.Command(db_command1);
           }
       }

       public void populate_user_reservation(System.Windows.Forms.DataGridView g1, System.Windows.Forms.DataGridView g2)
       {
           if (g1.SelectedRows.Count != 0)
           {
               DataGridViewRow row = g1.SelectedRows[0];
               int id_u = int.Parse(row.Cells["u_id"].Value.ToString());
               String command_cleaner = "SELECT * FROM [polihilton].[dbo].[Rezervations] WHERE u_id='"+id_u+"'";
               DataSet ds1 = db1.Read(command_cleaner);
               foreach (DataTable table in ds1.Tables)
               {
                   g2.DataSource = table;
               }
           }
       }

       public void populate_cleaning_assigned(System.Windows.Forms.DataGridView g1, System.Windows.Forms.DataGridView g2)
       {
           String command_cleaner = "SELECT * FROM [polihilton].[dbo].[Cleaning] WHERE status='Pending' ";
           DataSet ds1 = db1.Read(command_cleaner);
           foreach (DataTable table in ds1.Tables)
           {
               g1.DataSource = table;
           }
           command_cleaner = "SELECT * FROM [polihilton].[dbo].[Cleaning] INNER JOIN [polihilton].[dbo].[Users] ON Cleaning.u_id=Users.u_id WHERE status='Assigned' ";
           ds1 = db1.Read(command_cleaner);
           foreach (DataTable table in ds1.Tables)
           {
               g2.DataSource = table;
           }

       }

       public void assign_cleaning(System.Windows.Forms.DataGridView g1, System.Windows.Forms.DataGridView g2)
       {
           if (g1.SelectedRows.Count != 0)
           {
               if (g2.SelectedRows.Count != 0)
               {

                   DataGridViewRow row = g1.SelectedRows[0];
                   int id_u = int.Parse(row.Cells["u_id"].Value.ToString());
                   row = g2.SelectedRows[0];
                   int id_c = int.Parse(row.Cells["clean_id"].Value.ToString());
                   String db_command = "UPDATE [polihilton].[dbo].[Cleaning] SET status='Assigned', u_id='" + id_u + "' WHERE clean_id='" + id_c + "'";
                   db1.Command(db_command);
               }
           }
       }
        

           public void delete_assignment(System.Windows.Forms.DataGridView g1)
           { 
               if (g1.SelectedRows.Count != 0)
               {
                   DataGridViewRow row = g1.SelectedRows[0];
                   int id_u = int.Parse(row.Cells["u_id"].Value.ToString());
                   int id_c= int.Parse(row.Cells["clean_id"].Value.ToString());
                    String db_command = "UPDATE [polihilton].[dbo].[Cleaning] SET status='Pending', u_id='"+id_u+"' WHERE clean_id='" + id_c + "'";
                   db1.Command(db_command);
               }
           }

           public void auto_assign_cleaning()
           {
               String command_cleaner = "SELECT * FROM [polihilton].[dbo].[Users] Where u_type_id='3'";
               DataSet ds1 = db1.Read(command_cleaner);
               DataTable t1 = ds1.Tables[0];
               command_cleaner = "SELECT * FROM [polihilton].[dbo].[Cleaning] Where status='Pending' OR status='in progress'";
               ds1 = db1.Read(command_cleaner);
               DataTable t2 = ds1.Tables[0];
               int divider = t1.Rows.Count;
               int rows_clean = t2.Rows.Count;
               int iter = rows_clean / divider;
               int leftower = rows_clean % divider;
               //MessageBox.Show("" + iter + "" + leftower);
               String id_u = "0";
               String id_c = "0";
               String db_command = "";
               DataRow r_user;
               DataRow r_clean;
               for (int j = 0; j < iter; j++)
               {
                   for (int i = 0; i < divider; i++)
                   {
                       r_user = t1.Rows[i];
                       r_clean = t2.Rows[i + divider* j];
                       id_u = r_user["u_id"].ToString();
                       id_c = r_clean["clean_id"].ToString();
                      // MessageBox.Show("user: " + id_u + "cleaning job: " + id_c);
                       db_command = "UPDATE [polihilton].[dbo].[Cleaning] SET status='Assigned', u_id='" + id_u + "' WHERE clean_id='" + id_c + "'";
                       db1.Command(db_command);
                   }
               }
               if (leftower != 0)
               {
                   for (int i = 0; i < leftower; i++)
                   {
                       r_user = t1.Rows[i];
                       r_clean = t2.Rows[i + divider*iter];
                       id_u = r_user["u_id"].ToString();
                       id_c = r_clean["clean_id"].ToString();
                      // MessageBox.Show("user: " + id_u + "cleaning job: " + id_c);
                       db_command = "UPDATE [polihilton].[dbo].[Cleaning] SET status='Assigned', u_id='" + id_u + "' WHERE clean_id='" + id_c + "'";
                       db1.Command(db_command);
                   }
               }
           }

           public void statistic_income(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2)
           {
               //Age wise
               int total = 0;
               String db_command = "SELECT * FROM [polihilton].[dbo].[Rezervations] ";
               DataSet ds1=db1.Read(db_command);
               foreach (DataTable table in ds1.Tables)
               {
                   foreach (DataRow dr in table.Rows)
                   {
                       DateTime time1 =Convert.ToDateTime(dr["start_date"].ToString());
                       DateTime time2 = Convert.ToDateTime(dr["end_date"].ToString());
                       int price = Int16.Parse(dr["rez_price"].ToString());
                       total = total + (int)(time2 - time1).TotalDays * price;
                   }
               }
               t1.Text = total.ToString();
               //Montly
               total = 0;
               DateTime reference = DateTime.UtcNow.AddMonths(-1);
               string sql = "SELECT * FROM [polihilton].[dbo].[Rezervations] WHERE start_date > Convert(datetime,'"+reference+"')";
               ds1 = db1.Read(sql);
               foreach (DataTable table in ds1.Tables)
               {
                   foreach (DataRow dr in table.Rows)
                   {
                       DateTime time1 = Convert.ToDateTime(dr["start_date"].ToString());
                       DateTime time2 = Convert.ToDateTime(dr["end_date"].ToString());
                       int price = Int16.Parse(dr["rez_price"].ToString());
                       total = total + (int)(time2 - time1).TotalDays * price;
                   }
               }
               t2.Text = total.ToString();
           }

           public void statistic_customers(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2)
           {
               //Age wise
               int total = 0;
               String db_command = "SELECT * FROM [polihilton].[dbo].[Rezervations] ";
               DataSet ds1 = db1.Read(db_command);
               foreach (DataTable table in ds1.Tables)
               {
                   foreach (DataRow dr in table.Rows)
                   {
                       total=total + 1;
                   }
               }
               t1.Text = total.ToString();
               //Montly
               total = 0;
               DateTime reference = DateTime.UtcNow.AddMonths(-1);
               string sql = "SELECT * FROM [polihilton].[dbo].[Rezervations] WHERE start_date > Convert(datetime,'" + reference + "')";
               ds1 = db1.Read(sql);
               foreach (DataTable table in ds1.Tables)
               {
                   foreach (DataRow dr in table.Rows)
                   {
                       total = total + 1;
                   }
               }
               t2.Text = total.ToString();
           }


           public void statistic_totals(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4)
           {
               //user
               string sql = "SELECT * FROM [polihilton].[dbo].[Users] WHERE u_type_id='1'";
              DataSet ds1 = db1.Read(sql);
              t1.Text=ds1.Tables[0].Rows.Count.ToString();
               //Cleaner
              sql = "SELECT * FROM [polihilton].[dbo].[Users] WHERE u_type_id='3'";
              ds1 = db1.Read(sql);
              t2.Text = ds1.Tables[0].Rows.Count.ToString();
              //Reception
              sql = "SELECT * FROM [polihilton].[dbo].[Users] WHERE u_type_id='4'";
              ds1 = db1.Read(sql);
              t3.Text = ds1.Tables[0].Rows.Count.ToString();
              //Admin
              sql = "SELECT * FROM [polihilton].[dbo].[Users] WHERE u_type_id='2'";
              ds1 = db1.Read(sql);
              t4.Text = ds1.Tables[0].Rows.Count.ToString();
           }

           public void cleaned_rooms(System.Windows.Forms.TextBox t1)
           {
               int total = 0;
               DateTime reference = DateTime.UtcNow.AddMonths(-1);
               string sql = "SELECT * FROM [polihilton].[dbo].[Cleaning] WHERE status='Cleaned' AND date_required > Convert(datetime,'" + reference + "')";
               DataSet ds1 = db1.Read(sql);
               foreach (DataTable table in ds1.Tables)
               {
                   foreach (DataRow dr in table.Rows)
                   {
                       total = total + 1;
                   }
               }
               t1.Text = total.ToString();
           }

           public void statistics_rooms(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2)
           {
               int total = 0;
               DateTime reference = DateTime.UtcNow;
               string sql = "SELECT * FROM [polihilton].[dbo].[Rezervations] WHERE end_date > Convert(datetime,'" + reference + "') AND start_date < Convert(datetime,'" + reference + "')";
               DataSet ds1 = db1.Read(sql);
               foreach (DataTable table in ds1.Tables)
               {
                   foreach (DataRow dr in table.Rows)
                   {
                       total = total + 1;
                   }
               }
               t1.Text = total.ToString();

               sql = "SELECT * FROM [polihilton].[dbo].[Rooms]";
               ds1 = db1.Read(sql);
               t2.Text = (ds1.Tables[0].Rows.Count - total).ToString();
           }
           
    }
}
