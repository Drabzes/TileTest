using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Program
{
    class AssetManager
    {
        public static PlayerImages readMobilePlayer()
        {
            PlayerImages playerImage = new PlayerImages();
            try
            {
                //Look for the path we want
                string assetsPlayer = "Assets\\Mobile\\Player";

                //make the path
                var path = Environment.CurrentDirectory;
                path = Path.GetFullPath(Path.Combine(path, @"..\..\"));
                path = Path.Combine(path, assetsPlayer);

                //put the path info in the directoryInfo
                DirectoryInfo di = new DirectoryInfo(path);
                //shorten the path
                path = Path.GetFullPath(Path.Combine(path, @"..\..\..\"));

                //look in all directories
                foreach (var d in di.GetDirectories())
                {
                    List<bitImage> image = new List<bitImage>();
                    //lookup all PGN images in a directory *.PNG
                    foreach (var fi in d.GetFiles())
                    {
                        //Console.WriteLine(fi.Name);
                        //Console.WriteLine(@"{0}\{1}\{2}",assetsPlayer,d,fi);

                        // reads every image en puts it in a list & put it in a bitImage
                        
                        path += String.Format(@"{0}\{1}\{2}", assetsPlayer, d, fi);
                        BitmapImage b = new BitmapImage(new Uri(path, UriKind.Absolute));
                        bitImage n = new bitImage(fi.ToString(), b);
                        path = Path.GetFullPath(Path.Combine(path, @"..\..\..\..\..\"));
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
                    
                }
                //return the images of a player character
                return playerImage;
            }
            catch(Exception ex) when (ex is DirectoryNotFoundException || ex is FileNotFoundException)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error loading something", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
                return playerImage;
            }
              
        }

    }
}
