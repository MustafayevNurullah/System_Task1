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

namespace System_Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            string[] droppedFiles = null;
        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> List = new List<string>();
      

        private void Ellipse_Drop(object sender, DragEventArgs e)
        {
        Ellipse ellipse = (sender as Ellipse);
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                droppedFiles = e.Data.GetData(DataFormats.FileDrop, true) as string[];
                StreamReader file = new StreamReader($"{droppedFiles[0]}");
                string Name;

                while ((Name = file.ReadLine()) != null)
                {
                    List.Add(Name);
                }
                string[] filePaths = Directory.GetFiles(@"C:\", "*.txt",
                                         SearchOption.TopDirectoryOnly);
            }
        }
    }
}
