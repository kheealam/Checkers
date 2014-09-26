using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.BackgroundImage = CheckerPiece.Image_Red;
            button2.BackgroundImage = CheckerPiece.Image_Red;
            button3.BackgroundImage = CheckerPiece.Image_Red;
            button4.BackgroundImage = CheckerPiece.Image_Red;
            button5.BackgroundImage = CheckerPiece.Image_Red;
            button6.BackgroundImage = CheckerPiece.Image_Red;
            button7.BackgroundImage = CheckerPiece.Image_Red;
            button8.BackgroundImage = CheckerPiece.Image_Red;
            button9.BackgroundImage = CheckerPiece.Image_Red;
            button10.BackgroundImage = CheckerPiece.Image_Red;
            button11.BackgroundImage = CheckerPiece.Image_Red;
            button12.BackgroundImage = CheckerPiece.Image_Red;
            button21.BackgroundImage = CheckerPiece.Image_Black;
            button22.BackgroundImage = CheckerPiece.Image_Black;
            button23.BackgroundImage = CheckerPiece.Image_Black;
            button24.BackgroundImage = CheckerPiece.Image_Black;
            button25.BackgroundImage = CheckerPiece.Image_Black;
            button26.BackgroundImage = CheckerPiece.Image_Black;
            button27.BackgroundImage = CheckerPiece.Image_Black;
            button28.BackgroundImage = CheckerPiece.Image_Black;
            button29.BackgroundImage = CheckerPiece.Image_Black;
            button30.BackgroundImage = CheckerPiece.Image_Black;
            button31.BackgroundImage = CheckerPiece.Image_Black;
            button32.BackgroundImage = CheckerPiece.Image_Black;

            
        }
        bool FClick = true;
        bool SCLick = false;
        bool isEmpty;
        bool isOur;
        Button gloBut;
        CheckerPiece piece1 = new CheckerPiece();
        private void button1_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11,button12, button13, button14, button15,button16,button17,button18,button19,button20,button21,button22,button23,button24,button25,button26,button27,button28,button29,button30,button31,button32 };
            Button locBut = button1;
            isEmpty = piece1.IsEmpty(button1);
            isOur = piece1.IsOur(button1);
            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button1;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button2;
            isEmpty = piece1.IsEmpty(button2);
            isOur = piece1.IsOur(button2);
            if (isEmpty == false && isOur == true )
            {
                FClick = false;
                SCLick = true;
                gloBut = button2;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button3;
            isEmpty = piece1.IsEmpty(button3);
            isOur = piece1.IsOur(button3);
            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button3;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button4;
            isEmpty = piece1.IsEmpty(button4);
            isOur = piece1.IsOur(button4);
            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button4;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button5;
            CheckerPiece piece1 = new CheckerPiece();
            isEmpty = piece1.IsEmpty(button5);
            isOur = piece1.IsOur(button5);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button5;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button6;
            CheckerPiece piece1 = new CheckerPiece();
            isEmpty = piece1.IsEmpty(button6);
            isOur = piece1.IsOur(button6);

            if (isEmpty == false && isOur == true)
            {

                FClick = false;
                SCLick = true;
                gloBut = button6;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button7;
            CheckerPiece piece1 = new CheckerPiece();
            isEmpty = piece1.IsEmpty(button7);
            isOur = piece1.IsOur(button7);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button7;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button8;
            isEmpty = piece1.IsEmpty(button8);
            isOur = piece1.IsOur(button8);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button8;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button9;
            isEmpty = piece1.IsEmpty(button9);
            isOur = piece1.IsOur(button9);
            
            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button9;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button10;
            isEmpty = piece1.IsEmpty(button10);
            isOur = piece1.IsOur(button10);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button10;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button11;
            isEmpty = piece1.IsEmpty(button11);
            isOur = piece1.IsOur(button11);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button11;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {

                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button12;
            isEmpty = piece1.IsEmpty(button12);
            isOur = piece1.IsOur(button12);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button12;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button13;

            isEmpty = piece1.IsEmpty(button13);
            isOur = piece1.IsOur(button13);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button13;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button14;

            isEmpty = piece1.IsEmpty(button14);
            isOur = piece1.IsOur(button14);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button14;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11,button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button15;

            isEmpty = piece1.IsEmpty(button15);
            isOur = piece1.IsOur(button15);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button15;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button16;

            isEmpty = piece1.IsEmpty(button16);
            isOur = piece1.IsOur(button16);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button16;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button17;

            isEmpty = piece1.IsEmpty(button17);
            isOur = piece1.IsOur(button17);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button17;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button18;

            isEmpty = piece1.IsEmpty(button18);
            isOur = piece1.IsOur(button18);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button18;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        piece1.Loop2(gloBut, locBut);
                        FClick = true;
                        SCLick = false;
                        
                    }
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button19;

            isEmpty = piece1.IsEmpty(button19);
            isOur = piece1.IsOur(button19);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button19;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button20;

            isEmpty = piece1.IsEmpty(button20);
            isOur = piece1.IsOur(button20);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button20;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button21;

            isEmpty = piece1.IsEmpty(button21);
            isOur = piece1.IsOur(button21);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button21;

            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button22;

            isEmpty = piece1.IsEmpty(button22);
            isOur = piece1.IsOur(button22);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button22;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {

                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button23;

            isEmpty = piece1.IsEmpty(button23);
            isOur = piece1.IsOur(button23);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button23;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button24;

            isEmpty = piece1.IsEmpty(button24);
            isOur = piece1.IsOur(button24);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button24;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button25;

            isEmpty = piece1.IsEmpty(button25);
            isOur = piece1.IsOur(button25);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button25;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button26;

            isEmpty = piece1.IsEmpty(button26);
            isOur = piece1.IsOur(button26);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button26;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button27;

            isEmpty = piece1.IsEmpty(button27);
            isOur = piece1.IsOur(button27);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button27;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button28;

            isEmpty = piece1.IsEmpty(button28);
            isOur = piece1.IsOur(button28);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button28;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button29;

            isEmpty = piece1.IsEmpty(button29);
            isOur = piece1.IsOur(button29);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button29;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button30;

            isEmpty = piece1.IsEmpty(button30);
            isOur = piece1.IsOur(button30);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button30;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button31;

            isEmpty = piece1.IsEmpty(button31);
            isOur = piece1.IsOur(button31);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button31;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button32;
            
            isEmpty = piece1.IsEmpty(button32);
            isOur = piece1.IsOur(button32);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button32;
            }
            else if (isEmpty == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop(myArray, gloBut, locBut, piece1);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
            else if (isEmpty == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y + 80) || gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (CheckerPiece.turn == true)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = false;
                        }
                        else if (CheckerPiece.turn == false)
                        {
                            piece1.Loop2(gloBut, locBut);
                            FClick = true;
                            SCLick = false;
                            CheckerPiece.turn = true;
                        }
                    }
                }
            }
        }
    }
}
