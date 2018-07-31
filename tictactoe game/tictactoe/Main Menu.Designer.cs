namespace tictactoe
{
    partial class Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_one_player = new System.Windows.Forms.Button();
            this.button_two_players = new System.Windows.Forms.Button();
            this.button_options = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_one_player
            // 
            this.button_one_player.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_one_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_one_player.Location = new System.Drawing.Point(136, 251);
            this.button_one_player.Name = "button_one_player";
            this.button_one_player.Size = new System.Drawing.Size(256, 53);
            this.button_one_player.TabIndex = 0;
            this.button_one_player.Text = "One Player";
            this.button_one_player.UseVisualStyleBackColor = false;
            this.button_one_player.Click += new System.EventHandler(this.button_one_player_Click);
            // 
            // button_two_players
            // 
            this.button_two_players.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_two_players.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_two_players.Location = new System.Drawing.Point(136, 324);
            this.button_two_players.Name = "button_two_players";
            this.button_two_players.Size = new System.Drawing.Size(256, 51);
            this.button_two_players.TabIndex = 1;
            this.button_two_players.Text = "Two Players";
            this.button_two_players.UseVisualStyleBackColor = false;
            this.button_two_players.Click += new System.EventHandler(this.button_two_player_Click);
            // 
            // button_options
            // 
            this.button_options.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_options.Location = new System.Drawing.Point(136, 397);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(256, 53);
            this.button_options.TabIndex = 2;
            this.button_options.Text = "Options";
            this.button_options.UseVisualStyleBackColor = false;
            // 
            // button_quit
            // 
            this.button_quit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_quit.Location = new System.Drawing.Point(136, 470);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(256, 50);
            this.button_quit.TabIndex = 3;
            this.button_quit.Text = "Quit";
            this.button_quit.UseVisualStyleBackColor = false;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "TIC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(190, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 59);
            this.label2.TabIndex = 5;
            this.label2.Text = "TAC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(337, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 59);
            this.label3.TabIndex = 6;
            this.label3.Text = "TOE";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(514, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_options);
            this.Controls.Add(this.button_two_players);
            this.Controls.Add(this.button_one_player);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_one_player;
        private System.Windows.Forms.Button button_two_players;
        private System.Windows.Forms.Button button_options;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}