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
    class Lvl1
    {
        
        //Private Members
        private PictureBox[,] mLevel1;
        private ImageList mBrickImageList;
        private Form mBrickBreakerForm;
        private Vector mBallVelocity;
 

        private int mLevel1Rows;
        private int mLevel1Columns;

        private int mLevel1PositionX;
        private int mLevel1PositionY;
        
        private int mBrickWidth;
        private int mBrickHeight;

        private bool mLevel1Start = false;
        private int mLevel1BlockCount;

        private string mScoreLabel;
        private int mScore;

        //Lives
        private PictureBox[,] mLives;
        private int mNumLives;


        //Properties
        public Form BrickBreakerForm
        {
            get { return mBrickBreakerForm; }
            set { mBrickBreakerForm = value; }
        }

        public PictureBox[,] Level1
        {
            get { return mLevel1; }
            set { mLevel1 = value; }
        }
        public ImageList BrickImageList
        {
            get { return mBrickImageList; }
            set { mBrickImageList = value; }
        }
        public int Level1Rows
        {
            get { return mLevel1Rows; }
            set { mLevel1Rows = value; }
        }

        public int Level1Columns
        {
            get { return mLevel1Columns; }
            set { mLevel1Columns = value; }
        }

        public int Level1PositionX
        {
            get { return mLevel1PositionX; }
            set { mLevel1PositionX = value; }
        }

        public int Level1PositionY
        {
            get { return mLevel1PositionY; }
            set { mLevel1PositionY = value; }
        }

        public int Level1BlockCount
        {
            get { return mLevel1BlockCount; }
            set { mLevel1BlockCount = value; }
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
        public int NumLives
        {
            get { return mNumLives; }
            set { mNumLives = value; }
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

        public bool Level1Start
        {
            get { return mLevel1Start; }
            set { mLevel1Start = value; }
        }

        

        //Constructor
        public Lvl1(Form BrickBreakerForm, ImageList BrickImageList, int Level1Rows, int Level1Columns, int Level1PositionX, int Level1PositionY, bool Level1Start, int BrickWidth, int BrickHeight)
        {

            


            mBrickBreakerForm = BrickBreakerForm;
            mBrickImageList = BrickImageList;

            mLevel1Rows = Level1Rows;
            mLevel1Columns = Level1Columns;

            mLevel1PositionX = Level1PositionX;
            mLevel1PositionY = Level1PositionY;

            mLevel1Start = Level1Start;

            mBrickWidth = BrickWidth;
            mBrickHeight = BrickHeight;

            mLevel1 = new PictureBox[mLevel1Rows, mLevel1Columns];

            

            Random rand = new Random();


            for (int i = 0; i < mLevel1Rows; i++)
            {

                for (int j = 0; j < mLevel1Columns; j++)
                {
                    mLevel1[i, j] = new PictureBox();

                    mLevel1[i, j].Visible = true;
                    mLevel1[i, j].Height = BrickHeight;
                    mLevel1[i, j].Width = BrickWidth;


                    int index = rand.Next(0, mBrickImageList.Images.Count-1);
                    mLevel1[i, j].Image = mBrickImageList.Images[index];
                    mLevel1[i, j].Tag = index;


                }

            }

            BlockCount();



            mLives = new PictureBox[1, 2];
            int pX = 22;
            int pY = 450;
            for (int j = 0; j < 2; j++)
            {
                mLives[0, j] = new PictureBox();

                mLives[0, j].Visible = true;
                mLives[0, j].Height = 25;
                mLives[0, j].Width = 27;
                mLives[0, j].Left = pX;
                mLives[0, j].Top = pY;


                mLives[0, j].Image = PowerImages.LifePixel;
                mLives[0, j].BackColor = Color.Transparent;

                pX += 30;


            }


        }
    


        //Methods
        public void AddBricks()
        {
            Random rand = new Random();
            int pX = mLevel1PositionX;
            int pY = mLevel1PositionY;

            for (int i = 0; i < mLevel1Rows; i++)
            {
                pX = mLevel1PositionX;
                for (int j = 0; j < mLevel1Columns; j++)
                {
                    mLevel1[i, j].Left = pX;
                    mLevel1[i, j].Top = pY;
                    pX += mBrickWidth;

                    mBrickBreakerForm.Controls.Add(mLevel1[i, j]);//To add the Picture Box to form.
                }
                pY += mBrickHeight;
            }

            mBrickBreakerForm.Controls.Add(mLives[0, 0]);
            mBrickBreakerForm.Controls.Add(mLives[0, 1]);
           
        }
        public void RemoveBricks()
        {
            for (int i = 0; i < mLevel1Rows; i++)
            {
                for (int j = 0; j < mLevel1Columns; j++)
                {
                    mBrickBreakerForm.Controls.Remove(mLevel1[i, j]);//To remove the Picture Box to form.
                }

            }
            mBrickBreakerForm.Controls.Remove(mLives[0, 0]);
            mBrickBreakerForm.Controls.Remove(mLives[0, 1]);
        }

        public int BlockCount()
        {
            mLevel1BlockCount = mLevel1Rows * mLevel1Columns;
            return mLevel1BlockCount;
        }

        public bool GamePlay(PictureBox picBall, Vector BallVelocity, SoundPlayer blockHitSound, int Score, int NumLives)
        {
            
            mBallVelocity.X = BallVelocity.X;
            mBallVelocity.Y = BallVelocity.Y;
            mScore = Score;
            mNumLives = NumLives;
            bool GameOvertrue;

            if(mNumLives == 1)
            {
                mBrickBreakerForm.Controls.Remove(mLives[0, 1]);
            }
            if(mNumLives == 0)
            {
                mBrickBreakerForm.Controls.Remove(mLives[0, 0]);
            }

            for (int i = 0; i < mLevel1Rows; i++)
            {
                for (int j = 0; j < mLevel1Columns; j++)
                {
                    if (mLevel1[i, j] != null)
                    {

                        if (picBall.Bounds.IntersectsWith(mLevel1[i, j].Bounds))
                        {
                            mLevel1BlockCount -= 1;
                            if (mLevel1BlockCount == 0)
                            {
                                mBrickBreakerForm.Controls.Remove(Level1[i, j]);
                                mLevel1[i, j] = null;

                                mScore += 1;
                                mScoreLabel = mScore.ToString();

                                GameOvertrue = true;
                                return GameOvertrue;


                            }
                            if (mLevel1BlockCount >= 1)
                            {


                                mBallVelocity.Y = -BallVelocity.Y;
                                blockHitSound.Play();
                                mScore += 1;
                                mScoreLabel = mScore.ToString();
                              
                                

                                mBrickBreakerForm.Controls.Remove(Level1[i, j]);
                                mLevel1[i, j] = null;
                                
                            }

                        }
                    }
                }
            }
            GameOvertrue = false;
            return GameOvertrue;
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

        public void ResetLvl1()
        {
            mScore = 0;
            mScoreLabel = null;
        }

        
    }
}
