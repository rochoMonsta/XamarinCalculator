using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void button1_clicked(object sender, EventArgs e)
        {
            label1.Text += button1.Text;
        }
        private void button2_clicked(object sender, EventArgs e)
        {
            label1.Text += button2.Text;
        }
        private void button3_clicked(object sender, EventArgs e)
        {
            label1.Text += button3.Text;
        }
        private void button_sum_clicked(object sender, EventArgs e)
        {
            label1.Text += button_sum.Text;
        }
        private void button4_clicked(object sender, EventArgs e)
        {
            label1.Text += button4.Text;
        }
        private void button5_clicked(object sender, EventArgs e)
        {
            label1.Text += button5.Text;
        }
        private void button6_clicked(object sender, EventArgs e)
        {
            label1.Text += button6.Text;
        }
        private void button_min_clicked(object sender, EventArgs e)
        {
            label1.Text += button_min.Text;
        }
        private void button_clear_clicked(object sender, EventArgs e)
        {
            label1.Text = " ";
            label2.Text = " ";
        }
        private void button_delete_symbol(object sender, EventArgs e)
        {
            string text = " ";

            for(int i = 0; i < label1.Text.Length - 1; i++)
            {
                text += label1.Text[i];
            }

            label1.Text = text;
        }
        private void button_dil(object sender, EventArgs e)
        {
            label1.Text += button_d.Text;
        }
        private void button7_clicked(object sender, EventArgs e)
        {
            label1.Text += button7.Text;
        }
        private void button8_clicked(object sender, EventArgs e)
        {
            label1.Text += button8.Text;
        }
        private void button9_clicked(object sender, EventArgs e)
        {
            label1.Text += button9.Text;
        }
        private void button_mnosh_clicked(object sender, EventArgs e)
        {
            label1.Text += button_m.Text;
        }
        private void button0_clicked(object sender, EventArgs e)
        {
            label1.Text += button0.Text;
        }
        private void button_dot_clicked(object sender, EventArgs e)
        {
            label1.Text += button_dot.Text;
        }
        private void button_result_clicked(object sender, EventArgs e)
        {
            label2.Text = label1.Text;

            string expression = label1.Text.Trim();

            try
            {
                var result = new System.Data.DataTable().Compute(expression, null);

                if (result.GetType() == typeof(double))
                {
                    result = Math.Round((double)result, 5);
                }
                if (result.GetType() == typeof(decimal))
                {
                    result = Math.Round((decimal)result, 5);
                }

                string res = Convert.ToString(result);

                if (res.Contains(',')) { res = res.Replace(',', '.'); }
                label1.Text = res;
            }
            catch (Exception)
            {
                label1.Text = "Error";
            }
        }
        private void button_dush1_clicked(object sender, EventArgs e)
        {
            label1.Text += button_dush1.Text;
        }
        private void button_dush2_clicked(object sender, EventArgs e)
        {
            label1.Text += button_dush2.Text;
        }

        private void button_per_clicked(object sender, EventArgs e)
        {
            label2.Text = label1.Text;

            try
            {
                double number = Convert.ToDouble(label1.Text);

                number /= 100;

                string res = Convert.ToString(number);

                if(res.Contains(',')) { res = res.Replace(',', '.'); }

                label1.Text = res;
            }
            catch(Exception)
            {
                label1.Text = "Error";
            }
        }
    }
    
}
