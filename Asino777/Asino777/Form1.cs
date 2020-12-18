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

namespace Asino777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pic1 = 0, pic2 = 1, pic3 = 2;
        int number1 = 0, number2 = 0, number3 = 0;
        int poz1 = 0, poz2 = 0, poz3 = 0;
        int win = 0;
        int result = 0;
        int[] test = { };
        Random rnd = new Random();
        Class execute = new Class();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show(
        "Розробник: студент ПЗС-2044, Оратівський Сергій",
        "Автор",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false && pic1 == pic2 && pic2 == pic3)
            {
                pictureBox5.Visible = true;

                if (pic1 % 2 == 0)
                {
                    win += 1000;
                }
                else win += 5000;

                label1.Text = ("Ваш виграш: " + win +"$");
                timer4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number1 = rnd.Next(1, 10);
            number2 = rnd.Next(1, 10);
            number3 = rnd.Next(1, 10);
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            poz1 = 0;
            poz2 = 0;
            poz3 = 0;
            result++;
            label2.Text = ("Спроб: " + result);
            pictureBox5.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        { 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (poz2 <= number2)
            {
                pic2 = execute.Pict(poz2, pic2, number2, pictureBox2, imageList1, timer2);
                poz2++;
            }
            else
            {
                timer2.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (poz3 <= number2)
            {
                pic3 = execute.Pict(poz3, pic3, number3, pictureBox3, imageList1, timer3);
                poz3++;
            }
            else
            {
                timer3.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (poz1 <= number1)
            {
                pic1 = execute.Pict(poz1, pic1, number1, pictureBox1, imageList1, timer1);
                poz1++;
            }
            else
            {
                timer1.Enabled = false;
            }

        }
    }

}
