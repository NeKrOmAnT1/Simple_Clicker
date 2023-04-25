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
using System.Windows.Threading;

namespace Indifference.windows
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        private readonly Random _random = new Random();
        private int a = 0;
        private readonly DispatcherTimer timer = new DispatcherTimer();


        public Game()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Обновление таймера
            timeLabel.Content = DateTime.Now.ToString("mm:ss tt");
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            score.Text = "Очки: " + ++a ;
            switch (a)
            {
                case 5:
                    score.Text = "Слабенько... " + a +" очков, на большее не способен?";
                    break;
                case 10:
                    score.Text = "Всё ещё слабо... " + a + " очков";
                    break;
                case 25:
                    score.Text = "Ну может быть... " + a + " очков";
                    break;
                case 50:
                    score.Text = "Хорош!!! " + a + " очков";
                    break;
                case 75:
                    score.Text = "Уже можно остановиться, ты всё доказал. " + a + " очков";
                    break;
                case 100:
                    score.Text = "Совсем делать нечего? " + a + " очков";
                    break;
            }
            if (a == 101)
            {
                score.Text = "Ты всё доказал";
                MessageBox.Show("Ну и дурной же ты, но всё же молодец. Cледующее нажатие закроет игру.");
            }
            else if (a == 102)
            {
                MainWindow startwindow1= new MainWindow();
                startwindow1.Show();
                Close();
            }
            Canvas.SetLeft(button, _random.NextDouble() * (canvas.ActualWidth - button.ActualWidth));
            Canvas.SetTop(button, _random.NextDouble() * (canvas.ActualHeight - button.ActualHeight));
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow startwindow= new MainWindow();
            startwindow.Show();
            Close();
        }
    }

}
