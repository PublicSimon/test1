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
using System.Windows.Shapes;

namespace PaperPlane
{
    /// <summary>
    /// Interaction logic for MessageSendWindow.xaml
    /// </summary>
    public partial class MessageWindow : Window
    {
        public MessageWindow()
        {
            //User cusr = App.Current.Properties["CurrentUser"] as User;
            //MessageBox.Show(cusr.Username);
            //User cusr = Application.Current.Windows[];
        }

        private void GroupStack_MouseDown(object sender, RoutedEventArgs e)
        {

            //sender
        }

        private void Border_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as FrameworkElement).ToString());
        }
    }
}
