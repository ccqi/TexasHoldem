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
    public partial class FormGetMoney : Form
    {
        public FormGetMoney()
        {
            InitializeComponent();
            this.Icon = new Icon("Poker.ico");
        }
        public void setMoney(int minimum,int maximum) //sets minimum and maximum bet amounts
        {
            nudBetRaise.Minimum = minimum;
            nudBetRaise.Maximum = maximum;
            nudBetRaise.Value = minimum;
            tbRaise.Minimum = minimum;
            tbRaise.Maximum = maximum;
            tbRaise.Value = minimum;
        }

        private void tbRaise_Scroll(object sender, EventArgs e)
        {
            for (int i = tbRaise.Minimum; i < tbRaise.Maximum; i += tbRaise.TickFrequency)
            {
                if (tbRaise.Value - i > 0 && tbRaise.Value - i < tbRaise.TickFrequency)
                    tbRaise.Value = i;
            }
            nudBetRaise.Value = tbRaise.Value;
        }

        private void nudBetRaise_ValueChanged(object sender, EventArgs e)
        {
            if (nudBetRaise.Value < tbRaise.Minimum || nudBetRaise.Value > tbRaise.Maximum)
                return;
            tbRaise.Value = (int)nudBetRaise.Value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
