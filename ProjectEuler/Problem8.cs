using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem8
    {
        private int[] _searchArray;

        public Problem8(int[] searchArray)
        {
            this._searchArray = searchArray;
        }

        public long ArrayProduct(int lengthToSearchFor)
        {
            long answer = 0, working = 0, runningAns = 0;
            List<int> checkingArray = new List<int>(_searchArray.Take(lengthToSearchFor));
            answer = ProductArray(checkingArray);
            runningAns = answer;
            for (int i = lengthToSearchFor; i < _searchArray.Length; i++)
            {
                working = checkingArray[0];
                checkingArray.RemoveAt(0);
                checkingArray.Add(_searchArray[i]);
                runningAns = ProductArray(checkingArray);

                if(runningAns >= answer)
                {
                    answer = runningAns;
                }
            }

            return answer;
        }

        private long ProductArray(List<int> array)
        {
            long ans = 1;
            foreach (var i in array)
            {
                ans *= i;
            }
            return ans;
        }
    }
}
