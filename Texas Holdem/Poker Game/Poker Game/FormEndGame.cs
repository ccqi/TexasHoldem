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
    public partial class FormEndGame : Form
    {
        public FormPoker FormPoker;
        public FormEndGame(bool win)
        {
            InitializeComponent();
            this.Icon = new Icon("Poker.ico");
            if (win == true)
            {
                pbResult.BackgroundImage = Image.FromFile("WIN.jpg");
                lblBetterLuck.Hide();
            }
            else
            {
                pbResult.BackgroundImage = Image.FromFile("LOSE.jpg");
                lblBetterLuck.Show();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
            FormPoker.Close();
            
        }
    }
}
