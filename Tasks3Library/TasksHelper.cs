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
    }
}
