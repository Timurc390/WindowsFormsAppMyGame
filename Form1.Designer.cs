namespace WindowsFormsAppMyGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelCoins = new System.Windows.Forms.Label();
            this.labelEnemis = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelDamage = new System.Windows.Forms.Label();
            this.labelWeaponDamage = new System.Windows.Forms.Label();
            this.labelArmor = new System.Windows.Forms.Label();
            this.labelKeys = new System.Windows.Forms.Label();
            this.labelGameStats = new System.Windows.Forms.Label();
            this.labelLevelUp = new System.Windows.Forms.Label();
            this.labelNumberLevel = new System.Windows.Forms.Label();
            this.labelplayerLevelHealth = new System.Windows.Forms.Label();
            this.labelplayerLevelDamage = new System.Windows.Forms.Label();
            this.labelplayerLevelArmor = new System.Windows.Forms.Label();
            this.labelplayerLevelWeapon = new System.Windows.Forms.Label();
            this.labelCostHealth = new System.Windows.Forms.Label();
            this.labelCostDamage = new System.Windows.Forms.Label();
            this.labelCostArmor = new System.Windows.Forms.Label();
            this.labelCostWeapon = new System.Windows.Forms.Label();
            this.buttonLevelUpHealth = new System.Windows.Forms.Button();
            this.buttonLevelUpDamage = new System.Windows.Forms.Button();
            this.buttonLevelUpArmor = new System.Windows.Forms.Button();
            this.buttonWeapon = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.Red;
            this.buttonStart.Location = new System.Drawing.Point(890, 659);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(124, 41);
            this.buttonStart.TabIndex = 65;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.Color.Red;
            this.labelCoins.Location = new System.Drawing.Point(816, 46);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(48, 16);
            this.labelCoins.TabIndex = 66;
            this.labelCoins.Text = "Coins -";
            // 
            // labelEnemis
            // 
            this.labelEnemis.AutoSize = true;
            this.labelEnemis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnemis.ForeColor = System.Drawing.Color.Red;
            this.labelEnemis.Location = new System.Drawing.Point(816, 166);
            this.labelEnemis.Name = "labelEnemis";
            this.labelEnemis.Size = new System.Drawing.Size(125, 16);
            this.labelEnemis.TabIndex = 67;
            this.labelEnemis.Text = "Enemis On Screen -";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHealth.ForeColor = System.Drawing.Color.Red;
            this.labelHealth.Location = new System.Drawing.Point(816, 72);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(53, 16);
            this.labelHealth.TabIndex = 69;
            this.labelHealth.Text = "Health -";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer.ForeColor = System.Drawing.Color.Red;
            this.labelPlayer.Location = new System.Drawing.Point(909, 9);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(74, 24);
            this.labelPlayer.TabIndex = 70;
            this.labelPlayer.Text = "Player:";
            // 
            // labelDamage
            // 
            this.labelDamage.AutoSize = true;
            this.labelDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDamage.ForeColor = System.Drawing.Color.Red;
            this.labelDamage.Location = new System.Drawing.Point(916, 46);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(67, 16);
            this.labelDamage.TabIndex = 71;
            this.labelDamage.Text = "Damage -";
            // 
            // labelWeaponDamage
            // 
            this.labelWeaponDamage.AutoSize = true;
            this.labelWeaponDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeaponDamage.ForeColor = System.Drawing.Color.Red;
            this.labelWeaponDamage.Location = new System.Drawing.Point(916, 72);
            this.labelWeaponDamage.Name = "labelWeaponDamage";
            this.labelWeaponDamage.Size = new System.Drawing.Size(122, 16);
            this.labelWeaponDamage.TabIndex = 72;
            this.labelWeaponDamage.Text = "Weapon Damage -";
            // 
            // labelArmor
            // 
            this.labelArmor.AutoSize = true;
            this.labelArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArmor.ForeColor = System.Drawing.Color.Red;
            this.labelArmor.Location = new System.Drawing.Point(816, 100);
            this.labelArmor.Name = "labelArmor";
            this.labelArmor.Size = new System.Drawing.Size(50, 16);
            this.labelArmor.TabIndex = 73;
            this.labelArmor.Text = "Armor -";
            // 
            // labelKeys
            // 
            this.labelKeys.AutoSize = true;
            this.labelKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKeys.ForeColor = System.Drawing.Color.Red;
            this.labelKeys.Location = new System.Drawing.Point(916, 100);
            this.labelKeys.Name = "labelKeys";
            this.labelKeys.Size = new System.Drawing.Size(47, 16);
            this.labelKeys.TabIndex = 74;
            this.labelKeys.Text = "Keys - ";
            // 
            // labelGameStats
            // 
            this.labelGameStats.AutoSize = true;
            this.labelGameStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameStats.ForeColor = System.Drawing.Color.Red;
            this.labelGameStats.Location = new System.Drawing.Point(886, 133);
            this.labelGameStats.Name = "labelGameStats";
            this.labelGameStats.Size = new System.Drawing.Size(121, 24);
            this.labelGameStats.TabIndex = 75;
            this.labelGameStats.Text = "Game Stats:";
            // 
            // labelLevelUp
            // 
            this.labelLevelUp.AutoSize = true;
            this.labelLevelUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelUp.ForeColor = System.Drawing.Color.Red;
            this.labelLevelUp.Location = new System.Drawing.Point(897, 227);
            this.labelLevelUp.Name = "labelLevelUp";
            this.labelLevelUp.Size = new System.Drawing.Size(98, 24);
            this.labelLevelUp.TabIndex = 78;
            this.labelLevelUp.Text = "Level Up:";
            // 
            // labelNumberLevel
            // 
            this.labelNumberLevel.AutoSize = true;
            this.labelNumberLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberLevel.ForeColor = System.Drawing.Color.Red;
            this.labelNumberLevel.Location = new System.Drawing.Point(816, 198);
            this.labelNumberLevel.Name = "labelNumberLevel";
            this.labelNumberLevel.Size = new System.Drawing.Size(112, 16);
            this.labelNumberLevel.TabIndex = 79;
            this.labelNumberLevel.Text = "Number of Level -";
            // 
            // labelplayerLevelHealth
            // 
            this.labelplayerLevelHealth.AutoSize = true;
            this.labelplayerLevelHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelplayerLevelHealth.ForeColor = System.Drawing.Color.Red;
            this.labelplayerLevelHealth.Location = new System.Drawing.Point(814, 262);
            this.labelplayerLevelHealth.Name = "labelplayerLevelHealth";
            this.labelplayerLevelHealth.Size = new System.Drawing.Size(59, 18);
            this.labelplayerLevelHealth.TabIndex = 80;
            this.labelplayerLevelHealth.Text = "Health -";
            // 
            // labelplayerLevelDamage
            // 
            this.labelplayerLevelDamage.AutoSize = true;
            this.labelplayerLevelDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelplayerLevelDamage.ForeColor = System.Drawing.Color.Red;
            this.labelplayerLevelDamage.Location = new System.Drawing.Point(814, 289);
            this.labelplayerLevelDamage.Name = "labelplayerLevelDamage";
            this.labelplayerLevelDamage.Size = new System.Drawing.Size(73, 18);
            this.labelplayerLevelDamage.TabIndex = 81;
            this.labelplayerLevelDamage.Text = "Damage -";
            // 
            // labelplayerLevelArmor
            // 
            this.labelplayerLevelArmor.AutoSize = true;
            this.labelplayerLevelArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelplayerLevelArmor.ForeColor = System.Drawing.Color.Red;
            this.labelplayerLevelArmor.Location = new System.Drawing.Point(814, 316);
            this.labelplayerLevelArmor.Name = "labelplayerLevelArmor";
            this.labelplayerLevelArmor.Size = new System.Drawing.Size(58, 18);
            this.labelplayerLevelArmor.TabIndex = 82;
            this.labelplayerLevelArmor.Text = "Armor -";
            // 
            // labelplayerLevelWeapon
            // 
            this.labelplayerLevelWeapon.AutoSize = true;
            this.labelplayerLevelWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelplayerLevelWeapon.ForeColor = System.Drawing.Color.Red;
            this.labelplayerLevelWeapon.Location = new System.Drawing.Point(814, 346);
            this.labelplayerLevelWeapon.Name = "labelplayerLevelWeapon";
            this.labelplayerLevelWeapon.Size = new System.Drawing.Size(73, 18);
            this.labelplayerLevelWeapon.TabIndex = 83;
            this.labelplayerLevelWeapon.Text = "Weapon -";
            // 
            // labelCostHealth
            // 
            this.labelCostHealth.AutoSize = true;
            this.labelCostHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostHealth.ForeColor = System.Drawing.Color.Red;
            this.labelCostHealth.Location = new System.Drawing.Point(961, 262);
            this.labelCostHealth.Name = "labelCostHealth";
            this.labelCostHealth.Size = new System.Drawing.Size(49, 18);
            this.labelCostHealth.TabIndex = 84;
            this.labelCostHealth.Text = "Cost -";
            // 
            // labelCostDamage
            // 
            this.labelCostDamage.AutoSize = true;
            this.labelCostDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostDamage.ForeColor = System.Drawing.Color.Red;
            this.labelCostDamage.Location = new System.Drawing.Point(961, 289);
            this.labelCostDamage.Name = "labelCostDamage";
            this.labelCostDamage.Size = new System.Drawing.Size(49, 18);
            this.labelCostDamage.TabIndex = 85;
            this.labelCostDamage.Text = "Cost -";
            // 
            // labelCostArmor
            // 
            this.labelCostArmor.AutoSize = true;
            this.labelCostArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostArmor.ForeColor = System.Drawing.Color.Red;
            this.labelCostArmor.Location = new System.Drawing.Point(961, 316);
            this.labelCostArmor.Name = "labelCostArmor";
            this.labelCostArmor.Size = new System.Drawing.Size(49, 18);
            this.labelCostArmor.TabIndex = 86;
            this.labelCostArmor.Text = "Cost -";
            // 
            // labelCostWeapon
            // 
            this.labelCostWeapon.AutoSize = true;
            this.labelCostWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostWeapon.ForeColor = System.Drawing.Color.Red;
            this.labelCostWeapon.Location = new System.Drawing.Point(961, 346);
            this.labelCostWeapon.Name = "labelCostWeapon";
            this.labelCostWeapon.Size = new System.Drawing.Size(49, 18);
            this.labelCostWeapon.TabIndex = 87;
            this.labelCostWeapon.Text = "Cost -";
            // 
            // buttonLevelUpHealth
            // 
            this.buttonLevelUpHealth.BackColor = System.Drawing.Color.Black;
            this.buttonLevelUpHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevelUpHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLevelUpHealth.ForeColor = System.Drawing.Color.Red;
            this.buttonLevelUpHealth.Location = new System.Drawing.Point(1045, 255);
            this.buttonLevelUpHealth.Name = "buttonLevelUpHealth";
            this.buttonLevelUpHealth.Size = new System.Drawing.Size(25, 25);
            this.buttonLevelUpHealth.TabIndex = 88;
            this.buttonLevelUpHealth.Text = "⬆️";
            this.buttonLevelUpHealth.UseVisualStyleBackColor = false;
            this.buttonLevelUpHealth.Click += new System.EventHandler(this.buttonLevelUpHealth_Click);
            // 
            // buttonLevelUpDamage
            // 
            this.buttonLevelUpDamage.BackColor = System.Drawing.Color.Black;
            this.buttonLevelUpDamage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevelUpDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLevelUpDamage.ForeColor = System.Drawing.Color.Red;
            this.buttonLevelUpDamage.Location = new System.Drawing.Point(1045, 281);
            this.buttonLevelUpDamage.Name = "buttonLevelUpDamage";
            this.buttonLevelUpDamage.Size = new System.Drawing.Size(25, 25);
            this.buttonLevelUpDamage.TabIndex = 89;
            this.buttonLevelUpDamage.Text = "⬆️";
            this.buttonLevelUpDamage.UseVisualStyleBackColor = false;
            this.buttonLevelUpDamage.Click += new System.EventHandler(this.buttonLevelUpDamage_Click);
            // 
            // buttonLevelUpArmor
            // 
            this.buttonLevelUpArmor.BackColor = System.Drawing.Color.Black;
            this.buttonLevelUpArmor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevelUpArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLevelUpArmor.ForeColor = System.Drawing.Color.Red;
            this.buttonLevelUpArmor.Location = new System.Drawing.Point(1045, 309);
            this.buttonLevelUpArmor.Name = "buttonLevelUpArmor";
            this.buttonLevelUpArmor.Size = new System.Drawing.Size(25, 25);
            this.buttonLevelUpArmor.TabIndex = 90;
            this.buttonLevelUpArmor.Text = "⬆️";
            this.buttonLevelUpArmor.UseVisualStyleBackColor = false;
            this.buttonLevelUpArmor.Click += new System.EventHandler(this.buttonLevelUpArmor_Click);
            // 
            // buttonWeapon
            // 
            this.buttonWeapon.BackColor = System.Drawing.Color.Black;
            this.buttonWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWeapon.ForeColor = System.Drawing.Color.Red;
            this.buttonWeapon.Location = new System.Drawing.Point(1045, 339);
            this.buttonWeapon.Name = "buttonWeapon";
            this.buttonWeapon.Size = new System.Drawing.Size(25, 25);
            this.buttonWeapon.TabIndex = 91;
            this.buttonWeapon.Text = "⬆️";
            this.buttonWeapon.UseVisualStyleBackColor = false;
            this.buttonWeapon.Click += new System.EventHandler(this.buttonWeapon_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.ForeColor = System.Drawing.Color.Red;
            this.buttonRestart.Location = new System.Drawing.Point(890, 706);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(124, 41);
            this.buttonRestart.TabIndex = 92;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(890, 753);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(124, 41);
            this.buttonClose.TabIndex = 93;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppMyGame.SpritesThing.Line;
            this.pictureBox1.Location = new System.Drawing.Point(800, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 800);
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1084, 800);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonWeapon);
            this.Controls.Add(this.buttonLevelUpArmor);
            this.Controls.Add(this.buttonLevelUpDamage);
            this.Controls.Add(this.buttonLevelUpHealth);
            this.Controls.Add(this.labelCostWeapon);
            this.Controls.Add(this.labelCostArmor);
            this.Controls.Add(this.labelCostDamage);
            this.Controls.Add(this.labelCostHealth);
            this.Controls.Add(this.labelplayerLevelWeapon);
            this.Controls.Add(this.labelplayerLevelArmor);
            this.Controls.Add(this.labelplayerLevelDamage);
            this.Controls.Add(this.labelplayerLevelHealth);
            this.Controls.Add(this.labelNumberLevel);
            this.Controls.Add(this.labelLevelUp);
            this.Controls.Add(this.labelGameStats);
            this.Controls.Add(this.labelKeys);
            this.Controls.Add(this.labelArmor);
            this.Controls.Add(this.labelWeaponDamage);
            this.Controls.Add(this.labelDamage);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.labelEnemis);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.buttonStart);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 839);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 839);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Label labelEnemis;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.Label labelWeaponDamage;
        private System.Windows.Forms.Label labelArmor;
        private System.Windows.Forms.Label labelKeys;
        private System.Windows.Forms.Label labelGameStats;
        private System.Windows.Forms.Label labelLevelUp;
        private System.Windows.Forms.Label labelNumberLevel;
        private System.Windows.Forms.Label labelplayerLevelHealth;
        private System.Windows.Forms.Label labelplayerLevelDamage;
        private System.Windows.Forms.Label labelplayerLevelArmor;
        private System.Windows.Forms.Label labelplayerLevelWeapon;
        private System.Windows.Forms.Label labelCostHealth;
        private System.Windows.Forms.Label labelCostDamage;
        private System.Windows.Forms.Label labelCostArmor;
        private System.Windows.Forms.Label labelCostWeapon;
        private System.Windows.Forms.Button buttonLevelUpHealth;
        private System.Windows.Forms.Button buttonLevelUpDamage;
        private System.Windows.Forms.Button buttonLevelUpArmor;
        private System.Windows.Forms.Button buttonWeapon;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

