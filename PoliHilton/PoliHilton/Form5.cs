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
    public partial class Form5 : Form
    {
        Users u1;
        public Form5(Users u1)
        {
            InitializeComponent();
            this.u1 = u1;
            u1.init_f5(this);
        }
    }
}
