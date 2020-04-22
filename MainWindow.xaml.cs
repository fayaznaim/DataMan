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
using System.Text.RegularExpressions;

namespace DataMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rtb1maininput.Document.Blocks.Clear();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            rtb2results.Document.Blocks.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            rtb1maininput.Document.Blocks.Clear();
            rtb2results.Document.Blocks.Clear();
        }

        // Button to extract md5
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
            if (Clearpreviouscheckbox.IsChecked ?? true)
            {
                rtb2results.Document.Blocks.Clear();
            }
            rtb2results.AppendText(Environment.NewLine);
            Regex md5regex = new Regex(@"\b[A-Fa-f0-9]{32}\b");
            TextRange textRangeinput = new TextRange(rtb1maininput.Document.ContentStart, rtb1maininput.Document.ContentEnd);
            MatchCollection md5collection = md5regex.Matches(textRangeinput.Text);
            foreach (Match md5match in md5collection)
            {
            rtb2results.AppendText(md5match.Value + Environment.NewLine);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (Clearpreviouscheckbox.IsChecked ?? true)
            {
                rtb2results.Document.Blocks.Clear();
            }
            rtb2results.AppendText(Environment.NewLine);
            Regex sha1regex = new Regex(@"\b[A-Fa-f0-9]{40}\b");
            TextRange textRangeinput = new TextRange(rtb1maininput.Document.ContentStart, rtb1maininput.Document.ContentEnd);
            MatchCollection sha1collection = sha1regex.Matches(textRangeinput.Text);
            foreach (Match sha1match in sha1collection)
            {
                rtb2results.AppendText(sha1match.Value + Environment.NewLine);
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rtb2results_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Clearpreviouscheckbox_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
