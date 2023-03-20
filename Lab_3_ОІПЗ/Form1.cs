using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_ОІПЗ
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side_1, side_2, angle, P;
            side_1 = Convert.ToInt16(textBox1.Text);
            side_2 = Convert.ToInt16(textBox2.Text);
            angle = Convert.ToInt16(textBox3.Text);

            P = side_1 + side_2 + side_3(side_1, side_2, angle);

            if (side_1 >= 0 && side_2 >= 0 && angle > 0)
            {
                label9.Text = "Периметр трикутника: " + P;
            }
            else
            {
                label9.Text = "Трикутник не існує";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double side_1, side_2, angle_1, angle_2, D;
            side_1 = Convert.ToInt16(textBox4.Text);
            side_2 = Convert.ToInt16(textBox5.Text);
            angle_1 = Convert.ToInt16(textBox6.Text);

            angle_2 = 180 - angle_1;

            D = side_3(side_1, side_2, angle_2);
            if (side_1 >= 0 && side_2 >= 0 && angle_1 > 0)
            {
                label10.Text = "Довжина більшої діагоналі паралелограма: " + D;
            }
            else
            {
                label10.Text = "Паралелограм не існує";
            }
            
        }
        double side_3(double side_1, double side_2, double angle)
        {
            double cos_a, side_3;
            cos_a = Math.Cos(angle);

            side_3 = Math.Sqrt((side_1 * side_1) + (side_2 * side_2) - 2 * side_1 * side_2 * cos_a);

            return side_3;
        }

    }
}
