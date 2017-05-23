namespace Project.Euler
{
    public static class Question0001SumOfMultiples3And5
    {

        public static int SumOfMultiples3And5(int n)
        {
            var sum = 0;
            for (int i = 3; i <= n; i++)
                if (i%3 == 0 || i%5 == 0) sum += i;
            return sum;
        }

    }
}
