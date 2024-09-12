using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMyGame
{
    internal class LevelSpawn
    {
        public int Number;
        public int Enemis;
        public int Chest;
        public float MaxHelth;
        public float MinHelth;
        public float MaxDamaged;
        public float MinDamaged;
        public int MinCoins;
        public int MaxCoins;
        public const float DifficultyCef = 0.2f;

        public List<(int x, int y)> occupiedCells = new List<(int, int)>();

        public List<Zombie> zombieList = new List<Zombie>();
        public List<Chest> chestList = new List<Chest>();
        public List<Skeloton> skeletonList = new List<Skeloton>();
        public List<Key> keyList = new List<Key>();

        public LevelSpawn()
        {
            Number = 0;
            Enemis = 1;
            Chest = 1;
        }

        public void Spawn(PaintEventArgs e, bool NeedUpdateEnemisAndThing, Player player)
        {
            if (player.positionX == 700 && player.positionY == 0)
            {
                int CountEnemis = 0;
                //player.positionX = 0; player.positionY = 700;
                for(int i = 0; i < zombieList.Count; i++)
                {
                    if (zombieList[i].IsAlive) CountEnemis++;
                }

                for (int i = 0; i < skeletonList.Count; i++) 
                {
                    if (skeletonList[i].IsAlive) CountEnemis++;
                }

                if (CountEnemis == 0) 
                {
                    MessageBox.Show("Level Up!");
                    player.IsAlive = true;
                }
                else { NeedUpdateEnemisAndThing = false; }
            }

            Form1 form1 = new Form1();
            if (NeedUpdateEnemisAndThing)
            {

                Number += 1;
                float LevelDifficulty = Number * DifficultyCef;

                zombieList.Clear();
                skeletonList.Clear();
                chestList.Clear();
                keyList.Clear();

                if ((Number % 5) == 0 && Chest < 4) { Chest += 1; }
                if ((Number % 2) == 0 && Enemis < 9) { Enemis += 1; }

                if (Number > 20)
                {
                    MessageBox.Show("You completed this game!");
                }

                occupiedCells.Clear();

                FindFreeCells();

                for (int i = 1; i <= Enemis; i++)
                {

                    if (ZombieOrSkeleton())
                    {
                        Zombie zombie = new Zombie(RandomHealth(), RandomDamaged(), occupiedCells[i - 1].x, occupiedCells[i - 1].y, RandomCoins());
                        zombieList.Add(zombie);
                        zombie.Spawn(e);
                    }
                    else
                    {
                        Skeloton skeleton = new Skeloton(RandomHealth(), RandomDamaged(), occupiedCells[i - 1].x, occupiedCells[i - 1].y, RandomCoins());
                        skeletonList.Add(skeleton);
                        skeleton.Spawn(e);
                    }
                }
                for (int i = Enemis; i < Enemis + Chest; i++)
                {
                    Chest chest = new Chest(occupiedCells[i].x, occupiedCells[i].y, RandomCoins());
                    chestList.Add(chest);
                    chest.Spawn(e);
                }
                for (int i = Enemis + Chest; i < Enemis + (Chest * 2); i++)
                {
                    if (keyList.Count == chestList.Count)
                    {
                        return;
                    }
                    try
                    {
                        Key key = new Key(occupiedCells[i + 1].x, occupiedCells[i + 1].y);
                        keyList.Add(key);
                        key.Spawn(e);
                    }
                    catch { }
                }
            }
            else
            {
                foreach (var zombie in zombieList)
                {
                    if (zombie.IsAlive) zombie.Spawn(e);
                    if (player.positionX == zombie.PositionX && player.positionY == zombie.PositionY && zombie.IsAlive)
                    {
                        zombie.Health -= player.Damage + player.WeaponDamaged;
                        if (zombie.Health <= 0)
                        {
                            player.Coins += zombie.Coins;
                            zombie.IsAlive = false;
                            zombie.ZombieImage = null;
                        }

                        if (player.OnBlocked && player.ArmorHealth >= zombie.Damage)
                        {
                            player.OnBlocked = false;

                            player.ArmorHealth -= zombie.Damage;
                        }
                        else
                        {
                            player.Health -= zombie.Damage;
                            if (player.Health <= 0)
                            {
                                player.IsAlive = false;
                                form1.PlayerDied();
                                return;
                            }
                        }
                    }
                }
                foreach (var chest in chestList)
                {
                    if (player.positionX == chest.PositionX && player.positionY == chest.PositionY && player.Keys > 0 && !chest.IsOpened)
                    {
                        chest.IsOpened = true;
                        player.Keys--;
                        player.Coins += chest.Coins;
                        chest.ChestImage = SpritesThing.ChestOpened;
                    }
                    chest.Spawn(e);
                }
                foreach (var skeleton in skeletonList)
                {
                    if (skeleton.IsAlive) { skeleton.Spawn(e); }
                    if (skeleton.PositionX == player.positionX && skeleton.PositionY == player.positionY && skeleton.IsAlive)
                    {
                        skeleton.Health -= player.Damage + player.WeaponDamaged;

                        if (player.OnBlocked && player.ArmorHealth >= skeleton.Damage)
                        {
                            player.OnBlocked = false;

                            player.ArmorHealth -= skeleton.Damage;
                        }
                        else
                        {
                            player.Health -= skeleton.Damage;
                            if (player.Health <= 0)
                            {
                                player.IsAlive = false;
                                form1.PlayerDied();
                                return;
                            }
                        }
                        if (skeleton.Health <= 0)
                        {
                            player.Coins += skeleton.Coins;
                            skeleton.SkeletonImage = null;
                            skeleton.IsAlive = false;
                        }
                    }
                }
                foreach (var key in keyList)
                {
                    if (!key.IsCollected) { key.Spawn(e); }
                    if (player.positionX == key.PositionX && player.positionY == key.PositionY && !key.IsCollected)
                    {
                        player.Keys++;
                        key.IsCollected = true;
                        key.KeyImage = null;
                    }
                }

            }
        }

        public bool ZombieOrSkeleton()
        {
            Random random = new Random();
            bool randomBool = random.Next(2) == 1;

            return randomBool;
        }

        public float RandomHealth()
        {
            MinHelth = DifficultyCef * Number * 40;
            MaxHelth = (DifficultyCef * Number * 40) + 15;

            Random random = new Random();
            float randomHealth = (float)random.NextDouble() * (MaxHelth - MinHelth) + MinHelth;

            return randomHealth;
        }

        public float RandomDamaged()
        {
            MinDamaged = DifficultyCef * Number * 30;
            MaxDamaged = (DifficultyCef * Number * 30) + 13;

            Random random = new Random();
            float randomDamaged = (float)random.NextDouble() * (MaxDamaged - MinDamaged) + MinDamaged;

            return randomDamaged;
        }

        public int RandomCoins()
        {
            MinCoins = Number * 5;
            MaxCoins = (Number * 5) + 10;

            Random random = new Random();
            int randomCoins = random.Next(MinCoins, MaxCoins);

            return randomCoins;
        }

        public void FindFreeCells()
        {
            Random random = new Random();

            while (true)
            {
                int iTemp = random.Next(0, 8) * 100;
                int jTemp = random.Next(0, 8) * 100;

                if (!occupiedCells.Contains((iTemp, jTemp)) && !occupiedCells.Contains((iTemp + 100, jTemp))
                 && !occupiedCells.Contains((iTemp, jTemp + 100)) && !occupiedCells.Contains((iTemp - 100, jTemp))
                 && !occupiedCells.Contains((iTemp, jTemp - 100)))
                {
                    if ((iTemp != 0 && jTemp != 700) || (iTemp != 700 && jTemp != 0))
                    {
                        occupiedCells.Add((iTemp, jTemp));
                    }
                }

                if (occupiedCells.Count >= 16)
                {
                    break;
                }
            }
        }
    }
}
