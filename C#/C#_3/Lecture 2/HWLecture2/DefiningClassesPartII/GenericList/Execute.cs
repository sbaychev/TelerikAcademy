using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Execute
{
    public static void Main()
    {
        //testing bellow all of the defined in GenericList
        GenericList<int> listTesting = new GenericList<int>(1);
        listTesting.AddElement(3);
        listTesting.AddElement(2);
        listTesting.AddElement(-100);
        listTesting.AddElement(1);
        listTesting.AddElement(6);

        Console.WriteLine(listTesting);

        listTesting.RemoveElementAtIndex(1);

        Console.WriteLine(listTesting);

        listTesting.InsertElementAtIndex(0, 21);

        Console.WriteLine(listTesting);

        Console.WriteLine(listTesting.FindElementByValue(7));

        Console.WriteLine(listTesting.Max());
        Console.WriteLine(listTesting.Min());

        listTesting.ClearList();

        Console.WriteLine(listTesting);
    }
}
