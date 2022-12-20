using myproject.CotThep;
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
    public partial class NhapCotThep : Form
    {
        public NhapCotThep()
        {
            InitializeComponent();
        }

        private void cbb_choncotthep_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbb_choncotthep.SelectedIndex;
            switch (index)
            {
                case 0:
                    Data.cothep = new CT240T();
                    break;
                case 1:
                    Data.cothep = new CB300T();
                    break;
                case 2:
                    Data.cothep = new CB300V();
                    break;
                case 3:
                    Data.cothep = new CB400V();
                    break;

                default:
                    break;
            }

            txt_Rs.Text = Data.cothep.Rs.ToString();
            txt_Es.Text = Data.cothep.Es.ToString();
            txt_Rsc.Text = Data.cothep.Rsc.ToString();
        }

        private void NhapCotThep_Load(object sender, EventArgs e)
        {
            cbb_choncotthep.SelectedIndex = 0;
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            this.Close();
            Data.Success("Lưu cốt thép thành công");
            Data.IsClickConcrete = true;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
