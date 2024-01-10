using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Atributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs Holiday = new Songs("Holiday", "Mark", "Generous", 6);
            Songs Ghetto = new Songs("Ghetto", "Akon", "Begin", 3);
            Songs Soweto = new Songs("Soweto", "Maseven", "RapLyf", 2);
            Songs Truth = new Songs("Truth", "Preelicant", "Promise", 5);


            Console.WriteLine(Songs.songCount);

            Console.Read();

        }

        
    }
}
