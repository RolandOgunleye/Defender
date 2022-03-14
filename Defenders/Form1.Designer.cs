
namespace DefendersGame
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.pgrHealth = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.tmrSpawn = new System.Windows.Forms.Timer(this.components);
            this.lblWave = new System.Windows.Forms.Label();
            this.picSpaceShip = new System.Windows.Forms.PictureBox();
            this.picDynamos5 = new System.Windows.Forms.PictureBox();
            this.picDynamos4 = new System.Windows.Forms.PictureBox();
            this.picDynamos3 = new System.Windows.Forms.PictureBox();
            this.picDynamos6 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDynamos5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDynamos4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDynamos3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDynamos6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // pgrHealth
            // 
            this.pgrHealth.BackColor = System.Drawing.Color.LimeGreen;
            this.pgrHealth.ForeColor = System.Drawing.SystemColors.GrayText;
            this.pgrHealth.Location = new System.Drawing.Point(91, 12);
            this.pgrHealth.Name = "pgrHealth";
            this.pgrHealth.Size = new System.Drawing.Size(100, 23);
            this.pgrHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgrHealth.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGameOver);
            this.panel1.Controls.Add(this.lblPause);
            this.panel1.Controls.Add(this.picSpaceShip);
            this.panel1.Controls.Add(this.picDynamos5);
            this.panel1.Controls.Add(this.picDynamos4);
            this.panel1.Controls.Add(this.picDynamos3);
            this.panel1.Controls.Add(this.picDynamos6);
            this.panel1.Controls.Add(this.pictureBox22);
            this.panel1.Controls.Add(this.pictureBox21);
            this.panel1.Controls.Add(this.pictureBox20);
            this.panel1.Controls.Add(this.pictureBox19);
            this.panel1.Controls.Add(this.pictureBox18);
            this.panel1.Controls.Add(this.pictureBox17);
            this.panel1.Controls.Add(this.pictureBox16);
            this.panel1.Controls.Add(this.pictureBox15);
            this.panel1.Controls.Add(this.pictureBox14);
            this.panel1.Controls.Add(this.pictureBox13);
            this.panel1.Controls.Add(this.pictureBox12);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 535);
            this.panel1.TabIndex = 2;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGameOver.Location = new System.Drawing.Point(343, 234);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(472, 86);
            this.lblGameOver.TabIndex = 52;
            this.lblGameOver.Text = "                     GAME OVER!\r\nPRESS [ESC] TO RETURN TO LOBBY";
            this.lblGameOver.Visible = false;
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.Transparent;
            this.lblPause.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPause.Location = new System.Drawing.Point(484, 185);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(171, 46);
            this.lblPause.TabIndex = 51;
            this.lblPause.Text = "[F1] RETURN TO GAME\r\n[F2] RETURN TO LOBBY\r\n";
            this.lblPause.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(467, 22);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHealth.Location = new System.Drawing.Point(12, 9);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(72, 26);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = "Health:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(909, 11);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(67, 26);
            this.lblPoints.TabIndex = 7;
            this.lblPoints.Text = "Score:";
            // 
            // tmrSpawn
            // 
            this.tmrSpawn.Enabled = true;
            this.tmrSpawn.Tick += new System.EventHandler(this.tmrSpawn_Tick);
            // 
            // lblWave
            // 
            this.lblWave.AutoSize = true;
            this.lblWave.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWave.ForeColor = System.Drawing.Color.White;
            this.lblWave.Location = new System.Drawing.Point(490, 9);
            this.lblWave.Name = "lblWave";
            this.lblWave.Size = new System.Drawing.Size(63, 26);
            this.lblWave.TabIndex = 8;
            this.lblWave.Text = "Wave:";
            // 
            // picSpaceShip
            // 
            this.picSpaceShip.BackColor = System.Drawing.Color.Transparent;
            this.picSpaceShip.Image = global::DefendersGame.Resource1.DefenderShipRight;
            this.picSpaceShip.Location = new System.Drawing.Point(915, 337);
            this.picSpaceShip.Name = "picSpaceShip";
            this.picSpaceShip.Size = new System.Drawing.Size(38, 38);
            this.picSpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpaceShip.TabIndex = 0;
            this.picSpaceShip.TabStop = false;
            this.picSpaceShip.Tag = "Player";
            this.picSpaceShip.UseWaitCursor = true;
            // 
            // picDynamos5
            // 
            this.picDynamos5.Image = ((System.Drawing.Image)(resources.GetObject("picDynamos5.Image")));
            this.picDynamos5.Location = new System.Drawing.Point(1078, 441);
            this.picDynamos5.Name = "picDynamos5";
            this.picDynamos5.Size = new System.Drawing.Size(52, 52);
            this.picDynamos5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDynamos5.TabIndex = 46;
            this.picDynamos5.TabStop = false;
            this.picDynamos5.Tag = "Dynamos";
            // 
            // picDynamos4
            // 
            this.picDynamos4.Image = ((System.Drawing.Image)(resources.GetObject("picDynamos4.Image")));
            this.picDynamos4.Location = new System.Drawing.Point(41, 441);
            this.picDynamos4.Name = "picDynamos4";
            this.picDynamos4.Size = new System.Drawing.Size(52, 52);
            this.picDynamos4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDynamos4.TabIndex = 45;
            this.picDynamos4.TabStop = false;
            this.picDynamos4.Tag = "Dynamos";
            // 
            // picDynamos3
            // 
            this.picDynamos3.Image = ((System.Drawing.Image)(resources.GetObject("picDynamos3.Image")));
            this.picDynamos3.Location = new System.Drawing.Point(1078, 24);
            this.picDynamos3.Name = "picDynamos3";
            this.picDynamos3.Size = new System.Drawing.Size(52, 52);
            this.picDynamos3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDynamos3.TabIndex = 44;
            this.picDynamos3.TabStop = false;
            this.picDynamos3.Tag = "Dynamos";
            this.picDynamos3.WaitOnLoad = true;
            // 
            // picDynamos6
            // 
            this.picDynamos6.Image = ((System.Drawing.Image)(resources.GetObject("picDynamos6.Image")));
            this.picDynamos6.Location = new System.Drawing.Point(41, 24);
            this.picDynamos6.Name = "picDynamos6";
            this.picDynamos6.Size = new System.Drawing.Size(52, 52);
            this.picDynamos6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDynamos6.TabIndex = 42;
            this.picDynamos6.TabStop = false;
            this.picDynamos6.Tag = "Dynamos";
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox22.Location = new System.Drawing.Point(79, 179);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(3, 3);
            this.pictureBox22.TabIndex = 39;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "Star";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox21.Location = new System.Drawing.Point(128, 115);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(3, 3);
            this.pictureBox21.TabIndex = 38;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "Star";
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox20.Location = new System.Drawing.Point(59, 33);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(3, 3);
            this.pictureBox20.TabIndex = 37;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "Star";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox19.Location = new System.Drawing.Point(1069, 33);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(3, 3);
            this.pictureBox19.TabIndex = 36;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "Star";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.Location = new System.Drawing.Point(1083, 283);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(3, 3);
            this.pictureBox18.TabIndex = 35;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "Star";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Location = new System.Drawing.Point(1032, 115);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(3, 3);
            this.pictureBox17.TabIndex = 34;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "Star";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.Location = new System.Drawing.Point(59, 266);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(3, 3);
            this.pictureBox16.TabIndex = 33;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "Star";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Location = new System.Drawing.Point(288, 304);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(3, 3);
            this.pictureBox15.TabIndex = 32;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "Star";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Location = new System.Drawing.Point(657, 252);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(3, 3);
            this.pictureBox14.TabIndex = 31;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "Star";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox13.Location = new System.Drawing.Point(890, 62);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(3, 3);
            this.pictureBox13.TabIndex = 30;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "Star";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Location = new System.Drawing.Point(890, 293);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(3, 3);
            this.pictureBox12.TabIndex = 29;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "Star";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Location = new System.Drawing.Point(195, 259);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(3, 3);
            this.pictureBox11.TabIndex = 28;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "Star";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Location = new System.Drawing.Point(548, 228);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(3, 3);
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "Star";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Location = new System.Drawing.Point(548, 122);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(3, 3);
            this.pictureBox9.TabIndex = 26;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "Star";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Location = new System.Drawing.Point(692, 146);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(3, 3);
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "Star";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Location = new System.Drawing.Point(218, 94);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(3, 3);
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "Star";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(288, 221);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(3, 3);
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "Star";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(780, 266);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(3, 3);
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Star";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(313, 136);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(3, 3);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Star";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(839, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(3, 3);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Star";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(369, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3, 3);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Star";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(455, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3, 3);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Star";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1165, 586);
            this.Controls.Add(this.lblWave);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pgrHealth);
            this.Name = "Game";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDynamos5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDynamos4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDynamos3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDynamos6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSpaceShip;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.ProgressBar pgrHealth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.PictureBox picDynamos6;
        private System.Windows.Forms.PictureBox picDynamos5;
        private System.Windows.Forms.PictureBox picDynamos4;
        private System.Windows.Forms.PictureBox picDynamos3;
        private System.Windows.Forms.Timer tmrSpawn;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblWave;
    }
}

