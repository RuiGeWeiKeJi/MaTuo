namespace ProductionErp
{
    partial class FormWindBase
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lupGoods = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.WIB001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.secUser = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.WIB002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB005 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB006 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB007 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB008 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB009 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB010 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB011 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB012 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB013 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.lupUser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.wait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.WIB00101 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB00201 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WIB00301 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupGoods.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 26);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.lupGoods);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1235, 434);
            this.splitContainerControl1.SplitterPosition = 38;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lupGoods
            // 
            this.lupGoods.Location = new System.Drawing.Point(109, 9);
            this.lupGoods.Name = "lupGoods";
            this.lupGoods.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lupGoods.Properties.Appearance.Options.UseFont = true;
            this.lupGoods.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupGoods.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WIB001", 35, "品号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WIB002", 55, "品名"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WIB003", "规格")});
            this.lupGoods.Properties.NullText = "";
            this.lupGoods.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lupGoods.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lupGoods.Size = new System.Drawing.Size(176, 20);
            this.lupGoods.TabIndex = 10;
            this.lupGoods.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lupGoods_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "商品信息：";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.lupUser,
            this.repositoryItemComboBox2,
            this.repositoryItemGridLookUpEdit1,
            this.secUser});
            this.gridControl1.Size = new System.Drawing.Size(1235, 384);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControl1_KeyPress);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WIB001,
            this.WIB002,
            this.WIB003,
            this.WIB004,
            this.idx,
            this.WIB005,
            this.WIB006,
            this.WIB007,
            this.WIB008,
            this.WIB009,
            this.WIB010,
            this.WIB011,
            this.WIB012,
            this.WIB013});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 45;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // WIB001
            // 
            this.WIB001.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB001.AppearanceCell.Options.UseFont = true;
            this.WIB001.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB001.AppearanceHeader.Options.UseFont = true;
            this.WIB001.Caption = "品号";
            this.WIB001.ColumnEdit = this.secUser;
            this.WIB001.FieldName = "WIB001";
            this.WIB001.Name = "WIB001";
            this.WIB001.Visible = true;
            this.WIB001.VisibleIndex = 0;
            this.WIB001.Width = 122;
            // 
            // secUser
            // 
            this.secUser.AutoHeight = false;
            this.secUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.secUser.Name = "secUser";
            this.secUser.NullText = "";
            this.secUser.View = this.repositoryItemSearchLookUpEdit1View;
            this.secUser.EditValueChanged += new System.EventHandler(this.secUser_EditValueChanged);
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Appearance.FocusedRow.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.repositoryItemSearchLookUpEdit1View.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.DarkSeaGreen;
            this.repositoryItemSearchLookUpEdit1View.Appearance.FocusedRow.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.repositoryItemSearchLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemSearchLookUpEdit1View.Appearance.FocusedRow.Options.UseBackColor = true;
            this.repositoryItemSearchLookUpEdit1View.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.repositoryItemSearchLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WIB00101,
            this.WIB00201,
            this.WIB00301});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsBehavior.Editable = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // WIB002
            // 
            this.WIB002.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB002.AppearanceCell.Options.UseFont = true;
            this.WIB002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB002.AppearanceHeader.Options.UseFont = true;
            this.WIB002.Caption = "品名";
            this.WIB002.FieldName = "WIB002";
            this.WIB002.Name = "WIB002";
            this.WIB002.OptionsColumn.AllowEdit = false;
            this.WIB002.Visible = true;
            this.WIB002.VisibleIndex = 1;
            this.WIB002.Width = 131;
            // 
            // WIB003
            // 
            this.WIB003.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB003.AppearanceCell.Options.UseFont = true;
            this.WIB003.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB003.AppearanceHeader.Options.UseFont = true;
            this.WIB003.Caption = "规格";
            this.WIB003.FieldName = "WIB003";
            this.WIB003.Name = "WIB003";
            this.WIB003.OptionsColumn.AllowEdit = false;
            this.WIB003.Visible = true;
            this.WIB003.VisibleIndex = 2;
            this.WIB003.Width = 141;
            // 
            // WIB004
            // 
            this.WIB004.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB004.AppearanceCell.Options.UseFont = true;
            this.WIB004.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB004.AppearanceHeader.Options.UseFont = true;
            this.WIB004.Caption = "匝数";
            this.WIB004.FieldName = "WIB004";
            this.WIB004.Name = "WIB004";
            this.WIB004.Visible = true;
            this.WIB004.VisibleIndex = 3;
            this.WIB004.Width = 48;
            // 
            // idx
            // 
            this.idx.Caption = "编号";
            this.idx.FieldName = "idx";
            this.idx.Name = "idx";
            // 
            // WIB005
            // 
            this.WIB005.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB005.AppearanceCell.Options.UseFont = true;
            this.WIB005.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB005.AppearanceHeader.Options.UseFont = true;
            this.WIB005.Caption = "组数";
            this.WIB005.FieldName = "WIB005";
            this.WIB005.Name = "WIB005";
            this.WIB005.Visible = true;
            this.WIB005.VisibleIndex = 4;
            this.WIB005.Width = 47;
            // 
            // WIB006
            // 
            this.WIB006.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB006.AppearanceCell.Options.UseFont = true;
            this.WIB006.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB006.AppearanceHeader.Options.UseFont = true;
            this.WIB006.Caption = "绕线模号";
            this.WIB006.FieldName = "WIB006";
            this.WIB006.Name = "WIB006";
            this.WIB006.Visible = true;
            this.WIB006.VisibleIndex = 5;
            // 
            // WIB007
            // 
            this.WIB007.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB007.AppearanceCell.Options.UseFont = true;
            this.WIB007.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB007.AppearanceHeader.Options.UseFont = true;
            this.WIB007.Caption = "绕线模数量";
            this.WIB007.FieldName = "WIB007";
            this.WIB007.Name = "WIB007";
            this.WIB007.Visible = true;
            this.WIB007.VisibleIndex = 6;
            this.WIB007.Width = 80;
            // 
            // WIB008
            // 
            this.WIB008.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB008.AppearanceCell.Options.UseFont = true;
            this.WIB008.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB008.AppearanceHeader.Options.UseFont = true;
            this.WIB008.Caption = "软管号";
            this.WIB008.FieldName = "WIB008";
            this.WIB008.Name = "WIB008";
            this.WIB008.Visible = true;
            this.WIB008.VisibleIndex = 7;
            // 
            // WIB009
            // 
            this.WIB009.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB009.AppearanceCell.Options.UseFont = true;
            this.WIB009.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB009.AppearanceHeader.Options.UseFont = true;
            this.WIB009.Caption = "线规";
            this.WIB009.FieldName = "WIB009";
            this.WIB009.Name = "WIB009";
            this.WIB009.Visible = true;
            this.WIB009.VisibleIndex = 8;
            this.WIB009.Width = 72;
            // 
            // WIB010
            // 
            this.WIB010.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB010.AppearanceCell.Options.UseFont = true;
            this.WIB010.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB010.AppearanceHeader.Options.UseFont = true;
            this.WIB010.Caption = "额定电压";
            this.WIB010.FieldName = "WIB010";
            this.WIB010.Name = "WIB010";
            this.WIB010.Visible = true;
            this.WIB010.VisibleIndex = 9;
            // 
            // WIB011
            // 
            this.WIB011.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB011.AppearanceCell.Options.UseFont = true;
            this.WIB011.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB011.AppearanceHeader.Options.UseFont = true;
            this.WIB011.Caption = "并联路数";
            this.WIB011.FieldName = "WIB011";
            this.WIB011.Name = "WIB011";
            this.WIB011.Visible = true;
            this.WIB011.VisibleIndex = 10;
            // 
            // WIB012
            // 
            this.WIB012.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB012.AppearanceCell.Options.UseFont = true;
            this.WIB012.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB012.AppearanceHeader.Options.UseFont = true;
            this.WIB012.Caption = "引出线规格(平方)";
            this.WIB012.FieldName = "WIB012";
            this.WIB012.Name = "WIB012";
            this.WIB012.Visible = true;
            this.WIB012.VisibleIndex = 11;
            this.WIB012.Width = 122;
            // 
            // WIB013
            // 
            this.WIB013.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB013.AppearanceCell.Options.UseFont = true;
            this.WIB013.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB013.AppearanceHeader.Options.UseFont = true;
            this.WIB013.Caption = "引出线长度(根)";
            this.WIB013.FieldName = "WIB013";
            this.WIB013.Name = "WIB013";
            this.WIB013.Visible = true;
            this.WIB013.VisibleIndex = 12;
            this.WIB013.Width = 108;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "定子线圈",
            "制动器",
            "总装配"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // lupUser
            // 
            this.lupUser.AutoHeight = false;
            this.lupUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupUser.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WIB001", 100, "品号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WIB002", 100, "品名"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WIB003", 100, "规格")});
            this.lupUser.Name = "lupUser";
            this.lupUser.NullText = "";
            this.lupUser.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lupUser.PopupWidth = 800;
            this.lupUser.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lupUser.EditValueChanged += new System.EventHandler(this.lupUser_EditValueChanged);
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "确认线圈匝数",
            "确认线圈组数",
            "接头数量",
            "并联路数",
            "确认接头数量"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            this.repositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.ImmediatePopup = true;
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullText = "";
            this.repositoryItemGridLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick;
            this.repositoryItemGridLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemGridLookUpEdit1.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // wait
            // 
            this.wait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.wait.Appearance.Options.UseBackColor = true;
            this.wait.BarAnimationElementThickness = 2;
            this.wait.Caption = "请稍后";
            this.wait.Description = "数据加载中 ...";
            this.wait.Location = new System.Drawing.Point(494, 197);
            this.wait.LookAndFeel.UseDefaultLookAndFeel = false;
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(246, 66);
            this.wait.TabIndex = 35;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // WIB00101
            // 
            this.WIB00101.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WIB00101.AppearanceCell.Options.UseFont = true;
            this.WIB00101.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB00101.AppearanceHeader.Options.UseFont = true;
            this.WIB00101.Caption = "品号";
            this.WIB00101.FieldName = "WIB001";
            this.WIB00101.Name = "WIB00101";
            this.WIB00101.Visible = true;
            this.WIB00101.VisibleIndex = 0;
            // 
            // WIB00201
            // 
            this.WIB00201.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB00201.AppearanceCell.Options.UseFont = true;
            this.WIB00201.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB00201.AppearanceHeader.Options.UseFont = true;
            this.WIB00201.Caption = "品名";
            this.WIB00201.FieldName = "WIB002";
            this.WIB00201.Name = "WIB00201";
            this.WIB00201.Visible = true;
            this.WIB00201.VisibleIndex = 1;
            // 
            // WIB00301
            // 
            this.WIB00301.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB00301.AppearanceCell.Options.UseFont = true;
            this.WIB00301.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.WIB00301.AppearanceHeader.Options.UseFont = true;
            this.WIB00301.Caption = "规格";
            this.WIB00301.FieldName = "WIB003";
            this.WIB00301.Name = "WIB00301";
            this.WIB00301.Visible = true;
            this.WIB00301.VisibleIndex = 2;
            // 
            // FormWindBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 460);
            this.Controls.Add(this.wait);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormWindBase";
            this.Text = "绕线基础数据设置";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            this.Controls.SetChildIndex(this.wait, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lupGoods.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress . XtraEditors . SplitContainerControl splitContainerControl1;
        private DevExpress . XtraGrid . GridControl gridControl1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView1;
        private DevExpress . XtraGrid . Columns . GridColumn WIB001;
        private DevExpress . XtraEditors . Repository . RepositoryItemLookUpEdit lupUser;
        private DevExpress . XtraGrid . Columns . GridColumn WIB002;
        private DevExpress . XtraGrid . Columns . GridColumn WIB003;
        private DevExpress . XtraEditors . Repository . RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress . XtraGrid . Columns . GridColumn WIB004;
        private DevExpress . XtraEditors . Repository . RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress . XtraGrid . Columns . GridColumn idx;
        private DevExpress . XtraEditors . Repository . RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView2;
        private DevExpress . XtraWaitForm . ProgressPanel wait;
        private DevExpress . XtraGrid . Columns . GridColumn WIB005;
        private DevExpress . XtraGrid . Columns . GridColumn WIB006;
        private DevExpress . XtraGrid . Columns . GridColumn WIB007;
        private DevExpress . XtraGrid . Columns . GridColumn WIB008;
        private DevExpress . XtraGrid . Columns . GridColumn WIB009;
        private DevExpress . XtraGrid . Columns . GridColumn WIB010;
        private DevExpress . XtraGrid . Columns . GridColumn WIB011;
        private DevExpress . XtraGrid . Columns . GridColumn WIB012;
        private DevExpress . XtraGrid . Columns . GridColumn WIB013;
        private DevExpress . XtraEditors . LookUpEdit lupGoods;
        private System . Windows . Forms . Label label1;
        private System . ComponentModel . BackgroundWorker backgroundWorker1;
        private System . ComponentModel . BackgroundWorker backgroundWorker2;
        private DevExpress . XtraEditors . Repository . RepositoryItemSearchLookUpEdit secUser;
        private DevExpress . XtraGrid . Views . Grid . GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress . XtraGrid . Columns . GridColumn WIB00101;
        private DevExpress . XtraGrid . Columns . GridColumn WIB00201;
        private DevExpress . XtraGrid . Columns . GridColumn WIB00301;
    }
}