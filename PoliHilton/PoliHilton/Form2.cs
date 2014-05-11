using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliHilton
{
    public partial class Form2 : Form
    {
        //every button must call a function of the class that controlls it : required by Prof
        //Lat form only log out required
        Admin a1;
        Database db1;
        public Form2(String username,Database db1)
        {
            InitializeComponent();
            this.Show();
            this.db1 = db1;
            init_admin(username);           
            form_initialization_data();
        }

        public void form_initialization_data()
        {
            a1.dataset_populate(form2_dataGridView_Cleaner,3);
            a1.dataset_populate(form2_dataGridView_Manager, 2);
            a1.dataset_populate(form2_DataGridView_Customer, 1);
            a1.dataset_populate(form2_DataGridView_Reception, 4);
        }

        public void init_admin(String username)
        {
            String db_command="SELECT * FROM [polihilton].[dbo].[Users] Where username='"+username+"'";
         DataSet ds1=db1.Read(db_command);
         DataRow dr1 = ds1.Tables[0].Rows[0];
         this.a1 = new Admin(int.Parse(dr1["u_id"].ToString()), dr1["firstName"].ToString(), dr1["lastName"].ToString(),this.db1);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void adsadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asdsaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void discountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1.adding_user(form2_Cleaner_UserName, form2_Cleaner_Password, form2_Cleaner_FirstName, form2_Cleaner_LastName,3);
            form_initialization_data();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void form2_SelectBtn_Cleaner_Click(object sender, EventArgs e)
        {
            a1.dataset_select(form2_dataGridView_Cleaner, form2_Cleaner_FirstName, form2_Cleaner_LastName, form2_Cleaner_UserName, form2_Cleaner_Password);
        }

        private void logut_button_admin_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(this.db1);
            this.Hide();
            f1.Show();
        }

        private void form2_dataGridView_Cleaner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.dataset_select(form2_dataGridView_Cleaner, form2_Cleaner_FirstName, form2_Cleaner_LastName, form2_Cleaner_UserName, form2_Cleaner_Password);
        }

        private void form2_SelectBtn_Manager_Click(object sender, EventArgs e)
        {
            a1.dataset_select(form2_dataGridView_Manager,textBox8, form2_Manager_LastName, form2_Manager_UserName, form2_Manager_Password);
        
        }

        private void form2_dataGridView_Manager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.dataset_select(form2_dataGridView_Manager, textBox8, form2_Manager_LastName, form2_Manager_UserName, form2_Manager_Password);
        }

        private void form2_SelectBtn_Customer_Click(object sender, EventArgs e)
        {
            a1.dataset_select(form2_DataGridView_Customer, form2_Customer_FirstName, form2_Customer_LastName, form2_Customer_UserName, form2_Customer_Password);
        }

        private void form2_DataGridView_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.dataset_select(form2_DataGridView_Customer, form2_Customer_FirstName, form2_Customer_LastName, form2_Customer_UserName, form2_Customer_Password);
        }

        private void form2_DataGridView_Reception_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.dataset_select(form2_DataGridView_Reception, form2_Reception_FirstName, form2_Reception_LastName, form2_Reception_UserName, form2_Reception_Password);
        }

        private void form2_SelectBtn_Reception_Click(object sender, EventArgs e)
        {
            a1.dataset_select(form2_DataGridView_Reception, form2_Reception_FirstName, form2_Reception_LastName, form2_Reception_UserName, form2_Reception_Password);
        }

        private void form2_AddNewBtn_Manager_Click(object sender, EventArgs e)
        {
            a1.adding_user(form2_Manager_UserName, form2_Manager_Password, textBox8, form2_Manager_LastName, 2);
            form_initialization_data();
        }

        private void form2_AddNewBtn_Customer_Click(object sender, EventArgs e)
        {
            a1.adding_user(form2_Customer_UserName, form2_Customer_Password, form2_Customer_FirstName, form2_Customer_LastName, 1);
            form_initialization_data();
        }

        private void form2_AddNewBtn_Reception_Click(object sender, EventArgs e)
        {
            a1.adding_user(form2_Reception_UserName, form2_Reception_Password, form2_Reception_FirstName, form2_Reception_LastName, 4);
            form_initialization_data();
        }

        private void form2_DeleteBtn_Cleaner_Click(object sender, EventArgs e)
        {
            a1.delete_user(form2_dataGridView_Cleaner);
            form_initialization_data();

        }

        private void form2_DeleteBtn_Manager_Click(object sender, EventArgs e)
        {
            a1.delete_user(form2_dataGridView_Manager);
            form_initialization_data();
        }

        private void form2_ModifyBtn_Customer_Click(object sender, EventArgs e)
        {
        }

        private void form2_DeleteBtn_Reception_Click(object sender, EventArgs e)
        {
            a1.delete_user(form2_DataGridView_Reception);
            form_initialization_data();
        }

        private void form2_DeleteBtn_Customer_Click(object sender, EventArgs e)
        {
            a1.delete_user(form2_DataGridView_Customer);
            form_initialization_data();
        }
    }
}
