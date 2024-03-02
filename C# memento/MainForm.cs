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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clint clint = new Clint();
            clint.Show();
            this.Hide();

        }

        private void bookingbutton_Click(object sender, EventArgs e)
        {
            Booking book = new Booking();
            book.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewBooking book = new ViewBooking();
            book.Show();
            this.Hide();
        }
    }
}
