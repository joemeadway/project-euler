using System;

namespace ProjectEuler
{
    public class Problem6
    {
        public int SumOfSquares(int start, int end)
        {
            int x = 0;
            for (int i = start; i <= end; i++)
            {
                x = x + (i * i);
            }
            return x;
        }

        public int SquareOfSum(int start, int end)
        {
            int x = 0;
            for (int i = start; i <= end; i++)
            {
                x = x + i;
            }
            return x * x;

        }
        
    }
}