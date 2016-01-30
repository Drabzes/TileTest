using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class ReadRegion
    {
        public static Region Read (string fileName)
        {
            try
            {
                string _regionName = "";
                string text = "";
                XmlTextReader reader = new XmlTextReader(fileName);

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            _regionName = reader.Name;
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                            text = reader.Value;
                            break;
                    }

                }
                Console.ReadLine();

                // remeber list of the region
                List<List<Tile>> _Region = new List<List<Tile>>();

                //split the string into an array
                String[] substrings = text.Split();

                int countRows = 0;
                // get each line in the array
                foreach (string row in substrings)
                {
                    //check if the line is an empty lines
                    if (!String.IsNullOrEmpty(row))
                    {
                        // removes the , in the array
                        ArrayList numbers = new ArrayList(row.Split(new char[] { ',' }));

                        // creates a help list.
                        var sublist = new List<Tile>();

                        // puts all the tile info off a row in the help list
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            //declare tile info.
                            Tile tile = new Tile("Tile " + countRows + " " + j, Convert.ToInt32((numbers[j])));
                            sublist.Add( tile );
                        }
                        _Region.Add(sublist);
                        countRows++;
                    }
                }

                Region region = new Region(_Region, _regionName);
                return region;
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return null;
            }
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}
