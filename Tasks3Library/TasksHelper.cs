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

        public static int Task5(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static int Task6(int n)
        {
            int a = 1;
            int b = 1;
            for (int i = 2; i < n; i += 2)
            {
                a += b;
                b += a;
            }

            return n % 2 == 1 ? a : b;
        }

        public static int Task7(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        public static int Task8(int y)
        {
            int left = 0;
            int right = y;
            int middle = right;

            while (y != middle * middle * middle)
            {
                if (middle * middle * middle > y)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
                middle = (left + right) / 2;
            }
            return middle;
        }

        public static int Task9(int a)
        {
            int b = a % 10;
            int n = 0;

            while (a != 0)
            {
                if (b % 2 == 1)
                {
                    n++;
                }
                a = a / 10;
                b = a % 10;
            }
            return n;
        }

        public static int Task10(int a)
        {
            int result = 0;

            while (a != 0)
            {
                result *= 10;
                result += a % 10;
                a /= 10;
            }

            return result;
        }

        public static int[] Task11(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; ++i)
            {
                (int chet, int nechet) = GetNumberParts(i);

                if (chet > nechet)
                {
                    ++count;
                }
            }

            int[] arr = new int[count];
            for (int num = 1, i = 0; num <= n; ++num)
            {
                (int chet, int nechet) = GetNumberParts(num);

                if (chet > nechet)
                {
                    arr[i++] = num;
                }
            }

            return arr;
        }

        private static (int chet, int nechet) GetNumberParts(int num)
        {
            int chet = 0;
            int nechet = 0;
            while (num != 0)
            {
                int b = num % 10;
                if (b % 2 == 0)
                {
                    chet += b;
                }
                else
                {
                    nechet += b;
                }

                num /= 10;
            }

            return (chet, nechet);
        }
    }
}