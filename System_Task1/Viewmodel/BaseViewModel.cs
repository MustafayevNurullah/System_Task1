﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Task1.Viewmodel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
       public void OnPropertyChanged(PropertyChangedEventArgs e)
        {

            PropertyChanged?.Invoke(this, e);
        }
    }
}
