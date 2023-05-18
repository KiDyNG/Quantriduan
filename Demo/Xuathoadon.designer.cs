namespace CNPM
{
    partial class Xuathoadon
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.bt_xuat = new System.Windows.Forms.Button();
            this.txt_ngaylap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenkhachhang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(-4, 239);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1134, 814);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.bt_quaylai);
            this.groupBox1.Controls.Add(this.bt_xuat);
            this.groupBox1.Controls.Add(this.txt_ngaylap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tenkhachhang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin hóa đơn xuất";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.BackColor = System.Drawing.Color.Red;
            this.bt_quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quaylai.Location = new System.Drawing.Point(275, 149);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(172, 42);
            this.bt_quaylai.TabIndex = 5;
            this.bt_quaylai.Text = "Thoát";
            this.bt_quaylai.UseVisualStyleBackColor = false;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click);
            // 
            // bt_xuat
            // 
            this.bt_xuat.BackColor = System.Drawing.Color.Lime;
            this.bt_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xuat.Location = new System.Drawing.Point(41, 149);
            this.bt_xuat.Name = "bt_xuat";
            this.bt_xuat.Size = new System.Drawing.Size(172, 42);
            this.bt_xuat.TabIndex = 4;
            this.bt_xuat.Text = "Xuất hóa đơn";
            this.bt_xuat.UseVisualStyleBackColor = false;
            this.bt_xuat.Click += new System.EventHandler(this.bt_xuat_Click);
            // 
            // txt_ngaylap
            // 
            this.txt_ngaylap.Location = new System.Drawing.Point(203, 89);
            this.txt_ngaylap.Multiline = true;
            this.txt_ngaylap.Name = "txt_ngaylap";
            this.txt_ngaylap.Size = new System.Drawing.Size(244, 30);
            this.txt_ngaylap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập :";
            // 
            // txt_tenkhachhang
            // 
            this.txt_tenkhachhang.Location = new System.Drawing.Point(203, 35);
            this.txt_tenkhachhang.Multiline = true;
            this.txt_tenkhachhang.Name = "txt_tenkhachhang";
            this.txt_tenkhachhang.Size = new System.Drawing.Size(349, 30);
            this.txt_tenkhachhang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng :";
            // 
            // Xuathoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1143, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Xuathoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.Xuathoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Button bt_xuat;
        private System.Windows.Forms.TextBox txt_ngaylap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenkhachhang;
        private System.Windows.Forms.Label label1;
    }
}