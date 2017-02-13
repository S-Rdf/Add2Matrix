using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add2Matrix
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            int[,] matrix1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] matrix2 = new int[,] { { 6, 5, 4 }, { 3, 2, 1 } };
            //Array sumMatrix = new int[2, 3];
            int[,] sumMatrix = new int[2, 3];
            int row = 2, col = 3;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write(sumMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
       
    }
}
