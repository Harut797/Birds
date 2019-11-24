using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.Media;

namespace Birds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            smile.BackColor = Color.FromArgb(128, 255, 255, 255);
        }
        public void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                
            }
        }
        public int get_coin()
        {
            int coinsss = 0;
            using (StreamReader sr = new StreamReader("coins.txt"))
            {
                String c = sr.ReadLine();
                int co = int.Parse(c);
                coinsss = co;
            }
            return coinsss;
        }

        public void Form1_Shown(object sender, EventArgs e)
        {
            Image sm1 = new Bitmap(@"img\smile1.jpg");
            Image sm2 = new Bitmap(@"img\poxos.jpg");
            coin2.Text = get_coin().ToString();
            using (StreamReader sr = new StreamReader("Test.txt"))
            {
                
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"audio\fon.wav");
                player.Play();
                int[] top = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                string []topanun = {"","","", "", "", "", "", "", "" };
                for(int i =0;i <= 8; i++)
                {
                    String line = sr.ReadLine();
                    String result = Regex.Match(line, @"\d+").Value;

                    listBox1.Items.Add(line);
                    
                }
                
            }
        }
        Random rd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int x = smile.Top - 50;
            smile.Location = new Point(200, x);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (smile.Top > 400)
            {
                
                MessageBox.Show("ad");
            }
        }
        int coin = 0;
        int coin22 = 0;
        int smilecordx = 0;
        int smilecordy = 0;
        int x;
        int y;
        int x2;
        int stolbarag = 5;
        int smilearag = 5;
        int smilenerqev = 5;
        private void timer3_Tick(object sender, EventArgs e)
        {
            
            int rand = rd.Next(-100, 100);
            int stolba2rand = -16 + rand;
            x = stolba.Left;
            x2 = stolba2.Left;
            y = smile.Top;
            //if (back1.Left == -500)
            //{
            //    back1.Location = new Point(0, back1.Top);
            //    back2.Location = new Point(543, back1.Top);
            //    back3.Location = new Point(1078, back1.Top);
            //}
            //back1.Location = new Point(back1.Left - 1, back1.Top);
            //back2.Location = new Point(back2.Left - 1, back2.Top);
            smile.Location = new Point(200, y + smilenerqev);
            stolba.Left -= stolbarag;
            stolba4.Left -= stolbarag;
            stolba2.Left = stolba.Left;
            stolba2.Top = stolba.Top - 340;
            stolba5.Left = stolba4.Left;
            stolba5.Top = stolba4.Top - 340;
            stolba6.Left -= stolbarag;
            stolba7.Left = stolba6.Left;
            stolba7.Top = stolba6.Top - 340;
            coin1.Location = new Point(coin1.Left - stolbarag, coin1.Top);
            if(rand == 5)
            {
                coin1.Visible = true;
                coin1.Location = new Point(750, 100 +rand);
            }
            if (smile.Top > 400 || smile.Top <0)
            {
                GameOver();
            }
            if (smile.Left + 40 + rand > stolba.Left - 15 + rand && smile.Left + 40 + rand < stolba.Left + 15 + rand && smile.Top + rand > stolba.Top - 15 + rand && stolba.Top + rand < stolba.Top + 15 + rand)
            {
                GameOver();
            }
            if (smile.Left + 40 + rand > stolba4.Left - 15 + rand && smile.Left + 40 + rand < stolba4.Left + 15 + rand && smile.Top + rand > stolba4.Top - 15 + rand && stolba4.Top + rand < stolba4.Top + 15 + rand)
            {
                GameOver();
            }
            if (smile.Left + 40 + rand > stolba6.Left - 15 + rand && smile.Left + 40 + rand < stolba6.Left + 15 + rand && smile.Top + rand > stolba6.Top - 15 + rand && stolba6.Top + rand < stolba6.Top + 15 + rand)
            {
                GameOver();
            }
            if (smile.Left + 40 + rand >= stolba2.Left - 10 + rand && smile.Left + 40 + rand <= stolba2.Left + 30 + rand && smile.Top + rand < stolba2.Top + 170 + rand && smile.Top + rand > stolba2.Top - 10 + rand)
            {
                GameOver();
            }
            if (smile.Left + 40 + rand >= stolba5.Left - 10 + rand && smile.Left + 40 + rand <= stolba5.Left + 30 + rand && smile.Top + rand < stolba5.Top + 170 + rand && smile.Top + rand > stolba5.Top - 10 + rand)
            {
                GameOver();
            }
            if (smile.Left - 8 < coin1.Left && smile.Left > coin1.Left+40 && smile.Top > coin1.Top - 40 && smile.Top - 40 < coin1.Top + 40 || smile.Left + 40 > coin1.Left &&  smile.Left < coin1.Left && smile.Top > coin1.Top-40 && smile.Top -40 < coin1.Top-40)
            {
                coin1.Visible = false;
                coin22 = (int)coin22+ (int)get_coin();
                coin2.Text = coin22.ToString();
            }
            if (stolba.Left <= 0)
            {
                stolba.Location = new Point(stolba6.Left+300 , 276 + rand <-0? rand-500:rand+300);
            }
            if (stolba4.Left <= 0)
            {
                stolba4.Location = new Point(stolba.Left+300, 276 + rand < -0 ? rand - 500 : rand + 300);
            }
            if (stolba6.Left <= 0)
            {
                stolba6.Location = new Point(stolba.Left+600, 276 + rand < -0 ? rand - 500 : rand + 300);
            }
            coin++;
            coins.Text = coin.ToString();
            if(timer3.Interval != 5 && coin == 100 || coin == 500 || coin == 1000 || coin == 2000 || coin == 2500)
            {
                stolbarag += 5;
                smilearag += 3;
                timer3.Enabled = false;
                //timer3.Interval -= 5;
                smilenerqev += 1;
                MessageBox.Show("Level UP!");
                coin++;
                timer3.Enabled = true;
            }
            if(coin == 1050)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"audio\fon.wav");
                player.Play();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            var f4 = new Form3();
            f4.Show();
        }
        //void isContact(PictureBox smile,PictureBox stolba,int rand,int num1,int num2,int num3, int num4, int num5,int num6)
        //{
        //    if (smile.Left + num1 + rand > stolba.Left - num2 + rand && smile.Left + num3 + rand < stolba.Left + num4 + rand && smile.Top + rand > stolba.Top - num5 + rand && stolba.Top + rand < stolba.Top + num6 + rand)
        //        GameOver();
        //}
        public void GameOver()
        {
            timer3.Enabled = false;
            MessageBox.Show("Game Over...Your Coin " + coin);
            string message, title, defaultValue;
            string myValue;
            message = "Please Input Your Name";
            title = "Your Name";
            defaultValue = "Harut";
            myValue = Interaction.InputBox(message, title, defaultValue, 100, 100);
            listBox1.Items.Add(myValue.ToString() + ": " + coin);
            using (StreamWriter writer = new StreamWriter(@"test.txt", true))
            {
                writer.WriteLine(myValue + ":" + coin);
            }
            using (StreamWriter writer = new StreamWriter(@"coins.txt"))
            {
                writer.WriteLine(coin22);
            }

            return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void randtime_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
            //this.Close();

        }

        private void coins_Click(object sender, EventArgs e)
        {

        }
    }
}
