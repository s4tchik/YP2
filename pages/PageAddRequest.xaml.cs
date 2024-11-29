using ProjectForYp2.classes;
using ProjectForYp2.data;
using ProjectForYp2.Model;
using ProjectForYp2.pages.SecondPage;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace ProjectForYp2.pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddRequest.xaml
    /// </summary>
    public partial class PageAddRequest : Page
    {
        classdata data = new classdata();
        string FirstName;
        string LastName;
        string Name;
        Int64 Phone;
        string ModelTech;
        string ManufactureTech;
        string SeriialNumber;
        string TypeTech;
        string search;
        string Descrp;
        User uid;

        public PageAddRequest(string login)
        {
            InitializeComponent();
            //FirstName = firstname.Text;
            //LastName = secondname.Text;
            //Name = name.Text;
            //Phone = Convert.ToInt64(phone.Text);
            //TypeTech = (string)cmbTechType.SelectedValue;
            //ModelTech = modeltech.Text;
            //ManufactureTech = manufacturetech.Text;
            //SeriialNumber = numbermodel.Text;
            //Descrp = descriptiontxt.Text;
            var users = data.GetUsers();
            var result = users.Where(x => x.Login == login).FirstOrDefault();
            //result.FirstName = "Бакшеев";
            //data.userContext.SaveChanges();
            uid = result;
            search = login;

            cmbTechType.DisplayMemberPath = "Name";
            cmbTechType.SelectedValuePath = "Id";
            cmbTechType.ItemsSource = data.userContext.OrgTechType.ToList();
            //var result = users.Where(x => x.Login == search).ToList();
            //firstname.Text = result.fir
            foreach (var item in users)
            {
                if (item.Login == login)
                {
                    name.Text = item.FirstName;
                    firstname.Text = item.Name;
                    secondname.Text = item.LastName;
                    phone.Text = Convert.ToString(item.Phone);
                    break;
                }
            }
        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            var request = data.GetRequests();
            var type = data.GetOrgTechType();
            var status = data.GetStatys();
            var result = request.ToList();
            var date = DateTime.Now;
            //result.StartDate = Convert.ToString(DateTime.Today);

            Requests requests = new Requests()
            {
                Client = uid,
                Id_OrgTechType = type.Where(x => x.Id == Convert.ToInt32(cmbTechType.SelectedValue)).FirstOrDefault(),
                OrgTechManufacture = manufacturetech.Text,
                OrgTechModel = modeltech.Text,
                OrgTechNumber = numbermodel.Text,
                StartDate = DateOnly.FromDateTime(DateTime.Now),
                Id_Statys = status.Where(x => x.Id == 3).FirstOrDefault()
            };
            data.userContext.Add(requests);
            data.userContext.SaveChanges();
            MessageBox.Show("Данные отправлены");
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные очищены");
            cmbTechType.SelectedValue = 0;
            modeltech.Clear();
            manufacturetech.Clear();
            numbermodel.Clear();
            descriptiontxt.Clear();
        }

        private void look_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageRequestUser(search));
        }
    }
}

//Заявка может содержать данные о виде оргтехники, 
//    модели, описании проблемы, личную информацию (ФИО клиента и номер телефона). 