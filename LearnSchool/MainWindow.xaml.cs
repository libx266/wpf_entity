using LearnSchool.Database;
using LearnSchool.Database.Entities;
using LearnSchool.Pages;
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
using MyRabbit;

namespace LearnSchool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static EfModel E => EfModel.Instance;

        static Window W;

        protected Page Navigated;
        public static double WD => W.ActualWidth;
        List<T> Parse<T>(string name) => new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<List<T>>(System.IO.File.ReadAllText($"./{name}.json"));

        static MainWindow()
        {
            Console.Write("Password:  ");
            EfModel.Login = ImageEncrypter.Decode(Properties.Resources.Original, Properties.Resources.Comparable, Console.ReadLine());
        }

        public MainWindow()
        {
            if (0 == 1)
            {
                E.Clients.AddRange(Parse<Client>("client"));
                E.Services.AddRange(Parse<Service>("service"));
                E.ClientServices.AddRange(Parse<ClientService>("clientservice"));
            }
            ContentRendered += new EventHandler((s, e) => Setup());
            InitializeComponent();
            
            if (this is MainWindow) SizeChanged += new SizeChangedEventHandler((s, e) => NotifyWidth());
            
        }

        private void NotifyWidth()
        {
            var page = Navigated as INotifyWidthChanged;
            if (page != null && page.Initialized) 
                page.NotifyWidthChanged();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            ContentRendered -= new EventHandler((s, e) => Setup());
        }



        protected virtual void Setup()
        {
            W = this;
            Title = Properties.Resources.MainWindowTitle;
            Navigator.Navigate(Navigated = new Pages.ServicesPage());
        }
    }
}
