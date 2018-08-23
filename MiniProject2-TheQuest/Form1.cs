using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject2_TheQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        private bool isPotionNeeded = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(125, 94, 700, 280));
            game.NewLevel(random);
            UpdateCharacters();
            SetTheLevel();
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void UpdateCharacters()
        {
            playerHitPoints.Text = game.playerHitPoints.ToString();
            pictureBoxPlayer.Location = game.PlayerLocation;
            int enemiesShown = 0;
            enemiesShown = CountEnemies();

            Control weaponControl = null;
            SetPictureBoxVisisbility();
            weaponControl = SetVisibilityToWeaponInRoom(weaponControl);
            weaponControl.Visible = true;
            CheckPlayerInventory();
            weaponControl.Location = game.WeaponInRoom.Location;

            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
            {
                weaponControl.Visible = true;
                weaponControl.Location = game.WeaponInRoom.Location;
            }
            if(game.playerHitPoints<=0)
            {
                MessageBox.Show("You died ", "System...");
                Application.Exit();
            }
            if(enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level ");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        private void CheckPlayerInventory()
        {
            CheckPlayerWeapon("Sword","Weapon",pictureSword);
            CheckPlayerWeapon("Bow", "Weapon", pictureBow);
            CheckPlayerWeapon("Mace", "Weapon", pictureMace);

            CheckPlayerPotion("Blue Potion", "Potion", pictureBluePotion);
            CheckPlayerPotion("Red Potion", "Potion", pictureRedPotion);

        }
        private void CheckPlayerPotion(string potionName, string weaponType, PictureBox weaponPictureBox)
        {
            weaponPictureBox.BorderStyle = BorderStyle.None;
            if (game.CheckPlayerInventory(potionName))
            {
                if (!game.CheckPotionUsed(potionName))
                {
                    weaponPictureBox.Visible = true;
                    if (game.WeaponEquipped(potionName))
                    {
                        weaponPictureBox.BorderStyle = BorderStyle.FixedSingle;
                        SetupAttackButtons(weaponType);
                        isPotionNeeded = true;
                    }
                }
                else
                {
                    weaponPictureBox.BorderStyle = BorderStyle.None;
                    weaponPictureBox.Visible = false;
                    if (isPotionNeeded)
                    {
                        game.Equip("Sword");
                        CheckPlayerWeapon("Sword", "Weapon", pictureSword);
                        SetupAttackButtons("weapon");
                        isPotionNeeded = false;
                    }
                }
            }
        }

        private void CheckPlayerWeapon(string weaponName, string weaponType, PictureBox weaponPictureBox)
        {
            weaponPictureBox.BorderStyle = BorderStyle.None;
            if(game.CheckPlayerInventory(weaponName))
            {
                weaponPictureBox.Visible = true;
                if(game.WeaponEquipped(weaponName))
                {
                    weaponPictureBox.BorderStyle = BorderStyle.FixedSingle;
                    SetupAttackButtons(weaponType);
                }
            }
        }

        private Control SetVisibilityToWeaponInRoom(Control weaponControl)
        {
            switch(game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword;
                    break;
                case "Bow":
                    weaponControl = bow;
                    break;
                case "Mace":
                    weaponControl = mace;
                    break;
                case "Red Potion":
                    weaponControl = redPotion;
                    break;
                case "Blue Potion":
                    weaponControl = bluePotion;
                    break;
            }
            return weaponControl;
        }
        private void SetPictureBoxVisisbility()
        {
            sword.Visible = false;
            bow.Visible = false;
            mace.Visible = false;
            bluePotion.Visible = false;
            redPotion.Visible = false;
        }
        private int CountEnemies()
        {
            int enemiesShown = 0;

            foreach(Enemy enemy in game.Enemies)
            {
                if(enemy is Bat)
                {
                    if (UpdateEnemy(enemy, bat, batHitPoints))
                        enemiesShown++;
                }
                if(enemy is Ghost)
                {
                    if (UpdateEnemy(enemy, ghost, ghostHitPoints))
                        enemiesShown++;
                }
                if(enemy is Ghoul)
                {
                    if (UpdateEnemy(enemy, ghoul, ghoulHitpoints))
                        enemiesShown++;
                }
            }
            return enemiesShown;
        }
        private bool UpdateEnemy(Enemy enemy, PictureBox pictureBoxEnemy, Label labelEnemyHitPoints)
        {
            bool isEnenmyUpdated = false;

            labelEnemyHitPoints.Text = enemy.HitPoints.ToString();
            labelEnemyHitPoints.Visible = true;

            if(enemy.HitPoints > 0)
            {
                pictureBoxEnemy.Location = enemy.Location;
                pictureBoxEnemy.Visible = true;
                isEnenmyUpdated = true;
            }
            else
            {
                pictureBoxEnemy.Visible = false;
                labelEnemyHitPoints.Visible = false;
            }
            return isEnenmyUpdated;
        }
        private void pictureSword_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(pictureSword, "Sword", "Weapon");
            UpdateCharacters();
        }
        private void pictureBluePotion_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(pictureBluePotion,"Blue Potion","Potion");
            UpdateCharacters();
        }
        private void pictureBow_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(pictureBow,"Bow","Weapon");
            UpdateCharacters();
        }
        private void pictureRedPotion_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(pictureRedPotion, "Red Potion", "Potion");
            UpdateCharacters();
        }

        private void pictureMace_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(pictureMace, "Mace", "Weapon");
            UpdateCharacters();
        }
        private void SelectInventoryItem(PictureBox item,string itemName,string weaponType)
        {
            if(game.CheckPlayerInventory(itemName))
            {
                game.Equip(itemName);
                RemoveInventoryBorders();
                item.BorderStyle = BorderStyle.FixedSingle;
                SetupAttackButtons(weaponType);
                RemoveInventoryBorders();
            }
        }
        private void SetupAttackButtons(string weaponType)
        {
            if ("potion".Equals(weaponType.ToLower()))
            {
                attackUp.Text = "Drink";
                attackUp.Size = new System.Drawing.Size(50,30);
                attackDown.Visible = false;
                attackLeft.Visible = false;
                attackRight.Visible = false;
            }
            if ("weapon".Equals(weaponType.ToLower()))
            {
                attackUp.Text = "↑";
                attackUp.Size = new System.Drawing.Size(30, 30);
                attackDown.Visible = true;
                attackRight.Visible = true;
                attackLeft.Visible = true;
            }
        }
        private void RemoveInventoryBorders()
        {
            pictureSword.BorderStyle = BorderStyle.None;
            pictureBow.BorderStyle = BorderStyle.None;
            pictureMace.BorderStyle = BorderStyle.None;
            pictureBluePotion.BorderStyle = BorderStyle.None;
            pictureRedPotion.BorderStyle = BorderStyle.None;
        }
        private void SetTheLevel()
        {
            pictureBoxPlayer.BringToFront();
            bat.SendToBack();
            ghost.SendToBack();
            ghoul.SendToBack();
            bow.SendToBack();
            mace.SendToBack();
            sword.SendToBack();
            bluePotion.SendToBack();
            redPotion.SendToBack();
        }
        private void attackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }
        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }
        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }
        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }
    }
}
