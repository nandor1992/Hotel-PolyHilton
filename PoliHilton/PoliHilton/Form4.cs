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
    public partial class Form4 : Form
    {
        //every button must call a function of the class that controlls it : required by Prof
        //Final form only log out required
       Reception r1;

        public Form4(Reception r1)
        {
            InitializeComponent();
            this.r1 = r1;
            this.Show();
            //added by nandor for init 
            //ar fi bine sa fie populat tabelul cand se creaza, asta la toate
            r1.reception_dataset_populate(form4_cb_roomid);

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void form4_button_createrezervation_Click(object sender, EventArgs e)
        {
            //Nandor: Asta nue bine aici, ar trebui asapara inainte savrei sa dai click pe reservation, la initalizare, sus am pus
            form4_cb_roomid.Items.Add("1");
            form4_cb_roomid.Items.Add("2");
            form4_cb_roomid.Items.Add("3");
           // r1.reception_dataset_populate(form4_cb_roomid);
            

        }

        private void form4_button_createuser_Click(object sender, EventArgs e)
        {
            if (form4_text_usertypeid.Text == "")
            {
                form4_text_usertypeid.Text="1";
            }
                r1.create_user(form4_text_username.Text, form4_text_password.Text, form4_text_firstname.Text, form4_text_lastname.Text, int.Parse(form4_text_usertypeid.Text));
        }

        private void form4_button_showrezervations_Click(object sender, EventArgs e)
        {

        }
    }
}
