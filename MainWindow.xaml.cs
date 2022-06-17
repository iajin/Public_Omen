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
            LoadImages();
            //LoadUpandDownImages();

        }

        //private void LoadUpandDownImages()
        //{
        //    UpImage.Source = LoadImage("Up.png");
        //    DownImage.Source = LoadImage("Down.png");
        //}

        private void LoadImages()
        {
            this.lst_gallery.ItemsSource = new GalleryData[]
            {
                new GalleryData{Name="GameImage 1", Image=LoadImage("GameImage.jfif")},
                new GalleryData{Name="GameImage 2", Image=LoadImage("GameImage.jfif")},
                new GalleryData{Name="GameImage 3", Image=LoadImage("GameImage.jfif")},
                new GalleryData{Name="GameImage 4", Image=LoadImage("GameImage.jfif")},
                new GalleryData{Name="GameImage 5", Image=LoadImage("GameImage.jfif")},
                new GalleryData{Name="GameImage 6", Image=LoadImage("GameImage.jfif")},
                new GalleryData{Name="GameImage 7", Image=LoadImage("GameImage.jfif")},
                new GalleryData{Name="GameImage 8", Image=LoadImage("GameImage.jfif")},

            };
            txt_results.Text = lst_gallery.Items.Count.ToString();

        }
        private BitmapImage LoadImage(string filename)
        {
            return new BitmapImage(new Uri("pack://application:,,,/" + filename));
        }


        private void btn_Add_Filter_Click(object sender, RoutedEventArgs e)
        {
            lbl_filter.Content = txt_Input.Text;
        }
    }
}
