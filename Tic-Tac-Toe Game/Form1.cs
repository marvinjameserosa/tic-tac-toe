namespace Tic_Tac_Toe_Game
{
    public partial class gameScreen : Form
    {
        /* FOR X AND O BUTTON */
        int num;

        /* FOR WIN SCENARIO */
        int R1C1VAL = 10;
        int R1C2VAL = 10;
        int R1C3VAL = 10;
        int R2C1VAL = 10;
        int R2C2VAL = 10;
        int R2C3VAL = 10;
        int R3C1VAL = 10;
        int R3C2VAL = 10;
        int R3C3VAL = 10;
        public gameScreen()
        {
            InitializeComponent();
        }

        private void R1C1_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R1C1.Text = "X";
                /* FOR WIN SCENARIO */
                R1C1VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R1C1.Text = "O";
                /* FOR WIN SCENARIO*/
                R1C1VAL = 0;
            }

            /* BUTTON DISABLE */
            R1C1.Enabled = false;

            /* O WIN SCENARIO */

                /*HORIZONTAL*/
            if (R1C1VAL == 0 & R1C2VAL == 0 & R1C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

                 /* VERTICAL */
            if (R1C1VAL == 0 & R2C1VAL == 0 & R3C1VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

                /* DIAGONAL */

            if (R1C1VAL == 0 & R2C2VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /*HORIZONTAL*/
            if (R1C1VAL == 1 & R1C2VAL == 1 & R1C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C1VAL == 1 & R2C1VAL == 1 & R3C1VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* DIAGONAL */

            if (R1C1VAL == 1 & R2C2VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R1C2_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R1C2.Text = "X";
                /* FOR WIN SCENARIO */
                R1C2VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R1C2.Text = "O";
                /* FOR WIN SCENARIO*/
                R1C2VAL = 0;
            }

            /* BUTTON DISABLE */
            R1C2.Enabled = false;

            /* O WIN SCENARIO */

                 /* HORIZONTAL */
            if (R1C1VAL == 0 & R1C2VAL == 0 & R1C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

                 /* VERTICAL */
            if (R1C2VAL == 0 & R2C2VAL == 0 & R3C2VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZONTAL */
            if (R1C1VAL == 1 & R1C2VAL == 1 & R1C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C2VAL == 1 & R2C2VAL == 1 & R3C2VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R1C3_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R1C3.Text = "X";
                /* FOR WIN SCENARIO */
                R1C3VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R1C3.Text = "O";
                /* FOR WIN SCENARIO*/
                R1C3VAL = 0;
            }

            /* BUTTON DISABLE */
            R1C3.Enabled = false;

            /* O WIN SCENARIO */
            
                /*HORIZOTAL*/
            if (R1C1VAL == 0 & R1C2VAL == 0 & R1C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

                /* VERTICAL */
            if (R1C3VAL == 0 & R2C3VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* DIAGONAL */
            if (R1C3VAL == 0 & R2C2VAL == 0 & R3C1VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZOTAL */
            if (R1C1VAL == 1 & R1C2VAL == 1 & R1C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C3VAL == 1 & R2C3VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* DIAGONAL */
            if (R1C3VAL == 1 & R2C2VAL == 1 & R3C1VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }
            /*DRAW SCENARIO*/
            else if (num > 8)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R2C1_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R2C1.Text = "X";
                /* FOR WIN SCENARIO */
                R2C1VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R2C1.Text = "O";
                /* FOR WIN SCENARIO*/
                R2C1VAL = 0;
            }

            /* BUTTON DISABLE */
            R2C1.Enabled = false;

            /* O WIN SCENARIO */

                /* HORIZOTAL */
            if (R2C1VAL == 0 & R2C2VAL == 0 & R2C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C1VAL == 0 & R2C1VAL == 0 & R3C1VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZOTAL */
            if (R2C1VAL == 1 & R2C2VAL == 1 & R2C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C1VAL == 1 & R2C1VAL == 1 & R3C1VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }
            /*DRAW SCENARIO*/
            else if (num > 8)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R2C2_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R2C2.Text = "X";
                /* FOR WIN SCENARIO */
                R2C2VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R2C2.Text = "O";
                /* FOR WIN SCENARIO*/
                R2C2VAL = 0;
            }

            /* BUTTON DISABLE */
            R2C2.Enabled = false;

            /* O WIN SCENARIO */

                /*HORIZONTAL*/
            if (R2C1VAL == 0 & R2C2VAL == 0 & R2C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }
                /* VERTICAL */
            if (R1C2VAL == 0 & R2C2VAL == 0 & R3C2VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

              /* DIAGONAL DESCENDING */
            
            if (R1C1VAL == 0 & R2C2VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C2.Enabled = false;
            }

             /* DIAGONAL ASCENDING */

            if (R1C3VAL == 0 & R2C2VAL == 0 & R3C1VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /*HORIZONTAL*/
            if (R2C1VAL == 1 & R2C2VAL == 1 & R2C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }
            /* VERTICAL */
            if (R1C2VAL == 1 & R2C2VAL == 1 & R3C2VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* DIAGONAL DESCENDING */

            if (R1C1VAL == 1 & R2C2VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C2.Enabled = false;
            }

            /* DIAGONAL ASCENDING */

            if (R1C3VAL == 1 & R2C2VAL == 1 & R3C1VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8)
            {
               gameSatus.Text = "Nobody Wins :(";
                
            }
        }

        private void R2C3_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R2C3.Text = "X";
                /* FOR WIN SCENARIO */
                R2C3VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R2C3.Text = "O";
                /* FOR WIN SCENARIO*/
                R2C3VAL = 0;
            }

            /* BUTTON DISABLE */
            R2C3.Enabled = false;

            /* O WIN SCENARIO */

                 /* HORIZONTAL */
            if (R2C1VAL == 0 & R2C2VAL == 0 & R2C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }
                
                /* VERTICAL */
            if (R1C3VAL == 0 & R2C3VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZONTAL */
            if (R2C1VAL == 1 & R2C2VAL == 1 & R2C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C3VAL == 1 & R2C3VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R3C1_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R3C1.Text = "X";
                /* FOR WIN SCENARIO */
                R3C1VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R3C1.Text = "O";
                /* FOR WIN SCENARIO*/
                R3C1VAL = 0;
            }

            /* BUTTON DISABLE */
            R3C1.Enabled = false;

            /* O WIN SCENARIO */

                /* HORIZONTAL */
            if (R3C1VAL == 0 & R3C2VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

                /* VERTICAL */
            if (R1C1VAL == 0 & R2C1VAL == 0 & R3C1VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* DIAGONAL */
            if (R1C3VAL == 0 & R2C2VAL == 0 & R3C1VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 1 & R3C2VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C1VAL == 1 & R2C1VAL == 1 & R3C1VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /* DIAGONAL */
            if (R1C3VAL == 1 & R2C2VAL == 1 & R3C1VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R3C2_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R3C2.Text = "X";
                /* FOR WIN SCENARIO */
                R3C2VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R3C2.Text = "O";
                /* FOR WIN SCENARIO*/
                R3C2VAL = 0;
            }

            /* BUTTON DISABLE */
            R3C2.Enabled = false;

            /* O WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 0 & R3C2VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C2VAL == 0 & R2C2VAL == 0 & R3C2VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C3.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 1 & R3C2VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C3.Enabled = false;
            }

            /* VERTICAL */
            if (R1C2VAL == 1 & R2C2VAL == 1 & R3C2VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C3.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }

        private void R3C3_Click(object sender, EventArgs e)
        {
            /* FOR X AND O BUTTON */
            num = num + 1;
            int mod = num % 2;

            if (mod == 0)
            {   /* FOR X AND O BUTTON */
                R3C3.Text = "X";
                /* FOR WIN SCENARIO */
                R3C3VAL = 1;
            }
            else
            {   /* FOR X AND O BUTTON*/
                R3C3.Text = "O";
                /* FOR WIN SCENARIO*/
                R3C3VAL = 0;
            }

            /* BUTTON DISABLE */
            R3C3.Enabled = false;

            /* O WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 0 & R3C2VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
            }

            /* VERTICAL */
            if (R1C3VAL == 0 & R2C3VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }


            /* DIAGONAL */
            if (R1C1VAL == 0 & R2C2VAL == 0 & R3C3VAL == 0)
            {
                gameSatus.Text = "Player 1 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R1C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 1 & R3C2VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
            }

            /* VERTICAL */
            if (R1C3VAL == 1 & R2C3VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C2.Enabled = false;
                R3C3.Enabled = false;
            }


            /* DIAGONAL */
            if (R1C1VAL == 1 & R2C2VAL == 1 & R3C3VAL == 1)
            {
                gameSatus.Text = "Player 2 Wins :)";
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R1C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8)
            {
                gameSatus.Text = "Nobody Wins :(";
            }
        }
    }
}