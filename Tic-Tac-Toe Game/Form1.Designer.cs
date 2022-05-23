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
            this.mainContainer = new System.Windows.Forms.Panel();
            this.gameGrid = new System.Windows.Forms.TableLayoutPanel();
            this.R3C3 = new System.Windows.Forms.Button();
            this.R3C2 = new System.Windows.Forms.Button();
            this.R3C1 = new System.Windows.Forms.Button();
            this.R2C3 = new System.Windows.Forms.Button();
            this.R2C2 = new System.Windows.Forms.Button();
            this.R2C1 = new System.Windows.Forms.Button();
            this.R1C3 = new System.Windows.Forms.Button();
            this.R1C2 = new System.Windows.Forms.Button();
            this.R1C1 = new System.Windows.Forms.Button();
            this.gameSatus = new System.Windows.Forms.Label();
            this.resetBTN = new System.Windows.Forms.Button();
            this.mainContainer.SuspendLayout();
            this.gameGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // game_Title
            // 
            this.game_Title.AutoSize = true;
            this.game_Title.Font = new System.Drawing.Font("Ink Free", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game_Title.ForeColor = System.Drawing.Color.White;
            this.game_Title.Location = new System.Drawing.Point(87, 21);
            this.game_Title.Name = "game_Title";
            this.game_Title.Size = new System.Drawing.Size(393, 83);
            this.game_Title.TabIndex = 0;
            this.game_Title.Text = "Tic-Tac-Toe";
            this.game_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.gameGrid);
            this.mainContainer.Location = new System.Drawing.Point(117, 190);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(339, 300);
            this.mainContainer.TabIndex = 1;
            // 
            // gameGrid
            // 
            this.gameGrid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.gameGrid.ColumnCount = 3;
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameGrid.Controls.Add(this.R3C3, 2, 2);
            this.gameGrid.Controls.Add(this.R3C2, 1, 2);
            this.gameGrid.Controls.Add(this.R3C1, 0, 2);
            this.gameGrid.Controls.Add(this.R2C3, 2, 1);
            this.gameGrid.Controls.Add(this.R2C2, 1, 1);
            this.gameGrid.Controls.Add(this.R2C1, 0, 1);
            this.gameGrid.Controls.Add(this.R1C3, 2, 0);
            this.gameGrid.Controls.Add(this.R1C2, 1, 0);
            this.gameGrid.Controls.Add(this.R1C1, 0, 0);
            this.gameGrid.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameGrid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.gameGrid.Location = new System.Drawing.Point(-9, -11);
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.RowCount = 3;
            this.gameGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gameGrid.Size = new System.Drawing.Size(357, 314);
            this.gameGrid.TabIndex = 0;
            // 
            // R3C3
            // 
            this.R3C3.FlatAppearance.BorderSize = 0;
            this.R3C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R3C3.Font = new System.Drawing.Font("Ink Free", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R3C3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(49)))));
            this.R3C3.Location = new System.Drawing.Point(242, 212);
            this.R3C3.Name = "R3C3";
            this.R3C3.Size = new System.Drawing.Size(109, 94);
            this.R3C3.TabIndex = 8;
            this.R3C3.UseVisualStyleBackColor = true;
            this.R3C3.Click += new System.EventHandler(this.R3C3_Click);
            // 
            // R3C2
            // 
            this.R3C2.FlatAppearance.BorderSize = 0;
            this.R3C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R3C2.Font = new System.Drawing.Font("Ink Free", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R3C2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(49)))));
            this.R3C2.Location = new System.Drawing.Point(124, 212);
            this.R3C2.Name = "R3C2";
            this.R3C2.Size = new System.Drawing.Size(109, 94);
            this.R3C2.TabIndex = 7;
            this.R3C2.UseVisualStyleBackColor = true;
            this.R3C2.Click += new System.EventHandler(this.R3C2_Click);
            // 
            // R3C1
            // 
            this.R3C1.FlatAppearance.BorderSize = 0;
            this.R3C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R3C1.Font = new System.Drawing.Font("Ink Free", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R3C1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(49)))));
            this.R3C1.Location = new System.Drawing.Point(6, 212);
            this.R3C1.Name = "R3C1";
            this.R3C1.Size = new System.Drawing.Size(109, 94);
            this.R3C1.TabIndex = 6;
            this.R3C1.UseVisualStyleBackColor = true;
            this.R3C1.Click += new System.EventHandler(this.R3C1_Click);
            // 
            // R2C3
            // 
            this.R2C3.FlatAppearance.BorderSize = 0;
            this.R2C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R2C3.Font = new System.Drawing.Font("Ink Free", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R2C3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(49)))));
            this.R2C3.Location = new System.Drawing.Point(242, 109);
            this.R2C3.Name = "R2C3";
            this.R2C3.Size = new System.Drawing.Size(109, 94);
            this.R2C3.TabIndex = 5;
            this.R2C3.UseVisualStyleBackColor = true;
            this.R2C3.Click += new System.EventHandler(this.R2C3_Click);
            // 
            // R2C2
            // 
            this.R2C2.FlatAppearance.BorderSize = 0;
            this.R2C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R2C2.Font = new System.Drawing.Font("Ink Free", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R2C2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(49)))));
            this.R2C2.Location = new System.Drawing.Point(124, 109);
            this.R2C2.Name = "R2C2";
            this.R2C2.Size = new System.Drawing.Size(109, 94);
            this.R2C2.TabIndex = 4;
            this.R2C2.UseVisualStyleBackColor = true;
            this.R2C2.Click += new System.EventHandler(this.R2C2_Click);
            // 
            // R2C1
            // 
            this.R2C1.FlatAppearance.BorderSize = 0;
            this.R2C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R2C1.Font = new System.Drawing.Font("Ink Free", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R2C1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(49)))));
            this.R2C1.Location = new System.Drawing.Point(6, 109);
            this.R2C1.Name = "R2C1";
            this.R2C1.Size = new System.Drawing.Size(109, 94);
            this.R2C1.TabIndex = 3;
            this.R2C1.UseVisualStyleBackColor = true;
            this.R2C1.Click += new System.EventHandler(this.R2C1_Click);
            // 
            // R1C3
            // 
            this.R1C3.FlatAppearance.BorderSize = 0;
            this.R1C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R1C3.Font = new System.Drawing.Font("Ink Free", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R1C3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(49)))));
            this.R1C3.Location = new System.Drawing.Point(242, 6);
            this.R1C3.Name = "R1C3";
            this.R1C3.Size = new System.Drawing.Size(109, 94);
            this.R1C3.TabIndex = 2;
            this.R1C3.UseVisualStyleBackColor = true;
            this.R1C3.Click += new System.EventHandler(this.R1C3_Click);
            // 
            // R1C2
            // 
            this.R1C2.FlatAppearance.BorderSize = 0;
            this.R1C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R1C2.Font = new System.Drawing.Font("Ink Free", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R1C2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(49)))));
            this.R1C2.Location = new System.Drawing.Point(124, 6);
            this.R1C2.Name = "R1C2";
            this.R1C2.Size = new System.Drawing.Size(109, 94);
            this.R1C2.TabIndex = 1;
            this.R1C2.UseVisualStyleBackColor = true;
            this.R1C2.Click += new System.EventHandler(this.R1C2_Click);
            // 
            // R1C1
            // 
            this.R1C1.FlatAppearance.BorderSize = 0;
            this.R1C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R1C1.Font = new System.Drawing.Font("Ink Free", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R1C1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(49)))));
            this.R1C1.Location = new System.Drawing.Point(6, 6);
            this.R1C1.Name = "R1C1";
            this.R1C1.Size = new System.Drawing.Size(109, 94);
            this.R1C1.TabIndex = 0;
            this.R1C1.UseVisualStyleBackColor = true;
            this.R1C1.Click += new System.EventHandler(this.R1C1_Click);
            // 
            // gameSatus
            // 
            this.gameSatus.AutoSize = true;
            this.gameSatus.Font = new System.Drawing.Font("Ink Free", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameSatus.ForeColor = System.Drawing.Color.White;
            this.gameSatus.Location = new System.Drawing.Point(154, 104);
            this.gameSatus.Name = "gameSatus";
            this.gameSatus.Size = new System.Drawing.Size(0, 49);
            this.gameSatus.TabIndex = 2;
            // 
            // resetBTN
            // 
            this.resetBTN.Location = new System.Drawing.Point(6, 288);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(96, 121);
            this.resetBTN.TabIndex = 3;
            this.resetBTN.Text = "RESET";
            this.resetBTN.UseVisualStyleBackColor = true;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(107)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(584, 524);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.gameSatus);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.game_Title);
            this.Name = "gameScreen";
            this.Text = "Tic-Tac-Toe";
            this.mainContainer.ResumeLayout(false);
            this.gameGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label game_Title;
        private Panel mainContainer;
        private TableLayoutPanel gameGrid;
        private Button R1C1;
        private Button R3C3;
        private Button R3C2;
        private Button R3C1;
        private Button R2C3;
        private Button R2C2;
        private Button R2C1;
        private Button R1C3;
        private Button R1C2;
        private Label gameSatus;
        private Button resetBTN;
    }
}