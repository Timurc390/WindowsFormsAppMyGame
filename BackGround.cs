using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMyGame
{
    internal class BackGround
    {
        public int Size;
        public Image WhiteImage;
        public Image DarkImage;
        public Image ExitImage;

        public BackGround() 
        {
            Size = 100;
            WhiteImage = SpritesThing.White_cell;
            DarkImage = SpritesThing.Dark_cell;
            ExitImage = SpritesThing.Exit;
        }

        public void SpawnDarkImage(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            for (int i = 0; i < 8;  i++)
            {
                for (int j = 0; j < 8; j++)
                {

                    if((j + i) % 2 == 0)
                    {
                        graphics.DrawImage(DarkImage, i * 100, j * 100, Size, Size);
                    }
                }
            }
        }

        public void SpawnWhiteImage(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 7 && j == 0) { graphics.DrawImage(ExitImage, i * 100, j * 100, Size, Size); j++; }

                    if ((j + i) % 2 != 0)
                    {
                        graphics.DrawImage(WhiteImage, i * 100, j * 100, Size, Size);
                    }
                }
            }
        }
    }
}
