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
        Reservation r1;
        Users u1;
        public Form7(Users u1)
        {
            InitializeComponent();
            this.u1 = u1;
            r1 = new Reservation();
        }
    }
}
