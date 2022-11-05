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
using _db = DE_Laslin4438.Models.Parfum2Entities;


namespace DE_Laslin4438
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
            for (int i = 0; i < _db.GetContext().Users.Count(); i++)
            {
                if (logtb.Text == _db.GetContext().Users.ToList()[i].login &&
                    passtb.Text == _db.GetContext().Users.ToList()[i].password)
                {
                    MessageBox.Show("Успешная авторизация!");
                    if (_db.GetContext().Users.ToList()[i].role_id == 2)
                    {
                        new Show_win().Show();
                        this.Hide();
                    }
                    else if (_db.GetContext().Users.ToList()[i].role_id == 1)
                    {
                        new Show_win().Show();
                        this.Hide();
                    }
                    else if (_db.GetContext().Users.ToList()[i].role_id == 3)
                    {
                        new Show_win().Show();
                        this.Hide();
                    }
                }

            }
        }
    }
}
