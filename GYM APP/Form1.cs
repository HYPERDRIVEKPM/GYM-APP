using System.Data.SqlClient;

namespace GYM_APP
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-VPSGF32H; Database = GYMAPP; User ID = kpmoo; Password =; Trusted_connection = Yes;");
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Empidtxtbox.Text = "";
            Passwordtxtbox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Employees Where Employee_Number = '" + Empidtxtbox.Text + "' and Password = '" + Passwordtxtbox.Text + "'", con);
            SqlDataReader read = cmd.ExecuteReader();
            if(read.Read())
            {
                Mainmenu mainmenu = new Mainmenu();
                mainmenu.Show();
                this.Hide();
            }
            else
            {
                con.Close();
                MessageBox.Show("Please check Employee Number and Password and try again!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empidtxtbox.Text = "";
            Passwordtxtbox.Text = "";
        }
    }
}