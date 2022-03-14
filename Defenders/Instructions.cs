using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefendersGame
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }
        private Random rnd = new Random();
        private void tmrBackground_Tick(object sender, EventArgs e)
        {
            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && (string)X.Tag == "Star")
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                    X.BackColor = randomColor;
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            StartScreen startScreen = new StartScreen();
            this.Visible = false;
            startScreen.ShowDialog();
            this.Visible = true;
        }
    }
}
