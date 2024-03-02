using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_and_register
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5FQ0CAB0;Initial Catalog=C#Project;Integrated Security=True");

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 create = new Form1();
            create.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select * from StaffTbl where StaffName='" + txtUsername.Text.Trim() + "' and StaffPassword='" + textpassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (txtUsername.Text=="" || textpassword.Text == "")
            {
                MessageBox.Show("Enter Username or Password");
            }
            else if(dt.Rows.Count==1)
            {
                MainForm mn = new MainForm();
                mn.Show();
                this.Hide();
            }
            else if(txtUsername.Text=="admin"&& textpassword.Text=="bolbo na")
            {
                AdminPanel adpnl = new AdminPanel();
                adpnl.Show();
                this.Hide();


            }

            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

            }
        private void clear()
        {
            txtUsername.Text = "";
            textpassword.Text = "";
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

    }
    }


