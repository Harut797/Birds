using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Birds
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("coins.txt"))
            {
                    String line = sr.ReadLine();
                    int t = int.Parse(line);
                    achok.Text = t.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Restart();
        }

        int t = 0;

        private void angrysmile_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"skin.txt"))
            {
                writer.WriteLine("smile1");
                MessageBox.Show("Smile 1 skin applied!");
            }

            using (StreamReader sr = new StreamReader("coins.txt"))
            {
                String line = sr.ReadLine();
                t = int.Parse(line);
                t -= 1000;
                //achok.Text = t.ToString();
            }
            using (StreamWriter writer = new StreamWriter(@"coins.txt"))
            {
                writer.WriteLine(t);
            }
            achok.Text = t.ToString();
        }

        private void poxos_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"skin.txt"))
            {
                writer.WriteLine("poxos");
                MessageBox.Show("Poxos skin applied!");
            }

            using (StreamReader sr = new StreamReader("coins.txt"))
            {
                String line = sr.ReadLine();
                t = int.Parse(line);
                t -= 5000;
                //achok.Text = t.ToString();
            }
            using (StreamWriter writer = new StreamWriter(@"coins.txt"))
            {
                writer.WriteLine(t);
            }
            achok.Text = t.ToString();
        }
    }
}

