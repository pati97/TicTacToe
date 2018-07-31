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
    public partial class TicTacToe : Form
    {
        bool turn = true; // if true - X turn, false - 0 turn
        int turn_count = 0;
        static string player1, player2;
        bool against_computer = false;

        public TicTacToe()
        {
            InitializeComponent();
        }

        public static void SetPlayerNames(String name1, String name2)
        {
            player1 = name1;
            player2 = name2;
        }

        public static void SetOnePlayerName(String name1)
        {
            player1 = name1;
            player2 = "Computer";
           
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Patrycja", "Tic Tac Toe About");             
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Infomate", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    b.BackColor = Color.LightSteelBlue;
                }
                catch { }
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(turn)
            {
                b.Text = "X";
                b.ForeColor = Color.Red;
            }
            else
            { 
                b.Text = "O";
                b.ForeColor = Color.Blue;
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
            
            if((!turn) && (against_computer) && (turn_count<=9))
            {
                Computer_make_move();
            }
        }

        private void checkForWinner()
        {
            bool it_is_a_winner = false;

            //horizontal  checks
            if ((btnA1.Text == btnA2.Text) && (btnA2.Text == btnA3.Text) && (!btnA1.Enabled))
            {
                btnA1.BackColor = Color.LimeGreen;
                btnA2.BackColor = Color.LimeGreen;
                btnA3.BackColor = Color.LimeGreen;
                it_is_a_winner = true;
            }
            else if ((btnB1.Text == btnB2.Text) && (btnB2.Text == btnB3.Text) && (!btnB1.Enabled))
            {
                btnB1.BackColor = Color.LimeGreen;
                btnB2.BackColor = Color.LimeGreen;
                btnB3.BackColor = Color.LimeGreen;
                it_is_a_winner = true;
            }
            else if ((btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text) && (!btnC1.Enabled))
            {
                btnC1.BackColor = Color.LimeGreen;
                btnC2.BackColor = Color.LimeGreen;
                btnC3.BackColor = Color.LimeGreen;
                it_is_a_winner = true;
            }

            //vertical checks
            if ((btnA1.Text == btnB1.Text) && (btnB1.Text == btnC1.Text) && (!btnA1.Enabled))
            {
                btnA1.BackColor = Color.LimeGreen;
                btnB1.BackColor = Color.LimeGreen;
                btnC1.BackColor = Color.LimeGreen;
                it_is_a_winner = true;
            }
            else if ((btnA2.Text == btnB2.Text) && (btnB2.Text == btnC2.Text) && (!btnA2.Enabled))
            {
                btnA2.BackColor = Color.LimeGreen;
                btnB2.BackColor = Color.LimeGreen;
                btnC2.BackColor = Color.LimeGreen;
                it_is_a_winner = true;
            }
            else if ((btnA3.Text == btnB3.Text) && (btnB3.Text == btnC3.Text) && (!btnA3.Enabled))
            {
                btnA3.BackColor = Color.LimeGreen;
                btnB3.BackColor = Color.LimeGreen;
                btnC3.BackColor = Color.LimeGreen;
                it_is_a_winner = true;
            }

            //diagonal checks
            if ((btnA1.Text == btnB2.Text) && (btnB2.Text == btnC3.Text) && (!btnA1.Enabled))
            {
                btnA1.BackColor = Color.LimeGreen;
                btnB2.BackColor = Color.LimeGreen;
                btnC3.BackColor = Color.LimeGreen;
                it_is_a_winner = true;
            }
            else if ((btnA3.Text == btnB2.Text) && (btnB2.Text == btnC1.Text) && (!btnA3.Enabled))
            {
                btnA3.BackColor = Color.LimeGreen;
                btnB2.BackColor = Color.LimeGreen;
                btnC1.BackColor = Color.LimeGreen;
                it_is_a_winner = true;
            }


            if (it_is_a_winner)
            {
                disableButtons();

                String winner;
                if (turn)
                {
                    winner = player2;
                    l_o_count.Text = (Int32.Parse(l_o_count.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    l_x_count.Text = (Int32.Parse(l_x_count.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " wins!", "Who won ?");
               
            }
            else
            {
                
                if (turn_count == 9)
                {
                    l_draw_count.Text = (Int32.Parse(l_draw_count.Text) + 1).ToString();
                    MessageBox.Show("Draw!","Who won ?");
                }

            }
        }

        private void disableButtons()
        {
           
           foreach (Control c in Controls)
           {
              try
              {
                  Button b = (Button)c;
                  b.Enabled = false;
              }
              catch { }
           }
           
        }

        private void Computer_make_move()
        {
            Button move = null;
            move = look_for_win_or_block("O");          //win O
            if(move==null)
            {
                move = look_for_win_or_block("X");      //block X
                if(move==null)
                {
                    move = look_for_corner();           //look for corner in board
                    if (move == null)
                    {
                        move = look_for_open_space();     //look for open space in board 
                    }
                }
            }
            if (turn_count < 9)
            {
                move.PerformClick();
            }
        }

        private Button look_for_win_or_block(string mark)
        {
            //horizontal test 

            if ((btnA1.Text == mark) && (btnA2.Text == mark) && (btnA3.Text == ""))
                return btnA3;
            else if ((btnA2.Text == mark) && (btnA3.Text == mark) && (btnA1.Text == ""))
                return btnA1;
            else if ((btnA1.Text == mark) && (btnA3.Text == mark) && (btnA2.Text == ""))
                return btnA2;

            if ((btnB1.Text == mark) && (btnB2.Text == mark) && (btnB3.Text == ""))
                return btnB3;
            if ((btnB2.Text == mark) && (btnB3.Text == mark) && (btnB1.Text == ""))
                return btnB1;
            if ((btnB1.Text == mark) && (btnB3.Text == mark) && (btnB2.Text == ""))
                return btnB2;

            if ((btnC1.Text == mark) && (btnC2.Text == mark) && (btnC3.Text == ""))
                return btnC3;
            if ((btnC2.Text == mark) && (btnC3.Text == mark) && (btnC1.Text == ""))
                return btnC1;
            if ((btnC1.Text == mark) && (btnC3.Text == mark) && (btnC2.Text == ""))
                return btnC2;

            //vertical test 

            if ((btnA1.Text == mark) && (btnB1.Text == mark) && (btnC1.Text == ""))
                return btnC1;
            else if ((btnB1.Text == mark) && (btnC1.Text == mark) && (btnA1.Text == ""))
                return btnA1;
            else if ((btnA1.Text == mark) && (btnC1.Text == mark) && (btnB1.Text == ""))
                return btnB1;

            if ((btnA2.Text == mark) && (btnB2.Text == mark) && (btnC2.Text == ""))
                return btnC2;
            else if ((btnB2.Text == mark) && (btnC2.Text == mark) && (btnA2.Text == ""))
                return btnA2;
            else if ((btnA2.Text == mark) && (btnC2.Text == mark) && (btnB2.Text == ""))
                return btnB2;

            if ((btnA3.Text == mark) && (btnB3.Text == mark) && (btnC3.Text == ""))
                return btnC3;
            else if ((btnB3.Text == mark) && (btnC3.Text == mark) && (btnA3.Text == ""))
                return btnA3;
            else if ((btnA3.Text == mark) && (btnC3.Text == mark) && (btnB3.Text == ""))
                return btnB3;

            //diagonal test 

            if ((btnA1.Text == mark) && (btnB2.Text == mark) && (btnC3.Text == ""))
                return btnC3;
            if ((btnB2.Text == mark) && (btnC3.Text == mark) && (btnA1.Text == ""))
                return btnA1;
            if ((btnA1.Text == mark) && (btnC3.Text == mark) && (btnB2.Text == ""))
                return btnB2;

            if ((btnA3.Text == mark) && (btnB2.Text == mark) && (btnC1.Text == ""))
                return btnC1;
            if ((btnB2.Text == mark) && (btnC1.Text == mark) && (btnA3.Text == ""))
                return btnA3;
            if ((btnA3.Text == mark) && (btnC1.Text == mark) && (btnB2.Text == ""))
                return btnB2;

            return null;
        }

        private Button look_for_corner()
        {
            if(btnA1.Text=="O")
            {
                if(btnA3.Text =="")
                    return btnA3;
                if (btnC1.Text =="")
                    return btnC1;
                if (btnC3.Text == "")
                    return btnC3;
            }
            if (btnA3.Text == "O")
            {
                if (btnA1.Text == "")
                    return btnA1;
                if (btnC1.Text == "")
                    return btnC1;
                if (btnC3.Text == "")
                    return btnC3;
            }
            if (btnC1.Text == "O")
            {
                if (btnA3.Text == "")
                    return btnA3;
                if (btnA1.Text == "")
                    return btnA1;
                if (btnC3.Text == "")
                    return btnC3;
            }
            if (btnC3.Text == "O")
            {
                if (btnA3.Text == "")
                    return btnA3;
                if (btnC1.Text == "")
                    return btnC1;
                if (btnA1.Text == "")
                    return btnA1;
            }

            if (btnA1.Text == "")
                return btnA1;
            if (btnA3.Text == "")
                return btnA3;
            if (btnC1.Text == "")
                return btnC1;
            if (btnC3.Text == "")
                return btnC3;
            
            return null;
        }

        private Button look_for_open_space()
        {
            Button b = null;
            foreach(Control c in Controls)
            {
                b = c as Button;
                if(b != null)
                {
                    if(b.Text == "")
                        return b;
                }
            }

            return null;
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                {
                    b.Text = "X";
                    b.ForeColor = Color.Red;
                }
                else
                {
                    b.Text = "O";
                    b.ForeColor = Color.Blue;
                }
            }
        }

        private void resetWinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l_x_count.Text = "0";
            l_draw_count.Text = "0";
            l_o_count.Text = "0";
        }

        private void backToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form_tic = new TicTacToe();
            form_tic.ShowDialog();
            this.Close();
        }

        private void Tic_Tac_Toe_Load(object sender, EventArgs e)
        {
            Form form_main = new Main_Menu();
            form_main.ShowDialog();

            label_X.Text = player1;
            label_O.Text = player2;
            if (label_O.Text == "Computer") against_computer = true;
        }
    }
}
