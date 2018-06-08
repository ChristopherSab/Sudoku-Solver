using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolverApplication.Workers
{
    class SudokuFileReader
    {
        public int[,] ReadFile(string filename)
        {
            int[,] sudokuBoard = new int[9, 9];

            try
            {
                var SudokuBoardLines = File.ReadAllLines(filename);

                int row = 0;
                foreach(var sudokuBoardLine in SudokuBoardLines)
                {
                    string[] sudokuBoardElements = sudokuBoardLine.Split('|').Skip(1).Take(9).ToArray();

                    int col = 0;
                    foreach(var sudokuBoardElement in sudokuBoardElements)
                    {
                        sudokuBoard[row, col] = sudokuBoardElement.Equals(" ") ? 0 : Convert.ToInt16(sudokuBoardElement);
                        col++;
                    }

                    row++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something Went Wrong While Reading The File: " + ex.Message);
            }
            return sudokuBoard;
        }
    }
}
