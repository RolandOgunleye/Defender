using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace  DefendersGame
{
    // Roland Ogunleye
    // January 29th, 2021
    // This class is meant to create the laser for a spaceship, control its movement and properly dispose of it. Each laser gets assigned a timer which then controls its movement.
    class Laser :Game
    {
        // Variables for laser direction, speed, new picturebox, timer,top,left and etc...
       public string Direction;
       private int LaserSpeed = 20;
       private PictureBox laser = new PictureBox();
        private Timer LaserTimer = new Timer();
        public int LaserTop;
        public int LaserLeft;
        
        public Image LaserImage;

        public void MakeLaser(Panel panel)
        {
            // Set the laser properties and what panel is being used.

            laser.Size = new System.Drawing.Size(20, 10);
            laser.SizeMode = PictureBoxSizeMode.StretchImage;
            laser.Tag = "Laser";
            laser.Image = LaserImage;
            laser.Top = LaserTop;
            laser.Left =LaserLeft;
                     
            laser.BringToFront();
            panel.Controls.Add(laser);

            LaserTimer.Interval = LaserSpeed;
            LaserTimer.Tick += new EventHandler(LaserTimerEvent);
            LaserTimer.Start();
            
          
         

        }

        // acts as a timer to update the movement of the laser. Properly disposes the laser and timer.
        public void LaserTimerEvent(object sender, EventArgs e)
        {
            if (Direction == "Right")
            {
                 laser.Left += LaserSpeed;
            }
            if (Direction == "Left")
            {
                laser.Left -= LaserSpeed;
            }
          if (laser.Left<0||laser.Right>ClientSize.Width )
            {
               
                LaserTimer.Stop();
                LaserTimer.Dispose();
                laser.Dispose();
                LaserTimer = null;
                laser = null;

               

            }
        }

    }
}
