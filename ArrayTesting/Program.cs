using System;

namespace ArrayTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            object[] cells = new object[5];

            cells[1] = "Carol";
            cells[2] = "Daniel";
            cells[3] = "Harry";
            cells[4] = "Ben";


            for (int i = 0; i < cells.GetLength(0); i++)
            {

                Console.WriteLine(cells[i]?.ToString());

               
            }


        }
    }
}
