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
    public partial class FormLogin : Form
    {
        public FormTitleScreen FormTitleScreen;
        public FormLogin()
        {
            InitializeComponent();
            this.Icon = new Icon("Poker.ico");
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            UserAccount user = new UserAccount();
            user.LoadFromFile(txtUserName.Text, txtPassword.Text);
            if (user.invalidinput == false)
            {
                FormTitleScreen.user = new UserAccount(user);
                Close();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
