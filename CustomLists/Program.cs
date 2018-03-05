using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> stuff = new CustomList<int>();
            stuff.Add(30);
            stuff.Add(89);
            stuff.Add(298);
            stuff.Add(808);
            stuff.Add(789);
            stuff.Add(83);
            stuff.Add(65);
            stuff.Add(5656);
            stuff.Add(89);
            stuff.Add(786);
            stuff.Add(897);
            stuff.Add(788);
            stuff.Add(78);

            Console.WriteLine(stuff[12]);

         

            Console.WriteLine(stuff[12]);





        }
    }
}
