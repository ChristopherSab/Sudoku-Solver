using SudokuSolverApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolverApplication.Workers
{
    class SudokuMapper
    {
        public SudokuMap Find(int givenRow, int givenCol)
        {
            SudokuMap sudokumap = new SudokuMap();
             
            if ((givenRow >= 0 && givenRow <=2) && (givenCol >= 0 && givenCol <= 2))
            {
                sudokumap.StartRow = 0;
                sudokumap.StartCol = 0;
            }

            else if ((givenRow >= 0 && givenRow <= 2) && (givenCol >= 3 && givenCol <= 5))
            {
                sudokumap.StartRow = 0;
                sudokumap.StartCol = 3;
            }
            else if ((givenRow >= 0 && givenRow <= 2) && (givenCol >= 6 && givenCol <= 8))
            {
                sudokumap.StartRow = 0;
                sudokumap.StartCol = 6;
            }
            else  if ((givenRow >= 3 && givenRow <= 5) && (givenCol >= 0 && givenCol <= 2))
            {
                sudokumap.StartRow = 3;
                sudokumap.StartCol = 0;
            }
            else if ((givenRow >= 3 && givenRow <= 5) && (givenCol >= 3 && givenCol <= 5))
            {
                sudokumap.StartRow = 3;
                sudokumap.StartCol = 3;
            }
            else if ((givenRow >= 3 && givenRow <= 5) && (givenCol >= 6 && givenCol <= 8))
            {
                sudokumap.StartRow = 3;
                sudokumap.StartCol = 6;
            }
            else if ((givenRow >= 6 && givenRow <= 8) && (givenCol >= 0 && givenCol <= 2))
            {
                sudokumap.StartRow = 6;
                sudokumap.StartCol = 0;
            }
            else if ((givenRow >= 6 && givenRow <= 8) && (givenCol >= 3 && givenCol <= 5))
            {
                sudokumap.StartRow = 6;
                sudokumap.StartCol = 3;
            }
            else if ((givenRow >= 6 && givenRow <= 8) && (givenCol >= 6 && givenCol <= 8))
            {
                sudokumap.StartRow = 6;
                sudokumap.StartCol = 6;
            }


            return sudokumap;
                
        }
    }
}
