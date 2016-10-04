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

        private float averageOwner = 0;
        private float averageHacker = 0;
      //  private float[] difArray;
        private int lenDifArray =0;
        private float[] columnOwnerArray;
        private float[] columnHackerArray;
        private int xForRect = 10;
        public string sumsum;
        public string sumsum1;

        public TestLengthKey(Graphics Gr)
        {
            this.myStatGraph = Gr;
            this.currentHackerTryNumber = 0;
            this.currentOwnerTryNumber = 0;
            //difArray = new float[100];
            this.columnOwnerArray = new float[100];
            this.columnHackerArray = new float[100];
            this.lenDifArray = 0;
            myStatGraph.TranslateTransform(0, 249);

        }

        public void writeOwnerTime(int currentTime)
        {
           
            ownerTime[this.currentOwnerTryNumber] = currentTime;
            this.currentOwnerTryNumber = this.currentOwnerTryNumber + 1;



        }
        public void writeHackerTime(int currentTime)
        {
            
            this.hackerTime[this.currentHackerTryNumber] = currentTime;
            this.currentHackerTryNumber = this.currentHackerTryNumber + 1;

        }

        public void averageTime()
        {
            int sumOwner = 0;
            int sumHacker = 0;
            for (int i = 0; i < this.currentOwnerTryNumber; i++)
            {
                sumOwner = sumOwner + this.ownerTime[i];
            }
            for (int j = 0; j < this.currentHackerTryNumber; j++)
            {
                sumHacker = sumHacker + this.hackerTime[j];
            }
            averageOwner = sumOwner / (this.currentOwnerTryNumber);
            averageHacker = sumHacker / (this.currentHackerTryNumber);
            //difArray[lenDifArray] = (averageOwner) - (averageHacker);
            sumsum = " ";
            sumsum1 = " ";
            for (int i = 0; i < this.currentOwnerTryNumber; i++)
            {
                this.sumsum = this.sumsum + "   "+ this.ownerTime[i].ToString();
                
            }
            for (int i = 0; i < this.currentHackerTryNumber; i++)
            {
                this.sumsum1 = this.sumsum1 + "   " + this.hackerTime[i].ToString();

            }
            columnOwnerArray[lenDifArray] = averageOwner;
            columnHackerArray[lenDifArray] = averageHacker;
            //lenDifArray = lenDifArray + 1;
            lenDifArray = lenDifArray + 1;

        }

        public void clearBefore()
        {
            
            this.ownerTime = null;
            this.hackerTime = null;
            ownerTime = new int[100];
            hackerTime = new int[100];
            this.currentOwnerTryNumber = 0;
            this.currentHackerTryNumber = 0;
            this.averageOwner = 0;
            this.averageHacker = 0;
        }

        public void PaintGraph()
        {
            myStatGraph.Clear(Color.White);
            
            Pen myPen3 = new Pen(Color.Green);
            Pen myPen4 = new Pen(Color.Red);
            int width = 20;
            xForRect = 10;
            int margin = 20;
            //myStatGraph.Clear(Color.White);
            for (int i = 0; i < lenDifArray; i++)
            {

                  myStatGraph.DrawRectangle(myPen3, (xForRect), -((columnOwnerArray[i])/50), (width / 2), ((columnOwnerArray[i])/50));
                  myStatGraph.DrawRectangle(myPen4, (xForRect+(width/2)), -((columnHackerArray[i])/50), (width / 2), ((columnHackerArray[i])/50));
                  xForRect = xForRect + width+margin;
                
            }
            
        }
        public void totallyClear()
        {
            this.ownerTime = null;
            this.hackerTime = null;
            ownerTime = new int[100];
            hackerTime = new int[100];
            this.currentOwnerTryNumber = 0;
            this.currentHackerTryNumber = 0;
            this.averageOwner = 0;
            this.averageHacker = 0;
            this.columnOwnerArray = null;
            this.columnHackerArray = null;
            columnOwnerArray = new float[100];
            columnHackerArray = new float[100];
            lenDifArray = 0;
        }
    }
}
