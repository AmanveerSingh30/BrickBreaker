using System;
using System.Windows.Forms;

using System.Drawing;

using System.Media;

using System.Windows;




namespace BrickBreaker
{


    public partial class BrickBreakerForm : Form
    {

        Vector BallVelocity;
        Vector BallPosition;

        


        // Sounds for the game
        SoundPlayer startSound = new SoundPlayer(BrickBreaker.Properties.Resources.GameStart);
        SoundPlayer quitSound = new SoundPlayer(BrickBreaker.Properties.Resources.Quit);
        SoundPlayer CountDownSound = new SoundPlayer(BrickBreaker.Properties.Resources.GameCountdown);
        SoundPlayer blockHitSound = new SoundPlayer(BrickBreaker.Properties.Resources.BallHit1);
        SoundPlayer wallHitSound = new SoundPlayer(BrickBreaker.Properties.Resources.BallHit2);
        SoundPlayer blockSpeedSound = new SoundPlayer(BrickBreaker.Properties.Resources.SpeedUp);
        SoundPlayer paddleTouchSound = new SoundPlayer(BrickBreaker.Properties.Resources.BallPaddleHit);

        //GameTimer
        Timer GameTimer = new Timer();
      

        //To Display the Score
        string ScoreLabel;
        int Score = 0;



        //ScoreButton
        string[] AllScores;

        //Ball variables
        float Lvl1ballSpeed = 10;
        float Lvl2ballSpeed = 7;
        float Lvl3ballSpeed = 7;

        //Brick Variables
        int BrickWidth;
        int BrickHeight;

        //StartScreen Variables to Display
        StrtScreen StartScreenClass;

        int StartScreenRows;
        int StartScreenColumns;


        // Level1 Variables
        Lvl1 Lvl1Class;
        
       
        int Level1Rows;
        int Level1Columns;

        int Level1PositionX;
        int Level1PositionY;

        bool Level1Start = false;
       

        bool Level1Remove;

        int Level1NumLives;

        // Level2 Variables
       
        Lvl2 Lvl2Class;

        int Level2Rows;
        int Level2Columns;

        int Level2PositionX;
        int Level2PositionY;

        bool Level2Start = false;
    

        int Level2Stones;

        int Level2NumLives;

        bool Level2Remove;

        


        //Level3 Variables
        Lvl3 Lvl3Class;

        int Level3Rows;
        int Level3Columns;

        int Level3PositionX;
        int Level3PositionY;

        bool Level3Start = false;
     

        int Level3Stones;

        int Level3NumLives;

        bool Level3Remove;


    

        //OtherGameVariables
        bool GameOverWin;

        int NumLives;

        bool ReverseOn = false;



        public BrickBreakerForm()
        {
            InitializeComponent();
          
             StartScreenDisplay();
            AllScores = new string[3];
            AllScores[0] = "N/A";
            AllScores[1] = "N/A";
            AllScores[2] = "N/A";
        }



        public void StartScreenDisplay()
        {
           //Displaying the first screen with game menu and bricks on the side

            StartScreenRows = 25;
            StartScreenColumns = 15;
            BrickWidth = BrickImageList.ImageSize.Width;
            BrickHeight = BrickImageList.ImageSize.Height;


     

            StartScreenClass = new StrtScreen(this, BrickImageList, StartScreenRows, StartScreenColumns, BrickWidth, BrickHeight);

            StartScreenClass.AddBricks();

           

            picGameTitle.Visible = true;
            pnlMenu.Visible = true;
            btnRules.Visible = true;
            btnStartGame.Visible = true;
            btnQuit.Visible = true;
            btnScores.Visible = true;
            btnHome.Visible = false;
            picPaddle.Visible = false;
            picBall.Visible = false;
            btnLevel1.Visible = false;
            btnLevel2.Visible = false;
            btnLevel3.Visible = false;
            lblScore.Visible = false;
            btnPlayAgain.Visible = false;
            lblGameOver.Visible = false;
            lblAllScores.Visible = false;
            Level1Start = false;

        }


        public void RemoveStartScreenDisplay()
        {
            //Removing the bricks on teh start screen and the buttons

            StartScreenClass.RemoveBricks();

            picGameTitle.Visible = false;
            pnlMenu.Visible = false;
            btnRules.Visible = false;
            btnStartGame.Visible = false;
            btnScores.Visible = false;
            btnQuit.Visible = false;
            btnHome.Visible = false;

            btnLevel1.Visible = false;
            btnLevel2.Visible = false;
            btnLevel3.Visible = false;



        }



        public void Level1PicArray()
        {
         //Creating the bricks for the level to display

            Level1Rows = 6;
            Level1Columns = 6;
            BrickWidth = BrickImageList.ImageSize.Width;
            BrickHeight = BrickImageList.ImageSize.Height;
            Level1PositionX = (ClientRectangle.Width - BrickWidth * Level1Columns) / 2; ;
            Level1PositionY = 20;
            Level1NumLives = 2;

            Lvl1Class = new Lvl1(this, BrickImageList, Level1Rows, Level1Columns, Level1PositionX, Level1PositionY, Level1Start, BrickWidth, BrickHeight);
            Lvl1Class.AddBricks();
         

            
        }
       


        public void Level2PicArray()
        {

            //Creating the bricks for the level to display
            Level2Rows = 8;
            Level2Columns = 8;
            BrickWidth = BrickImageList.ImageSize.Width;
            BrickHeight = BrickImageList.ImageSize.Height;
            Level2PositionX = (ClientRectangle.Width - (BrickWidth * Level2Columns)) / 2; ;
            Level2PositionY = 30;
            Level2Stones = 7;
            Level2NumLives = 1;

            Lvl2Class = new Lvl2(this, BrickImageList, Level2Rows, Level2Columns, Level2PositionX, Level2PositionY, Level2Start, Level2Stones, BrickWidth, BrickHeight);
            Lvl2Class.AddBricks();
       



        }

       


        public void Level3PicArray()
        {
            //Creating the bricks for the level to display

            Level3Rows = 10;
            Level3Columns = 10;
            BrickWidth = BrickImageList.ImageSize.Width;
            BrickHeight = BrickImageList.ImageSize.Height;
            Level3PositionX = ((ClientRectangle.Width - (BrickWidth * Level3Columns)) / 2)-BrickWidth;
            Level3PositionY = 30+BrickHeight;
            Level3Stones = 10;
            Level3NumLives = 0;

            Lvl3Class = new Lvl3(this, BrickImageList, Level3Rows, Level3Columns, Level3PositionX, Level3PositionY, Level3Start, Level3Stones, BrickWidth, BrickHeight);
            Lvl3Class.AddBricks();
          
            

            
        }
       



        





        private void BrickBreakerForm_Load(object sender, EventArgs e)
        {
            // Center paddle on screen
            picPaddle.Left = (ClientRectangle.Width - picPaddle.Width) / 2;

            

            //Center ball on screen
            picBall.Left = (ClientRectangle.Width - picBall.Width) / 2;
            picBall.Top = ((ClientRectangle.Height - picBall.Height) / 2)+20;


            // Setup game timer
            GameTimer.Interval = 16; // Call timer every 16ms
            GameTimer.Tick += GameTimer_Tick;




        }

      

      

        

       



        

        private void GameTimer_Tick(object sender, EventArgs e)
        {

            

          

            //move the ball
            BallPosition = BallPosition + BallVelocity;
            picBall.Left = (int)BallPosition.X;
            picBall.Top = (int)BallPosition.Y;

            if (BallPosition.X < 0 || BallPosition.X > ClientRectangle.Width - picBall.Width)
            {
                wallHitSound.Play();
                BallVelocity.X = -BallVelocity.X;
            }
            //detect if the ball hits top 
            if (BallPosition.Y <= 0)
            {
                wallHitSound.Play();
                BallVelocity.Y = -1 * BallVelocity.Y;
            }

            //detect if the ball passes through bottom
            if (picBall.Top >= ClientSize.Height)
            {
                // Game Over
                if (NumLives == 0)
                {
                    ShowGameOver("Game Over");
                    
                }
                else
                {
                    GameTimer.Enabled = false;
                  
                    NumLives--;

                    if (Level1Start == true)
                        Lvl1Class.GamePlay(picBall, BallVelocity, blockHitSound, Score, Level1NumLives);
                    else if (Level2Start == true)
                    {
                        Lvl2Class.GamePlay(picBall, picPaddle, BallVelocity, blockHitSound, blockSpeedSound, Score, NumLives);
                        Resett();
                    }
                    else if (Level3Start == true)
                    {
                        Lvl3Class.GamePlay(picBall, picPaddle, BallVelocity, blockHitSound, blockSpeedSound, Score, NumLives);
                        Resett();
                    }


                    PicPositions();

                    // Center paddle on screen
                    picPaddle.Left = (ClientRectangle.Width - picPaddle.Width) / 2;

                    //Center ball on screen
                    picBall.Left = (ClientRectangle.Width - picBall.Width) / 2;
                    picBall.Top = ((ClientRectangle.Height - picBall.Height) / 2) + 20;

       
                    Countdown();
                    GameTimer.Enabled = true;
                }
                




            }



            // Detect collision with paddle
            if (picBall.Bounds.IntersectsWith(picPaddle.Bounds))
            {
                paddleTouchSound.Play();
                BallVelocity.Y = -BallVelocity.Y;
            }



            //Gameplay for each level
            if (Level1Start == true)
            {
                
                GameOverWin = Lvl1Class.GamePlay(picBall, BallVelocity, blockHitSound, Score, NumLives);
                BallVelocity = Lvl1Class.ballVelocity();
                lblScore.Text = Lvl1Class.scorelabel();
                Score = Lvl1Class.score();
                TotalScores(Score.ToString());
               
              
                if (GameOverWin == true)
                    ShowGameOver("You Win!");
            }
            if (Level2Start == true)
            {
                
                GameOverWin = Lvl2Class.GamePlay(picBall,picPaddle, BallVelocity, blockHitSound, blockSpeedSound, Score, NumLives);
                BallVelocity = Lvl2Class.ballVelocity();
                ReverseOn = Lvl2Class.Reverse();
                lblScore.Text = Lvl2Class.scorelabel();
                Score = Lvl2Class.score();
                TotalScores(Score.ToString());
                NumLives = Lvl2Class.LivesReturn();

                if (GameOverWin == true)
                    ShowGameOver("You Win!");
            }
            if (Level3Start == true)
            {
             
                GameOverWin = Lvl3Class.GamePlay(picBall,picPaddle, BallVelocity, blockHitSound, blockSpeedSound, Score, NumLives);
                BallVelocity = Lvl3Class.ballVelocity();
                ReverseOn = Lvl3Class.Reverse();
                lblScore.Text = Lvl3Class.scorelabel();
                Score = Lvl3Class.score();
                TotalScores(Score.ToString());
                NumLives = Lvl3Class.LivesReturn();

                if (GameOverWin == true)
                    ShowGameOver("You Win!");
            }





        }





        private void ShowGameOver(string text)
        {
            //Game over display 
            lblScore.Text = Score.ToString();

            
            lblGameOver.Text = text;
            lblGameOver.Left = (ClientRectangle.Width - lblGameOver.Width) / 2;
            lblGameOver.Top = 60;
            lblGameOver.Visible = true;
            GameTimer.Enabled = false;

            quitSound.Play();

            for (int i = 0; i < 10; ++i)
            {
                lblGameOver.Top += 15;
                Application.DoEvents();
                System.Threading.Thread.Sleep(45);
            }

          
            lblScore.Visible = true;
            System.Threading.Thread.Sleep(5000);

            if (Level1Remove == true)
                Lvl1Class.RemoveBricks();
            if (Level2Remove == true)
                Lvl2Class.RemoveBricks();
            if (Level3Remove == true)
                Lvl3Class.RemoveBricks();

            BrickBreakerForm.ActiveForm.BackgroundImage = BrickBreaker.Properties.Resources.Startimage;
            
            Level1Remove = false;
            Level2Remove = false;
            Level3Remove = false;

            Resett();
            StartScreenDisplay();

        }


        private void MovePaddle(int XPos)
        {
            if (ReverseOn == false)
            {
                if (XPos < 0)
                    XPos = 0;
                else if (XPos >= ClientRectangle.Width - picPaddle.Width)
                    XPos = ClientRectangle.Width - picPaddle.Width;

                picPaddle.Left = XPos;
            }
            else //Reverse power down is active
            {
                if (XPos < 0)
                    XPos = 0;
                else if (XPos >= ClientRectangle.Width - picPaddle.Width)
                    XPos = ClientRectangle.Width - picPaddle.Width;
                

                picPaddle.Left = ClientRectangle.Width - XPos;
            }

        }


        private void BrickBreakerForm_MouseMove(object sender, MouseEventArgs e)
        {


            MovePaddle(e.X);

        }

      
        
        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            //the screen display when pressed startgame
            picGameTitle.Visible = true;
            pnlMenu.Visible = true;
            btnRules.Visible = false;
            btnStartGame.Visible = false;
            btnScores.Visible = false;
            btnQuit.Visible = false;
            btnHome.Visible = true;
            picPaddle.Visible = false;
            picBall.Visible = false;


            btnLevel3.Visible = true;


            Level1Start = false;

            btnLevel1.Visible = true;
            btnLevel1.Left = (ClientRectangle.Width / 2) - picPaddle.Width + 30;
            btnLevel1.Top = 295;

            btnLevel2.Visible = true;
            btnLevel2.Left = (ClientRectangle.Width / 2) - picPaddle.Width + 30;
            btnLevel2.Top = 345;

            btnLevel3.Visible = true;
            btnLevel3.Left = (ClientRectangle.Width / 2) - picPaddle.Width + 30;
            btnLevel3.Top = 395;
        }

        private void TotalScores(string Score)
        {
            //Collecting the total scores and storing it in array for the scores button
            if (Level1Start == true)
            {
                AllScores[0] = Score;
            }
            if (Level2Start == true)
            {
                AllScores[1] = Score;
            }
            if (Level3Start == true)
            {
                AllScores[2] = Score;
            }

        }
        private void BtnScores_Click(object sender, EventArgs e)
        {
            //View all the previouse game played scores
            lblAllScores.Visible = true;
            lblAllScores.Left = 350;
            lblAllScores.Top = 300;
            lblAllScores.Font = new Font("Times New Roman", 18, FontStyle.Regular);
            lblAllScores.Text = "Level 1:" + AllScores[0] + "\n" + "\n" + "Level 2:" + AllScores[1] + "\n" + "\n" + "Level 3:" + AllScores[2];


            pnlMenu.Visible = false;
            btnRules.Visible = false;
            btnStartGame.Visible = false;
            btnScores.Visible = false;
            btnQuit.Visible = false;
            btnHome.Visible = true;

            
        }

        private void BtnRules_Click(object sender, EventArgs e)
        {
            lblAllScores.Visible = true;
            lblAllScores.Left = 125;
            lblAllScores.Top = 265;
            lblAllScores.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            lblAllScores.Text = "- Move the paddle to hit the ball and eliminate all the bricks to win!" + "\n" + "- If the ball falls past your paddle you lose!" + "\n" + "\n" +
                "- Watch out for the stones, hitting them will occasionally increase the speed of the ball depending on the level" +"\n" + "\n" +
                "-Be careful to catch falling power ups and avoid the power downs" + "\n" +
                "       Power-Ups: Long Paddle, Life Plus, Bullets(3 Bullets)" + "\n" + "               Bomb - there will be 1 bomb that triggers when you hit a brick in levels 2&3 blowing any few bricks around" + "\n" + "\n" +
                "       Power-Downs: Short Paddle, Inverse ";

            pnlMenu.Visible = false;
            btnRules.Visible = false;
            btnStartGame.Visible = false;
            btnScores.Visible = false;
            btnQuit.Visible = false;
            btnHome.Visible = true;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLevel1_Click(object sender, EventArgs e)
        {

            BrickBreakerForm.ActiveForm.BackgroundImage = BrickBreaker.Properties.Resources.Level1image;
            picBall.Image = PaddleBallImages.BallPokeBall;

            RemoveStartScreenDisplay();

            picPaddle.Visible = true;
            picBall.Visible = true;
            lblScore.Visible = true;
            Level1Start = true;
            Level1PicArray();
            PicPositions();
            NumLive();
            Countdown();
            GameTimer.Enabled = true;
            Level1Remove = true;
            GameOverWin = false;



            ResetAll();

        }

        private void BtnLevel2_Click(object sender, EventArgs e)
        {
            BrickBreakerForm.ActiveForm.BackgroundImage = BrickBreaker.Properties.Resources.Level2;
            picBall.Image = PaddleBallImages.BallfireBall;
            RemoveStartScreenDisplay();
            picPaddle.Visible = true;
            picBall.Visible = true;
            lblScore.Visible = true;
            Level2Start = true;
            Level2PicArray();
            PicPositions();
            NumLive();
            Countdown();
            GameTimer.Enabled = true;
            Level2Remove = true;
            GameOverWin = false;
            bool ReverseOn = false;

            ResetAll();
        }

        private void BtnLevel3_Click(object sender, EventArgs e)
        {
            BrickBreakerForm.ActiveForm.BackgroundImage = BrickBreaker.Properties.Resources.Level3;
            picBall.Image = PaddleBallImages.Ballasteroidball;

            RemoveStartScreenDisplay();
            picPaddle.Visible = true;
            picBall.Visible = true;
            lblScore.Visible = true;
            Level3Start = true;
            Level2Start = false;
            Level1Start = false;
            Level3PicArray();
            PicPositions();
            NumLive();
            Countdown();
            GameTimer.Enabled = true;
            Level3Remove = true;
            GameOverWin = false;
            bool ReverseOn = false;

            ResetAll();


        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            //when home button is clicked
            BrickBreakerForm.ActiveForm.BackgroundImage = BrickBreaker.Properties.Resources.Startimage;
          

            StartScreenClass.AddBricks();



            picGameTitle.Visible = true;
            pnlMenu.Visible = true;
            btnRules.Visible = true;
            btnStartGame.Visible = true;
            btnQuit.Visible = true;
            btnScores.Visible = true;
            btnHome.Visible = false;
            picPaddle.Visible = false;
            picBall.Visible = false;
            btnLevel1.Visible = false;
            btnLevel2.Visible = false;
            btnLevel3.Visible = false;
            lblScore.Visible = false;
            btnPlayAgain.Visible = false;
            lblGameOver.Visible = false;
            lblAllScores.Visible = false;


            Level1Start = false;



        }

        private void Countdown()
        {
            //counting down before the game starts
            lblCountdown.Visible = true;

            for (int i = 3; i > 0; i--)
            {
                lblCountdown.Text = i.ToString();
                Application.DoEvents();
                CountDownSound.Play();
                System.Threading.Thread.Sleep(1000);
            }


            lblCountdown.Visible = false;
            lblCountdown.Text = 3.ToString();

        }

        private void Resett()
        {

            if (Level2Start == true)
            {
                Lvl2Class.RemovePicBoxesLvl2();
               
            }

            if (Level3Start == true)
            {
                Lvl3Class.RemovePicBoxesLvl3();
            }
            
      

            GameOverWin = false;

            // Center paddle on screen
            picPaddle.Left = (ClientRectangle.Width - picPaddle.Width) / 2;

            //Center ball on screen
            picBall.Left = (ClientRectangle.Width - picBall.Width) / 2;
            picBall.Top = ((ClientRectangle.Height - picBall.Height) / 2) + 20;

            // Setup game timer
          //  GameTimer.Interval = 26; // Call timer every 16ms
            //GameTimer.Tick += GameTimer_Tick;
        }

        private void ResetAll()
        {
            Score = 0;
            lblScore.Text = "0";
            ReverseOn = false;
            picPaddle.Height = 10;
            picPaddle.Width = 76;
    //////////////////////////////////////////////////////////////        picPaddle.Image = PaddleBallImages.PaddleShort;

            if (Level2Start == true)
            {
                Lvl2Class.RemovePicBoxesLvl2();
                Lvl2Class.ResetLvl2();
            }

            if (Level3Start == true)
            {
                Lvl3Class.RemovePicBoxesLvl3();
                Lvl3Class.ResetLvl3();
            }


        }
        private void PicPositions()
        {
            //Postioning and Starting velocity of the ball

            float Width = (ClientSize.Width + picBall.Width) / 2;
            float Height = ((ClientSize.Height + picBall.Height) / 2) + 20;
            BallPosition = new Vector(Width, Height);

            float Angle = FindRandomAngle();
            if (Level1Start == true)
            {
                float Vx = Lvl1ballSpeed * (float)Math.Cos(Angle);
                float Vy = Lvl1ballSpeed * (float)Math.Sin(Angle);
                BallVelocity = new Vector(Vx, Vy);
            }
            if (Level2Start == true)
            {
                float Vx = Lvl2ballSpeed * (float)Math.Cos(Angle);
                float Vy = Lvl2ballSpeed * (float)Math.Sin(Angle);
                BallVelocity = new Vector(Vx, Vy);
            }
            if (Level3Start == true)
            {
                float Vx = Lvl3ballSpeed * (float)Math.Cos(Angle);
                float Vy = Lvl3ballSpeed * (float)Math.Sin(Angle);
                BallVelocity = new Vector(Vx, Vy);
            }

        }
        private float FindRandomAngle()
        {
            //generate a random angle for the ball
            Random RandomAngle = new Random();
            float Angle;
            int R = 0;
            R = RandomAngle.Next(1, 5);
            if (R == 3)
            {
                while (R == 3)
                {
                    R = RandomAngle.Next(1, 5);
                }
            }
            else
            {
                R = RandomAngle.Next(1, 5);
            }
            //convert angle to radian from degrees

            Angle = 2 * 30 * (float)Math.PI / 180;

            if (R == 1)
            {
                Angle = 30 * (float)Math.PI / 180;
            }
            if (R == 2)
            {
                Angle = 60 * (float)Math.PI / 180;
            }
            if (R == 4)
            {
                Angle = 120 * (float)Math.PI / 180;
            }
            if (R == 5)
            {
                Angle = 150 * (float)Math.PI / 180;
            }



            return Angle;
        }
        private void NumLive()
        {
            if (Level1Start == true)
                NumLives = Level1NumLives;
            else if (Level2Start == true)
                NumLives = Level2NumLives;
            else if (Level3Start == true)
                NumLives = Level3NumLives;

        }
    }      
                
}














