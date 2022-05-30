namespace Tic_Tac_Toe_Game
{
    public partial class gameScreen : Form
    {
        /* FOR X AND O BUTTON */
        int num;
        int mod;

        /* WIN SCENARIO // DRAW SCENARIO FIX */
        bool win = false;

        /* SCORE FUNCTION */
        int oscore = 0;
        int xscore = 0;

        /* FOR WIN SCENARIO */ /* 10 IS ARBITRARY VALUE // IT CAN BE ANY VALUE AS LONG AS IT IS NOT 1 OR 0 */ 
        int R1C1VAL = 10;
        int R1C2VAL = 10;
        int R1C3VAL = 10;
        int R2C1VAL = 10;
        int R2C2VAL = 10;
        int R2C3VAL = 10;
        int R3C1VAL = 10;
        int R3C2VAL = 10;
        int R3C3VAL = 10;

    /* COMPUTER MODE SWITCH */
    bool comp = false;

        public gameScreen()
        {
            InitializeComponent();
        }

        /* COMPUTER MODE ALGORITHM */
        public void first()
        {
            if (comp & num == 1)
            {
                R2C2.PerformClick();
                gameSatus.Text = "Noice, Let's Play :)";
                gameSatus.Location = new Point(178,105);
            }
        }

        public void algorithm()
        {
            mod = num % 2;

            if (comp & num >= 3 & mod != 0)
            {
                if (R1C1VAL == 10)
                {
                    R1C2.PerformClick();
                    gameSatus.Text = "Really?";
                    gameSatus.Location = new Point(261, 105);
                }
                else if (R1C2VAL == 10) 
                {
                    R1C2.PerformClick();
                    gameSatus.Text = "You can do better!";
                    gameSatus.Location = new Point(180, 105);
                }
                 else if (R1C3VAL == 10) 
                {
                    R1C3.PerformClick();
                    gameSatus.Text = "Emotional Damage!";
                    gameSatus.Location = new Point(174, 105);
                }
                else if (R2C1VAL == 10)
                {
                    R2C1.PerformClick();
                    gameSatus.Text = "Try Again :(";
                    gameSatus.Location = new Point(224, 105);
                }
                else if (R2C2VAL == 10)
                {
                    R2C2.PerformClick();
                    gameSatus.Text = "Better luck next time :(";
                    gameSatus.Location = new Point(209, 105);
                }
                else if (R2C3VAL == 10)
                {
                    R2C3.PerformClick();
                    gameSatus.Text = "The Earth is full go home";
                    gameSatus.Location = new Point(125, 105);
                }
                else if (R3C1VAL == 10)
                {
                    R3C1.PerformClick();
                    gameSatus.Text = "Oh I get it … like humor … but different";
                    gameSatus.Location = new Point(15, 105);
                }
                else if (R3C2VAL == 10)
                {
                    R3C2.PerformClick();
                    gameSatus.Text = "Thomas has never seen such mess before";
                    gameSatus.Location = new Point(6, 105);
                }
                else if (R3C3VAL == 10)
                {
                    R3C3.PerformClick();
                    gameSatus.Text = "What were you thinking";
                    gameSatus.Location = new Point(132, 105);
                }
            }
        }
        public void owin()
        {
            gameSatus.Text = "Player O Wins :)";
            gameSatus.Location = new Point(198, 105);
        }

        public void xwin()
        {
            gameSatus.Text = "Player X Wins :)";
            gameSatus.Location = new Point(204, 105);
        }

        public void nwin()
        {
            gameSatus.Text = "Nobody Wins :(";
            gameSatus.Location = new Point(209, 105);
        }

        public void center()
        {
            if (comp & num == 1)
            {
                R1C2.PerformClick();
                gameSatus.Text = "Noice, Let's Play :)";
                gameSatus.Location = new Point(178, 105);
            }
        }

        public void pvp()
        {
            gameSatus.Text = "Oh! I didn't know you have friends";
            gameSatus.Location = new Point(62, 105);
        }
        private void R1C1_Click(object sender, EventArgs e)
        {
            pvp();
            /* FOR X AND O BUTTON */
            num = num + 1;
            mod = num % 2;

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

            /* COMPUTER MODE*/
            first();
            algorithm();
            
            /* O WIN SCENARIO */

                /*HORIZONTAL*/
            if (R1C1VAL == 0 & R1C2VAL == 0 & R1C3VAL == 0)
            {
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
            else if (num > 8 & win == false)
            {
                nwin();
            }
        }

        private void R1C2_Click(object sender, EventArgs e)
        {
            pvp();

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

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /* HORIZONTAL */
            if (R1C1VAL == 0 & R1C2VAL == 0 & R1C3VAL == 0)
            {
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
            else if (num > 8 & win == false)
            {
                nwin();
            }
        }

        private void R1C3_Click(object sender, EventArgs e)
        {
            pvp();

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

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /*HORIZOTAL*/
            if (R1C1VAL == 0 & R1C2VAL == 0 & R1C3VAL == 0)
            {
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
            else if (num > 8 & win == false)
            {
                nwin();
            }
        }

        private void R2C1_Click(object sender, EventArgs e)
        {
            pvp();

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

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /* HORIZOTAL */
            if (R2C1VAL == 0 & R2C2VAL == 0 & R2C3VAL == 0)
            {
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
            else if (num > 8 & win == false)
            {
                nwin();
            }
        }

        private void R2C2_Click(object sender, EventArgs e)
        {
            pvp();
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

            /* COMPUTER MODE*/
            center();
            algorithm();

            /* O WIN SCENARIO */

            /*HORIZONTAL*/
            if (R2C1VAL == 0 & R2C2VAL == 0 & R2C3VAL == 0)
            {
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
            else if (num > 8 & win == false)
            {
                nwin();

            }
        }

        private void R2C3_Click(object sender, EventArgs e)
        {
            pvp();

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

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /* HORIZONTAL */
            if (R2C1VAL == 0 & R2C2VAL == 0 & R2C3VAL == 0)
            {
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
            else if (num > 8 & win == false )
            {
                nwin();
            }
        }

        private void R3C1_Click(object sender, EventArgs e)
        {
            pvp();

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

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 0 & R3C2VAL == 0 & R3C3VAL == 0)
            {
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
            else if (num > 8 & win == false)
            {
                nwin();
            }
        }

        private void R3C2_Click(object sender, EventArgs e)
        {
            pvp();

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

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 0 & R3C2VAL == 0 & R3C3VAL == 0)
            {
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
            else if (num > 8 & win == false)
            {
                nwin();
            }
        }

        private void R3C3_Click(object sender, EventArgs e)
        {
            pvp();

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

            /* COMPUTER MODE*/
            first();
            algorithm();

            /* O WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 0 & R3C2VAL == 0 & R3C3VAL == 0)
            {
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                owin();

                /* GAME STATUS IDENTIFIER */
                win = true;

                /* SCORE FUNCTIONALITY */
                oscore = oscore + 1;
                scorePlayer1.Text = "Player O: " + oscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
            }

            /* X WIN SCENARIO */

            /* HORIZONTAL */
            if (R3C1VAL == 1 & R3C2VAL == 1 & R3C3VAL == 1)
            {
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
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
                xwin();

                /* SCORE FUNCTIONALITY */
                xscore = xscore + 1;
                scorePlayer2.Text = "Player X: " + xscore;

                /* WIN SCENARIO BUTTON DISABLER */
                R1C1.Enabled = false;
                R1C2.Enabled = false;
                R1C3.Enabled = false;
                R2C1.Enabled = false;
                R2C2.Enabled = false;
                R2C3.Enabled = false;
                R3C1.Enabled = false;
                R3C2.Enabled = false;
            }

            /*DRAW SCENARIO*/
            else if (num > 8 & win == false)
            {
                nwin();
            }
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            num = 0;
            mod = 0;
            win = false;

            /* ENABLE ALL BUTTONS */
            R1C1.Enabled = true;
            R1C2.Enabled = true;
            R1C3.Enabled = true;
            R2C1.Enabled = true;
            R2C2.Enabled = true;
            R2C3.Enabled = true;
            R3C1.Enabled = true;
            R3C2.Enabled = true;
            R3C3.Enabled = true;

            /* CLEAR ALL BUTTON*/
            R1C1.Text = "";
            R1C2.Text = "";
            R1C3.Text = "";
            R2C1.Text = "";
            R2C2.Text = "";
            R2C3.Text = "";
            R3C1.Text = "";
            R3C2.Text = "";
            R3C3.Text = "";

            /* RESET VALUE FOR WIN DETERMINER */
             R1C1VAL = 10;
             R1C2VAL = 10;
             R1C3VAL = 10;
             R2C1VAL = 10;
             R2C2VAL = 10;
             R2C3VAL = 10;
             R3C1VAL = 10;
             R3C2VAL = 10;
             R3C3VAL = 10;

            /* CLEAR GAME STATUS */
            gameSatus.Text = "Start Game";
            gameSatus.Location = new Point(224, 105);
            comp = false;
        }

        private void computerMode_Click(object sender, EventArgs e)
        {
            comp = true;
            gameSatus.Text = "You Go First ;)";
            gameSatus.Location = new Point(204, 105);
        }
    }
}