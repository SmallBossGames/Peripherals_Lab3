using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peripherals_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                var value = byte.Parse(SourceDecTextBox.Text);
                var c1 = double.Parse(С1TextBox.Text);
                var c2 = double.Parse(С2TextBox.Text);
                var e0 = double.Parse(E0TextBox.Text);

                var resultArray = DAC.ConvertToAnalog(value, c1, c2, e0);

                SourceBinTextBox.Text = Convert.ToString(value, 2);
                DrawChart(resultArray, value);
                AnalogTextBox.Text = resultArray[resultArray.Length-1].ToString();
            }
            catch(FormatException e1)
            {
                MessageBox.Show(e1.Message);
            }
            catch(OverflowException e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void DrawChart(IEnumerable<double> values, double target)
        {
            Chart.Series[0].Points.Clear();
            Chart.Series[1].Points.Clear();

            foreach (var item in values)
            {
                Chart.Series[0].Points.Add(item);
                Chart.Series[1].Points.Add(target);
            }
        }
    }
}
