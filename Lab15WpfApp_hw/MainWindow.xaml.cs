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

namespace Lab15WpfApp_hw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Локи задушен", "Поздравляем, Танос!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вижен с проломленым лбом", "Поздравляем, Танос!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Коллекционер убит", "Поздравляем!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Корпус Нова разрушен", "Поздравляем, Танос!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Доктор Стрэндж отдал Вам камень", "Поздравляем, Танос!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сегодня Вы убили Гамору", "Поздравляем, Танос!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

        }
    }
}
