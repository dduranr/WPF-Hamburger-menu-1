using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Hamburger_Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool StateClosed = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (StateClosed)
            {
                Storyboard sb = (Storyboard)FindResource("OpenMenu");
                sb.Begin();
            }
            else
            {
                Storyboard sb = (Storyboard)FindResource("CloseMenu");
                sb.Begin();
            }

            StateClosed = !StateClosed;
        }
    }
}