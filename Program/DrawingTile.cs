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
            throw new NotImplementedException();
        }
    }
}
