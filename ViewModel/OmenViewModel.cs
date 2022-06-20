using Demo_Omen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Demo_Omen.ViewModel
{
    internal class OmenViewModel
    {
        private IList<GalleryData> _ImageList = null;
        public IList<GalleryData> ImageList
        {
            get { return _ImageList; }
            set { _ImageList = value; }
        }
        public OmenViewModel()
        {
            LoadImages();
        }

        private int _results;
        public int Results 
        {
            get { return _results; }
            set { _results = value; }
        }

        public void LoadImages()
        {
            _ImageList = new List<GalleryData>
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
            _results = _ImageList.Count;
        }

        private BitmapImage LoadImage(string filename)
        {
            return new BitmapImage(new Uri("pack://application:,,,/" + filename));
        }
    }
}
