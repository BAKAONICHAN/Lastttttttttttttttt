using Microsoft.Win32;
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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
      
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            name.Text = "picture.jpg";
          
            BitmapImage myBitmapImage1 = new BitmapImage();

            myBitmapImage1.BeginInit();
            myBitmapImage1.UriSource = new Uri(@"Z:\www\picture.jpg", UriKind.Absolute);
            myBitmapImage1.EndInit();

            JPG.Source = myBitmapImage1;
        }
       
    }
}

