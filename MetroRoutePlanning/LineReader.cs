using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroRoutePlanning
{
    class LineReader
    {
        public static void Read()
        {
            string line;
            try
            {
                FileStream aFile = new FileStream("subway.txt", FileMode.OpenOrCreate);
                StreamReader streamReader = new StreamReader(aFile);
                line = streamReader.ReadToEnd();
                Console.WriteLine(line);
                streamReader.Close();
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return;
            }
        }
        public static void ReadLine(string input)
        {
            string[] line;
            line = File.ReadAllLines("subway.txt");
            if(line.Length>0)
            {
                Console.WriteLine(line[Convert.ToInt32(input)]);
            }
        }
    }
}
