using System.Windows;
using DataController;
using System.IO;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        readonly DataControl data = new DataControl();
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            data.ToDatabase(firstName, lastName);
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            using StreamReader sr = new StreamReader(@"C:\Users\thepa\Desktop\Internship\WPF\PersonInfoTXT\Text.txt");            
            Results.Text = sr.ReadToEnd();
        }

        //private void DeleteAll_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
