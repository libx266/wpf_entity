using LearnSchool.Database;
using LearnSchool.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LearnSchool.Windows
{
    public class AddServiceWindow : MainWindow
    {
        public Service Service => BaseEntity.GetItem<Service>(Navigated);

        public AddServiceWindow() : base() { }

        protected override void Setup()
        {
            Width = 750; Height = 400;
            MinHeight = 400; MaxHeight = 400;
            MinWidth = 750; MaxWidth = 750;
            
            Title = Properties.Resources.ServiceAddTitle;
            
            Navigator.Navigate(Navigated = new Pages.AddServicePage());
        }
    }
}
