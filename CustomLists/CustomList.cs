using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLists 
{
    public class CustomList<T> :  IEnumerable
    {

        // member variables (HAS A)
        public T[] items = new T[6];
        public int count = 0;
        public int index;
        

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

        // Need a loop thro list Method

        // public void Loop(): IEnumerable

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];

            }
        }
        //public IEnumerator GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}






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
            for (int i = 0; i < count; i++)
            {
                
                if (items[i].Equals(item))
                {
                    index = i;
                    count = items.Length - index;
                }
                else
                {

                }

            }
                for (int j = index ; j < count; j++)
                {
                items[j] = items[j + 1];
                }  
            }
                
        
        // Need a loop thro list Method


        // Override a Tostring Method

        public override  string ToString()
        {
            return base.ToString();

        }

        // Overload a + opeartor tp add two instance of custom list

        public static CustomList<T> operator +(CustomList<T> custList1, CustomList<T> custList2)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < custList1.count; i++)
            {           
              newList.Add(custList1[i]);
            }
            for (int i = 0; i < custList2.count; i++)
            {   
              newList.Add(custList2[i]);
            }
            return newList;
        }

        // Count Method
        public int Count()
        {

          
            return count;

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

  //  public interface IEnumberable
  //  {
  //  }
}
