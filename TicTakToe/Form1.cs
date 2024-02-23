namespace TicTakToe
{
    public partial class Form1 : Form
    {
        static int[] bitmap = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static Random random = new Random();
        static int randomnumber;
        public Form1()
        {
            InitializeComponent();
        }

        public static void tick()
        {
            while (bitmap[randomnumber] != 0)
            {
                randomnumber = random.Next(0, 10);
            }
            bitmap[randomnumber] = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bitmap[0] == 0)
            {
                bitmap[0] = 1;
            }
            tick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bitmap[1] == 0)
            {
                bitmap[1] = 1;
            }
            randomnumber = random.Next(0, 10);
            tick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bitmap[2] == 0)
            {
                bitmap[2] = 1;
            }
            randomnumber = random.Next(0, 10);
            tick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bitmap[3] == 0)
            {
                bitmap[3] = 1;
            }
            randomnumber = random.Next(0, 10);
            tick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bitmap[4] == 0)
            {
                bitmap[4] = 1;
            }
            randomnumber = random.Next(0, 10);
            tick();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bitmap[5] == 0)
            {
                bitmap[5] = 1;
            }
            randomnumber = random.Next(0, 10);
            tick();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bitmap[6] == 0)
            {
                bitmap[6] = 1;
            }
            randomnumber = random.Next(0, 10);
            tick();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bitmap[7] == 0)
            {
                bitmap[7] = 1;
            }
            randomnumber = random.Next(0, 10);
            tick();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bitmap[8] == 0)
            {
                bitmap[8] = 1;
            }
            randomnumber = random.Next(0, 10);
            tick();
        }
    }
}