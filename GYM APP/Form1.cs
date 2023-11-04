namespace GYM_APP
{
    public partial class Login : Form
    {
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
            if (Empidtxtbox.Text == "admin" & Passwordtxtbox.Text == "Pascarlkm1")
            {
                Mainmenu mainmenu = new Mainmenu();
                mainmenu.Show();
                this.Hide();
            }
            else
            {
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