using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class Test
    {
        public Graphics myStatGraph;
        public string realKey; 
        public int[] hackerTime;
        public int[] ownerTime;
        public int wrongTry;
        public int currentHackerTryNumber = 0;
        public int currentOwnerTryNumber = 0;
        public void paintAxis(string nameAxisX,string nameAxisY)
        {
        }
       
        public void anotherHackerTry(int timeTry)
        {
            hackerTime[currentHackerTryNumber] = timeTry;
            currentHackerTryNumber = currentHackerTryNumber + 1;
        }
        public void anotherOwnerTry(int timeTry)
        {
            ownerTime[currentOwnerTryNumber] = timeTry;
            currentOwnerTryNumber = currentOwnerTryNumber + 1;
        }



    }
}
