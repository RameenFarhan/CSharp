using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_register
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void bookingbutton_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clint2 clint2 = new Clint2();
            clint2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmLogin frmlg = new FrmLogin();
            frmlg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewBooking2 viewbook2 = new ViewBooking2();
            viewbook2.Show();
            this.Hide();
        }
    }
}
