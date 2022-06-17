using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Demo_Omen
{
    public class GalleryData
    {
        private string _Name;
        public string Name
        {
            get { return this._Name; }
            set { this._Name = value; }
        }

        private BitmapImage _Image;
        public BitmapImage Image
        {
            get { return this._Image; }
            set { this._Image = value; }
        }
    }
}
