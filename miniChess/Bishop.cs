using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace miniChess
{
    class Bishop : ChessPiece
    {
        public Bishop(String color)
        {
            this.color = color;
        }
         override public Bitmap GetPath()
         {
            if (this.color == "white")
            {
                return miniChess.Properties.Resources.WhiteBishop;
            }
            else if (this.color == "black")
            {
                return miniChess.Properties.Resources.BlackBishop;
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
            //Bishop moves diagonally up left, up right, down left, down right
            
            //up left
            for(int i = 1; ((x-i)>=0) && ((y-i)>=0); i++)
            {
                if(ChessBoard.GetChessPieceInSlot(x-i,y-i)!=null)
                {
                    if(ChessBoard.GetChessPieceInSlot(x - i, y - i).GetColor()!=this.color)
                    {
                        moveAbleSlot.Add(new Point(x - i, y - i));
                    }
                    break;
                }
                moveAbleSlot.Add(new Point(x - i, y - i));
            }

            //up right
            for(int i = 1; ((x+i)<8) && ((y-i)>=0); i++)
            {
                if (ChessBoard.GetChessPieceInSlot(x+i, y-i) != null)
                {
                    if (ChessBoard.GetChessPieceInSlot(x + i, y - i).GetColor() != this.color)
                    {
                        moveAbleSlot.Add(new Point(x + i, y - i));
                    }
                    break;
                }
                moveAbleSlot.Add(new Point(x + i, y - i));
            }
            //down left
            for (int i = 1; ((x - i) >=0) && ((y + i) < 8); i++)
            {
                if (ChessBoard.GetChessPieceInSlot(x-i,y+i) != null)
                {
                    if (ChessBoard.GetChessPieceInSlot(x - i, y + i).GetColor() != this.color)
                    {
                        moveAbleSlot.Add(new Point(x - i, y + i));
                    }
                    break;
                }
                moveAbleSlot.Add(new Point(x - i , y + i));
            }

            //down right
            for(int i = 1; ((x + i) < 8) && ((y + i) < 8); i++)
            {
                if (ChessBoard.GetChessPieceInSlot(x+i,y+i) != null)
                {
                    if (ChessBoard.GetChessPieceInSlot(x + i, y + i).GetColor() != this.color)
                    {
                        moveAbleSlot.Add(new Point(x + i, y + i));
                    }
                    break;
                }
                moveAbleSlot.Add(new Point(x + i, y + i));
            }

            return moveAbleSlot;
        }
    }
}
