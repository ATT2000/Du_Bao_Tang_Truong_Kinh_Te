using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ID3_BANKING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MENUIMPORTDATA_Click(object sender, EventArgs e)
        {
           wfimport_data frm = new wfimport_data();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void MenuChuanhoaData_Click(object sender, EventArgs e)
        {
            frmLamSachData frm = new frmLamSachData();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void MenuID3_Click(object sender, EventArgs e)
        {
            frmID3 frm= new frmID3();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void MENUUNGDUNG_Click(object sender, EventArgs e)
        {
            
        }

        private void MENUCAY_Click(object sender, EventArgs e)
        {
            
        }

        private void MENUCHUANHOA_Click(object sender, EventArgs e)
        {
            frmLamSachData frm = new frmLamSachData();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void MENUSINHLUATVOIID3_Click(object sender, EventArgs e)
        {
            frmID3 frm = new frmID3();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MENUUNGDUNG_Click_1(object sender, EventArgs e)
        {
            frmUngDung frm = new frmUngDung();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
