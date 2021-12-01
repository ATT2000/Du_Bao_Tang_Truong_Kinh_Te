using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
namespace ID3_BANKING
{
    public partial class frmLamSachData : Form
    {
        public frmLamSachData()
        {
            InitializeComponent();
        }
        DataSet ds;
        private void frmLamSachData_Load(object sender, EventArgs e)
        {
            ds = new System.Data.DataSet();
            ds.ReadXmlSchema("Schema_Banking.xml");
            ds.ReadXml("Data_Banking.xml");

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BTLamsach_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu trùng
            int demtrung = 0;
            int demmauthuan = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count - 1; i++)
            {
                if (ds.Tables[0].Rows[i].RowState != DataRowState.Deleted)
                    for (int j = i + 1; j < ds.Tables[0].Rows.Count - 1; j++)
                    {
                        if (ds.Tables[0].Rows[j].RowState != DataRowState.Deleted)
                            if (Kiemtra_dulieu_trung(ds.Tables[0].Rows[i], ds.Tables[0].Rows[j]))
                            {
                                demtrung++;

                                ds.Tables[0].Rows[j].Delete();//XÓA DỮ LIỆU TRÙNG

                            }
                    }
            }
            ds.Tables[0].AcceptChanges();
           //KIEM TRA DỮ LIỆU MÂU THUẪN
            for (int i = 0; i < ds.Tables[0].Rows.Count - 1; i++)
            {
                if (ds.Tables[0].Rows[i].RowState != DataRowState.Deleted)
                for (int j = i + 1; j < ds.Tables[0].Rows.Count - 1; j++)
                {
                    if (ds.Tables[0].Rows[j].RowState != DataRowState.Deleted)
                        if (Kiemtra_du_mau_thuan(ds.Tables[0].Rows[i], ds.Tables[0].Rows[j]))
                        {
                            demmauthuan++;

                            ds.Tables[0].Rows[j].Delete();//XÓA DỮ LIỆU MÂU THUẪN

                        }
                }
            }
            ds.Tables[0].AcceptChanges();
            dataGridView1.DataSource = ds.Tables[0];//LOAD DỮ LIỆU LẠI DATAGRIDVIEW
            
            MessageBox.Show("Đã chuẩn hóa dữ liệu");
            lbthongbao.Text = "Tổng dữ liệu: " + ds.Tables[0].Rows.Count;
        }
       
        private bool Kiemtra_du_mau_thuan(DataRow dr1, DataRow dr2)
        {
            //HÀM KIỂM TRA 2 DÒNG CÓ MÂU THUẪN KHÔNG ? NẾU CÓ TRẢ VỀ TRUE NGUOC LAI FLASE
            int dem = 0;
            for (int i = 0; i < dr1.ItemArray.Count()-1; i++)
                if (dr1[i].ToString().Trim() == dr2[i].ToString().Trim())
                {
                    dem++;
                }
            if (dem == dr1.ItemArray.Count() - 1 && dr1[dr1.ItemArray.Count() - 1].ToString().Trim() != dr2[dr1.ItemArray.Count() - 1].ToString().Trim())
                return true;
            return false;
        }
        private bool Kiemtra_dulieu_trung(DataRow dr1, DataRow dr2)
        {
            //HÀM KIỂM TRA 2 DÒNG CÓ MÂU THUẪN KHÔNG ? NẾU CÓ TRẢ VỀ TRUE NGUOC LAI FLASE
            int dem = 0;
            for (int i = 0; i < dr1.ItemArray.Count() - 1; i++)
                if (dr1[i].ToString().Trim() == dr2[i].ToString().Trim())
                {
                    dem++;
                }
            if (dem == dr1.ItemArray.Count()-1)
                return true;
            return false;
        }
        private void BTCapNhat_Click(object sender, EventArgs e)
        {
            //LƯU DỮ LIỆU SAU KHI ĐÃ ĐIỀU CHỈNH
            ds.WriteXmlSchema("Schema_Banking.xml");
            ds.WriteXml("Data_Banking.xml");
            MessageBox.Show("Đã lưu dữ liệu");
            ds = new DataSet();
            ds.ReadXmlSchema("Schema_Banking.xml");
            ds.ReadXml("Data_Banking.xml");
        }
    }
}
