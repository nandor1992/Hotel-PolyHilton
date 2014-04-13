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
    public partial class Form8 : Form
    {
        Users u1;
        Reservation r1;
        public Form8(Users u1,Reservation r1)
        {
            InitializeComponent();
            this.u1 = u1;
            this.r1 = r1;
        }
    }
}
