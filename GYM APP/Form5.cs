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
    public partial class Payment : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-VPSGF32H; Database = GYMAPP; User Id = Kpmoo; Password =; Trusted_connection = yes;");
        DataTable dt = new DataTable();
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            IDtxtbox.Text = "";
            Paymenttxtbox.Text = "";
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
            Paymenttxtbox.Text = "";
            Memberinfo.Columns.Clear();
        }

        private void IDtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * From Members Where ID = '" + IDtxtbox.Text + "'", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = cmd;
            sqlDataAdapter.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            Memberinfo.DataSource = bs;
            con.Close();
        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE [Members] SET [Fee] = Fee - '" + Paymenttxtbox.Text + "' Where ID = '" + IDtxtbox.Text + "' ", con);
            sqlCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Payment Sucsessful!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }
    }
}
