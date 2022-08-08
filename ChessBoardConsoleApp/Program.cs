using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardConsoleApp
{
    internal class Program
    {
        static Board myBoard = new Board(8);
        
        static void Main(string[] args)
        {

            // show the empty chess board
            printBoard(myBoard);


            Cell currentCell;
            // ask the user for an coordinate
            try
            {
                currentCell = setCurrentCell();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input, cell set to 3, 3");
                 currentCell = myBoard.theGrid[3, 3];
                
            }
            currentCell.CurrentlyOccupied = true;

            // calculate all legal moves for that piece
            Console.WriteLine("Please input a Piece: King, Knight, Bishop, Queen");
            string piece = Console.ReadLine();

            myBoard.MarkNextLegalMove(currentCell, piece);

            // print the chess board. Using an x to occupied square. use a + for legal move and use . for emtpy cell
            printBoard(myBoard);
            Console.ReadLine();
        }

        private static Cell setCurrentCell()
        {
            // get x and y coord from the user and return a cell location
            int currentRow;
            int currentColumn;
            try
            {
                Console.WriteLine("Enter Row number");
                currentRow = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input, Row set to 3");
                currentRow = 3;
            }


            try
            {
                Console.WriteLine("Enter Column number");
                currentColumn = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input, Column set to 3");
                currentColumn = 3;
            }
           

            return myBoard.theGrid[currentRow, currentColumn];
        }

        private static void printBoard(Board myBoard)
        {
            // print the chess board in console log
            for (int i = 0; i < myBoard.Size; i++)
            {
               
                Console.WriteLine("+---+---+---+---+---+---+---+---+");
                Console.Write("|");

                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    if (c.CurrentlyOccupied == true)
                    {
                        Console.Write(" X ");
                    }
                    else if (c.LegalNextMove == true)
                    {
                        Console.Write(" + ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                    Console.Write("|");

                    if (j == myBoard.Size - 1)
                    {
                        Console.WriteLine();
                    }
                }

            }
            Console.WriteLine("+---+---+---+---+---+---+---+---+");

            Console.WriteLine("==================================================================");
        }

    }
}
