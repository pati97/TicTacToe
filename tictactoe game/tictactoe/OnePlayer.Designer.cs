namespace tictactoe
{
    partial class OnePlayerForm
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
            this.Txt_player = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_player
            // 
            this.Txt_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Txt_player.Location = new System.Drawing.Point(157, 26);
            this.Txt_player.Name = "Txt_player";
            this.Txt_player.Size = new System.Drawing.Size(214, 32);
            this.Txt_player.TabIndex = 0;
            this.Txt_player.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_player_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Name";
            // 
            // Button_play
            // 
            this.Button_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_play.Location = new System.Drawing.Point(234, 79);
            this.Button_play.Name = "Button_play";
            this.Button_play.Size = new System.Drawing.Size(110, 39);
            this.Button_play.TabIndex = 2;
            this.Button_play.Text = "PLAY";
            this.Button_play.UseVisualStyleBackColor = true;
            this.Button_play.Click += new System.EventHandler(this.Button_play_Click);
            // 
            // OnePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 141);
            this.Controls.Add(this.Button_play);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_player);
            this.Name = "OnePlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnePlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_play;
    }
}