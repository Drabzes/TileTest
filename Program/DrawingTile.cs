using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Program
{
    class DrawingTile
    {
        
        public static void DrawTile(int x, int y, int tileWidth, int tileHeight)
        {
            var mainWindowInstant = (MainWindow)App.Current.MainWindow;
            Polygon myPolygon = new Polygon();
            myPolygon.Stroke = System.Windows.Media.Brushes.Black;
            myPolygon.Fill = System.Windows.Media.Brushes.LightSeaGreen;
            myPolygon.StrokeThickness = 2;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Center;


            PointCollection points = new PointCollection();

            Point topCord = getPointTilePoint(x, y, tileWidth, tileHeight);
            points.Add(topCord);
            Point rightCord = getPointTilePoint(x + 1, y, tileWidth, tileHeight);
            points.Add(rightCord);
            Point botCord = getPointTilePoint(x + 1, y + 1, tileWidth, tileHeight);
            points.Add(botCord);
            Point leftCord = getPointTilePoint(x, y + 1, tileWidth, tileHeight);
            points.Add(leftCord);

            myPolygon.Points = points;

            //int screenX = (x - y) * tileWidth / 2 ;
            //int screenY = (x + y) * tileHeight / 2;

            //int pointX;
            //int pointY;

            //Point p = new Point(screenX, screenY);
            //points.Add(p);

            //pointX = screenX + Convert.ToInt32((tileWidth / 2));
            //pointY = Convert.ToInt32(screenY + (tileHeight / 2));

            //p = new Point(pointX, pointY);
            //points.Add(p);

            //pointX = screenX;
            //pointY = screenY + tileHeight;

            //p = new Point(pointX, pointY);
            //points.Add(p);

            //pointX = Convert.ToInt32(screenX - (tileWidth / 2));
            //pointY = Convert.ToInt32(screenY + (tileHeight / 2));

            //p = new Point(pointX, pointY);
            //points.Add(p);

            mainWindowInstant.drawingCanvas.Children.Add(myPolygon);
        }

        private static Point getPointTilePoint(int x, int y, int with, int height)
        {
            var mainWindowInstant = (MainWindow)App.Current.MainWindow;
            Point point = new Point();
            int screenX = (x - y) * with / 2 + Convert.ToInt32(mainWindowInstant.drawingCanvas.Width / 2);
            int screenY = (x + y) * height / 2;

            point = new Point(screenX, screenY);

            return point;
        }
    }
}
