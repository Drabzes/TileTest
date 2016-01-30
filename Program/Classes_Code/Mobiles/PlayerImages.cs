using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Program
{
    class PlayerImages
    {
        //list of images that will be used
        private List<bitImage> Attack_01 = new List<bitImage>();
        private List<bitImage> Attack_02 = new List<bitImage>();
        private List<bitImage> Death = new List<bitImage>();
        private List<bitImage> Idle = new List<bitImage>();
        private List<bitImage> Walk = new List<bitImage>();

        //add image to or get an image
        public void addAttack_01 (bitImage i)
        {
            Attack_01.Add(i);
        }

        public bitImage addAttack_01(int i)
        {
            return Attack_01[i];
        }

        public BitmapImage getAttack_01(string name)
        {
            BitmapImage image = new BitmapImage();
            foreach (var n in Attack_01)
            {
                if (n.name.Equals(name))
                {
                    image = n.getImage();
                }
            }
            return image;
        }

        public void addAttack_02(bitImage i)
        {
            Attack_02.Add(i);
        }

        public bitImage addAttack_02(int i)
        {
            return Attack_02[i];
        }

        public BitmapImage getAttack_02(string name)
        {
            BitmapImage image = new BitmapImage();
            foreach (var n in Attack_02)
            {
                if (n.name.Equals(name))
                {
                    image = n.getImage();
                }
            }
            return image;
        }

        public void addDeath(bitImage i)
        {
            Death.Add(i);
        }

        public bitImage addDeath(int i)
        {
            return Death[i];
        }

        public BitmapImage getDeath(string name)
        {
            BitmapImage image = new BitmapImage();
            foreach (var n in Death)
            {
                if (n.name.Equals(name))
                {
                    image = n.getImage();
                }
            }
            return image;
        }

        public void addIdle(bitImage i)
        {
            Idle.Add(i);
        }

        public bitImage addIdle(int i)
        {
            return Idle[i];
        }

        public BitmapImage getIdle(string name)
        {
            BitmapImage image = new BitmapImage();
            foreach (var n in Idle)
            {
                if (n.name.Equals(name))
                {
                    image = n.getImage();
                }
            }
            return image;
        }

        public void addWalk(bitImage i)
        {
            Walk.Add(i);
        }

        public bitImage addWalk(int i)
        {
            return Walk[i];
        }

        public BitmapImage getWalk(string name)
        {
            BitmapImage image = new BitmapImage();
            foreach (var n in Walk)
            {
                if (n.name.Equals(name))
                {
                    image = n.getImage();
                }

            }
            if (image == null)
            {
                Console.WriteLine("Coulnd find {0}", name);
            }
            return image;
        }
    }
}
