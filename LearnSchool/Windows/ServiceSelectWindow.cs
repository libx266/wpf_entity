using LearnSchool.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LearnSchool.Windows
{
    public class ServiceSelectWindow : MainWindow
    {
        Service Service;
        public ServiceSelectWindow(Service service) : base() => Service = service;

        protected override void Setup()
        {
            Title = Properties.Resources.SelectServiceTitle;
            Height = 650; MinHeight = 650;
            Navigator.Navigate(Navigated = new Pages.SelectServicePage(Service));
        }
    }
}
