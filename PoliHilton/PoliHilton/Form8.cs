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
        int room_number;
        public Form8(Users u1,int room_number)
        {
            InitializeComponent();
            this.u1 = u1;
            this.room_number = room_number;
            this.Show();
            u1.fill_room_fields_final(form8_tb_roomName, form8_tb_roomNo, form8_tb_roomFloor, form8_tb_roomCap, form8_tb_roomSurface,form8_tb_roomOrientation,form8_tb_roomPrice,form8_tb_roomDisc,form8_tb_total,room_number);
            MessageBox.Show(room_number.ToString());
        }
    }

}
