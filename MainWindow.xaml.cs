using Microsoft.EntityFrameworkCore;
using ProjectForYp2.classes;
using ProjectForYp2.data;
using ProjectForYp2.pages;
using System.Windows;

namespace ProjectForYp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameApp.frmObj = MainFrm;
            FrameApp.frmObj.Navigate(new PageLogin());
        }
    }
}