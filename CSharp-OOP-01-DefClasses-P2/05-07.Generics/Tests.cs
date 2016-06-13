namespace _05_07.Generics
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            GenericList<int> firstList = new GenericList<int>();
            Console.WriteLine(firstList);

            //testing Add
            firstList.Add(31);
            Console.WriteLine(firstList);

            //testing AddAtPosition
            firstList.AddAtPosition(52,0);
            Console.WriteLine(firstList);

            //testing Remove
            firstList.Remove(0);
            Console.WriteLine(firstList);

            //testing Clear
            firstList.Clear();
            Console.WriteLine(firstList);
        }
    }
}
