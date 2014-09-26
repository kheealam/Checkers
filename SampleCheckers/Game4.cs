using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.BackgroundImage = CheckerPieceClass.Image_Red;
            button2.BackgroundImage = CheckerPieceClass.Image_Red;
            button3.BackgroundImage = CheckerPieceClass.Image_Red;
            button4.BackgroundImage = CheckerPieceClass.Image_Red;
            button5.BackgroundImage = CheckerPieceClass.Image_Red;
            button6.BackgroundImage = CheckerPieceClass.Image_Red;
            button7.BackgroundImage = CheckerPieceClass.Image_Red;
            button8.BackgroundImage = CheckerPieceClass.Image_Red;
            button9.BackgroundImage = CheckerPieceClass.Image_Red;
            button10.BackgroundImage = CheckerPieceClass.Image_Red;
            button11.BackgroundImage = CheckerPieceClass.Image_Red;
            button12.BackgroundImage = CheckerPieceClass.Image_Red;
            button21.BackgroundImage = CheckerPieceClass.Image_Black;
            button22.BackgroundImage = CheckerPieceClass.Image_Black;
            button23.BackgroundImage = CheckerPieceClass.Image_Black;
            button24.BackgroundImage = CheckerPieceClass.Image_Black;
            button25.BackgroundImage = CheckerPieceClass.Image_Black;
            button26.BackgroundImage = CheckerPieceClass.Image_Black;
            button27.BackgroundImage = CheckerPieceClass.Image_Black;
            button28.BackgroundImage = CheckerPieceClass.Image_Black;
            button29.BackgroundImage = CheckerPieceClass.Image_Black;
            button30.BackgroundImage = CheckerPieceClass.Image_Black;
            button31.BackgroundImage = CheckerPieceClass.Image_Black;
            button32.BackgroundImage = CheckerPieceClass.Image_Black;
            globalButton = button32;
        }
        //This is the bool of First Click.
        //If it is true First CLick can be done.
        bool FClick = true;
        //This is the bool of Second Click.
        //If it is true Second CLick can be done.
        bool SCLick = false;
        //This variable is to store the return of IsEmpty Method.
        bool isEmpty;
        //This variable is to store the return of IsOur Method.
        bool isOur;
        //This bool is to give on and off effect to labels.
        bool ForTimer=true;
        //This variable is to store the global button.
        //The button is globalized when first click is done on it.
        Button globalButton;
        //It is the instance of the class CheckerPiece.
        CheckerPieceClass piece1 = new CheckerPieceClass();
        
        private void button1_Click(object sender, EventArgs e)
        {
            //This array contains all the buttons of the board.
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11,button12, button13, button14, button15,button16,button17,button18,button19,button20,button21,button22,button23,button24,button25,button26,button27,button28,button29,button30,button31,button32 };
            //This variable stores the button on which first click is done.
            Button localButton = button1;
            //Here the button is checked for its emptiness.
            isEmpty = piece1.IsEmpty(button1);
            //Here the button is checked for owner.
            isOur = piece1.IsOur(button1);
            //Checking if button is not empty & it is our.
            if (isEmpty == false && isOur == true)
            {
                //First Click is accepted.
                FClick = false;
                //Now place for second click is opened.
                SCLick = true;
                //Here the border color of global button is changed to black.
                globalButton.FlatAppearance.BorderColor = Color.Black;
                //Now this button is stored as global.
                globalButton = button1;
                //Here the border color of global button is changed to yellowgreen.
                button1.FlatAppearance.BorderColor = Color.YellowGreen;
            }
            //Checking if button is not empty and is not our.
            else if (isEmpty == false && isOur == false)
            {
                //If it was First click it will remain the same.
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                //If it was second click.
                else if (SCLick == true)
                {
                    //Checking if Click was done from the four sides of the localbutton(the button on which second click was done).
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            //Here it is calling the Loop method(which handles the events of capturing a piece).
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            else if (isEmpty == true)
            {
                //If it was First click it will remain the same.
                if (FClick == true)
                {
                    FClick = true;
                    SCLick = false;
                }
                //If it is Second click.
                else if (SCLick == true)
                {
                    //Checking if Click was done from the four sides of the localbutton(the button on which second click was done).
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            //Here is is calling the LocCheck method(which handles the normal move of a piece).
                            piece1.LocCheck(globalButton, localButton);
                            //Now it is changing the Clicks States back to there
                            //original states.
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            //Here an static NumPieces method is called(it calculates the number of pieces on the board).
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button2;
            isEmpty = piece1.IsEmpty(button2);
            isOur = piece1.IsOur(button2);
            if (isEmpty == false && isOur == true )
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button2;
                button2.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;    
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button3;
            isEmpty = piece1.IsEmpty(button3);
            isOur = piece1.IsOur(button3);
            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button3;
                button3.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button4;
            isEmpty = piece1.IsEmpty(button4);
            isOur = piece1.IsOur(button4);
            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button4;
                button4.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
                             
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                             
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button5;
            CheckerPieceClass piece1 = new CheckerPieceClass();
            isEmpty = piece1.IsEmpty(button5);
            isOur = piece1.IsOur(button5);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button5;
                button5.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {

                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
                             
                        
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                             
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button6;
            CheckerPieceClass piece1 = new CheckerPieceClass();
            isEmpty = piece1.IsEmpty(button6);
            isOur = piece1.IsOur(button6);

            if (isEmpty == false && isOur == true)
            {

                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button6;
                button6.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
                             
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                             
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button7;
            CheckerPieceClass piece1 = new CheckerPieceClass();
            isEmpty = piece1.IsEmpty(button7);
            isOur = piece1.IsOur(button7);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button7;
                button7.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
                             
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                             
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button8;
            isEmpty = piece1.IsEmpty(button8);
            isOur = piece1.IsOur(button8);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button8;
                button8.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
                             
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button9;
            isEmpty = piece1.IsEmpty(button9);
            isOur = piece1.IsOur(button9);
            
            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button9;
                button9.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {

                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button10;
            isEmpty = piece1.IsEmpty(button10);
            isOur = piece1.IsOur(button10);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button10;
                button10.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button11;
            isEmpty = piece1.IsEmpty(button11);
            isOur = piece1.IsOur(button11);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button11;
                button11.FlatAppearance.BorderColor = Color.YellowGreen;
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

                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button12;
            isEmpty = piece1.IsEmpty(button12);
            isOur = piece1.IsOur(button12);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button12;
                button12.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button13;

            isEmpty = piece1.IsEmpty(button13);
            isOur = piece1.IsOur(button13);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button13;
                button13.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button14;

            isEmpty = piece1.IsEmpty(button14);
            isOur = piece1.IsOur(button14);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button14;
                button14.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                             
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11,button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button15;

            isEmpty = piece1.IsEmpty(button15);
            isOur = piece1.IsOur(button15);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button15;
                button15.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button16;

            isEmpty = piece1.IsEmpty(button16);
            isOur = piece1.IsOur(button16);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button16;
                button16.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button17;

            isEmpty = piece1.IsEmpty(button17);
            isOur = piece1.IsOur(button17);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button17;
                button17.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button18;

            isEmpty = piece1.IsEmpty(button18);
            isOur = piece1.IsOur(button18);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button18;
                button18.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                        piece1.LocCheck(globalButton, localButton);
                        FClick = true;
                        SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button19;

            isEmpty = piece1.IsEmpty(button19);
            isOur = piece1.IsOur(button19);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button19;
                button19.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button20;

            isEmpty = piece1.IsEmpty(button20);
            isOur = piece1.IsOur(button20);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button20;
                button20.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button21;

            isEmpty = piece1.IsEmpty(button21);
            isOur = piece1.IsOur(button21);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button21;
                button21.FlatAppearance.BorderColor = Color.YellowGreen;

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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button22;

            isEmpty = piece1.IsEmpty(button22);
            isOur = piece1.IsOur(button22);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button22;
                button22.FlatAppearance.BorderColor = Color.YellowGreen;
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

                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button23;

            isEmpty = piece1.IsEmpty(button23);
            isOur = piece1.IsOur(button23);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button23;
                button23.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button24;

            isEmpty = piece1.IsEmpty(button24);
            isOur = piece1.IsOur(button24);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button24;
                button24.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button25;

            isEmpty = piece1.IsEmpty(button25);
            isOur = piece1.IsOur(button25);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button25;
                button25.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button26;

            isEmpty = piece1.IsEmpty(button26);
            isOur = piece1.IsOur(button26);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button26;
                button26.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button27;

            isEmpty = piece1.IsEmpty(button27);
            isOur = piece1.IsOur(button27);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button27;
                button27.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button28;

            isEmpty = piece1.IsEmpty(button28);
            isOur = piece1.IsOur(button28);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button28;
                button28.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button29;

            isEmpty = piece1.IsEmpty(button29);
            isOur = piece1.IsOur(button29);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button29;
                button29.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button30;

            isEmpty = piece1.IsEmpty(button30);
            isOur = piece1.IsOur(button30);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button30;
                button30.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button31;

            isEmpty = piece1.IsEmpty(button31);
            isOur = piece1.IsOur(button31);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button31;
                button31.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
            Button localButton = button32;
            
            isEmpty = piece1.IsEmpty(button32);
            isOur = piece1.IsOur(button32);

            if (isEmpty == false && isOur == true)
            {
                FClick = false;
                SCLick = true;
                globalButton.FlatAppearance.BorderColor = Color.Black;
                globalButton = button32;
                button32.FlatAppearance.BorderColor = Color.YellowGreen;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.Loop(myArray, globalButton, localButton, piece1,ref label4,ref label3);
                            FClick = true;
                            SCLick = false;
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
                    if (globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y + 80) || globalButton.Location == new Point(localButton.Location.X - 80, localButton.Location.Y - 80) || globalButton.Location == new Point(localButton.Location.X + 80, localButton.Location.Y - 80))
                    {
                            piece1.LocCheck(globalButton, localButton);
                            FClick = true;
                            SCLick = false;
                    }
                }
            }
            CheckerPieceClass.NumPieces(myArray);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckerPieceClass.turn == true)
            {
                if (ForTimer == true)
                {
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Red;
                    if (globalButton.BackgroundImage == CheckerPieceClass.Image_Black)
                    {
                        globalButton.FlatAppearance.BorderColor = Color.Red;
                    }
                    
                    ForTimer = false;
                }
                else if (ForTimer == false)
                {
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    if (globalButton.BackgroundImage == CheckerPieceClass.Image_Black)
                    {
                        globalButton.FlatAppearance.BorderColor = Color.Yellow;
                    }
                    
                    ForTimer = true;
                }
            }
            else if (CheckerPieceClass.turn == false)
            {
                if (ForTimer == true)
                {
                    label2.ForeColor = Color.Black;
                    label1.ForeColor = Color.Red;
                    if (globalButton.BackgroundImage == CheckerPieceClass.Image_Red)
                    {
                        globalButton.FlatAppearance.BorderColor = Color.Red;
                    }
                    ForTimer = false;
                }
                else if (ForTimer == false)
                {
                    label2.ForeColor = Color.Black;
                    label1.ForeColor = Color.Black;
                    if (globalButton.BackgroundImage == CheckerPieceClass.Image_Red)
                    {
                        globalButton.FlatAppearance.BorderColor = Color.Yellow;
                    }
                    ForTimer = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Names name = new Names();
            Form1 f1=new Form1();
            
            if (label1.Text=="Computer")
            {
                timer2.Enabled = true;
            }
            timer1.Enabled = true;
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
         
              Button[] myArray = { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32 };
              CheckerPieceClass.AIMain(myArray);
         
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckerPieceClass.CapBlackPieces = 0;
            CheckerPieceClass.CapRedPieces = 0;
            CheckerPieceClass.turn = true;
        }
    }
}
