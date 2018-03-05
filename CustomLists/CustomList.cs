using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists
{
 public class CustomList<T> 
    {

        // member variables (HAS A)
        T[] items = new T[6];
        int count = 0;
        int capacity;

        public int Length
        {
            get { return items.Length; }
        }

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

        public IEnumerator<T> Count()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
                count = count + 1;
            }
        }




        // Need Add Method
        public void Add (T value)
        {
            if(count < items.Length)
            {
                items[count++] = value;
            }else
            {
                int newsize = items.Length * 2;
                Resize( newsize);
                items[count++] = value;
            } 
           
           
            
        }

        // Resize method 
        public void Resize(int newsize)
        {
            T[] newarray = new T[newsize];
            for (int i = 0; i < items.Length; i++)
            {
                newarray[i] = items[i];
               
            }
            items = newarray;
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
        //public void Count()
        //{


        //}




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
