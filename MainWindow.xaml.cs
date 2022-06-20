using Demo_Omen.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo_Omen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Uri iconUri = new ("pack://application:,,,/Artboard_3.png", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);
            //LoadImages();
            //LoadUpandDownImages();

        }

        //private void LoadUpandDownImages()
        //{
        //    UpImage.Source = LoadImage("Up.png");
        //    DownImage.Source = LoadImage("Down.png");
        //}

        private void btn_Add_Filter_Click(object sender, RoutedEventArgs e)
        {
            lbl_filter.Content = txt_Input.Text;
        }
    }
}
