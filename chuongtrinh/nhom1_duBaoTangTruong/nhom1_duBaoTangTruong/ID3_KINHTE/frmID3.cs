using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace ID3_BANKING
{
    public partial class frmID3 : Form
    {
        string fileDatabase;//database's path
        //by default, fileDatase is set Training Examples.xls
        DecisionTree glDtID3Alg = new DecisionTree();
        List<string> staticAtt = new List<string>();
        List<Example> trainingExamples = new List<Example>();
        List<string> attributes = new List<string>();
        List<string> description = new List<string>();//output description of each step in drawing's function

        //controls
        OpenFileDialog ofdLoadDatabase = new OpenFileDialog();
        Timer timerMainForm = new Timer();
        Button[] btnNodes;
        Point[] p1;//draw line from p1 to p2
        Point[] p2;//draw line from p1 to p2
        int countArrowsToDraw = 0;
        int numberOfArrows = 0;
        int countDescription;

       
        public frmID3()
        {
            InitializeComponent();
        }
        private DataSet ds;
        private void BTKHOITAO_Click(object sender, EventArgs e)
        {
            //ĐỌC DỮ LIỆU TỪ FILE XML
            ds = new DataSet();
            ds.ReadXmlSchema("Schema_Banking.xml");
            ds.ReadXml("Data_Banking.xml");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BTID3_Click(object sender, EventArgs e)
        {
            //CODE THUC HIÊN ID3
            ResetDecisionTree();
            PreDrawing();
          
        }
        private void ResetDecisionTree()
        {
            //TẠO CÂY ID3 RỖNG
            if (glDtID3Alg.Count > 0)//decision tree has created
            {

                for (int i = 0; i < btnNodes.Length; i++)
                {
                    panelDrawing.Controls.Remove(btnNodes[i]);
                    btnNodes[i].Dispose();
                }
            }
            description.Clear();
            glDtID3Alg.Clear();
            trainingExamples.Clear();
            attributes.Clear();
            staticAtt.Clear();
            countArrowsToDraw = 0;
            numberOfArrows = 0;
            countDescription = 0;
            rtbDescription.Text = "";
            rtbRules.Text = "";
        }
       
       
        private void PreDrawing()
        {
            //CHỨC NĂNG CHÍNH ID3
            LoadDatabase(fileDatabase);//load database from file excel to datagrid control
            UpdateTrainingExamples();//update trainingExamples & attributes from datagrid control
            BuildingTree();//create decision tree from training examples
            rtbRules.Text = "Luật của kết quả tích cực:\n" + glDtID3Alg.GetRules();//output rules from training examples
           
        }
        private void LoadDatabase(string fileDatabase)
        {
            //LOAD DỮ LIỆU LÊN ĐỂ XỬ LÝ
            string chuoi = "";
         
            DataTable dtid3 = (DataTable)(dataGridView1.DataSource);
            
            lbthongbao.Text = "Tổng số dữ liệu: " + dtid3.Rows.Count;
            lbkt.Text = chuoi;
            //dataGridView1.DataSource = dtid3;
           
        }
       
        private void UpdateTrainingExamples()
        {
            //update attribute's Name
            //we will ignore first and last columns
            //first column is examples's ID
            //last column is result of examples
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                attributes.Add(column.HeaderText);
                staticAtt.Add(column.HeaderText);
            }

            //get data to training examples
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Example example = new Example();
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    example.AddValue(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
                trainingExamples.Add(example);
            }
        }
        //HÀM TÍNH Entropy TRONG ID3
        private double Entropy(List<Example> te)
        {
            //te: training examples

            //count the number of status of result's training examples
            Dictionary<string, int> results = new Dictionary<string, int>();
            foreach (Example exam in te)
            {
                string key = exam.GetResultTraining();
                if (results.ContainsKey(key) == false)
                {
                    //adding new key to dictionary
                    results.Add(key, 1);
                }
                else
                {
                    //increasing key's value
                    int value = results[key] + 1;
                    results.Remove(key);
                    results.Add(key, value);
                }
            }

            //evaluate Entropy
            double entropy = 0;
            double probability;
            ICollection<string> ss = results.Keys;
            foreach (string s in ss)
            {
                int k = results[s];
                probability = (double)results[s] / te.Count;
                entropy -= probability * Math.Log(probability, 2);
            }
            return entropy;
        }

        private double GainInformation(List<Example> te, int positionAtt, double entropy)
        {
            //te: training examples
            //att: attribute
            //ent: entropy

            //counting the number values of attribute
            //int positionAtt = staticAtt.IndexOf(att);//get index of att in attributes list
            if (positionAtt < 0)
                return 0;

            List<string> values = new List<string>();
            foreach (Example exp in te)
            {
                if (!values.Contains(exp.GetValue(positionAtt)))
                    values.Add(exp.GetValue(positionAtt));
            }

            //separate to N sub examples
            List<Example>[] subTe = new List<Example>[values.Count];
            for (int i = 0; i < values.Count; i++)
                subTe[i] = new List<Example>();
            foreach (Example exam in te)
            {
                for (int i = 0; i < values.Count; i++)
                {
                    if (exam.GetValue(positionAtt) == values[i])
                    {
                        subTe[i].Add(exam);
                        break;
                    }
                }
            }

            //evaluate entropy of sub training examples
            double[] entropyAtt = new double[values.Count];
            for (int i = 0; i < values.Count; i++)
                entropyAtt[i] = Entropy(subTe[i]);

            //evaluate gain information
            //double gainInfo = Entropy(te);
            for (int i = 0; i < subTe.Length; i++)
                entropy -= (double)subTe[i].Count / te.Count * entropyAtt[i];
            return entropy;
        }

        private int MaxGain(double[] gain, List<string> att)
        {
            //we will ignore first and last column
            int max = 1;
            for (int i = 2; i < gain.Length - 1; i++)
                if (gain[max] < gain[i])
                    max = i;
            return max;
        }

        private int ChooseBestAttribute(List<Example> te, List<string> att)
        {
            if (te.Count == 0 || att.Count == 0)
                return -1;
            double entropyTe = Entropy(te);
            double[] gainTe = new double[att.Count];
            for (int i = 0; i < att.Count; i++)
                gainTe[i] = GainInformation(te, i, entropyTe);

            //get string
            string tmp = "";
            tmp += "Entropy([";
            for (int i = 0; i < te.Count; i++)
                tmp += te[i].GetNameExample() + ",";
            tmp = tmp.Remove(tmp.Length - 1);
            tmp += "]) = " + entropyTe.ToString() + "\n";
            for (int i = 1; i < att.Count - 1; i++)
                tmp += "Gain(" + att[i] + ") = " + gainTe[i].ToString() + "\n";
            description.Add(tmp);

            return MaxGain(gainTe, att);
        }

        private void BuildingTree()
        {
            ID3Alg(trainingExamples, attributes, -1);//create root
            description.Add("HOÀN THÀNH!");
        }

        private void ID3Alg(List<Example> te, List<string> att, int parentID)
        {
            //checking to end this function
            if (te.Count == 0)
                return;
            if (att.Count == 2)//first column and last column: ID & reslt column
                return;

            //choose the best decision attribute
            //int best = ChooseBestAttribute(te, staticAtt);
            string bestAtt = staticAtt[ChooseBestAttribute(te, staticAtt)];

            //update description
            description[description.Count - 1] += "--->Chọn: " + bestAtt + "\n\n";

            //searching parent's level
            int level = 0;
            for (int i = 0; i < glDtID3Alg.Nodes.Count; i++)
                if (glDtID3Alg.Nodes[i].ID == parentID)
                    level = glDtID3Alg.Nodes[i].Level;

            //create nodes
            //first, we create parent node
            DTNode parentNode = new DTNode(bestAtt, true, parentID, level + 1, false);
            parentNode.Examples = te;

            //counting N the number values of attribute
            //to create N child nodes of node above
            int positionAtt = staticAtt.IndexOf(bestAtt);//get index of att in attributes list
            List<string> values = new List<string>();
            foreach (Example exp in te)
                if (!values.Contains(exp.GetValue(positionAtt)))
                    values.Add(exp.GetValue(positionAtt));

            //add new child nodes of this attribute
            DTNode[] childNode = new DTNode[values.Count];
            for (int i = 0; i < values.Count; i++)
            {
                childNode[i] = new DTNode(values[i], false, parentNode.ID, parentNode.Level + 1, false);
            }
            //level++;

            //separate te into childNodes
            foreach (Example exam in te)
            {
                for (int i = 0; i < values.Count; i++)
                    if (childNode[i].Name == exam.GetValue(staticAtt.IndexOf(bestAtt)))
                        childNode[i].Examples.Add(exam);
            }

            //add nodes to decision tree
            glDtID3Alg.AddNode(parentNode);
            for (int i = 0; i < values.Count; i++)
                glDtID3Alg.AddNode(childNode[i]);

            //we remove the best decision attribute before this function is recalled
            att.Remove(bestAtt);

            List<string> tmpatt = new List<string>();
            for (int i = 0; i < att.Count; i++)
                tmpatt.Add(att[i]);
            for (int i = 0; i < values.Count; i++)
                if (childNode[i].AllChildInOneClass() != true)
                    ID3Alg(childNode[i].Examples, tmpatt, childNode[i].ID);
                else
                {
                    //add new node Yes or No to this tree
                    DTNode tmpNode = new DTNode(childNode[i].Examples[0].GetLastValue(), false, childNode[i].ID, childNode[i].Level + 1, true);
                    glDtID3Alg.AddNode(tmpNode);
                }
        }


        private void frmID3_Load(object sender, EventArgs e)
        {

        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
