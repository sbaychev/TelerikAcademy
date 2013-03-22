using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the elements of the list 
//in an array with fixed capacity which is given as parameter in the class constructor. Implement methods for adding element, 
//accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element 
//by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.
public class GenericList<T> where T : IComparable
{
    private const int capacity = 10;
    private T[] list;
    private int position;

    public GenericList() : this(capacity) {  }
    public GenericList(int cap)
    {
        this.list = new T[cap];
    }
    public T this[int index]
    {
        get
        {
            return this.list[index];
        }
        set
        {
            this.list[index] = value;
        }
    }
    //7. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
    //You may need to add a generic constraints for the type T.

    public T Max()
    {
        dynamic maxElement = int.MinValue;
        for (int i = 0; i < this.list.Length; i++)
        {
            if (this.list[i] > maxElement)
            {
                maxElement = this.list[i];
            }
        }
        return maxElement;
    }
    public T Min()
    {
        dynamic minElement = int.MaxValue;
        for (int i = 0; i < this.list.Length; i++)
        {
            if (this.list[i] < minElement)
            {
                minElement = this.list[i];
            }
        }
        return minElement;
    }
    public void AddElement(T element)
    {
        if (this.position >= this.list.Length)
        {
            //6. Implement auto-grow functionality: when the internal array is full, 
            //create a new array of double size and move all elements to it.

            T[] aList = new T[this.list.Length * 2];
            for (int i = 0; i < this.list.Length; i++)
            {
                aList[i] = this.list[i];
            }

            this.position++;
            aList[this.list.Length] = element;
            this.list = aList;
        }
        else
        {
            this.list[this.position] = element;
            this.position++;
        }
    }

    public void RemoveElementAtIndex(int index)
    {
        if (index < this.list.Length)
        {
            T[] aList = new T[this.list.Length - 1];
            bool beforeRemoval = true;
            for (int i = 0; i < this.list.Length - 1; i++)
            {
                if (i == index)
                {
                    beforeRemoval = false;
                }
                if (beforeRemoval)
                {
                    aList[i] = this.list[i];
                }
                else
                {
                    aList[i] = this.list[i + 1];
                }
            }
            this.list = aList;
        }
        else
        {
            Console.WriteLine("Out of the array");
        }
    }
    public void InsertElementAtIndex(int index, T element)
    {
        if (index < this.list.Length)
        {
            T[] aList = new T[this.list.Length + 1];
            bool beforeRemoval = true;

            for (int i = 0; i < this.list.Length + 1; i++)
            {
                if (i == index)
                {
                    beforeRemoval = false;
                    aList[i] = element;
                    continue;
                }
                if (beforeRemoval)
                {
                    aList[i] = this.list[i];
                }
                else
                {
                    aList[i] = this.list[i - 1];
                }
            }
            this.list = aList;
        }
        else
        {
            Console.WriteLine("Out of the array");
        }
    }
    public int Length()
    {
        return this.list.Length;
    }
    public void ClearList()
    {
        this.list = new T[1];
    }
    public int FindElementByValue(T value)
    {
        int indexFound = -1; //-1 for false/ not found

        for (int i = 0; i < this.list.Length; i++)
        {
            if (this.list[i].Equals(value))
            {
                indexFound = i;
                break;
            }
        }
        return indexFound;
    }
    public override string ToString()
    {
        StringBuilder endData = new StringBuilder();
        foreach (var item in this.list)
        {
            endData.AppendFormat("{0} ", item);
        }
        return endData.ToString().Trim();
    }
}