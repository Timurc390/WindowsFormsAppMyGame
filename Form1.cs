using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMyGame
{
    public partial class Form1 : Form
    {
        LevelSpawn Level;
        Player Player = new Player(0, 700);
        SafeRoom room = new SafeRoom();

        private int NewLevelHealthCost;
        private int NewLevelDamageCost;
        private int NewLevelArmorCost;
        private int NewLevelWeaponCost;

        public float DataHealth = 50;

        private bool GameOn;
        private bool PlayerMovebel;
        public Form1()
        {
            InitializeComponent();
            Init();

            this.KeyPreview = true;
            this.Focus();
        }

        private void Init()
        {
            Player.Coins = 300;
            Level = new LevelSpawn();

            NewLevelHealthCost = 3;
            NewLevelDamageCost = 3;
            NewLevelArmorCost = 3;
            NewLevelWeaponCost = 3;

            labelplayerLevelHealth.Text = ("Health - " + room.playerLevelHealth.ToString());
            labelHealth.Text = ("Health - " + Player.Health.ToString());

            labelplayerLevelDamage.Text = ("Damage - " + room.playerLevelDamage.ToString());
            labelDamage.Text = "Damage - " + Player.Damage.ToString();

            labelplayerLevelArmor.Text = ("Armor - " + room.playerLevelArmor.ToString());
            labelArmor.Text = "Armor - " + Player.ArmorHealth.ToString();

            labelplayerLevelWeapon.Text = ("Weapon - " + room.playerLevelWeapon.ToString());
            labelWeaponDamage.Text = "Weapon Damage - " + Player.WeaponDamaged.ToString();

            labelCoins.Text = "Coins - " + Player.Coins.ToString();

            labelCostHealth.Text = "Cost - " + NewLevelHealthCost.ToString();
            labelCostDamage.Text = "Cost - " + NewLevelDamageCost.ToString();
            labelCostArmor.Text = "Cost - " + NewLevelArmorCost.ToString();
            labelCostWeapon.Text = "Cost - " + NewLevelWeaponCost.ToString();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Player.positionX = 0; Player.positionY = 700;

            buttonStart.Enabled = false;

            buttonRestart.Enabled = true;

            Player.IsAlive = true;

            GameOn = true;

            Level.Number = 1;
            Level.Enemis = 1;
            Level.Chest = 1;

            Player.Health = DataHealth;

            Invalidate();
        }

        public void PlayerDied()
        {
            GameOn = false;
            
            MessageBox.Show("Game Over!");

            buttonStart.Enabled = true;

            buttonRestart.Enabled = false;

            PlayerMovebel = false;

            Level.Number = 1;

            Player.Health = DataHealth;

            Invalidate();

            LabelApdatedData();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            if (!GameOn) return;

            Graphics graphics = e.Graphics;

            BackGround backGround = new BackGround();

            backGround.SpawnDarkImage(e);
            backGround.SpawnWhiteImage(e);

            Player.Spawn(e);
            
            Level.Spawn(e, !PlayerMovebel, Player);
           
        }

        private void buttonLevelUpHealth_Click(object sender, EventArgs e)
        {
            if (Player.Health < DataHealth) { Player.Health = DataHealth; }

            if (!GameOn && Player.Coins >= NewLevelHealthCost) { 
                Player.Health = room.LevelUpHealth(Player.Health);

                if (Player.Health > DataHealth) {  DataHealth = Player.Health; }

                labelplayerLevelHealth.Text = ("Health - " + room.playerLevelHealth.ToString());

                Player.Coins -= NewLevelHealthCost;

                NewLevelHealthCost = room.playerLevelHealth * 3;
                labelCostHealth.Text = "Cost - " + NewLevelHealthCost.ToString();

                LabelApdatedData();
            }
            else { MessageBox.Show("You need more coins!"); }
            
        }

        private void buttonLevelUpDamage_Click(object sender, EventArgs e)
        {
            if (!GameOn && Player.Coins >= NewLevelDamageCost) { 
                Player.Damage = room.LevelUpDamage(Player.Damage);

                labelplayerLevelDamage.Text = ("Damage - " + room.playerLevelDamage.ToString());

                Player.Coins -= NewLevelDamageCost;

                NewLevelDamageCost = room.playerLevelDamage * 3;
                labelCostDamage.Text = "Cost - " + NewLevelDamageCost.ToString();

                LabelApdatedData();
            }
            else { MessageBox.Show("You need more coins!"); }
        }

        private void buttonLevelUpArmor_Click(object sender, EventArgs e)
        {
            if (!GameOn && Player.Coins >= NewLevelArmorCost)
            {
                Player.ArmorHealth = room.LevelUpArmor(Player.ArmorHealth);

                labelplayerLevelArmor.Text = ("Armor - " + room.playerLevelArmor.ToString());

                Player.Coins -= NewLevelArmorCost;

                NewLevelArmorCost = room.playerLevelArmor * 3;
                labelCostArmor.Text = "Cost - " + NewLevelArmorCost.ToString();

                LabelApdatedData();
            }
            else { MessageBox.Show("You need more coins!"); }
        }

        private void buttonWeapon_Click(object sender, EventArgs e)
        {
            if (!GameOn && Player.Coins >= NewLevelWeaponCost) 
            { 
                Player.WeaponDamaged = room.LevelUpWeapon(Player.WeaponDamaged);

                labelplayerLevelWeapon.Text = ("Weapon - " + room.playerLevelWeapon.ToString());

                Player.Coins -= NewLevelWeaponCost;

                NewLevelWeaponCost = room.playerLevelWeapon * 3;
                labelCostWeapon.Text = "Cost - " + NewLevelWeaponCost.ToString();

                LabelApdatedData();     
            }
            else { MessageBox.Show("You need more coins!"); }


        }
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            if (Player.Health < DataHealth) { Player.Health = DataHealth; }

            buttonRestart.Enabled = false;

            buttonStart.Enabled = true;

            GameOn = false;

            Invalidate();

            labelNumberLevel.Text = "Number of Level - " + Level.Number.ToString();

            LabelApdatedData();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (GameOn && Player.IsAlive)
            {
                PlayerMovebel = true;

                if (e.KeyCode == Keys.W) { Player.MoveUp(); labelEnemis.Text = "W"; }
                else if (e.KeyCode == Keys.S) { Player.MoveDown(); labelEnemis.Text = "S"; }
                else if (e.KeyCode == Keys.A) { Player.MoveLeft(); labelEnemis.Text = "A"; }
                else if (e.KeyCode == Keys.D) { Player.MoveRight(); labelEnemis.Text = "D"; }

                LabelApdatedData();
                Invalidate();

                if (Player.positionX == 700 && Player.positionY == 0)
                {

                    PlayerMovebel = false;

                    Invalidate();
                }
            }
        }

        private void LabelApdatedData()
        {

            labelArmor.Text = "🛡️: " + Player.ArmorHealth.ToString();
            labelCoins.Text = "💰: " + Player.Coins.ToString();
            labelDamage.Text = "💪: " + Player.Damage.ToString();
            labelWeaponDamage.Text = "⚔️: " + Player.WeaponDamaged.ToString();
            labelHealth.Text = "❤️: " + Player.Health.ToString();
            labelKeys.Text = "🗝️: " + Player.Keys.ToString();

            labelNumberLevel.Text = "Number of Level: " + Level.Number.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
