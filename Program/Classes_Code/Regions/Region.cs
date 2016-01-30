using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Region
    {
        private string _name;
        private List<List<Tile>> _regionValue = new List<List<Tile>>();
        

        public Region (List<List<Tile>> valueRegion, string name)
        {
            _name = name;
            _regionValue = valueRegion;
        }

        public string getName()
        {
            return _name;
        }

        public void printRegion()
        {
            Console.WriteLine("Elements:");
            foreach (var sublist in _regionValue)
            {
                foreach (var value in sublist)
                {
                    Console.Write(value.getValue());
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public void printRegionBlocks()
        {
             
        }

        public int getTileValueAtIndex(int x, int y)
        {
            return _regionValue[x][y].getValue();
        }

        public string getTileNameAtIndex(int x, int y)
        {
            return _regionValue[x][y].getName();
        }

        public string getTileInfo(int x, int y)
        {
            return _regionValue[x][y].printInfo();
        }

        public string giveRegionName()
        {
            return _name;
        }

        public List<List<Tile>> getRegionValue()
        {
            return _regionValue;
        }
    }
}
