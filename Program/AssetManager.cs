using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Program
{
    class AssetManager
    {

        
        private List<string> assetsMobilePlayerMoves = new List<string>();
        
        private List<List<BitmapImage>> bitImages = new List<List<BitmapImage>>();
        public AssetManager()
        {
            //load all maps
            assetsMobilePlayerMoves.Add("Attack_01");
            assetsMobilePlayerMoves.Add("Attack_02");
            assetsMobilePlayerMoves.Add("Death");
            assetsMobilePlayerMoves.Add("Idle");
            assetsMobilePlayerMoves.Add("Walk");
        }

        public static void readMobilePlayer()
        {
            List<List<BitmapImage>> bitImages = new List<List<BitmapImage>>();
            
            string assetsPlayer = @"C:\Users\Titaantje\Documents\GitHub\Program\TileTest\Program\Assets\Mobile\Player";
            DirectoryInfo di = new DirectoryInfo(assetsPlayer);

            foreach (var d in di.GetDirectories())
            {
                List<BitmapImage> image = new List<BitmapImage>();
                foreach (var fi in d.GetFiles())
                {
                    //Console.WriteLine(fi.Name);
                    //Console.WriteLine(@"{0}\{1}\{2}",assetsPlayer,d,fi);

                    // reads every image en puts it in a list
                    BitmapImage b = new BitmapImage(new Uri(String.Format(@"{0}\{1}\{2}",assetsPlayer,d,fi), UriKind.Absolute));
                    image.Add(b);
                }
                Console.WriteLine(d.Name);
                bitImages.Add(image);
            }


            //List<BitmapImage> imagesRow = new List<BitmapImage>();
            //b.UriSource = new Uri(assetsPlayer + "\\" + assetsMobilePlayerMoves[0]);
            //imagesRow.Add(b);
            
        }

    }
}
