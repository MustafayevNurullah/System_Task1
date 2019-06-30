using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Task1.Viewmodel
{
    public class ViewModel : BaseViewModel
    {
        public ViewModel()
        {

        }

        private string currentText;
        public string CurrentText
        {
            get
            {
                return currentText;
            }

            set
            {
                currentText = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentText)));
            }
        }
    }
}