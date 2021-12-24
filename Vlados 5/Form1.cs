using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vlados_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Модель: ";
            label5.Text = "Количество пикселей: ";
            label6.Text = "Размер экрана: ";
            label7.Text = "Питание: ";
            label4.Text += richTextBox1.Text;
            label5.Text += richTextBox2.Text;
            label6.Text += richTextBox3.Text;
            label7.Text += checkBox1.Checked;
        }
    }
}
