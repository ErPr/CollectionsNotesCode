using System;

namespace CollectionsNotesCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayInstantiation();
            JaggedArrays();
            MultidimensionalArrays());

            System.Threading.Thread.Sleep(10000);
        }

        public static void JaggedArrays()
        {
            Cell[][] sheet = new Cell[100][];    //array of cell arrays = sheet

            Console.WriteLine(sheet);

            sheet[0] = new Cell[10];

            Console.WriteLine(sheet);

            for (int rowIndex = 0; rowIndex < sheet.Length; rowIndex++)
            {
                sheet[rowIndex] = new Cell[10]; //create a row of 10 cells

                for (int colIndex = 0; colIndex < sheet[rowIndex].Length; colIndex++)
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

        public static Cell[,] MultidimensionalArrays()
        {
            Cell[,] sheet = new Cell[100, 10]; //single array or 1000 items, organized into dimensions one for rows and one for columns
            //sheet.length //1000
            //sheet[0,0]   //null

            for (int rowIndex = 0; rowIndex < sheet.GetLength(0); rowIndex++)
            {
                for(int colIndex = 0; colIndex < sheet.GetLength(1); colIndex++)
                {
                    sheet[rowIndex, colIndex] = new Cell();
                }
            }
            //sheet[2,3] //Cell
            int[,] matrix = new int[5, 5];
            //matrix[2,3] //0
            
            Cell[][][] sheet3D = new Cell[100][][]; //three dimensional array
            //needs three nested for loops to fill in
            int[,,] threeDimMatrix = new int[5, 5, 5];

            return sheet;
        }
    }
}
