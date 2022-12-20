using DevExpress.XtraEditors;
using myproject.myBeTong;
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
    public partial class NhapBeTong : DevExpress.XtraEditors.XtraForm
    {
        public NhapBeTong()
        {
            InitializeComponent();
        }

        private void cbb_nhapbetong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chiso = cbb_nhapbetong.SelectedIndex;
            switch (chiso)
            {
                case 0:
                    Data.Concrete = new B20();
                    break;
                case 1:
                    Data.Concrete = new B25();
                    break;
                case 2:
                    Data.Concrete = new B30();
                    break;
                default:
                    break;
            }
            txt_Rb.Text = Data.Concrete.Rb.ToString();
            txt_Rbt.Text = Data.Concrete.Rbt.ToString();
            txt_Es.Text = Data.Concrete.EB.ToString();

        }

   

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhapBeTong_Load(object sender, EventArgs e)
        {
            // Khởi tạo mặc định
            cbb_nhapbetong.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            this.Close();
            Data.IsClickSteel = true;
        }
    }
}