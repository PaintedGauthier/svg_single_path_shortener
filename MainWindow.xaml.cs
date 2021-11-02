using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

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
                TbRawData.TextChanged += TbRawData_TextChanged;
            };
        }

        public string Fix_num(string num, string rounding_fluff)
        {
            if (!double.TryParse(num, out double result))
            {
                return "0";
            }

            string res = result.ToString(rounding_fluff);
            if (res == "0.0")
            {
                return "0";
            }
            else if (res.StartsWith("0."))
            {
                res = res.Replace("0.", ".");
            }
            else if (res.StartsWith("-0."))
            {
                res = res.Replace("-0.", "-.");
            }

            return res;
        }

        private void TbRawData_TextChanged(object sender, TextChangedEventArgs e)
        {
            Run_Data_Fixing();
        }
        private void CbRounding_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Run_Data_Fixing();
        }

        private void Run_Data_Fixing()
        {
            byte.TryParse((CbRounding.SelectedItem as ComboBoxItem)?.Content.ToString() ?? "3", out byte roundnum);

            var round_fluff = "0.".PadRight(roundnum + 2, '#');

            string text = TbRawData.Text;
            StringBuilder sb = new StringBuilder();
            string[] parts = text.Split(" ");
            string[] list;
            Regex only_letters = new Regex(@"^[a-zA-Z]+$");
            foreach (string part in parts)
            {
                if (string.IsNullOrEmpty(part))
                    continue;

                if (only_letters.IsMatch(part))
                {
                    _ = sb.Append(part);
                }
                else
                {
                    list = part.Split(",");
                    if (list.Length == 2)
                    {
                        _ = sb.Append(Fix_num(list[0], round_fluff));
                        _ = sb.Append(",");
                        _ = sb.Append(Fix_num(list[1], round_fluff));
                    }
                    else if (list.Length == 1)
                    {
                        _ = sb.Append(Fix_num(list[0], round_fluff));
                    }
                    else
                    {

                    }
                }
                _ = sb.Append(" ");
            }
            TbFixedData.Text = sb.ToString().Trim();
            TbTitle1.Text = "Raw svg data (" + text.Length + ")";
            TbTitle2.Text = "cleaned up data (" + TbFixedData.Text.Length + ")";
        }

    }
}
