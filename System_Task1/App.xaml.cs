﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace System_Task1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public  partial  class App : Application
    {
        public static
        Dictionary<string, int> keyValuePairs;
        public App()
        {
            keyValuePairs = new Dictionary<string, int>();            
        }
    }
}
