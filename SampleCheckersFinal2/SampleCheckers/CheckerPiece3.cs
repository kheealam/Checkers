﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class CheckerPiece
    {
        
        //FIELDS:
        private bool checkOwner;
        public static Image Image_Black=Image.FromFile(@"d:\Pieces_Black.png");
        public static Image Image_Red = Image.FromFile(@"d:\Pieces_Red.png");
        public static Image Image_King_Black = Image.FromFile(@"d:\King_Black.png");
        public static Image Image_King_Red = Image.FromFile(@"d:\King_Red.png");
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

        //(3)a Checks the X-axis of the location of piece.

        public int LocationX(Button button)
        {
            int x;
            x = button.Location.X;
            return x;
        }
        
        //(3)b Checks the Y-axis of the location of piece.

        public int LocationY(Button button)
        {
            int y;
            y = button.Location.Y;
            return y;
        }
        
        //(4) Checks whether the piece is King or Not.

        public bool IsKing(Button button)
        {
            bool king;
            king = (button.BackgroundImage == Image_King_Black) ? true : false;
            return king;
        }

        public void Loop(Button[] array,Button global,Button local,CheckerPiece piece)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                if(global.Location==new Point(local.Location.X-80,local.Location.Y+80))
                {
                    if (local.Location.X + 80 <= 400 && local.Location.X + 80 >= 0 && local.Location.Y - 80 <= 200 && local.Location.Y - 80 >= 0)
                    {
                        if (array[i].Location == new Point(local.Location.X + 80, local.Location.Y - 80) && piece.IsEmpty(array[i]) == true)
                        {
                            CheckerPiece.Move(ref array[i], ref global);
                            local.BackgroundImage = null;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (global.Location == new Point(local.Location.X + 80, local.Location.Y - 80))
                {
                    if (global.BackgroundImage == CheckerPiece.Image_King_Black)
                    {
                        if (local.Location.X - 80 <= 400 && local.Location.X - 80 >= 0 && local.Location.Y + 80 <= 200 && local.Location.Y + 80 >= 0)
                        {
                            if (array[i].Location == new Point(local.Location.X - 80, local.Location.Y + 80) && piece.IsEmpty(array[i]) == true)
                            {
                                CheckerPiece.Move(ref array[i], ref global);
                                local.BackgroundImage = null;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
                else if (global.Location == new Point(local.Location.X + 80, local.Location.Y + 80))
                {
                    if (local.Location.X - 80 <= 400 && local.Location.X - 80 >= 0 && local.Location.Y - 80 <= 200 && local.Location.Y - 80 >= 0)
                    {
                        if (array[i].Location == new Point(local.Location.X - 80, local.Location.Y + 80) && piece.IsEmpty(array[i]) == true)
                        {
                            CheckerPiece.Move(ref array[i], ref global);
                            local.BackgroundImage = null;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

            }
        }
        public static void Move(ref Button a, ref Button b)
        {
            Image temp1, temp2;
            temp1 = a.BackgroundImage;
            temp2 = b.BackgroundImage;
            a.BackgroundImage = temp2;
            b.BackgroundImage = temp1;
        }
    }
}