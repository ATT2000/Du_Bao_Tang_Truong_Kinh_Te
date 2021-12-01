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
    public partial class wfimport_data : Form
    {
        public wfimport_data()
        {
            InitializeComponent();
        }
        private DataSet ds;
        private void wfimport_data_Load(object sender, EventArgs e)
        {

        }

        private void BTChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();//MỞ FILE EXCEL
            dlg.Filter = "Excel Files (.xls)|*.*";
            OleDbConnection conn;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
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
                
                OleDbCommand cmd;
                OleDbDataAdapter da = new OleDbDataAdapter();
                ds = new DataSet();//LƯU DỮ LIỆU TỪ EXCEL VÀO DATASET
                string query = "";
               
                    query = "SELECT * FROM [Sheet1$]";
              

                if (conn.State == ConnectionState.Closed) conn.Open();//CẬP NHẬT VÀO FILE
                try
                {
                    cmd = new OleDbCommand(query, conn);
                    da = new OleDbDataAdapter(cmd);
                    da.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
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
        private int tong_so_thuoc_tinh()
        {
            int tong = 0;
            int dem = 0;
            for (int j = 0; j < ds.Tables[0].Columns.Count-1; j++)
            {
                string[] mang = new string[15];
                tong++;
                dem = 0;
                for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                {

                    if (ds.Tables[0].Rows[0][j].ToString().Trim() != ds.Tables[0].Rows[i][j].ToString().Trim() && !kiem_tra(mang,ds.Tables[0].Rows[i][j].ToString()) && mang.Length>0)
                    {
                        tong++;
                        mang[dem] = ds.Tables[0].Rows[i][j].ToString();
                        dem++;
                    }

                }
            }

            return tong;
        }
        private bool kiem_tra(string [] mang, string gt)
        {
            for( int i=0;i<mang.Length;i++)
            {
                if(mang[i]==gt)
                    return true;
            }
            return false;
        }
        private void BTImportData_Click(object sender, EventArgs e)
        {
            
            

        }

        private void BTXOA_Click(object sender, EventArgs e)
        {
            //HÀM XÓA FILE DỮ LIỆU
            File.Delete("Schema_Banking.xml");
            File.Delete("Data_Banking.xml");
            MessageBox.Show("Đã xóa dữ liệu thành công");
        }

        private void txtpath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTCapNhat_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            class_Ham_Xay_Dung cls = new class_Ham_Xay_Dung();
            for (int i = 0; i < dt.Columns.Count;i++ )
            {
                dt.Columns[i].ColumnName = dt.Columns[i].ColumnName.Trim().Replace(' ', '_');
                dt.Columns[i].ColumnName =cls.RemoveUnicode(dt.Columns[i].ColumnName.Trim()).Replace("__","_");
               
            }
                //HÀM LƯU DỮ LIỆU
            dt.TableName = "Banking";
                dt.WriteXmlSchema("Schema_Banking.xml");
            dt.WriteXml("Data_Banking.xml");
            
            ds = new DataSet();
            ds.ReadXmlSchema("Schema_Banking.xml");
            ds.ReadXml("Data_Banking.xml");
            //LOAD DỮ LIỆU LÊN DATAGRIDVIEW
            dataGridView1.DataSource = ds.Tables[0];
            lbtongdl.Text = "Tổng số dữ liệu: " + ds.Tables[0].Rows.Count;
            lbtongsocot.Text = "Tổng số cột: " + ds.Tables[0].Columns.Count;
            lbtongbienphuthuoc.Text = "Tổng số biến phụ thuộc: " + tong_so_thuoc_tinh();
        }
    }
}
