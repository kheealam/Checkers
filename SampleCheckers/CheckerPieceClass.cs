using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace WindowsFormsApplication1
{
    class CheckerPieceClass
    {
        
        //FIELDS:
        //This is used in IsEmpty method.
        private bool checkOwner;
        //This is the image of normal black piece.
        public static Image Image_Black = Image.FromFile("Pieces_Black2.png");
        //This is the image of normal red piece.
        public static Image Image_Red = Image.FromFile("Pieces_Red2.png");
        //This is the image of black king piece.
        public static Image Image_King_Black = Image.FromFile("King_Black2.png");
        //This is the image of red king piece.
        public static Image Image_King_Red = Image.FromFile("King_Red2.png");
        //This sound is played when piece becomes King.
        public static SoundPlayer king = new SoundPlayer("trumpet.wav");
        //This sound is played when piece moves.
        public static SoundPlayer moveS = new SoundPlayer("button-47.wav");
        //This sound is played when piece captures enemy's piece.
        public static SoundPlayer moveSC = new SoundPlayer("button-21.wav");
        //This calculates the number of red pieces captured by black.
        public static int CapRedPieces=0;
        //This calculates the number of black pieces captured by red.
        public static int CapBlackPieces=0;
        //This changes the turns.
        public static bool turn=true;
        

        //METHODS:
        
        //(1) Checks whether the piece is Present or Not.

        public bool IsEmpty(Button button)
        {
            //This checks whether the backgroundimage of button is empty or not.
            bool checkImage;
            checkImage = (button.BackgroundImage==null) ? true : false;
            return checkImage;
        }

        //(2) Checks whether the piece is Our or Not.
        
        public bool IsOur(Button button)
        {
            //This Part is for the AI.
            Names name = new Names();
            if (name.radioButton1.Checked==true)
            {
                checkOwner = (button.BackgroundImage == Image_Black || button.BackgroundImage == Image_King_Black) ? true : false;
                return checkOwner;
            }
            //This part is for the Multiplayer(Player vs Player).
            else
            {
                //If turn if true, black pieces will be considered as our.
                if (turn == true)
                {

                    {
                        checkOwner = (button.BackgroundImage == Image_Black || button.BackgroundImage == Image_King_Black) ? true : false;
                    }
                }
                //If turn if false, red pieces will be considered as our.
                else if (turn == false)
                {
                    checkOwner = (button.BackgroundImage == Image_Red || button.BackgroundImage == Image_King_Red) ? true : false;
                }
                return checkOwner;
            }
        }
        
        //(3) Checks whether the piece is King or Not.

        //public bool IsKing(Button button)
        //{
        //    //This checks whether the piece is a King or not.
        //    bool king;
        //    king = (button.BackgroundImage == Image_King_Black) ? true : false;
        //    return king;
        //}

        //(4)Checks Whether the box after the Enemy's Piece is Empty or Not.

        public void Loop(Button[] array,Button global,Button local,CheckerPieceClass piece,ref Label lable1,ref Label lable2)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //This checks the difference between the locations local button and global button .
                if(global.Location==new Point(local.Location.X-80,local.Location.Y+80))
                {
                    //After checking the location it checks the image of the global button.
                    //Only Black piece,Black King and Red king is allowed.
                    if (global.BackgroundImage == CheckerPieceClass.Image_King_Black || global.BackgroundImage == CheckerPieceClass.Image_Black || global.BackgroundImage == CheckerPieceClass.Image_King_Red)
                    {   
                          //Here it is checking the next button's location after local button.
                          if (array[i].Location == new Point(local.Location.X + 80, local.Location.Y - 80))
                          {
                              //Here it is checking whether the next button after local button is
                              //empty of not.
                              if (piece.IsEmpty(array[i]) == true)
                              {
                                    //Here it is checking if the next button's location's Y after local button is "50" or not.
                                    //and its image is black piece or not.
                                    if (array[i].Location.Y == 50 && global.BackgroundImage == CheckerPieceClass.Image_Black)
                                    {
                                        //Playing the sound of KING.
                                        king.Play();
                                        //Changing the image to King.
                                        global.BackgroundImage = CheckerPieceClass.Image_King_Black;
                                        //Moving the piece to its location.
                                        CheckerPieceClass.Move(ref array[i], ref global);
                                        //Capturing the enemies piece.
                                        local.BackgroundImage = null;
                                        //If turn is true.
                                        if (CheckerPieceClass.turn == true)
                                        {
                                            //Here it increases the number of pieces captured.
                                            CapRedPieces += 1;
                                            lable1.Text = Convert.ToString(CapRedPieces);
                                            //Changing the turn.
                                            CheckerPieceClass.turn = false;
                                            //Deselecting the piece which was selected.
                                            global.FlatAppearance.BorderColor = Color.Black;
                                        }
                                        else if (CheckerPieceClass.turn == false)
                                        {
                                            //Here it increases the number of pieces captured.
                                            CapBlackPieces += 1;
                                            lable2.Text = Convert.ToString(CapBlackPieces);
                                            //Changing the turn.
                                            CheckerPieceClass.turn = true;
                                        }
                                    }
                                    //Here it is checking if the next button's location's Y after local button is not "50" .
                                    else
                                    {
                                        //Playing the sound of Capturing.
                                        moveSC.Play();
                                        //Moving the Piece to its location.
                                        CheckerPieceClass.Move(ref array[i], ref global);
                                        //Capturing the piece.
                                        local.BackgroundImage = null;
                                        //Same as above.
                                        if (CheckerPieceClass.turn == true)
                                        {
                                            CapRedPieces += 1;
                                            lable1.Text = Convert.ToString(CapRedPieces);
                                            CheckerPieceClass.turn = false;
                                        }
                                        else if (CheckerPieceClass.turn == false)
                                        {
                                            CapBlackPieces += 1;
                                            lable2.Text = Convert.ToString(CapBlackPieces);
                                            CheckerPieceClass.turn = true;
                                        }
                                        //AFter doing its work it breaks the loop.
                                        break;
                                    }
                                }
                            }   
                    }
                }
                //This checks the difference between the locations local button and global button.
                else if (global.Location == new Point(local.Location.X + 80, local.Location.Y - 80))
                {
                    //After checking the location it checks the image of the global button.
                    //Only Red piece,Black King and Red king is allowed.
                    if (global.BackgroundImage == CheckerPieceClass.Image_King_Black || global.BackgroundImage==CheckerPieceClass.Image_Red || global.BackgroundImage==CheckerPieceClass.Image_King_Red)
                    {
                        //From here to the end of this method code same as above just the differences of locations.
                            if (array[i].Location == new Point(local.Location.X - 80, local.Location.Y + 80))
                            {
                                if (piece.IsEmpty(array[i]) == true)
                                {
                                    if (array[i].Location.Y == 610 && global.BackgroundImage == CheckerPieceClass.Image_Red)
                                    {
                                        king.Play();
                                        global.BackgroundImage = CheckerPieceClass.Image_King_Red;
                                        CheckerPieceClass.Move(ref array[i], ref global);
                                        local.BackgroundImage = null;
                                        if (CheckerPieceClass.turn == true)
                                        {
                                            CapRedPieces += 1;
                                            lable1.Text = Convert.ToString(CapRedPieces);
                                            CheckerPieceClass.turn = false;
                                        }
                                        else if (CheckerPieceClass.turn == false)
                                        {
                                            CapBlackPieces += 1;
                                            lable2.Text = Convert.ToString(CapBlackPieces);
                                            CheckerPieceClass.turn = true;
                                        }
                                    }
                                    else
                                    {
                                        moveSC.Play();
                                        CheckerPieceClass.Move(ref array[i], ref global);
                                        local.BackgroundImage = null;
                                        if (CheckerPieceClass.turn == true)
                                        {
                                            CapRedPieces += 1;
                                            lable1.Text = Convert.ToString(CapRedPieces);
                                            CheckerPieceClass.turn = false;
                                        }
                                        else if (CheckerPieceClass.turn == false)
                                        {
                                            CapBlackPieces += 1;
                                            lable2.Text = Convert.ToString(CapBlackPieces);
                                            CheckerPieceClass.turn = true;
                                        }
                                        break;
                                    }
                                }
                            }
                    }
                }
                else if (global.Location == new Point(local.Location.X + 80, local.Location.Y + 80))
                {
                    if (global.BackgroundImage == CheckerPieceClass.Image_King_Black || global.BackgroundImage == CheckerPieceClass.Image_Black || global.BackgroundImage == CheckerPieceClass.Image_King_Red)
                    {
                            if (array[i].Location == new Point(local.Location.X - 80, local.Location.Y - 80))
                            {
                                if (piece.IsEmpty(array[i]) == true)
                                {
                                    if (array[i].Location.Y == 50 && global.BackgroundImage == CheckerPieceClass.Image_Black)
                                    {
                                        king.Play();
                                        global.BackgroundImage = CheckerPieceClass.Image_King_Black;
                                        CheckerPieceClass.Move(ref array[i], ref global);
                                        local.BackgroundImage = null;
                                        if (CheckerPieceClass.turn == true)
                                        {
                                            CapRedPieces += 1;
                                            lable1.Text = Convert.ToString(CapRedPieces);
                                            CheckerPieceClass.turn = false;
                                        }
                                        else if (CheckerPieceClass.turn == false)
                                        {
                                            CapBlackPieces += 1;
                                            lable2.Text = Convert.ToString(CapBlackPieces);
                                            CheckerPieceClass.turn = true;
                                        }
                                    }
                                    else
                                    {
                                        moveSC.Play();
                                        CheckerPieceClass.Move(ref array[i], ref global);
                                        local.BackgroundImage = null;
                                        if (CheckerPieceClass.turn == true)
                                        {
                                            CapRedPieces += 1;
                                            lable1.Text = Convert.ToString(CapRedPieces);
                                            CheckerPieceClass.turn = false;
                                        }
                                        else if (CheckerPieceClass.turn == false)
                                        {
                                            CapBlackPieces += 1;
                                            lable2.Text = Convert.ToString(CapBlackPieces);
                                            CheckerPieceClass.turn = true;
                                        }
                                        break;
                                    }
                                }
                            }
                    }
                }
                else if (global.Location == new Point(local.Location.X - 80, local.Location.Y - 80))
                {
                    if (global.BackgroundImage == CheckerPieceClass.Image_King_Black || global.BackgroundImage==CheckerPieceClass.Image_Red || global.BackgroundImage==CheckerPieceClass.Image_King_Red)
                    {              
                         if (array[i].Location == new Point(local.Location.X + 80, local.Location.Y + 80))
                         {
                             if (piece.IsEmpty(array[i]) == true)
                             {
                                 if (array[i].Location.Y == 610 && global.BackgroundImage == CheckerPieceClass.Image_Red)
                                 {
                                     king.Play();
                                     global.BackgroundImage = CheckerPieceClass.Image_King_Red;
                                     CheckerPieceClass.Move(ref array[i], ref global);
                                     local.BackgroundImage = null;
                                     if (CheckerPieceClass.turn == true)
                                     {
                                         CapRedPieces += 1;
                                         lable1.Text = Convert.ToString(CapRedPieces);
                                         CheckerPieceClass.turn = false;
                                     }
                                     else if (CheckerPieceClass.turn == false)
                                     {
                                         CapBlackPieces += 1;
                                         lable2.Text = Convert.ToString(CapBlackPieces);
                                         CheckerPieceClass.turn = true;
                                     }
                                 }
                                 else
                                 {
                                     moveSC.Play();
                                     CheckerPieceClass.Move(ref array[i], ref global);
                                     local.BackgroundImage = null;
                                     if (CheckerPieceClass.turn == true)
                                     {
                                         CapRedPieces += 1;
                                         lable1.Text = Convert.ToString(CapRedPieces);
                                         CheckerPieceClass.turn = false;
                                     }
                                     else if (CheckerPieceClass.turn == false)
                                     {
                                         CapBlackPieces += 1;
                                         lable2.Text = Convert.ToString(CapBlackPieces);
                                         CheckerPieceClass.turn = true;
                                     }
                                     break;
                                 }
                             }
                        }
                    }
                }
            }
        }

        //(5)Checks, from how far the click was done.

        public void LocCheck(Button global, Button local)
        {
            //This checks the difference between the locations local button and global button.
            if (global.Location == new Point(local.Location.X + 80, local.Location.Y + 80) || global.Location == new Point(local.Location.X - 80, local.Location.Y + 80))
            {
                //Here it is checking whether the next button is the end of the board or not and the global button image is black.
                if (local.Location.Y == 50 && global.BackgroundImage == CheckerPieceClass.Image_Black)
                {
                    //Playing sound of King
                    king.Play();
                    //Changing image to King.
                    global.BackgroundImage = CheckerPieceClass.Image_King_Black;
                    //Moving the piece to its location.
                    CheckerPieceClass.Move(ref global, ref local);
                    //Same as in the Loop method.
                    if (CheckerPieceClass.turn == true)
                    {
                        CheckerPieceClass.turn = false;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                    else if (CheckerPieceClass.turn == false)
                    {
                        CheckerPieceClass.turn = true;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                }
                //Only Black Piece,Black King and Red piece is allowed to move in upward direction.
                else if (global.BackgroundImage == CheckerPieceClass.Image_King_Red || global.BackgroundImage == CheckerPieceClass.Image_Black || global.BackgroundImage == CheckerPieceClass.Image_King_Black)
                {
                    
                    moveS.Play();
                    CheckerPieceClass.Move(ref global, ref local);
                    if (CheckerPieceClass.turn == true)
                    {
                        CheckerPieceClass.turn = false;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                    else if (CheckerPieceClass.turn == false)
                    {
                        CheckerPieceClass.turn = true;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                }
            }
            
            else if (global.Location == new Point(local.Location.X - 80, local.Location.Y - 80) || global.Location == new Point(local.Location.X + 80, local.Location.Y - 80))
            {
                //Checking the location if it is the edge of the board and image is black piece.
                if (local.Location.Y == 610 && global.BackgroundImage == CheckerPieceClass.Image_Red)
                {
                    king.Play();
                    global.BackgroundImage = CheckerPieceClass.Image_King_Red;
                    CheckerPieceClass.Move(ref global, ref local);
                    if (CheckerPieceClass.turn == true)
                    {
                        CheckerPieceClass.turn = false;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                    else if (CheckerPieceClass.turn == false)
                    {
                        CheckerPieceClass.turn = true;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                }
                else if (global.BackgroundImage == CheckerPieceClass.Image_King_Black || global.BackgroundImage == CheckerPieceClass.Image_Red || global.BackgroundImage == CheckerPieceClass.Image_King_Red)
                {
                    moveS.Play();
                    CheckerPieceClass.Move(ref global, ref local);
                    if (CheckerPieceClass.turn == true)
                    {
                        CheckerPieceClass.turn = false;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                    else if (CheckerPieceClass.turn == false)
                    {
                        CheckerPieceClass.turn = true;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                }
            }
        }

        //(6)Moves the piece to the specified location.

        public static void Move(ref Button a, ref Button b)
        {
            Image temp1, temp2;
            temp1 = a.BackgroundImage;
            temp2 = b.BackgroundImage;
            a.BackgroundImage = temp2;
            b.BackgroundImage = temp1;
        }

        //(7)Checks the number of pieces on the board both Black and Red.

        public static void NumPieces(Button[] array)
        {
            Form1 f1 = new Form1();
            int a=0,b=0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].BackgroundImage == CheckerPieceClass.Image_Black || array[i].BackgroundImage == CheckerPieceClass.Image_King_Black)
                {
                    a = a + 1;
                }
                else if (array[i].BackgroundImage == CheckerPieceClass.Image_Red || array[i].BackgroundImage == CheckerPieceClass.Image_King_Red)
                {
                    b=b+1;
                }
                else
                {
                    continue;
                }
            }
            if (a == 0)
            {
                MessageBox.Show(f1.label1.Text+" Won");
            }
            else if (b == 0)
            {
                MessageBox.Show(f1.label2.Text+" Won");
            }
        }
        //(8)Its Computer's Main Intelligence;

        public static void AIMain(Button[] array)
        {
            AICapt(array);
        }

        //(9)It Controls Normal Moves of Computer;

        //Priority: Third;

        //Detail:
        //After checking whether he can capture enemy's piece and save his own piece.
        //It makes a normal move.

        public static void AINorm(Button[] array)
        {
            //this instance is created to generate a
            //random number to play the move.

            Random num = new Random();

            //this variable calculates the length of array.
            //it also acts as the random number for array.

            int length = 0;

            //this variable calculates the index of the array.

            int norm = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //this checks the first box.
                if (array[i].BackgroundImage == Image_Red || array[i].BackgroundImage == Image_King_Red)
                {
                    for (int a = 0; a < array.Length; a++)
                    {
                        //this checks the second box's position and checks whether
                        //it is empty or not.
                        if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && array[a].BackgroundImage == null)
                        {
                            length += 1;
                        }
                        if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && array[a].BackgroundImage == null)
                        {
                            length += 1;
                        }
                        if (array[i].BackgroundImage == Image_King_Red)
                        {
                            if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y + 80) && array[a].BackgroundImage == null)
                            {
                                length += 1;
                            }
                            if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y + 80) && array[a].BackgroundImage == null)
                            {
                                length += 1;
                            }
                        }
                    }
                }
            }
            //here an array is created of the length of the
            //possibilities of normal moves.

            Button[] array1 = new Button[length];
            if (length != 0)

                //these loops arranges those possibilities in the array.

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].BackgroundImage == Image_Red || array[i].BackgroundImage == Image_King_Red)
                    {
                        for (int a = 0; a < array.Length; a++)
                        {
                            if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && array[a].BackgroundImage == null)
                            {
                                //here this check checks whether index of the array is smaller than
                                //its length or not.

                                if (norm < length)
                                {
                                    //here index number is increased.

                                    array1[norm] = array[i];
                                    norm++;
                                }
                            }
                            if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && array[a].BackgroundImage == null)
                            {
                                if (norm < length)
                                {
                                    array1[norm] = array[i];
                                    norm++;
                                }
                            }
                            if (array[i].BackgroundImage == CheckerPieceClass.Image_King_Red)
                            {
                                if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y + 80) && array[a].BackgroundImage == null)
                                {
                                    if (norm < length)
                                    {
                                        array1[norm] = array[i];
                                        norm++;
                                    }
                                }
                                if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y + 80) && array[a].BackgroundImage == null)
                                {
                                    if (norm < length)
                                    {
                                        array1[norm] = array[i];
                                        norm++;
                                    }
                                }
                            }
                        }
                    }
                }
            //decreament is done because when the last element
            //is arranged the array, index number is increased
            //which becomes equal to the length.

            norm--;
            if (length != 0)
            {
                //here it generates the random move for the computer.

                length = num.Next(norm);

                //these codes check the position of the randomly
                //generated move.And then moves the piece and changes the turn.

                for (int a = 0; a < array.Length; a++)
                {
                    if ((array1[length].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) || array1[length].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80)) && array[a].BackgroundImage == null)
                    {
                        if (array[a].Location.Y == 610)
                        {
                            if (CheckerPieceClass.turn == false)
                            {
                                Move(ref array1[length], ref array[a]);
                                array[a].BackgroundImage = CheckerPieceClass.Image_King_Red;
                                turn = true;
                                break;
                            }
                        }
                        else
                        {
                            if (CheckerPieceClass.turn == false)
                            {
                                Move(ref array1[length], ref array[a]);
                                turn = true;
                                break;
                            }
                        }
                    }
                    else if (array1[length].BackgroundImage == Image_King_Red)
                    {
                        if (array1[length].Location == new Point(array[a].Location.X + 80, array[a].Location.Y + 80) && array[a].BackgroundImage == null)
                        {
                            if (CheckerPieceClass.turn == false)
                            {
                                Move(ref array1[length], ref array[a]);
                                turn = true;
                                break;
                            }
                        }
                        else if (array1[length].Location == new Point(array[a].Location.X - 80, array[a].Location.Y + 80) && array[a].BackgroundImage == null)
                        {
                            if (CheckerPieceClass.turn == false)
                            {
                                Move(ref array1[length], ref array[a]);
                                turn = true;
                                break;
                            }
                        }
                    }
                }
            }
        }

        //(10)Its Controls Capturing Moves of Computer;

        //Priority: First;

        //Detail:
        //It helps the computer to recognize which enemy pieces can be captured.

        public static void AICapt(Button[] array)
        {
            Random num = new Random();
            int length = 0;
            int capt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].BackgroundImage == Image_Red || array[i].BackgroundImage == Image_King_Red)
                {
                    for (int a = 0; a < array.Length; a++)
                    {
                        if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && (array[a].BackgroundImage == CheckerPieceClass.Image_Black || array[a].BackgroundImage == CheckerPieceClass.Image_King_Black))
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y - 80) && array[b].BackgroundImage == null)
                                {
                                    length += 1;
                                }
                            }
                        }
                        if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && (array[a].BackgroundImage == CheckerPieceClass.Image_Black || array[a].BackgroundImage == CheckerPieceClass.Image_King_Black))
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y - 80) && array[b].BackgroundImage == null)
                                {
                                    length += 1;
                                }
                            }
                        }
                        if (array[i].BackgroundImage == Image_King_Red)
                        {
                            if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y + 80) && (array[a].BackgroundImage == CheckerPieceClass.Image_Black || array[a].BackgroundImage == CheckerPieceClass.Image_King_Black))
                            {
                                for (int b = 0; b < array.Length; b++)
                                {
                                    if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y + 80) && array[b].BackgroundImage == null)
                                    {
                                        length += 1;
                                    }
                                }
                            }
                            if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y + 80) && (array[a].BackgroundImage == CheckerPieceClass.Image_Black || array[a].BackgroundImage == CheckerPieceClass.Image_King_Black))
                            {
                                for (int b = 0; b < array.Length; b++)
                                {
                                    if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y + 80) && array[b].BackgroundImage == null)
                                    {
                                        length += 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Button[] array1 = new Button[length];
            if (length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].BackgroundImage == Image_Red || array[i].BackgroundImage == Image_King_Red)
                    {
                        for (int a = 0; a < array.Length; a++)
                        {
                            if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && (array[a].BackgroundImage == CheckerPieceClass.Image_Black || array[a].BackgroundImage == CheckerPieceClass.Image_King_Black))
                            {
                                for (int b = 0; b < array.Length; b++)
                                {
                                    if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y - 80) && array[b].BackgroundImage == null)
                                    {
                                        if (capt < length)
                                        {
                                            array1[capt] = array[i];
                                            capt++;
                                        }
                                    }
                                }
                            }
                            if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && (array[a].BackgroundImage == CheckerPieceClass.Image_Black || array[a].BackgroundImage == CheckerPieceClass.Image_King_Black))
                            {
                                for (int b = 0; b < array.Length; b++)
                                {
                                    if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y - 80) && array[b].BackgroundImage == null)
                                    {
                                        if (capt < length)
                                        {
                                            array1[capt] = array[i];
                                            capt++;
                                        }
                                    }
                                }
                            }
                            if (array[i].BackgroundImage == Image_King_Red)
                            {
                                if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y + 80) && (array[a].BackgroundImage == CheckerPieceClass.Image_Black || array[a].BackgroundImage == CheckerPieceClass.Image_King_Black))
                                {
                                    for (int b = 0; b < array.Length; b++)
                                    {
                                        if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y + 80) && array[b].BackgroundImage == null)
                                        {
                                            if (capt < length)
                                            {
                                                array1[capt] = array[i];
                                                capt++;
                                            }
                                        }
                                    }
                                }
                                if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y + 80) && (array[a].BackgroundImage == CheckerPieceClass.Image_Black || array[a].BackgroundImage == CheckerPieceClass.Image_King_Black))
                                {
                                    for (int b = 0; b < array.Length; b++)
                                    {
                                        if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y + 80) && array[b].BackgroundImage == null)
                                        {
                                            if (capt < length)
                                            {
                                                array1[capt] = array[i];
                                                capt++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            capt--;
            if (length == 0)
            {
                AISave(array);
            }
            else if (length != 0)
            {
                length = num.Next(capt);
                if (array1[length].BackgroundImage == Image_Red || array1[length].BackgroundImage == Image_King_Red)
                {
                    for (int a = 0; a < array.Length; a++)
                    {
                        if (array1[length].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && (array[a].BackgroundImage == CheckerPieceClass.Image_Black || array[a].BackgroundImage == CheckerPieceClass.Image_King_Black))
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y - 80) && array[b].BackgroundImage == null)
                                {
                                    if (CheckerPieceClass.turn == false)
                                    {
                                        if (array[b].Location.Y == 610)
                                        {
                                            Move(ref array1[length], ref array[b]);
                                            array[a].BackgroundImage = null;
                                            array[b].BackgroundImage = Image_King_Red;
                                            turn = true;
                                            break;
                                        }
                                        else
                                        {
                                            Move(ref array1[length], ref array[b]);
                                            array[a].BackgroundImage = null;
                                            turn = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else if (array1[length].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && (array[a].BackgroundImage == CheckerPieceClass.Image_Black || array[a].BackgroundImage == CheckerPieceClass.Image_King_Black))
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y - 80) && array[b].BackgroundImage == null)
                                {
                                    if (CheckerPieceClass.turn == false)
                                    {
                                        if (array[b].Location.Y == 610)
                                        {
                                            Move(ref array1[length], ref array[b]);
                                            array[a].BackgroundImage = null;
                                            array[b].BackgroundImage = Image_King_Red;
                                            turn = true;
                                            break;
                                        }
                                        else
                                        {
                                            Move(ref array1[length], ref array[b]);
                                            array[a].BackgroundImage = null;
                                            turn = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else if (array1[length].BackgroundImage == Image_King_Red)
                        {
                            if (array1[length].Location == new Point(array[a].Location.X + 80, array[a].Location.Y + 80) && (array[a].BackgroundImage == CheckerPieceClass.Image_Black || array[a].BackgroundImage == CheckerPieceClass.Image_King_Black))
                            {
                                for (int b = 0; b < array.Length; b++)
                                {
                                    if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y + 80) && array[b].BackgroundImage == null)
                                    {
                                        if (CheckerPieceClass.turn == false)
                                        {
                                            Move(ref array1[length], ref array[b]);
                                            array[a].BackgroundImage = null;
                                            turn = true;
                                            break;
                                        }
                                    }
                                }
                            }
                            else if (array1[length].Location == new Point(array[a].Location.X - 80, array[a].Location.Y + 80) && (array[a].BackgroundImage == CheckerPieceClass.Image_Black || array[a].BackgroundImage == CheckerPieceClass.Image_King_Black))
                            {
                                for (int b = 0; b < array.Length; b++)
                                {
                                    if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y + 80) && array[b].BackgroundImage == null)
                                    {
                                        if (CheckerPieceClass.turn == false)
                                        {
                                            Move(ref array1[length], ref array[b]);
                                            array[a].BackgroundImage = null;
                                            turn = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        //(9)It Controls Saving Moves of Computer;

        //Priority: Second;

        //Detail:
        //It helps the computer to judge which of his piece is about to get captured.
        //He makes a move to save his piece.

        public static void AISave(Button[] array)
        {
            Random num = new Random();
            int length = 0;
            int save = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int a = 0; a < array.Length; a++)
                {
                    if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && array[a].BackgroundImage == CheckerPieceClass.Image_Red && array[i].BackgroundImage == null)
                    {
                        for (int b = 0; b < array.Length; b++)
                        {
                            if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y - 80) && (array[b].BackgroundImage == CheckerPieceClass.Image_Black || array[b].BackgroundImage == CheckerPieceClass.Image_King_Black))
                            {
                                for (int c = 0; c < array.Length; c++)
                                {
                                    if ((array[i].Location == new Point(array[c].Location.X - 80, array[c].Location.Y + 80) || array[i].Location == new Point(array[c].Location.X + 80, array[c].Location.Y + 80)) && array[c].BackgroundImage == CheckerPieceClass.Image_Red)
                                    {
                                        length++;
                                    }
                                }
                            }
                        }
                    }
                    if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && array[a].BackgroundImage == CheckerPieceClass.Image_Red && array[i].BackgroundImage == null)
                    {
                        for (int b = 0; b < array.Length; b++)
                        {
                            if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y - 80) && (array[b].BackgroundImage == CheckerPieceClass.Image_Black || array[b].BackgroundImage == CheckerPieceClass.Image_King_Black))
                            {
                                for (int c = 0; c < array.Length; c++)
                                {
                                    if ((array[i].Location == new Point(array[c].Location.X + 80, array[c].Location.Y + 80) || array[i].Location == new Point(array[c].Location.X - 80, array[c].Location.Y + 80)) && array[c].BackgroundImage == CheckerPieceClass.Image_Red)
                                    {
                                        length++;
                                    }
                                }
                            }
                        }
                    }
                    if (array[i].BackgroundImage == Image_King_Red)
                    {
                        if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y + 80) && array[a].BackgroundImage == CheckerPieceClass.Image_Red && array[i].BackgroundImage == null)
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y + 80) && (array[b].BackgroundImage == CheckerPieceClass.Image_Black || array[b].BackgroundImage == CheckerPieceClass.Image_King_Black))
                                {
                                    for (int c = 0; c < array.Length; c++)
                                    {
                                        if ((array[i].Location == new Point(array[c].Location.X + 80, array[c].Location.Y - 80) || array[i].Location == new Point(array[c].Location.X - 80, array[c].Location.Y - 80)) && array[c].BackgroundImage == CheckerPieceClass.Image_Red)
                                        {
                                            length++;
                                        }
                                    }
                                }
                            }
                        }
                        if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y + 80) && array[a].BackgroundImage == CheckerPieceClass.Image_Red && array[i].BackgroundImage == null)
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y + 80) && (array[b].BackgroundImage == CheckerPieceClass.Image_Black || array[b].BackgroundImage == CheckerPieceClass.Image_King_Black))
                                {
                                    for (int c = 0; c < array.Length; c++)
                                    {
                                        if ((array[i].Location == new Point(array[c].Location.X + 80, array[c].Location.Y - 80) || array[i].Location == new Point(array[c].Location.X - 80, array[c].Location.Y - 80)) && array[c].BackgroundImage == CheckerPieceClass.Image_Red)
                                        {
                                            length++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Button[] array1 = new Button[length];
            if (length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int a = 0; a < array.Length; a++)
                    {
                        if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && array[a].BackgroundImage == CheckerPieceClass.Image_Red && array[i].BackgroundImage == null)
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y - 80) && (array[b].BackgroundImage == CheckerPieceClass.Image_Black || array[b].BackgroundImage == CheckerPieceClass.Image_King_Black))
                                {
                                    for (int c = 0; c < array.Length; c++)
                                    {
                                        if ((array[i].Location == new Point(array[c].Location.X - 80, array[c].Location.Y + 80) || array[i].Location == new Point(array[c].Location.X + 80, array[c].Location.Y + 80)) && array[c].BackgroundImage == CheckerPieceClass.Image_Red)
                                        {
                                            if (save < length)
                                            {
                                                array1[save] = array[i];
                                                save++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && array[a].BackgroundImage == CheckerPieceClass.Image_Red && array[i].BackgroundImage == null)
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y - 80) && (array[b].BackgroundImage == CheckerPieceClass.Image_Black || array[b].BackgroundImage == CheckerPieceClass.Image_King_Black))
                                {
                                    for (int c = 0; c < array.Length; c++)
                                    {
                                        if ((array[i].Location == new Point(array[c].Location.X + 80, array[c].Location.Y + 80) || array[i].Location == new Point(array[c].Location.X - 80, array[c].Location.Y + 80)) && array[c].BackgroundImage == CheckerPieceClass.Image_Red)
                                        {
                                            if (save < length)
                                            {
                                                array1[save] = array[i];
                                                save++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (array[i].BackgroundImage == Image_King_Red)
                        {
                            if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y + 80) && array[a].BackgroundImage == CheckerPieceClass.Image_Red && array[i].BackgroundImage == null)
                            {
                                for (int b = 0; b < array.Length; b++)
                                {
                                    if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y + 80) && (array[b].BackgroundImage == CheckerPieceClass.Image_Black || array[b].BackgroundImage == CheckerPieceClass.Image_King_Black))
                                    {
                                        for (int c = 0; c < array.Length; c++)
                                        {
                                            if ((array[i].Location == new Point(array[c].Location.X + 80, array[c].Location.Y - 80) || array[i].Location == new Point(array[c].Location.X - 80, array[c].Location.Y - 80)) && array[c].BackgroundImage == CheckerPieceClass.Image_Red)
                                            {
                                                length++;
                                            }
                                        }
                                    }
                                }
                            }
                            if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y + 80) && array[a].BackgroundImage == CheckerPieceClass.Image_Red && array[i].BackgroundImage == null)
                            {
                                for (int b = 0; b < array.Length; b++)
                                {
                                    if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y + 80) && (array[b].BackgroundImage == CheckerPieceClass.Image_Black || array[b].BackgroundImage == CheckerPieceClass.Image_King_Black))
                                    {
                                        for (int c = 0; c < array.Length; c++)
                                        {
                                            if ((array[i].Location == new Point(array[c].Location.X + 80, array[c].Location.Y - 80) || array[i].Location == new Point(array[c].Location.X - 80, array[c].Location.Y - 80)) && array[c].BackgroundImage == CheckerPieceClass.Image_Red)
                                            {
                                                length++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            save--;
            if (length == 0)
            {
                AINorm(array);
            }
            else if (length != 0)
            {
                length = num.Next(save);         
                for (int c = 0; c < array.Length; c++)
                {
                   if ((array1[length].Location == new Point(array[c].Location.X - 80, array[c].Location.Y + 80) || array1[length].Location == new Point(array[c].Location.X + 80, array[c].Location.Y + 80)) && array[c].BackgroundImage == CheckerPieceClass.Image_Red)
                   {
                      if (CheckerPieceClass.turn == false)
                      {
                          Move(ref array1[length], ref array[c]);
                          turn = true;
                          break;
                      }
                   }
                   else if ((array1[length].Location == new Point(array[c].Location.X - 80, array[c].Location.Y - 80) || array1[length].Location == new Point(array[c].Location.X + 80, array[c].Location.Y - 80)) && array[c].BackgroundImage == CheckerPieceClass.Image_King_Red)
                   {
                        if (CheckerPieceClass.turn == false)
                        {
                            Move(ref array1[length], ref array[c]);
                            turn = true;
                            break;
                        }
                   }            
                }
            }
        }
    }
}
