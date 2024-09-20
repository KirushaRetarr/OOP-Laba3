using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            double y;

            if (!double.TryParse(textBox1.Text, out x))
            {
                MessageBox.Show("Ошибка", "Нужно корректное значение x", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(textBox2.Text, out y))
            {
                MessageBox.Show("Ошибка", "Нужно корректное значение y", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((y != 0) && (Math.Abs(x) > Math.Abs(y)))
            {
                textBox3.Text = (1 / Math.Atan(x / y)).ToString();
            }
            else
            {
                textBox3.Text = 0.ToString();
            }

            if ((y != 0) && (Math.Abs(x) <= Math.Abs(y)))
            {
                textBox4.Text = (1 / Math.Asin(x / y)).ToString();
            }
            else
            {
                textBox4.Text = 0.ToString();
            }
        }
    }
}
