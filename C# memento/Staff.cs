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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5FQ0CAB0;Initial Catalog=C#Project;Integrated Security=True");

        private void populate()
        {
            con.Open();
            string query = "Select * from StaffTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StaffDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        int staffkey;

        private void clear()
        {
            StaffNameTb.Text = "";
            StaffPhoneTb.Text = "";
            staffkey = 0;
            StaffGenderCb.SelectedIndex=-1;
            StaffPasswordTb.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StaffNameTb.Text == "" || StaffPasswordTb.Text == "" || StaffPhoneTb.Text == ""|| StaffGenderCb.SelectedIndex ==-1)
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into StaffTbl values('" + StaffNameTb.Text + "','" + StaffPhoneTb.Text + "','"+StaffGenderCb.SelectedItem.ToString()+ "','" + StaffPasswordTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Added");
                    con.Close();
                    populate();
                    clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (staffkey == 0)
            {
                MessageBox.Show("Select The Staff To Be Deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Delete from StaffTbl where StaffId=" + staffkey + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Deleted Successfully");
                    con.Close();
                    populate();
                    clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void StaffDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffNameTb.Text = StaffDGV.SelectedRows[0].Cells[1].Value.ToString();
            StaffPasswordTb.Text = StaffDGV.SelectedRows[0].Cells[2].Value.ToString();
            StaffGenderCb.SelectedItem = StaffDGV.SelectedRows[0].Cells[3].Value.ToString();
            StaffPhoneTb.Text = StaffDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (StaffNameTb.Text == "")
            {
                staffkey = 0;
            }
            else
            {
                staffkey = Convert.ToInt32(StaffDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StaffNameTb.Text == "" || StaffPhoneTb.Text == "" || StaffPasswordTb.Text == "" || StaffGenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update StaffTbl set StaffName='" + StaffNameTb.Text + "',StaffPassword='" + StaffPhoneTb.Text + "',StaffGender='" + StaffGenderCb.Text + "',StaffPhone='" + StaffPasswordTb.Text + "' where StaffId=" + staffkey + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Successfully Updated");
                    con.Close();
                    populate();
                    clear();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminPanel adminpanel = new AdminPanel();
            adminpanel.Show();
            this.Hide();
        }
    }
}
