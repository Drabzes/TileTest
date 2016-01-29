using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Program
{
    class CreateVisualMap
    {
        public static Rectangle draw(int tileValue, int width, int height)
        {
            Rectangle Tile = new Rectangle()

            {
                Stroke = Brushes.Black,
                StrokeThickness = 1
            };

            Tile.Width = width;
            Tile.Height = height;
            Tile.Fill = getValue(tileValue);
            return Tile;
        }

        private static Brush getValue(int value)
        {
            if (value == 1)
            {
                return Brushes.Red;
            }
            else
            {
                return Brushes.Green;
            }
        }

        
    }
}
