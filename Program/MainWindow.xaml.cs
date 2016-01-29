using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Program
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BitmapImage carBitmap = new BitmapImage(new Uri(@"C:\Users\Titaantje\Documents\Visual Studio 2015\Projects\Program\Tiles\iso_0.png", UriKind.Absolute));
        Image[] carImg = new Image[5];
        Random rnd = new Random();



        public MainWindow()
        {
            InitializeComponent();

            // inisialize map
            Map map = new Map();

            //load a reagion into the map.
            map.addMap(ReadRegion.Read(".//Region 1.xml"));

            
            Region toLoadRegion = map.getmap(0);

            List<List<Tile>> drawList = toLoadRegion.getRegionValue();

            RevealRegion(drawList);

            drawChar();


            //rechthoekTekenen(0, 1, 64, 32);


        }

        private void RevealRegion(List<List<Tile>> drawList)
        {
            int i = 0;

            int width = 64;
            int height = 32;

            //plits the matrix in mutiple rows
            foreach (var value in drawList)
            {
                //ge the value of each row
                for (int j = 0; j < value.Count; j++)
                {
                    DrawingTile.DrawTile(i, j, width, height);

<<<<<<< HEAD
=======
                    
>>>>>>> parent of 8dc4d0f... Revert "test"


                    // get the value of the rectangle
                    //Rectangle tile = CreateVisualMap.draw(value[j].getValue(), width, height);
                    //RotateTransform rotation = new RotateTransform();
                    ////tile.LayoutTransform = new RotateTransform(45, 0, 0);
                    //drawingCanvas.Children.Add(tile);

                    //Canvas.SetTop(tile, j + width);
                    //Canvas.SetLeft(tile, i + height);
<<<<<<< HEAD
=======
                }
                i++;
            }

            
        }

        private void drawChar()
        {
            Image tekening = new Image();
            tekening.Source = carBitmap;
            tekening.Width = 128;
            tekening.Height = 64;
            drawingCanvas.Children.Add(tekening);
            Canvas.SetTop(tekening, getPointTilePoint(1, 1, 64, 32).Y);
            Canvas.SetLeft(tekening, getPointTilePoint(1, 1, 64, 32).X);
        }

        private Point getPointTilePoint(int x, int y, int with, int height)
        {
            var mainWindowInstant = (MainWindow)App.Current.MainWindow;
            Point point = new Point();
            int screenX = (x - y) * with / 2 + Convert.ToInt32(mainWindowInstant.drawingCanvas.Width / 2);
            int screenY = (x + y) * height / 2;
>>>>>>> parent of 8dc4d0f... Revert "test"



                    /*
                    if (value[j].getValue() == 0)
                    {
                        Image tekening = new Image();
                        tekening.Source = carBitmap;
                        tekening.Width = carBitmap.Width;
                        tekening.Height = carBitmap.Height;
                        drawingCanvas.Children.Add(tekening);
                        Canvas.SetTop(tekening, i * width);
                        Canvas.SetLeft(tekening, j * height);
                    }
                    */
                }
                i++;
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            drawChar();
        }
    }  
}
