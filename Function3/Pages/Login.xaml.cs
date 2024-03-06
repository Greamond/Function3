using Function3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Function3.Pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        bool AutorizationIsApply = false;
        public Login()
        {
            InitializeComponent();
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
            var doc = MainWindow.conn.DoctorsRus.FirstOrDefault(x => x.Login == LoginDoc.Text);
            if (doc != null)
            {
                if(doc.Password== PasswordDoc.Password)
                    MainWindow.init.OpenPage(new Pages.Main());
                else
                    MessageBox.Show($"{LoginDoc.Text}, ваш пароль неверный!\nПовторите попытку.");
            }
            else
                MessageBox.Show("Неверный логин");
        }
    }
}
