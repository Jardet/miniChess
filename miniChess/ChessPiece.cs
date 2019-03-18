using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

/**     
 *      Abstract class use to make chessPieces subclass
 *      Made by Jarudet Wichit 11 Feb 2019
 *      
 */
namespace miniChess
{
    abstract class ChessPiece
    {
        // piece color
        protected String color;
       
        // get string of color black or white
        public String GetColor()
        {
            return color;
        }

        /** image path of each chess piece */
        abstract public Bitmap GetPath();

        //GetMove method calculate point chess piece can move to and return it as and array of int
        abstract public List<Point> GetMove(int x, int y);

    }
}
