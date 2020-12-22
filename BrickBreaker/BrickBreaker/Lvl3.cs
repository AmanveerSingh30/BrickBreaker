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

namespace BrickBreaker
{
    class Lvl3
    {

        //Private Members
        private PictureBox[,] mLevel3;
        private ImageList mBrickImageList;
        private Form mBrickBreakerForm;
        private Vector mBallVelocity;


        private int mLevel3Rows;
        private int mLevel3Columns;

        private int mLevel3PositionX;
        private int mLevel3PositionY;

        private int mBrickWidth;
        private int mBrickHeight;

        private bool mLevel3Start = false;
        private int mLevel3BlockCount;

        private string mScoreLabel;
        private int mScore;
        private int mStoneCounter;
        private int mLevel3Stones;
        private int mLevel3SpeedUp;

        private bool mGameOverWin;

        //////////////////////////////////powerups
        private PictureBox mpicPaddle;

        //LongPaddle
        private PictureBox[,] mLevel3LongPaddle;

        //Lives
        private PictureBox[,] mLevel3Lives;
        private PictureBox[,] mLevel3PowerLives;
        private int mLevel3NumLives;
        private bool mLifeUp;

        //Bullet
        private PictureBox[,] mLevel3PowerBullets;
        private PictureBox[] mBullet;
        private bool mBulletActivate = false;
        private double mBulletYP1 = 1.01;
        private double mBulletYP2 = 1.01;
        private double mBulletYP3 = 1.01;

        private int mBullet2Counter = 0;
        private int mBullet3Counter = 0;

        //Bomb
        private int[,] mLevel3PowerBomb;
        private bool mBombActivate;

        /// /////////////////////////////powerdowns
        //ShortPaddle
        private PictureBox[,] mLevel3ShortPaddle;

        //Reverse
        private PictureBox[,] mLevel3Reverse;
        private bool mReverseOn = false;
        private double mReverseCounter = 0;


        //Properties
        public Form BrickBreakerForm
        {
            get { return mBrickBreakerForm; }
            set { mBrickBreakerForm = value; }
        }

        public PictureBox[,] Level3
        {
            get { return mLevel3; }
            set { mLevel3 = value; }
        }
        public ImageList BrickImageList
        {
            get { return mBrickImageList; }
            set { mBrickImageList = value; }
        }
        public PictureBox picPaddle
        {
            get { return mpicPaddle; }
            set { mpicPaddle = value; }
        }
        public int Level3Rows
        {
            get { return mLevel3Rows; }
            set { mLevel3Rows = value; }
        }

        public int Level3Columns
        {
            get { return mLevel3Columns; }
            set { mLevel3Columns = value; }
        }

        public int Level3PositionX
        {
            get { return mLevel3PositionX; }
            set { mLevel3PositionX = value; }
        }

        public int Level3PositionY
        {
            get { return mLevel3PositionY; }
            set { mLevel3PositionY = value; }
        }

        public int Level3BlockCount
        {
            get { return mLevel3BlockCount; }
            set { mLevel3BlockCount = value; }
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
        public int Level3Stones
        {
            get { return mLevel3Stones; }
            set { mLevel3Stones = value; }
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

        public bool Level3Start
        {
            get { return mLevel3Start; }
            set { mLevel3Start = value; }
        }
        public int Level3NumLives
        {
            get { return mLevel3NumLives; }
            set { mLevel3NumLives = value; }
        }



        //Constructor
        public Lvl3(Form BrickBreakerForm, ImageList BrickImageList, int Level3Rows, int Level3Columns, int Level3PositionX, int Level3PositionY, bool Level3Start, int Level3Stones, int BrickWidth, int BrickHeight)
        {

            mBrickBreakerForm = BrickBreakerForm;
            mBrickImageList = BrickImageList;

            mLevel3Rows = Level3Rows;
            mLevel3Columns = Level3Columns;

            mLevel3PositionX = Level3PositionX;
            mLevel3PositionY = Level3PositionY;

            mLevel3Start = Level3Start;

            mBrickWidth = BrickWidth;
            mBrickHeight = BrickHeight;

            mLevel3Stones = Level3Stones;

            mLevel3 = new PictureBox[mLevel3Rows, mLevel3Columns];



            Random rand = new Random();

            mStoneCounter = 10;
            


            for (int i = 0; i < mLevel3Rows; i++)
            {

                for (int j = 0; j < mLevel3Columns; j++)
                {
                    mLevel3[i, j] = new PictureBox();
                    mLevel3[i, j].Visible = true;
                    mLevel3[i, j].Height = mBrickHeight;
                    mLevel3[i, j].Width = mBrickWidth;

                   

                    int Index = rand.Next(0, mBrickImageList.Images.Count-1);
                    mLevel3[i, j].Image = mBrickImageList.Images[Index];
                    mLevel3[i, j].Tag = Index;


                }

            }
           

            mLevel3[4, 4].Image = mBrickImageList.Images[8];
            mLevel3[4, 4].Tag = 8;

            mLevel3[4, 5].Image = mBrickImageList.Images[8];
            mLevel3[4, 5].Tag = 8;


            mLevel3[2, 2].Image = mBrickImageList.Images[8];
            mLevel3[2, 2].Tag = 8;            

            mLevel3[7, 7].Image = mBrickImageList.Images[8];
            mLevel3[7, 7].Tag = 8;

            mLevel3[7, 2].Image = mBrickImageList.Images[8];
            mLevel3[7, 2].Tag = 8;

            mLevel3[2, 7].Image = mBrickImageList.Images[8];
            mLevel3[2, 7].Tag = 8;


            mLevel3[9, 9].Image = mBrickImageList.Images[8];
            mLevel3[9, 9].Tag = 8;

            mLevel3[0, 0].Image = mBrickImageList.Images[8];
            mLevel3[0, 0].Tag = 8;

            mLevel3[0, 9].Image = mBrickImageList.Images[8];
            mLevel3[0, 9].Tag = 8;

            mLevel3[9, 0].Image = mBrickImageList.Images[8];
            mLevel3[9, 0].Tag = 8;

            
            BlockCount();












            //////Long Paddle
            mLevel3LongPaddle = new PictureBox[mLevel3Rows, mLevel3Columns];

            //2 of these powerups
            int Row = rand.Next(0, mLevel3Rows);
            int Col = rand.Next(0, mLevel3Columns);

            mLevel3LongPaddle[Row, Col] = new PictureBox();
            mLevel3LongPaddle[Row, Col].Visible = false;
            mLevel3LongPaddle[Row, Col].Height = mBrickHeight;
            mLevel3LongPaddle[Row, Col].Width = mBrickWidth;
            mLevel3LongPaddle[Row, Col].Image = PowerImages.PaddleLong;



            Row = rand.Next(0, mLevel3Rows);
            Col = rand.Next(0, mLevel3Columns);

            mLevel3LongPaddle[Row, Col] = new PictureBox();
            mLevel3LongPaddle[Row, Col].Visible = false;
            mLevel3LongPaddle[Row, Col].Height = mBrickHeight;
            mLevel3LongPaddle[Row, Col].Width = mBrickWidth;
            mLevel3LongPaddle[Row, Col].Image = PowerImages.PaddleLong;



            ////////////////Lives
            ///Picture boxes at  the bottom
            ///no lives to begin with
            mLevel3Lives = new PictureBox[1, 10];


            //Lives power falling downnn
            mLevel3PowerLives = new PictureBox[mLevel3Rows, mLevel3Columns];

            //1 of this power up
            Row = rand.Next(0, mLevel3Rows);
            Col = rand.Next(0, mLevel3Columns);

            mLevel3PowerLives[Row, Col] = new PictureBox();
            mLevel3PowerLives[Row, Col].Visible = false;
            mLevel3PowerLives[Row, Col].Height = mBrickHeight;
            mLevel3PowerLives[Row, Col].Width = mBrickWidth;
            mLevel3PowerLives[Row, Col].Image = PowerImages.Life;
            mLevel3PowerLives[Row, Col].BackColor = Color.Transparent;


            /////////Bullets
            ///
            mBullet = new PictureBox[3];
            ///
            mLevel3PowerBullets = new PictureBox[mLevel3Rows, Level3Columns];

            //1 of this power up
            Row = rand.Next(0, mLevel3Rows);
            Col = rand.Next(0, mLevel3Columns);

            mLevel3PowerBullets[Row, Col] = new PictureBox();
            mLevel3PowerBullets[Row, Col].Visible = false;
            mLevel3PowerBullets[Row, Col].Height = 12;
            mLevel3PowerBullets[Row, Col].Width = 8;
            mLevel3PowerBullets[Row, Col].Image = PowerImages.Bulletnormal;
            mLevel3PowerBullets[Row, Col].BackColor = Color.Transparent;


            ////////////Bomb
            mLevel3PowerBomb = new int[mLevel3Rows, mLevel3Columns];

            //1 of this power up
            Row = rand.Next(0, mLevel3Rows);
            Col = rand.Next(0, mLevel3Columns);

            mLevel3PowerBomb[Row, Col] = new int();
            mLevel3PowerBomb[Row, Col] = 1;


            //////Short Paddle
            mLevel3ShortPaddle = new PictureBox[mLevel3Rows, mLevel3Columns];

            //4 of these powerdowns
            Row = rand.Next(0, mLevel3Rows);
            Col = rand.Next(0, mLevel3Columns);

            mLevel3ShortPaddle[Row, Col] = new PictureBox();
            mLevel3ShortPaddle[Row, Col].Visible = false;
            mLevel3ShortPaddle[Row, Col].Height = mBrickHeight;
            mLevel3ShortPaddle[Row, Col].Width = mBrickWidth;
            mLevel3ShortPaddle[Row, Col].Image = PowerImages.PaddleShort;



            Row = rand.Next(0, mLevel3Rows);
            Col = rand.Next(0, mLevel3Columns);

            mLevel3ShortPaddle[Row, Col] = new PictureBox();
            mLevel3ShortPaddle[Row, Col].Visible = false;
            mLevel3ShortPaddle[Row, Col].Height = mBrickHeight;
            mLevel3ShortPaddle[Row, Col].Width = mBrickWidth;
            mLevel3ShortPaddle[Row, Col].Image = PowerImages.PaddleShort;


            //////Reverse
            mLevel3Reverse = new PictureBox[mLevel3Rows, mLevel3Columns];

            //2 of these powerdowns
            for (int i = 0; i < 3; i++)
            {
                Row = rand.Next(0, mLevel3Rows);
                Col = rand.Next(0, mLevel3Columns);

                mLevel3Reverse[Row, Col] = new PictureBox();
                mLevel3Reverse[Row, Col].Visible = false;
                mLevel3Reverse[Row, Col].Height = 20;
                mLevel3Reverse[Row, Col].Width = 20;
                mLevel3Reverse[Row, Col].Image = PowerImages.Reverse; 
            }


        }

        //Methods
        public void AddBricks()
        {
            Random rand = new Random();
            int pX = mLevel3PositionX;
            int pY = mLevel3PositionY;

            for (int i = 0; i < mLevel3Rows; i++)
            {
                pX = mLevel3PositionX + mBrickWidth;
                for (int j = 0; j < mLevel3Columns; j++)
                {
                    mLevel3[i, j].Left = pX;
                    mLevel3[i, j].Top = pY;
                    pX += mBrickWidth;

                    mBrickBreakerForm.Controls.Add(mLevel3[i, j]);//To add the Picture Box to form.
                }
                pY += mBrickHeight;
            }
            //Lives at bottom
            mBrickBreakerForm.Controls.Add(mLevel3Lives[0, 0]);
            mBrickBreakerForm.Controls.Add(mLevel3Lives[0, 1]);
        }

        public void RemoveBricks()
        {
            for (int i = 0; i < mLevel3Rows; i++)
            {
                for (int j = 0; j < mLevel3Columns; j++)
                {
                    mBrickBreakerForm.Controls.Remove(mLevel3[i, j]);//To remove the Picture Box to form.
                    mLevel3[i, j] = null;
                }

            }
            //Lives at bottom
            mBrickBreakerForm.Controls.Remove(mLevel3Lives[0, 0]);
            mBrickBreakerForm.Controls.Remove(mLevel3Lives[0, 1]);
        }

        public int BlockCount()
        {
            mLevel3BlockCount = (mLevel3Rows * mLevel3Columns) - mLevel3Stones;
            return mLevel3BlockCount;
        }

        public bool GamePlay(PictureBox picBall, PictureBox picPaddle,Vector BallVelocity, SoundPlayer blockHitSound, SoundPlayer blockSpeedSound, int Score, int NumLives)
        {
            mpicPaddle = picPaddle;
            mBallVelocity.X = BallVelocity.X;
            mBallVelocity.Y = BallVelocity.Y;
            mScore = Score;
           
            mLevel3NumLives = NumLives;

            if (mLevel3NumLives == 1)
            {
                mBrickBreakerForm.Controls.Remove(mLevel3Lives[0, 1]);
            }
            if (mLevel3NumLives == 0)
            {
                mBrickBreakerForm.Controls.Remove(mLevel3Lives[0, 0]);
            }

            if (mReverseOn == true)
            {
                Reverse();
            }

            for (int i = 0; i < mLevel3Rows; i++)
            {
                for (int j = 0; j < mLevel3Columns; j++)
                {

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


                    if (mLevel3[i, j] != null)
                    {
    
                        if (picBall.Bounds.IntersectsWith(mLevel3[i, j].Bounds))
                        {
                            mLevel3BlockCount -= 1;


                            CheckLongPowerHit(i, j);

                            CheckLivesHit(i, j);

                            CheckBulletPowerHit(i, j);

                            CheckBombPowerHit(i, j);

                            CheckShortPowerHit(i, j);

                            CheckReversePowerHit(i, j);



                            if (mLevel3[i, j] != null)
                            {
                                if ((int)mLevel3[i, j].Tag == 8)
                                {
                                    mLevel3BlockCount += 1;

                                    mBallVelocity.X = 1.005 * mBallVelocity.X;
                                    mBallVelocity.Y = 1.005 * -mBallVelocity.Y;

                                    //BallVelocity.X = -BallVelocity.X;

                                    blockSpeedSound.Play();
                                }
                                else if (mLevel3BlockCount == 0)
                                {
                                    mBrickBreakerForm.Controls.Remove(mLevel3[i, j]);
                                    mLevel3[i, j] = null;

                                    mGameOverWin = true;
                                    return mGameOverWin;
                                }
                                else if (mLevel3BlockCount >= 1)
                                {
                                    mBallVelocity.Y = -BallVelocity.Y;
                                    blockHitSound.Play();
                                    mScore += 1;
                                    mScoreLabel = mScore.ToString();


                                    mBrickBreakerForm.Controls.Remove(Level3[i, j]);
                                    mLevel3[i, j] = null;
                                    mGameOverWin = false;
                                    return mGameOverWin;
                                }
                               
                            }
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
            if (mLevel3LongPaddle[i, j] != null)
            {
                mLevel3LongPaddle[i, j].Left = mLevel3[i, j].Left;
                mLevel3LongPaddle[i, j].Top = mLevel3[i, j].Top;
                mLevel3LongPaddle[i, j].Visible = true; ;
                mBrickBreakerForm.Controls.Add(mLevel3LongPaddle[i, j]);
            }
        }

        public void CheckLongPowerCollect(int i, int j)
        {
            if (mLevel3LongPaddle[i, j] != null)
            {
                if (mLevel3LongPaddle[i, j].Visible == true)
                {
                    mLevel3LongPaddle[i, j].Top += 8;

                    if (mLevel3LongPaddle[i, j].Bounds.IntersectsWith(mpicPaddle.Bounds))
                    {
                        PaddleLong();
                        mBrickBreakerForm.Controls.Remove(mLevel3LongPaddle[i, j]);
                        mLevel3LongPaddle[i, j] = null;
                    }
                }

            }
        }

        public void PaddleLong()
        {
            mpicPaddle.Image = null;
            System.Drawing.Size picPaddleLongSize = new System.Drawing.Size(mpicPaddle.Width + 10, mpicPaddle.Height);

            mpicPaddle.Size = picPaddleLongSize;
        }

        //Lives
        public void CheckLivesHit(int i, int j)
        {
            if (mLevel3PowerLives[i, j] != null)
            {
                if (mLevel3PowerLives[i, j].Visible == false)
                {

                    mLevel3PowerLives[i, j].Left = mLevel3[i, j].Left;
                    mLevel3PowerLives[i, j].Top = mLevel3[i, j].Top;
                    mLevel3PowerLives[i, j].Visible = true; ;

                    mBrickBreakerForm.Controls.Add(mLevel3PowerLives[i, j]);
                }


            }
        }

        public void CheckLivesCollect(int i, int j)
        {
            if (mLevel3PowerLives[i, j] != null)
            {
                if (mLevel3PowerLives[i, j].Visible == true)
                {
                    mLevel3PowerLives[i, j].Top += 3;

                    if (mLevel3PowerLives[i, j].Bounds.IntersectsWith(mpicPaddle.Bounds))
                    {
                        Lives();
                        mBrickBreakerForm.Controls.Remove(mLevel3PowerLives[i, j]);
                        mLevel3PowerLives[i, j] = null;
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
                if (mLevel3NumLives == j)
                {

                    mLevel3Lives[0, j] = new PictureBox();
                    mLevel3Lives[0, j].Height = 25;
                    mLevel3Lives[0, j].Width = 27;
                    mLevel3Lives[0, j].Left = pX;
                    mLevel3Lives[0, j].Top = pY;
                    mLevel3Lives[0, j].Image = PowerImages.Life;
                    mBrickBreakerForm.Controls.Add(mLevel3Lives[0, j]);
                    mLifeUp = true;

                }
                pX += 30;
            }
        }

        public int LivesReturn()
        {
            if (mLifeUp == true)
            {
                mLevel3NumLives++;
                mLifeUp = false;
                return mLevel3NumLives;

            }
            return mLevel3NumLives;
        }






        //Bullets
        public void CheckBulletPowerHit(int i, int j)
        {
            if (mLevel3PowerBullets[i, j] != null)
            {
                if (mLevel3PowerBullets[i, j].Visible == false)
                {

                    mLevel3PowerBullets[i, j].Left = mLevel3[i, j].Left;
                    mLevel3PowerBullets[i, j].Top = mLevel3[i, j].Top;
                    mLevel3PowerBullets[i, j].Visible = true; ;

                    mBrickBreakerForm.Controls.Add(mLevel3PowerBullets[i, j]);
                }


            }
        }
        public void CheckBulletsCollect(int i, int j)
        {
            if (mLevel3PowerBullets[i, j] != null)
            {
                if (mLevel3PowerBullets[i, j].Visible == true)
                {
                    mLevel3PowerBullets[i, j].Top += 3;

                    if (mLevel3PowerBullets[i, j].Bounds.IntersectsWith(mpicPaddle.Bounds))
                    {
                        mBulletActivate = true;

                        for (int f = 0; f < mBullet.GetLength(0); f++)
                        {
                            mBullet[f] = new PictureBox();
                            mBullet[f].Visible = true;
                            mBullet[f].Height = 20;
                            mBullet[f].Width = 10;
                            mBullet[f].Left = mpicPaddle.Left;//mpicPaddle.Left;
                            mBullet[f].Top = mpicPaddle.Top;// mpicPaddle.Top;
                            mBullet[f].Image = PowerImages.Bulletnormal;

                        }
                        mBrickBreakerForm.Controls.Add(mBullet[0]);


                        mBrickBreakerForm.Controls.Remove(mLevel3PowerBullets[i, j]);
                        mLevel3PowerBullets[i, j] = null;
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
                if (mLevel3[i, j] != null)
                {
                    for (int f = 0; f < mBullet.GetLength(0); f++)
                    {
                        if (mBullet[f] != null)
                        {
                            if (mLevel3[i, j] != null && mBullet[f].Bounds.IntersectsWith(mLevel3[i, j].Bounds))
                            {
                                mLevel3BlockCount -= 1;


                                CheckLongPowerHit(i, j);

                                CheckLivesHit(i, j);

                                CheckBulletPowerHit(i, j);

                                CheckBombPowerHit(i, j);

                                CheckShortPowerHit(i, j);








                                if ((int)mLevel3[i, j].Tag == 8)
                                {
                                    //to figure if its a stone
                                    mLevel3BlockCount += 1;
                                    mBrickBreakerForm.Controls.Remove(mBullet[f]);
                                    mBullet[f] = null;

                                }
                                else if (mLevel3BlockCount == 0)
                                {
                                    mBrickBreakerForm.Controls.Remove(mLevel3[i, j]);
                                    mBrickBreakerForm.Controls.Remove(mBullet[f]);
                                    mLevel3[i, j] = null;
                                    mBullet[f] = null;

                                    mGameOverWin = true;

                                }
                                else if (mLevel3BlockCount >= 1)
                                {

                                    mScore += 1;
                                    mScoreLabel = mScore.ToString();

                                    mBrickBreakerForm.Controls.Remove(mBullet[f]);
                                    mBullet[f] = null;
                                    mBrickBreakerForm.Controls.Remove(Level3[i, j]);
                                    mLevel3[i, j] = null;
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
            if (mLevel3PowerBomb[i, j] == 1)
            {

                Bomb(0, 0, j, i);
                Shake();
                Opacity();
                mBombActivate = false;
                mLevel3PowerBomb[i, j] = 0;

            }
        }

        public void Bomb(int r, int c, int j, int i)
        {
            //record the current value in array

            //Path += "M[" + r + ", " + c + "]  ";

            //check to move right
            if (c < mLevel3Columns - 1)
                Bomb(r, c + 1, j, i);
            //check to move down
            if (r < mLevel3Rows - 1)
                Bomb(r + 1, c, j, i);


            //check if at the end position

            //bottom right
            if (i == mLevel3Rows - 1 && j == mLevel3Columns - 1)
            {
                if (mLevel3[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i - 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i, j - 1] != null)
                {
                    if (c == j - 1 && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i - 1, j] != null)
                {
                    if (c == j && r == i - 1)
                        GamePlayBomb(r, c);
                }
            }

            //bottom left
            else if (i == mLevel3Rows - 1 && j == 0)
            {
                if (mLevel3[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i - 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i - 1, j] != null)
                {
                    if (c == j && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i, j + 1] != null)
                {
                    if (c == j + 1 && r == i)
                        GamePlayBomb(r, c);
                }
            }

            //top right
            else if (i == 0 && j == mLevel3Columns - 1)
            {
                if (mLevel3[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i, j - 1] != null)
                {
                    if (c == j - 1 && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i + 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i + 1, j] != null)
                {
                    if (c == j && r == i + 1)
                        GamePlayBomb(r, c);
                }
            }

            //top left
            else if (i == 0 && j == 0)
            {
                if (mLevel3[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i + 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i, j + 1] != null)
                {
                    if (c == j + 1 && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i + 1, j] != null)
                {
                    if (c == j && r == i + 1)
                        GamePlayBomb(r, c);
                }
            }

            //top row
            else if (i == 0)
            {
                if (mLevel3[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i + 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i + 1, j] != null)
                {
                    if (c == j && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i + 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
            }

            //bottom row
            else if (i == mLevel3Rows - 1)
            {
                if (mLevel3[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i - 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i - 1, j] != null)
                {
                    if (c == j && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i - 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
            }

            //left first column
            else if (j == 0)
            {
                if (mLevel3[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i - 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i + 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i, j + 1] != null)
                {
                    if (c == j + 1 && r == i)
                        GamePlayBomb(r, c);
                }
            }

            //right last column
            else if (j == mLevel3Columns - 1)
            {
                if (mLevel3[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i - 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i, j - 1] != null)
                {
                    if (c == j - 1 && r == i)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i + 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
            }

            //in middle
            else
            {
                if (mLevel3[i, j] != null)
                {
                    if (c == j && r == i)
                        GamePlayBomb(r, c);

                }
                if (mLevel3[i + 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i - 1, j + 1] != null)
                {
                    if (c == j + 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i + 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i + 1)
                        GamePlayBomb(r, c);
                }
                if (mLevel3[i - 1, j - 1] != null)
                {
                    if (c == j - 1 && r == i - 1)
                        GamePlayBomb(r, c);
                }
            }








        }

        public void GamePlayBomb(int r, int c)
        {
            mLevel3BlockCount -= 1;

            CheckLongPowerHit(r, c);

            CheckLivesHit(r, c);

            CheckBulletPowerHit(r, c);


            CheckShortPowerHit(r, c);


            if ((int)mLevel3[r, c].Tag == 8)
            {
                //to figure if its a stone
                mLevel3BlockCount += 1;

            }
            else if (mLevel3BlockCount == 0)
            {
                mBrickBreakerForm.Controls.Remove(mLevel3[r, c]);

                mLevel3[r, c] = null;


                mGameOverWin = true;

            }
            else if (mLevel3BlockCount >= 1)
            {

                mScore += 1;
                mScoreLabel = mScore.ToString();



                mBrickBreakerForm.Controls.Remove(Level3[r, c]);
                mLevel3[r, c] = null;
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
            if (mLevel3ShortPaddle[i, j] != null)
            {
                mLevel3ShortPaddle[i, j].Left = mLevel3[i, j].Left;
                mLevel3ShortPaddle[i, j].Top = mLevel3[i, j].Top;
                mLevel3ShortPaddle[i, j].Visible = true; ;
                mBrickBreakerForm.Controls.Add(mLevel3ShortPaddle[i, j]);
            }
        }

        public void CheckShortPowerCollect(int i, int j)
        {
            if (mLevel3ShortPaddle[i, j] != null)
            {
                if (mLevel3ShortPaddle[i, j].Visible == true)
                {
                    mLevel3ShortPaddle[i, j].Top += 3;

                    if (mLevel3ShortPaddle[i, j].Bounds.IntersectsWith(mpicPaddle.Bounds))
                    {
                        PaddleShort();
                        mBrickBreakerForm.Controls.Remove(mLevel3ShortPaddle[i, j]);
                        mLevel3ShortPaddle[i, j] = null;
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
            if (mLevel3Reverse[i, j] != null)
            {
                if (mLevel3Reverse[i, j].Visible == false)
                {
                    mLevel3Reverse[i, j].Left = mLevel3[i, j].Left;
                    mLevel3Reverse[i, j].Top = mLevel3[i, j].Top;
                    mLevel3Reverse[i, j].Visible = true;

                    mBrickBreakerForm.Controls.Add(mLevel3Reverse[i, j]);
                }
            }
        }

        public void CheckReverseCollect(int i, int j)
        {
            if (mLevel3Reverse[i, j] != null)
            {
                if (mLevel3Reverse[i, j].Visible == true)
                {
                    mLevel3Reverse[i, j].Top += 3;

                    if (mLevel3Reverse[i, j].Bounds.IntersectsWith(mpicPaddle.Bounds))
                    {
                        mReverseOn = true;
                        mBrickBreakerForm.Controls.Remove(mLevel3Reverse[i, j]);
                        mLevel3Reverse[i, j] = null;
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


        public void RemovePicBoxesLvl3()
        {


            for (int i = 0; i < mLevel3Rows; i++)
            {
                for (int j = 0; j < mLevel3Columns; j++)
                {
                    if (mLevel3LongPaddle[i, j] != null)
                        mBrickBreakerForm.Controls.Remove(mLevel3LongPaddle[i, j]);

                    if (mLevel3PowerLives[i, j] != null)
                        mBrickBreakerForm.Controls.Remove(mLevel3PowerLives[i, j]);

                    if (mLevel3PowerBullets[i, j] != null)
                        mBrickBreakerForm.Controls.Remove(mLevel3PowerBullets[i, j]);


                    if (mLevel3ShortPaddle[i, j] != null)
                        mBrickBreakerForm.Controls.Remove(mLevel3ShortPaddle[i, j]);

                    if (mLevel3Reverse[i, j] != null)
                        mBrickBreakerForm.Controls.Remove(mLevel3Reverse[i, j]);



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
        public void ResetLvl3()
        {
            mLevel3Start = false;

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
