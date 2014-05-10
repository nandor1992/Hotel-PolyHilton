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
    public partial class Form1 : Form
    {
        Auth auth1;
        Database db1;
        //Two constructors one is needed if we log out the other for basic log in
        //every button must call a function of the class that controlls it : required by Prof
        public Form1()
        {
            InitializeComponent();
            db1 = new Database();
            db1.init();
            auth1 = new Auth(db1);
        }
        public Form1(Database db1)
        {
            this.db1 = db1;
            InitializeComponent();
            auth1 = new Auth(db1);
        }
        private void form1_button_signin_Click(object sender, EventArgs e)
        {
            auth1.login(form1_textBoxUsername.Text.ToString(), form1_textBoxPass.Text.ToString());
            this.Hide();
        }

        private void form1_button_signup_Click(object sender, EventArgs e)
        {
            if (form1_tab2_firstName.Text == "" || form1_tab2_pass.Text == "" || form1_tab2_lastName.Text == "" || form1_tab2_username.Text=="")
            {
                MessageBox.Show("The field must not be NULL");
            }
            else if (form1_tab2_pass.Text != form1_tab2_confpass.Text)
            {
                MessageBox.Show("passwords doesnt match");
            }
            else
            {
                auth1.create_user(form1_tab2_username.Text, form1_tab2_pass.Text, form1_tab2_firstName.Text, form1_tab2_lastName.Text);
            }
        
        }
    }
}
