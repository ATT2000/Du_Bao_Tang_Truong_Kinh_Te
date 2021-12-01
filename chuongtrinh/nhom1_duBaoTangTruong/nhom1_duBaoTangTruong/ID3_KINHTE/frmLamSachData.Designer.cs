namespace ID3_BANKING
{
    partial class frmLamSachData
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
            this.BTLamsach = new System.Windows.Forms.Button();
            this.BTCapNhat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbthongbao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(462, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUẨN HÓA DỮ LIỆU";
            // 
            // BTLamsach
            // 
            this.BTLamsach.Location = new System.Drawing.Point(98, 54);
            this.BTLamsach.Name = "BTLamsach";
            this.BTLamsach.Size = new System.Drawing.Size(246, 35);
            this.BTLamsach.TabIndex = 1;
            this.BTLamsach.Text = "Thực hiện chuẩn hóa dữ liệu";
            this.BTLamsach.UseVisualStyleBackColor = true;
            this.BTLamsach.Click += new System.EventHandler(this.BTLamsach_Click);
            // 
            // BTCapNhat
            // 
            this.BTCapNhat.Location = new System.Drawing.Point(350, 54);
            this.BTCapNhat.Name = "BTCapNhat";
            this.BTCapNhat.Size = new System.Drawing.Size(219, 35);
            this.BTCapNhat.TabIndex = 1;
            this.BTCapNhat.Text = "Cập nhật dữ liệu";
            this.BTCapNhat.UseVisualStyleBackColor = true;
            this.BTCapNhat.Click += new System.EventHandler(this.BTCapNhat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 482);
            this.dataGridView1.TabIndex = 2;
            // 
            // lbthongbao
            // 
            this.lbthongbao.AutoSize = true;
            this.lbthongbao.ForeColor = System.Drawing.Color.Red;
            this.lbthongbao.Location = new System.Drawing.Point(640, 84);
            this.lbthongbao.Name = "lbthongbao";
            this.lbthongbao.Size = new System.Drawing.Size(0, 20);
            this.lbthongbao.TabIndex = 3;
            // 
            // frmLamSachData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 598);
            this.Controls.Add(this.lbthongbao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTCapNhat);
            this.Controls.Add(this.BTLamsach);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLamSachData";
            this.Text = "DIEU CHINH DU LIEU";
            this.Load += new System.EventHandler(this.frmLamSachData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTLamsach;
        private System.Windows.Forms.Button BTCapNhat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbthongbao;
    }
}