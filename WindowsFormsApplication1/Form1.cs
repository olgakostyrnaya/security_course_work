using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private MainBox MyBox;
        public Form1()
        {
           
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            btnOK.Visible = false;
            btnCancel.Visible = false;
            checkBox1.Visible = false;
            btnAttemptsNumber.Visible = false;
            btnTestLength.Visible = false;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyBox.propState = "neutral";

        }

        
        
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;

            btnStart.Visible = false;
            btnAttemptsNumber.Visible = true;
            btnTestLength.Visible = true;
            pictureBox1.Enabled = true;
            btnOK.Visible = true;
            btnCancel.Visible = true;
            checkBox1.Visible = true;
            Graphics Gr1 = pictureBox1.CreateGraphics();
            Graphics Gr2 = pictureBox2.CreateGraphics();
            Graphics Gr3 = pictureBox3.CreateGraphics();
            MyBox = new MainBox(Gr1,Gr2,Gr3);

           


        }

        

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {


            switch (MyBox.propState)
            {
                case "first":
                    if (MyBox.propStore.exitSignal == true)
                    {
                        MyBox.propTime.Stop();
                        label1.Text = MyBox.propTime.Elapsed.Seconds.ToString();
                        return;
                    }

                    float x = e.X;
                    float y = e.Y;

                    int numberOfNode = 20;
                    string sp = "_";


                    label2.Text = (x.ToString()) + sp + (y.ToString());
                    for (int i = 0; i <= 8; i++)
                    {

                        numberOfNode = (MyBox.propNode[i].CheckPoint(x, y));
                        if (numberOfNode < 404)
                        {

                            MyBox.propStore.addNode(MyBox.propNode[numberOfNode]);
                            label1.Text = numberOfNode.ToString();
                            break;

                        }

                    }


                    if (MyBox.propStore.propLen >= 1)
                    {
                        MyBox.propMak.Paint(MyBox.propStore.propKeyText, MyBox.propNode);
                        //  pictureBox1.Refresh();
                    }
                    //label2.Text = " ";
                    label2.Text = MyBox.propStore.propKeyText.ToString();


                    break;
                case "test1":

                    if ((MyBox.myChecker == 14) || (MyBox.myChecker > 14))
                    {
                        MessageBox.Show("Test done!", "Number Attempts Test");
                        MyBox.propTest1.PaintGraph();
                        MyBox.propState = "neutral";
                        return;
                    };

                    if (MyBox.propStore.exitSignal == true)
                    {

                        MyBox.propTime.Stop();
                        MyBox.repaintScreen();
                        label1.Text = MyBox.propTime.Elapsed.Milliseconds.ToString();
                        int ququ = MyBox.propTime.Elapsed.Milliseconds;
                        MyBox.propTime.Reset();

                        if (MyBox.myChecker < 7-1)

                        {
                            MyBox.propTest1.writeOwnerTime(ququ);

                        }
                        else
                        {
                            if (MyBox.myChecker == 7-1) { MessageBox.Show("Start hacker attempts", "Number Attempts Test"); }
                            MyBox.propTest1.writeHackerTime(ququ);
                            // MyBox.propTest1.currentHackerTryNumber = MyBox.propTest1.currentHackerTryNumber + 1; 
                        }

                        MyBox.myChecker = MyBox.myChecker + 1;
                        MyBox.propStore.exitSignal = false;

                        return;
                    }
                    MyBox.propTime.Start();
                    float x1 = e.X;
                    float y1 = e.Y;

                    int numberOfNode1;
                    
                    for (int i = 0; i <= 8; i++)
                    {

                        numberOfNode1 = (MyBox.propNode[i].CheckPoint(x1, y1));
                        if ((numberOfNode1 < 404) || (numberOfNode1 == MyBox.propStore.firstNode.propId))
                        {

                            MyBox.propStore.addNode(MyBox.propNode[numberOfNode1]);
                            label1.Text = numberOfNode1.ToString();
                            break;

                        }

                    }


                    if (MyBox.propStore.propLen >= 1)
                    {
                        MyBox.propMak.Paint(MyBox.propStore.propKeyText, MyBox.propNode);
                        //  pictureBox1.Refresh();
                    }
                    //label2.Text = " ";
                    label2.Text = MyBox.propStore.propKeyText.ToString();



                   break;
                case "test2":
                int numCheck = 6; // 6 10 14 18

                    //     while (MyBox.myChecker < 18)
                    //   {
                    //if (MyBox.myChecker < 18)
                   // {
                        if ((MyBox.myChecker == numCheck) || (MyBox.myChecker > numCheck))
                        {
                            MessageBox.Show("Test done!", "Length Key Test");
                            MyBox.propTest2.averageTime();
                            MyBox.propTest2.PaintGraph();
                            MyBox.propTest2.clearBefore();
                            MyBox.myChecker = 0;
                            MyBox.propState = "neutral";
                            pictureBox3.Update();
                  
                            return;
                        };

                        if (MyBox.propStore.exitSignal == true) 
                        {

                            MyBox.propTime.Stop();
                            MyBox.repaintScreen();
                            //   label1.Text = MyBox.propTime.Elapsed.Milliseconds.ToString();
                            int timerToTest = MyBox.propTime.Elapsed.Milliseconds;
                            MyBox.propTime.Reset();

                            if (MyBox.myChecker < (numCheck / 2)-1)

                            {
                                MyBox.propTest2.writeOwnerTime(timerToTest);

                            }
                            else
                            {
                                if (MyBox.myChecker == (numCheck / 2) - 1) { MessageBox.Show("Start hacker attempts", "Length Key Test"); }
                                MyBox.propTest2.writeHackerTime(timerToTest);
                                // MyBox.propTest1.currentHackerTryNumber = MyBox.propTest1.currentHackerTryNumber + 1; 
                            }

                            MyBox.myChecker = MyBox.myChecker + 1;
                            MyBox.propStore.exitSignal = false;

                            return;
                        }
                        MyBox.propTime.Start();
                        float x2 = e.X;
                        float y2 = e.Y;

                        int numberOfNode2 = 20;

                        for (int j1 = 0; j1 <= 8; j1++)
                        {

                            numberOfNode2 = (MyBox.propNode[j1].CheckPoint(x2, y2));
                            if ((numberOfNode2 < 404)) //|| (MyBox.propStore.propLen <= (numCheck/2))) //|| (numberOfNode2 == MyBox.propStore.firstNode.propId))
                            {

                                MyBox.propStore.addNode(MyBox.propNode[numberOfNode2]);
                                label1.Text = numberOfNode2.ToString();
                                break;

                            }

                        }


                        if (MyBox.propStore.propLen >= 1)
                        {
                            MyBox.propMak.Paint(MyBox.propStore.propKeyText, MyBox.propNode);

                        }

                        //label2.Text = MyBox.propStore.propKeyText.ToString();


                    //}
                    //else {

                    //    MyBox.propState = "neutral";
                    //    return;
                   
                    //}
                    ////numCheck = numCheck + 4;
                    //  return;
                    break;

                case "neutral":
                    break;
            }

            

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            //// код
            //string a = "54";
            //string b = "2";
            //int c = 0;
            //c = Convert.ToInt32(a.Substring(1,1)); //+ Convert.ToInt32(b);
            //label2.Text = c.ToString();
            ////--------------------------------
            


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            MyBox.repaintScreen();
        }

        private void btnAttemptsNumber_Click(object sender, EventArgs e)
        {
            MyBox.propState = "test1";
            MyBox.repaintScreen();
            MyBox.propTest1.realKey = MyBox.propStore.propKeyText;
            MyBox.propStore.exitSignal = false;
            MyBox.propStore.clearArr();
            MessageBox.Show("Start owner attempts","Number Attempts Test");

        }

        private void btnTestLength_Click(object sender, EventArgs e)
        {

            MyBox.propState = "test2";
            MyBox.repaintScreen();
           // MyBox.propTest2.realKey = MyBox.propStore.propKeyText;--
            MyBox.propStore.exitSignal = false;
           // MyBox.propStore.clearArr();
            MyBox.propTest2.clearBefore();
           // MyBox.myChecker = 0;--
            MessageBox.Show("Start owner attempts", "Length Key Test");
            //Graphics g1 = pictureBox3.CreateGraphics();
            //g1.TranslateTransform(0, 249);
            //Pen myPen1 = new Pen(Color.BlueViolet);
            //int width = 50;
            //int xForRect = 10;
            //int margin = 20;
            //float[] difArray = new float[4];
            //difArray[0] = 100;
            //difArray[1] = 80;
            //difArray[2] = 30;
            //for (int i = 0; i < 3; i++)
            //{
            //    g1.DrawRectangle(myPen1, xForRect, -(difArray[i]), width, (difArray[i]));
            //    xForRect = xForRect + width + margin;
            //}


        }

        private void btnClearPBox3_Click(object sender, EventArgs e)
        {
            // MyBox.propState = "test2";
            //MyBox.repaintScreen();

            //  MyBox.propTest2.realKey = MyBox.propStore.propKeyText;
            //  MyBox.propStore.exitSignal = false;
            // MyBox.propStore.clearArr();
            pictureBox3.Refresh();
            MyBox.myChecker = 0;

        }
    }
}
