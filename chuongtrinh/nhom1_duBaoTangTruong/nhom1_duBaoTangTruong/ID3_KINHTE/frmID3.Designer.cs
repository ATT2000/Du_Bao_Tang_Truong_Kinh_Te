namespace ID3_BANKING
{
    partial class frmID3
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
            this.lbkt = new System.Windows.Forms.Label();
            this.rtbRules = new System.Windows.Forms.RichTextBox();
            this.lbthongbao = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTID3 = new System.Windows.Forms.Button();
            this.BTKHOITAO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rTBphanlop = new System.Windows.Forms.RichTextBox();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbkt
            // 
            this.lbkt.AutoSize = true;
            this.lbkt.Location = new System.Drawing.Point(43, 88);
            this.lbkt.Name = "lbkt";
            this.lbkt.Size = new System.Drawing.Size(0, 20);
            this.lbkt.TabIndex = 28;
            this.lbkt.Visible = false;
            // 
            // rtbRules
            // 
            this.rtbRules.Location = new System.Drawing.Point(5, 335);
            this.rtbRules.Name = "rtbRules";
            this.rtbRules.ReadOnly = true;
            this.rtbRules.Size = new System.Drawing.Size(721, 289);
            this.rtbRules.TabIndex = 26;
            this.rtbRules.Text = "";
            this.rtbRules.WordWrap = false;
            // 
            // lbthongbao
            // 
            this.lbthongbao.AutoSize = true;
            this.lbthongbao.Location = new System.Drawing.Point(856, 37);
            this.lbthongbao.Name = "lbthongbao";
            this.lbthongbao.Size = new System.Drawing.Size(0, 20);
            this.lbthongbao.TabIndex = 23;
            this.lbthongbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1265, 223);
            this.dataGridView1.TabIndex = 22;
            // 
            // BTID3
            // 
            this.BTID3.Location = new System.Drawing.Point(236, 56);
            this.BTID3.Name = "BTID3";
            this.BTID3.Size = new System.Drawing.Size(195, 31);
            this.BTID3.TabIndex = 20;
            this.BTID3.Text = "SINH LUẬT VỚI ID3";
            this.BTID3.UseVisualStyleBackColor = true;
            this.BTID3.Click += new System.EventHandler(this.BTID3_Click);
            // 
            // BTKHOITAO
            // 
            this.BTKHOITAO.Location = new System.Drawing.Point(18, 56);
            this.BTKHOITAO.Name = "BTKHOITAO";
            this.BTKHOITAO.Size = new System.Drawing.Size(195, 31);
            this.BTKHOITAO.TabIndex = 21;
            this.BTKHOITAO.Text = "KHỞI TẠO DỮ LIỆU";
            this.BTKHOITAO.UseVisualStyleBackColor = true;
            this.BTKHOITAO.Click += new System.EventHandler(this.BTKHOITAO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(385, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "SINH LUẬT VỚI THUẬT TOÁN ID3";
            // 
            // rTBphanlop
            // 
            this.rTBphanlop.Location = new System.Drawing.Point(732, 335);
            this.rTBphanlop.Name = "rTBphanlop";
            this.rTBphanlop.ReadOnly = true;
            this.rTBphanlop.Size = new System.Drawing.Size(538, 289);
            this.rTBphanlop.TabIndex = 27;
            this.rTBphanlop.Text = "";
            this.rTBphanlop.Visible = false;
            this.rTBphanlop.WordWrap = false;
            // 
            // panelDrawing
            // 
            this.panelDrawing.Location = new System.Drawing.Point(5, 630);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(461, 40);
            this.panelDrawing.TabIndex = 24;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(515, 630);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(455, 40);
            this.rtbDescription.TabIndex = 25;
            this.rtbDescription.Text = "";
            this.rtbDescription.Visible = false;
            // 
            // frmID3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 695);
            this.Controls.Add(this.lbkt);
            this.Controls.Add(this.rTBphanlop);
            this.Controls.Add(this.rtbRules);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.lbthongbao);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTID3);
            this.Controls.Add(this.BTKHOITAO);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmID3";
            this.Text = "CAY QUYET DINH ID3";
            this.Load += new System.EventHandler(this.frmID3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbkt;
        private System.Windows.Forms.RichTextBox rtbRules;
        private System.Windows.Forms.Label lbthongbao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTID3;
        private System.Windows.Forms.Button BTKHOITAO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTBphanlop;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.RichTextBox rtbDescription;
    }
}