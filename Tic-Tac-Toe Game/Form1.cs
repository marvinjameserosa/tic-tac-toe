namespace Tic_Tac_Toe_Game
{
    public partial class gameScreen : Form
    {
        int num = 1;
        public gameScreen()
        {
            InitializeComponent();
        }

        private void R1C1_Click(object sender, EventArgs e)
        {
            num = num + 1;
            int mod = num % 2;
            if (mod == 0)
                R1C1.Text = "X";
            else
                R1C1.Text = "O";
            R1C1.Enabled = false;
        }

        private void R1C2_Click(object sender, EventArgs e)
        {
            num = num + 1;
            int mod = num % 2;
            if (mod == 0)
                R1C2.Text = "X";
            else
                R1C2.Text = "O";
            R1C2.Enabled = false;
        }

        private void R1C3_Click(object sender, EventArgs e)
        {
            num = num + 1;
            int mod = num % 2;
            if (mod == 0)
                R1C3.Text = "X";
            else
                R1C3.Text = "O";
            R1C3.Enabled = false;
        }

        private void R2C1_Click(object sender, EventArgs e)
        {
            num = num + 1;
            int mod = num % 2;
            if (mod == 0)
                R2C1.Text = "X";
            else
                R2C1.Text = "O";
            R2C1.Enabled = false;
        }

        private void R2C2_Click(object sender, EventArgs e)
        {
            num = num + 1;
            int mod = num % 2;
            if (mod == 0)
                R2C2.Text = "X";
            else
                R2C2.Text = "O";
            R2C2.Enabled = false;
        }

        private void R2C3_Click(object sender, EventArgs e)
        {
            num = num + 1;
            int mod = num % 2;
            if (mod == 0)
                R2C3.Text = "X";
            else
                R2C3.Text = "O";
            R2C3.Enabled = false;
        }

        private void R3C1_Click(object sender, EventArgs e)
        {
            num = num + 1;
            int mod = num % 2;
            if (mod == 0)
                R3C1.Text = "X";
            else
                R3C1.Text = "O";
            R3C1.Enabled = false;
        }

        private void R3C2_Click(object sender, EventArgs e)
        {
            num = num + 1;
            int mod = num % 2;
            if (mod == 0)
                R3C2.Text = "X";
            else
                R3C2.Text = "O";
            R3C2.Enabled = false;
        }

        private void R3C3_Click(object sender, EventArgs e)
        {
            num = num + 1;
            int mod = num % 2;
            if (mod == 0)
                R3C3.Text = "X";
            else
                R3C3.Text = "O";
            R3C3.Enabled = false;
        }
    }
}