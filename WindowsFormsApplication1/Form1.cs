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

            btnAttemptsNumber.Visible = false;
            btnTestLength.Visible = false;
            btnGeneralKey.Visible = false;
            btnClearPBox3.Visible = false;
            this.Width = 220;
            this.Height = 240;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            lblTest1.Visible = false;
            lblTest2.Visible = false;
            btnTest1PMinus.Visible = false;
            btnTest1Plus.Visible = false;
            btnTest2Minus.Visible = false;
            btnTest2Plus.Visible = false;
            label6.Visible = false;
            label4.Visible = false;
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
            this.Width = 740;
            this.Height = 390;
            

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
            btnGeneralKey.Visible = true;
            btnClearPBox3.Visible = true;

            lblTest1.Visible = true;
            lblTest2.Visible = true;
            lblTest1.Text = "5";
            lblTest2.Text = "3";

            btnTest1PMinus.Visible = true;
            btnTest1Plus.Visible = true;
            btnTest2Minus.Visible = true;
            btnTest2Plus.Visible = true;
            label6.Visible = true;
            label4.Visible = true;

            Graphics Gr1 = pictureBox1.CreateGraphics();
            Graphics Gr2 = pictureBox2.CreateGraphics();
            Graphics Gr3 = pictureBox3.CreateGraphics();
            MyBox = new MainBox(Gr1,Gr2,Gr3);
            MyBox.propState = "neutral";
           


        }

        

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {


            switch (MyBox.propState)
            {
                case "first":
                    if (MyBox.propStore.exitSignal == true)
                    {
                        MyBox.propTime.Stop();
                       // label1.Text = MyBox.propTime.Elapsed.Seconds.ToString();
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
                          //  label1.Text = numberOfNode.ToString();
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
                    int numAtt;
                    numAtt = (Convert.ToInt32(lblTest1.Text)) * 2;
                    if (MyBox.myChecker == numAtt+1) //|| (MyBox.myChecker > 14))
                    {
                        MessageBox.Show("Test done!", "Number Attempts Test");
                        MyBox.propTest1.PaintGraph();
                        MyBox.propTest1.clearBefore();
                        MyBox.myChecker = 0;
                        MyBox.propState = "neutral";
                        pictureBox2.Update();
                        label3.Text = MyBox.propTest1.sumO + " и " + MyBox.propTest1.sumH;
                        return;
                    };

                    if (MyBox.propStore.exitSignal == true)
                    {

                        MyBox.propTime.Stop();
                        
                        MyBox.repaintScreen();
                        label1.Text = MyBox.propTime.ElapsedMilliseconds.ToString();
                        int ququ = Convert.ToInt32((MyBox.propTime.ElapsedMilliseconds));
                      //  label1.Text = ququ.ToString();
                        MyBox.propTime.Reset();

                        if (MyBox.myChecker <= (numAtt/2))

                        {
                            MyBox.propTest1.writeOwnerTime(ququ);
                            if (MyBox.myChecker == (numAtt/2)) { MessageBox.Show("Start hacker attempts", "Number Attempts Test"); }
                        }
                        else
                        {
                           
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

                    int numberOfNode1 = 20;
                    
                    for (int i = 0; i <= 8; i++)
                    {

                        numberOfNode1 = (MyBox.propNode[i].CheckPoint(x1, y1));
                        if ((numberOfNode1 < 404)) //|| (numberOfNode1 == MyBox.propStore.firstNode.propId))
                        {

                            MyBox.propStore.addNode(MyBox.propNode[numberOfNode1]);
                        //    label1.Text = numberOfNode1.ToString();
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
                int numCheck; // 6 10 14 18
                    numCheck = (Convert.ToInt32(lblTest2.Text))*2;
                    //     while (MyBox.myChecker < 18)
                    //   {
                    //if (MyBox.myChecker < 18)
                   // {
                        if ((MyBox.myChecker == numCheck+1) || (MyBox.myChecker > numCheck))
                        {
                            MessageBox.Show("Test done!", "Length Key Test");
                        
                        
                            MyBox.propTest2.averageTime();
                            MyBox.propTest2.PaintGraph();
                            MyBox.propTest2.clearBefore();
                            MyBox.myChecker = 0;
                            MyBox.propState = "neutral";
                            pictureBox3.Update();
                           label1.Text = MyBox.propTest2.sumsum;
                           label2.Text = MyBox.propTest2.sumsum1;
                        
                        return;
                        };

                    if (MyBox.propStore.exitSignal == true)
                    {

                        MyBox.propTime.Stop(); //ТУУУУТ!
                        MyBox.repaintScreen();





                        int timerToTest = Convert.ToInt32(MyBox.propTime.ElapsedMilliseconds);
                        MyBox.propTime.Reset();
                        label1.Text = timerToTest.ToString();

                    
                   
                            if (MyBox.myChecker <= (numCheck / 2)) // here

                            {
                                MyBox.propTest2.writeOwnerTime(timerToTest);
                                if (MyBox.myChecker == (numCheck / 2)) { MessageBox.Show("Start hacker attempts", "Length Key Test"); }

                        }
                            else
                            { // here
                                
                                MyBox.propTest2.writeHackerTime(timerToTest);
                               
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
                            if ((numberOfNode2 < 404))// || (MyBox.propStore.propLen <= (numCheck/2))) //|| (numberOfNode2 == MyBox.propStore.firstNode.propId))
                            {

                                MyBox.propStore.addNode(MyBox.propNode[numberOfNode2]);
                                //label1.Text = numberOfNode2.ToString();
                                break;

                            }

                        }


                        if (MyBox.propStore.propLen >= 1)
                        {
                            MyBox.propMak.Paint(MyBox.propStore.propKeyText, MyBox.propNode);

                        }

                    
                    break;

                case "neutral":
                    break;
            }

            

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

          


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
            MyBox.myChecker = 1;
            MyBox.propState = "test1";
            MyBox.repaintScreen();
            MyBox.propTest1.myStatGraph.Clear(Color.White);
        //    MyBox.propTest1.realKey = MyBox.propStore.propKeyText;
            MyBox.propStore.exitSignal = false;
            MyBox.propTest1.clearBefore();
            MyBox.propStore.clearArr();
           
            //pictureBox2.Refresh();

            MessageBox.Show("Start owner attempts","Number Attempts Test");

        }

        private void btnTestLength_Click(object sender, EventArgs e)
        {
            MyBox.myChecker = 1;
            MyBox.propState = "test2";
            MyBox.repaintScreen();
            MyBox.propStore.exitSignal = false;
            MyBox.propTest2.clearBefore();
            MyBox.propStore.clearArr();
            MessageBox.Show("Start owner attempts", "Length Key Test");
        }

        private void btnClearPBox3_Click(object sender, EventArgs e)
        {

            pictureBox3.Refresh();
            MyBox.myChecker = 1;
            MyBox.propTest2.clearBefore();
            // MyBox.propStore.clearArr();
            MyBox.propTest2.totallyClear();


        }

        private void btnGeneralKey_Click(object sender, EventArgs e)
        {
            MyBox.propState = "first";
        }

        private void btnTest1PMinus_Click(object sender, EventArgs e)
        {
            int serviceNum = 0;
            serviceNum = Convert.ToInt32(lblTest1.Text);
            if (serviceNum <= 2)
            { return; }
            else
            {
                serviceNum = serviceNum - 1;
                lblTest1.Text = serviceNum.ToString();
            }
        }

        private void btnTest2Minus_Click(object sender, EventArgs e)
        {
            int serviceNum = 0;
            serviceNum = Convert.ToInt32(lblTest2.Text);
            if (serviceNum <= 2)
            { return; }
            else
            {
                serviceNum = serviceNum - 1;
                lblTest2.Text = serviceNum.ToString();
            }
        }

        private void btnTest1Plus_Click(object sender, EventArgs e)
        {
            int serviceNum = 0;
            serviceNum = Convert.ToInt32(lblTest1.Text);
            serviceNum = serviceNum + 1;
            lblTest1.Text = serviceNum.ToString();
           
        }

        private void btnTest2Plus_Click(object sender, EventArgs e)
        {
            int serviceNum = 0;
            serviceNum = Convert.ToInt32(lblTest2.Text);
            serviceNum = serviceNum + 1;
            lblTest2.Text = serviceNum.ToString();
        }
    }
}
