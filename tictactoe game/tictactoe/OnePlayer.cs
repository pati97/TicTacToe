using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class OnePlayerForm : Form
    {
        public OnePlayerForm()
        {
            InitializeComponent();
        }

        public void Button_play_Click(object sender, EventArgs e)
        {
            TicTacToe.SetOnePlayerName(Txt_player.Text);
            this.Close();
        }

        private void Txt_player_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Button_play.PerformClick();
        }

    }
}
