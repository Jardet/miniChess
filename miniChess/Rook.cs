using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace miniChess
{
    class Rook : ChessPiece
    {
        public Rook(String color)
        {
            this.color = color;
        }
        override public Bitmap GetPath()
        {
            if (this.color == "white")
            {
                return miniChess.Properties.Resources.WhiteRook;
            }
            else if (this.color == "black")
            {
                return miniChess.Properties.Resources.BlackRook;
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
            int count = 0;
            //move up
            for(int i = 1;(y-i)>=0; i++,count++)
            {
                if (ChessBoard.GetChessPieceInSlot(x, y - i) != null)
                {
                    if (ChessBoard.GetChessPieceInSlot(x, y - i).GetColor() != this.color)
                    {
                        moveAbleSlot.Add(new Point(x, y - i));
                    }
                    break;
                }
                moveAbleSlot.Add(new Point(x,y-i));
            }
            //move down
            for(int i=1;(y+i<8);i++,count++)
            {
                if (ChessBoard.GetChessPieceInSlot(x, y + i) != null)
                {
                    if (ChessBoard.GetChessPieceInSlot(x, y + i).GetColor() != this.color)
                    {
                        moveAbleSlot.Add(new Point(x, y + i));
                    }
                    break;
                }
                moveAbleSlot.Add(new Point(x, y + i));
            }
            //move left
            for(int i = 1;(x-i)>=0;i++,count++)
            {
                if (ChessBoard.GetChessPieceInSlot(x - i, y) != null)
                {
                    if (ChessBoard.GetChessPieceInSlot(x - i, y).GetColor() != this.color)
                    {
                        moveAbleSlot.Add(new Point(x - i, y));
                    }
                    break;
                }
                moveAbleSlot.Add(new Point(x - i,y));
            }
            //move right
            for(int i = 1;(x+i)<8;i++,count++)
            {
                if (ChessBoard.GetChessPieceInSlot(x + i, y) != null)
                {
                    if (ChessBoard.GetChessPieceInSlot(x + i, y).GetColor() != this.color)
                    {
                        moveAbleSlot.Add(new Point(x + i, y));
                    }
                    break;
                }
                moveAbleSlot.Add(new Point(x + i,y));
            }

            return moveAbleSlot;
        }
    }
}
