using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMyGame
{
    internal class Chest
    {
        public int PositionX;
        public int PositionY;
        public bool IsOpened;
        public int Coins;        
        public Image ChestImage;

        public Chest(int x, int y, int coins)
        {
            PositionX = x;
            PositionY = y;
            IsOpened = false;
            Coins = coins;
            ChestImage = SpritesThing.ChestClosed;
        }

        public void Spawn(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(ChestImage, PositionX, PositionY, 100, 100);
        }
    }
}
