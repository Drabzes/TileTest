using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Program
{
    class Map
    {
        private List<Region> _map = new List<Region>();

        public Map ()
        {
        }

        public void addMap(Region region)
        {
            _map.Add(region);
        }

        public List<List<Tile>>showMap(string name)
        {
            Region value = null;
            if ( _map.Exists(x => x.giveRegionName().Contains(name)))
            {
                foreach (Region region in _map)
                {
                    if ( region.getName().Equals(name))
                    {
                        value = region;
                        break;
                    }
                }
                return value.getRegionValue();
            }
            else
            {
                return value.getRegionValue();
            }  
        }

        public Region getmap(int index)
        {
            try
            {
                return _map[index];
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
                return null;
            }
            
        }
    }
}
