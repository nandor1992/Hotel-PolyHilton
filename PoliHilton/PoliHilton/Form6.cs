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
    public partial class Form6 : Form
    {
        Users u1;
        Reservation r1;
        public Form6(Users u1)
        {
            InitializeComponent();
            this.u1 = u1;
            r1 = new Reservation();
        }
    }
}
