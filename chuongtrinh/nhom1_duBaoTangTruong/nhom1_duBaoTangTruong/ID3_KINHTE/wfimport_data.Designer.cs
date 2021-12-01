namespace ID3_BANKING
{
    partial class wfimport_data
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTChonFile = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtongdl = new System.Windows.Forms.Label();
            this.lbtongsocot = new System.Windows.Forms.Label();
            this.lbtongbienphuthuoc = new System.Windows.Forms.Label();
            this.BTCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỌC DỮ LIỆU TỪ FILE EXCEL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(87, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 492);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BTChonFile
            // 
            this.BTChonFile.Location = new System.Drawing.Point(809, 60);
            this.BTChonFile.Name = "BTChonFile";
            this.BTChonFile.Size = new System.Drawing.Size(75, 27);
            this.BTChonFile.TabIndex = 9;
            this.BTChonFile.Text = "Chọn File";
            this.BTChonFile.UseVisualStyleBackColor = true;
            this.BTChonFile.Click += new System.EventHandler(this.BTChonFile_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(305, 63);
            this.txtpath.Name = "txtpath";
            this.txtpath.ReadOnly = true;
            this.txtpath.Size = new System.Drawing.Size(498, 26);
            this.txtpath.TabIndex = 8;
            this.txtpath.TextChanged += new System.EventHandler(this.txtpath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Đường dẫn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbtongdl
            // 
            this.lbtongdl.AutoSize = true;
            this.lbtongdl.Location = new System.Drawing.Point(959, 593);
            this.lbtongdl.Name = "lbtongdl";
            this.lbtongdl.Size = new System.Drawing.Size(0, 20);
            this.lbtongdl.TabIndex = 11;
            // 
            // lbtongsocot
            // 
            this.lbtongsocot.AutoSize = true;
            this.lbtongsocot.Location = new System.Drawing.Point(959, 618);
            this.lbtongsocot.Name = "lbtongsocot";
            this.lbtongsocot.Size = new System.Drawing.Size(0, 20);
            this.lbtongsocot.TabIndex = 11;
            // 
            // lbtongbienphuthuoc
            // 
            this.lbtongbienphuthuoc.AutoSize = true;
            this.lbtongbienphuthuoc.Location = new System.Drawing.Point(959, 643);
            this.lbtongbienphuthuoc.Name = "lbtongbienphuthuoc";
            this.lbtongbienphuthuoc.Size = new System.Drawing.Size(0, 20);
            this.lbtongbienphuthuoc.TabIndex = 11;
            // 
            // BTCapNhat
            // 
            this.BTCapNhat.Location = new System.Drawing.Point(890, 60);
            this.BTCapNhat.Name = "BTCapNhat";
            this.BTCapNhat.Size = new System.Drawing.Size(157, 27);
            this.BTCapNhat.TabIndex = 9;
            this.BTCapNhat.Text = "Lưu dữ liệu";
            this.BTCapNhat.UseVisualStyleBackColor = true;
            this.BTCapNhat.Click += new System.EventHandler(this.BTCapNhat_Click);
            // 
            // wfimport_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 667);
            this.Controls.Add(this.lbtongbienphuthuoc);
            this.Controls.Add(this.lbtongsocot);
            this.Controls.Add(this.lbtongdl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTCapNhat);
            this.Controls.Add(this.BTChonFile);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "wfimport_data";
            this.Text = "IMPORT DATA";
            this.Load += new System.EventHandler(this.wfimport_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTChonFile;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtongdl;
        private System.Windows.Forms.Label lbtongsocot;
        private System.Windows.Forms.Label lbtongbienphuthuoc;
        private System.Windows.Forms.Button BTCapNhat;
    }
}