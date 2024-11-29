using ProjectForYp2.classes;
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

namespace ProjectForYp2.pages
{
    /// <summary>
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public PageReg()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            string pas = pass1.Password;
            string pas1 = pass2.Password;
            string login = log.Text;

            if (pas1 == pas)
            {
                //Внесение в базу данных
                MessageBox.Show("Внесенно в базу");
            }
        }
    }
}
