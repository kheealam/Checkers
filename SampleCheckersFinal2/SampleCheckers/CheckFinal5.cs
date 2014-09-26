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
            button1.BackgroundImage = CheckerPiece.Image_Red;
            button3.BackgroundImage = CheckerPiece.Image_Red;
            button4.BackgroundImage = CheckerPiece.Image_Red;
            button1.BackgroundImage = CheckerPiece.Image_Red;
            button1.BackgroundImage = CheckerPiece.Image_Red;
            button7.BackgroundImage = CheckerPiece.Image_Red;
            button8.BackgroundImage = CheckerPiece.Image_Red;
            button9.BackgroundImage = CheckerPiece.Image_Red;
            button10.BackgroundImage = CheckerPiece.Image_Red;
            button1.BackgroundImage = CheckerPiece.Image_Red;
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
        Button gloBut;
        
        private void button1_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15,button16,button17,button18,button19,button20,button21,button22,button23,button24,button25,button26,button27,button28,button29,button30,button31,button32 };
            Button locBut = button1;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button1);
            isOur = piece1.IsOur(button1);
            locx = piece1.LocationX(button1);
            locy = piece1.LocationY(button1);
            
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button1;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 0; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locx+80>=0 && locy - 80 <= 200 && locy-80>=0)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button2;
            bool isEmptySelf;
            bool isOur;
            bool isKing;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button2);
            isOur = piece1.IsOur(button2);
            locx = piece1.LocationX(button2);
            locy = piece1.LocationY(button2);
            isKing=piece1.IsKing(button2);
            if (isEmptySelf == false && isOur == true )
            {
                FClick = false;
                SCLick = true;
                gloBut = button2;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button3;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button3);
            isOur = piece1.IsOur(button3);
            locx = piece1.LocationX(button3);
            locy = piece1.LocationY(button3);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button3;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button4;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button4);
            isOur = piece1.IsOur(button4);
            locx = piece1.LocationX(button4);
            locy = piece1.LocationY(button4);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button4;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                                if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button5;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button5);
            isOur = piece1.IsOur(button5);
            locx = piece1.LocationX(button5);
            locy = piece1.LocationY(button5);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button5;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    for (int i = 1; i <= myArray.Length; i++)
                    {
                        if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                                if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                                {
                                    if (piece1.IsEmpty(myArray[i]) == true)
                                    {
                                        CheckerPiece.Move(ref myArray[i], ref gloBut);
                                        locBut.BackgroundImage = null;
                                        break;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button6;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button6);
            isOur = piece1.IsOur(button6);
            locx = piece1.LocationX(button6);
            locy = piece1.LocationY(button6);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button6;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button7;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button7);
            isOur = piece1.IsOur(button7);
            locx = piece1.LocationX(button7);
            locy = piece1.LocationY(button7);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button7;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {

                    if (gloBut.Location == new Point(locx - 80, locy + 80) && gloBut.Location == new Point(locx - 80, locy - 80) && gloBut.Location == new Point(locx + 80, locy + 80) && gloBut.Location == new Point(locx + 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                                if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button8;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button8);
            isOur = piece1.IsOur(button8);
            locx = piece1.LocationX(button8);
            locy = piece1.LocationY(button8);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button8;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button9;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button9);
            isOur = piece1.IsOur(button9);
            locx = piece1.LocationX(button9);
            locy = piece1.LocationY(button9);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button9;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button10;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button10);
            isOur = piece1.IsOur(button10);
            locx = piece1.LocationX(button10);
            locy = piece1.LocationY(button10);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button10;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    for (int i = 0; i <= myArray.Length; i++)
                    {
                        if (gloBut.Location == new Point(locx - 80, locy + 80))
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                                if (myArray[i].Location == new Point(locx + 80, locy - 80) && piece1.IsEmpty(myArray[i]) == true)
                                {
                                    if (piece1.IsEmpty(myArray[i]) == true)
                                    {
                                        CheckerPiece.Move(ref myArray[i], ref gloBut);
                                        locBut.BackgroundImage = null;
                                        break;
                                    }

                                }
                            }
                        }
                        else if (gloBut.Location == new Point(locx + 80, locy - 80))
                        {
                            if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                            {
                                if (locx + 80 <= 400 && locy - 80 <= 200)
                                {

                                    if (myArray[i].Location == new Point(locx - 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                                    {
                                        if (piece1.IsEmpty(myArray[i]) == true)
                                        {
                                            CheckerPiece.Move(ref myArray[i], ref gloBut);
                                            locBut.BackgroundImage = null;
                                            break;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (gloBut.Location == new Point(locx + 80, locy + 80))
                        {

                                if (locx + 80 <= 400 && locy - 80 <= 200)
                                {

                                    if (myArray[i].Location == new Point(locx - 80, locy - 80) && piece1.IsEmpty(myArray[i]) == true)
                                    {
                                        if (piece1.IsEmpty(myArray[i]) == true)
                                        {
                                            CheckerPiece.Move(ref myArray[i], ref gloBut);
                                            locBut.BackgroundImage = null;
                                            break;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                        }
                        else if (gloBut.Location == new Point(locx - 80, locy - 80))
                        {

                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {

                                if (myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                                {
                                    if (piece1.IsEmpty(myArray[i]) == true)
                                    {
                                        CheckerPiece.Move(ref myArray[i], ref gloBut);
                                        locBut.BackgroundImage = null;
                                        break;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx - 80, locy + 80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage == CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button11;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button11);
            isOur = piece1.IsOur(button11);
            locx = piece1.LocationX(button11);
            locy = piece1.LocationY(button11);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button11;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button12;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button12);
            isOur = piece1.IsOur(button12);
            locx = piece1.LocationX(button12);
            locy = piece1.LocationY(button12);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button12;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button13;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button13);
            isOur = piece1.IsOur(button13);
            locx = piece1.LocationX(button13);
            locy = piece1.LocationY(button13);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button13;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button14;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button14);
            isOur = piece1.IsOur(button14);
            locx = piece1.LocationX(button14);
            locy = piece1.LocationY(button14);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button14;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 0; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button15;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button15);
            isOur = piece1.IsOur(button15);
            locx = piece1.LocationX(button15);
            locy = piece1.LocationY(button15);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button15;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button16;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button16);
            isOur = piece1.IsOur(button16);
            locx = piece1.LocationX(button16);
            locy = piece1.LocationY(button16);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button16;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button17;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button17);
            isOur = piece1.IsOur(button17);
            locx = piece1.LocationX(button17);
            locy = piece1.LocationY(button17);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button17;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button18;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button18);
            isOur = piece1.IsOur(button18);
            locx = piece1.LocationX(button18);
            locy = piece1.LocationY(button18);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button18;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button19;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button19);
            isOur = piece1.IsOur(button19);
            locx = piece1.LocationX(button19);
            locy = piece1.LocationY(button19);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button19;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button20;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button20);
            isOur = piece1.IsOur(button20);
            locx = piece1.LocationX(button20);
            locy = piece1.LocationY(button20);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button20;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button21;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button21);
            isOur = piece1.IsOur(button21);
            locx = piece1.LocationX(button21);
            locy = piece1.LocationY(button21);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button21;

            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y + 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80) || myArray[i].Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button22;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button22);
            isOur = piece1.IsOur(button22);
            locx = piece1.LocationX(button22);
            locy = piece1.LocationY(button22);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button22;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button23;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button23);
            isOur = piece1.IsOur(button23);
            locx = piece1.LocationX(button23);
            locy = piece1.LocationY(button23);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button23;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80) || gloBut.Location==new Point(locx - 80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button24;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button24);
            isOur = piece1.IsOur(button24);
            locx = piece1.LocationX(button24);
            locy = piece1.LocationY(button24);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button24;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button25;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button25);
            isOur = piece1.IsOur(button25);
            locx = piece1.LocationX(button25);
            locy = piece1.LocationY(button25);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button25;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button26;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button26);
            isOur = piece1.IsOur(button26);
            locx = piece1.LocationX(button26);
            locy = piece1.LocationY(button26);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button26;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button27;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button27);
            isOur = piece1.IsOur(button27);
            locx = piece1.LocationX(button27);
            locy = piece1.LocationY(button27);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button27;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button28;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button28);
            isOur = piece1.IsOur(button28);
            locx = piece1.LocationX(button28);
            locy = piece1.LocationY(button28);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button28;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button29;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button29);
            isOur = piece1.IsOur(button29);
            locx = piece1.LocationX(button29);
            locy = piece1.LocationY(button29);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button29;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button30;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button30);
            isOur = piece1.IsOur(button30);
            locx = piece1.LocationX(button30);
            locy = piece1.LocationY(button30);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button30;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button31;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button31);
            isOur = piece1.IsOur(button31);
            locx = piece1.LocationX(button31);
            locy = piece1.LocationY(button31);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button31;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button locBut = button32;
            bool isEmptySelf;
            bool isOur;
            int locx;
            int locy;

            CheckerPiece piece1 = new CheckerPiece();
            isEmptySelf = piece1.IsEmpty(button32);
            isOur = piece1.IsOur(button32);
            locx = piece1.LocationX(button32);
            locy = piece1.LocationY(button32);
            if (isEmptySelf == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                gloBut = button32;
            }
            else if (isEmptySelf == false && isOur == false)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                                       
                    if (gloBut.Location == new Point(locx - 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location == new Point(locx + 80, locy - 80) || gloBut.Location == new Point(locx - 80, locy - 80))
                    {
                        for (int i = 1; i <= myArray.Length; i++)
                        {
                            if (locx + 80 <= 400 && locy - 80 <= 200)
                            {
                            if (myArray[i].Location == new Point(locx + 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy - 80) || myArray[i].Location == new Point(locx - 80, locy + 80) || myArray[i].Location == new Point(locx + 80, locy + 80) && piece1.IsEmpty(myArray[i]) == true)
                            {
                                if (piece1.IsEmpty(myArray[i]) == true)
                                {
                                    CheckerPiece.Move(ref myArray[i], ref gloBut);
                                    locBut.BackgroundImage = null;
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            }
                        }
                    }
                }
            }
            else if (isEmptySelf == true)
            {
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                else if (SCLick == true)
                {
                    if (gloBut.Location == new Point(locx + 80, locy + 80) || gloBut.Location==new Point(locx-80,locy+80))
                    {
                        if (locy == 50 && gloBut.BackgroundImage==CheckerPiece.Image_Black)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Black;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Black || gloBut.BackgroundImage==CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                    else if (gloBut.Location == new Point(locBut.Location.X - 80, locBut.Location.Y - 80) || gloBut.Location == new Point(locBut.Location.X + 80, locBut.Location.Y - 80))
                    {
                        if (locy == 610 && gloBut.BackgroundImage == CheckerPiece.Image_Red)
                        {
                            gloBut.BackgroundImage = CheckerPiece.Image_King_Red;
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        if (gloBut.BackgroundImage == CheckerPiece.Image_King_Black)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                        else if (gloBut.BackgroundImage == CheckerPiece.Image_Red || gloBut.BackgroundImage==CheckerPiece.Image_King_Red)
                        {
                            CheckerPiece.Move(ref gloBut, ref locBut);
                        }
                    }
                }
            }
        }
    }
}
