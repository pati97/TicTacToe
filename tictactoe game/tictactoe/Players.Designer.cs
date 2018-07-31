namespace tictactoe
{
    partial class Form_Players
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
            this.Txt_player1 = new System.Windows.Forms.TextBox();
            this.Txt_player2 = new System.Windows.Forms.TextBox();
            this.l_player1 = new System.Windows.Forms.Label();
            this.l_player2 = new System.Windows.Forms.Label();
            this.button_play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_player1
            // 
            this.Txt_player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_player1.Location = new System.Drawing.Point(168, 18);
            this.Txt_player1.Name = "Txt_player1";
            this.Txt_player1.Size = new System.Drawing.Size(284, 35);
            this.Txt_player1.TabIndex = 0;
            // 
            // Txt_player2
            // 
            this.Txt_player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_player2.Location = new System.Drawing.Point(168, 67);
            this.Txt_player2.Name = "Txt_player2";
            this.Txt_player2.Size = new System.Drawing.Size(284, 35);
            this.Txt_player2.TabIndex = 1;
            this.Txt_player2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_player2_KeyPress);
            // 
            // l_player1
            // 
            this.l_player1.AutoSize = true;
            this.l_player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_player1.Location = new System.Drawing.Point(23, 24);
            this.l_player1.Name = "l_player1";
            this.l_player1.Size = new System.Drawing.Size(139, 29);
            this.l_player1.TabIndex = 2;
            this.l_player1.Text = "Player One:";
            // 
            // l_player2
            // 
            this.l_player2.AutoSize = true;
            this.l_player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_player2.Location = new System.Drawing.Point(23, 73);
            this.l_player2.Name = "l_player2";
            this.l_player2.Size = new System.Drawing.Size(141, 29);
            this.l_player2.TabIndex = 3;
            this.l_player2.Text = "Player Two:";
            // 
            // button_play
            // 
            this.button_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_play.Location = new System.Drawing.Point(341, 123);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(111, 39);
            this.button_play.TabIndex = 4;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // Form_Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 174);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.l_player2);
            this.Controls.Add(this.l_player1);
            this.Controls.Add(this.Txt_player2);
            this.Controls.Add(this.Txt_player1);
            this.MaximumSize = new System.Drawing.Size(500, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 230);
            this.Name = "Form_Players";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_player1;
        private System.Windows.Forms.TextBox Txt_player2;
        private System.Windows.Forms.Label l_player1;
        private System.Windows.Forms.Label l_player2;
        private System.Windows.Forms.Button button_play;
    }
}