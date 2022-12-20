using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace myproject
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Form1();
                }
                return _instance;
            }
        }
        public Form1()
        {
            InitializeComponent();
         
        }

        private void btnNhapLieuBeTong_Click(object sender, EventArgs e)
        {
            Data.frm_nhapbetong.ShowDialog();
        }

        private void btnNhapLieuThep_Click(object sender, EventArgs e)
        {
            Data.frm_NhapCotThep.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Hiện Form nhập bê tông
            Data.frm_nhapbetong.ShowDialog();
        }

        private void btn_vatlieucoththep_ItemClick(object sender, ItemClickEventArgs e)
        {
            // hiện form nhập cốt thép
            Data.frm_NhapCotThep.ShowDialog();
        }

        private void btn_tinhtoantaitrong_ItemClick(object sender, ItemClickEventArgs e)
        {

            //-------------------------
            DisplayControl(Data.frm_TinhToan);
        }

        public  void DisplayControl(Form form)
        {
            if (!pn_main.Controls.Contains(form))
            {
                pn_main.Controls.Clear(); // xóa giao diện cũ đi trước rồi mới thêm vào 
                form.TopLevel = false;
                form.AutoScroll = true;
                form.Dock = DockStyle.Fill;
                pn_main.Controls.Add(form);
                form.Show();
            }
            else
            {
                form.Show();
            }
         
        }

        private void btn_hoattai_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btn_tinhnoiluc_ItemClick(object sender, ItemClickEventArgs e)
        {
          //  DisplayControl(Data.frm_noiluc);
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _instance = this;
            DisplayControl(Data.frm_TinhToan);
        }

        private void btn_chieunghi_ItemClick(object sender, ItemClickEventArgs e)
        {
          //  DisplayControl(Data.frm_noilucchieunghi);
           
        }

        private void btn_tinhthepdai_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form1.Instance.pn_main.Controls.Clear();
        }

      

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            DisplayControl(Data.frm_chieunghi);
        }
    }
}
