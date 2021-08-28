namespace Tasks3Library
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

        public static int Task3(int a)
        {
            int step = 3;
            int count = 1;
            for (int i = 2; i < a;
                i += step,
                step += 2,
                count++) ;

            if (count * count < a)
            {
                return count;
            }
            else
            {
                return count - 1;
            }
        }

        public static int Task4(int a)
        {
            int b = a / 2;

            for (int i = b; i >= 1; i--)
            {
                if (a % i == 0)
                {
                    b = i;
                    break;
                }
            }

            return b;
        }
    }
}
