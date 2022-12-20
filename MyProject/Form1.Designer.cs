
namespace myproject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.pn_main = new System.Windows.Forms.Panel();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_vatlieucoththep = new DevExpress.XtraBars.BarButtonItem();
            this.btn_tinhtoantaitrong = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_hoattai = new DevExpress.XtraBars.BarButtonItem();
            this.btn_tinhnoiluc = new DevExpress.XtraBars.BarButtonItem();
            this.btn_huongdansudung = new DevExpress.XtraBars.BarButtonItem();
            this.btn_banve = new DevExpress.XtraBars.BarButtonItem();
            this.btn_chieunghi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_tinhthepdai = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.pn_main);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 193);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1370, 850);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // pn_main
            // 
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(0, 0);
            this.pn_main.Margin = new System.Windows.Forms.Padding(4);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(1370, 850);
            this.pn_main.TabIndex = 0;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.btn_vatlieucoththep,
            this.btn_tinhtoantaitrong,
            this.barButtonItem2,
            this.btn_hoattai,
            this.btn_tinhnoiluc,
            this.btn_huongdansudung,
            this.btn_banve,
            this.btn_chieunghi,
            this.btn_tinhthepdai,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1370, 193);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Vật liệu bê tông";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = global::MyProject.Properties.Resources.icons8_steel_ore_48px;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btn_vatlieucoththep
            // 
            this.btn_vatlieucoththep.Caption = "Vật liệu cốt thép";
            this.btn_vatlieucoththep.Id = 2;
            this.btn_vatlieucoththep.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_vatlieucoththep.ImageOptions.Image")));
            this.btn_vatlieucoththep.Name = "btn_vatlieucoththep";
            this.btn_vatlieucoththep.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_vatlieucoththep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_vatlieucoththep_ItemClick);
            // 
            // btn_tinhtoantaitrong
            // 
            this.btn_tinhtoantaitrong.Caption = "Tính toán bản thang";
            this.btn_tinhtoantaitrong.Id = 3;
            this.btn_tinhtoantaitrong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_tinhtoantaitrong.ImageOptions.SvgImage")));
            this.btn_tinhtoantaitrong.Name = "btn_tinhtoantaitrong";
            this.btn_tinhtoantaitrong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_tinhtoantaitrong_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btn_hoattai
            // 
            this.btn_hoattai.Caption = "Tính toán hoạt tải";
            this.btn_hoattai.Id = 5;
            this.btn_hoattai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_hoattai.ImageOptions.SvgImage")));
            this.btn_hoattai.Name = "btn_hoattai";
            this.btn_hoattai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_hoattai_ItemClick);
            // 
            // btn_tinhnoiluc
            // 
            this.btn_tinhnoiluc.Caption = "Tính nội lực và tính thép bản thang";
            this.btn_tinhnoiluc.Id = 6;
            this.btn_tinhnoiluc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_tinhnoiluc.ImageOptions.Image")));
            this.btn_tinhnoiluc.Name = "btn_tinhnoiluc";
            this.btn_tinhnoiluc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_tinhnoiluc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_tinhnoiluc_ItemClick);
            // 
            // btn_huongdansudung
            // 
            this.btn_huongdansudung.Caption = "Hướng dẫn sử dụng";
            this.btn_huongdansudung.Id = 7;
            this.btn_huongdansudung.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_huongdansudung.ImageOptions.SvgImage")));
            this.btn_huongdansudung.Name = "btn_huongdansudung";
            // 
            // btn_banve
            // 
            this.btn_banve.Caption = "Bản vẽ";
            this.btn_banve.Id = 8;
            this.btn_banve.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_banve.ImageOptions.Image")));
            this.btn_banve.Name = "btn_banve";
            this.btn_banve.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_chieunghi
            // 
            this.btn_chieunghi.Caption = "Đối với chiếu nghỉ";
            this.btn_chieunghi.Id = 9;
            this.btn_chieunghi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_chieunghi.ImageOptions.SvgImage")));
            this.btn_chieunghi.Name = "btn_chieunghi";
            this.btn_chieunghi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_chieunghi_ItemClick);
            // 
            // btn_tinhthepdai
            // 
            this.btn_tinhthepdai.Caption = "Tính toán thép đai";
            this.btn_tinhthepdai.Id = 10;
            this.btn_tinhthepdai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_tinhthepdai.ImageOptions.SvgImage")));
            this.btn_tinhthepdai.Name = "btn_tinhthepdai";
            this.btn_tinhthepdai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_tinhthepdai_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Tính toán bản chiếu nghỉ";
            this.barButtonItem3.Id = 11;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nhập liệu và tính toán";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.ImageOptions.Image")));
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_vatlieucoththep);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_tinhtoantaitrong);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 1043);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1370, 30);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 1073);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_vatlieucoththep;
        private DevExpress.XtraBars.BarButtonItem btn_tinhtoantaitrong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btn_hoattai;
        private DevExpress.XtraBars.BarButtonItem btn_tinhnoiluc;
        private DevExpress.XtraBars.BarButtonItem btn_huongdansudung;
        private DevExpress.XtraBars.BarButtonItem btn_banve;
        private DevExpress.XtraBars.BarButtonItem btn_chieunghi;
        public System.Windows.Forms.Panel pn_main;
        private DevExpress.XtraBars.BarButtonItem btn_tinhthepdai;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}

