using ProjectForYp2.classes;
using ProjectForYp2.data;
using ProjectForYp2.Model;
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

namespace ProjectForYp2.pages.SecondPage
{
    /// <summary>
    /// Логика взаимодействия для PageRequestUser.xaml
    /// </summary>
    public partial class PageRequestUser : Page
    {
        classdata data = new classdata();
        User uid;
        public PageRequestUser(string id)
        {
            InitializeComponent();
            var users = data.GetUsers();
            var result = users.Where(x => x.Login == id).FirstOrDefault();
            uid = result;
            UserGrid.ItemsSource = data.userContext.Requests.Local.Where(u => u.Client == uid).ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
