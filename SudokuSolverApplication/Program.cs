using SudokuSolverApplication.Strategies;
using SudokuSolverApplication.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolverApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SudokuMapper sudokuMapper = new SudokuMapper();
                SudokuBoardStateManager sudokuBoardStateManager = new SudokuBoardStateManager();
                SudokuSolverEngine sudokuSolverEngine = new SudokuSolverEngine(sudokuBoardStateManager, sudokuMapper);
                SudokuFileReader sudokuFileReader = new SudokuFileReader();
                SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();

                Console.WriteLine("Please Enter The File Name Containing The Sudoku Puzzle:");
                var filename = Console.ReadLine();

                var sudokuBoard = sudokuFileReader.ReadFile(filename);
                sudokuBoardDisplayer.Display("Initial State", sudokuBoard);

                bool IsSudokuSolved = sudokuSolverEngine.Solve(sudokuBoard);
                sudokuBoardDisplayer.Display("Final State", sudokuBoard);

                Console.WriteLine(IsSudokuSolved
                    ? "You Have Successfully Solved This Sudoku Puzzle!"
                    : "Unfortunately, current algorithm(s) were not enough to solve the current Sudoku Puzzle!");

            }
            catch (Exception ex)
            {
                //In Real World I Would Log This Message In A DataBase
                Console.WriteLine("{0} : {1}", "Sudoku Puzzle Cannot Be Solved Because There Was An Error:", ex.Message);
            }
        }
    }
}
