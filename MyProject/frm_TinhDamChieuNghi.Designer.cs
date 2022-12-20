
namespace MyProject
{
    partial class frm_TinhDamChieuNghi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_dong = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_bdcn = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_bdcn = new System.Windows.Forms.TextBox();
            this.cbb_damchieunghi = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Hdcn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_moment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_tinhtoan = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cover = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_u = new System.Windows.Forms.TextBox();
            this.lb_thongbao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyProject.Properties.Resources._1200px_LOGO_DHXD;
            this.pictureBox1.Location = new System.Drawing.Point(14, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_dong
            // 
            this.btn_dong.BorderRadius = 5;
            this.btn_dong.CheckedState.Parent = this.btn_dong;
            this.btn_dong.CustomImages.Parent = this.btn_dong;
            this.btn_dong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_dong.ForeColor = System.Drawing.Color.White;
            this.btn_dong.HoverState.Parent = this.btn_dong;
            this.btn_dong.Location = new System.Drawing.Point(713, 385);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.ShadowDecoration.Parent = this.btn_dong;
            this.btn_dong.Size = new System.Drawing.Size(106, 38);
            this.btn_dong.TabIndex = 19;
            this.btn_dong.Text = "Lưu lại";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 54);
            this.panel1.TabIndex = 20;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(64, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(540, 36);
            this.label28.TabIndex = 6;
            this.label28.Text = "TÍNH TOÁN DẦM CHIẾU NGHỈ (DCN -2)";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Phần mềm thiết kế và tính toán thang - DHXD version 1.0";
            // 
            // cbb_bdcn
            // 
            this.cbb_bdcn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_bdcn.FormattingEnabled = true;
            this.cbb_bdcn.Items.AddRange(new object[] {
            "0.3 Hdcn",
            "0.4 Hdcn",
            "0.5 Hdcn"});
            this.cbb_bdcn.Location = new System.Drawing.Point(13, 136);
            this.cbb_bdcn.Name = "cbb_bdcn";
            this.cbb_bdcn.Size = new System.Drawing.Size(368, 29);
            this.cbb_bdcn.TabIndex = 3;
            this.cbb_bdcn.SelectedIndexChanged += new System.EventHandler(this.cbb_bdcn_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(309, 28);
            this.label17.TabIndex = 0;
            this.label17.Text = "Chọn chiều rộng dầm chiếu nghỉ : ";
            // 
            // txt_bdcn
            // 
            this.txt_bdcn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bdcn.Location = new System.Drawing.Point(159, 33);
            this.txt_bdcn.Name = "txt_bdcn";
            this.txt_bdcn.ReadOnly = true;
            this.txt_bdcn.Size = new System.Drawing.Size(166, 29);
            this.txt_bdcn.TabIndex = 1;
            this.txt_bdcn.Text = "0";
            // 
            // cbb_damchieunghi
            // 
            this.cbb_damchieunghi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_damchieunghi.FormattingEnabled = true;
            this.cbb_damchieunghi.Items.AddRange(new object[] {
            "(1/8) L",
            "(1/9) L",
            "(1/10) L",
            "(1/11) L",
            "(1/12) L"});
            this.cbb_damchieunghi.Location = new System.Drawing.Point(12, 56);
            this.cbb_damchieunghi.Name = "cbb_damchieunghi";
            this.cbb_damchieunghi.Size = new System.Drawing.Size(368, 29);
            this.cbb_damchieunghi.TabIndex = 3;
            this.cbb_damchieunghi.SelectedIndexChanged += new System.EventHandler(this.cbb_damchieunghi_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(356, 34);
            this.label13.TabIndex = 0;
            this.label13.Text = "Chọn chiều cao dầm chiếu nghỉ";
            // 
            // txt_Hdcn
            // 
            this.txt_Hdcn.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hdcn.Location = new System.Drawing.Point(161, 79);
            this.txt_Hdcn.Name = "txt_Hdcn";
            this.txt_Hdcn.ReadOnly = true;
            this.txt_Hdcn.Size = new System.Drawing.Size(164, 29);
            this.txt_Hdcn.TabIndex = 1;
            this.txt_Hdcn.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_cover);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbb_bdcn);
            this.groupBox1.Controls.Add(this.cbb_damchieunghi);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(13, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 309);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(341, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "mm";
            // 
            // txt_moment
            // 
            this.txt_moment.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_moment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_moment.Location = new System.Drawing.Point(161, 125);
            this.txt_moment.Name = "txt_moment";
            this.txt_moment.ReadOnly = true;
            this.txt_moment.Size = new System.Drawing.Size(164, 29);
            this.txt_moment.TabIndex = 23;
            this.txt_moment.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(11, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "III. Diện tích CT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lb_thongbao);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_Hdcn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_u);
            this.groupBox2.Controls.Add(this.txt_moment);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_bdcn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(419, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 299);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tính toán";
            // 
            // btn_tinhtoan
            // 
            this.btn_tinhtoan.BorderRadius = 5;
            this.btn_tinhtoan.CheckedState.Parent = this.btn_tinhtoan;
            this.btn_tinhtoan.CustomImages.Parent = this.btn_tinhtoan;
            this.btn_tinhtoan.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_tinhtoan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_tinhtoan.ForeColor = System.Drawing.Color.White;
            this.btn_tinhtoan.HoverState.Parent = this.btn_tinhtoan;
            this.btn_tinhtoan.Location = new System.Drawing.Point(594, 385);
            this.btn_tinhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tinhtoan.Name = "btn_tinhtoan";
            this.btn_tinhtoan.ShadowDecoration.Parent = this.btn_tinhtoan;
            this.btn_tinhtoan.Size = new System.Drawing.Size(111, 38);
            this.btn_tinhtoan.TabIndex = 19;
            this.btn_tinhtoan.Text = "Tính";
            this.btn_tinhtoan.Click += new System.EventHandler(this.btn_tinhtoan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(11, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "II. B-DCN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(11, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "I. H-DCN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(341, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "mm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(331, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "mm2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(337, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "mm";
            // 
            // txt_cover
            // 
            this.txt_cover.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cover.Location = new System.Drawing.Point(13, 247);
            this.txt_cover.Name = "txt_cover";
            this.txt_cover.Size = new System.Drawing.Size(318, 29);
            this.txt_cover.TabIndex = 5;
            this.txt_cover.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chọn lớp bảo vệ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Lớp bảo vệ chọn đơn vị mm 20,30,...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(11, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(290, 31);
            this.label11.TabIndex = 22;
            this.label11.Text = "IV. Hàm lượng % cốt thép";
            // 
            // txt_u
            // 
            this.txt_u.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_u.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_u.Location = new System.Drawing.Point(159, 206);
            this.txt_u.Name = "txt_u";
            this.txt_u.ReadOnly = true;
            this.txt_u.Size = new System.Drawing.Size(164, 29);
            this.txt_u.TabIndex = 23;
            this.txt_u.Text = "0";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongbao.ForeColor = System.Drawing.Color.Blue;
            this.lb_thongbao.Location = new System.Drawing.Point(12, 253);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(272, 25);
            this.lb_thongbao.TabIndex = 22;
            this.lb_thongbao.Text = "Hàm lượng cốt thép đảm bảo.";
            this.lb_thongbao.Visible = false;
            // 
            // frm_TinhDamChieuNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_tinhtoan);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_TinhDamChieuNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tính toán dầm chiếu nghỉ version 1.0 ";
            this.Load += new System.EventHandler(this.frm_TinhDamChieuNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_dong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_bdcn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_bdcn;
        private System.Windows.Forms.ComboBox cbb_damchieunghi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Hdcn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_moment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btn_tinhtoan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cover;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_u;
    }
}