using ModernWpf;
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

namespace Indifference
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;
        }

        private void btn_go_Click(object sender, RoutedEventArgs e)
        {
            windows.Game window_game = new windows.Game();
            window_game.Show();
            Close();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {

            windows.Exit exit = new windows.Exit();
            exit.ShowDialog();
            Close();
        }

        private void btn_settings_Click(object sender, RoutedEventArgs e)
        {
            windows.Settings settings = new windows.Settings();
            settings.Show();
            Close();
        }
    }
}
