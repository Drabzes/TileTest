using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Program
{
    public abstract class Mobile
    {
        public string name;
        public List<List<BitmapImage>> bitImages = new List<List<BitmapImage>>();
        public Point point;
    }
}
