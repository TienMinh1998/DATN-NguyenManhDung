
namespace MyProject
{
    partial class Frm_chieunghi
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
            this.btn_tinhtoan = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_moment = new System.Windows.Forms.TextBox();
            this.txt_tongtaitrong = new System.Windows.Forms.TextBox();
            this.txt_hoattai = new System.Windows.Forms.TextBox();
            this.txt_tongtinhtai = new System.Windows.Forms.TextBox();
            this.txt_Ts = new System.Windows.Forms.TextBox();
            this.txt_L4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_L3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label28 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dong = new Guna.UI2.WinForms.Guna2Button();
            this.btn_loadExcel = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_as = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tinhtoan
            // 
            this.btn_tinhtoan.BorderRadius = 3;
            this.btn_tinhtoan.CheckedState.Parent = this.btn_tinhtoan;
            this.btn_tinhtoan.CustomImages.Parent = this.btn_tinhtoan;
            this.btn_tinhtoan.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_tinhtoan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_tinhtoan.ForeColor = System.Drawing.Color.White;
            this.btn_tinhtoan.HoverState.Parent = this.btn_tinhtoan;
            this.btn_tinhtoan.Location = new System.Drawing.Point(1018, 528);
            this.btn_tinhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tinhtoan.Name = "btn_tinhtoan";
            this.btn_tinhtoan.ShadowDecoration.Parent = this.btn_tinhtoan;
            this.btn_tinhtoan.Size = new System.Drawing.Size(124, 34);
            this.btn_tinhtoan.TabIndex = 14;
            this.btn_tinhtoan.Text = "Tính toán";
            this.btn_tinhtoan.Click += new System.EventHandler(this.btn_tinhtoan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_as);
            this.groupBox1.Controls.Add(this.txt_moment);
            this.groupBox1.Controls.Add(this.txt_tongtaitrong);
            this.groupBox1.Controls.Add(this.txt_hoattai);
            this.groupBox1.Controls.Add(this.txt_tongtinhtai);
            this.groupBox1.Controls.Add(this.txt_Ts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_L4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_L3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 427);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            this.dgv_data.AllowUserToDeleteRows = false;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_data.Location = new System.Drawing.Point(516, 106);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.ReadOnly = true;
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.RowTemplate.Height = 24;
            this.dgv_data.Size = new System.Drawing.Size(737, 415);
            this.dgv_data.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Các lớp cấu tạo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Chiều dày";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "y";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hệ số vượt tải";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tải trọng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // txt_moment
            // 
            this.txt_moment.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_moment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_moment.Location = new System.Drawing.Point(297, 336);
            this.txt_moment.Name = "txt_moment";
            this.txt_moment.ReadOnly = true;
            this.txt_moment.Size = new System.Drawing.Size(187, 29);
            this.txt_moment.TabIndex = 7;
            this.txt_moment.Text = "0";
            // 
            // txt_tongtaitrong
            // 
            this.txt_tongtaitrong.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtaitrong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_tongtaitrong.Location = new System.Drawing.Point(297, 289);
            this.txt_tongtaitrong.Name = "txt_tongtaitrong";
            this.txt_tongtaitrong.ReadOnly = true;
            this.txt_tongtaitrong.Size = new System.Drawing.Size(187, 29);
            this.txt_tongtaitrong.TabIndex = 7;
            this.txt_tongtaitrong.Text = "0";
            // 
            // txt_hoattai
            // 
            this.txt_hoattai.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoattai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_hoattai.Location = new System.Drawing.Point(297, 239);
            this.txt_hoattai.Name = "txt_hoattai";
            this.txt_hoattai.ReadOnly = true;
            this.txt_hoattai.Size = new System.Drawing.Size(187, 29);
            this.txt_hoattai.TabIndex = 7;
            this.txt_hoattai.Text = "0";
            // 
            // txt_tongtinhtai
            // 
            this.txt_tongtinhtai.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtinhtai.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_tongtinhtai.Location = new System.Drawing.Point(297, 188);
            this.txt_tongtinhtai.Name = "txt_tongtinhtai";
            this.txt_tongtinhtai.ReadOnly = true;
            this.txt_tongtinhtai.Size = new System.Drawing.Size(187, 29);
            this.txt_tongtinhtai.TabIndex = 7;
            this.txt_tongtinhtai.Text = "0";
            // 
            // txt_Ts
            // 
            this.txt_Ts.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_Ts.Location = new System.Drawing.Point(297, 141);
            this.txt_Ts.Name = "txt_Ts";
            this.txt_Ts.ReadOnly = true;
            this.txt_Ts.Size = new System.Drawing.Size(187, 29);
            this.txt_Ts.TabIndex = 7;
            this.txt_Ts.Text = "0";
            // 
            // txt_L4
            // 
            this.txt_L4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_L4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_L4.Location = new System.Drawing.Point(297, 92);
            this.txt_L4.Name = "txt_L4";
            this.txt_L4.ReadOnly = true;
            this.txt_L4.Size = new System.Drawing.Size(187, 29);
            this.txt_L4.TabIndex = 7;
            this.txt_L4.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Moment ";
            // 
            // txt_L3
            // 
            this.txt_L3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_L3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_L3.Location = new System.Drawing.Point(297, 44);
            this.txt_L3.Name = "txt_L3";
            this.txt_L3.ReadOnly = true;
            this.txt_L3.Size = new System.Drawing.Size(187, 29);
            this.txt_L3.TabIndex = 6;
            this.txt_L3.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tổng tải trọng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "L4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hoạt tải tính toán : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "L3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng tĩnh tải";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tỉ số L4 / L3 : ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.LightCyan;
            this.label28.Location = new System.Drawing.Point(470, 19);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(410, 36);
            this.label28.TabIndex = 6;
            this.label28.Text = "TÍNH TOÁN BẢN CHIẾU NGHỈ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 70);
            this.panel1.TabIndex = 14;
            // 
            // btn_dong
            // 
            this.btn_dong.BorderRadius = 3;
            this.btn_dong.CheckedState.Parent = this.btn_dong;
            this.btn_dong.CustomImages.Parent = this.btn_dong;
            this.btn_dong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_dong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_dong.ForeColor = System.Drawing.Color.White;
            this.btn_dong.HoverState.Parent = this.btn_dong;
            this.btn_dong.Location = new System.Drawing.Point(1150, 528);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.ShadowDecoration.Parent = this.btn_dong;
            this.btn_dong.Size = new System.Drawing.Size(103, 34);
            this.btn_dong.TabIndex = 14;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_loadExcel
            // 
            this.btn_loadExcel.BorderRadius = 3;
            this.btn_loadExcel.CheckedState.Parent = this.btn_loadExcel;
            this.btn_loadExcel.CustomImages.Parent = this.btn_loadExcel;
            this.btn_loadExcel.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_loadExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_loadExcel.ForeColor = System.Drawing.Color.White;
            this.btn_loadExcel.HoverState.Parent = this.btn_loadExcel;
            this.btn_loadExcel.Location = new System.Drawing.Point(858, 528);
            this.btn_loadExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_loadExcel.Name = "btn_loadExcel";
            this.btn_loadExcel.ShadowDecoration.Parent = this.btn_loadExcel;
            this.btn_loadExcel.Size = new System.Drawing.Size(152, 34);
            this.btn_loadExcel.TabIndex = 14;
            this.btn_loadExcel.Text = "Load dữ liệu";
            this.btn_loadExcel.Click += new System.EventHandler(this.btn_loadExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Phần mềm thiết kế và tính toán thang - DHXD version 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyProject.Properties.Resources._1200px_LOGO_DHXD;
            this.pictureBox1.Location = new System.Drawing.Point(420, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Diện tích cốt thép";
            // 
            // txt_as
            // 
            this.txt_as.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_as.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_as.Location = new System.Drawing.Point(297, 379);
            this.txt_as.Name = "txt_as";
            this.txt_as.ReadOnly = true;
            this.txt_as.Size = new System.Drawing.Size(187, 29);
            this.txt_as.TabIndex = 7;
            this.txt_as.Text = "0";
            // 
            // Frm_chieunghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_loadExcel);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_tinhtoan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_chieunghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tính toán bản chiếu nghỉ version 1.0";
            this.Load += new System.EventHandler(this.Frm_chieunghi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_tinhtoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_moment;
        private System.Windows.Forms.TextBox txt_tongtaitrong;
        private System.Windows.Forms.TextBox txt_hoattai;
        private System.Windows.Forms.TextBox txt_tongtinhtai;
        private System.Windows.Forms.TextBox txt_Ts;
        private System.Windows.Forms.TextBox txt_L4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_L3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_dong;
        private Guna.UI2.WinForms.Guna2Button btn_loadExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_as;
        private System.Windows.Forms.Label label1;
    }
}