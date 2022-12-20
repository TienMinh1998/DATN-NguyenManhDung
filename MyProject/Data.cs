using myproject.CotThep;
using myproject.myBeTong;
using myproject.ThongBao;
using MyProject;
using System;
namespace myproject
{
   public static class Data
    {
        #region Khai báo các giao diện người dùng
        public static Form1 frm_main = new Form1();
        public static MyBeTong Concrete = new MyBeTong();
        public static cottheptinhtoan cothep = new cottheptinhtoan();
        public static NhapBeTong frm_nhapbetong = new NhapBeTong();
        public static NhapCotThep frm_NhapCotThep = new NhapCotThep();
        public static Taitrongtinhtoan frm_TinhToan = new Taitrongtinhtoan();
        public static Frm_chieunghi frm_chieunghi = new Frm_chieunghi();
        public static frm_TinhDamChieuNghi frm_TinhDamChieuNghi = new frm_TinhDamChieuNghi();
        #endregion

        #region Hàm log thông báo
        public static void ShowError(string text)
        {
            try
            {
                frm_thongbao thongbao = new frm_thongbao();
                thongbao.showAlert(text, frm_thongbao.enmType.Error);
            }
            catch (Exception)
            {

            }

        }
        public static void Success(string text)
        {
            try
            {
                frm_thongbao thongbao = new frm_thongbao();
                thongbao.showAlert(text, frm_thongbao.enmType.Success);
            }
            catch (Exception)
            {

            }

        }
        public static void ShowInfomation(string text)
        {
            try
            {
                frm_thongbao thongbao = new frm_thongbao();
                thongbao.showAlert(text, frm_thongbao.enmType.Info);
            }
            catch (Exception)
            {

            }

        }
        #endregion

        #region Thông số 

        // Các thông số tính toán dùng chung 
        public static double L1;
        public static double L2;
        public static double L3;
        public static double L4;
        public static double Hsan;
        public static double b;
        public static double cover;

        // Transmit 
        public static bool IsClickConcrete;
        public static bool IsClickSteel;
        #endregion
    }
}
