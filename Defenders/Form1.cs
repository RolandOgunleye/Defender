using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Media;
using System.Numerics;


namespace DefendersGame
{
    // Roland Ogunleye
    // January 29th, 2021
    // Main form that controls the game movement, score, sound, etc...
    public partial class Game : Form
    {
        List<LanderState> EnemyList = new List<LanderState>();
       
        SoundPlayer StartMusic = new SoundPlayer(Resource1.Start);
        SoundPlayer LaserSound = new SoundPlayer(Resource1.LaserSound);
        private Random rnd = new Random();

        //Variables to keep tracck of position, speed, enemies, pause, ammo,etc...
        Vector2 SpaceShipPosition;
        Vector2 DynamosPosition;
        Vector2 Velocity;   
        bool PauseGame;
        int EnemyCounter=0;
        bool DynamosShoot;
        float Speed = 10;
        int Level = 1;
        int Score = 0;
        int Ammo = 5;
        string Face = "Right";
        int Movementspeed = 12;

        enum ShipMovement
        {
            None,
            Up,
            Down,
            Left,
            Right,
        }

            //Set ship movement to none at start

        ShipMovement Ship = ShipMovement.None;


        public Game()
        {
            InitializeComponent();
            //set player health to 100 at start of game
            pgrHealth.Maximum = 100;
            pgrHealth.Value = 100;
        //add dynamos to panel controls

            this.panel1.Controls.Add(picSpaceShip);
            this.panel1.Controls.Add(picDynamos6);
            this.panel1.Controls.Add(picDynamos3);
            this.panel1.Controls.Add(picDynamos4);
            this.panel1.Controls.Add(picDynamos5);
        }

       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //Pauses the game 
                lblPause.Visible = true;
                PauseGame = true;
                tmrGame.Stop();
                tmrSpawn.Stop();
            }
            else if (e.KeyCode == Keys.F1 && PauseGame)
            {
                // Continues the Game
                lblPause.Visible = false;
                PauseGame = false;
                tmrGame.Start();
                tmrSpawn.Start();
               
            }
           else if (e.KeyCode == Keys.F2 && PauseGame)
            {
                //return to Lobby
                Close();
                StartScreen startScreen = new StartScreen();
                this.Visible = false;
                startScreen.ShowDialog();
                this.Visible = true;
            }
        

            // Ship movement keys
            if (e.KeyCode == Keys.Up)
            {
                Dynamos();
                Ship = ShipMovement.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                Dynamos();
                Ship = ShipMovement.Down;
            }
            else if (e.KeyCode == Keys.Left)
            {
                Dynamos();
                Ship = ShipMovement.Left;
                picSpaceShip.Image = Resource1.DefenderShipLeft;
                Face = "Left";
            }
            else if (e.KeyCode == Keys.Right)
            {
                Dynamos();
                Ship = ShipMovement.Right;
                picSpaceShip.Image = Resource1.DefenderShipRight;
                Face = "Right";
            }

            // Keeps track of ammo for player ship/
            if (e.KeyCode == Keys.Space & Ammo > 0)
            {
                NewLaser(Face);
                Ammo -= 1;
                LaserSound.Play();
                AddAmmo();
                Dynamos();


            }
            if (e.KeyCode == Keys.Escape&& lblGameOver.Visible == true)
            {
                Close();
            }
            

        }


        private void tmrGame_Tick(object sender, EventArgs e)
        {
            PlayerMovement();
            // Collision check

            foreach (Control X in this.panel1.Controls)
            {
                // if lander, swarmer or a dynamoslaser hits player then lose health
                if (X is PictureBox && ((string)X.Tag == "Lander" || (string)X.Tag == "Swarmer" || (string)X.Tag == "DynamosLaser"))
                {
                    // if player hits zero health game is over
                    if (((PictureBox)X).Bounds.IntersectsWith(picSpaceShip.Bounds) && pgrHealth.Value == 0)
                    {

                        this.panel1.Controls.Remove(X);
                        X.Dispose();
                       
                        tmrGame.Enabled = false;
                        lblGameOver.Visible = true;
                        tmrSpawn.Enabled = false;
                    }
                    
                    else if (((PictureBox)X).Bounds.IntersectsWith(picSpaceShip.Bounds) && pgrHealth.Value != 0)
                    {
                        // If player gets hit by lander or swarmer they lose health. Enemy gets destroyed. If it puts player in negative health clear panel.
                        if ((pgrHealth.Value - 10) < 0)
                        {
                            this.panel1.Controls.Remove(X);
                            X.Dispose();
                           
                            tmrGame.Enabled = false;
                            lblGameOver.Visible = true;
                          
                            tmrSpawn.Enabled = false;
                            PauseGame = true;
                        }
                        else
                        {

                            // Lose health. Enemy counter drops by one if enemy is a swarmer or lander
                            pgrHealth.Value -= 10;
                            if ((string)X.Tag == "Lander")
                            {
                               EnemyCounter = EnemyCounter - 1;
                                MakeLander();
                                EnemyCounter = EnemyCounter + 1;
                                this.panel1.Controls.Remove(X);
                                X.Dispose();
                            }
                            else if ((string)X.Tag == "Swarmer")
                            {
                                EnemyCounter = EnemyCounter - 1;
                                 MakeSwamer();
                                EnemyCounter = EnemyCounter + 1;
                                this.panel1.Controls.Remove(X);
                                X.Dispose();
                            }
                            else if ((string)X.Tag == "DynamosLaser")
                            {
                                this.panel1.Controls.Remove(X);
                                X.Dispose();
                            }
                        }

                        
                       

                    }


                }


                foreach (Control k in this.panel1.Controls)
                {

                    // if laser hits lander or swarmer the player gains points and the enemy is removed from panel.
                    if ((k is PictureBox && (string)k.Tag == "Laser") && (X is PictureBox && (string)X.Tag == "Lander" || (string)X.Tag == "Swarmer"))
                    {
                        if (k.Bounds.IntersectsWith(X.Bounds))
                        {
                            EnemyCounter = EnemyCounter - 1;
                            // if Player hits Swarmer or Lander they get points 
                            Score += 250;

                            Dynamos();
                            lblPoints.Text = "Score: " + Score.ToString();
                            this.panel1.Controls.Remove(X);

                            X.Dispose();
                            this.panel1.Controls.Remove(k);
                            k.Dispose();
                         




                        }
                    }

                    //if Laser hits Dynamos then the dynamos is invisible from the screen and player gains points 
                    if ((k is PictureBox && (string)k.Tag == "Laser") && (X is PictureBox && (string)X.Tag == "Dynamos" && X.Visible == true))
                    {
                        if (k.Bounds.IntersectsWith(X.Bounds))
                        {
                        
                         

                          


                        }


                    }
                    //remove dynamos laser from screen

                    if ((X is PictureBox && (string)X.Tag == "DynamosLaser"))
                    {

                        if (X.Left < 0 || X.Right > panel1.Width || X.Top < 0 || X.Top > panel1.Height)
                        {
                            this.panel1.Controls.Remove(X);
                            X.Dispose();
                        }
                    }
                }
            }



       

            // Swarmer chases the player 
            foreach (Control x in this.panel1.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Swarmer")
                {
                    if (picSpaceShip.Top > x.Top)
                    {
                        x.Top += 2 *Level ;
                    }
                    if (picSpaceShip.Left > x.Left)
                    {
                        x.Left += 2 * Level ;
                    }
                    if (picSpaceShip.Top < x.Top)
                    {
                        x.Top -= 2*Level;
                    }
                    if (picSpaceShip.Left < x.Left)
                    {
                        x.Left -= 2*Level;
                    }
                }

            }

            //Move Lander
            foreach (LanderState landerState in EnemyList)
            {
                var x = landerState.LanderImage;
                if (x is PictureBox && (string)x.Tag == "Lander")
                {
                    // Lander's velocity changes when it hits panel border
                    if (x.Top <= 0 || x.Bottom >= panel1.ClientSize.Height)
                    {
                        landerState.SetVelocityY(-1 * landerState.Velocity.Y);
                    }
                    else if (x.Left <= 0 || x.Left >= panel1.ClientSize.Width - x.Width)
                    {
                        landerState.SetVelocityX(-landerState.Velocity.X);
                    }



                    //update position and velocity vector

                    landerState.Position = new Vector2(x.Left, x.Top) + landerState.Velocity;

                    x.Top = (int)landerState.Position.Y;
                    x.Left = (int)landerState.Position.X;
                }


            }
            //Adjust level depending on score
            if(Score ==0)
            {
                lblWave.Text = "Wave: " + Level;
                Level = 1;
            }    

            else if (Score==10000)
            {
                lblWave.Text = "Wave: " + Level;
                Level = 2;
            }
            else if (Score>30000)
            {
                lblWave.Text = "Wave: " + Level;
                Level = 3;
            }
            else if (Score>60000)
            {

                lblWave.Text = "Wave: " + Level;
                Level = 4;
            }
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            // Stop ship from moving when no keys are pressed
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            {
                Ship = ShipMovement.None;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // start music
            StartMusic.Play();
        }

        private void PlayerMovement()
        {
            if (picSpaceShip.Top <= 0)
            {
                
                picSpaceShip.Top += Movementspeed;
            }
            // if the ship is less than zero on x-axis then move right
            else if (picSpaceShip.Left <= 0)
            {
                picSpaceShip.Left += Movementspeed;
            }
            //If bottom of the ship is greater than Client Height then move up
            else if (picSpaceShip.Bottom >= panel1.Height)
            {
                picSpaceShip.Top -= Movementspeed;
            }
            // If ship is greater than client width then move left.
            else if (picSpaceShip.Right >= panel1.Width)
            {
                picSpaceShip.Left -= Movementspeed;
            }
            // Movement for spaceship
            if (Ship == ShipMovement.Up)
            {
                picSpaceShip.Top -= Movementspeed;
            }
            else if (Ship == ShipMovement.Down)
                picSpaceShip.Top += Movementspeed;
            else if (Ship == ShipMovement.Right)
                picSpaceShip.Left += Movementspeed;
            else if (Ship == ShipMovement.Left)
                picSpaceShip.Left -= Movementspeed;
        }

        public void NewLaser(string Direction)
        {

            // Create laser and set it off based on direction of player
            Laser FireLaser = new Laser();
            FireLaser.Direction = Direction;
            FireLaser.LaserLeft = picSpaceShip.Left + (picSpaceShip.Width / 2);
            FireLaser.LaserTop = picSpaceShip.Top + (picSpaceShip.Height / 2);

            FireLaser.LaserImage = Resource1.Laser;
            FireLaser.MakeLaser(this.panel1);




        }
        public void DynamosNewLaser(float Left, float Top, float Width, float Height)
        {

            // Create laser and set it off based on direction of player
            DynamosLaser FireLaser = new DynamosLaser();

            FireLaser.DynamosLaserLeft = (int)Left + ((int)Width / 2);
            FireLaser.DynamosLaserTop = (int)Top + ((int)Height / 2);

            FireLaser.DynamosLaserImage = Resource1.DynamosLaser;


            DynamosAngle(Left, Top, Width, Height);
            FireLaser.Velocity = Velocity;



            // FireLaser.Direction = DynamosPosition;
            FireLaser.MakedDynamosLaser(panel1);


            FireLaser.panel = panel1;

        }

        public void DynamosAngle(float Left, float Top, float Width, float Height)
        {
            SpaceShipPosition = new Vector2(picSpaceShip.Left + (picSpaceShip.Width / 2), picSpaceShip.Top + (picSpaceShip.Height / 2));


            DynamosPosition = new Vector2(Left + (Width / 2), Top + (Height / 2));
            double Opp = SpaceShipPosition.X - DynamosPosition.X;
            double Adj = SpaceShipPosition.Y - DynamosPosition.Y;
            double OppositeOverAdjacent = (Opp / Adj);
            float DynamosAngle = (float)(Math.Atan(OppositeOverAdjacent));

            //Enemy is firing from above the ship
            if (Adj > 0)
            {
                DynamosAngle = (float)((Math.PI / 2) - DynamosAngle);

            }
            //enemy is firing from below the ship
            else if (Adj < 0)
            {
                DynamosAngle = (float)((3 * Math.PI / 2) - DynamosAngle);
            }


            float SpeedX = Speed * (float)Math.Cos(DynamosAngle);

            float SpeedY = Speed * (float)Math.Sin(DynamosAngle);

            Velocity = new Vector2(SpeedX, SpeedY);

        }


        public void MakeLander()
        {
           
            // Spawn Lander at random location on screen
            //Create an individual lander.
            Random RandomSpawn = new Random();
            PictureBox Lander = new PictureBox();
            LanderState landerState = new LanderState(Lander);
            EnemyList.Add(landerState);
            Lander.Tag = "Lander";
            Lander.Image = Resource1.Lander;

            Lander.Size = new System.Drawing.Size(30, 27);
            Lander.SizeMode = PictureBoxSizeMode.StretchImage;

            Lander.Left = RandomSpawn.Next(0, panel1.Width - Lander.Width);
            Lander.Top = RandomSpawn.Next(0, panel1.Height - Lander.Height);
            this.panel1.Controls.Add(Lander);
            Lander.BringToFront();


            Speed = 6;

            landerState.Position = new Vector2(Lander.Width / 2, Lander.Height / 2);
            Double Angle = FindRandomAngle();
            landerState.Velocity = new Vector2((float)(Speed * Math.Cos(Angle)), (float)(Speed * Math.Sin(Angle)));
        }


        public void MakeSwamer()
        {
            
            // Spawn swarmer at random location on the panel
            Random RandomSpawn = new Random();
            PictureBox Swamer = new PictureBox();


            Swamer.Tag = "Swarmer";
            Swamer.Image = Resource1.Swamer;

            Swamer.Size = new System.Drawing.Size(30, 27);
            Swamer.SizeMode = PictureBoxSizeMode.StretchImage;
            Swamer.Left = RandomSpawn.Next(0, panel1.Width - Swamer.Width);
            Swamer.Top = RandomSpawn.Next(0, panel1.Height - Swamer.Height);

            this.panel1.Controls.Add(Swamer);
        }




        //Set random angle for the Lander to go off at
        public Double FindRandomAngle()
        {
            Random RandomAngle = new Random();

            int r = 0;
            while (r % 2 == 0)
            {
                r = RandomAngle.Next(1, 8);
            }

            double Angle = r * 45 * Math.PI / 100;
            return Angle;
        }


        public async Task SpawnRate()
        {
           
            if (EnemyCounter == 0)
            {
                
                for (int i = 0; i < Level * 3; i++)
                {
                    EnemyCounter= EnemyCounter + 1;
                    // 1 seccond delay for spawning of Landers
                    await Task.Delay(1000);
                    MakeLander();

                }

                //1 second delay
                for (int i = 0; i < Level * 1; i++)
                {

                    EnemyCounter = EnemyCounter + 1;
                    await Task.Delay(1000);
                   MakeSwamer();

                }

              
            }

          

        }
    
        public async void AddAmmo()
        {
            // .5 second delay for reloading Ammo
            if (Ammo == 0)
            {
                await Task.Delay(500);
                Ammo = 5;

            }
        }



       

        private void tmrSpawn_Tick(object sender, EventArgs e)
        {
            // Spawn enemy when counter hits zero
            if (EnemyCounter == 0)
            {
                DynamosShoot = true;
               
                SpawnRate();
            }
            else
               DynamosShoot = false;
        
            //Change color for each star in background
            foreach (Control X in this.panel1.Controls)
            {
                if (X is PictureBox && (string)X.Tag == "Star")
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                    X.BackColor = randomColor;
                }
              
            }
        }



        public void Dynamos()
        {
            // Shoot laser for each dynamos
            if (DynamosShoot)
            {
                DynamosShoot = false;
                DynamosNewLaser(picDynamos5.Left, picDynamos5.Top, picDynamos5.Width, picDynamos5.Height);
                DynamosNewLaser(picDynamos4.Left, picDynamos4.Top, picDynamos4.Width, picDynamos4.Height);
                DynamosNewLaser(picDynamos6.Left, picDynamos6.Top, picDynamos6.Width, picDynamos6.Height);
                DynamosNewLaser(picDynamos3.Left, picDynamos3.Top, picDynamos3.Width, picDynamos3.Height);
            }
        }
    }
}