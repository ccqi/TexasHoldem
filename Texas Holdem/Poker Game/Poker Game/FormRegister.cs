using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poker_Game
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            this.Icon = new Icon("Poker.ico");
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "default" || txtPass.Text == "default") //default must not become a viable username (it is the default for a reason and also to indicate that no user has logged in)
            {
                MessageBox.Show("<default> as a password or a username is not allowed.");
            }
            else if (txtUserName.Text == "" || txtPass.Text == "" || txtPass.Text == "" || txtReEnterPass.Text == "")
            {
                MessageBox.Show("Please fill in the all the boxes to register.");
            }
            else if (txtPass.Text != txtReEnterPass.Text)
            {
                MessageBox.Show("Re-entered password must be the same as password.");
            }
            else
            {
                UserAccount user = new UserAccount(txtUserName.Text, txtPass.Text, txtPlayerName.Text);
                user.WriteToFile();
                Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
