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
            Console.WriteLine(stuff.ToString());
           

            Console.WriteLine(stuff[5]);

            stuff.Remove(83);

            Console.WriteLine(stuff[5]);

            Console.WriteLine(stuff.Count());

            CustomList<int> test1 = new CustomList<int>();
            CustomList<int> test2 = new CustomList<int>();
            CustomList<int> test3 = new CustomList<int>();
            test1.Add(12);
            test1.Add(36);
            test1.Add(56);
            test2.Add(35);
            test2.Add(34);
            test2.Add(78);
            test2.Add(90);
            test2.Add(89);

       
            test3 = test1 - test2;
          //  Console.WriteLine(test3[1]);
            

                   


        }
    }
}
