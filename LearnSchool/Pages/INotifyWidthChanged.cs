using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LearnSchool.Pages
{
    interface INotifyWidthChanged
    {
        void NotifyWidthChanged();
        bool Initialized { get; }
    }
}
