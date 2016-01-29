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
        BitmapImage carBitmap = new BitmapImage(new Uri(".//Tuscan_Idle_60000.png", UriKind.Relative));
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
                    DrawingTile.DrawTile(i, j, width, height, value[j]);


                    


                    // get the value of the rectangle
                    //Rectangle tile = CreateVisualMap.draw(value[j].getValue(), width, height);
                    //RotateTransform rotation = new RotateTransform();
                    ////tile.LayoutTransform = new RotateTransform(45, 0, 0);
                    //drawingCanvas.Children.Add(tile);

                    //Canvas.SetTop(tile, j + width);
                    //Canvas.SetLeft(tile, i + height);

                }
                i++;
            }
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

            return point;
        }
            

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
        }
        private void getCords(double x, double y, double tileWidth, double tileHeight)
       {
           double test = ((x / (tileWidth / 2) + y / (tileHeight / 2)) / 2);
           //take the lowest cord -x
           int mapX = Convert.ToInt32(Math.Floor(test));
      
           test = (y / (tileHeight / 2) - (x / (tileWidth / 2))) / 2;
           //take the lowest cord -Y
            int mapY = Convert.ToInt32(Math.Floor(test));

            Console.WriteLine("Cord x {0} and cord y {1} ", mapX, mapY);
          }

        private void drawingCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var pos = this.PointToScreen(Mouse.GetPosition(this));
            getCords(Convert.ToInt32(pos.X - (drawingCanvas.ActualWidth / 2)), Convert.ToInt32(pos.Y), 64, 32);
        }
    }  
}
