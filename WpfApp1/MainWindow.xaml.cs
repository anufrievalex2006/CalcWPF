using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a, b, s;
        string z = "";
        bool isChanged = false;

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (txtNum.Text == "0" && isChanged == false)
            {
                txtNum.Text = "1";
                isChanged = true;
            }
            else txtNum.Text += "1";
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (txtNum.Text == "0" && isChanged == false)
            {
                txtNum.Text = "2";
                isChanged = true;
            }
            else txtNum.Text += "2";
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (txtNum.Text == "0" && isChanged == false)
            {
                txtNum.Text = "3";
                isChanged = true;
            }
            else txtNum.Text += "3";
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (txtNum.Text == "0" && isChanged == false)
            {
                txtNum.Text = "4";
                isChanged = true;
            }
            else txtNum.Text += "4";
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            if (txtNum.Text == "0" && isChanged == false)
            {
                txtNum.Text = "5";
                isChanged = true;
            }
            else txtNum.Text += "5";
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (txtNum.Text == "0" && isChanged == false)
            {
                txtNum.Text = "6";
                isChanged = true;
            }
            else txtNum.Text += "6";
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            if (txtNum.Text == "0" && isChanged == false)
            {
                txtNum.Text = "7";
                isChanged = true;
            }
            else txtNum.Text += "7";
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            if (txtNum.Text == "0" && isChanged == false)
            {
                txtNum.Text = "8";
                isChanged = true;
            }
            else txtNum.Text += "8";
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            if (txtNum.Text == "0" && isChanged == false)
            {
                txtNum.Text = "9";
                isChanged = true;
            }
            else txtNum.Text += "9";
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            if (txtNum.Text != "0" || txtNum.Text == "") txtNum.Text += "0";
        }

        private void bPoint_Click(object sender, RoutedEventArgs e)
        {
            if (txtNum.Text != "" && !txtNum.Text.Contains(',')) txtNum.Text += ",";
        }

        private void bPlus_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(txtNum.Text);
            z = "+";
            txtNum.Text = "";
        }

        private void bMin_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(txtNum.Text);
            z = "-";
            txtNum.Text = "";
        }

        private void bMult_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(txtNum.Text);
            z = "*";
            txtNum.Text = "";
        }

        private void bDiv_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(txtNum.Text);
            z = "/";
            txtNum.Text = "";
        }

        private void bMinPl_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(txtNum.Text);
            a = -a;
            txtNum.Text = a.ToString();
        }

        private void bAC_Click(object sender, RoutedEventArgs e)
        {
            a = 0;
            b = 0;
            txtNum.Text = "";
            z = "";
        }

        private void bEqual_Click(object sender, RoutedEventArgs e)
        {
            b = Convert.ToDouble(txtNum.Text);
            switch (z)
            {
                case "+": s = a + b; break;
                case "-": s = a - b; break;
                case "*": s = a * b; break;
                case "/": s = a / b; break;
            }
            txtNum.Text = Math.Round(s, 3).ToString();
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
