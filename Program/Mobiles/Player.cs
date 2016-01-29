using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Program.Mobiles
{
    class Player:Mobile
    {
        public Player(string playerName, Point startCord)
        {
            setName(playerName);
            setPosition(startCord);
        }

        public void setName(string name)
        {
            base.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void addImageList(List<BitmapImage> image)
        {
            bitImages.Add(image);
        }

        public BitmapImage getImage(int x, int y)
        {
            return bitImages[x][y];
        }

        public void setPosition(Point cordPoint)
        {
            point = cordPoint;
        }

        public Point getPointposition()
        {
            return point;
        }


    }
}
