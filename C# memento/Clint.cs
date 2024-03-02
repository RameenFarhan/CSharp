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
    public partial class Clint : Form
    {
        public Clint()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5FQ0CAB0;Initial Catalog=C#Project;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            if(ClintNameTb.Text==""|| ClintAddressTb.Text == ""|| ClintPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into ClintTbl values('" + ClintNameTb.Text + "','" + ClintAddressTb.Text + "','" + ClintPhoneTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Clint Successfully Added");
                    con.Close();
                    populate();
                    clear();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void populate()
        {
            con.Open();
            string query = "Select * from ClintTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ClintDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Clint_Load(object sender, EventArgs e)
        {
            populate();
        }

        int Clintkey = 0;

        private void ClintDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //selected row problem
            
            /*ClintNameTb.Text = ClintDGV.SelectedRows[0].Cells[1].Value.ToString();
            ClintAddressTb.Text = ClintDGV.SelectedRows[0].Cells[2].Value.ToString();
            ClintPhoneTb.Text = ClintDGV.SelectedRows[0].Cells[3].Value.ToString();
            if(ClintPhoneTb.Text=="")
            {
                Clintkey = 0;
            }
            else
            {
                Clintkey = Convert.ToInt32(ClintDGV.SelectedRows[0].Cells[0].Value.ToString());
            } */

        }

        private void clear()
        {
            ClintPhoneTb.Text = "";
            ClintAddressTb.Text = "";
            Clintkey = 0;
            ClintNameTb.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Clintkey==0)
            {
                MessageBox.Show("Select The Clint To Be Deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Delete from ClintTbl where ClintId=" + Clintkey + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Clint Deleted Successfully");
                    con.Close();
                    populate();
                    clear();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ClintDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClintNameTb.Text = ClintDGV.SelectedRows[0].Cells[1].Value.ToString();
            ClintAddressTb.Text = ClintDGV.SelectedRows[0].Cells[2].Value.ToString();
            ClintPhoneTb.Text = ClintDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (ClintPhoneTb.Text == "")
            {
                Clintkey = 0;
            }
            else
            {
                Clintkey = Convert.ToInt32(ClintDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ClintNameTb.Text == "" || ClintAddressTb.Text == "" || ClintPhoneTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update ClintTbl set ClintName='"+ClintNameTb.Text+"',ClintAddress='"+ClintAddressTb.Text+"',ClintPhone='"+ClintPhoneTb.Text+"' where ClintId=" + Clintkey + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Clint Successfully Updated");
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

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm mnfrm = new MainForm();
            mnfrm.Show();
            this.Hide();
        }

        private void ClintPhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClintAddressTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClintNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
