using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMyGame
{
    internal class Key
    {
        public int PositionX;
        public int PositionY;
        public bool IsCollected;
        public Image KeyImage;

        public Key(int x, int y)
        {
            PositionX = x;
            PositionY = y;
            IsCollected = false;
            KeyImage = SpritesThing.key;
        }

        public void Spawn(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(KeyImage, PositionX, PositionY, 100, 100);
        }
    }
}
