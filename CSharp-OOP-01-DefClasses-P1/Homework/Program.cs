namespace Homework
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            GSM myGSM = new GSM("One Plus", "X");
            Console.WriteLine(myGSM.ToString());
            Console.WriteLine(GSM.IPhone4s);
        }
    }
}
