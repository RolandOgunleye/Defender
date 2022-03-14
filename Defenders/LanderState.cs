using System.Windows;
using System.Windows.Forms;
using System.Numerics;
namespace DefendersGame
{
    public class LanderState
    {
        public PictureBox LanderImage { get; set; }
        public PictureBox SwarmerImage { get; set; }
        public Vector2 Position { get; set; }
        private Vector2 mvelocity;
        public Vector2 Velocity  
        
        {
        get {return mvelocity;}
       set{mvelocity= value;}
}

        public LanderState(PictureBox landerImage)
        {
            LanderImage = landerImage;
        }

        public void SetVelocityX(float value)
        {
            mvelocity.X = value;
        }
        public void SetVelocityY(float value)
        {
            mvelocity.Y = value;
        }
    }
}