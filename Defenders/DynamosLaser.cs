using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Numerics;


namespace DefendersGame
{
    // Roland Ogunleye
    // January 29th, 2021
    // This class is meant to create the laser for a dynamos, control its movement and properly dispose of it.Each laser gets assigned a timer which then controls its movement.

    class DynamosLaser :Game
    {

        // Creating new timer and picturebox. Variables for  top, left, velocity and speed 
        public int DynamosLaserSpeed = 1;
        private PictureBox Dynamoslaser = new PictureBox();
        private Timer DynamosLaserTimer = new Timer();
        public int DynamosLaserTop;
        public int DynamosLaserLeft;
        public Vector2 Direction;
        public Vector2 Velocity;
        public Panel panel;
        


        public Image DynamosLaserImage;

        public void MakedDynamosLaser(Panel panel)
        {
            //Assign properties for dynamoslaser
            Dynamoslaser.Size = new System.Drawing.Size(20, 20);
            Dynamoslaser.SizeMode = PictureBoxSizeMode.StretchImage;
            Dynamoslaser.Tag = "DynamosLaser";
            Dynamoslaser.Image = DynamosLaserImage;
            Dynamoslaser.Top = DynamosLaserTop;
           Dynamoslaser.Left = DynamosLaserLeft;
  
           
        
            Dynamoslaser.BringToFront();
            panel.Controls.Add(Dynamoslaser);

            DynamosLaserTimer.Interval = DynamosLaserSpeed;
            DynamosLaserTimer.Tick += new EventHandler(DynamosLaserTimerEvent);
            DynamosLaserTimer.Start();
           

          
        }
        // acts as a timer to update the movement of the laser
        public void DynamosLaserTimerEvent(object sender, EventArgs e)
        {
            Direction = new Vector2(Dynamoslaser.Left, Dynamoslaser.Top) + Velocity;

                Dynamoslaser.Left = (int)Direction.X;
            Dynamoslaser.Top = (int)Direction.Y;
            Remove();


        }
        // removes laser from screen, dipose of it. Disables timer and makes Dynamoslaser and Timer null.
        public void Remove()
        {
            if (Dynamoslaser.Left < 0 || Dynamoslaser.Right > panel.Width || Dynamoslaser.Top < 0 || Dynamoslaser.Top > panel.Height)
            {

                DynamosLaserTimer.Stop();
                DynamosLaserTimer.Dispose();

                Dynamoslaser.Dispose();
                DynamosLaserTimer = null;
                Dynamoslaser = null;



            }

        }
    }
}
