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
  
    public partial class frm_TinhDamChieuNghi : Form
    {
        public double q1 { get; set; } = 5.19;
        public double q2 { get; set; } = 4.99;
        public double q3 { get; set; } = 1.82;
        public double q4 { get; set; } = 0.14;
        public double q { get; set; } = 0;
        public double L4 { get; set; } = 0;
        public double M { get; set; }
        private double Hdcn = 0;
        private double Bdcn = 0;
        private double ho;
        private double coverLayer;

        public frm_TinhDamChieuNghi()
        {
            InitializeComponent();
           
        }
        private void InitializeData()
        {
            q = q1 + q2 + q3 + q4;
            L4 = Data.L4;
        }

        private void cbb_damchieunghi_SelectedIndexChanged(object sender, EventArgs e)
        {
            double scale;
            double index = cbb_damchieunghi.SelectedIndex;
            switch (index)
            {
                case 0:
                    scale = 1 / 8.0;
                    break;
                case 1:
                    scale = 1 / 9.0;
                    break;
                case 2:
                    scale = 1 / 10.0;
                    break;
                case 3:
                    scale = 1 / 11.0;
                    break;
                case 4:
                    scale = 1 / 12.0;
                    break;
                default:
                    scale = 1 / 8;
                    break;
            }
            if (L4 > 0)
            {
                Hdcn = Create_HDCN(L4, scale);
                txt_Hdcn.Text = Hdcn.ToString();
            }
            else
            {

            }

        }
        private double Create_HDCN(double L, double scale)
        {
            var response = scale * L;
            return Math.Round(response, 2);
        }

        private double Create_BDCN(double hdcn, double scale)
        {
            var response = scale * Hdcn;
            return Math.Round(response, 2);
        }
        private void cbb_bdcn_SelectedIndexChanged(object sender, EventArgs e)
        {
            double scale;
            double index = cbb_bdcn.SelectedIndex;
            switch (index)
            {
                case 0:
                    scale = 0.3;
                    break;
                case 1:
                    scale = 0.4;
                    break;
                case 2:
                    scale = 0.5;
                    break;
                default:
                    scale = 0.3;
                    break;
            }

            if (Hdcn > 0)
            {
                Bdcn = Create_BDCN(Hdcn, scale);
                txt_bdcn.Text = Bdcn.ToString();

            }
        }

        private void frm_TinhDamChieuNghi_Load(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void btn_tinhtoan_Click(object sender, EventArgs e)
        {
            
            double l = L4;
            double am, cosi, As,u;
            try
            {
                coverLayer = double.Parse(txt_cover.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Sai định dạng nhập liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
     
            if (coverLayer<=0)
            {
                MessageBox.Show("Không được nhập giá trị âm cho lớp bảo vệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                M = Extension.Execute_Moment(q, L4);
                ho = Extension.Execute_Ho(Hdcn, coverLayer);
                am = Extension.ExecuteAm_mm(M, Hdcn, ho);
                cosi = Extension.Execute_cosi(am);
                As = Extension.Execute_As(M, cosi, Data.cothep.Rs, ho);
                u = Extension.Execute_Hamluongcotthep(As, Bdcn, ho);
                txt_moment.Text = As.ToString();
                txt_u.Text = u.ToString() + " %";
                if (u>0.2 && u<0.5)
                {
                    lb_thongbao.Visible = true;
                    lb_thongbao.Text = "Hàm lượng cốt thép đảm bảo";
                    Data.frm_TinhToan.level3.BackColor = Color.Green;
                }
                else
                {
                    lb_thongbao.Visible = true;
                    lb_thongbao.Text = "Hàm lượng cốt thép không đảm bảo";
                    Data.frm_TinhToan.level3.BackColor = Color.Gray;
                }
            }

        }
    }
}
