using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace ID3_BANKING
{
    public partial class frmUngDung : Form
    {
        public frmUngDung()
        {
            InitializeComponent();
        }
        private DataSet ds;
        private void BTChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();//MO FILE EXCEL
            dlg.Filter = "Excel Files (.xls)|*.*";
            OleDbConnection conn;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                //tenfile = dlg.FileName;
                txtpath.Text = fileName;
                string path = fileName;
                if (Path.GetExtension(path) == ".xls")
                {
                    conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"");
                }
                else
                {
                    conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
                }
                //oledbConn.Open();
                OleDbCommand cmd;
                OleDbDataAdapter da = new OleDbDataAdapter();// DOC DU LIEU EXCEL VAO DATASET
                ds = new DataSet();
                string query = "";

                query = "SELECT * FROM [Sheet1$]";


                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    cmd = new OleDbCommand(query, conn);
                    da = new OleDbDataAdapter(cmd);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];//HIỂN THỊ DỮ LIỆU LÊN DATAGRIDVIEW
                }
                catch (Exception loi)
                {
                    MessageBox.Show("loi " + loi.Message);

                }
                finally
                {
                    da.Dispose();
                    conn.Close();
                }
            }
        }

        private void frmUngDung_Load(object sender, EventArgs e)
        {
            FileStream fs2 = new FileStream("rules.txt", FileMode.Open);//LOAD TẬP LUẬT LƯU TRỮ TRONG FILE TEXT BIN\DEBUG\rules.txt
            StreamReader sr2 = new StreamReader(fs2);
            string line = "";
            while ((line = sr2.ReadLine()) != null)
            {
                listBox1.Items.Add(line.Trim());//ĐỌC DỮ LIỆU LÊN LISTBOX
            }
            sr2.Close();//ĐÓNG FILE TEXT
            fs2.Close();
        }

        private void BTTHUCHIEN_Click(object sender, EventArgs e)
        {
            FileStream fs2 = new FileStream("rules.txt", FileMode.Open);//ĐỌC FILE TEXT
            StreamReader sr2 = new StreamReader(fs2);
            string[] mang_rule = new string[50];
            string line = "";
            int dem = 0;
            bool kt = false;
            DataTable dt = (DataTable)dataGridView1.DataSource;//ĐỌC DỮ LIỆU TEST
            if(dt!=null)
                dt.Columns.Add("Ketqua", typeof(string));
            else
            {
                dt = new DataTable();
                dt.Columns.Add("CHISOXNK", typeof(string));
                dt.Columns.Add("DAUTU", typeof(string));
                dt.Columns.Add("CHITIEUCONG", typeof(string));
                dt.Columns.Add("DULICH", typeof(string));
                dt.Columns.Add("DICHVU", typeof(string));
                dt.Columns.Add("Ketqua", typeof(string));
                string CHISOXNK = "dương";
                if (rdam.Checked)
                    CHISOXNK = "âm";
                else if(rdCanbang.Checked)
                    CHISOXNK = "cân băng";
                string DAUTU = "mở rộng";
                if(rdthuhep.Checked)
                    DAUTU = "thu hẹp";
                string CHITIEUCONG = "tăng";
                if(rdgiam.Checked)
                    CHITIEUCONG = "giảm";
                string DULICH = "phát triển";
                if(rdondinh.Checked)
                    DULICH = "ổn định";
                else if(rdkempt.Checked)
                    DULICH = "kém pt";
                string DICHVU = "nâng cao";
                if(rddambao.Checked)
                    DICHVU = "đảm bảo";
                else if(rdkem.Checked)
                    DICHVU = "kém";
                DataRow dr = dt.NewRow();
                dr["CHISOXNK"] = CHISOXNK;
                dr["DAUTU"] = DAUTU;
                dr["CHITIEUCONG"] = CHITIEUCONG;
                dr["DULICH"] = DULICH;
                dr["DICHVU"] = DICHVU;
                dt.Rows.Add(dr);
                kt = true;
            }

            while ((line = sr2.ReadLine()) != null)
            {
                mang_rule[dem] = line.Trim();
                dem++;
            }
            int dem_kq;
            for (int u = 0; u < dt.Rows.Count; u++)// XỬ LÝ TỪNG DÒNG DỮ LIỆU TRONG DATAGRIDVIEW
            {
                for (int i = 0; i < dem; i++)
                {
                    string[] mang = mang_rule[i].Split('-');
                    dem_kq = 0;
                    for (int j = 0; j < mang.Length - 1; j += 2)
                    {
                        //dem_kq = 0;
                        for (int k = 0; k < dt.Columns.Count; k++)//QUÁ TRÌNH XỨ LÝ CẮT ĐÔI TẬP LUẬT
                        {
                            string giatri = dt.Rows[u][k].ToString().Trim();
                           
                            if (dt.Columns[k].ColumnName.Trim().ToLower() == mang[j].ToLower() && mang[j + 1].Trim().ToLower() == giatri.ToLower())
                            {

                                dem_kq++;
                                k = dt.Columns.Count;
                            }

                        }
                    if (dem_kq == (mang.Length - 1) / 2)//SO SÁNH TRÙNG KHỚP THÌ CẬP NHẬT LẠI DATAGRIDVIEW
                    {
                        dt.Rows[u]["Ketqua"] = mang[mang.Length - 1];//LƯU KẾT QUẢ
                        i = dem;
                    }
                    else
                            dt.Rows[u]["Ketqua"] = mang[mang.Length - 1];

                    }
                    
                }
              
            }
            sr2.Close();
            fs2.Close();
            if (kt)
                lbkq.Text = dt.Rows[0]["Ketqua"].ToString();
            LBTHONGBAO.Text = "KẾT QUẢ THỰC HIỆN";
        }
    }
}
