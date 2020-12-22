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
    class StrtScreen
    {

        //Private Members
        private PictureBox[,] mStartScreenPicArray;
        private ImageList mBrickImageList;
        private Form mBrickBreakerForm;

        private int mStartScreenRows;
        private int mStartScreenColumns;

        private int mBrickWidth;
        private int mBrickHeight;

        //Properties

        public PictureBox[,] StartScreenPicArray
        {
            get { return mStartScreenPicArray; }
            set { mStartScreenPicArray = value; }
        }
        public ImageList BrickImageList
        {
            get { return mBrickImageList; }
            set { mBrickImageList = value; }
        }
        public Form BrickBreakerForm
        {
            get { return mBrickBreakerForm; }
            set { mBrickBreakerForm = value; }
        }
        public int StartScreenRows
        {
            get { return mStartScreenRows; }
            set { mStartScreenRows = value; }
        }

        public int StartScreenColumns
        {
            get { return mStartScreenColumns; }
            set { mStartScreenColumns = value; }
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

        //Constructor
        public StrtScreen(Form BrickBreakerForm, ImageList BrickImageList, int StartScreenRows, int StartScreenColumns, int BrickWidth, int BrickHeight)
        {
            mBrickBreakerForm = BrickBreakerForm;
            mBrickImageList = BrickImageList;

            mStartScreenRows = StartScreenRows;
            mStartScreenColumns = StartScreenColumns;

            mBrickWidth = BrickWidth;
            mBrickHeight = BrickHeight;

            mStartScreenPicArray = new PictureBox[mStartScreenRows, mStartScreenColumns];

            Random rnd = new Random();

          
            for (int i = 0; i < mStartScreenRows; ++i)
            {
                
                for (int j = 0; j < mStartScreenColumns; ++j)
                {
                    mStartScreenPicArray[i, j] = new PictureBox();

                    mStartScreenPicArray[i, j].Visible = true;
                    mStartScreenPicArray[i, j].Height = mBrickHeight;
                    mStartScreenPicArray[i, j].Width = mBrickWidth;

                  

                    int index = rnd.Next(0, mBrickImageList.Images.Count);
                    mStartScreenPicArray[i, j].Image = mBrickImageList.Images[index];
                    mStartScreenPicArray[i, j].Tag = index;

                    
                }
                
            }

            


        }

        //Methods
        public void AddBricks()
        {
            Random rand = new Random();
            int pX = 0;
            int pY = 0;

            for (int i = 0; i < mStartScreenRows; i++)
            {
                pX = 0;
                for (int j = 0; j < mStartScreenColumns; j++)
                {
                    mStartScreenPicArray[i, j].Left = pX;
                    mStartScreenPicArray[i, j].Top = pY;
                    pX += mBrickWidth;

                    mBrickBreakerForm.Controls.Add(mStartScreenPicArray[i, j]);//To add the Picture Box to form.
                }
                pY += mBrickHeight;
            }

            for (int i = 2; i < mStartScreenRows - 1; ++i)
            {
                for (int j = 2; j < mStartScreenColumns - 2; ++j)
                {
                    mBrickBreakerForm.Controls.Remove(mStartScreenPicArray[i, j]);
                   
                }
            }
            mBrickBreakerForm.Controls.Remove(mStartScreenPicArray[24, 3]);
            mBrickBreakerForm.Controls.Remove(mStartScreenPicArray[24, 11]);
            mBrickBreakerForm.Controls.Remove(mStartScreenPicArray[24, 4]);
            mBrickBreakerForm.Controls.Remove(mStartScreenPicArray[24, 5]);
            mBrickBreakerForm.Controls.Remove(mStartScreenPicArray[24, 6]);
            mBrickBreakerForm.Controls.Remove(mStartScreenPicArray[24, 7]);
            mBrickBreakerForm.Controls.Remove(mStartScreenPicArray[24, 8]);
            mBrickBreakerForm.Controls.Remove(mStartScreenPicArray[24, 9]);
            mBrickBreakerForm.Controls.Remove(mStartScreenPicArray[24, 10]);
        
        }

        public void RemoveBricks()
        {
            for (int i = 0; i < mStartScreenRows; ++i)
            {
                for (int j = 0; j < mStartScreenColumns; ++j)
                {
                    mBrickBreakerForm.Controls.Remove(mStartScreenPicArray[i, j]);
                }
            }
        }












    }
}
