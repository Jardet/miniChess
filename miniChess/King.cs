
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace miniChess
{
    class King : ChessPiece
    {
        public King(String color)
        {
            this.color = color;
        }

        override public Bitmap GetPath()
        {
            if (this.color == "white")
            {
                return miniChess.Properties.Resources.WhiteKing;
            }
            else if (this.color == "black")
            {
                return miniChess.Properties.Resources.BlackKing;
            }
            else
            {
                Console.WriteLine("Error wrong chess piece color");
                return null;
            }
        }

        override public List<Point> GetMove(int x, int y)
        {
            List<Point> moveAbleSlot = new List<Point>();
            //King moves to adjacent slot
           
            if((x-1)>=0)
            {
                moveAbleSlot.Add(new Point(x - 1, y));

                if(y-1>=0)
                {
                    moveAbleSlot.Add(new Point(x - 1, y - 1));
                }
                if(y+1<8)
                {
                    moveAbleSlot.Add(new Point(x - 1, y + 1));
                }
            }
            if((x+1)<8)
            {
                moveAbleSlot.Add(new Point(x + 1, y));
                if (y - 1 >= 0)
                {
                    moveAbleSlot.Add(new Point(x + 1, y - 1));
                }
                if (y + 1 < 8)
                {
                    moveAbleSlot.Add(new Point(x + 1, y + 1));
                }
            }
            if((y-1)>=0)
            {
                moveAbleSlot.Add(new Point(x,y-1));
            }
            if((y+1)<8)
            {
                moveAbleSlot.Add(new Point(x, y + 1));
                
            }
            return moveAbleSlot;
        }
    }
}
