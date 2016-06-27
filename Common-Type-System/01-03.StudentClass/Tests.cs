namespace _01_03.StudentClass
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            Student nikola = new Student("Nikola", "Ivanov", "Nikolov", "13444",
                "Sofia", "0888888888", "test@abv.bg", 3,
                Specialty.CivilEngineering, Faculty.Civil, University.UACEG);
            Console.WriteLine(nikola);
        }
    }
}
