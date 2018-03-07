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
            test1.Add(1);
            test1.Add(3);
            test1.Add(5);
            test2.Add(2);
            test2.Add(4);
            test2.Add(6);
            test3 = test3.Zipper(test1, test2);

       
        //    test3 = test1 - test2;
          //  Console.WriteLine(test3[1]);
            

                   


        }
    }
}
