using System;
using System.Collections.Generic;
using System.Data;
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
     Form2 f2;
        
       public Admin(int id,String firstname,String lastname,Database db1)
        {
        this.db1=db1;
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        }

       public void init(Form2 f2)
       {
           this.f2 = f2;
           //initialize initial stuff
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


       public void log_out()
       {
           this.f2.Close();
           Form1 f1 = new Form1(this.db1);
           f1.Show();
       }

    }
}
