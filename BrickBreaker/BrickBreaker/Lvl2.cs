using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Schema;
using System.Media;
using System.Runtime.CompilerServices;
using System.Windows;
using System.ComponentModel;
using System.Data;
using System.Resources;

namespace BrickBreaker
{
    class Lvl2
    {
        //Private Members
        private PictureBox[,] mLevel2;
        private ImageList mBrickImageList;
        private Form mBrickBreakerForm;
        private Vector mBallVelocity;

        private int mLevel2Rows;
        private int mLevel2Columns;

        private int mLevel2PositionX;
        private int mLevel2PositionY;
        
        private int mBrickWidth;
        private int mBrickHeight;

        private bool mLevel2Start = false;
        private int mLevel2BlockCount;

        private string mScoreLabel;
        private int mScore;
        private int mStoneCounter;
        private int mLevel2Stones;

        private bool mGameOverWin;

        //////////////////////////////////powerups
        private PictureBox mpicPaddle;

        //LongPaddle
        private PictureBox[,] mLevel2LongPaddle;

        //Lives
        private PictureBox[,] mLevel2Lives;
        private PictureBox[,] mLevel2PowerLives;
        private int mLevel2NumLives;
        private bool mLifeUp;

        //Bullet
        private PictureBox[,] mLevel2PowerBullets;
        private PictureBox[] mBullet;
        private bool mBulletActivate = false;
        private double mBulletYP1 = 1.01;
        private double mBulletYP2 = 1.01;
        private double mBulletYP3 = 1.01;
        
        private int mBullet2Counter = 0;
        private int mBullet3Counter = 0;

        //Bomb
        private int[,] mLevel2PowerBomb;
        private bool mBombActivate;


        /// /////////////////////////////powerdowns
        //ShortPaddle
        private PictureBox[,] mLevel2ShortPaddle;

        //Reverse
        private PictureBox[,] mLevel2Reverse;
        private bool mReverseOn = false;
        private double mReverseCounter = 0;


        //Properties
        public Form BrickBreakerForm
        {
            get { return mBrickBreakerForm; }
            set { mBrickBreakerForm = value; }
        }

        public PictureBox[,] Level2
        {
            get { return mLevel2; }
            set { mLevel2 = value; }
        }

        public PictureBox picPaddle
        {
            get { return mpicPaddle; }
            set { mpicPaddle = value; }
        }
        public ImageList BrickImageList
        {
            get { return mBrickImageList; }
            set { mBrickImageList = value; }
        }
        public int Level2Rows
        {
            get { return mLevel2Rows; }
            set { mLevel2Rows = value; }
        }

        public int Level2Columns
        {
            get { return mLevel2Columns; }
            set { mLevel2Columns = value; }
        }

        public int Level2PositionX
        {
            get { return mLevel2PositionX; }
            set { mLevel2PositionX = value; }
        }

        public int Level2PositionY
        {
            get { return mLevel2PositionY; }
            set { mLevel2PositionY = value; }
        }

        public int Level2BlockCount
        {
            get { return mLevel2BlockCount; }
            set { mLevel2BlockCount = value; }
        }

        public int BrickWidth
        {
            get { return mBrickWidth; }
            set { mBrickWidth = value; }
        }
        public int BrickHeight
        {
            get { return mBrickHeight; }
            set { mBrickHeight = value; }
        }
        public int Score
        {
            get { return mScore; }
            set { mScore = value; }
        }

        public int StoneCounter
        {
            get { return mStoneCounter; }
            set { mStoneCounter = value; }
        }
        public int Level2Stones
        {
            get { return mLevel2Stones; }
            set { mLevel2Stones = value; }
        }

        public string ScoreLabel
        {
            get { return mScoreLabel; }
            set { mScoreLabel = value; }
        }

        public Vector BallVelocity
        {
            get { return mBallVelocity; }
            set { mBallVelocity = value; }
        }

        public bool Level2Start
        {
            get { return mLevel2Start; }
            set { mLevel2Start = value; }
        }

        public PictureBox[,] Level2LongPaddle
        {
            get { return mLevel2LongPaddle; }
            set { Level2LongPaddle = value; }
        }
        public int Level2NumLives
        {
            get { return mLevel2NumLives; }
            set { mLevel2NumLives = value; }
        }






        //Constructor
        public Lvl2(Form BrickBreakerForm, ImageList BrickImageList, int Level2Rows, int Level2Columns, int Level2PositionX, int Level2PositionY, bool Level2Start, int Level2Stones,  int BrickWidth, int BrickHeight)
        {

            mBrickBreakerForm = BrickBreakerForm;
            mBrickImageList = BrickImageList;

            mLevel2Rows = Level2Rows;
            mLevel2Columns = Level2Columns;

            mLevel2PositionX = Level2PositionX;
            mLevel2PositionY = Level2PositionY;

            mLevel2Start = Level2Start;

            mBrickWidth = BrickWidth;
            mBrickHeight = BrickHeight;

            mLevel2Stones = Level2Stones;

            mLevel2 = new PictureBox[mLevel2Rows, mLevel2Columns];



            Random rand = new Random();

            mStoneCounter = 0;
            int Index = 0;

            for (int i = 0; i < mLevel2Rows; i++)
            {

                for (int j = 0; j < mLevel2Columns; j++)
                {
                    mLevel2[i, j] = new PictureBox();
                    mLevel2[i, j].Visible = true;
                    mLevel2[i, j].Height = mBrickHeight;
                    mLevel2[i, j].Width = mBrickWidth;

                    if (mStoneCounter <= mLevel2Stones - 1)
                    {
                        Index = rand.Next(0, mBrickImageList.Images.Count);
                        if (Index == 8)
                            mStoneCounter++;
                    }
                    else if (mStoneCounter == mLevel2Stones)
                    {
                        do
                        {
                            Index = rand.Next(0, mBrickImageList.Images.Count);



                        } while (Index == 8);
                    }

                    if (Index == 8 && mStoneCounter == 7)
                       ;


                    Index = rand.Next(0, mBrickImageList.Images.Count);
                    mLevel2[i, j].Image = mBrickImageList.Images[Index];
                    mLevel2[i, j].Tag = Index;


                }

            }
            mLevel2BlockCount = (mLevel2Rows * mLevel2Columns) - mStoneCounter;
            //BlockCount();







            //////Long Paddle
            mLevel2LongPaddle = new PictureBox[mLevel2Rows, mLevel2Columns];

            //2 of these powerups
            int Row;
            int Col;
            
            for (int i = 0; i < 2; i++)
            {
                Row = rand.Next(0, mLevel2Rows);
                Col = rand.Next(0, mLevel2Columns);

                mLevel2LongPaddle[Row, Col] = new PictureBox();
                mLevel2LongPaddle[Row, Col].Visible = false;
                mLevel2LongPaddle[Row, Col].Height = mBrickHeight;
                mLevel2LongPaddle[Row, Col].Width = mBrickWidth;
                mLevel2LongPaddle[Row, Col].Image = PowerImages.PaddleLong;
            }


            ////////////////Lives
                ///Picture boxes at  the bottom
                mLevel2Lives = new PictureBox[1, 10];
            int pX = 22;
            int pY = 450;
            for (int j = 0; j < 1; j++)
            {
                mLevel2Lives[0, j] = new PictureBox();

                mLevel2Lives[0, j].Visible = true;
                mLevel2Lives[0, j].Height = 25;
                mLevel2Lives[0, j].Width = 27;
                mLevel2Lives[0, j].Left = pX;
                mLevel2Lives[0, j].Top = pY;


                mLevel2Lives[0, j].Image = PowerImages.Life;
                mLevel2Lives[0, j].BackColor = Color.Transparent;

                pX += 30;


            }

            //Lives power falling downnn
            mLevel2PowerLives = new PictureBox[mLevel2Rows, mLevel2Columns];

            //1 of this power up
            Row = rand.Next(0, mLevel2Rows);
            Col = rand.Next(0, mLevel2Columns);

            mLevel2PowerLives[Row, Col] = new PictureBox();
            mLevel2PowerLives[Row, Col].Visible = false;
            mLevel2PowerLives[Row, Col].Height = mBrickHeight;
            mLevel2PowerLives[Row, Col].Width = mBrickWidth;
            mLevel2PowerLives[Row, Col].Image = PowerImages.Life;
            mLevel2PowerLives[Row, Col].BackColor = Color.Transparent;



            /////////Bullets
            ///
            mBullet = new PictureBox[3];
            ///
            mLevel2PowerBullets = new PictureBox[mLevel2Rows, Level2Columns];

            //1 of this power up
            Row = rand.Next(0, mLevel2Rows);
            Col = rand.Next(0, mLevel2Columns);

            mLevel2PowerBullets[Row, Col] = new PictureBox();
            mLevel2PowerBullets[Row, Col].Visible = false;
            mLevel2PowerBullets[Row, Col].Height = 12;
            mLevel2PowerBullets[Row, Col].Width = 8;
            mLevel2PowerBullets[Row, Col].Image = PowerImages.BulletLvl2;
            mLevel2PowerBullets[Row, Col].BackColor = Color.Transparent;



            ////////////Bomb
            mLevel2PowerBomb = new int[mLevel2Rows, mLevel2Columns];

            //1 of this power up
            Row = rand.Next(0, mLevel2Rows);
            Col = rand.Next(0, mLevel2Columns);

            mLevel2PowerBomb[Row, Col] = new int();
            mLevel2PowerBomb[Row, Col] = 1;




            //////Short Paddle
            mLevel2ShortPaddle = new PictureBox[mLevel2Rows, mLevel2Columns];

            //4 of these powerdowns
            for(int i = 0; i< 4; i++)
            {
                Row = rand.Next(0, mLevel2Rows);
                Col = rand.Next(0, mLevel2Columns);

                mLevel2ShortPaddle[Row, Col] = new PictureBox();
                mLevel2ShortPaddle[Row, Col].Visible = false;
                mLevel2ShortPaddle[Row, Col].Height = mBrickHeight;
                mLevel2ShortPaddle[Row, Col].Width = mBrickWidth;
                mLevel2ShortPaddle[Row, Col].Image = PowerImages.PaddleShort;
            }

            //////Reverse
            mLevel2Reverse = new PictureBox[mLevel2Rows, mLevel2Columns];

            //2 of these powerdowns
            for (int i = 0; i < 2; i++)
            {
                Row = rand.Next(0, mLevel2Rows);
                Col = rand.Next(0, mLevel2Columns);

                mLevel2Reverse[Row, Col] = new PictureBox();
                mLevel2Reverse[Row, Col].Visible = false;
                mLevel2Reverse[Row, Col].Height = 20;
                mLevel2Reverse[Row, Col].Width = 20;
                mLevel2Reverse[Row, Col].Image = PowerImages.Reverse; ;
            }









        }

        

        //Methods
        public void AddBricks()
        {
            Random rand = new Random();
            int pX = mLevel2PositionX;
            int pY = mLevel2PositionY;

            for (int i = 0; i < mLevel2Rows; i++)
            {
                pX = mLevel2PositionX;
                for (int j = 0; j < mLevel2Columns; j++)
                {
                    mLevel2[i, j].Left = pX;
                    mLevel2[i, j].Top = pY;
                    pX += mBrickWidth;

                    mBrickBreakerForm.Controls.Add(mLevel2[i, j]);//To add the Picture Box to form.
                }
                pY += mBrickHeight;
            }
            //Lives at bottom
            mBrickBreakerForm.Controls.Add(mLevel2Lives[0, 0]);
            mBrickBreakerForm.Controls.Add(mLevel2Lives[0, 1]);

        }

        public void RemoveBricks()
        {
            for (int i = 0; i < mLevel2Rows; i++)
            {
                for (int j = 0; j < mLevel2Columns; j++)
                {
                    mBrickBreakerForm.Controls.Remove(mLevel2[i, j]);//To remove the Picture Box to form.
                    mLevel2[i, j] = null;//To remove the Picture Box to form.
                }

            }
            //Lives at bottom
            mBrickBreakerForm.Controls.Remove(mLevel2Lives[0, 0]);
            mBrickBreakerForm.Controls.Remove(mLevel2Lives[0, 1]);
        }

        public int BlockCount()
        {
            mLevel2BlockCount = (mLevel2Rows * mLevel2Columns) - mLevel2Stones;
            return mLevel2BlockCount;
        }

        public bool GamePlay(PictureBox picBall,PictureBox picPaddle, Vector BallVelocity, SoundPlayer blockHitSound, SoundPlayer blockSpeedSound, int Score, int NumLives)
        {
            mpicPaddle = picPaddle;
            mBallVelocity.X = BallVelocity.X;
            mBallVelocity.Y = BallVelocity.Y;
            mScore = Score;

            
            mLevel2NumLives = NumLives;
            
            //Removing lives
            if (mLevel2NumLives == 1)
            {
                mBrickBreakerForm.Controls.Remove(mLevel2Lives[0, 1]);
            }
            if (mLevel2NumLives == 0)
            {
                mBrickBreakerForm.Controls.Remove(mLevel2Lives[0, 0]);
            }
            //If reverse power down active 
            if(mReverseOn == true)
            {
                Reverse();
            }

            for (int i = 0; i < mLevel2Rows; i++)
            {
                for (int j = 0; j < mLevel2Columns; j++)
                {
                    //Check if the falling power downs or ups are collected by the paddle
                    CheckLongPowerCollect(i, j);

                    CheckLivesCollect(i, j);

                    CheckBulletsCollect(i, j);

                    CheckShortPowerCollect(i, j);

                    CheckReverseCollect(i, j);

                 
                    Bullets();

                    

                    if (mBulletActivate == true)
                    {
                        BulletsHit(i, j, picBall, blockSpeedSound, blockHitSound);
                    }


                    if (mLevel2[i, j] != null)
                    {
                       

                        if (picBall.Bounds.IntersectsWith(mLevel2[i, j].Bounds))
                        {
                            mLevel2BlockCount -= 1;

                            //Checks if any bricks that contain a power up/down are hit so than the power can fall down
                            CheckLongPowerHit(i, j);

                            CheckLivesHit(i, j);

                            CheckBulletPowerHit(i, j);

                            CheckBombPowerHit(i, j);

                            CheckShortPowerHit(i, j);

                            CheckReversePowerHit(i, j);






                            if (mLevel2[i, j] != null)
                            {

                                if ((int)mLevel2[i, j].Tag == 8)
                                {
                                    //to figure if its a stone
                                    mLevel2BlockCount += 1;

                                    mBallVelocity.X = 1.005 * mBallVelocity.X;
                                    mBallVelocity.Y = 1.005 * -mBallVelocity.Y;



                                    blockSpeedSound.Play();
                                }
                                else if (mLevel2BlockCount == 0)
                                {
                                    //figure if the game ends
                                    mBrickBreakerForm.Controls.Remove(mLevel2[i, j]);
                                    mLevel2[i, j] = null;

                                    RemovePicBoxesLvl2();

                                    mGameOverWin = true;
                                    return mGameOverWin;

                                    
                                }
                                else if (mLevel2BlockCount >= 1)
                                {
                                    //if there are remaining bocks the game continues
                                    mBallVelocity.Y = -BallVelocity.Y;
                                    blockHitSound.Play();
                                    mScore += 1;
                                    mScoreLabel = mScore.ToString();


                                    mBrickBreakerForm.Controls.Remove(Level2[i, j]);
                                    mLevel2[i, j] = null;
                                    mGameOverWin = false;
                                    return mGameOverWin;
                                }
                            }
                            mGameOverWin = false;
                            return mGameOverWin;
                        }
                    }
                }
            }
            mGameOverWin = false;
            return mGameOverWin;
            
        }



        public int score()
        {
            return mScore;
        }
        public string scorelabel()
        {
            return mScoreLabel;
        }
        public Vector ballVelocity()
        {
            return mBallVelocity;
        }


        //Long Paddle powerup
        public void CheckLongPowerHit(int i, int j)
        {
            if (mLevel2LongPaddle[i, j] != null)
            {
                mLevel2LongPaddle[i, j].Left = mLevel2[i, j].Left;
                mLevel2LongPaddle[i, j].Top = mLevel2[i, j].Top;
                mLevel2LongPaddle[i, j].Visible = true; ;
                mBrickBreakerForm.Controls.Add(mLevel2LongPaddle[i, j]);
            }
        }

        public void CheckLongPowerCollect(int i, int j)
        {
            if (mLevel2LongPaddle[i, j] != null)
            {
                if (mLevel2LongPaddle[i, j].Visible == true)
                {
                    mLevel2LongPaddle[i, j].Top += 3;

                    if (mLevel2LongPaddle[i, j].Bounds.IntersectsWith(mpicPaddle.Bounds))
                    {
                        PaddleLong();
                        mBrickBreakerForm.Controls.Remove(mLevel2LongPaddle[i, j]);
                        mLevel2LongPaddle[i, j] = null;
                    }
                }

            }
        }

        public void PaddleLong()
        {
            mpicPaddle.Image = null;
            System.Drawing.Size picPaddleLongSize = new System.Drawing.Size(mpicPaddle.Width+10, mpicPaddle.Height);
            
            mpicPaddle.Size = picPaddleLongSize;
        }

        //Lives
        public void CheckLivesHit(int i, int j)
        {
            if (mLevel2PowerLives[i, j] != null)
            {
                if (mLevel2PowerLives[i, j].Visible == false)
                {

                    mLevel2PowerLives[i, j].Left = mLevel2[i, j].Left;
                    mLevel2PowerLives[i, j].Top = mLevel2[i, j].Top;
                    mLevel2PowerLives[i, j].Visible = true; ;

                    mBrickBreakerForm.Controls.Add(mLevel2PowerLives[i, j]);
                }
            

            }
        }

        public void CheckLivesCollect(int i, int j)
        {
            if (mLevel2PowerLives[i, j] != null)
            {
                if (mLevel2PowerLives[i, j].Visible == true)
                {
                    mLevel2PowerLives[i, j].Top += 3;

                    if (mLevel2PowerLives[i, j].Bounds.IntersectsWith(mpicPaddle.Bounds))
                    {
                        Lives();
                        mBrickBreakerForm.Controls.Remove(mLevel2PowerLives[i,j]);
                        mLevel2PowerLives[i, j] = null;
                    }
                }

            }
        }

        public void Lives()
        {
            int pX = 22;
            int pY = 450;

            for (int j = 0; j < 5; j++)
            {
                if (mLevel2NumLives == j)
                {
                    mLevel2Lives[0, j] = new PictureBox();
                    mLevel2Lives[0, j].Height = 25;
                    mLevel2Lives[0, j].Width = 27;
                    mLevel2Lives[0, j].Left = pX;
                    mLevel2Lives[0, j].Top = pY;
                    mLevel2Lives[0, j ].Image = PowerImages.Life;
                    mBrickBreakerForm.Controls.Add(mLevel2Lives[0, j]);
                    mLifeUp = true;
                    
                }
                pX += 30;
            }

            
           

        }

        public int LivesReturn()
        {
            if(mLifeUp == true)
            {
                mLevel2NumLives++;
                mLifeUp = false;
                return mLevel2NumLives;
                
            }
            return mLevel2NumLives;
        }

        //Bullets
        public void CheckBulletPowerHit(int i, int j)
        {
            if (mLevel2PowerBullets[i, j] != null)
            {
                if (mLevel2PowerBullets[i, j].Visible == false)
                {

                    mLevel2PowerBullets[i, j].Left = mLevel2[i, j].Left;
                    mLevel2PowerBullets[i, j].Top = mLevel2[i, j].Top;
                    mLevel2PowerBullets[i, j].Visible = true; ;

                    mBrickBreakerForm.Controls.Add(mLevel2PowerBullets[i, j]);
                }


            }
        }
        public void CheckBulletsCollect(int i, int j)
        {
            if (mLevel2PowerBullets[i, j] != null)
            {
                if (mLevel2PowerBullets[i, j].Visible == true)
                {
                    mLevel2PowerBullets[i, j].Top += 3;

                    if (mLevel2PowerBullets[i, j].Bounds.IntersectsWith(mpicPaddle.Bounds))
                    {
                        mBulletActivate = true;

                        for(int f = 0; f < mBullet.GetLength(0);f++)
                        {
                            mBullet[f] = new PictureBox();
                            mBullet[f].Visible = true;
                            mBullet[f].Height = 20;
                            mBullet[f].Width = 10;
                            mBullet[f].Left = mpicPaddle.Left;//mpicPaddle.Left;
                            mBullet[f].Top = mpicPaddle.Top;// mpicPaddle.Top;
                            mBullet[f].Image = PowerImages.BulletLvl2;
                            
                        }
                        mBrickBreakerForm.Controls.Add(mBullet[0]);


                        mBrickBreakerForm.Controls.Remove(mLevel2PowerBullets[i, j]);
                        mLevel2PowerBullets[i, j] = null;
                    }
                }

            }
        }

        public void Bullets()
        {
            

            if (mBulletActivate == true)
            {
                if (mBullet[0] != null)
                {
                    mBullet[0].Top = mpicPaddle.Top - (int)mBulletYP1;
                    mBulletYP1 = mBulletYP1 + 0.07;
                }


                mBullet2Counter++;

                if (mBullet[1] != null)
                {
                    if (mBullet2Counter >= 4000)
                    {
                        if (mBullet2Counter == 4001)
                        {
                            mBullet[1].Left = mpicPaddle.Left;
                            mBrickBreakerForm.Controls.Add(mBullet[1]);
                        }
                        mBullet[1].Top = mpicPaddle.Top - (int)mBulletYP2;

                        mBulletYP2 = mBulletYP2 + 0.07;
                    }
                }


                mBullet3Counter++;

                if (mBullet[2] != null)
                {
                    if (mBullet3Counter >= 8000)
                    {
                        if (mBullet3Counter == 8001)
                        {
                            mBullet[2].Left = mpicPaddle.Left;
                            mBrickBreakerForm.Controls.Add(mBullet[2]);
                        }
                        mBullet[2].Top = mpicPaddle.Top - (int)mBulletYP3;
                        mBulletYP3 = mBulletYP3 + 0.07;
                    }
                }
                else
                {
                    mBulletActivate = false;
                }
               
               
                

                


            }
        }
        public void BulletsHit(int i, int j, PictureBox picBall, SoundPlayer blockSpeedSound, SoundPlayer blockHitSound)
        {
            if (mBulletActivate == true)
            {
                if (mLevel2[i,j] != null)
                {
                    for (int f = 0; f < mBullet.GetLength(0); f++)
                    {
                        if (mBullet[f] != null)
                        {
                            if (mLevel2[i, j] != null && mBullet[f].Bounds.IntersectsWith(mLevel2[i, j].Bounds))
                            {
                                mLevel2BlockCount -= 1;


                                CheckLongPowerHit(i, j);

                                CheckLivesHit(i, j);

                                CheckBulletPowerHit(i, j);

                                CheckBombPowerHit(i, j);

                                CheckShortPowerHit(i, j);








                                if ((int)mLevel2[i, j].Tag == 8)
                                {
                                    //to figure if its a stone
                                    mLevel2BlockCount += 1;
                                    mBrickBreakerForm.Controls.Remove(mBullet[f]);
                                    mBullet[f] = null;

                                }
                                else if (mLevel2BlockCount == 0)
                                {
                                    mBrickBreakerForm.Controls.Remove(mLevel2[i, j]);
                                    mBrickBreakerForm.Controls.Remove(mBullet[f]);
                                    mLevel2[i, j] = null;
                                    mBullet[f] = null;

                                    mGameOverWin = true;

                                }
                                else if (mLevel2BlockCount >= 1)
                                {

                                    mScore += 1;
                                    mScoreLabel = mScore.ToString();

                                    mBrickBreakerForm.Controls.Remove(mBullet[f]);
                                    mBullet[f] = null;
                                    mBrickBreakerForm.Controls.Remove(Level2[i, j]);
                                    mLevel2[i, j] = null;
                                    mGameOverWin = false;

                                }


                            }
                        }
                    }
                }
            }
            
        }

        //Bomb
        public void CheckBombPowerHit(int i, int j)
        {
            if (mLevel2PowerBomb[i, j] == 1)
            {
                
                    Bomb(0, 0, j, i);
                    Shake();
                    Opacity();
                    mBombActivate = false;
                mLevel2PowerBomb[i, j] = 0;

            }
        }

        public void Bomb(int r, int c, int j, int i)
        {
            //record the current value in array

            //Path += "M[" + r + ", " + c + "]  ";

            //check to move right
            if (c < mLevel2Columns - 1)
                Bomb(r, c + 1, j, i);
            //check to move down
            if (r < mLevel2Rows - 1)
                Bomb(r + 1, c, j, i);


            //check if at the end position

            //bottom right
            if (i == mLevel2Rows - 1 && j == mLevel2Columns - 1)
            {
                if (mLevel2[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i - 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i, j - 1] != null)
                {
                    if (c == j - 1 && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i - 1, j] != null)
                {
                    if (c == j && r == i - 1)
                        GamePlayBomb(r, c);
                }
            }

            //bottom left
            else if (i == mLevel2Rows - 1 && j == 0)
            {
                if (mLevel2[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i - 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i - 1, j] != null)
                {
                    if (c == j && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i, j + 1] != null)
                {
                    if (c == j + 1 && r == i)
                        GamePlayBomb(r, c);
                }
            }

            //top right
            else if (i == 0 && j == mLevel2Columns - 1)
            {
                if (mLevel2[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i, j - 1] != null)
                {
                    if (c == j - 1 && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i + 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i + 1, j] != null)
                {
                    if (c == j && r == i + 1)
                        GamePlayBomb(r, c);
                }
            }

            //top left
            else if (i == 0 && j == 0)
            {
                if (mLevel2[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i + 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i, j + 1] != null)
                {
                    if (c == j + 1 && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i + 1, j] != null)
                {
                    if (c == j && r == i + 1)
                        GamePlayBomb(r, c);
                }
            }

            //top row
            else if (i == 0)
            {
                if (mLevel2[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i + 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i + 1, j] != null)
                {
                    if (c == j && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i + 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
            }

            //bottom row
            else if (i == mLevel2Rows - 1)
            {
                if (mLevel2[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i - 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i - 1, j] != null)
                {
                    if (c == j && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i - 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
            }

            //left first column
            else if (j == 0)
            {
                if (mLevel2[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i - 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i + 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i, j + 1] != null)
                {
                    if (c == j + 1 && r == i)
                        GamePlayBomb(r, c);
                }
            }

            //right last column
            else if (j == mLevel2Columns - 1)
            {
                if (mLevel2[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i - 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i , j - 1] != null)
                {
                    if (c == j - 1 && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i + 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
            }

            //in middle
            else
            {
                if (mLevel2[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                   
                }
                if (mLevel2[i + 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i - 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i + 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel2[i - 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
            }






           

        }

        public void GamePlayBomb(int r, int c)
        {
            mLevel2BlockCount -= 1;

            CheckLongPowerHit(r, c);

            CheckLivesHit(r, c);

            CheckBulletPowerHit(r, c);


            CheckShortPowerHit(r, c);


            if ((int)mLevel2[r, c].Tag == 8)
            {
                //to figure if its a stone
                mLevel2BlockCount += 1;

            }
            else if (mLevel2BlockCount == 0)
            {
                mBrickBreakerForm.Controls.Remove(mLevel2[r, c]);

                mLevel2[r, c] = null;


                mGameOverWin = true;

            }
            else if (mLevel2BlockCount >= 1)
            {

                mScore += 1;
                mScoreLabel = mScore.ToString();



                mBrickBreakerForm.Controls.Remove(Level2[r, c]);
                mLevel2[r, c] = null;
                mGameOverWin = false;

            }
        }
        public void Shake()
        {
            var original = mBrickBreakerForm.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                mBrickBreakerForm.Location = new System.Drawing.Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            mBrickBreakerForm.Location = original;
        }

        public void Opacity()
        {
            mBrickBreakerForm.Opacity = 0.1;
            System.Threading.Thread.Sleep(100);
            mBrickBreakerForm.Opacity = 1;
            System.Threading.Thread.Sleep(100);
            mBrickBreakerForm.Opacity = 0.1;
            System.Threading.Thread.Sleep(100);
            mBrickBreakerForm.Opacity = 1;
            System.Threading.Thread.Sleep(100);
            mBrickBreakerForm.Opacity = 0.1;
            System.Threading.Thread.Sleep(100);
            mBrickBreakerForm.Opacity = 1;

        }


        //Short Paddle PowerDown
        public void CheckShortPowerHit(int i, int j)
        {
            if (mLevel2ShortPaddle[i, j] != null)
            {
                if (mLevel2ShortPaddle[i, j].Visible == false)
                {
                    mLevel2ShortPaddle[i, j].Left = mLevel2[i, j].Left;
                    mLevel2ShortPaddle[i, j].Top = mLevel2[i, j].Top;
                    mLevel2ShortPaddle[i, j].Visible = true; ;
                   
                    mBrickBreakerForm.Controls.Add(mLevel2ShortPaddle[i, j]);
                }
            }
        }

        public void CheckShortPowerCollect(int i, int j)
        {
            if (mLevel2ShortPaddle[i, j] != null)
            {
                if (mLevel2ShortPaddle[i, j].Visible == true)
                {
                    mLevel2ShortPaddle[i, j].Top += 3;

                    if (mLevel2ShortPaddle[i, j].Bounds.IntersectsWith(mpicPaddle.Bounds))
                    {
                        PaddleShort();
                        mBrickBreakerForm.Controls.Remove(mLevel2ShortPaddle[i, j]);
                        mLevel2ShortPaddle[i, j] = null;
                    }
                }

            }
        }

        public void PaddleShort()
        {
            mpicPaddle.Image = null;
            System.Drawing.Size picPaddleShortSize = new System.Drawing.Size(mpicPaddle.Width - 10, mpicPaddle.Height);

            mpicPaddle.Size = picPaddleShortSize;
        }


        //Revrese
        public void CheckReversePowerHit(int i, int j)
        {
            if (mLevel2Reverse[i, j] != null)
            {
                if (mLevel2Reverse[i, j].Visible == false)
                {
                    mLevel2Reverse[i, j].Left = mLevel2[i, j].Left;
                    mLevel2Reverse[i, j].Top = mLevel2[i, j].Top;
                    mLevel2Reverse[i, j].Visible = true;
                   
                    mBrickBreakerForm.Controls.Add(mLevel2Reverse[i, j]);
                }
            }
        }

        public void CheckReverseCollect(int i, int j)
        {
            if (mLevel2Reverse[i, j] != null)
            {
                if (mLevel2Reverse[i, j].Visible == true)
                {
                    mLevel2Reverse[i, j].Top += 3;

                    if (mLevel2Reverse[i, j].Bounds.IntersectsWith(mpicPaddle.Bounds))
                    {
                        mReverseOn = true;
                        mBrickBreakerForm.Controls.Remove(mLevel2Reverse[i, j]);
                        mLevel2Reverse[i, j] = null;
                    }
                }

            }
        }

        public bool Reverse()
        {

           

            if (mReverseOn == true)
            {
                //mpicPaddle.Left = mBrickBreakerForm.ClientSize.Width - mpicPaddle.Left;

                mReverseCounter = mReverseCounter + 0.1;

                if (mReverseCounter == 50)
                {
                    mReverseOn = false;
                }
            }
            return mReverseOn;
         
        }


        public void RemovePicBoxesLvl2()
        {
            //Removing the pictureboxes if round has to be reset
           

            for (int i = 0; i < mLevel2Rows; i++)
            {
                for (int j = 0; j < mLevel2Columns; j++)
                {
                    if (mLevel2LongPaddle[i, j] != null)
                        mBrickBreakerForm.Controls.Remove(mLevel2LongPaddle[i, j]);

                    if (mLevel2PowerLives[i, j] != null)
                        mBrickBreakerForm.Controls.Remove(mLevel2PowerLives[i, j]);

                    if (mLevel2PowerBullets[i, j] != null)
                        mBrickBreakerForm.Controls.Remove(mLevel2PowerBullets[i, j]);

                  
                    if (mLevel2ShortPaddle[i, j] != null)
                        mBrickBreakerForm.Controls.Remove(mLevel2ShortPaddle[i, j]);

                    if (mLevel2Reverse[i, j] != null)
                        mBrickBreakerForm.Controls.Remove(mLevel2Reverse[i, j]);



                }
            }


            for (int j = 0; j < mBullet.GetLength(0); j++)
            {
                if (mBullet[j] != null)
                {
                    mBrickBreakerForm.Controls.Remove(mBullet[j]);
                }
            }


            mReverseOn = false;
            mReverseCounter = 0;

            
        }
        public void ResetLvl2()
        {
            //Reseting the variables
            mLevel2Start = false;

            mScoreLabel = null;
            mScore = 0;
            mStoneCounter = 0;
        
            mGameOverWin = false;

            mLifeUp = false;

       
            mBulletActivate = false;
            mBulletYP1 = 1.01;
            mBulletYP2 = 1.01;
            mBulletYP3 = 1.01;

            mBullet2Counter = 0;
            mBullet3Counter = 0;

        
            mReverseOn = false;
               mReverseCounter = 0;
        }
    



    }
}
