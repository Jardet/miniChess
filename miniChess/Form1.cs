using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace miniChess
{
    public partial class chessForm : Form
    {
        public chessForm()
        {
            InitializeComponent();
            ChessBoard.setAllButton(InitializeChessBoardInfo());
            ChessBoard.ResetChessPiece();
            ChessBoard.ResetAllBackColor();
            ChessBoard.ClearButtonImage();
            ChessBoard.UpdateButtonImage();
        }

        private Button[,] InitializeChessBoardInfo()
        {
            Button[,] tempButton = new Button[8,8];

            tempButton[0, 0] = slot0;
            tempButton[1, 0] = slot1;
            tempButton[2, 0] = slot2;
            tempButton[3, 0] = slot3;
            tempButton[4, 0] = slot4;
            tempButton[5, 0] = slot5;
            tempButton[6, 0] = slot6;
            tempButton[7, 0] = slot7;
            tempButton[0, 1] = slot8;
            tempButton[1, 1] = slot9;
            tempButton[2, 1] = slot10;
            tempButton[3, 1] = slot11;
            tempButton[4, 1] = slot12;
            tempButton[5, 1] = slot13;
            tempButton[6, 1] = slot14;
            tempButton[7, 1] = slot15;
            tempButton[0, 2] = slot16;
            tempButton[1, 2] = slot17;
            tempButton[2, 2] = slot18;
            tempButton[3, 2] = slot19;
            tempButton[4, 2] = slot20;
            tempButton[5, 2] = slot21;
            tempButton[6, 2] = slot22;
            tempButton[7, 2] = slot23;
            tempButton[0, 3] = slot24;
            tempButton[1, 3] = slot25;
            tempButton[2, 3] = slot26;
            tempButton[3, 3] = slot27;
            tempButton[4, 3] = slot28;
            tempButton[5, 3] = slot29;
            tempButton[6, 3] = slot30;
            tempButton[7, 3] = slot31;
            tempButton[0, 4] = slot32;
            tempButton[1, 4] = slot33;
            tempButton[2, 4] = slot34;
            tempButton[3, 4] = slot35;
            tempButton[4, 4] = slot36;
            tempButton[5, 4] = slot37;
            tempButton[6, 4] = slot38;
            tempButton[7, 4] = slot39;
            tempButton[0, 5] = slot40;
            tempButton[1, 5] = slot41;
            tempButton[2, 5] = slot42;
            tempButton[3, 5] = slot43;
            tempButton[4, 5] = slot44;
            tempButton[5, 5] = slot45;
            tempButton[6, 5] = slot46;
            tempButton[7, 5] = slot47;
            tempButton[0, 6] = slot48;
            tempButton[1, 6] = slot49;
            tempButton[2, 6] = slot50;
            tempButton[3, 6] = slot51;
            tempButton[4, 6] = slot52;
            tempButton[5, 6] = slot53;
            tempButton[6, 6] = slot54;
            tempButton[7, 6] = slot55;
            tempButton[0, 7] = slot56;
            tempButton[1, 7] = slot57;
            tempButton[2, 7] = slot58;
            tempButton[3, 7] = slot59;
            tempButton[4, 7] = slot60;
            tempButton[5, 7] = slot61;
            tempButton[6, 7] = slot62;
            tempButton[7, 7] = slot63;

            return tempButton;
        }
             
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ChessBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slot24_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(0,3);
        }

        private void slot48_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(0,6);
        }

        private void slot51_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(3,6);
        }

        private void slot62_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(6,7);
        }

        private void slot52_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(4,6);
        }

        private void slot12_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(4,1);
        }
        //editing start here need to set x y for each button
        private void slot0_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(0,0);
        }

        private void slot1_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(1,0);
        }

        private void slot2_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(2,0);
        }

        private void slot3_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(3,0);
        }

        private void slot4_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(4,0);
        }

        private void slot5_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(5,0);
        }

        private void slot6_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(6,0);
        }

        private void slot7_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(7,0);
        }

        private void slot8_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(0,1);
        }

        private void slot9_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(1,1);
        }

        private void slot10_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(2,1);
        }

        private void slot11_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(3,1);
        }

        private void slot12_Click_1(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(4,1);
        }

        private void slot13_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(5,1);
        }

        private void slot14_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(6,1);
        }

        private void slot15_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(7,1);
        }

        private void slot16_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(0, 2);
        }

        private void slot17_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(1,2);
        }

        private void slot18_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(2,2);
        }

        private void slot19_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(3,2);
        }

        private void slot20_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(4,2);
        }

        private void slot21_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(5,2);
        }

        private void slot22_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(6,2);
        }

        private void slot23_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(7,2);
        }

        private void slot25_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(1,3);
        }

        private void slot31_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(7,3);
        }

        private void slot26_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(2,3);
        }

        private void slot27_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(3,3);
        }

        private void slot28_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(4,3);
        }

        private void slot29_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(5,3);
        }

        private void slot30_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(6,3);
        }

        private void slot32_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(0,4);
        }

        private void slot33_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(1,4);
        }

        private void slot34_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(2,4);
        }

        private void slot35_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(3,4);
        }

        private void slot36_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(4,4);
        }

        private void slot37_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(5,4);
        }

        private void slot38_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(6,4);
        }

        private void slot39_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(7,4);
        }

        private void slot40_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(0,5);
        }

        private void slot41_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(1,5);
        }

        private void slot42_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(2,5);
        }

        private void slot43_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(3,5);
        }

        private void slot44_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(4,5);
        }

        private void slot45_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(5,5);
        }

        private void slot46_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(6,5);
        }

        private void slot47_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(7,5);
        }

        private void slot49_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(1,6);
        }

        private void slot50_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(2,6);
        }

        private void slot53_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(5,6);
        }

        private void slot54_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(6,6);
        }

        private void slot55_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(7,6);
        }

        private void slot56_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(0,7);
        }

        private void slot57_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(1,7);
        }

        private void slot58_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(2,7);
        }

        private void slot59_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(3,7);
        }

        private void slot60_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(4,7);
        }

        private void slot61_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(5,7);
        }

        private void slot63_Click(object sender, EventArgs e)
        {
            ChessBoard.buttonClicked(7,7);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChessBoard.ResetChessPiece();
            ChessBoard.ResetAllBackColor();
            ChessBoard.ClearButtonImage();
            ChessBoard.UpdateButtonImage();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
