using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Board
    {
        /// <summary>
        /// Size of the board usually 8X8
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// Array for cells
        /// </summary>
        public Cell[,] theGrid { get; set; }



        public Board(int s)
        {
            Size = s;

            theGrid = new Cell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void MarkNextLegalMove(Cell currentCell, string chessPiece)
        {
            // Clear all pervious moves
            Cell nextMove = currentCell;

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;
                }
            }


            // find all legal moves and mark the cells as legals
            switch (chessPiece)
            {
                case "Knight":
                    if(IsSafeCell(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    break;

                case "King":
                    if (IsSafeCell(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber + 1, currentCell.ColumnNumber + 0))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber + 0, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber + 0, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber - 1, currentCell.ColumnNumber + 0))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                    if (IsSafeCell(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1))
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    break;

                case "Rook":
                    while (IsSafeCell(nextMove.RowNumber+1, nextMove.ColumnNumber))
                    {
                        nextMove = theGrid[nextMove.RowNumber + 1, nextMove.ColumnNumber];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber - 1, nextMove.ColumnNumber))
                    {
                        nextMove = theGrid[nextMove.RowNumber - 1, nextMove.ColumnNumber];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber, nextMove.ColumnNumber + 1))
                    {
                        nextMove = theGrid[nextMove.RowNumber, nextMove.ColumnNumber + 1];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber, nextMove.ColumnNumber - 1))
                    {
                        nextMove = theGrid[nextMove.RowNumber, nextMove.ColumnNumber - 1];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    break;

                case "Bishop":
                    while (IsSafeCell(nextMove.RowNumber + 1, nextMove.ColumnNumber + 1))
                    {
                        nextMove = theGrid[nextMove.RowNumber + 1, nextMove.ColumnNumber + 1];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber - 1, nextMove.ColumnNumber - 1))
                    {
                        nextMove = theGrid[nextMove.RowNumber - 1, nextMove.ColumnNumber - 1];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber - 1 , nextMove.ColumnNumber + 1))
                    {
                        nextMove = theGrid[nextMove.RowNumber - 1, nextMove.ColumnNumber + 1];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber + 1, nextMove.ColumnNumber - 1))
                    {
                        nextMove = theGrid[nextMove.RowNumber + 1, nextMove.ColumnNumber - 1];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    break;


                case "Queen":
                    while (IsSafeCell(nextMove.RowNumber + 1, nextMove.ColumnNumber + 1))
                    {
                        nextMove = theGrid[nextMove.RowNumber + 1, nextMove.ColumnNumber + 1];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber - 1, nextMove.ColumnNumber - 1))
                    {
                        nextMove = theGrid[nextMove.RowNumber - 1, nextMove.ColumnNumber - 1];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber - 1, nextMove.ColumnNumber + 1))
                    {
                        nextMove = theGrid[nextMove.RowNumber - 1, nextMove.ColumnNumber + 1];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber + 1, nextMove.ColumnNumber - 1))
                    {
                        nextMove = theGrid[nextMove.RowNumber + 1, nextMove.ColumnNumber - 1];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber + 1, nextMove.ColumnNumber))
                    {
                        nextMove = theGrid[nextMove.RowNumber + 1, nextMove.ColumnNumber];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber - 1, nextMove.ColumnNumber))
                    {
                        nextMove = theGrid[nextMove.RowNumber - 1, nextMove.ColumnNumber];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber, nextMove.ColumnNumber + 1))
                    {
                        nextMove = theGrid[nextMove.RowNumber, nextMove.ColumnNumber + 1];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    nextMove = currentCell;
                    while (IsSafeCell(nextMove.RowNumber, nextMove.ColumnNumber - 1))
                    {
                        nextMove = theGrid[nextMove.RowNumber, nextMove.ColumnNumber - 1];
                        theGrid[nextMove.RowNumber, nextMove.ColumnNumber].LegalNextMove = true;
                    }
                    break;

                default:
                    break;
            }
            theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
        }

        private bool IsSafeCell(int row, int column )
        {
            if (row < 0 || row >= Size )
            {
                return false;
            }

            if (column < 0 || column >= Size)
            {
                return false;
            }

            return true;
        }
    }
}
