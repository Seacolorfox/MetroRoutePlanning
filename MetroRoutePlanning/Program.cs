using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroRoutePlanning
{
    class Program
    {
       
        public static void Help()
        {
            Console.WriteLine("-map [输入文件(txt)] 读取地铁路线");
            Console.WriteLine("-a 指定用户希望查询的地铁线路，后接-o来指定输出文件\n例如：subway.exe -a 1号线 -map subway.txt -o station.txt");
            Console.WriteLine("-b [起点站] [终点站] -map [输入文件(txt)] -o [输出文件(txt)]\n例如：subway.exe -b 洪湖里 复兴路 -map subway.txt -o routine.txt");
        }
        static void Main(string[] args)
        {
            if(args.Length==1)
            {
                if (args[0].Equals("-map"))
                {
                    Console.WriteLine("全部地铁线路如下： ");
                    LineReader.Read();
                }
                else
                {
                    if (args[0].Equals("-h"))
                    {
                        Help();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("参数输入错误，输入-h查看帮助");
                        return;
                    }

                }
            }
            else if(args.Length==2)
            {
                if(args[0].Equals("-a"))
                {
                    LineReader.ReadLine(args[1]);
                }
            }
            return;
          //  Console.ReadKey();
        }
    }
}
