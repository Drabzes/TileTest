using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Program
{
    class Player : Mobile
    {
        PlayerImages images = new PlayerImages();
        public Player(string playerName, Point startCord, PlayerImages i)
        {
            setName(playerName);
            setPosition(startCord);
            images = i;
        }

        public void setName(string name)
        {
            base.name = name;
        }

        public string getName()
        {
            return name;
        }


        public BitmapImage getAttack01Image(string imageName)
        {
            
            return images.getAttack_01(imageName);
        }

        public BitmapImage getAttack02Image(string imageName)
        {

            return images.getAttack_02(imageName);
        }

        public BitmapImage getDeathImage(string imageName)
        {

            return images.getDeath(imageName);
        }

        public BitmapImage getIdleImage(string imageName)
        {

            return images.getIdle(imageName);
        }

        public BitmapImage getWalk(string imageName)
        {

            return images.getWalk(imageName);
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
