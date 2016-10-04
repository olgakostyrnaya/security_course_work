using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class TestAttemptsNumber : Test
    {
        public string sumO;
        public string sumH;      
        public TestAttemptsNumber (Graphics Gr)
        {
            this.myStatGraph = Gr;
            this.currentHackerTryNumber = 0;
            this.currentOwnerTryNumber = 0;
            myStatGraph.TranslateTransform(0, 249);
        }
        public void writeOwnerTime(int currentTime)
        {
           
                ownerTime[this.currentOwnerTryNumber] = currentTime;
               this.currentOwnerTryNumber = this.currentOwnerTryNumber + 1;
            sumO = currentOwnerTryNumber.ToString();


        }
        public void writeHackerTime(int currentTime)
        {
            hackerTime[this.currentHackerTryNumber] = currentTime;
            this.currentHackerTryNumber = this.currentHackerTryNumber + 1;
            sumH = currentHackerTryNumber.ToString();
        }



        public void PaintGraph()
        {
            myStatGraph.Clear(Color.White);
          
            Pen myPen1;
            Pen myPen2;
            myPen1 = new Pen(Color.Green);
            myPen2 = new Pen(Color.Red);
         
            Point[] apt = new Point[currentOwnerTryNumber];
         
            for (int i = 0; i < currentOwnerTryNumber;i++)
            {
                apt[i] = new Point(i*30,-(this.ownerTime[i])/25);
               
            }

            myStatGraph.DrawLines(myPen1, apt);

            Point[] apt1 = new Point[currentHackerTryNumber];
          
            for (int j = 0; j < currentHackerTryNumber; j++)
            {
                apt1[j] = new Point(j*30, -(this.hackerTime[j])/25);
            }


            myStatGraph.DrawLines(myPen2, apt1);
            
        }
        public void clearBefore()
        {
            this.ownerTime = null;
            hackerTime = null;
            ownerTime = new int[100];
            hackerTime = new int[100];
            this.currentHackerTryNumber = 0;
            this.currentOwnerTryNumber = 0;
        }
    }
}
