using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace svg_shortener
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += (m, n) =>
            {
                tbRawData.TextChanged += tbRawData_TextChanged;
            };
        }

        public string fix_num(string num)
        {
            if (!double.TryParse(num, out double result))
                return "0";

            var res = result.ToString("0.###");
            if (res == "0.0")
                return "0";
            else if (res.StartsWith("0."))
                res = res.Replace("0.", ".");
            else if (res.StartsWith("-0."))
                res = res.Replace("-0.", "-.");
            return res;
        }

        private void tbRawData_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = (sender as TextBox).Text;
            StringBuilder sb = new StringBuilder();
            var parts = text.Split(" ");
            int comma;
            string[] list;
            Regex only_letters = new Regex(@"^[a-zA-Z]+$");
            foreach (var part in parts)
            {
                if (only_letters.IsMatch(part))
                {
                    sb.Append(part);
                }
                else
                {
                    list = part.Split(",");
                    if (list.Length == 2)
                    {
                        sb.Append(fix_num(list[0]));
                        sb.Append(",");
                        sb.Append(fix_num(list[1]));
                    }
                    else if (list.Length == 1)
                    {
                        sb.Append(fix_num(list[0]));
                    }
                    else
                    {

                    }
                }
                sb.Append(" ");
            }
            tbFixedData.Text = sb.ToString().Trim();
            tbTitle1.Text = "Raw svg data (" + text.Length + ")";
            tbTitle2.Text = "cleaned up data (" + tbFixedData.Text.Length + ")";
        }
    }
}
