using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;

namespace LearnSchool.Database
{
    public abstract class BaseEntity : INotifyPropertyChanged, INotifyDataChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangedEventHandler DataChanged;

        public bool NotifyProperty([CallerMemberName] string propName = "")
        {
            if (PropertyChanged is null) return false;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
            return true;
        }

        public bool NotifyData([CallerMemberName] string propName = "")
        {
            if (DataChanged is null) return false;
            DataChanged.Invoke(this, new PropertyChangedEventArgs(propName));
            return true;
        }

        [Key]
        [ScriptIgnore]
        public int ID { get; set; }

        public static implicit operator bool(BaseEntity e) => e != null;

        public double Width => MainWindow.WD - 48;

        public static T GetItem<T>(object sender) where T : BaseEntity => (sender as FrameworkElement).DataContext as T;

    }

}
