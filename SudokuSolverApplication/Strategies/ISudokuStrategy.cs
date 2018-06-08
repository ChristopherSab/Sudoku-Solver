using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolverApplication.Strategies
{
    interface ISudokuStrategy
    {
        int[,] Solve(int[,] sudokuBoard);
    }
}
