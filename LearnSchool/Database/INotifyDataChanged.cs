using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Database
{
    interface INotifyDataChanged
    {
        event PropertyChangedEventHandler DataChanged;

        bool NotifyData(string propName = "");
    }
}
