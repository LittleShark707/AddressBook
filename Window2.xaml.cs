using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace midterm.Properties
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;
        string path = @"C:\Users\Natasja\Desktop\privatebook.ini";
        public Window2()
        {
            InitializeComponent();
        }

        private void t1_Click(object sender, RoutedEventArgs e)
        {
            num1 += 1;
            if (num1 > 9)
            {
                num1 = 0;
            }
            else if(num1 < 0)
            {
                num1 = 9;
            }
            n1.Content = num1.ToString();

            string pin = File.ReadLines(path).ElementAtOrDefault(1);
            string PIN = n1.Content.ToString() + n2.Content.ToString() + n3.Content.ToString()
                + n4.Content.ToString() + n5.Content.ToString() + n6.Content.ToString();
            if (PIN == pin)
            {
                this.Close();
            }
        }

        private void t2_Click(object sender, RoutedEventArgs e)
        {
            num2 += 1;
            if (num2 > 9)
            {
                num2 = 0;
            }
            else if (num2 < 0)
            {
                num2 = 9;
            }
            n2.Content = num2.ToString();

            string pin = File.ReadLines(path).ElementAtOrDefault(1);
            string PIN = n1.Content.ToString() + n2.Content.ToString() + n3.Content.ToString()
                + n4.Content.ToString() + n5.Content.ToString() + n6.Content.ToString();
            if (PIN == pin)
            {
                this.Close();
            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            num2 -= 1;
            if (num2 > 9)
            {
                num2 = 0;
            }
            else if (num2 < 0)
            {
                num2 = 9;
            }
            n2.Content = num2.ToString();

            string pin = File.ReadLines(path).ElementAtOrDefault(1);
            string PIN = n1.Content.ToString() + n2.Content.ToString() + n3.Content.ToString()
                + n4.Content.ToString() + n5.Content.ToString() + n6.Content.ToString();
            if (PIN == pin)
            {
                this.Close();
            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            num3 -= 1;
            if (num3 > 9)
            {
                num3 = 0;
            }
            else if (num3 < 0)
            {
                num3 = 9;
            }
            n3.Content = num3.ToString();

            string pin = File.ReadLines(path).ElementAtOrDefault(1);
            string PIN = n1.Content.ToString() + n2.Content.ToString() + n3.Content.ToString()
                + n4.Content.ToString() + n5.Content.ToString() + n6.Content.ToString();
            if (PIN == pin)
            {
                this.Close();
            }
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            num4 -= 1;
            if (num4 > 9)
            {
                num4 = 0;
            }
            else if (num4 < 0)
            {
                num4 = 9;
            }
            n4.Content = num4.ToString();

            string pin = File.ReadLines(path).ElementAtOrDefault(1);
            string PIN = n1.Content.ToString() + n2.Content.ToString() + n3.Content.ToString()
                + n4.Content.ToString() + n5.Content.ToString() + n6.Content.ToString();
            if (PIN == pin)
            {
                this.Close();
            }
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            num5 -= 1;
            if (num5 > 9)
            {
                num5 = 0;
            }
            else if (num5 < 0)
            {
                num5 = 9;
            }
            n5.Content = num5.ToString();

            string pin = File.ReadLines(path).ElementAtOrDefault(1);
            string PIN = n1.Content.ToString() + n2.Content.ToString() + n3.Content.ToString()
                + n4.Content.ToString() + n5.Content.ToString() + n6.Content.ToString();
            if (PIN == pin)
            {
                this.Close();
            }
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            num6 -= 1;
            if (num6 > 9)
            {
                num6 = 0;
            }
            else if (num6 < 0)
            {
                num6 = 9;
            }
            n6.Content = num6.ToString();

            string pin = File.ReadLines(path).ElementAtOrDefault(1);
            string PIN = n1.Content.ToString() + n2.Content.ToString() + n3.Content.ToString()
                + n4.Content.ToString() + n5.Content.ToString() + n6.Content.ToString();
            if (PIN == pin)
            {
                this.Close();
            }
        }

        private void t3_Click(object sender, RoutedEventArgs e)
        {
            num3 += 1;
            if (num3 > 9)
            {
                num3 = 0;
            }
            else if (num3 < 0)
            {
                num3 = 9;
            }
            n3.Content = num3.ToString();

            string pin = File.ReadLines(path).ElementAtOrDefault(1);
            string PIN = n1.Content.ToString() + n2.Content.ToString() + n3.Content.ToString()
            + n4.Content.ToString() + n5.Content.ToString() + n6.Content.ToString();
            if (PIN == pin)
            {
                this.Close();
            }
        }

        private void t4_Click(object sender, RoutedEventArgs e)
        {
            num4 += 1;
            if (num4 > 9)
            {
                num4 = 0;
            }
            else if (num4 < 0)
            {
                num4 = 9;
            }
            n4.Content = num4.ToString();

            string pin = File.ReadLines(path).ElementAtOrDefault(1);
            string PIN = n1.Content.ToString() + n2.Content.ToString() + n3.Content.ToString()
                + n4.Content.ToString() + n5.Content.ToString() + n6.Content.ToString();
            if (PIN == pin)
            {
                this.Close();
            }
        }

        private void t5_Click(object sender, RoutedEventArgs e)
        {
            num5 += 1;
            if (num5 > 9)
            {
                num5 = 0;
            }
            else if (num5 < 0)
            {
                num5 = 9;
            }
            n5.Content = num5.ToString();

            string pin = File.ReadLines(path).ElementAtOrDefault(1);
            string PIN = n1.Content.ToString() + n2.Content.ToString() + n3.Content.ToString()
                + n4.Content.ToString() + n5.Content.ToString() + n6.Content.ToString();
            if (PIN == pin)
            {
                this.Close();
            }
        }

        private void t6_Click(object sender, RoutedEventArgs e)
        {
            num6 += 1;
            if (num6 > 9)
            {
                num6 = 0;
            }
            else if (num6 < 0)
            {
                num6 = 9;
            }
            n6.Content = num6.ToString();

            string pin = File.ReadLines(path).ElementAtOrDefault(1);
            string PIN = n1.Content.ToString() + n2.Content.ToString() + n3.Content.ToString()
                + n4.Content.ToString() + n5.Content.ToString() + n6.Content.ToString();
            if (PIN == pin)
            {
                this.Close();
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            num1 -= 1;
            if (num1 > 9)
            {
                num1 = 0;
            }
            else if (num1 < 0)
            {
                num1 = 9;
            }
            n1.Content = num1.ToString();

            string pin = File.ReadLines(path).ElementAtOrDefault(1);
            string PIN = n1.Content.ToString() + n2.Content.ToString() + n3.Content.ToString()
                + n4.Content.ToString() + n5.Content.ToString() + n6.Content.ToString();
            if (PIN == pin)
            {
                this.Close();
            }
        }
    }
}
