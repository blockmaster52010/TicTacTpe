using System.Media;

namespace TicTakToe
{
    public partial class Form1 : Form
    {
        static int[] bitmap = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static int playermap = 0;
        static int botmap = 0;
        static Random random = new Random();
        static int randomnumber;
        public Form1()
        {
            InitializeComponent();
        }

        public static void tick(Button button)
        {
            if (bitmap.Contains(0)) {
                randomnumber = random.Next(0, 9);
                while (bitmap[randomnumber] != 0)
                {
                    randomnumber = random.Next(0, 9);
                }
                bitmap[randomnumber] = 2;
                
            } else
            {
                //end game
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bitmap[0] == 0)
            {
                bitmap[0] = 1;
                if (bitmap.Contains(0))
                {
                    randomnumber = random.Next(0, 9);
                    while (bitmap[randomnumber] != 0)
                    {
                        randomnumber = random.Next(0, 9);
                    }
                    bitmap[randomnumber] = 2;
                    
                }
                else
                {
                    //end game
                }
                button1.Text = bitmap[0].ToString();
                button2.Text = bitmap[1].ToString();
                button3.Text = bitmap[2].ToString();
                button4.Text = bitmap[3].ToString();
                button5.Text = bitmap[4].ToString();
                button6.Text = bitmap[5].ToString();
                button7.Text = bitmap[6].ToString();
                button8.Text = bitmap[7].ToString();
                button9.Text = bitmap[8].ToString();
                playermap = 0;
                for (int i = 0; i < bitmap.Length; i++)
                {
                    playermap += (bitmap[i]%2);
                    playermap <<= 1;
                }
                botmap = 0;
                for (int i = 0; i < bitmap.Length; i++)
                {
                    botmap += (bitmap[i]/2);
                    botmap <<= 1;
                }
                if ((playermap & 0b111000000) == 0b111000000) 
                {

                } else if ((playermap & 0b000111000) == 0b000111000)
                {

                } else if ((playermap & 0b000000111) == 0b000000111)
                {

                } else if ((playermap & 0b100100100) == 0b100100100)
                {

                } else if ((playermap & 0b010010010) == 0b010010010)
                {

                } else if ((playermap & 0b001001001) == 0b001001001)
                {

                } else if ((playermap & 0b100010001) == 0b100010001)
                {

                } else if ((playermap & 0b001010100) == 0b001010100)
                {

                }


                if ((botmap & 0b111000000) == 0b111000000) 
                {

                } else if ((botmap & 0b000111000) == 0b000111000)
                {

                } else if ((botmap & 0b000000111) == 0b000000111)
                {

                } else if ((botmap & 0b100100100) == 0b100100100)
                {

                } else if ((botmap & 0b010010010) == 0b010010010)
                {

                } else if ((botmap & 0b001001001) == 0b001001001)
                {

                } else if ((botmap & 0b100010001) == 0b100010001)
                {

                } else if ((botmap & 0b001010100) == 0b001010100)
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bitmap[1] == 0)
            {
                bitmap[1] = 1;
                if (bitmap.Contains(0))
                {
                    randomnumber = random.Next(0, 9);
                    while (bitmap[randomnumber] != 0)
                    {
                        randomnumber = random.Next(0, 9);
                    }
                    bitmap[randomnumber] = 2;
                    
                }
                else
                {
                    //end game
                }
                button1.Text = bitmap[0].ToString();
                button2.Text = bitmap[1].ToString();
                button3.Text = bitmap[2].ToString();
                button4.Text = bitmap[3].ToString();
                button5.Text = bitmap[4].ToString();
                button6.Text = bitmap[5].ToString();
                button7.Text = bitmap[6].ToString();
                button8.Text = bitmap[7].ToString();
                button9.Text = bitmap[8].ToString();
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bitmap[2] == 0)
            {
                bitmap[2] = 1;
                if (bitmap.Contains(0))
                {
                    randomnumber = random.Next(0, 9);
                    while (bitmap[randomnumber] != 0)
                    {
                        randomnumber = random.Next(0, 9);
                    }
                    bitmap[randomnumber] = 2;
                    
                }
                else
                {
                    //end game
                }
                button1.Text = bitmap[0].ToString();
                button2.Text = bitmap[1].ToString();
                button3.Text = bitmap[2].ToString();
                button4.Text = bitmap[3].ToString();
                button5.Text = bitmap[4].ToString();
                button6.Text = bitmap[5].ToString();
                button7.Text = bitmap[6].ToString();
                button8.Text = bitmap[7].ToString();
                button9.Text = bitmap[8].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bitmap[3] == 0)
            {
                bitmap[3] = 1;
                if (bitmap.Contains(0))
                {
                    randomnumber = random.Next(0, 9);
                    while (bitmap[randomnumber] != 0)
                    {
                        randomnumber = random.Next(0, 9);
                    }
                    bitmap[randomnumber] = 2;
                    
                }
                else
                {
                    //end game
                }
                button1.Text = bitmap[0].ToString();
                button2.Text = bitmap[1].ToString();
                button3.Text = bitmap[2].ToString();
                button4.Text = bitmap[3].ToString();
                button5.Text = bitmap[4].ToString();
                button6.Text = bitmap[5].ToString();
                button7.Text = bitmap[6].ToString();
                button8.Text = bitmap[7].ToString();
                button9.Text = bitmap[8].ToString();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bitmap[4] == 0)
            {
                bitmap[4] = 1;
                if (bitmap.Contains(0))
                {
                    randomnumber = random.Next(0, 9);
                    while (bitmap[randomnumber] != 0)
                    {
                        randomnumber = random.Next(0, 9);
                    }
                    bitmap[randomnumber] = 2;
                    
                }
                else
                {
                    //end game
                }
                button1.Text = bitmap[0].ToString();
                button2.Text = bitmap[1].ToString();
                button3.Text = bitmap[2].ToString();
                button4.Text = bitmap[3].ToString();
                button5.Text = bitmap[4].ToString();
                button6.Text = bitmap[5].ToString();
                button7.Text = bitmap[6].ToString();
                button8.Text = bitmap[7].ToString();
                button9.Text = bitmap[8].ToString();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bitmap[5] == 0)
            {
                bitmap[5] = 1;
                if (bitmap.Contains(0))
                {
                    randomnumber = random.Next(0, 9);
                    while (bitmap[randomnumber] != 0)
                    {
                        randomnumber = random.Next(0, 9);
                    }
                    bitmap[randomnumber] = 2;
                    
                }
                else
                {
                    //end game
                }
                button1.Text = bitmap[0].ToString();
                button2.Text = bitmap[1].ToString();
                button3.Text = bitmap[2].ToString();
                button4.Text = bitmap[3].ToString();
                button5.Text = bitmap[4].ToString();
                button6.Text = bitmap[5].ToString();
                button7.Text = bitmap[6].ToString();
                button8.Text = bitmap[7].ToString();
                button9.Text = bitmap[8].ToString();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (bitmap[6] == 0)
            {
                bitmap[6] = 1;
                if (bitmap.Contains(0))
                {
                    randomnumber = random.Next(0, 9);
                    while (bitmap[randomnumber] != 0)
                    {
                        randomnumber = random.Next(0, 9);
                    }
                    bitmap[randomnumber] = 2;
                    
                }
                else
                {
                    //end game
                }
                button1.Text = bitmap[0].ToString();
                button2.Text = bitmap[1].ToString();
                button3.Text = bitmap[2].ToString();
                button4.Text = bitmap[3].ToString();
                button5.Text = bitmap[4].ToString();
                button6.Text = bitmap[5].ToString();
                button7.Text = bitmap[6].ToString();
                button8.Text = bitmap[7].ToString();
                button9.Text = bitmap[8].ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bitmap[7] == 0)
            {
                bitmap[7] = 1;
                if (bitmap.Contains(0))
                {
                    randomnumber = random.Next(0, 9);
                    while (bitmap[randomnumber] != 0)
                    {
                        randomnumber = random.Next(0, 9);
                    }
                    bitmap[randomnumber] = 2;
                    
                }
                else
                {
                    //end game
                }
                button1.Text = bitmap[0].ToString();
                button2.Text = bitmap[1].ToString();
                button3.Text = bitmap[2].ToString();
                button4.Text = bitmap[3].ToString();
                button5.Text = bitmap[4].ToString();
                button6.Text = bitmap[5].ToString();
                button7.Text = bitmap[6].ToString();
                button8.Text = bitmap[7].ToString();
                button9.Text = bitmap[8].ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bitmap[8] == 0)
            {
                bitmap[8] = 1;
                if (bitmap.Contains(0))
                {
                    randomnumber = random.Next(0, 9);
                    while (bitmap[randomnumber] != 0)
                    {
                        randomnumber = random.Next(0, 9);
                    }
                    bitmap[randomnumber] = 2;
                }
                else
                {
                    //end game
                }
                button1.Text = bitmap[0].ToString();
                button2.Text = bitmap[1].ToString();
                button3.Text = bitmap[2].ToString();
                button4.Text = bitmap[3].ToString();
                button5.Text = bitmap[4].ToString();
                button6.Text = bitmap[5].ToString();
                button7.Text = bitmap[6].ToString();
                button8.Text = bitmap[7].ToString();
                button9.Text = bitmap[8].ToString();
            }
         
        }
    }
}