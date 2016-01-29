using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Program
{
    class IsoHelper
    {
        public static Point isoTo2D(Point pt)
        {
            var tempPoint = new Point(0,0);
            tempPoint.X = (2 * pt.Y + pt.X) / 2;
            tempPoint.Y = (2 * pt.Y - pt.X) / 2;

            return tempPoint;
        }

        public static Point twoDToIso(Point point)
        {
            var tempPoint = new Point();
            tempPoint.X = point.X - point.Y;
            tempPoint.Y = (point.X + point.Y) / 2;

            return tempPoint;
        }

        public static Point getTileCoordinates(Point point, double tileHeight)
        {
            Point tempPoint = new Point(0, 0);

            tempPoint.X = Math.Floor(point.X / tileHeight);
            tempPoint.Y = Math.Floor(point.Y / tileHeight);

            return tempPoint;
        }

        public static Point get2dFromTileCoordinates(Point point, double tileHeight)
        {
            Point tempPoint = new Point(0, 0);

            tempPoint.X = point.X * tileHeight;
            tempPoint.Y = point.Y * tileHeight;

            return tempPoint;
        }
    }
}
