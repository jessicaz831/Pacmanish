// Jessica Zhu
// Feb 20, 2019
// Create a game where player has to collect 10 objects then catch the enemy that is now running away from the player

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit1Assignment
{
    public partial class Form1 : Form
    {
        // store player movement states
        bool moveUp = false;
        bool moveDown = false;
        bool moveLeft = false;
        bool moveRight = false;

        // store player's starting location
        int playerY = 336;
        int playerX = 479;

        // store enemy's starting location
        int enemyY;
        int enemyX;

        // store player's movement speed
        int speed = 10;

        // store of the objects have been picked up or not
        bool object1 = false;
        bool object2 = false;
        bool object3 = false;
        bool object4 = false;
        bool object5 = false;
        bool object6 = false;
        bool object7 = false;
        bool object8 = false;
        bool object9 = false;
        bool object10 = false;

        public Form1()
        {
            InitializeComponent();

            // hide win screen, hide menu
            lblWin.Hide();
            lblResume.Hide();
            picPause.Hide();
            lblHelp.Hide();
            lblRestart.Hide();
            lblBack.Hide();
            lblInfo.Hide();

            // timer is disabled
            tmrLoop.Enabled = false;

            // hide player, enemy and all objects
            picPlayer.Hide();
            picEnemy.Hide();
            picObject1.Hide();
            picObject2.Hide();
            picObject3.Hide();
            picObject4.Hide();
            picObject5.Hide();
            picObject6.Hide();
            picObject7.Hide();
            picObject8.Hide();
            picObject9.Hide();
            picObject10.Hide();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // when user presses enter, timer is enabled
                tmrLoop.Enabled = true;
                // instructions are hidden
                lblInfo.Hide();
                // player, enemy and objects are all visible
                picPlayer.Show();
                picEnemy.Show();
                picObject1.Show();
                picObject2.Show();
                picObject3.Show();
                picObject4.Show();
                picObject5.Show();
                picObject6.Show();
                picObject7.Show();
                picObject8.Show();
                picObject9.Show();
                picObject10.Show();
                // pause button is visible
                picPause.Show();
            }

            // player moves up when user presses W
            if (e.KeyCode == Keys.W)
            {
                moveUp = true;
            }
            // player moves down when user presses S
            else if (e.KeyCode == Keys.S)
            {
                moveDown = true;
            }
            // player moves left when user presses A
            else if (e.KeyCode == Keys.A)
            {
                moveLeft = true;
                // make player's image face left
                picPlayer.Image = Properties.Resources.pacmanleft;
            }
            // player move right when user presses D
            else if (e.KeyCode == Keys.D)
            {
                moveRight = true;
                // make player's image face right
                picPlayer.Image = Properties.Resources.pacmanright;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // when the user lets go of W, turn off upward movement
            if (e.KeyCode == Keys.W)
            {
                moveUp = false;
            }
            // when the user lets go of S, turn off downward movement
            else if (e.KeyCode == Keys.S)
            {
                moveDown = false;
            }
            // when the user lets go of A, turn off left movement
            else if (e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            // when the user lets go of D, turn off right movement
            else if (e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
        }

        void CheckLeftBoundary()
        {
            // stop the player's x value from being negative
            if (playerX < 0)
            {
                playerX = 0;
            }
            // stop the enemy's x value from being negative
            if (enemyX < 0)
            {
                enemyX = 0;
            }
        }

        void CheckTopBoundary()
        {
            // stop the player's y value from being negative
            if (playerY < 0)
            {
                playerY = 0;
            }
            // stop the enemy's y value from being negative
            if (enemyY < 0)
            {
                enemyY = 0;
            }
        }

        void CheckRightBoundary()
        {
            // stop the player's right x value from being bigger than the screen's width
            if (playerX > this.ClientSize.Width - picPlayer.Width)
            {
                playerX = this.ClientSize.Width - picPlayer.Width;
            }
            // stop the enemy's right x value from being bigger than the screen's width
            if (enemyX > this.ClientSize.Width - picEnemy.Width)
            {
                enemyX = this.ClientSize.Width - picEnemy.Width;
            }
        }

        void CheckBottomBoundary()
        {
            // stop the player's bottom y value from being bigger than the screen's height
            if (playerY > this.ClientSize.Height - picPlayer.Height)
            {
                playerY = this.ClientSize.Height - picPlayer.Height;
            }
            // stop the enemy's bottom y value from being bigger than the screen's height
            if (enemyY > this.ClientSize.Height - picEnemy.Height)
            {
                enemyY = this.ClientSize.Height - picEnemy.Height;
            }
        }

        // stops the user from going past any of the edges of the form
        void BoundaryDetection()
        {
            CheckLeftBoundary();
            CheckTopBoundary();
            CheckRightBoundary();
            CheckBottomBoundary();

            // update player's location
            picPlayer.Location = new Point(playerX, playerY);
        }

        // program enemy's movement
        void EnemyMovement()
        {
            // if enemy is on the left of the player, move enemy right by 3
            if (enemyX <= playerX)
            {
                enemyX = enemyX + 3;
                picEnemy.Image = Properties.Resources.ghostright;
            }
            // if enemy is on the right of the player, move enemy left by 3
            if (enemyX > playerX)
            {
                enemyX = enemyX - 3;
                picEnemy.Image = Properties.Resources.ghostleft;
            }
            // if enemy is above player, move enemy down by 3
            if (enemyY <= playerY)
            {
                enemyY = enemyY + 3;
            }
            // if enemy is below player, move enemy up by 3
            if (enemyY > playerY)
            {
                enemyY = enemyY - 3;
            }
            // update enemy's location
            picEnemy.Location = new Point(enemyX, enemyY);
        }

        // program enemy's movement after user has collected all items
        void EnemyDeadMovement()
        {
            // if enemy is on the left of the player, move enemy left by 7
            if (enemyX <= playerX)
            {
                enemyX = enemyX - 7;
            }
            // if enemy is on the right of the player, move enemy right by 7
            if (enemyX > playerX)
            {
                enemyX = enemyX + 7;
            }
            // if enemy is above player, move enemy up by 7
            if (enemyY <= playerY)
            {
                enemyY = enemyY - 7;
            }
            // if enemy is below player, move enemy down by 7
            if (enemyY > playerY)
            {
                enemyY = enemyY + 7;
            }
            // update enemy's location
            picEnemy.Location = new Point(enemyX, enemyY);
        }

        void CheckLose()
        {
            // if player touches enemy
            if (picPlayer.Bounds.IntersectsWith(picEnemy.Bounds))
            {
                // disable timer
                tmrLoop.Enabled = false;
                // hide pause button
                picPause.Hide();
                // hide player
                picPlayer.Hide();
                // show game over screen
                lblWin.Text = "Game Over!";
                lblWin.Show();
            }
        }

        void CheckWin()
        {
            // if player touches enemy
            if (picPlayer.Bounds.IntersectsWith(picEnemy.Bounds))
            {
                // disable timer
                tmrLoop.Enabled = false;
                // hide enemy
                picEnemy.Hide();
                // show win screen
                lblWin.Text = "You Win!";
                lblWin.Show();
                // hide pause button
                picPause.Hide();
            }
        }

        void PickedUpObject()
        {
            // if player intersects with any of the objects, move them off screen
            if (picPlayer.Bounds.IntersectsWith(picObject1.Bounds))
            {
                picObject1.Location = new Point(-1000, -1000);
                object1 = true;
            }

            if (picPlayer.Bounds.IntersectsWith(picObject2.Bounds))
            {
                picObject2.Location = new Point(-1000, -1000);
                object2 = true;
            }

            if (picPlayer.Bounds.IntersectsWith(picObject3.Bounds))
            {
                picObject3.Location = new Point(-1000, -1000);
                object3 = true;
            }

            if (picPlayer.Bounds.IntersectsWith(picObject4.Bounds))
            {
                picObject4.Location = new Point(-1000, -1000);
                object4 = true;
            }

            if (picPlayer.Bounds.IntersectsWith(picObject5.Bounds))
            {
                picObject5.Location = new Point(-1000, -1000);
                object5 = true;
            }

            if (picPlayer.Bounds.IntersectsWith(picObject6.Bounds))
            {
                picObject6.Location = new Point(-1000, -1000);
                object6 = true;
            }

            if (picPlayer.Bounds.IntersectsWith(picObject7.Bounds))
            {
                picObject7.Location = new Point(-1000, -1000);
                object7 = true;
            }

            if (picPlayer.Bounds.IntersectsWith(picObject8.Bounds))
            {
                picObject8.Location = new Point(-1000, -1000);
                object8 = true;
            }

            if (picPlayer.Bounds.IntersectsWith(picObject9.Bounds))
            {
                picObject9.Location = new Point(-1000, -1000);
                object9 = true;
            }

            if (picPlayer.Bounds.IntersectsWith(picObject10.Bounds))
            {
                picObject10.Location = new Point(-1000, -1000);
                object10 = true;
            }
        }

        private void tmrLoop_Tick(object sender, EventArgs e)
        {
            // When upward movement is on, decrease the player's y value by speed
            if (moveUp == true)
            {
                playerY = playerY - speed;
            }
            // When downward movement is on, increase the player's y value by speed
            if (moveDown == true)
            {
                playerY = playerY + speed;
            }
            // When left movement is on, decrease the player's x value by speed
            if (moveLeft == true)
            {
                playerX = playerX - speed;
            }
            // When right movement is on, increase the player's x value by speed
            if (moveRight == true)
            {
                playerX = playerX + speed;
            }

            // check which objects have been picked up
            PickedUpObject();

            if (object1 == true && object2 == true && object3 == true && object4 == true && object5 == true && object6 == true && object7 == true && object8 == true && object9 == true && object10 == true)
            {
                // if all objects are picked up, double player's speed
                speed = 20;
                // change enemy picture to enemy in vulnerable state
                picEnemy.Image = Properties.Resources.ghostdead;

                // replace the enemy with enemy in vulnerable state, and enable it's movement
                EnemyDeadMovement();
                // check if player won
                CheckWin();
            }
            else
            {
                // if not all objects are picked up, enable enemy movement
                EnemyMovement();
                // check if player lost
                CheckLose();
            }
            
            // detect boundaries
            BoundaryDetection();

        }

        private void picPause_Click(object sender, EventArgs e)
        {
            // when user clicks pause
            // disable timer
            tmrLoop.Enabled = false;
            // show menu options
            lblResume.Show();
            lblHelp.Show();
            lblRestart.Show();
            // hide pause button
            picPause.Hide();

            // hide enemy
            picEnemy.Hide();
            // hide player
            picPlayer.Hide();
            // hide all objects
            picObject1.Hide();
            picObject2.Hide();
            picObject3.Hide();
            picObject4.Hide();
            picObject5.Hide();
            picObject6.Hide();
            picObject7.Hide();
            picObject8.Hide();
            picObject9.Hide();
            picObject10.Hide();
        }

        private void lblResume_Click(object sender, EventArgs e)
        {
            // when user clicks resume
            // enable timer
            tmrLoop.Enabled = true;
            // hide pause menu
            lblResume.Hide();
            lblHelp.Hide();
            lblRestart.Hide();
            // show pause button
            picPause.Show();

            // enemy is visible
            picEnemy.Show();
            // player is visible
            picPlayer.Show();
            // all objects are visible
            picObject1.Show();
            picObject2.Show();
            picObject3.Show();
            picObject4.Show();
            picObject5.Show();
            picObject6.Show();
            picObject7.Show();
            picObject8.Show();
            picObject9.Show();
            picObject10.Show();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            // when user clicks help
            // display instructions
            lblInfo.Show();
            lblInfo.Text = "Use WASD to move. \r\nCollect all the dots, but watch out for the enemy!\r\nAfter collecting all the dots, catch the enemy to win!";
            // show back button to go back to menu
            lblBack.Show();
            // hide pause button
            picPause.Hide();
            // hide pause menu
            lblResume.Hide();
            lblHelp.Hide();
            lblRestart.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            // when user clicks back
            // hide instructions
            lblInfo.Hide();
            // hide back button
            lblBack.Hide();
            // hide pause button
            picPause.Hide();
            // show pause menu
            lblResume.Show();
            lblHelp.Show();
            lblRestart.Show();
        }

        private void lblRestart_Click(object sender, EventArgs e)
        {
            // when user clicks restart, restart application
            Application.Restart();
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            // when user clicks play
            // hide title
            lblTitle.Hide();
            // hide play button
            lblPlay.Hide();
            // display instructions
            lblInfo.Show();
            lblInfo.Text = "Use WASD to move. \r\nCollect all the dots, but watch out for the enemy!\r\nAfter collecting all the dots, catch the enemy to win!\r\nPress Enter to play!";
        }
    }
}
