﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
 public class CustomList<T>
    {

        // member variables (HAS A)
        T[] items = new T[10];
        int count;

        public T this[int index]
        {
            get
            {
                return items[index];
            }

            set
            {
                items[index] = value;
            }
        }


        // constructor (SPAWNER)
        //  public CustomListClass<T>
        //{

        //}

        // member methods (CAN DO)

        // Need Add Method
        public void Add (T value)
        {
            items[count++] = value;
        }

        // Need an Remove  Method

        public void Remove(T item)
        {

        }

        // Need a loop thro list Method

        public void Loop()
        {

        }

        // Override a Tostring Method

        public void CToString()
        {

        }

        // Overload a + opeartor tp add two instance of custom list

        public void Plus()
        {

        }

        // Count Method
        public void Count()
        {

        }

        // Zip Method
        public void InterLeave()
        {

        }

        // Sort Metod for Bonus

        public void Sort()
        {

        }



    }
}
