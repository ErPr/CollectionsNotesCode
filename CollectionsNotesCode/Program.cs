using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNotesCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lockCombination = new int[3];
            Console.WriteLine(lockCombination);

            int[] lockCombination1 = new int[] { 10, 5, 32 };
            int[] lockCombination2 = new[] { 10, 5, 32 };
            int[] lockCombination3 = { 10, 5, 32 };

            int last = lockCombination3[2];
            Console.WriteLine(last);

            lockCombination3[2] = 20;
        }
    }
}
