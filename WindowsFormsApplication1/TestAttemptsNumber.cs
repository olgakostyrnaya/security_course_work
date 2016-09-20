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
            //int i;// = 0;
            //int j;// = 0;
         //   if (this.currentOwnerTryNumber < 5)
           // {
                ownerTime[this.currentOwnerTryNumber] = currentTime;
               this.currentOwnerTryNumber = this.currentOwnerTryNumber + 1;
               // i = i + 1;

        //    }
          //  else
           // {
             //   if (this.currentHackerTryNumber < 5)
               // {
               
                    //j = j + 1;
                //}
            //}


        }
        public void writeHackerTime(int currentTime)
        {
            hackerTime[this.currentHackerTryNumber] = currentTime;
            this.currentHackerTryNumber = this.currentHackerTryNumber + 1;
        }



        public void PaintGraph(Graphics GrTest)
        {



            //MyBox.propStore.saveToFile();
            // Graphics g = pictureBox2.CreateGraphics();
            //float d = pictureBox2.Size.Height;
            //g.TranslateTransform(0.0F, d);
            GrTest.TranslateTransform(0, 249);
            //   Graphics formGraphics = pictureBox2.CreateGraphics();
            Pen myPen;
            Pen myPen2;
            myPen = new Pen(Color.Red);
            myPen2 = new Pen(Color.Aqua);
         
            Point[] apt = new Point[7];
         
            for (int i = 0; i < 7;i++)
            {
                apt[i] = new Point(i*30,-(this.ownerTime[i])/5);
               
            }
            // apt[7] = new Point(6*20, 0);
            GrTest.DrawLines(myPen, apt);

            Point[] apt1 = new Point[7];
          
            for (int j = 0; j < 7; j++)
            {
                apt1[j] = new Point(j*30, -(this.hackerTime[j])/5);
            }
            //apt1[7] = new Point(6*20, 0);

            
         //   GrTest.DrawLine(new Pen(Color.Black), apt[6], apt[0]);



         

            GrTest.DrawLines(myPen2, apt1);
            //GrTest.DrawLine(new Pen(Color.White), apt1[6], apt1[0]);

            //GrTest.DrawCurve(myPen, apt);
            // GrTest.DrawCurve(myPen2, apt1);
            // GrTest.DrawBezier(myPen2, apt1[0], apt1[1], apt1[2], apt1[3]);
            //GrTest.DrawBezier(myPen2, apt1[4], apt1[5], apt1[6], apt1[7]);
            //myStatGraph.DrawBezier(myPen2, apt1, 0, 3, 0.9f);
            //.DrawLine(myPen, 0, pictureBox2.Height, pictureBox2.Width, pictureBox2.Height);
            //g.DrawBezier(myPen, 0, 0, 20, -20, 40, -35, 80, -50);
            //g.DrawBezier(new Pen(Color.Aqua), 2, -10, 20, -22, 38, -33, 75, -50);
        }
    }
}
