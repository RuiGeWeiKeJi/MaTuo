namespace ProductionErp
{
    partial class FormChild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components . Dispose ( );
            }
            base . Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChild));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.toolQuery = new DevExpress.XtraBars.BarButtonItem();
            this.toolAdd = new DevExpress.XtraBars.BarButtonItem();
            this.toolEdit = new DevExpress.XtraBars.BarButtonItem();
            this.toolDelete = new DevExpress.XtraBars.BarButtonItem();
            this.toolSave = new DevExpress.XtraBars.BarButtonItem();
            this.toolCancel = new DevExpress.XtraBars.BarButtonItem();
            this.toolPrint = new DevExpress.XtraBars.BarButtonItem();
            this.toolExport = new DevExpress.XtraBars.BarButtonItem();
            this.toolReview = new DevExpress.XtraBars.BarButtonItem();
            this.toolExamin = new DevExpress.XtraBars.BarButtonItem();
            this.toolCancellation = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMenu});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.toolQuery,
            this.toolAdd,
            this.toolEdit,
            this.toolDelete,
            this.toolSave,
            this.toolCancel,
            this.toolPrint,
            this.toolExport,
            this.barSubItem1,
            this.toolReview,
            this.toolExamin,
            this.toolCancellation});
            this.barManager1.MainMenu = this.barMenu;
            this.barManager1.MaxItemId = 12;
            // 
            // barMenu
            // 
            this.barMenu.BarAppearance.Disabled.Font = new System.Drawing.Font("宋体", 10.5F);
            this.barMenu.BarAppearance.Disabled.Options.UseFont = true;
            this.barMenu.BarAppearance.Hovered.Font = new System.Drawing.Font("宋体", 10.5F);
            this.barMenu.BarAppearance.Hovered.Options.UseFont = true;
            this.barMenu.BarAppearance.Normal.Font = new System.Drawing.Font("宋体", 10.5F);
            this.barMenu.BarAppearance.Normal.Options.UseFont = true;
            this.barMenu.BarAppearance.Pressed.Font = new System.Drawing.Font("宋体", 10.5F);
            this.barMenu.BarAppearance.Pressed.Options.UseFont = true;
            this.barMenu.BarName = "Main menu";
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.FloatLocation = new System.Drawing.Point(93, 157);
            this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.Caption | DevExpress.XtraBars.BarLinkUserDefines.PaintStyle))), this.toolQuery, "查询", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.toolAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.toolEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.toolDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.toolSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.toolCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.toolPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.toolExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.toolReview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.toolExamin, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.toolCancellation, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barMenu.OptionsBar.DrawBorder = false;
            this.barMenu.OptionsBar.DrawDragBorder = false;
            this.barMenu.OptionsBar.RotateWhenVertical = false;
            this.barMenu.OptionsBar.UseWholeRow = true;
            this.barMenu.Text = "Main menu";
            // 
            // toolQuery
            // 
            this.toolQuery.Caption = "查询";
            this.toolQuery.Id = 0;
            this.toolQuery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("toolQuery.ImageOptions.Image")));
            this.toolQuery.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("toolQuery.ImageOptions.LargeImage")));
            this.toolQuery.ImageOptions.LargeImageIndex = 0;
            this.toolQuery.Name = "toolQuery";
            this.toolQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.toolQuery_ItemClick);
            // 
            // toolAdd
            // 
            this.toolAdd.Caption = "新增";
            this.toolAdd.Id = 1;
            this.toolAdd.ImageOptions.Image = global::ProductionErp.Properties.Resources.add_16x16;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.toolAdd_ItemClick);
            // 
            // toolEdit
            // 
            this.toolEdit.Caption = "编辑";
            this.toolEdit.Id = 2;
            this.toolEdit.ImageOptions.Image = global::ProductionErp.Properties.Resources.edit_16x16;
            this.toolEdit.Name = "toolEdit";
            this.toolEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.toolEdit_ItemClick);
            // 
            // toolDelete
            // 
            this.toolDelete.Caption = "删除";
            this.toolDelete.Id = 3;
            this.toolDelete.ImageOptions.Image = global::ProductionErp.Properties.Resources.remove_16x16;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.toolDelete_ItemClick);
            // 
            // toolSave
            // 
            this.toolSave.Caption = "保存";
            this.toolSave.Id = 4;
            this.toolSave.ImageOptions.Image = global::ProductionErp.Properties.Resources.saveall_16x16;
            this.toolSave.Name = "toolSave";
            this.toolSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.toolSave_ItemClick);
            // 
            // toolCancel
            // 
            this.toolCancel.Caption = "取消";
            this.toolCancel.Id = 5;
            this.toolCancel.ImageOptions.Image = global::ProductionErp.Properties.Resources.cancel_16x16;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.toolCancel_ItemClick);
            // 
            // toolPrint
            // 
            this.toolPrint.Caption = "打印";
            this.toolPrint.Id = 6;
            this.toolPrint.ImageOptions.Image = global::ProductionErp.Properties.Resources.printer_16x16;
            this.toolPrint.Name = "toolPrint";
            this.toolPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.toolPrint_ItemClick);
            // 
            // toolExport
            // 
            this.toolExport.Caption = "导出";
            this.toolExport.Id = 7;
            this.toolExport.ImageOptions.Image = global::ProductionErp.Properties.Resources.export_16x16;
            this.toolExport.Name = "toolExport";
            this.toolExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.toolExport_ItemClick);
            // 
            // toolReview
            // 
            this.toolReview.Caption = "送审";
            this.toolReview.Id = 9;
            this.toolReview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("toolReview.ImageOptions.Image")));
            this.toolReview.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("toolReview.ImageOptions.LargeImage")));
            this.toolReview.Name = "toolReview";
            // 
            // toolExamin
            // 
            this.toolExamin.Caption = "审核";
            this.toolExamin.Id = 10;
            this.toolExamin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("toolExamin.ImageOptions.Image")));
            this.toolExamin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("toolExamin.ImageOptions.LargeImage")));
            this.toolExamin.Name = "toolExamin";
            // 
            // toolCancellation
            // 
            this.toolCancellation.Caption = "注销";
            this.toolCancellation.Id = 11;
            this.toolCancellation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("toolCancellation.ImageOptions.Image")));
            this.toolCancellation.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("toolCancellation.ImageOptions.LargeImage")));
            this.toolCancellation.Name = "toolCancellation";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1235, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 424);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1235, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1235, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 398);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 8;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 424);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormChild";
            this.Text = "FormChild";
            this.Load += new System.EventHandler(this.FormChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress . XtraBars . BarDockControl barDockControlTop;
        private DevExpress . XtraBars . BarDockControl barDockControlBottom;
        private DevExpress . XtraBars . BarDockControl barDockControlLeft;
        private DevExpress . XtraBars . BarDockControl barDockControlRight;
        private DevExpress . XtraBars . BarSubItem barSubItem1;
        public DevExpress . XtraBars . Bar barMenu;
        public DevExpress . XtraBars . BarButtonItem toolQuery;
        public DevExpress . XtraBars . BarButtonItem toolAdd;
        public DevExpress . XtraBars . BarButtonItem toolEdit;
        public DevExpress . XtraBars . BarButtonItem toolDelete;
        public DevExpress . XtraBars . BarButtonItem toolSave;
        public DevExpress . XtraBars . BarButtonItem toolCancel;
        public DevExpress . XtraBars . BarButtonItem toolPrint;
        public DevExpress . XtraBars . BarButtonItem toolExport;
        public DevExpress . XtraBars . BarManager barManager1;
        public DevExpress . XtraBars . BarButtonItem toolReview;
        public DevExpress . XtraBars . BarButtonItem toolExamin;
        public DevExpress . XtraBars . BarButtonItem toolCancellation;
    }
}