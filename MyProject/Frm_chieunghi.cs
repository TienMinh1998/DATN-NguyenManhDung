using myproject;
using MyProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
namespace MyProject
{
    public partial class Frm_chieunghi : Form
    {

        public double L4 { get; set; }
        public double L3 { get; set; }
        public double Qb { get; set; }
        private double cover = 15; // mm
        public double M { get; set; }
        public double Hsan { get; set; }
        public double Ho { get; set; }

        private List<TinhTaiModel> DataExcel = new List<TinhTaiModel>();
        public Frm_chieunghi()
        {
            InitializeComponent();
        }

        private void btn_tinhtoan_Click(object sender, EventArgs e)
        {

            // Lưu dữ liệu, tính tổng tĩnh tải
            double total = 0;
            var rows = dgv_data.Rows.Count;
            DataExcel.Clear();
            for (int i = 0; i < rows; i++)
            {
                TinhTaiModel item = new TinhTaiModel()
                {
                    Name = dgv_data.Rows[i].Cells[0].Value.ToString(),
                    ChieuDay = dgv_data.Rows[i].Cells[1].Value.ToString(),
                    Y = double.Parse(dgv_data.Rows[i].Cells[2].Value.ToString()),
                    HSVT = double.Parse(dgv_data.Rows[i].Cells[3].Value.ToString()),
                    TaiTrong = double.Parse(dgv_data.Rows[i].Cells[4].Value.ToString())
                };
                DataExcel.Add(item);
                total += item.TaiTrong;
            }
            // Tính tổng tĩnh tải 
            txt_hoattai.Text = "3.6";
            txt_tongtinhtai.Text = total.ToString();
            Qb = total + 3.6;

            Ho = Hsan - cover;
            M = Extension.Execute_Moment(Qb, L3);
            double am = Extension.ExecuteAm(M, Data.Concrete.Rb, 1, Ho);
            double c = Extension.Execute_cosi(am);
            double As = Extension.Execute_As(M, c, Data.cothep.Rs, Ho);

            txt_moment.Text = M.ToString() + " Kn.m";
            txt_tongtaitrong.Text = Qb.ToString() + "km/m2";
            txt_as.Text = As.ToString() + "mm2";
            Data.frm_TinhToan.level2.BackColor = Color.Green;
        }

        private void btn_loadExcel_Click(object sender, EventArgs e)
        {
           
            try
            {
                this.dgv_data.Rows.Clear();
                this.openFileDialog1.FileName = "";
                this.openFileDialog1.Filter = "Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    excel.Application xlApp;
                    excel.Workbook xlWorkBook;
                    excel.Worksheet xlWorkSheet;
                    xlApp = new excel.Application();
                    xlWorkBook = xlApp.Workbooks.Open(this.openFileDialog1.FileName);
                    xlWorkSheet = (excel.Worksheet)xlWorkBook.Worksheets["Sheet1"];
                    // Dem so hang
                    var sh = default(int);
                    for (int i = 2; i <= 300; i++)
                    {
                        if (xlWorkSheet.Cells[i, 1].value != null)
                        {
                            sh = i - 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                    this.dgv_data.Rows.Clear();
                    for (int i = 2, loopTo = sh + 1; i <= loopTo; i++)
                        this.dgv_data.Rows.Add(xlWorkSheet.Cells[(object)i, (object)1].value, xlWorkSheet.Cells[(object)i, (object)2].value, xlWorkSheet.Cells[(object)i, (object)3].value, xlWorkSheet.Cells[(object)i, (object)4].value, xlWorkSheet.Cells[(object)i, (object)5].value, xlWorkSheet.Cells[(object)i, (object)6].value, xlWorkSheet.Cells[(object)i, (object)7].value, xlWorkSheet.Cells[(object)i, (object)8].value, xlWorkSheet.Cells[(object)i, (object)9].value, xlWorkSheet.Cells[(object)i, (object)10].value, xlWorkSheet.Cells[(object)i, (object)11].value, xlWorkSheet.Cells[(object)i, (object)12].value);
                    xlWorkBook.Close();
                    xlApp.Quit();
                    btn_tinhtoan.Enabled = true;
                    btn_loadExcel.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void Frm_chieunghi_Load(object sender, EventArgs e)
        {
            //Lấy dữ liệu
            L4 = Data.L4;
            L3 = Data.L3;
            Hsan = Data.Hsan;
            txt_L3.Text = L3.ToString();
            txt_L4.Text = L4.ToString();
            double tile = L4 / L3;
            txt_Ts.Text = tile.ToString();
            btn_tinhtoan.Enabled = false;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
