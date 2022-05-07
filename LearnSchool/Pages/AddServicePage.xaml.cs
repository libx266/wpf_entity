using LearnSchool.Database;
using LearnSchool.Database.Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace LearnSchool.Pages
{
    /// <summary>
    /// Interaction logic for AddServicePage.xaml
    /// </summary>
    public partial class AddServicePage : Page
    {
        public AddServicePage()
        {
            DataContext = new Service
            {
                Title = "Новая услуга",
                Price = "1488 руб"
            };
            InitializeComponent();
        }

        private void ChangeImage(object sender, MouseButtonEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image files |*.jpg;*.png;*.bmp;*webp;";
            if (Convert.ToBoolean(dialog.ShowDialog()))
            {
                BaseEntity.GetItem<Service>(sender).Image =
                    File.ReadAllBytes(dialog.FileName);
            }
        }
    }
}
