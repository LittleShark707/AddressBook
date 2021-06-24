using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        string nameerror = "- Name should have at least five (5) characters\n";
        string doberror = "- Date must follow the correct format (MM/DD/YYYY)\n";
        string pinerror = "- Pin must contain six (6) numeric characters\n";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool ntrue = false;
            bool dtrue = false;
            bool ptrue = false;

            if (name.Text.Length >= 5)
            {
                ntrue = true;
            }
            if (!dob.Text.Any(char.IsLetter) && dob.Text.Length == 10) {
                DateTime db = DateTime.ParseExact(dob.Text, "MM/dd/yyyy", null);
                string date = db.ToString("MM/dd/yyyy");
                if (dob.Text == date)
                {
                    dtrue = true;
                }
            }
            else if (dob.Text.Any(char.IsLetter))
            {
                dtrue = false;
            }

            if (pin.Text.All(char.IsDigit) && pin.Text != "")
            {
                ptrue = true;
            }

            if(!ntrue && !dtrue && !ptrue)
            {
                MessageBox.Show(nameerror+doberror+pinerror, "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (!ntrue && !dtrue && ptrue)
            {
                MessageBox.Show(nameerror + doberror, "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (!ntrue && dtrue && ptrue)
            {
                MessageBox.Show(nameerror, "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (ntrue && !dtrue && !ptrue)
            {
                MessageBox.Show(doberror+pinerror, "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (ntrue && dtrue && !ptrue)
            {
                MessageBox.Show(pinerror, "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (!ntrue && dtrue && !ptrue)
            {
                MessageBox.Show(nameerror + pinerror, "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (ntrue && !dtrue && ptrue)
            {
                MessageBox.Show(doberror, "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if(ntrue && dtrue && ptrue)
            {

                string path = @"C:\Users\Natasja\Desktop\privatebook.ini";
                string ini = name.Text + "\n" + pin.Text + "\n" + dob.Text;
                File.WriteAllText(path, ini);

                Window2 w2 = new Window2();
                this.Close();
                w2.Show();
            }

            pin.IsEnabled = true;
        }

        private void pin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (pin.Text != "")
            {
                l3.Content = " ";
            }
            else if (pin.Text == "")
            {
                l3.Content = "*";
            }

            if (pin.Text.Length >= 6)
            {
                pin.IsEnabled = false;
            }
        }

        private void dob_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (dob.Text != "")
            {
                l2.Content = " ";
            }
            else if (dob.Text == "")
            {
                l2.Content = "*";
            }

            dob.SelectionStart = dob.Text.Length;
            if (dob.Text.Length == 2 && dob.Text.All(char.IsDigit))
            {
                string s = dob.Text;
                dob.Text = s + "/";
            }

            if (dob.Text.Length == 5 && !(dob.Text.Any(char.IsLetter)))
            {
                string s = dob.Text;
                dob.Text = s + "/";
            }
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (name.Text != "")
            {
                l1.Content = " ";
            }
            else if (name.Text == "")
            {
                l1.Content = "*";
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            dob.Text = "";
        }
    }
}
