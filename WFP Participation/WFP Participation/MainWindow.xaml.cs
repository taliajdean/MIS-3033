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

namespace WFP_Participation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtName.Text = string.Empty;
            txtDate.Text = string.Empty;
        }

        private void btnGo1_Click(object sender, RoutedEventArgs e)
        {
            string name, date;
            name = txtName.Text;
            date = txtDate.Text;



            txtName.Clear();
            txtDate.Text = string.Empty;

            DateTime birthdate = Convert.ToDateTime(date);
            var howOldTheyAre = DateTime.Now - birthdate;
            int old = Convert.ToInt32(howOldTheyAre.TotalDays / 365);

            btnGo1.Background = new SolidColorBrush(Colors.Blue);


            MessageBox.Show($"Welcome {name} whose birthday is {birthdate} and age is {old}.");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtName_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
