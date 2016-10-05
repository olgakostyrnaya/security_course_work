using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Drawing;
using System.IO;
using System.Diagnostics;



namespace WindowsFormsApplication1
{
    public class MainBox 
    {
        private TestAttemptsNumber test1;
        public TestAttemptsNumber propTest1
        {
            get { return test1; }
            set { test1 = value; }
        }

        private TestLengthKey test2;
        public TestLengthKey propTest2
        {
            get { return test2; }
            set { test2 = value; }
        }

        public int myChecker;
        private string stateGraph;
        public string propState
        {
            get { return stateGraph; }
            set { stateGraph = value; }
        }
        private Graphics myGraph; 
        private LineMaker myMaker;
        public LineMaker propMak
        {
            get { return myMaker; }

        }

       
        private KeyStore myStore;
        public KeyStore propStore
        {
            get { return myStore; }
        }
        private Stopwatch myTimer;
        public Stopwatch propTime
        {
            get { return myTimer; }
        }
        private Node[] arrayOfNode;
        public Node[] propNode
        {
            get { return arrayOfNode; }
        }

        public void repaintScreen()
        {
            myStore.exitSignal = false;
            myStore.clearArr();
            myGraph.Clear(Color.White);
            for (int i = 0; i <= 8; i++)
            {
                arrayOfNode[i].PaintMyself(myGraph);
            }
        }
    

        public MainBox (Graphics pBox1, Graphics pBox2, Graphics pBox3)
            {
            
            myGraph = pBox1;
            myGraph.Clear(Color.White);
            myTimer = new Stopwatch();
            Node N0 = new Node(0, 10, 10, 40, 40);
            Node N1 = new Node(1, 70, 10, 40, 40);
            Node N2 = new Node(2, 130, 10, 40, 40);
            Node N3 = new Node(3, 10, 70, 40, 40);
            Node N4 = new Node(4, 70, 70, 40, 40);
            Node N5 = new Node(5, 130, 70, 40, 40);
            Node N6 = new Node(6, 10, 130, 40, 40);
            Node N7 = new Node(7, 70, 130, 40, 40);
            Node N8 = new Node(8, 130, 130, 40, 40);
            arrayOfNode = new Node[9] { N0, N1, N2, N3, N4, N5, N6, N7, N8};
            for (int i = 0; i <= 8; i++)
            {
                arrayOfNode[i].PaintMyself(myGraph);
            }
            myStore = new KeyStore();
            myMaker = new LineMaker(myGraph);
            test1 = new TestAttemptsNumber(pBox2);
            test1.ownerTime = new int[200];
            test1.hackerTime = new int[200];
            test2 = new TestLengthKey(pBox3);
            test2.ownerTime = new int[200];
            test2.hackerTime = new int[200];
            stateGraph = "first";
            myChecker = 0;
        }

    }
}
