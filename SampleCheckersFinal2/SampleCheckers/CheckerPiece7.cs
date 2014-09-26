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
                                        SoundPlayer king = new SoundPlayer(@"d:\Checker_Images\trumpet.wav");
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
                                        SoundPlayer moveSC = new SoundPlayer(@"d:\Checker_Images\button-21.wav");
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
                                else
                                {
                                    break;
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
                                        SoundPlayer king = new SoundPlayer(@"d:\Checker_Images\trumpet.wav");
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
                                        SoundPlayer moveSC = new SoundPlayer(@"d:\Checker_Images\button-21.wav");
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
                                else
                                {
                                    break;
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
                                        SoundPlayer king = new SoundPlayer(@"d:\Checker_Images\trumpet.wav");
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
                                        SoundPlayer moveSC = new SoundPlayer(@"d:\Checker_Images\button-21.wav");
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
                                else
                                {
                                    break;
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
                                     SoundPlayer king = new SoundPlayer(@"d:\Checker_Images\trumpet.wav");
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
                                     SoundPlayer moveSC = new SoundPlayer(@"d:\Checker_Images\button-21.wav");
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
                             else
                             {
                                 break;
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
                    SoundPlayer king = new SoundPlayer(@"d:\Checker_Images\trumpet.wav");
                    king.Play();
                    global.BackgroundImage = CheckerPiece.Image_King_Black;
                    CheckerPiece.Move(ref global, ref local);
                    if (CheckerPiece.turn == true)
                    {
                        CheckerPiece.turn = false;
                    }
                    else if (CheckerPiece.turn == false)
                    {
                        CheckerPiece.turn = true;
                    }
                }
                else if (global.BackgroundImage == CheckerPiece.Image_King_Red || global.BackgroundImage == CheckerPiece.Image_Black || global.BackgroundImage == CheckerPiece.Image_King_Black)
                {
                    SoundPlayer moveS = new SoundPlayer(@"d:\Checker_Images\button-47.wav");
                    moveS.Play();
                    CheckerPiece.Move(ref global, ref local);
                    if (CheckerPiece.turn == true)
                    {
                        CheckerPiece.turn = false;
                    }
                    else if (CheckerPiece.turn == false)
                    {
                        CheckerPiece.turn = true;
                    }
                }
            }
            else if (global.Location == new Point(local.Location.X - 80, local.Location.Y - 80) || global.Location == new Point(local.Location.X + 80, local.Location.Y - 80))
            {
                if (local.Location.Y == 610 && global.BackgroundImage == CheckerPiece.Image_Red)
                {
                    SoundPlayer king = new SoundPlayer(@"d:\Checker_Images\trumpet.wav");
                    king.Play();
                    global.BackgroundImage = CheckerPiece.Image_King_Red;
                    CheckerPiece.Move(ref global, ref local);
                    if (CheckerPiece.turn == true)
                    {
                        CheckerPiece.turn = false;
                    }
                    else if (CheckerPiece.turn == false)
                    {
                        CheckerPiece.turn = true;
                    }
                }
                else if (global.BackgroundImage == CheckerPiece.Image_King_Black || global.BackgroundImage == CheckerPiece.Image_Red || global.BackgroundImage == CheckerPiece.Image_King_Red)
                {
                    SoundPlayer moveS = new SoundPlayer(@"d:\Checker_Images\button-47.wav");
                    moveS.Play();
                    CheckerPiece.Move(ref global, ref local);
                    if (CheckerPiece.turn == true)
                    {
                        CheckerPiece.turn = false;
                    }
                    else if (CheckerPiece.turn == false)
                    {
                        CheckerPiece.turn = true;
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
    }
}
