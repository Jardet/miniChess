using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace miniChess
{
    class Knight : ChessPiece
    {
        public Knight(String color)
        {
            this.color = color;
        }

        override public Bitmap GetPath()
        {
            if (this.color == "white")
            {
                return miniChess.Properties.Resources.WhiteKnight;
            }
            else if (this.color == "black")
            {
                return miniChess.Properties.Resources.BlackKnight;
            }
            else
            {
                Console.WriteLine("Error wrong chess piece color");
                return null;
            }
        }

        override public List<Point> GetMove(int x,int y)
        {
            List<Point> moveAbleSlot = new List<Point>();
            if( ((x-1)>=0) && ((y-2)>=0) ) // upper left
            {
                moveAbleSlot.Add(new Point(x - 1, y - 2));
            }
            if (((x - 2) >= 0) && ((y - 1) >= 0))
            {
                moveAbleSlot.Add(new Point(x - 2, y - 1));
            }
            if (((x + 1) < 8 ) && ((y + 2) < 8))// lower right
            {
                moveAbleSlot.Add(new Point(x + 1, y + 2));
            }
            if (((x + 2) < 8) && ((y + 1) < 8))
            {
                moveAbleSlot.Add(new Point(x + 2, y + 1));
            }
            if (((x - 1) >= 0) && ((y + 2) < 8))// lower left
            {
                moveAbleSlot.Add(new Point(x - 1, y + 2));
            }
            if (((x - 2) >= 0) && ((y + 1) < 8))
            {
                moveAbleSlot.Add(new Point(x - 2, y + 1));
            }
            if(((x + 2) < 8) && ((y - 1) >= 0))// upper right
            {
                moveAbleSlot.Add(new Point(x + 2, y - 1));
            }
            if (((x + 1) < 8) && ((y - 2) >= 0))
            {
                moveAbleSlot.Add(new Point(x + 1, y - 2));
            }
            return moveAbleSlot;
        }
    }
}
