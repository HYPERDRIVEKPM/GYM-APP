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
    public partial class AddMember : Form
    {
        class Member
        {
            double ID
            { get; set; }
            string Name
            { get; set; }
            int Fee
            { get; set; }

            public Member(double ID, string Name, int Fee)
            {
                this.ID = ID;
                this.Name = Name;
                this.Fee = Fee;
            }
           
        }
        class Standard : Member
        {

            public Standard(double ID, string Name, int Fee) : base(ID, Name, Fee)
            {
                Fee = 199;
            }               
        }
        class Vip : Member
        {

            public Vip(double ID, string Name, int Fee) : base(ID, Name, Fee)
            {
                Fee = 299;
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
        }
    }
}
