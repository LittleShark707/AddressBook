using midterm.Properties;
using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 w1 = new Window1();
        Window2 w2 = new Window2();
        string path = @"C:\Users\Natasja\Desktop\conent.csv";
        string path2 = @"C:\Users\Natasja\Desktop\privatebook.ini";
        public MainWindow()
        {
            InitializeComponent();
            fill();
            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //}
            //else if (File.Exists(path))
            //{
            //    List<string> lines = new List<string>();
            //    using (StreamReader r = new StreamReader(path))
            //    {
            //        string line;
            //        while ((line = r.ReadLine()) != null)
            //        {
            //            if (line.Split(' ').Count() > 1)
            //            {
            //                namelist.Items.Add(line.Split(' ')[0] + " " + line.Split(' ')[1]);
            //            }
            //        }
            //    }

            //    ArrayList q = new ArrayList();
            //    foreach (object o in namelist.Items)
            //    {
            //        q.Add(o);
            //    }
            //    q.Sort();
            //    namelist.Items.Clear();
            //    foreach (object o in q)
            //    {
            //        namelist.Items.Add(o);
            //    }
            //}

            if (!File.Exists(path2))
            {
                File.Create(path2);
                w1.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                w1.Topmost = true;
                this.LocationChanged += OnLocationchanged;
                w1.Show();
            }
            else if (File.Exists(path2))
            {
                w2.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                w2.Topmost = true;
                this.LocationChanged += OnLocationchanged2;
                w2.Show();
            }

            DispatcherTimer time = new DispatcherTimer();
            time.Interval = new TimeSpan(0, 0, 1);
            time.Tick += time_Tick;
            time.Start();
        }

        private void fill()
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else if (File.Exists(path))
            {
                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(path))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        if (line.Split(' ').Count() > 1)
                        {
                            namelist.Items.Add(line.Split(' ')[0] + " " + line.Split(' ')[1]);
                        }
                    }
                }

                ArrayList q = new ArrayList();
                foreach (object o in namelist.Items)
                {
                    q.Add(o);
                }
                q.Sort();
                namelist.Items.Clear();
                foreach (object o in q)
                {
                    namelist.Items.Add(o);
                }
            }
        }

        private void time_Tick(object sender, EventArgs e)
        {
            date.Content = DateTime.Now.ToString();
        }

        private void OnLocationchanged(object sender, EventArgs e)
        {
            if (w1 != null)
                w1.Close();
        }
        private void OnLocationchanged2(object sender, EventArgs e)
        {
            if (w2 != null)
                w2.Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            string input = ln.Text + "," + " " + fn.Text + " " + bd.Text + " " + ea.Text + " " + cn.Text + "\n";

            if (fn.Text != "" && ln.Text != "" && bd.Text != "" && ea.Text != "" && cn.Text != "")
            {
                File.AppendAllText(path, input);
                MessageBox.Show("Entry saved.");
            }
            else
            {
                MessageBox.Show("Textbox cannot be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            namelist.Items.Clear();
            fill();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            fn.Clear();
            ln.Clear();
            bd.Clear();
            ea.Clear();
            cn.Clear();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            namelist.Items.Clear();
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    foreach (string item in namelist.Items)
                    {
                        tw.WriteLine("");
                    }
                }
            }
            namelist.SelectedIndex = -1;
        }

        private void bd_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (bd.Text != "")
            {
                l3.Content = " ";
            }
            else if(bd.Text == "")
            {
                l3.Content = "*";
            }

            bd.SelectionStart = bd.Text.Length;
            if (bd.Text.Length == 2 && bd.Text.All(char.IsDigit))
            {
                string s = bd.Text;
                bd.Text = s + "/";
            }

            if (bd.Text.Length == 5 && (!bd.Text.Any(char.IsLetter)))
            {
                string s = bd.Text;
                bd.Text = s + "/";
            }
        }

        private void namelist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.namelist.SelectedIndex >= 0)
            {
                string entry = namelist.SelectedItem.ToString();
                string[] dataline = File.ReadAllLines(path);
                foreach (var line in dataline)
                {
                    if (line.Contains(entry))
                    {
                        string fileData = File.ReadAllText(path);
                        string[] parts = line.Split(' ');

                        fn.Text = parts[0];
                        ln.Text = parts[1];
                        bd.Text = parts[2];
                        ea.Text = parts[3];
                        cn.Text = parts[4];
                    }
                }
            }
        }

        private void fn_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (fn.Text != "")
            {
                l1.Content = " ";
            }
            else if (fn.Text == "")
            {
                l1.Content = "*";
            }
        }

        private void ln_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ln.Text != "")
            {
                l2.Content = " ";
            }
            else if (ln.Text == "")
            {
                l2.Content = "*";
            }
        }

        private void ea_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ea.Text != "")
            {
                l4.Content = " ";
            }
            else if (ea.Text == "")
            {
                l4.Content = "*";
            }
        }

        private void cn_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (cn.Text != "")
            {
                l5.Content = " ";
            }
            else if (cn.Text == "")
            {
                l5.Content = "*";
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            bd.Text = "";
        }
    }
}
