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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
            
        }

        private void button_two_player_Click(object sender, EventArgs e)
        {
            Form form_player1 = new Form_Players();
            form_player1.ShowDialog();
            this.Close();
        }

        private void button_one_player_Click(object sender, EventArgs e)
        {
            Form form_player2 = new OnePlayerForm();
            form_player2.ShowDialog();
            this.Close();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Infomate", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
