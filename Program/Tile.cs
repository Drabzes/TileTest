using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Program
{
    class Tile
    {
        int _value;
        string _name;
        string _path;
        bool _walkable;
        int _frame;

        public Tile (string name, int value)
        {
            _name = name;
            _value = value;
        }

        public  void setFrame( int value)
        {
            _frame = value;
        }

        public void setWalkable (bool value)
        {
            _walkable = value;
        }

        public string getName()
        {
            return _name;
        }

        public int getValue()
        {
            return _value;
        }

        public string printInfo()
        {
            return String.Format("Tile name = {1} {0}the value of this Tile is {2}.",
                                         Environment.NewLine, _name , _value);
        }
    }
}
