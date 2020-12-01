using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asino777
{
    class Class
    {
        Random rnd = new Random();
        public int Pict(int poz1, int pic1, int number1, PictureBox pictureBox1, ImageList imageList1, Timer timer1)
        {
            if (poz1 <= number1)
            {
                pic1 = rnd.Next(1, 9);
                pictureBox1.Image = imageList1.Images[pic1];
                poz1++;
                return pic1;
            }
            else
            {
                timer1.Enabled = false;
                return pic1;
            }
        }
    }

}