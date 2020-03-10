using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_click(object sender, EventArgs e)
        {
            double a, b, c;
            double disc;
            double x1, x2;
            a = Convert.ToDouble(A.Text);
            b = Convert.ToDouble(B.Text);
            c = Convert.ToDouble(C.Text);

            disc = Math.Pow(b, 2) - 4 * a * c; // Дискриминант
            
            if(disc < 0)         // Если дискриминант < 0 корней нет
            {
                xx1.Text = Convert.ToString("Дискриминант < 0 корней нет");  
                Disc.Text = Convert.ToString(disc);                         // Выводит значение Дискриминанта


            }
            if(disc == 0)                                  // Если дискриминант равен 0 = 1 корень
            {
                x1 = (-b + Math.Sqrt(disc)) / (2 * a);        // формула 1 корня
                xx1.Text = Convert.ToString(x1);              // Выводит значение первого корня
                Disc.Text = Convert.ToString(disc);           // Выводит значение Дискриминанта

            }
            else
                x1 = (-b + Math.Sqrt(disc)) / (2 * a);       // Формула 1 корня
                x2 = (-b - Math.Sqrt(disc)) / (2 * a);       // Формула 2 корня
            X1.Text = Convert.ToString(x1);                  // Выводит 1 корень
            X2.Text = Convert.ToString(x2);                   // Выводит 2 корень
            Disc.Text = Convert.ToString(disc);               // Выводит значение Дискриминанта





        }

        
    }
}
