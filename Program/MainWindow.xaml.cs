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


            //rechthoekTekenen(0, 1, 64, 32);


        }

        private void DrawTile(int x, int y, int tileWidth, int tileHeight)
        {
            Polygon myPolygon = new Polygon();
            myPolygon.Stroke = System.Windows.Media.Brushes.Black;
            myPolygon.Fill = System.Windows.Media.Brushes.LightSeaGreen;
            myPolygon.StrokeThickness = 2;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;

            Point topCord = getPointTilePoint(x, y);
            Point rightCord = getPointTilePoint(x + 1, y);
            Point botCord = getPointTilePoint(x + 1, y + 1);
            Point leftCord = getPointTilePoint(x, y + 1);

            int screenX = (x - y) * tileWidth / 2 + Convert.ToInt32(drawingCanvas.Width / 2);
            int screenY = (x + y) * tileHeight / 2;

            int pointX;
            int pointY;

            PointCollection points = new PointCollection();

            Point p = new Point(screenX, screenY);
            points.Add(p);

            pointX = screenX + Convert.ToInt32((tileWidth / 2));
            pointY = Convert.ToInt32(screenY + (tileHeight / 2));

            p = new Point(pointX, pointY);
            points.Add(p);

            pointX = screenX;
            pointY = screenY + tileHeight;

            p = new Point(pointX, pointY);
            points.Add(p);

            pointX = Convert.ToInt32(screenX - (tileWidth / 2));
            pointY = Convert.ToInt32(screenY + (tileHeight / 2));

            p = new Point(pointX, pointY);
            points.Add(p);


            myPolygon.Points = points;
            drawingCanvas.Children.Add(myPolygon);
        }

        private Point getPointTilePoint(int x, int y)
        {
            Point point = new Point();
            int screenX = (x - y) * 64 / 2;
            int screenY = (x + y) * 64 / 2;

            point = new Point(screenX, screenY);

            return point;
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

                    DrawTile(i, j, width, height);


                    // get the value of the rectangle
                    //Rectangle tile = CreateVisualMap.draw(value[j].getValue(), width, height);
                    //RotateTransform rotation = new RotateTransform();
                    ////tile.LayoutTransform = new RotateTransform(45, 0, 0);
                    //drawingCanvas.Children.Add(tile);

                    //Canvas.SetTop(tile, j + width);
                    //Canvas.SetLeft(tile, i + height);



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

        private void rechthoekdraaien()
        {
            Rectangle tile = new Rectangle()

            {
                Stroke = Brushes.Black,
                StrokeThickness = 1
            };

            tile.Width = 64;
            tile.Height = 64;
            tile.Fill = Brushes.Red;
            
            tile.LayoutTransform = new RotateTransform(45,0,0);

            drawingCanvas.Children.Add(tile);
            Canvas.SetTop(tile, 0);
            Canvas.SetLeft(tile, 0);

            
        }



    }  
}
