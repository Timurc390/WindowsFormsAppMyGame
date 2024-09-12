using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMyGame
{
    internal class Player
    {
        public int positionX;
        public int positionY;
        public float Health;
        public int Coins;
        public bool IsAlive;
        public int MovesLeft;
        public float Damage;
        public float WeaponDamaged;
        public float ArmorHealth;
        public int Keys;
        public bool OnBlocked;
        public Image PlayerImage;
        public Player(int x, int y)
        {
            this.positionX = x;
            this.positionY = y;
            this.Health = 50;
            this.Coins = 0;
            IsAlive = true;
            this.MovesLeft = 1;
            this.Damage = 10;
            this.WeaponDamaged = 5;
            this.ArmorHealth = 15;
            this.Keys = 0;
            this.PlayerImage = SpritesBody.Player;
        }

        public void Spawn(PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;

            graphics.DrawImage(PlayerImage, positionX, positionY, 100, 100);
        }

        public void MoveRight()
        {
            if (positionX < 700) 
            {
                positionX += 100;
            }
            else { MessageBox.Show("You can't move right!"); }
        }
        public void MoveLeft()
        {
            if (positionX != 0)
            {
                positionX -= 100;
            }
            else { MessageBox.Show("You can't move left!"); }
        }
        public void MoveUp()
        {
            if (positionY > 0) { positionY -= 100; }
            else { MessageBox.Show("You can't move up!"); }
        }
        public void MoveDown()
        {
            if (positionY < 700) { positionY += 100; }
            else { MessageBox.Show("You can't move down!"); }
        }
    }
}
