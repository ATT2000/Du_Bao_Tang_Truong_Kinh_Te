using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ID3_BANKING
{
    class DecisionTree
    {
        private List<DTNode> lstNode;
        int n;//the total elements in lslNode

        public DecisionTree()
        {
            n = 0;
            lstNode = new List<DTNode>();
        }

        public void Clear()
        {
            lstNode.Clear();
            n = 0;
            DTNode.CountID = 0;
        }

        public void AddNode(DTNode node)
        {
            lstNode.Add(node);
            n++;
            for (int i = 0; i < n; i++)
                if (lstNode[i].ID == node.ParentID)
                {
                    lstNode[i].NChild++;
                    break;
                }
        }

        public List<DTNode> Nodes
        {
            get { return lstNode; }
        }

        public int Count
        {
            get { return lstNode.Count; }
        }

        public int Height()
        {
            int h = 1;//for Root
            

            if (n < 1)
                return 0;
            if (n < 2)
                return 1;
            //n>>=2
            for (int i = 0; i < n - 1; i++)
            {
                //return max level of decision tree
                if (h < lstNode[i].Level)
                    h = lstNode[i].Level;
            }
            return h;
        }

        //return total Leaf Node
        public int Width()
        {
            int w = 0;
            for (int i = 0; i < n; i++)
            {
                if (lstNode[i].Leaf == true)
                    w++;
            }
            return w;
        }

        public int Width(int target)
        {
            int w = 0;//return this variable

            //find node is target
            int k = 0;
            for (int i = 0; i < n; i++)
                if (lstNode[i].ID == target)
                {
                    k = i;
                    break;
                }
            //node[k] is leaf
            if (lstNode[k].Leaf == true)
                return 1;
            //get width from target node to the end of list
            for (int i = k; i < n; i++)
            {
                if (lstNode[i].Leaf == true)
                {
                    //find parent of lstNode[[i]
                    int j = i;
                    while (lstNode[j].ParentID != target)
                    {
                        //j = lstNode[j].ParentID - 1;
                        j = lstNode[j].ParentID;
                        if (j < target)
                            break;
                    }

                    //increase width of target Node
                    if (lstNode[j].ParentID == target)
                        w++;
                }
            }
            return w;
        }

        public void CalculateStartEnd()
        {
            this.Nodes[0].SetStartEnd(0, this.Width());
            for (int i = 0; i < this.Count; i++)
            {
                if (this.Nodes[i].IsSetStartEnd == true)
                {   //node[i] was set location
                    int tmpStart = this.Nodes[i].Start;
                    int startJ, endJ;

                    for (int j = i; j < this.Count; j++)
                    {   //search all children of node[i]
                        //set start & end to node[i]'s children
                        if (this.Nodes[j].ParentID == this.Nodes[i].ID)
                        {
                            startJ = tmpStart;
                            endJ = tmpStart + this.Width(this.Nodes[j].ID);
                            this.Nodes[j].SetStartEnd(startJ, endJ);
                            tmpStart = this.Nodes[j].End;//update tmpStart
                            if (tmpStart == this.Nodes[i].End)
                                break;//means node[i] have no child more
                        }
                    }
                }
                else
                {   //node[i] wasn't set location
                    for (int j = i - 1; j > -1; j--)
                    { //find parent of node[i]
                        if (this.Nodes[j].ID == this.Nodes[i].ParentID)
                            i = j;//calculate Start & End of node[i]'s parent
                    }
                }
            }
        }

        public void SortByLevel()
        {
            for (int i = 0; i < lstNode.Count - 1; i++)
            {
                for (int j = i; j < lstNode.Count; j++)
                {
                    if (lstNode[i].Level > lstNode[j].Level)
                    {
                        DTNode tmp = lstNode[i];
                        lstNode[i] = lstNode[j];
                        lstNode[j] = tmp;
                    }
                }
            }

            for (int i = 0; i < lstNode.Count - 1; i++)
            {
                for (int j = i; j < lstNode.Count; j++)
                {
                    if (lstNode[i].Level == lstNode[j].Level && lstNode[i].ID > lstNode[j].ID)
                    {
                        DTNode tmp = lstNode[i];
                        lstNode[i] = lstNode[j];
                        lstNode[j] = tmp;
                    }
                }
            }
        }

        private List<string> ResultStatus()
        {
            List<string> results = new List<string>();
            for (int i = 0; i < Count; i++)
            {
                if (Nodes[i].Leaf == true && results.Contains(Nodes[i].Name) == false)
                    results.Add(Nodes[i].Name);
            }

            return results;
        }

        public string GetRules()
        {
            FileStream fs = new FileStream("rules.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            if (Count < 1)
                return "Cây không tồn tại!";
            Stack<DTNode> stkRules = new Stack<DTNode>();
            string rules = "";
            string luat = "";
            List<string> values = ResultStatus();
            
            for (int k = 0; k < values.Count; k++)
            {
                rules += "\n";
                rules += "Luật của kết quả: \"" + values[k] + "\"\n";
                luat=GetRules(values[k]);
                rules +=luat;
                string[] mang = luat.Split('\n');
                for (int i = 0; i < mang.Length; i++)
                {
                    if(mang[i].Trim()!="")
                        sw.WriteLine(mang[i]);
                }
                
            }
            rules = rules.Remove(rules.Length - 1);
            sw.Close();
            fs.Close();
            return rules;
        }

        private string GetRules(string result)
        {
            
            Stack<DTNode> stkRules = new Stack<DTNode>();
            string rules = "";

            for (int i = 0; i < Count; i++)
            {
                if (Nodes[i].Leaf == true && Nodes[i].Name == result)
                {
                    int tmp = i;
                    for (int j = i - 1; j > -1; j--)
                    {
                        if (Nodes[j].ID == Nodes[i].ParentID)
                        {
                            stkRules.Push(Nodes[j]);
                            i = j;
                        }
                    }
                    i = tmp;//restore i
                    //print rule

                    while (stkRules.Count > 1)
                    {
                        if (stkRules.Peek().Attribute == true)
                            rules += stkRules.Pop().Name + "-";
                        else
                            rules += stkRules.Pop().Name + "-";
                    }
                    rules += stkRules.Pop().Name + "-" + result + "\n";
                }
            }

            return rules;
        }
    }
}
