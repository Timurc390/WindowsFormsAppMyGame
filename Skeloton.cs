using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMyGame
{
    internal class Skeloton
    {
        public float Health;
        public float Damage;
        public int PositionX;
        public int PositionY;
        public int Coins;
        public bool IsAlive;
        public Image SkeletonImage;

        public Skeloton(float health, float damage, int positionX, int positionY, int coins)
        {
            this.Health = health;
            this.Damage = damage;
            this.PositionX = positionX;
            this.PositionY = positionY;
            IsAlive = true;
            this.SkeletonImage = SpritesBody.Skeleton;
            Coins = coins;
        }

        public void Spawn(PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;

            graphics.DrawImage(SkeletonImage, PositionX, PositionY, 100, 100);
        }
    }
}
