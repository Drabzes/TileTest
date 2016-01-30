using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Program
{
    class bitImage
    {
        public string name { get; set; }
        BitmapImage image = new BitmapImage();

        public bitImage(string imageName, BitmapImage bitImage)
        {
            name = imageName;
            image = bitImage;
        }

        public BitmapImage getImage()
        {
            return image;
        }
    }
}
