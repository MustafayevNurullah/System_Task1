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
using System.Windows.Shapes;
using System_Task1.Viewmodel;

namespace System_Task1.View
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
            ViewModel viewModel = new ViewModel();
        public View()
        {
            InitializeComponent();
            DataContext = viewModel;
        }
        private void TextBox_Drop(object sender, DragEventArgs e)
        {

        }
    }
}
