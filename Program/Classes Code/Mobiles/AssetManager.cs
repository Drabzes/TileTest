using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Program
{
    class AssetManager
    {
        public static PlayerImages readMobilePlayer()
        {
            PlayerImages playerImage = new PlayerImages();

            //load the directory
            string assetsPlayer = "Classes Code\\Assets\\Mobile\\Player\\";
            string relativeFile = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Classes Code\Assets\Mobile\Player\";
            var pathnaam = Path.GetDirectoryName(assetsPlayer);
            DirectoryInfo di = new DirectoryInfo(relativeFile);
            
            //look in all directories
            foreach (var d in di.GetDirectories())
            {
                List<bitImage> image = new List<bitImage>();
                //lookup all PGN images in a directorie *.PNG
                foreach (var fi in d.GetFiles())
                {
                    //Console.WriteLine(fi.Name);
                    //Console.WriteLine(@"{0}\{1}\{2}",assetsPlayer,d,fi);

                    // reads every image en puts it in a list & put it in a bitImage
                    BitmapImage b = new BitmapImage(new Uri(String.Format(@"{0}\{1}\{2}",assetsPlayer,d,fi), UriKind.Absolute));
                    bitImage n = new bitImage(fi.ToString(), b);
                    
                    image.Add(n);

                    //check in which directory the image is from
                    switch (d.Name)
                    {
                        case "Attack_01":
                            playerImage.addAttack_01(n);
                            break;
                        case "Attack_02":
                            playerImage.addAttack_02(n);
                            break;
                        case "Death":
                            playerImage.addDeath(n);
                            break;
                        case "Idle":
                            playerImage.addIdle(n);
                            break;
                        case "Walk":
                            playerImage.addWalk(n);
                            break;
                        default:
                            // send a message if nothing is loaded
                            Console.WriteLine("Nothing got loaded in to the BitImage file");
                            break;
                    }
                }
                Console.WriteLine("Images loaded from file: {0}", di.Name);
            }

            //return the images of a player character
            return playerImage;   
        }

    }
}
