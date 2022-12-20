using DevExpress.XtraEditors;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace myproject
{
    partial class Taitrongtinhtoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taitrongtinhtoan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btn_load_excel = new System.Windows.Forms.Button();
            this.btn_luu_du_lieu = new System.Windows.Forms.Button();
            this.txt_moment = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Hb = new System.Windows.Forms.TextBox();
            this.txt_lb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tct_hb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_h = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_l3 = new System.Windows.Forms.TextBox();
            this.txt_l2 = new System.Windows.Forms.TextBox();
            this.txt_l1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_ht = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_tt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_Ltt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label28 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_simulator = new Guna.UI2.WinForms.Guna2Button();
            this.Cbb_tinhtoan = new System.Windows.Forms.ComboBox();
            this.btn_batdau = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.level3 = new System.Windows.Forms.Panel();
            this.level2 = new System.Windows.Forms.Panel();
            this.level1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_botrithep = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_q);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.btn_load_excel);
            this.groupBox1.Controls.Add(this.btn_luu_du_lieu);
            this.groupBox1.Controls.Add(this.txt_moment);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Hb);
            this.groupBox1.Controls.Add(this.txt_lb);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tct_hb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_h);
            this.groupBox1.Controls.Add(this.txt_c);
            this.groupBox1.Controls.Add(this.txt_l3);
            this.groupBox1.Controls.Add(this.txt_l2);
            this.groupBox1.Controls.Add(this.txt_l1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 772);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label27.Location = new System.Drawing.Point(399, 674);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 23);
            this.label27.TabIndex = 2;
            this.label27.Text = "KN";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(399, 595);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 23);
            this.label20.TabIndex = 2;
            this.label20.Text = "mm";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label26.Location = new System.Drawing.Point(386, 635);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 23);
            this.label26.TabIndex = 2;
            this.label26.Text = "KN.m";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(401, 514);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "mm";
            // 
            // txt_q
            // 
            this.txt_q.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_q.Location = new System.Drawing.Point(144, 671);
            this.txt_q.Name = "txt_q";
            this.txt_q.ReadOnly = true;
            this.txt_q.Size = new System.Drawing.Size(238, 29);
            this.txt_q.TabIndex = 1;
            this.txt_q.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Maroon;
            this.label25.Location = new System.Drawing.Point(11, 671);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 24);
            this.label25.TabIndex = 0;
            this.label25.Text = "Lực cắt";
            // 
            // btn_load_excel
            // 
            this.btn_load_excel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_load_excel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load_excel.ForeColor = System.Drawing.Color.White;
            this.btn_load_excel.Location = new System.Drawing.Point(6, 716);
            this.btn_load_excel.Name = "btn_load_excel";
            this.btn_load_excel.Size = new System.Drawing.Size(180, 37);
            this.btn_load_excel.TabIndex = 3;
            this.btn_load_excel.Text = "Thêm tĩnh tải";
            this.btn_load_excel.UseVisualStyleBackColor = false;
            this.btn_load_excel.Click += new System.EventHandler(this.btn_load_excel_Click);
            // 
            // btn_luu_du_lieu
            // 
            this.btn_luu_du_lieu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_luu_du_lieu.Enabled = false;
            this.btn_luu_du_lieu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu_du_lieu.ForeColor = System.Drawing.Color.White;
            this.btn_luu_du_lieu.Location = new System.Drawing.Point(192, 716);
            this.btn_luu_du_lieu.Name = "btn_luu_du_lieu";
            this.btn_luu_du_lieu.Size = new System.Drawing.Size(190, 37);
            this.btn_luu_du_lieu.TabIndex = 3;
            this.btn_luu_du_lieu.Text = "Lưu dữ liệu";
            this.btn_luu_du_lieu.UseVisualStyleBackColor = false;
            this.btn_luu_du_lieu.Click += new System.EventHandler(this.btn_luu_du_lieu_Click);
            // 
            // txt_moment
            // 
            this.txt_moment.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_moment.Location = new System.Drawing.Point(144, 632);
            this.txt_moment.Name = "txt_moment";
            this.txt_moment.ReadOnly = true;
            this.txt_moment.Size = new System.Drawing.Size(236, 29);
            this.txt_moment.TabIndex = 1;
            this.txt_moment.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Maroon;
            this.label24.Location = new System.Drawing.Point(11, 633);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 24);
            this.label24.TabIndex = 0;
            this.label24.Text = "Moment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(401, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "mm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(401, 427);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "mm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(401, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "mm";
            // 
            // txt_Hb
            // 
            this.txt_Hb.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Hb.Location = new System.Drawing.Point(10, 590);
            this.txt_Hb.Name = "txt_Hb";
            this.txt_Hb.Size = new System.Drawing.Size(372, 29);
            this.txt_Hb.TabIndex = 1;
            this.txt_Hb.Text = "0";
            // 
            // txt_lb
            // 
            this.txt_lb.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lb.Location = new System.Drawing.Point(10, 511);
            this.txt_lb.Name = "txt_lb";
            this.txt_lb.Size = new System.Drawing.Size(372, 29);
            this.txt_lb.TabIndex = 1;
            this.txt_lb.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Chiều cao bậc (150 - 200)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 554);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(385, 24);
            this.label19.TabIndex = 0;
            this.label19.Text = "Sàn chiếu nghỉ chọn bằng chiều dày sàn : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 472);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Chiều rộng bậc : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(401, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "mm";
            // 
            // tct_hb
            // 
            this.tct_hb.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tct_hb.Location = new System.Drawing.Point(10, 421);
            this.tct_hb.Name = "tct_hb";
            this.tct_hb.Size = new System.Drawing.Size(372, 29);
            this.tct_hb.TabIndex = 1;
            this.tct_hb.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(399, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "mm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(399, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "mm";
            // 
            // txt_h
            // 
            this.txt_h.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_h.Location = new System.Drawing.Point(10, 341);
            this.txt_h.Name = "txt_h";
            this.txt_h.Size = new System.Drawing.Size(372, 29);
            this.txt_h.TabIndex = 1;
            this.txt_h.Text = "0";
            // 
            // txt_c
            // 
            this.txt_c.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c.Location = new System.Drawing.Point(10, 262);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(372, 29);
            this.txt_c.TabIndex = 1;
            this.txt_c.Text = "0";
            this.txt_c.TextChanged += new System.EventHandler(this.txt_c_TextChanged);
            // 
            // txt_l3
            // 
            this.txt_l3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_l3.Location = new System.Drawing.Point(10, 186);
            this.txt_l3.Name = "txt_l3";
            this.txt_l3.Size = new System.Drawing.Size(372, 29);
            this.txt_l3.TabIndex = 1;
            this.txt_l3.Text = "0";
            // 
            // txt_l2
            // 
            this.txt_l2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_l2.Location = new System.Drawing.Point(8, 118);
            this.txt_l2.Name = "txt_l2";
            this.txt_l2.Size = new System.Drawing.Size(372, 29);
            this.txt_l2.TabIndex = 1;
            this.txt_l2.Text = "0";
            // 
            // txt_l1
            // 
            this.txt_l1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_l1.Location = new System.Drawing.Point(8, 50);
            this.txt_l1.Name = "txt_l1";
            this.txt_l1.Size = new System.Drawing.Size(372, 29);
            this.txt_l1.TabIndex = 1;
            this.txt_l1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chiều cao tầng : (H)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khoảng thông thủy giữa 2 bản thang (c) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chiều rộng bản chiếu nghỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chiều dài bản thang : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chiều rộng bản thang :";
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
            this.dgv_data.Location = new System.Drawing.Point(474, 81);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.ReadOnly = true;
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.RowTemplate.Height = 24;
            this.dgv_data.Size = new System.Drawing.Size(859, 314);
            this.dgv_data.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tĩnh tải";
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
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(483, 419);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(459, 24);
            this.label21.TabIndex = 0;
            this.label21.Text = "Hoạt tải tiêu chuẩn cầu thang (TCVN 2737 - 1995)";
            // 
            // txt_ht
            // 
            this.txt_ht.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ht.Location = new System.Drawing.Point(956, 418);
            this.txt_ht.Name = "txt_ht";
            this.txt_ht.Size = new System.Drawing.Size(378, 29);
            this.txt_ht.TabIndex = 1;
            this.txt_ht.Text = "3.6";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(483, 459);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(244, 24);
            this.label22.TabIndex = 0;
            this.label22.Text = "Giá trị tĩnh tải tính toán  : ";
            // 
            // txt_tt
            // 
            this.txt_tt.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tt.Location = new System.Drawing.Point(956, 458);
            this.txt_tt.Name = "txt_tt";
            this.txt_tt.ReadOnly = true;
            this.txt_tt.Size = new System.Drawing.Size(378, 29);
            this.txt_tt.TabIndex = 1;
            this.txt_tt.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(483, 494);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 24);
            this.label23.TabIndex = 0;
            this.label23.Text = "Ltt : ";
            // 
            // txt_Ltt
            // 
            this.txt_Ltt.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ltt.Location = new System.Drawing.Point(956, 493);
            this.txt_Ltt.Name = "txt_Ltt";
            this.txt_Ltt.Size = new System.Drawing.Size(378, 29);
            this.txt_Ltt.TabIndex = 1;
            this.txt_Ltt.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Yellow;
            this.label28.Location = new System.Drawing.Point(562, 9);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(340, 36);
            this.label28.TabIndex = 6;
            this.label28.Text = "TÍNH TOÁN BẢN THANG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btn_simulator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 56);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyProject.Properties.Resources._1200px_LOGO_DHXD;
            this.pictureBox1.Location = new System.Drawing.Point(512, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_simulator
            // 
            this.btn_simulator.BorderRadius = 3;
            this.btn_simulator.CheckedState.Parent = this.btn_simulator;
            this.btn_simulator.CustomImages.Parent = this.btn_simulator;
            this.btn_simulator.FillColor = System.Drawing.Color.Gray;
            this.btn_simulator.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_simulator.ForeColor = System.Drawing.Color.White;
            this.btn_simulator.HoverState.Parent = this.btn_simulator;
            this.btn_simulator.Location = new System.Drawing.Point(1158, 12);
            this.btn_simulator.Margin = new System.Windows.Forms.Padding(4);
            this.btn_simulator.Name = "btn_simulator";
            this.btn_simulator.ShadowDecoration.Parent = this.btn_simulator;
            this.btn_simulator.Size = new System.Drawing.Size(175, 33);
            this.btn_simulator.TabIndex = 15;
            this.btn_simulator.Text = "Simulator Data";
            this.btn_simulator.Click += new System.EventHandler(this.btn_simulator_Click);
            // 
            // Cbb_tinhtoan
            // 
            this.Cbb_tinhtoan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_tinhtoan.FormattingEnabled = true;
            this.Cbb_tinhtoan.Items.AddRange(new object[] {
            "1. Tính toán thép bản thang",
            "2. Tính toán thép bản chiếu nghỉ",
            "3. Tính toán thép dầm chiếu nghỉ"});
            this.Cbb_tinhtoan.Location = new System.Drawing.Point(23, 139);
            this.Cbb_tinhtoan.Name = "Cbb_tinhtoan";
            this.Cbb_tinhtoan.Size = new System.Drawing.Size(672, 33);
            this.Cbb_tinhtoan.TabIndex = 4;
            // 
            // btn_batdau
            // 
            this.btn_batdau.BorderRadius = 3;
            this.btn_batdau.CheckedState.Parent = this.btn_batdau;
            this.btn_batdau.CustomImages.Parent = this.btn_batdau;
            this.btn_batdau.Enabled = false;
            this.btn_batdau.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_batdau.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_batdau.ForeColor = System.Drawing.Color.White;
            this.btn_batdau.HoverState.Parent = this.btn_batdau;
            this.btn_batdau.Location = new System.Drawing.Point(707, 137);
            this.btn_batdau.Margin = new System.Windows.Forms.Padding(4);
            this.btn_batdau.Name = "btn_batdau";
            this.btn_batdau.ShadowDecoration.Parent = this.btn_batdau;
            this.btn_batdau.Size = new System.Drawing.Size(148, 34);
            this.btn_batdau.TabIndex = 15;
            this.btn_batdau.Text = "Tính ";
            this.btn_batdau.Click += new System.EventHandler(this.btn_batdau_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.level3);
            this.groupBox3.Controls.Add(this.level2);
            this.groupBox3.Controls.Add(this.level1);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.Cbb_tinhtoan);
            this.groupBox3.Controls.Add(this.btn_botrithep);
            this.groupBox3.Controls.Add(this.btn_batdau);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(474, 547);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(859, 287);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn loại cấu kiện để tính toán";
            // 
            // level3
            // 
            this.level3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.level3.Location = new System.Drawing.Point(475, 204);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(220, 19);
            this.level3.TabIndex = 17;
            // 
            // level2
            // 
            this.level2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.level2.Location = new System.Drawing.Point(249, 204);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(220, 19);
            this.level2.TabIndex = 17;
            // 
            // level1
            // 
            this.level1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.level1.Location = new System.Drawing.Point(23, 204);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(220, 19);
            this.level1.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(477, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(245, 28);
            this.label17.TabIndex = 16;
            this.label17.Text = "3. Cấu kiện dầm chiếu nghỉ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(239, 28);
            this.label16.TabIndex = 16;
            this.label16.Text = "2. Cấu kiện bản chiếu nghỉ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 28);
            this.label13.TabIndex = 16;
            this.label13.Text = "1. Cấu kiện bản thang";
            // 
            // btn_botrithep
            // 
            this.btn_botrithep.BorderRadius = 3;
            this.btn_botrithep.CheckedState.Parent = this.btn_botrithep;
            this.btn_botrithep.CustomImages.Parent = this.btn_botrithep;
            this.btn_botrithep.Enabled = false;
            this.btn_botrithep.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_botrithep.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_botrithep.ForeColor = System.Drawing.Color.White;
            this.btn_botrithep.HoverState.Parent = this.btn_botrithep;
            this.btn_botrithep.Location = new System.Drawing.Point(707, 190);
            this.btn_botrithep.Margin = new System.Windows.Forms.Padding(4);
            this.btn_botrithep.Name = "btn_botrithep";
            this.btn_botrithep.ShadowDecoration.Parent = this.btn_botrithep;
            this.btn_botrithep.Size = new System.Drawing.Size(148, 34);
            this.btn_botrithep.TabIndex = 15;
            this.btn_botrithep.Text = "Bố trí thép";
            this.btn_botrithep.Visible = false;
            this.btn_botrithep.Click += new System.EventHandler(this.btn_batdau_Click);
            // 
            // Taitrongtinhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 852);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Ltt);
            this.Controls.Add(this.txt_tt);
            this.Controls.Add(this.txt_ht);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Taitrongtinhtoan.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Taitrongtinhtoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "wq ẻvgbth";
            this.Load += new System.EventHandler(this.Taitrongtinhtoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txt_h;
        private TextBox txt_c;
        private TextBox txt_l3;
        private TextBox txt_l2;
        private TextBox txt_l1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label11;
        private Label label12;
        private TextBox tct_hb;
        private TextBox txt_lb;
        private DataGridView dgv_data;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btn_luu_du_lieu;
        private Label label15;
        private Label label14;
        private TextBox txt_Hb;
        private Label label19;
        private Label label21;
        private TextBox txt_ht;
        private Label label22;
        private TextBox txt_tt;
        private Label label23;
        private TextBox txt_Ltt;
        private Label label25;
        private TextBox txt_q;
        private Label label24;
        private TextBox txt_moment;
        private Label label27;
        private Label label26;
        private Button btn_load_excel;
        private OpenFileDialog openFileDialog1;
        private Label label28;
        private Panel panel1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Cbb_tinhtoan;
        private Guna.UI2.WinForms.Guna2Button btn_batdau;
        private Label label20;
        private GroupBox groupBox3;
        private Label label17;
        private Label label16;
        private Label label13;
        private Guna.UI2.WinForms.Guna2Button btn_simulator;
        public Panel level3;
        public Panel level2;
        public Panel level1;
        private Guna.UI2.WinForms.Guna2Button btn_botrithep;
    }
}