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
        public Form1()
        {
           // db1 = new Database();
           // db1.init();
            InitializeComponent();
          // auth1 = new Auth(db1);
        }
        private void form1_button_signin_Click(object sender, EventArgs e)
        {
            //auth1.login(form1_textBoxUsername.Text, form1_textBoxPass.Text);
        }

        private void form1_button_signup_Click(object sender, EventArgs e)
        {
          //  auth1.create_user(form1_tab2_pass.Text, form1_tab2_username.Text, form1_tab2_firstName.Text, form1_tab2_lastName.Text);
       
        
        }
    }
}
