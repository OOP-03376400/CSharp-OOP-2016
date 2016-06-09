namespace Homework
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            GSM myGSM = new GSM("One Plus", "X");
            myGSM.Battery = new Battery("non-removable", 2525, BatteryType.LiPo);
            Console.WriteLine(myGSM.ToString());

            Console.WriteLine(GSM.IPhone4s);
        }
    }
}
