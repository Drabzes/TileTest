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
            drawingCanvas.Children.Add(myPolygon);
        }
    }
}
