using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private InterfaceIntegral integral;

        public Form1()
        {
            InitializeComponent();
            integral = new Integral(0.00001);
        }

        public async Task<Func<double, double>> func(string str)
        {
            Func<double, double> func = await CSharpScript.EvaluateAsync<Func<double, double>>(str);
            double result = func(2);
            return func;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Func<double, double> result = func("x => " + textBox3.Text).Result;
                double ureg = double.Parse(textBox1.Text);
                textBox1.Text = ureg.ToString();
                double dreg = double.Parse(textBox2.Text);
                textBox2.Text = dreg.ToString();
                textBox4.Text = integral.Calculate(result, ureg, dreg).ToString();
            }
            catch
            {
                textBox4.Text = "Error";
            }
        }
    }
}
