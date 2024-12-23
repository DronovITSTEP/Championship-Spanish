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

namespace Championship_Spanish
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /* select * from Teams where name= @name; */
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (ChampionshipEntities db = new ChampionshipEntities())
            {
                
               dataGrid.ItemsSource = db.Teams
                    .Where(name => name.Name == textBox.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (ChampionshipEntities db = new ChampionshipEntities())
            {

                dataGrid.ItemsSource = db.Teams
                     .Where(name => name.City == textBox.Text);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (ChampionshipEntities db = new ChampionshipEntities())
            {

                dataGrid.ItemsSource = db.Teams
                     .Where(name => name.Name == textBox.Text &&
                            name.City == textBox.Text);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            /*отобразить команды с самым большим количеством побед*/
            using (ChampionshipEntities db = new ChampionshipEntities())
            {
               
            }
        }
    }
}
