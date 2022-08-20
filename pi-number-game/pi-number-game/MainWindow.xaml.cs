using System.Text.RegularExpressions;
using System.Windows;

namespace pi_number_game
{
    public partial class MainWindow : Window
    {
        StopwatchEvent stopwatch = new StopwatchEvent();

        public MainWindow()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //stopwatch.Run();
        }
        private void PreviewOnlyNumbersDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            Regex _regex = new Regex("[^0-9.-]+");
            if (_regex.IsMatch(FromTextBox.Text)) e.Handled = true;
        }
        public void InputNumsOnly(string s, System.Windows.Input.KeyEventArgs e)
        {
            Regex _regex = new Regex("[^0-9.-]+");
            if (_regex.IsMatch(s)) e.Handled = true;
        }
    }
}
