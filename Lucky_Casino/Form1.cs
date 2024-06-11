namespace Lucky_Casino
{
    public partial class Form1 : Form
    {
        private Game game = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Bet(0, button1, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Bet(1, button2, label1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.Bet(2, button3, label1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.Bet(3, button4, label1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            game.Bet(4, button5, label1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            game.Bet(5, button6, label1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
