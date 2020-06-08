using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error = "";
            double[] result = Class1.Eqal(int.Parse(textBox1.Text),
                int.Parse(textBox2.Text), int.Parse(textBox3.Text), out error);
            string strResult = string.Join("\n", result);
            MessageBox.Show(strResult, error);
        }
    }
}
