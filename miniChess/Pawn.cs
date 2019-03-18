using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace miniChess
{
    class Pawn : ChessPiece
    {
        public Pawn(String color)
        {
            this.color = color;
        }

        override public Bitmap GetPath()
        {
            if (this.color == "white")
            {
                return miniChess.Properties.Resources.WhitePawn;
            }
            else if (this.color == "black")
            {
                return miniChess.Properties.Resources.BlackPawn;
            }
            else
            {
                Console.WriteLine("Error wrong chess piece color");
                return null;
            }
        }
        //operation to calculate move up down left right position
        override public List<Point> GetMove(int x, int y)
        {
            List<Point> moveAbleSlot = new List<Point>();
            if(this.color == "black")
            {
                if(y-1>=0)
                {
                    moveAbleSlot.Add(new Point(x,y-1));
                    if(x-1 >= 0)
                    {
                        moveAbleSlot.Add(new Point(x - 1, y - 1));
                    }
                    if(x+1<8)
                    {
                        moveAbleSlot.Add(new Point(x + 1, y - 1));
                    }
                }
            }
            else if(this.color =="white")
            {
                if (y + 1 < 8)
                {
                    moveAbleSlot.Add(new Point(x, y + 1));
                    if (x - 1 >= 0)
                    {
                        moveAbleSlot.Add(new Point(x - 1, y + 1));
                    }
                    if (x + 1 < 8)
                    {
                        moveAbleSlot.Add(new Point(x + 1, y + 1));
                    }
                }
            }

            return moveAbleSlot;
        }
    }
}
