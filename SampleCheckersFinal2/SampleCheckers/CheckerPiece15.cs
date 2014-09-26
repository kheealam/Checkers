using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace WindowsFormsApplication1
{
    class CheckerPiece
    {
        
        //FIELDS:
        
        private bool checkOwner;
        public static Image Image_Black = Image.FromFile(@"d:\Checker_Images\Pieces_Black2.png");
        public static Image Image_Red = Image.FromFile(@"d:\Checker_Images\Pieces_Red2.png");
        public static Image Image_King_Black = Image.FromFile(@"d:\Checker_Images\King_Black2.png");
        public static Image Image_King_Red = Image.FromFile(@"d:\Checker_Images\King_Red2.png");
        public static SoundPlayer king = new SoundPlayer(@"d:\Checker_Images\trumpet.wav");
        public static SoundPlayer moveS = new SoundPlayer(@"d:\Checker_Images\button-47.wav");
        public static SoundPlayer moveSC = new SoundPlayer(@"d:\Checker_Images\button-21.wav");
        public static int CapRedPieces=0;
        public static int CapBlackPieces=0;
        public static bool turn=true;
        

        //METHODS:
        
        //(1) Checks whether the piece is Present or Not.

        public bool IsEmpty(Button button)
        {
            bool checkImage;
            checkImage = (button.BackgroundImage==null) ? true : false;
            return checkImage;
        }

        //(2) Checks whether the piece is Our or Not.
        
        public bool IsOur(Button button)
        {
            Names name = new Names();
            if (name.radioButton1.Checked==true)
            {
                checkOwner = (button.BackgroundImage == Image_Black || button.BackgroundImage == Image_King_Black) ? true : false;
                return checkOwner;
            }
            else
            {
                if (turn == true)
                {
                    checkOwner = (button.BackgroundImage == Image_Black || button.BackgroundImage == Image_King_Black) ? true : false;
                }
                else if (turn == false)
                {
                    checkOwner = (button.BackgroundImage == Image_Red || button.BackgroundImage == Image_King_Red) ? true : false;
                }
                return checkOwner;
            }
        }
        
        //(3) Checks whether the piece is King or Not.

        public bool IsKing(Button button)
        {
            bool king;
            king = (button.BackgroundImage == Image_King_Black) ? true : false;
            return king;
        }

        //(4)Checks Whether the box after the Enemy's Piece is Empty or Not.

        public void Loop(Button[] array,Button global,Button local,CheckerPiece piece,ref Label lable1,ref Label lable2)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(global.Location==new Point(local.Location.X-80,local.Location.Y+80))
                {
                    if (global.BackgroundImage == CheckerPiece.Image_King_Black || global.BackgroundImage == CheckerPiece.Image_Black || global.BackgroundImage == CheckerPiece.Image_King_Red)
                    {   
                          if (array[i].Location == new Point(local.Location.X + 80, local.Location.Y - 80))
                          {
                              if (piece.IsEmpty(array[i]) == true)
                              {
                                    if (array[i].Location.Y == 50 && global.BackgroundImage == CheckerPiece.Image_Black)
                                    {
                                        king.Play();
                                        global.BackgroundImage = CheckerPiece.Image_King_Black;
                                        CheckerPiece.Move(ref array[i], ref global);
                                        local.BackgroundImage = null;
                                        if (CheckerPiece.turn == true)
                                        {
                                            CapRedPieces += 1;
                                            lable1.Text = Convert.ToString(CapRedPieces);
                                            CheckerPiece.turn = false;
                                            global.FlatAppearance.BorderColor = Color.Black;
                                        }
                                        else if (CheckerPiece.turn == false)
                                        {
                                            CapBlackPieces += 1;
                                            lable2.Text = Convert.ToString(CapBlackPieces);
                                            CheckerPiece.turn = true;
                                        }
                                    }
                                    else
                                    {
                                        
                                        moveSC.Play();
                                        CheckerPiece.Move(ref array[i], ref global);
                                        local.BackgroundImage = null;
                                        if (CheckerPiece.turn == true)
                                        {
                                            CapRedPieces += 1;
                                            lable1.Text = Convert.ToString(CapRedPieces);
                                            CheckerPiece.turn = false;
                                        }
                                        else if (CheckerPiece.turn == false)
                                        {
                                            CapBlackPieces += 1;
                                            lable2.Text = Convert.ToString(CapBlackPieces);
                                            CheckerPiece.turn = true;
                                        }
                                        break;
                                    }
                                }
                            }   
                    }
                }
                else if (global.Location == new Point(local.Location.X + 80, local.Location.Y - 80))
                {
                    if (global.BackgroundImage == CheckerPiece.Image_King_Black || global.BackgroundImage==CheckerPiece.Image_Red || global.BackgroundImage==CheckerPiece.Image_King_Red)
                    {
                            if (array[i].Location == new Point(local.Location.X - 80, local.Location.Y + 80))
                            {
                                if (piece.IsEmpty(array[i]) == true)
                                {
                                    if (array[i].Location.Y == 610 && global.BackgroundImage == CheckerPiece.Image_Red)
                                    {
                                        king.Play();
                                        global.BackgroundImage = CheckerPiece.Image_King_Red;
                                        CheckerPiece.Move(ref array[i], ref global);
                                        local.BackgroundImage = null;
                                        if (CheckerPiece.turn == true)
                                        {
                                            CapRedPieces += 1;
                                            lable1.Text = Convert.ToString(CapRedPieces);
                                            CheckerPiece.turn = false;
                                        }
                                        else if (CheckerPiece.turn == false)
                                        {
                                            CapBlackPieces += 1;
                                            lable2.Text = Convert.ToString(CapBlackPieces);
                                            CheckerPiece.turn = true;
                                        }
                                    }
                                    else
                                    {
                                        moveSC.Play();
                                        CheckerPiece.Move(ref array[i], ref global);
                                        local.BackgroundImage = null;
                                        if (CheckerPiece.turn == true)
                                        {
                                            CapRedPieces += 1;
                                            lable1.Text = Convert.ToString(CapRedPieces);
                                            CheckerPiece.turn = false;
                                        }
                                        else if (CheckerPiece.turn == false)
                                        {
                                            CapBlackPieces += 1;
                                            lable2.Text = Convert.ToString(CapBlackPieces);
                                            CheckerPiece.turn = true;
                                        }
                                        break;
                                    }
                                }
                            }
                    }
                }
                else if (global.Location == new Point(local.Location.X + 80, local.Location.Y + 80))
                {
                    if (global.BackgroundImage == CheckerPiece.Image_King_Black || global.BackgroundImage == CheckerPiece.Image_Black || global.BackgroundImage == CheckerPiece.Image_King_Red)
                    {
                            if (array[i].Location == new Point(local.Location.X - 80, local.Location.Y - 80))
                            {
                                if (piece.IsEmpty(array[i]) == true)
                                {
                                    if (array[i].Location.Y == 50 && global.BackgroundImage == CheckerPiece.Image_Black)
                                    {
                                        king.Play();
                                        global.BackgroundImage = CheckerPiece.Image_King_Black;
                                        CheckerPiece.Move(ref array[i], ref global);
                                        local.BackgroundImage = null;
                                        if (CheckerPiece.turn == true)
                                        {
                                            CapRedPieces += 1;
                                            lable1.Text = Convert.ToString(CapRedPieces);
                                            CheckerPiece.turn = false;
                                        }
                                        else if (CheckerPiece.turn == false)
                                        {
                                            CapBlackPieces += 1;
                                            lable2.Text = Convert.ToString(CapBlackPieces);
                                            CheckerPiece.turn = true;
                                        }
                                    }
                                    else
                                    {
                                        moveSC.Play();
                                        CheckerPiece.Move(ref array[i], ref global);
                                        local.BackgroundImage = null;
                                        if (CheckerPiece.turn == true)
                                        {
                                            CapRedPieces += 1;
                                            lable1.Text = Convert.ToString(CapRedPieces);
                                            CheckerPiece.turn = false;
                                        }
                                        else if (CheckerPiece.turn == false)
                                        {
                                            CapBlackPieces += 1;
                                            lable2.Text = Convert.ToString(CapBlackPieces);
                                            CheckerPiece.turn = true;
                                        }
                                        break;
                                    }
                                }
                            }
                    }
                }
                else if (global.Location == new Point(local.Location.X - 80, local.Location.Y - 80))
                {
                    if (global.BackgroundImage == CheckerPiece.Image_King_Black || global.BackgroundImage==CheckerPiece.Image_Red || global.BackgroundImage==CheckerPiece.Image_King_Red)
                    {              
                         if (array[i].Location == new Point(local.Location.X + 80, local.Location.Y + 80))
                         {
                             if (piece.IsEmpty(array[i]) == true)
                             {
                                 if (array[i].Location.Y == 610 && global.BackgroundImage == CheckerPiece.Image_Red)
                                 {
                                     king.Play();
                                     global.BackgroundImage = CheckerPiece.Image_King_Red;
                                     CheckerPiece.Move(ref array[i], ref global);
                                     local.BackgroundImage = null;
                                     if (CheckerPiece.turn == true)
                                     {
                                         CapRedPieces += 1;
                                         lable1.Text = Convert.ToString(CapRedPieces);
                                         CheckerPiece.turn = false;
                                     }
                                     else if (CheckerPiece.turn == false)
                                     {
                                         CapBlackPieces += 1;
                                         lable2.Text = Convert.ToString(CapBlackPieces);
                                         CheckerPiece.turn = true;
                                     }
                                 }
                                 else
                                 {
                                     moveSC.Play();
                                     CheckerPiece.Move(ref array[i], ref global);
                                     local.BackgroundImage = null;
                                     if (CheckerPiece.turn == true)
                                     {
                                         CapRedPieces += 1;
                                         lable1.Text = Convert.ToString(CapRedPieces);
                                         CheckerPiece.turn = false;
                                     }
                                     else if (CheckerPiece.turn == false)
                                     {
                                         CapBlackPieces += 1;
                                         lable2.Text = Convert.ToString(CapBlackPieces);
                                         CheckerPiece.turn = true;
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
            if (global.Location == new Point(local.Location.X + 80, local.Location.Y + 80) || global.Location == new Point(local.Location.X - 80, local.Location.Y + 80))
            {
                if (local.Location.Y == 50 && global.BackgroundImage == CheckerPiece.Image_Black)
                {
                    king.Play();
                    global.BackgroundImage = CheckerPiece.Image_King_Black;
                    CheckerPiece.Move(ref global, ref local);
                    if (CheckerPiece.turn == true)
                    {
                        CheckerPiece.turn = false;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                    else if (CheckerPiece.turn == false)
                    {
                        CheckerPiece.turn = true;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                }
                else if (global.BackgroundImage == CheckerPiece.Image_King_Red || global.BackgroundImage == CheckerPiece.Image_Black || global.BackgroundImage == CheckerPiece.Image_King_Black)
                {
                    
                    moveS.Play();
                    CheckerPiece.Move(ref global, ref local);
                    if (CheckerPiece.turn == true)
                    {
                        CheckerPiece.turn = false;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                    else if (CheckerPiece.turn == false)
                    {
                        CheckerPiece.turn = true;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                }
            }
            else if (global.Location == new Point(local.Location.X - 80, local.Location.Y - 80) || global.Location == new Point(local.Location.X + 80, local.Location.Y - 80))
            {
                if (local.Location.Y == 610 && global.BackgroundImage == CheckerPiece.Image_Red)
                {
                    king.Play();
                    global.BackgroundImage = CheckerPiece.Image_King_Red;
                    CheckerPiece.Move(ref global, ref local);
                    if (CheckerPiece.turn == true)
                    {
                        CheckerPiece.turn = false;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                    else if (CheckerPiece.turn == false)
                    {
                        CheckerPiece.turn = true;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                }
                else if (global.BackgroundImage == CheckerPiece.Image_King_Black || global.BackgroundImage == CheckerPiece.Image_Red || global.BackgroundImage == CheckerPiece.Image_King_Red)
                {
                    moveS.Play();
                    CheckerPiece.Move(ref global, ref local);
                    if (CheckerPiece.turn == true)
                    {
                        CheckerPiece.turn = false;
                        global.FlatAppearance.BorderColor = Color.Black;
                    }
                    else if (CheckerPiece.turn == false)
                    {
                        CheckerPiece.turn = true;
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
                if (array[i].BackgroundImage == CheckerPiece.Image_Black || array[i].BackgroundImage == CheckerPiece.Image_King_Black)
                {
                    a = a + 1;
                }
                else if (array[i].BackgroundImage == CheckerPiece.Image_Red || array[i].BackgroundImage == CheckerPiece.Image_King_Red)
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
                MessageBox.Show(f1.label1+" Won");
            }
            else if (b == 0)
            {
                MessageBox.Show(f1.label2+" Won");
            }
        }
        //(8)Its Computer's Main Intelligence;

        public static void AIMain(Button[] array)
        {
            AICapt(array);
            //AISave(array);
            //AINorm(array);
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

                if (array1[length].BackgroundImage == Image_Red || array1[length].BackgroundImage == Image_King_Red)
                {
                    for (int a = 0; a < array.Length; a++)
                    {
                        if ((array1[length].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && array[a].BackgroundImage == null) || array1[length].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && array[a].BackgroundImage == null)
                        {
                            if (CheckerPiece.turn == false)
                            {
                                Move(ref array1[length], ref array[a]);
                                turn = true;
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
                        if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && (array[a].BackgroundImage == CheckerPiece.Image_Black || array[a].BackgroundImage == CheckerPiece.Image_King_Black))
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y - 80) && array[b].BackgroundImage == null)
                                {
                                    length += 1;
                                }
                            }
                        }
                        if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && (array[a].BackgroundImage == CheckerPiece.Image_Black || array[a].BackgroundImage == CheckerPiece.Image_King_Black))
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y - 80) && array[b].BackgroundImage == null)
                                {
                                    length += 1;
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
                            if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && (array[a].BackgroundImage == CheckerPiece.Image_Black || array[a].BackgroundImage == CheckerPiece.Image_King_Black))
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
                            if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && (array[a].BackgroundImage == CheckerPiece.Image_Black || array[a].BackgroundImage == CheckerPiece.Image_King_Black))
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
                        if (array1[length].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && (array[a].BackgroundImage == CheckerPiece.Image_Black || array[a].BackgroundImage == CheckerPiece.Image_King_Black))
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y - 80) && array[b].BackgroundImage == null)
                                {
                                    if (CheckerPiece.turn == false)
                                    {
                                        Move(ref array1[length], ref array[b]);
                                        array[a].BackgroundImage = null;
                                        turn = true;
                                    }
                                }
                            }
                        }
                        else if (array1[length].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && (array[a].BackgroundImage == CheckerPiece.Image_Black || array[a].BackgroundImage == CheckerPiece.Image_King_Black))
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y - 80) && array[b].BackgroundImage == null)
                                {
                                    if (CheckerPiece.turn == false)
                                    {
                                        Move(ref array1[length], ref array[b]);
                                        array[a].BackgroundImage = null;
                                        turn = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        //(9)Its Controls Saving Moves of Computer;

        //Priority: Third;

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
                    if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && array[a].BackgroundImage == CheckerPiece.Image_Red && array[i].BackgroundImage == null)
                    {
                        for (int b = 0; b < array.Length; b++)
                        {
                            if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y - 80) && (array[b].BackgroundImage == CheckerPiece.Image_Black || array[b].BackgroundImage == CheckerPiece.Image_King_Black))
                            {
                                for (int c = 0; c < array.Length; c++)
                                {
                                    if ((array[i].Location == new Point(array[c].Location.X - 80, array[c].Location.Y + 80) || array[i].Location == new Point(array[c].Location.X + 80, array[c].Location.Y + 80)) && array[c].BackgroundImage == CheckerPiece.Image_Red)
                                    {
                                        length++;
                                    }
                                }
                            }
                        }
                    }
                    else if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && array[a].BackgroundImage == CheckerPiece.Image_Red && array[i].BackgroundImage == null)
                    {
                        for (int b = 0; b < array.Length; b++)
                        {
                            if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y - 80) && (array[b].BackgroundImage == CheckerPiece.Image_Black || array[b].BackgroundImage == CheckerPiece.Image_King_Black))
                            {
                                for (int c = 0; c < array.Length; c++)
                                {
                                    if ((array[i].Location == new Point(array[c].Location.X + 80, array[c].Location.Y + 80) || array[i].Location == new Point(array[c].Location.X - 80, array[c].Location.Y + 80)) && array[c].BackgroundImage == CheckerPiece.Image_Red)
                                    {
                                        length++;
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
                        if (array[i].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && array[a].BackgroundImage == CheckerPiece.Image_Red && array[i].BackgroundImage == null)
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y - 80) && (array[b].BackgroundImage == CheckerPiece.Image_Black || array[b].BackgroundImage == CheckerPiece.Image_King_Black))
                                {
                                    for (int c = 0; c < array.Length; c++)
                                    {
                                        if ((array[i].Location == new Point(array[c].Location.X - 80, array[c].Location.Y + 80) || array[i].Location == new Point(array[c].Location.X + 80, array[c].Location.Y + 80)) && array[c].BackgroundImage == CheckerPiece.Image_Red)
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
                        else if (array[i].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && array[a].BackgroundImage == CheckerPiece.Image_Red && array[i].BackgroundImage == null)
                        {
                            for (int b = 0; b < array.Length; b++)
                            {
                                if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y - 80) && (array[b].BackgroundImage == CheckerPiece.Image_Black || array[b].BackgroundImage == CheckerPiece.Image_King_Black))
                                {
                                    for (int c = 0; c < array.Length; c++)
                                    {
                                        if ((array[i].Location == new Point(array[c].Location.X + 80, array[c].Location.Y + 80) || array[i].Location == new Point(array[c].Location.X - 80, array[c].Location.Y + 80)) && array[c].BackgroundImage == CheckerPiece.Image_Red)
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
                for (int a = 0; a < array.Length; a++)
                {
                    if (array1[length].Location == new Point(array[a].Location.X - 80, array[a].Location.Y - 80) && array[a].BackgroundImage == CheckerPiece.Image_Red)
                    {
                        for (int b = 0; b < array.Length; b++)
                        {
                            if (array[a].Location == new Point(array[b].Location.X - 80, array[b].Location.Y - 80) && (array[b].BackgroundImage == CheckerPiece.Image_Black || array[b].BackgroundImage == CheckerPiece.Image_King_Black))
                            {
                                for (int c = 0; c < array.Length; c++)
                                {
                                    if (array1[length].Location == new Point(array[c].Location.X - 80, array[c].Location.Y + 80) && array[c].BackgroundImage == CheckerPiece.Image_Red)
                                    {
                                        if (CheckerPiece.turn == false)
                                        {
                                            Move(ref array1[length], ref array[c]);
                                            turn = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (array1[length].Location == new Point(array[a].Location.X + 80, array[a].Location.Y - 80) && array[a].BackgroundImage == CheckerPiece.Image_Red)
                    {
                        for (int b = 0; b < array.Length; b++)
                        {
                            if (array[a].Location == new Point(array[b].Location.X + 80, array[b].Location.Y - 80) && (array[b].BackgroundImage == CheckerPiece.Image_Black || array[b].BackgroundImage == CheckerPiece.Image_King_Black))
                            {
                                for (int c = 0; c < array.Length; c++)
                                {
                                    if (array1[length].Location == new Point(array[c].Location.X + 80, array[c].Location.Y + 80) && array[c].BackgroundImage == CheckerPiece.Image_Red)
                                    {
                                        if (CheckerPiece.turn == false)
                                        {
                                            Move(ref array1[length], ref array[c]);
                                            turn = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
