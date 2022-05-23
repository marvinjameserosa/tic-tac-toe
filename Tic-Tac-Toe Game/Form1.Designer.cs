namespace Tic_Tac_Toe_Game
{
    partial class gameScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.game_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // game_Title
            // 
            this.game_Title.AutoSize = true;
            this.game_Title.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game_Title.ForeColor = System.Drawing.Color.White;
            this.game_Title.Location = new System.Drawing.Point(206, 38);
            this.game_Title.Name = "game_Title";
            this.game_Title.Size = new System.Drawing.Size(393, 83);
            this.game_Title.TabIndex = 0;
            this.game_Title.Text = "Tic-Tac-Toe";
            this.game_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.game_Title);
            this.Name = "gameScreen";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label game_Title;
    }
}