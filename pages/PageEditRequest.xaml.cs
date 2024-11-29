using ProjectForYp2.classes;
using ProjectForYp2.data;
using ProjectForYp2.Model;
using ProjectForYp2.pages.SecondPage;
using System.Windows;
using System.Windows.Controls;

namespace ProjectForYp2.pages
{
    /// <summary>
    /// Логика взаимодействия для PageEditRequest.xaml
    /// </summary>
    public partial class PageEditRequest : Page
    {
        classdata data = new classdata();
        Requests requests = new Requests();


        int reqId;

        public PageEditRequest()
        {
            InitializeComponent();

            data.GetRequests();
            UserGrid.ItemsSource = data.userContext.Requests.Local.ToList();

            EditFrame.frmEdit = Frmedit;

            welldonereq.Text = "Выполнено: " + Convert.ToString(data.userContext.Requests.Where(s => s.Id_Statys.Name == "Готова к выдаче").Count());
            workreq.Text = "В работе: " + Convert.ToString(data.userContext.Requests.Where(s => s.Id_Statys.Name == "В процессе ремонта").Count());
            newreq.Text = "Новая заявка: " + Convert.ToString(data.userContext.Requests.Where(s => s.Id_Statys.Name == "Новая заявка").Count());
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            var req = (sender as Button).DataContext;

            foreach (var item in data.userContext.Requests.Local)
            {
                if (item == req)
                {
                    reqId = item.Id;
                    break;
                }
            }
            EditFrame.frmEdit.Navigate(new PageEditSelectRequest(reqId));
        }

        private void upddate_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageEditRequest());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }

        private void sort_Click(object sender, RoutedEventArgs e)
        {
            UserGrid.ItemsSource = data.userContext.Requests.Local.OrderBy(x => x.StartDate).ToList();
        }

        private void Edit_Click_1(object sender, RoutedEventArgs e)
        {
            data.GetRequests();
            Requests request = (Requests)(sender as Button).DataContext;

            DateTime date = request.StartDate.ToDateTime(TimeOnly.MinValue);
            DateTime date1 = request.CompletionDate.
                GetValueOrDefault(DateOnly.MinValue).ToDateTime(TimeOnly.MinValue);
            data.GetComments();
            var dateTime = date1 - date;
            var com = data.userContext.Comments.Where(x => x.reqId.Id == reqId).FirstOrDefault();
            string reppart = "";
            string coment;
            if (com != null)
            {
                coment = com.Message;
            }
            else
            {
                coment = "Мастер комментарий не оставил";
            }

            if (request.RepairParts != "")
            { 
                reppart = request.RepairParts; 
            }
            else
            { 
                reppart = "Мастер не использовал доп. части"; 
            }
            MessageBox.Show($"Количество дней: {dateTime.TotalDays}\nИспользуемые детали: {reppart}\nКоментарий мастера: {coment}", "Отчет"
                , MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void sort1_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string select = Convert.ToString(sort1.Text.ToUpper());
            UserGrid.ItemsSource = data.userContext.Requests.Where(x =>
            x.OrgTechManufacture.ToUpper().Contains(select))
                .ToList();
        }
    }
}
