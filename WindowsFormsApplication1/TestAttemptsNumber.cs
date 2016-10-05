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
            paintAxis();

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

        protected override void paintAxis()
        {
            Color myColor;
            Color black = Color.FromArgb(50, 0, 0);
            myColor = Color.FromArgb(50, black);
            Pen myPen = new Pen(myColor);

            int y;
            int x;
            y = -10;
            x = 30;
            while (y > -250)
            {
                myStatGraph.DrawLine(myPen, 0, y, 249, y);
                y = y - 10;
            }
            while (x < 250)
            {
                myStatGraph.DrawLine(myPen, x, 0, x, -249);
                x = x + 30;
            }

            paintLegend();
        }

        protected override void paintLegend()
        {
            Brush brushText = new SolidBrush(Color.Black);
            Brush myBrush = new SolidBrush(Color.White);
            Pen myPenForLegendRect = new Pen(Color.Black);
            myPenForLegendRect.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            myPenForLegendRect.Width = 2;
            Rectangle myRect = new Rectangle(135, -240, 90, 30);
            myStatGraph.DrawRectangle(myPenForLegendRect, myRect);
            myStatGraph.FillRectangle(myBrush, myRect);
            Pen myPenForOwner = new Pen(Color.Green);
            Pen myPenForHacker = new Pen(Color.Red);
            myStatGraph.DrawLine(myPenForOwner, 148, -230, 178, -230);
            myStatGraph.DrawLine(myPenForHacker, 148, -220, 178, -220);
            myStatGraph.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            Font font = new System.Drawing.Font("Arial", 7, FontStyle.Italic);
            myStatGraph.DrawString("owner", font , brushText, 180, -235);
            myStatGraph.DrawString("hacker", font, brushText, 180, -225);
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
