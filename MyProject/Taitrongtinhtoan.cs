
using MyProject;
using MyProject.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using excel =  Microsoft.Office.Interop.Excel;
namespace myproject
{
    public partial class Taitrongtinhtoan : DevExpress.XtraEditors.XtraForm
    {
        private bool checkTinhToan;// Có thể tính toán hay không
        private List<TinhTaiModel> DataExcel = new List<TinhTaiModel>();
        public Taitrongtinhtoan()
        {
            InitializeComponent();
        }

        #region Tham số

        private double Hdcn = 0;
        private double Bdcn = 0;
        private double cosA = 0;
        private double L4;
        private double L1;
        private double L2;
        private double L3;
        private double C;
        // Chiều rộng và chiều cao của bậc
        private double Hb;
        private double Lb;
        private double Hsan;
        // Tĩnh tải và hoạt tải 
        private double TT;
        private double HT;
        // Tổng tải 
        private double Qb;
        private double Ltt;
        // Kết quả tính toán
        private double M;
        private double Q;
        #endregion

        private bool CheckNagative()
        {
            if (L1<=0)
            {
                MessageBox.Show("Chiều rộng bản thang (L1) không được âm hoặc bằng 0");
                return false;
            }
            if (L2<=0)
            {
                MessageBox.Show("Chiều dài bản thang (L2) không được âm hoặc bằng 0");
                return false;
            }
            if (L3<=0)
            {
                MessageBox.Show("Chiều rộng bản chiếu nghỉ (L3) không được âm hoặc bằng 0");
                return false;
            }
            if (Hb <= 0)
            {
                MessageBox.Show("Chiều cao bậc không được âm hoặc bằng  0");
                return false;
            }
            if (C <=0)
            {
                MessageBox.Show("khoảng hở không được âm hoặc bằng 0");
                return false;
            }
            if (Lb <= 0)
            {
                MessageBox.Show("Chiều dài bậc không được âm hoặc bằng 0");
                return false;
            }
            return true;
        }


        private void Taitrongtinhtoan_Load(object sender, EventArgs e)
        {
            Cbb_tinhtoan.SelectedIndex = 0;
            level1.BackColor = Color.Gray;
            level2.BackColor = Color.Gray;
            level3.BackColor = Color.Gray;
        }

        private void btn_innitData_Click(object sender, EventArgs e)
        {
            dgv_data.Rows.Clear();
            dgv_data.Rows.Add("Lát đá", "20 (mm)", 20, 1.1, 0.44);
            dgv_data.Rows.Add("Vữa xi măng", "15 (mm)", 18, 1.3, 0.351);
            dgv_data.Rows.Add("Bậc gạch", "100 (mm)", 18, 1.1, 1.98);
            dgv_data.Rows.Add("Vữa lót", "15 (mm)", 18, 1.3, 0.351);
            dgv_data.Rows.Add("Bản BTCT", "120 (mm)", 25, 1.1, 3.3);
            dgv_data.Rows.Add("Vữa trát trần", "15 (mm)", 18, 1.3, 0.351);
        }

        #region Kiểm tra rỗng 
        private bool checkNull()
        {
            if (txt_l1.Text == "")
            {
                MessageBox.Show("Không được nhập số âm");
                return false;
            }
            if (txt_l2.Text == "")
            {
                MessageBox.Show("KHông được để trống L2");
                return false;
            }
            if (txt_l3.Text == "")
            {
                MessageBox.Show("KHông được để trống L3");
                return false;
            }
            if (txt_lb.Text == "")
            {
                MessageBox.Show("Không được để trống chiều dài bậc");
                return false;
            }
            if (tct_hb.Text == "Không được để trống chiều cao bậc")
            {
                MessageBox.Show("Không được để trống chiều cao bậc");
                return false;
            }
            if (txt_Hb.Text == "")
            {
                MessageBox.Show("Không được để trống Hb");
                return false;
            }
            return true;
        }
        #endregion

        private void btn_luu_du_lieu_Click(object sender, EventArgs e)
        {
            if (!checkNull()) return;
            try
            {

                L1 = double.Parse(txt_l1.Text);
                L2 = double.Parse(txt_l2.Text);
                L3 = double.Parse(txt_l3.Text);
                C = double.Parse(txt_c.Text);
                L4 = 2 * L1 + C;
                Hsan = double.Parse(txt_Hb.Text);
                // Chiều dài và chiều rộng bậc
                Lb = double.Parse(txt_lb.Text);
                Hb = double.Parse(tct_hb.Text);
                cosA = Lb / Math.Sqrt(Lb * Lb + Hb * Hb);
                TT = double.Parse(txt_tt.Text);
                HT = double.Parse(txt_ht.Text);
                Qb = (TT + HT) * cosA * 1;
                Ltt = 2*L1+C;
                M = ((Qb * Ltt * Ltt) / 8.0) / 1000000.0; // đổi đơn bị
                Q = ((Qb * Ltt) / 2) / 1000;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi nhập liệu");
                return;
            }
            if (!CheckNagative())
            {
                return;
            }
            else
            {
                // Tính toán M và Q
                txt_Ltt.Text = Ltt.ToString();
                txt_moment.Text = Math.Round(M, 2).ToString();
                txt_q.Text = Math.Round(Q, 2).ToString();
                Data.Hsan = Hsan;
                Data.L4 = L4;
                btn_batdau.Enabled = true;
                MessageBox.Show("Lưu dữ liệu thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
        }
        private double Create_HDCN(double L,double scale)
        {
            var response = scale * L;
            return Math.Round(response, 2);
        }

        private double Create_BDCN(double hdcn, double scale)
        {
            var response = scale * Hdcn;
            return Math.Round(response, 2);
        }

        private void btn_load_excel_Click(object sender, EventArgs e)
        {

            if (Data.IsClickConcrete==false || Data.IsClickSteel==false)
            {
                MessageBox.Show("Bạn phải chọn bê tông cốt thép trước","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
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
                    }
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
                    txt_tt.Text = total.ToString();

                    btn_luu_du_lieu.Enabled = true;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.frm_chieunghi.ShowDialog();
        }

        private void btn_batdau_Click(object sender, EventArgs e)
        {
            var index = Cbb_tinhtoan.SelectedIndex;
            if (index == 0) // tính toán với bản thang
            {
                Data.L1 = L1;
                Data.L2 = L2;
                Data.L3 = L3;
                Data.L4 = L4;

                Frm_TinhToanThep frm = new Frm_TinhToanThep();
                frm.H = Hsan;
                frm.M = M;
                frm.Rb = Data.Concrete.Rb;
                frm.Rs = Data.cothep.Rs;
                frm.ShowDialog();
            }
            if (index == 1)   // Tính toán với bản chiếu nghỉ
            {
                Data.frm_chieunghi.ShowDialog();
            }

            if (index==2)
            {
                Data.frm_TinhDamChieuNghi.ShowDialog();
            }
        }

        private void btn_simulator_Click(object sender, EventArgs e)
        {
            // Dữ liệu mẫu để Test
            txt_l1.Text = "1160";
            txt_l2.Text = "2650";
            txt_l3.Text = "1240";
            txt_c.Text = "500";
            txt_Hb.Text = "120";
            tct_hb.Text = "200";
            txt_lb.Text = "300";
            txt_h.Text = "3600";
        }

        private void txt_c_TextChanged(object sender, EventArgs e)
        {

        }
    }
}