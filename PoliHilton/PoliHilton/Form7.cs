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
    public partial class Form7 : Form
    {
        Users u1;
        Database db1;
        public Form7(Users u1)
        {
            InitializeComponent();
            this.u1 = u1;
            this.Show();
            u1.init_form7_fields(form7_cb_roomType, form7_cb_price, form7_cb_roomCap,Form7_label_name);

        }

        private void form7_llabel_signout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            u1.log_out(0);
        }

        private void form7_btn_search_Click(object sender, EventArgs e)
        {
            u1.search_rooms(form7_cb_roomType, form7_cb_price, form7_cb_roomCap, form7_dtp_start, form7_dtp_end, Form7_lb);
        }

        private void Form7_btn_reserve_Click(object sender, EventArgs e)
        {
            int number = u1.reserve_room(Form7_lb);
            u1.final_reserve_room(u1,number);

        }
      
        
    }
}
