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
            r1.reception_dataset_populate_rid(form4_cb_roomnumber);
            r1.reception_dataset_populate_uname(form4_cb_username);

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void form4_button_createrezervation_Click(object sender, EventArgs e)
        {
            if (form4_cb_roomnumber.SelectedIndex >= 0 && form4_cb_username.SelectedIndex>=0)
            {
                form4_textPrice.Text = r1.calculate_price(int.Parse(form4_cb_roomnumber.SelectedItem.ToString())).ToString();
                //string check_in = form4_dtp_checkin.Value.ToString("dd-MM-yyyy");
                //string check_out = form4_dtp_checkout.Value.ToString("dd-MM-yyyy");
                DateTime check_in = form4_dtp_checkin.Value.Date; 
                DateTime check_out = form4_dtp_checkout.Value.Date;
                int uid=r1.return_uid(form4_cb_username.SelectedItem.ToString());
                int rid = r1.return_rid(int.Parse(form4_cb_roomnumber.SelectedItem.ToString()));
                r1.create_rezervation(rid, uid, check_in, check_out, int.Parse(form4_textPrice.Text));
                
            }
            else
            {
                MessageBox.Show("You must select the room and the username");
            }
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
