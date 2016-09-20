using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsApplication1
{
    public class LineMaker
    {
        private Graphics myGr;
       
        public LineMaker(Graphics Gr) 
            {
            myGr = Gr;
            
            }
        public void DrawLine(Node Node1, Node Node2)
        {
            Pen myP = new Pen(Color.Red);
            myGr.DrawLine(myP, Node1.propXc, Node1.propYc, Node2.propXc, Node2.propYc);
        }
        public void Paint(string KeyStoreList, Node[] ArrOfNode)
        {
            int j1;
            int j2;
            int len = KeyStoreList.Length;
            for (int i = 0; i < len - 1; i++)
            {

                j1 = Convert.ToInt32(KeyStoreList.Substring(i,1));
                j2 = Convert.ToInt32(KeyStoreList.Substring(i + 1,1));
                DrawLine(ArrOfNode[j1], ArrOfNode[j2]);
               //ТУТ ПИСАТЬ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
        }
        public void paintToCurrent(float x11, float y11, float x22, float y22)
        {
            Pen myP = new Pen(Color.Red);
            myGr.DrawLine(myP, x11, y11, x22, y22);

        }
    }
}
