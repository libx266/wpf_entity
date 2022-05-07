using LearnSchool.Database;
using LearnSchool.Database.Entities;
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

namespace LearnSchool.Pages
{
    /// <summary>
    /// Interaction logic for SelectServicePage.xaml
    /// </summary>
    public partial class SelectServicePage : Page
    {
        EfModel E => EfModel.Instance;
        public SelectServicePage(Service service)
        {
            InitializeComponent();
            DataContext = service;
            CbClients.ItemsSource = EfModel.Instance.Clients.ToList();
        }

        private void OrderService(object sender, RoutedEventArgs e)
        {
            string msg;
            try
            {
                string T = TbTime.Text;
                
                int hours = (int)TbTime.Text.ToDecimal(0);
                int minutes = (int)TbTime.Text.ToDecimal(1);

                if (hours.InRange(0, 4) && minutes.InRange(0, 60))
                {
                    DateTime date = DpServiceDate.SelectedDate.Value.AddHours(hours).AddMinutes(minutes);

                    if (date < DateTime.Now) throw new Exception("Invalid Date");
                    if (CbClients.SelectedItem is null) throw new Exception("Client is undefined");

                    var order = new ClientService
                    {
                        Client = CbClients.SelectedItem.ToString(),
                        Service = BaseEntity.GetItem<Service>(this).Title,
                        DateStart = date.ToString()
                    };
                    E.ClientServices.Add(order);
                    E.SaveChanges();
                    msg = $"Seccessful! ID:  {order.ID}";
                }
                else msg = "Invalid Time";
                
            }
            catch (Exception ex)
            { msg = ex.Message;}
            
            MessageBox.Show(msg);

        }

        private void TbTimeChanged(object sender, TextChangedEventArgs e) =>
            TbTime.Text = TbTime.Text.Where(c => "0123456789:".Contains(c) && TbTime.Text.Length <=5).Join("");
    }
}
