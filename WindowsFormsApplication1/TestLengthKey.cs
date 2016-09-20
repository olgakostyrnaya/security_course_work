using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class TestLengthKey : Test
    {

        private float averageOwner;
        private float averageHacker;
        private float[] difArray;
        private int lenDifArray; 

        public TestLengthKey(Graphics Gr)
        {
            this.myStatGraph = Gr;
            this.currentHackerTryNumber = 0;
            this.currentOwnerTryNumber = 0;
            difArray = new float[100];
            lenDifArray = 0;
        }

        public void writeOwnerTime(int currentTime)
        {

            ownerTime[this.currentOwnerTryNumber] = currentTime;
            this.currentOwnerTryNumber = this.currentOwnerTryNumber + 1;



        }
        public void writeHackerTime(int currentTime)
        {
            hackerTime[this.currentHackerTryNumber] = currentTime;
            this.currentHackerTryNumber = this.currentHackerTryNumber + 1;
        }

        public void averageTime()
        {
            int sumOwner = 0;
            int sumHacker = 0;
            for (int i = 0; i < currentOwnerTryNumber; i++)
            {
                sumOwner = sumOwner + ownerTime[i];
            }
            for (int j = 0; j < currentOwnerTryNumber; j++)
            {
                sumHacker = sumHacker + hackerTime[j];
            }
            averageOwner = sumOwner / currentOwnerTryNumber;
            averageHacker = sumHacker / currentHackerTryNumber;
            difArray[lenDifArray] = (averageOwner) - (averageHacker);
            lenDifArray = lenDifArray + 1;
        }

        public void clearBefore()
        {
            currentOwnerTryNumber = 0;
            currentHackerTryNumber = 0;
            ownerTime = null;
            hackerTime = null;
        }

        public void PaintGraph()
        {
            //GrTest.TranslateTransform(0, 249);
            //Pen myPen;
            //Pen myPen2;
            //myPen = new Pen(Color.Red);
            //myPen2 = new Pen(Color.Aqua);

            //Point[] apt = new Point[currentOwnerTryNumber];

            //for (int i = 0; i < currentOwnerTryNumber; i++)
            //{
            //    apt[i] = new Point(i * 30, -(this.ownerTime[i]) / 5);

            //}

            //GrTest.DrawLines(myPen, apt);

            //Point[] apt1 = new Point[currentHackerTryNumber];

            //for (int j = 0; j < currentHackerTryNumber; j++)
            //{
            //    apt1[j] = new Point(j * 30, -(this.hackerTime[j]) / 5);
            //}


            //GrTest.DrawLines(myPen2, apt1);


            /////

            myStatGraph.TranslateTransform(0, 249);
            Pen myPen1 = new Pen(Color.BlueViolet);
            int width = 50;
            int xForRect = 10;
            int margin = 20;
            
            for (int i = 0; i < lenDifArray; i++)
            {
                myStatGraph.DrawRectangle(myPen1, xForRect, -(difArray[i]), width, (difArray[i]));
                xForRect = xForRect + width + margin;
            }
            
        }
    }
}
