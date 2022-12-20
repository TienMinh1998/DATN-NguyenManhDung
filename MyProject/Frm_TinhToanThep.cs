using myproject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class Frm_TinhToanThep : Form
    {
        public double H { get; set; }
        public double M { get; set; }
        private double Ho;
        public double Rb { get; set; }
        public double Rs { get; set; }
        public double As { get; set; }
        public double U { get; set; }
        public Frm_TinhToanThep()
        {
            InitializeComponent();
        }

        private void btn_tinhtoan_Click(object sender, EventArgs e)
        {
            btn_kiemtra.Enabled = true;
            lb_thongbao.Visible = false;
            double b = double.Parse(txt_b.Text);
         
            double am, C;
            double cover = double.Parse(txt_cover.Text);
            Ho = H - cover;

            // Tính toán am và cơ si 
            am = M / (Rb*100 * b * Ho/1000);
            C = 0.5 * (1 + Math.Sqrt(1 - 2 * am));
            As = M*Math.Pow(10,6) / (Rs/10 * C * Ho);
            U = As / (b * 1000 * Ho)*100;

            // Hiển thị kết quả
            txt_Hamluongcotthep.Text = U.ToString();
            txt_As.Text = As.ToString();
            Data.b = b;
            Data.cover= cover;
        }

        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            double u = 0.05;
            double umax = 2;
            if (u<U && U<umax)
            {
                lb_thongbao.Text = "Hàm lượng cốt thép đảm bảo";
                lb_thongbao.Visible = true;
                Data.frm_TinhToan.level1.BackColor = Color.Green;
            }
            else
            {
                lb_thongbao.Text = "Hàm lượng cốt thép không đảm bảo";
                lb_thongbao.ForeColor = Color.Red;
                lb_thongbao.Visible = true;
                Data.frm_TinhToan.level1.BackColor = Color.Gray;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
      
            this.Close();
        }
    }
}
