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
    public partial class Form3 : Form
    {
       Cleaning clean1;
       //every button must call a function of the class that controlls it : required by Prof
        //Final form only log out required
        public Form3(Cleaning clean1)
        {
            InitializeComponent();
            this.clean1 = clean1;
            this.Show();
            clean1.list_assigned_rooms(form3_lb);

        }

        private void form3_btn_asigne_Click(object sender, EventArgs e)
        {
            clean1.list_assigned_rooms(form3_lb);
        }

        private void form3_btn_submit_Click(object sender, EventArgs e)
        {
            // get info from dataset to clean1.cleaned(int roomid)
        }
        
        private void form3_btn_inProgress_Click(object sender, EventArgs e)
        {
            clean1.in_progress(form3_lb);
            clean1.list_assigned_rooms(form3_lb);
        }

        private void form3_btn_cleaned_Click(object sender, EventArgs e)
        {
            clean1.cleaned(form3_lb);
            clean1.list_assigned_rooms(form3_lb);
            //form3_clb.SelectedItem.

        }

        private void form3_llabel_signout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clean1.log_out();
        }
    }
}
