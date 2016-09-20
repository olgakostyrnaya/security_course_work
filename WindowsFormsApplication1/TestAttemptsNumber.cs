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

        public TestAttemptsNumber (Graphics Gr)
        {
            this.myStatGraph = Gr;
            this.currentHackerTryNumber = 0;
            this.currentOwnerTryNumber = 0;

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



        public void PaintGraph()
        {
            myStatGraph.TranslateTransform(0, 249);
            Pen myPen;
            Pen myPen2;
            myPen = new Pen(Color.Red);
            myPen2 = new Pen(Color.Aqua);
         
            Point[] apt = new Point[currentOwnerTryNumber];
         
            for (int i = 0; i < currentOwnerTryNumber;i++)
            {
                apt[i] = new Point(i*30,-(this.ownerTime[i])/5);
               
            }

            myStatGraph.DrawLines(myPen, apt);

            Point[] apt1 = new Point[currentHackerTryNumber];
          
            for (int j = 0; j < currentHackerTryNumber; j++)
            {
                apt1[j] = new Point(j*30, -(this.hackerTime[j])/5);
            }


            myStatGraph.DrawLines(myPen2, apt1);
         
        }
    }
}
