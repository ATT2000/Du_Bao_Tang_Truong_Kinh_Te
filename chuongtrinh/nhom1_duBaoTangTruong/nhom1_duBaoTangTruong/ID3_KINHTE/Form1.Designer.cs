namespace ID3_BANKING
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MENUIMPORTDATA = new System.Windows.Forms.ToolStripMenuItem();
            this.MENUCHUANHOA = new System.Windows.Forms.ToolStripMenuItem();
            this.MENUSINHLUATVOIID3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MENUUNGDUNG = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENUIMPORTDATA,
            this.MENUCHUANHOA,
            this.MENUSINHLUATVOIID3,
            this.MENUUNGDUNG});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "ỨNG DỤNG";
            // 
            // MENUIMPORTDATA
            // 
            this.MENUIMPORTDATA.Name = "MENUIMPORTDATA";
            this.MENUIMPORTDATA.Size = new System.Drawing.Size(150, 24);
            this.MENUIMPORTDATA.Text = "KHỎI TẠO DỮ LIỆU";
            this.MENUIMPORTDATA.Click += new System.EventHandler(this.MENUIMPORTDATA_Click);
            // 
            // MENUCHUANHOA
            // 
            this.MENUCHUANHOA.Name = "MENUCHUANHOA";
            this.MENUCHUANHOA.Size = new System.Drawing.Size(169, 24);
            this.MENUCHUANHOA.Text = "CHUẨN HÓA DỮ LIỆU";
            this.MENUCHUANHOA.Click += new System.EventHandler(this.MENUCHUANHOA_Click);
            // 
            // MENUSINHLUATVOIID3
            // 
            this.MENUSINHLUATVOIID3.Name = "MENUSINHLUATVOIID3";
            this.MENUSINHLUATVOIID3.Size = new System.Drawing.Size(151, 24);
            this.MENUSINHLUATVOIID3.Text = "SINH LUẬT VỚI ID3";
            this.MENUSINHLUATVOIID3.Click += new System.EventHandler(this.MENUSINHLUATVOIID3_Click);
            // 
            // MENUUNGDUNG
            // 
            this.MENUUNGDUNG.Name = "MENUUNGDUNG";
            this.MENUUNGDUNG.Size = new System.Drawing.Size(101, 24);
            this.MENUUNGDUNG.Text = "ỨNG DUNG";
            this.MENUUNGDUNG.Click += new System.EventHandler(this.MENUUNGDUNG_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1213, 649);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MENUIMPORTDATA;
        private System.Windows.Forms.ToolStripMenuItem MENUCHUANHOA;
        private System.Windows.Forms.ToolStripMenuItem MENUSINHLUATVOIID3;
        private System.Windows.Forms.ToolStripMenuItem MENUUNGDUNG;
        private System.Windows.Forms.Label label1;
    }
}

