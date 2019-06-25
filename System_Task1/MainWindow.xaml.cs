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
using Path = System.IO.Path;

namespace System_Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static void DirSearch(string sDir,List<string> list)
        {
            string data = String.Empty;
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        // Console.WriteLine(f);
                      //  MessageBox.Show(f);
                        //Console.WriteLine("__________________________________________");
                        if (f.Contains(".txt"))
                        {
                            using (StreamReader sr = new StreamReader(f))
                            {

                                data = sr.ReadToEnd();
                            }
                            foreach (var item in list)
                            {
                            var hasWord = data.Contains(item);
                            if (hasWord)
                            {

                                  MessageBox.Show("yes");
                                  string  fileName = Path.GetFileName(f);
                                    string[] pathArr = fileName.Split('.');
                                    File.Copy(f, "\\\\STHQ01DC01\\dfr$\\Must_xm12\\Desktop\\"+$"{pathArr[0]}"+ DateTime.Now.ToString("ff")+"."+pathArr[1]);
                                    string path= ("\\\\STHQ01DC01\\dfr$\\Must_xm12\\Desktop\\" + $"{pathArr[0]}" + DateTime.Now.ToString("ff") + "Copy." + pathArr[1]);
                                    File.Copy(f, path);
                                    string text = File.ReadAllText(path);
                                    text = text.Replace($"{item}", $"**{item}**");
                                    File.WriteAllText($"{path}", text);
                                }
                            }
                        }
                    }
                    DirSearch(d,list);
                }
            }
            catch (System.Exception excpt)
            {
                //    Console.WriteLine(excpt.Message);
              MessageBox.Show("Excpt"+excpt.Message);
            }
        }

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
                DirSearch(@"C:\Users\Must_xm12\source\repos\System_Task12",List);
            }
        }
    }
}
