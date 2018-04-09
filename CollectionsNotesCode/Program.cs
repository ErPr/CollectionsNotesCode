using System;

namespace CollectionsNotesCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayInstantiation();
            JaggedArrays();

        }

        public static void JaggedArrays()
        {
            Cell[][] sheet = new Cell[100][];    //array of cell arrays = sheet

            Console.WriteLine(sheet);

            sheet[0] = new Cell[10];

            Console.WriteLine(sheet);

            for(int rowIndex = 0; rowIndex < sheet.Length; rowIndex++)
            {
                sheet[rowIndex] = new Cell[10]; //create a row of 10 cells

                for(int colIndex = 0; colIndex < sheet[rowIndex].Length; colIndex++)
                {
                    sheet[rowIndex][colIndex] = new Cell();
                }
            }

            foreach (Cell[] row in sheet)
            {
                foreach (Cell Cell in row)
                {
                    System.Console.Write(Cell);
                }
            }
            System.Console.WriteLine();

            System.Threading.Thread.Sleep(10000);
        }

        private static void ArrayInstantiation()
        {
            int[] lockCombination = new int[3];
            Console.WriteLine(lockCombination);

            int[] lockCombination1 = new int[] { 10, 5, 32 };
            int[] lockCombination2 = new[] { 10, 5, 32 };
            int[] lockCombination3 = { 10, 5, 32 };

            int last = lockCombination3[2];
            Console.WriteLine(last);

            lockCombination3[2] = 20;
            Console.WriteLine(lockCombination3);

            Console.ReadLine();
        }
    }

    public static class MathHelpers
    {
        public static int[][] BuildMultiplicationTable(int maxFactor)
        {
            int[][] multiplicationTable = new int[maxFactor][];

            for (int rowIndex = 0; rowIndex <= maxFactor; rowIndex++)
            {
                multiplicationTable[rowIndex] = new int[maxFactor];

                for (int colIndex = 0; colIndex <= maxFactor; colIndex++)
                {
                    multiplicationTable[rowIndex][colIndex] = rowIndex * colIndex;
                }
            }
            return multiplicationTable;
        }
    }
}
