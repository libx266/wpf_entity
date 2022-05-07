using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using LearnSchool.Database;
using LearnSchool.Database.Entities;
using Microsoft.Win32;

namespace LearnSchool.Pages
{
    /// <summary>
    /// Interaction logic for ServicesPage.xaml
    /// </summary>
    public partial class ServicesPage : Page, INotifyWidthChanged
    {
        List<Service> services;

        public bool Initialized { get; protected set; }
        EfModel E => EfModel.Instance;
        public ServicesPage()
        {
            InitializeComponent();
            CbSort.ItemsSource = Properties.Resources.SortTypes.Split(';');
            CbFilt.ItemsSource = Properties.Resources.FiltTypes.Split(',').Select(s => s.Trim(' '));
            
            var selectUpdated = new SelectionChangedEventHandler((s, e) => UpdateData());
            CbSort.SelectionChanged += selectUpdated;
            CbFilt.SelectionChanged += selectUpdated;

            TbSearch.TextChanged += new TextChangedEventHandler((s, e) => UpdateData());

            UpdateData(); Initialized = true; NotifyWidthChanged();
        }

        public void NotifyWidthChanged() => services.ForEach(s => s.NotifyProperty("Width"));

        void UpdateData()
        {

            string range = CbFilt.SelectedIndex > 0 ? CbFilt.SelectedItem.ToString() : "0 100";
            decimal min = range.ToDecimal(0);
            decimal max = range.ToDecimal(1);
            
            IEnumerable<Service> services = E.Services.ToList().Where(S0 => S0.discount.InRange(min, max, RangeMode.IncludeMin))
                .Where(S1 => S1.Title.ToLower().Contains(TbSearch.Text.ToLower()));
            
            Func<Service, Object> sort = S => S.Price.ToDecimal(0);

            this.services = (Convert.ToBoolean(Math.Abs(CbSort.SelectedIndex)) ? services.OrderByDescending(sort) : services.OrderBy(sort)).ToList();

            this.services.ForEach(S => S.DataChanged += new PropertyChangedEventHandler((s, e) => E.SaveChanges()));

            LVServices.ItemsSource = this.services;

            GC.Collect(); GC.WaitForPendingFinalizers(); GC.Collect();
        }

        private void SelectService(object sender, RoutedEventArgs e)
        {
            var service = LVServices.SelectedItem as Service;
            if (service) new Windows.ServiceSelectWindow(service).ShowDialog();
        }

        private void DeleteService(object sender, RoutedEventArgs e)
        {
            var service = LVServices.SelectedItem as Service;
            if (service && Log.Warning(String.Format(Properties.Resources.DeleteWarning, "")))
            {
                E.Services.Remove(service);
                E.SaveChanges();
                UpdateData();
            }
        }

        private void AddService(object sender, RoutedEventArgs e)
        {
            var W = new Windows.AddServiceWindow();
            W.ShowDialog();
            E.Services.Add(W.Service);
            E.SaveChanges();
            UpdateData();
        }
    }
}
