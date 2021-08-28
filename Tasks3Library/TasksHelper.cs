﻿namespace Tasks3Library
{
    public class TasksHelper
    {
        public static int Pow(int a, int b)
        {
            int s = a;
            if (b == 0)
            {
                s = 1;
            }

            for (int i = 1; i < b; i++)
            {
                s = s * a;
            }

            return s;
        }

        public static int[] Task2(int a)
        {
            int count = 0;
            for (int i = a; i <= 1000; i += a)
            {
                count++;
            }
            int[] array = new int[count];
            for (int currentNumber = a, i = 0; currentNumber <= 1000; currentNumber += a, ++i)
            {
                array[i] = currentNumber;
            }

            return array;
        }
    }
}
