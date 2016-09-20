using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class Node
    {
        private int id;
        public int propId
        {
            get { return id; }
        }
        private float x1;
        private float y1;
        private float x2;
        private float y2;
        public float propX1
        {
            get { return x1; }
        }
        public float propX2
        {
            get { return x2; }
        }
        public float propY1
        {
            get { return y1; }
        }

        public float propY2
        {
            get { return y2; }
        }

        private float x; // х координата центра круга
        private float y; // y координата центра круга
        public float propXc
        {
            get { return x; }
        }
        public float propYc
        {
            get { return y; }
        }

        public Node (int id, float x1, float y1, float x2, float y2)
            {
            this.id = id;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            }
        public void PaintMyself(Graphics Gr)
        {
            Pen P = new Pen(Color.Black);
            Gr.DrawEllipse(P, this.x1, this.y1, this.x2, this.y2);
            float xc = Math.Abs(this.x1+(this.x2/2));
            float yc = Math.Abs(this.y1+(this.y2/2));
            this.x = xc;
            this.y = yc;    
            Gr.FillEllipse(Brushes.Black, xc-2, yc-2, 5, 5);
        } 
        public int CheckPoint(float x, float y)
        {
            int answer = 0;
            double helper = 0;
            double radius2 = 0;
            radius2 = Math.Pow(((this.propX2)/2), 2);
            helper = Math.Pow((x-propXc),2)+ Math.Pow((y - propYc), 2);
            if (helper <= radius2)
            {
               answer = this.id;
            }
            else answer = 404;         
                       
            return answer;
        }

    }
}
