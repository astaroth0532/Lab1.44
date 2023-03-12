using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Int32> variables = new List<Int32>(); //ініціалізація динамічного списку

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))                                           //ЗВД (Захист від дурня)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && //ЗВД
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  //ЗВД
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            variables.Insert(0, Convert.ToInt32(textBox1.Text));
            variables.Insert(1, Convert.ToInt32(textBox2.Text)); //додавання значень до списку
            variables.Insert(2, Convert.ToInt32(textBox3.Text));
            lblMax.Text = Convert.ToString(variables.Max()); //знаходження результатів
            lblMin.Text = Convert.ToString(variables.Min());
        }
    }
}
