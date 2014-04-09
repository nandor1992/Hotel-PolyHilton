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

        public Form3(Cleaning clean1)
        {
            InitializeComponent();
            this.clean1 = clean1;
            this.clean1.init();

        }

        private void form3_btn_asigne_Click(object sender, EventArgs e)
        {
            //add data table from dataset clean1.list_assigned_rooms().
        }

        private void form3_btn_submit_Click(object sender, EventArgs e)
        {
            // get info from dataset to clean1.cleaned(int roomid)
        }
    }
}
