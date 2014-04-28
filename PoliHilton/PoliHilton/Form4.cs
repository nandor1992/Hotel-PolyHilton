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

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
