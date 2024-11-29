using Microsoft.EntityFrameworkCore;
using ProjectForYp2.classes;
using ProjectForYp2.data;
using System.Windows;
using System.Windows.Controls;

namespace ProjectForYp2.pages
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        classdata data = new classdata();
        public PageLogin()
        {
            InitializeComponent();
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageReg());
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            string logiin = login.Text;
            string pas = password.Password;
            if (password.Password == "")
            {
                MessageBox.Show("Пароль не введен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                var users = data.GetUsers();
                var result = users.FirstOrDefault(u => u.Login == logiin && u.Password == pas);

                if (result == null)
                {
                    MessageBox.Show("Пользователь не найден", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (result != null)
                {
                    if(result.Type.Id == 4)
                    {
                        MessageBox.Show("Вход произведен успешно", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
                        FrameApp.frmObj.Navigate(new PageAddRequest(login.Text));
                    }
                    if (result.Type.Id == 3 || result.Type.Id == 1)
                    {
                        MessageBox.Show("Вход произведен успешно", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
                        FrameApp.frmObj.Navigate(new PageEditRequest());
                    }
                    if (result.Type.Id == 2)
                    {
                        MessageBox.Show("Вход произведен успешно", "Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
                        FrameApp.frmObj.Navigate(new PageMaster(login.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
