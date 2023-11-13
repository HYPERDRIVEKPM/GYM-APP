using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_APP
{
    public partial class ViewMember : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-VPSGF32H; Database = GYMAPP; User Id = Kpmoo; Password =; Trusted_connection = yes;");
        DataTable dt = new DataTable();
        public ViewMember()
        {
            InitializeComponent();
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
            MemberIDtxtbox.Text = "";
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
            MemberIDtxtbox.Text = "";
            dataGridView1.Columns.Clear();

        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * From Members Where ID = '" + MemberIDtxtbox.Text + "'", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = cmd;
            sqlDataAdapter.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            con.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void ViewAllbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * From Members", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = cmd;
            sqlDataAdapter.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            con.Close();
        }

        private void MemberIDtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
