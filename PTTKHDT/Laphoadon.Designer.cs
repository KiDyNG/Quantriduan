namespace PTTKHDT
{
    partial class Laphoadon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_lammoihd = new System.Windows.Forms.Button();
            this.btn_taohd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.txt_ngaylap = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_maxe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_laphoadon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_xuathd_hd = new System.Windows.Forms.Button();
            this.btn_thoatlaphd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_laphoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_lammoihd);
            this.groupBox1.Controls.Add(this.btn_taohd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.txt_mahd);
            this.groupBox1.Controls.Add(this.txt_thanhtien);
            this.groupBox1.Controls.Add(this.txt_ngaylap);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Controls.Add(this.txt_maxe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_lammoihd
            // 
            this.btn_lammoihd.BackColor = System.Drawing.Color.Blue;
            this.btn_lammoihd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoihd.ForeColor = System.Drawing.Color.White;
            this.btn_lammoihd.Location = new System.Drawing.Point(883, 161);
            this.btn_lammoihd.Name = "btn_lammoihd";
            this.btn_lammoihd.Size = new System.Drawing.Size(129, 64);
            this.btn_lammoihd.TabIndex = 7;
            this.btn_lammoihd.Text = "Làm mới";
            this.btn_lammoihd.UseVisualStyleBackColor = false;
            this.btn_lammoihd.Click += new System.EventHandler(this.btn_lammoihd_Click);
            // 
            // btn_taohd
            // 
            this.btn_taohd.BackColor = System.Drawing.Color.Blue;
            this.btn_taohd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taohd.ForeColor = System.Drawing.Color.White;
            this.btn_taohd.Location = new System.Drawing.Point(883, 30);
            this.btn_taohd.Name = "btn_taohd";
            this.btn_taohd.Size = new System.Drawing.Size(129, 75);
            this.btn_taohd.TabIndex = 6;
            this.btn_taohd.Text = "Tạo hóa đơn";
            this.btn_taohd.UseVisualStyleBackColor = false;
            this.btn_taohd.Click += new System.EventHandler(this.btn_taohd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(457, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(457, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thành tiền";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(585, 30);
            this.txt_soluong.Multiline = true;
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(271, 31);
            this.txt_soluong.TabIndex = 3;
            // 
            // txt_mahd
            // 
            this.txt_mahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahd.Location = new System.Drawing.Point(166, 32);
            this.txt_mahd.Multiline = true;
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(271, 31);
            this.txt_mahd.TabIndex = 0;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanhtien.Location = new System.Drawing.Point(585, 111);
            this.txt_thanhtien.Multiline = true;
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(271, 31);
            this.txt_thanhtien.TabIndex = 4;
            // 
            // txt_ngaylap
            // 
            this.txt_ngaylap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaylap.Location = new System.Drawing.Point(585, 194);
            this.txt_ngaylap.Multiline = true;
            this.txt_ngaylap.Name = "txt_ngaylap";
            this.txt_ngaylap.Size = new System.Drawing.Size(271, 31);
            this.txt_ngaylap.TabIndex = 5;
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Location = new System.Drawing.Point(166, 113);
            this.txt_makh.Multiline = true;
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(271, 31);
            this.txt_makh.TabIndex = 1;
            // 
            // txt_maxe
            // 
            this.txt_maxe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maxe.Location = new System.Drawing.Point(166, 194);
            this.txt_maxe.Multiline = true;
            this.txt_maxe.Name = "txt_maxe";
            this.txt_maxe.Size = new System.Drawing.Size(271, 31);
            this.txt_maxe.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(457, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // gv_laphoadon
            // 
            this.gv_laphoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_laphoadon.Location = new System.Drawing.Point(12, 301);
            this.gv_laphoadon.Name = "gv_laphoadon";
            this.gv_laphoadon.RowHeadersWidth = 51;
            this.gv_laphoadon.RowTemplate.Height = 24;
            this.gv_laphoadon.Size = new System.Drawing.Size(882, 201);
            this.gv_laphoadon.TabIndex = 1;
            this.gv_laphoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_laphoadon_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(357, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "HÓA ĐƠN";
            // 
            // btn_xuathd_hd
            // 
            this.btn_xuathd_hd.BackColor = System.Drawing.Color.Lime;
            this.btn_xuathd_hd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuathd_hd.ForeColor = System.Drawing.Color.White;
            this.btn_xuathd_hd.Location = new System.Drawing.Point(12, 521);
            this.btn_xuathd_hd.Name = "btn_xuathd_hd";
            this.btn_xuathd_hd.Size = new System.Drawing.Size(156, 46);
            this.btn_xuathd_hd.TabIndex = 3;
            this.btn_xuathd_hd.Text = "Xuất hóa đơn";
            this.btn_xuathd_hd.UseVisualStyleBackColor = false;
            this.btn_xuathd_hd.Click += new System.EventHandler(this.btn_xuathd_hd_Click);
            // 
            // btn_thoatlaphd
            // 
            this.btn_thoatlaphd.BackColor = System.Drawing.Color.Red;
            this.btn_thoatlaphd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoatlaphd.ForeColor = System.Drawing.Color.White;
            this.btn_thoatlaphd.Location = new System.Drawing.Point(900, 521);
            this.btn_thoatlaphd.Name = "btn_thoatlaphd";
            this.btn_thoatlaphd.Size = new System.Drawing.Size(130, 46);
            this.btn_thoatlaphd.TabIndex = 3;
            this.btn_thoatlaphd.Text = "Thoát";
            this.btn_thoatlaphd.UseVisualStyleBackColor = false;
            this.btn_thoatlaphd.Click += new System.EventHandler(this.btn_thoatlaphd_Click);
            // 
            // Laphoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1044, 583);
            this.Controls.Add(this.btn_thoatlaphd);
            this.Controls.Add(this.btn_xuathd_hd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gv_laphoadon);
            this.Controls.Add(this.groupBox1);
            this.Name = "Laphoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.Laphoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_laphoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gv_laphoadon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_lammoihd;
        private System.Windows.Forms.Button btn_taohd;
        private System.Windows.Forms.Button btn_xuathd_hd;
        private System.Windows.Forms.Button btn_thoatlaphd;
        private System.Windows.Forms.TextBox txt_maxe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TextBox txt_ngaylap;
        private System.Windows.Forms.TextBox txt_makh;
    }
}