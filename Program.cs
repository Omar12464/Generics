namespace Generics1
{
    internal class Program
    {
        public static void BubbleSort(int[] x)
        {
            int temp = 0;
            #region Q1
            if (x is not null)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    for (int j = 0; j < x.Length - i - 1; j++)
                    {
                        if (x[j] > x[j + 1])
                        {
                            temp = x[j];
                            x[j] = x[j + 1];
                            x[j + 1] = temp;
                        }
                    }

                }
            } 
            #endregion

        }
        static void Main(string[] args)
        {
            #region Q1
            //int[] x = { 1, 3, 2, 0 };
            //BubbleSort(x);
            //foreach (int xe in x) { Console.WriteLine(xe); } 
            #endregion
            #region Part 2
            #region q1
            Range<int> range = new Range<int>(2, 6);
            #endregion
            #region Q2
            //range.IsInRange(3);
            //Console.WriteLine($"3 is in range? {range.IsInRange(3)}");
            #endregion
            #region Q3
            //int x=range.Legth();
            //Console.WriteLine($"Length between Maximum and Minmum: {x}");
            #endregion
            #endregion

        }
    }
}
