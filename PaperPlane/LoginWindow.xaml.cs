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

namespace PaperPlane
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public User CurrentUser;
        public LoginWindow()
        {
            InitializeComponent();
            CurrentUser = new User("Username123", "Password456");
            this.DataContext = CurrentUser;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentUser.Verify() == false)
            {
                MessageBox.Show("Wrong Username and/or Password");
            }
            else
            {
                App.Current.Properties["CurrentUser"] = CurrentUser;
                MessageWindow messagewindow = new MessageWindow();
                App.Current.MainWindow = messagewindow;
                this.Close();
                messagewindow.Show();
            }
            
        }
    }
}
