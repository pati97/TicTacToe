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
    public partial class Form_Players : Form
    {
        public Form_Players()
        {
            InitializeComponent();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            TicTacToe.SetPlayerNames(Txt_player1.Text, Txt_player2.Text);
            this.Close();
        }

        private void Txt_player2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                button_play.PerformClick();
        }
    }
}
