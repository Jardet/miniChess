using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

/*
 *  ChessBoard class act as an centralize controller of of mini chess game 
 *  ChessBoard class keep every Button in Table of x and y
 *  ChessPieceInSlot and buttonSlot are paired up in the same x and y
 *  
 *  Created By jarudet Wichit, 16 Mar 2019
 *  
 *  */
namespace miniChess
{
    static class ChessBoard
    {

        private static ChessPiece[,] chessPieceInSlot = new ChessPiece[8, 8]; // keep ChessPiece object 

        private static Button[,] buttonSlot; // to keep Button Object

        private static int clickedX = 88; //x index of last clicked button

        private static int clickedY = 88; //y index of last clicked button

        public static void setAllButton(Button[,] buttonSlot)
        {
            ChessBoard.buttonSlot = buttonSlot;
        }

        // set all back color of every button back to ControlDarkDark
        public static void ResetAllBackColor()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            ChessBoard.buttonSlot[i, j].BackColor = Color.Gray;
                        }
                        else
                        {
                            ChessBoard.buttonSlot[i, j].BackColor = Color.White;
                        }
                    }
                    else
                    {
                        if (j % 2 == 1)
                        {
                            ChessBoard.buttonSlot[i, j].BackColor = Color.Gray;
                        }
                        else
                        {
                            ChessBoard.buttonSlot[i, j].BackColor = Color.White;
                        }
                    }
                }
            }
        }

        // set all button's image to null
        public static void ClearButtonImage()
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    ChessBoard.buttonSlot[i,j].BackgroundImage = null;
                }
            }
        }

        // set all button's image according to chess piece in it slot
        public static void UpdateButtonImage()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(ChessBoard.chessPieceInSlot[i,j] != null)
                    {
                        ChessBoard.buttonSlot[i, j].BackgroundImage = ChessBoard.chessPieceInSlot[i, j].GetPath();
                    }
                    
                }
            }
        }

        // update moveable slot BackColor to ControlDarkDark
        private static void UpdateMpveAbleSlot(int x, int y)
        {
            //Color.DimGray;
            //Color.Blue;
            List<Point> moveAbleSlot = ChessBoard.chessPieceInSlot[x, y].GetMove(x,y);
            int length = moveAbleSlot.Count;
            int x2, y2;
            for(int i = 0; i < length; i++)
            {
                x2 = moveAbleSlot[i].X;
                y2 = moveAbleSlot[i].Y;
                Console.WriteLine(x2+" "+y2);
                if(chessPieceInSlot[x2,y2]!=null)
                {
                    if(chessPieceInSlot[x, y].GetColor() != chessPieceInSlot[x2,y2].GetColor())
                    {
                        ChessBoard.buttonSlot[x2,y2].BackColor = Color.Blue;
                    }
                }
                else
                {
                    ChessBoard.buttonSlot[x2,y2].BackColor = Color.Blue;
                }
                
                
            }
            
        }

        // set all ChessPiece in slot to the pattern when you first start chess game
        public static void ResetChessPiece()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 2; j < 6; j++)
                {
                    ChessBoard.chessPieceInSlot[i, j] = null;
                }
            }
            ChessPiece newPiece;
            newPiece = new Rook("white");
            ChessBoard.chessPieceInSlot[0, 0] = newPiece;
            newPiece = new Knight("white");
            ChessBoard.chessPieceInSlot[1, 0] = newPiece;
            newPiece = new Bishop("white");
            ChessBoard.chessPieceInSlot[2, 0] = newPiece;
            newPiece = new Queen("white");
            ChessBoard.chessPieceInSlot[3, 0] = newPiece;
            newPiece = new King("white");
            ChessBoard.chessPieceInSlot[4, 0] = newPiece;
            newPiece = new Bishop("white");
            ChessBoard.chessPieceInSlot[5, 0] = newPiece;
            newPiece = new Knight("white");
            ChessBoard.chessPieceInSlot[6, 0] = newPiece;
            newPiece = new Rook("white");
            ChessBoard.chessPieceInSlot[7, 0] = newPiece;

            newPiece = new Rook("black");
            ChessBoard.chessPieceInSlot[0, 7] = newPiece;
            newPiece = new Knight("black");
            ChessBoard.chessPieceInSlot[1, 7] = newPiece;
            newPiece = new Bishop("black");
            ChessBoard.chessPieceInSlot[2, 7] = newPiece;
            newPiece = new Queen("black");
            ChessBoard.chessPieceInSlot[3, 7] = newPiece;
            newPiece = new King("black");
            ChessBoard.chessPieceInSlot[4, 7] = newPiece;
            newPiece = new Bishop("black");
            ChessBoard.chessPieceInSlot[5, 7] = newPiece;
            newPiece = new Knight("black");
            ChessBoard.chessPieceInSlot[6, 7] = newPiece;
            newPiece = new Rook("black");
            ChessBoard.chessPieceInSlot[7, 7] = newPiece;
            
            for (int i = 0; i < 8; i++)
            {
                newPiece = new Pawn("white");
                ChessBoard.chessPieceInSlot[i, 1] = newPiece;
                newPiece = new Pawn("black");
                ChessBoard.chessPieceInSlot[i, 6] = newPiece;

            }
        }

        public static Button GetButton(int x, int y)
        {
            return ChessBoard.buttonSlot[x,y];
        }

        public static ChessPiece GetChessPieceInSlot(int x,int y)
        {
            return ChessBoard.chessPieceInSlot[x, y]; 
        }

        //set move chess piece to certain slot
        private static void SetChessPieceInButton(int oldX, int oldY,int x,int y,ChessPiece chessPiece)
        {
            ChessBoard.chessPieceInSlot[x, y] = chessPiece;
            ChessBoard.chessPieceInSlot[oldX, oldY] = null;
            ClearButtonImage();
            UpdateButtonImage();
        }

        public static void buttonClicked(int x, int y)
        {
            if ((x == clickedX) && (y == clickedY)) // case cancel button clicked
            {
                clickedX = 88;
                clickedY = 88;
                ResetAllBackColor();
            }
            else if (chessPieceInSlot[x, y] != null && (buttonSlot[x, y].BackColor != Color.Blue)) // case new button clicked
            {
                clickedX = x;
                clickedY = y;
                ResetAllBackColor();
                //System.Threading.Thread.Sleep(5000);
                if (chessPieceInSlot[x, y] != null)
                {
                    UpdateMpveAbleSlot(x, y);
                }
            }
            else if (ChessBoard.buttonSlot[x, y].BackColor == Color.Blue) // case button is already clicked
            {

                ResetAllBackColor();
                chessPieceInSlot[x, y] = chessPieceInSlot[clickedX, clickedY];
                chessPieceInSlot[clickedX, clickedY] = null;
                ClearButtonImage();
                UpdateButtonImage();
            }

        }

    }
}
