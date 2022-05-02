using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._6
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
  
        int[] Mas = new int [30];
        private void Form1_Load(object sender, EventArgs e)
        {
            min.ForeColor = Color.Red;
            Max.ForeColor = Color.Red;
            min.Text = "Введите минимальное значение";
            Max.Text = "Введите максимальное значение";
        }
        private void условиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
            MessageBox.Show("Дан массив A целых чесел, содержащий 30 элементов. Вычислить и вывести сумму тех элементов, которые нечётные и отрицательные.");
        }
        private void min_Click(object sender, EventArgs e)
        {
            min.Clear();
            min.ForeColor = Color.Black;
        }

        private void Max_Click(object sender, EventArgs e)
        {
            Max.Clear();
            Max.ForeColor = Color.Black;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int x = int.Parse(min.Text);
            int y = int.Parse(Max.Text);
            Random rand = new Random();
            for (int i = 0; i < 30; ++i)
            {
                Mas[i] = rand.Next(x,y);
                listBox1.Items.Add ("Mas[" + Convert.ToString(i) + "] =" + Mas[i].ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Mas[0] = Convert.ToInt32(textBox1.Text);
            Mas[1] = Convert.ToInt32(textBox2.Text);
            Mas[2] = Convert.ToInt32(textBox3.Text);
            Mas[3] = Convert.ToInt32(textBox4.Text);
            Mas[4] = Convert.ToInt32(textBox5.Text);
            Mas[5] = Convert.ToInt32(textBox6.Text);
            Mas[6] = Convert.ToInt32(textBox7.Text);
            Mas[7] = Convert.ToInt32(textBox8.Text);
            Mas[8] = Convert.ToInt32(textBox9.Text);
            Mas[9] = Convert.ToInt32(textBox10.Text);
            Mas[10] = Convert.ToInt32(textBox11.Text);
            Mas[11] = Convert.ToInt32(textBox12.Text);
            Mas[12] = Convert.ToInt32(textBox13.Text);
            Mas[13] = Convert.ToInt32(textBox14.Text);
            Mas[14] = Convert.ToInt32(textBox15.Text);
            Mas[15] = Convert.ToInt32(textBox16.Text);
            Mas[16] = Convert.ToInt32(textBox17.Text);
            Mas[17] = Convert.ToInt32(textBox18.Text);
            Mas[18] = Convert.ToInt32(textBox19.Text);
            Mas[19] = Convert.ToInt32(textBox20.Text);
            Mas[20] = Convert.ToInt32(textBox21.Text);
            Mas[21] = Convert.ToInt32(textBox22.Text);
            Mas[22] = Convert.ToInt32(textBox23.Text);
            Mas[23] = Convert.ToInt32(textBox24.Text);
            Mas[24] = Convert.ToInt32(textBox25.Text);
            Mas[25] = Convert.ToInt32(textBox26.Text);
            Mas[26] = Convert.ToInt32(textBox27.Text);
            Mas[27] = Convert.ToInt32(textBox28.Text);
            Mas[28] = Convert.ToInt32(textBox29.Text);
            Mas[29] = Convert.ToInt32(textBox30.Text);
            for (int i = 0; i < 30; ++i)
            {
                listBox1.Items.Add("Mas[" + Convert.ToString(i) + "] =" + Mas[i].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int S = 0;
            int n = 0;
            textBox0.Clear();
            for (int i=0; i<30; ++i)
            {
                if(Mas[i] < 0 || Mas[i] % 2 != 0)
                {
                    n = Mas[i];
                    S = S + n;
                }
                else
                {
                    S = S + 0;
                }
            }
            textBox0.Text = Convert.ToString(S);
        }

       
    }
}