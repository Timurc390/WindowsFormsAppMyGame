using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppMyGame
{
    internal class SafeRoom
    {
        public int playerLevelHealth;
        public int playerLevelDamage;
        public int playerLevelArmor;
        public int playerLevelWeapon;

        public const float playerNewLevelCef = 0.15f;

        //public SafeRoom()
        //{
        //    this.playerLevelHealth = 1;
        //    this.playerLevelDamage = 1;
        //    this.playerLevelArmor = 1;
        //    this.playerLevelWeapon = 1;
        //}

        public float LevelUpHealth(float Health)
        {
            float NewHealth = Health;

            playerLevelHealth++;
            NewHealth = (NewHealth * playerNewLevelCef) + NewHealth;

            return NewHealth;
        }
        public float LevelUpDamage(float Damage)
        {
            float NewDamage = Damage;

            playerLevelDamage++;
            NewDamage = (NewDamage * playerNewLevelCef) + NewDamage;

            return NewDamage;
        }
        public float LevelUpArmor(float Armor)
        {
            float NewArmor = Armor;

            playerLevelArmor++;
            NewArmor = (NewArmor * playerNewLevelCef) + NewArmor;

            return NewArmor;
        }
        public float LevelUpWeapon(float Weapon)
        {
            float NewWeapon = Weapon;

            playerLevelWeapon++;
            NewWeapon = (NewWeapon * playerNewLevelCef) + NewWeapon;

            return NewWeapon;
        }
    }
}
