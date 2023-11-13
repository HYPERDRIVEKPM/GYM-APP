using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_APP
{
    public partial class AddMember : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-VPSGF32H; Database = GYMAPP; User Id = Kpmoo; Password =; Trusted_connection = yes;");
        class Employee
        {
            int EmpNum
            { get; set; }
            string Password
            { get; set; }

            public Employee(int empNum, string password)
            {
                this.EmpNum = empNum;
                this.Password = password;
            }
        }
        class Member
        {
            public double ID
            { get; set; }
            public string Name
            { get; set; }

            public Member(double ID, string Name)
            {
                this.ID = ID;
                this.Name = Name;
            }


        }
        class Standard : Member
        {
            public string Membership = "Stanard";
            public int Fee = 199;
            public string Spa = "NO";
            public Standard(double ID, string Name) : base(ID, Name)
            {

            }
        }
        class Vip : Member
        {
            public string Membership = "Vip";
            public int Fee = 299;
            public string Spa = "YES";
            public Vip(double ID, string Name) : base(ID, Name)
            {

            }
        }

        public AddMember()
        {
            InitializeComponent();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            IDtxtbox.Text = "";
            Nametxtbox.Text = "";
            Numbertxtbox.Text = "";
            Vipbtn.Checked = false;
            Standardbtn.Checked = false;
            timer.Start();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Mainmenu mainmenu = new Mainmenu();
            mainmenu.Show();
            this.Hide();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            IDtxtbox.Text = "";
            Nametxtbox.Text = "";
            Numbertxtbox.Text = "";
            Vipbtn.Checked = false;
            Standardbtn.Checked = false;
            Memberinfo.Columns.Clear();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (IDtxtbox.Text == null && Nametxtbox.Text == null)
            {
                MessageBox.Show("Please enter valid ID please try again!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Open();
                double id;
                id = double.Parse(IDtxtbox.Text);
                SqlCommand check = new SqlCommand("Select * from Members Where ID = '" + id + "'", con);
                SqlDataReader reader = check.ExecuteReader();
                if (reader.Read())
                {
                    con.Close();
                    MessageBox.Show("Member already exists! Please check ID number and try again!");
                }
                else
                {
                    con.Close();
                    if (Standardbtn.Checked)
                    {
                        con.Open();
                        Standard Newstanadrd = new Standard(id, Nametxtbox.Text);
                        SqlCommand cmdstandard = new SqlCommand("INSERT INTO Members ([ID],[Name],[Membership],[Fee],[Spa]) VALUES ('" + Newstanadrd.ID + "','" + Newstanadrd.Name + "','" + Newstanadrd.Membership + "','" + Newstanadrd.Fee + "','" + Newstanadrd.Spa + "')", con);
                        cmdstandard.ExecuteNonQuery();
                        con.Close();
                        SqlCommand cmd = new SqlCommand("select * From Members Where ID = '" + IDtxtbox.Text + "'", con);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                        sqlDataAdapter.SelectCommand = cmd;
                        sqlDataAdapter.Fill(dt);
                        BindingSource bs = new BindingSource();
                        bs.DataSource = dt;
                        Memberinfo.DataSource = bs;
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        Standard Newstanadrd = new Standard(id, Nametxtbox.Text);
                        SqlCommand cmdvip = new SqlCommand("INSERT INTO Members ([ID],[Name],[Membership],[Fee],[Spa]) VALUES ('" + Newstanadrd.ID + "','" + Newstanadrd.Name + "','" + Newstanadrd.Membership + "','" + Newstanadrd.Fee + "','" + Newstanadrd.Spa + "')", con);
                        cmdvip.ExecuteNonQuery();
                        con.Close();
                        SqlCommand cmd = new SqlCommand("select * From Members Where ID= '" + IDtxtbox.Text + "'", con);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                        sqlDataAdapter.SelectCommand = cmd;
                        sqlDataAdapter.Fill(dt);
                        BindingSource bs = new BindingSource();
                        bs.DataSource = dt;
                        Memberinfo.DataSource = bs;
                        con.Close();
                    }
                }
            }
        }

        private void Standardbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Vipbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void IDtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }

        private void Memberinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand check = new SqlCommand("Select * From Members Where ID = '" + IDtxtbox.Text + "'", con);
            SqlDataReader sqlDataReader = check.ExecuteReader();
            if (!sqlDataReader.Read())
            {
                MessageBox.Show("Member not found! please try again!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Close();
                SqlCommand cmd = new SqlCommand("Delete from Members Where ID = '" + IDtxtbox.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Member Deleted!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
