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
    public partial class ViewMember : Form
    {
        DataTable dt = new DataTable();
        public ViewMember()
        {
            InitializeComponent();
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
            MemberIDtxtbox.Text = "";
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
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
