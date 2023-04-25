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
using System.Windows.Shapes;

namespace Indifference.windows
{
    /// <summary>
    /// Логика взаимодействия для Exit.xaml
    /// </summary>
    public partial class Exit : Window
    {
        public Exit()
        {
            InitializeComponent();
            ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;
        }

        private void btn_yes_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            
        }

        private void btn_no_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow window= new MainWindow();
            window.Show();
        }
    }
}
