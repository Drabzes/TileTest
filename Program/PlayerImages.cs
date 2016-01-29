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
        private List<BitmapImage> Attack_01 = new List<BitmapImage>();
        private List<BitmapImage> Attack_02 = new List<BitmapImage>();
        private List<BitmapImage> Death = new List<BitmapImage>();
        private List<BitmapImage> Idle = new List<BitmapImage>();
        private List<BitmapImage> Walk = new List<BitmapImage>();

        public void addAttack_01 (BitmapImage i)
        {
            Attack_01.Add(i);
        }

        public BitmapImage addAttack_01(int i)
        {
            return Attack_01[i];
        }

        public void addAttack_02(BitmapImage i)
        {
            Attack_02.Add(i);
        }

        public BitmapImage addAttack_02(int i)
        {
            return Attack_02[i];
        }

        public void addDeath(BitmapImage i)
        {
            Death.Add(i);
        }

        public BitmapImage addDeath(int i)
        {
            return Death[i];
        }

        public void addIdle(BitmapImage i)
        {
            Idle.Add(i);
        }

        public BitmapImage addIdle(int i)
        {
            return Idle[i];
        }

        public void addWalk(BitmapImage i)
        {
            Walk.Add(i);
        }

        public BitmapImage addWalk(int i)
        {
            return Walk[i];
        }
    }
}
