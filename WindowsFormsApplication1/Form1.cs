using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = length_input;
        }

        private void count_button_Click(object sender, EventArgs e)
        {

            if (NotValid(length_input.Text))
            {
                MessageBox.Show("Length input value is not correct", "Error");
            }
            else if (NotValid(width_input.Text))
            {
                MessageBox.Show("Width input value is not correct", "Error");
            }
            else if (NotValid(height_input.Text))
            {
                MessageBox.Show("Height input value is not correct", "Error");
            }
            else
            {
                result_num.Text = Count(Convert.ToDouble(length_input.Text), Convert.ToDouble(width_input.Text), Convert.ToDouble(height_input.Text)).ToString();
                //MessageBox.Show(Count(Convert.ToDouble(length_input.Text), Convert.ToDouble(width_input.Text), Convert.ToDouble(height_input.Text)).ToString(), "Result");
            }
        }

        private double Count(double length, double width, double height)
        {
            double length_ratio, width_ratio, height_ratio;

            length_ratio = Math.Floor(18 / length);//length ratio rounded down
            width_ratio = Math.Floor(18 / width);//width ratio rounded down
            height_ratio = Math.Floor(8 / height);//height ratio rounded down

            double[] array = { length_ratio, height_ratio, width_ratio };//create array of ratios

            Array.Sort(array);//sort array to find minimum value

            return array[0];
        }

        private Boolean NotValid(String text)
        {
            double num;

            if (string.IsNullOrWhiteSpace(text) || //verify that information was added
                !double.TryParse(text, out num) || //verify that information is number
                Convert.ToDouble(text) <= 0)	   // verify that number is not zero or negative
            {
                return true;//entered value is invalid
            }
            else
            {
                return false;//entered value is valid
            }
        }

    }
}
