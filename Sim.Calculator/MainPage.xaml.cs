using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Sim.Calculator
{
    public partial class MainPage : PhoneApplicationPage
    {
        public string no1, consfun;
        public bool inputstatus;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            no1 = "";
         }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button1.Content;
            else
            {
                textBox1.Text = Convert.ToString(button1.Content);
                inputstatus = true;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button2.Content;
            else
            {
                textBox1.Text = Convert.ToString(button2.Content);
                inputstatus = true;
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button4.Content;
            else
            {
                textBox1.Text = Convert.ToString(button4.Content);
                inputstatus = true;
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button5.Content;
            else
            {
                textBox1.Text = Convert.ToString(button5.Content);
                inputstatus = true;
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button6.Content;
            else
            {
                textBox1.Text = Convert.ToString(button6.Content);
                inputstatus = true;
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button8.Content;
            else
            {
                textBox1.Text = Convert.ToString(button8.Content);
                inputstatus = true;
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button9.Content;
            else
            {
                textBox1.Text = Convert.ToString(button9.Content);
                inputstatus = true;
            }

        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button10.Content;
            else
            {
                textBox1.Text = Convert.ToString(button10.Content);
                inputstatus = true;
            }
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button12.Content;
            else
            {
                textBox1.Text = Convert.ToString(button12.Content);
                inputstatus = true;
            }
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button13.Content;
            else
            {
                textBox1.Text = Convert.ToString(button13.Content);
                inputstatus = true;
            }
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button14.Content;
            else
            {
                textBox1.Text = Convert.ToString(button14.Content);
                inputstatus = true;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            consfun = "+";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            consfun = "-";
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            consfun = "*";
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            consfun = "/";
        }
        private void funcall()
        {
            switch (consfun)
            {
                case "+":
                    int n = textBox1.Text.Length;
                    if (n == 0)
                        return;
                    else
                    {
                        textBox1.Text = Convert.ToString(Convert.ToDouble(no1) + Convert.ToDouble(textBox1.Text));
                    }
                    break;
                case "-":
                     n = textBox1.Text.Length;
                    if (n == 0)
                        return;
                    else
                    {
                        textBox1.Text = Convert.ToString(Convert.ToDouble(no1) - Convert.ToDouble(textBox1.Text));
                    }
                    break;
                case "*":
                    n = textBox1.Text.Length;
                    if (n == 0)
                        return;
                    else
                    {
                        textBox1.Text = Convert.ToString(Convert.ToDouble(no1) * Convert.ToDouble(textBox1.Text));
                    }
                    break;
                case "/":

                    n = textBox1.Text.Length;
                    if (n == 0)
                        return;
                    else
                    {
                        if (textBox1.Text == "0")
                        {
                            textBox1.Text = "Infinity";
                        }
                        else
                        {
                            textBox1.Text = Convert.ToString(Convert.ToDouble(no1) / Convert.ToDouble(textBox1.Text));
                        }
                    }
                    break;
            }
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            funcall();
            inputstatus = false;
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            textBox1.IsEnabled = false;
            textBox1.Text = "";
            inputstatus = false;
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Empty;
            inputstatus = true;
        
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else
            {
                textBox1.Text = (no1.Substring(0, n - 1));
            }
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }

    }

  }