using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_APP
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Viewmemberbtn_Click(object sender, EventArgs e)
        {
            ViewMember viewMember = new ViewMember();
            viewMember.Show();
            this.Hide();
        }

        private void Addmemberbtn_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
            this.Hide();
        }

        private void Paymentbtn_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
        }

        private void Gatebtn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Gate Opened!", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Loggedinlabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Loggedinlabel.Text = DateTime.Now.ToString();
        }
    }
}
