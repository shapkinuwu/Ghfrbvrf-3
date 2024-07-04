using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ПР3
{
    
    public partial class Приложение : Form

    {
        static public double Calc<T>(T x1, T y1, T x2, T y2)
        {
            dynamic dx1 = x1, dy1 = y1, dx2 = x2, dy2 = y2;
            double dist =  Math.Sqrt(Math.Pow(dx1 - dx2, 2) + Math.Pow(dy1 - dy2, 2));
            return Math.Round(dist, 3);
        }

        public Приложение()
        {
            InitializeComponent();

        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           x1.Clear();
           y1.Clear();
           x2.Clear();
           y2.Clear();
           
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void Опред_Click(object sender, EventArgs e)
        {
            string xx1 = x1.Text;
            string yy1 = y1.Text;
            string xx2 = x2.Text;
            string yy2 = y2.Text;
            if (Int32.TryParse(xx1, out int i) & Int32.TryParse(xx2, out int i2) & Int32.TryParse(yy1, out int i3) & Int32.TryParse(yy2, out int i4))
            {
                double rez = Calc(i, i2, i3, i4);
                textBox1.Text = $"{rez}";
            }
            else if (Double.TryParse(xx1, out double a) & Double.TryParse(xx2, out double a2) & Double.TryParse(yy1, out double a3) & Double.TryParse(yy2, out double a4))
            {
                double rez2 = Calc(a, a2, a3, a4);
                textBox1.Text = $"{rez2}";
            }

        }
    }

}
