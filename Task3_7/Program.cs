using System;
using Tasks3Library;

namespace Task3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(TasksHelper.Task7(a, b));
        }
    }
}
