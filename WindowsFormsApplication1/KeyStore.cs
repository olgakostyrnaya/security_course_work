using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    public class KeyStore
    {
        private string keyAsText;
        public string propKeyText
        {
            get { return keyAsText; }
        }
        public bool exitSignal;
        public Node firstNode;

        

        private string pathFile;
        public string propPath
        {
            get { return pathFile; }
            set { pathFile = value; }
        }
        private int lenArr;
        public int propLen
        {
            get { return lenArr; }
            set { lenArr = value; }
        }
        public Node[] keyArray;
        public bool checkNodeInStore(Node nodeToFind)
        {
            bool answer;
            if (keyAsText.Contains(nodeToFind.propId.ToString()))
            { answer = true; }
            else answer = false;
            return answer;
        }
        public bool firstOrNot(Node newNode)
        {
            bool answer = false;
            if (newNode.propId == this.firstNode.propId)
            {
                answer = true;
            }
            else answer = false;
            return answer;
        }

        public void addNode(Node newNode)
            {
            if (propLen == 0)
            {              
                propLen = propLen + 1;
                keyArray.SetValue(newNode, propLen);
               // keyAsText = keyAsText + newNode.propId;
                firstNode = newNode;
                exitSignal = false;
         //       return;
                // currentNode = newNode;
            }
            else
             {
                if ((checkNodeInStore(newNode) == false)) //|| (firstOrNot(newNode)==true))
                {
                    propLen = propLen + 1;
                    keyArray.SetValue(newNode, propLen);
                    keyAsText = keyAsText + newNode.propId;
                    exitSignal = false;
                }
                else
                {
                    if ((firstOrNot(newNode) == true) && ((firstOrNot(keyArray[propLen]))==false))
                    {
                        propLen = propLen + 1;
                        keyArray.SetValue(newNode, propLen);
                        keyAsText = keyAsText + newNode.propId;
                        exitSignal = true;
                    }
                }  
            }
        
        }
        public void clearArr()
        {
            
            propLen = 0;
            keyAsText = "";
        }
        public void saveToFile()

        {
            
            StreamWriter myStreamWriter; 
            FileInfo fileforstream = new FileInfo(propPath);
            myStreamWriter = fileforstream.AppendText();
            myStreamWriter.WriteLine(keyAsText);
            myStreamWriter.Close();
            
        }
        public string readFromFile()
        {
            StreamReader myStreamReader = new StreamReader(propPath);
            string keyText = "";
            while (!myStreamReader.EndOfStream)
            {
                keyText += myStreamReader.ReadLine();
            }
            return keyText;

        }
        public KeyStore()
        {
            exitSignal = false;
            firstNode = null;
            propLen = 0;
            propPath = "serviceFile.txt";
            keyAsText = "";
            keyArray = new Node [1000];
            FileInfo file = new FileInfo(propPath);
            if (file.Exists == false)
            {
                file.Create();

            }
            else
            {
                file.Delete();
                file.Create();
            }
        }

    }
}
