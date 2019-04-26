namespace ProductionErp
{
    partial class FormBrake
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSpace = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductNum = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BRB002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRB003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.BRB004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRB005 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.U0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resBut = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.idx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRB007 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRB008 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.lupUser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.editData = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BRB00701 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editOne = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.View1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BRB00702 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpace.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 33);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.txtCode);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtSpace);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtProductName);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtProductNum);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1235, 414);
            this.splitContainerControl1.SplitterPosition = 38;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(742, 8);
            this.txtCode.MenuManager = this.barManager1;
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Properties.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(141, 20);
            this.txtCode.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(694, 11);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 14);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "条码：";
            // 
            // txtSpace
            // 
            this.txtSpace.Location = new System.Drawing.Point(515, 8);
            this.txtSpace.MenuManager = this.barManager1;
            this.txtSpace.Name = "txtSpace";
            this.txtSpace.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpace.Properties.Appearance.Options.UseFont = true;
            this.txtSpace.Properties.ReadOnly = true;
            this.txtSpace.Size = new System.Drawing.Size(141, 20);
            this.txtSpace.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(467, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "规格：";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(278, 8);
            this.txtProductName.MenuManager = this.barManager1;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.Properties.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(141, 20);
            this.txtProductName.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(230, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "品名：";
            // 
            // txtProductNum
            // 
            this.txtProductNum.Location = new System.Drawing.Point(60, 8);
            this.txtProductNum.MenuManager = this.barManager1;
            this.txtProductNum.Name = "txtProductNum";
            this.txtProductNum.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductNum.Properties.Appearance.Options.UseFont = true;
            this.txtProductNum.Properties.ReadOnly = true;
            this.txtProductNum.Size = new System.Drawing.Size(141, 20);
            this.txtProductNum.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "品号：";
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
            this.repositoryItemDateEdit1,
            this.repositoryItemMemoEdit1,
            this.resBut,
            this.editData,
            this.editOne});
            this.gridControl1.Size = new System.Drawing.Size(1235, 364);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BRB002,
            this.BRB003,
            this.BRB004,
            this.BRB005,
            this.U0,
            this.idx,
            this.BRB007,
            this.BRB008});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 45;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEditForEditing);
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            // 
            // BRB002
            // 
            this.BRB002.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB002.AppearanceCell.Options.UseFont = true;
            this.BRB002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB002.AppearanceHeader.Options.UseFont = true;
            this.BRB002.Caption = "工步";
            this.BRB002.FieldName = "BRB002";
            this.BRB002.Name = "BRB002";
            this.BRB002.OptionsColumn.AllowEdit = false;
            this.BRB002.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.BRB002.Visible = true;
            this.BRB002.VisibleIndex = 0;
            this.BRB002.Width = 144;
            // 
            // BRB003
            // 
            this.BRB003.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB003.AppearanceCell.Options.UseFont = true;
            this.BRB003.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB003.AppearanceHeader.Options.UseFont = true;
            this.BRB003.Caption = "记录信息";
            this.BRB003.ColumnEdit = this.repositoryItemMemoEdit1;
            this.BRB003.FieldName = "BRB003";
            this.BRB003.Name = "BRB003";
            this.BRB003.OptionsColumn.AllowEdit = false;
            this.BRB003.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.BRB003.Visible = true;
            this.BRB003.VisibleIndex = 1;
            this.BRB003.Width = 457;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // BRB004
            // 
            this.BRB004.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB004.AppearanceCell.Options.UseFont = true;
            this.BRB004.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB004.AppearanceHeader.Options.UseFont = true;
            this.BRB004.Caption = "员工姓名";
            this.BRB004.FieldName = "BRB004";
            this.BRB004.Name = "BRB004";
            this.BRB004.OptionsColumn.AllowEdit = false;
            this.BRB004.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.BRB004.Visible = true;
            this.BRB004.VisibleIndex = 4;
            this.BRB004.Width = 115;
            // 
            // BRB005
            // 
            this.BRB005.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB005.AppearanceCell.Options.UseFont = true;
            this.BRB005.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB005.AppearanceHeader.Options.UseFont = true;
            this.BRB005.Caption = "填写时间";
            this.BRB005.FieldName = "BRB005";
            this.BRB005.Name = "BRB005";
            this.BRB005.OptionsColumn.AllowEdit = false;
            this.BRB005.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.BRB005.Visible = true;
            this.BRB005.VisibleIndex = 5;
            this.BRB005.Width = 122;
            // 
            // U0
            // 
            this.U0.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.U0.AppearanceCell.Options.UseFont = true;
            this.U0.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.U0.AppearanceHeader.Options.UseFont = true;
            this.U0.Caption = "签字";
            this.U0.ColumnEdit = this.resBut;
            this.U0.FieldName = "U0";
            this.U0.Name = "U0";
            this.U0.Visible = true;
            this.U0.VisibleIndex = 6;
            this.U0.Width = 62;
            // 
            // resBut
            // 
            this.resBut.AutoHeight = false;
            this.resBut.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "签字", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.resBut.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.resBut.Name = "resBut";
            this.resBut.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.resBut.Click += new System.EventHandler(this.resBut_Click);
            // 
            // idx
            // 
            this.idx.Caption = "编号";
            this.idx.FieldName = "idx";
            this.idx.Name = "idx";
            // 
            // BRB007
            // 
            this.BRB007.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB007.AppearanceCell.Options.UseFont = true;
            this.BRB007.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB007.AppearanceHeader.Options.UseFont = true;
            this.BRB007.Caption = "记录数据";
            this.BRB007.FieldName = "BRB007";
            this.BRB007.Name = "BRB007";
            this.BRB007.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.BRB007.Visible = true;
            this.BRB007.VisibleIndex = 2;
            this.BRB007.Width = 78;
            // 
            // BRB008
            // 
            this.BRB008.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB008.AppearanceCell.Options.UseFont = true;
            this.BRB008.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB008.AppearanceHeader.Options.UseFont = true;
            this.BRB008.Caption = "最终工时";
            this.BRB008.FieldName = "BRB008";
            this.BRB008.Name = "BRB008";
            this.BRB008.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.BRB008.Visible = true;
            this.BRB008.VisibleIndex = 3;
            this.BRB008.Width = 71;
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
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // editData
            // 
            this.editData.AutoHeight = false;
            this.editData.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.editData.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editData.Name = "editData";
            this.editData.NullText = "";
            this.editData.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.editData.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.editData.View = this.View;
            // 
            // View
            // 
            this.View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BRB00701});
            this.View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.View.Name = "View";
            this.View.OptionsBehavior.Editable = false;
            this.View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.View.OptionsView.ShowGroupPanel = false;
            // 
            // BRB00701
            // 
            this.BRB00701.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRB00701.AppearanceCell.Options.UseFont = true;
            this.BRB00701.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.BRB00701.AppearanceHeader.Options.UseFont = true;
            this.BRB00701.Caption = "漆包线厂家";
            this.BRB00701.FieldName = "BRB007";
            this.BRB00701.Name = "BRB00701";
            this.BRB00701.Visible = true;
            this.BRB00701.VisibleIndex = 0;
            // 
            // editOne
            // 
            this.editOne.AutoHeight = false;
            this.editOne.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.editOne.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editOne.ImmediatePopup = true;
            this.editOne.Name = "editOne";
            this.editOne.NullText = "";
            this.editOne.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.editOne.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.editOne.View = this.View1;
            // 
            // View1
            // 
            this.View1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BRB00702});
            this.View1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.View1.Name = "View1";
            this.View1.OptionsBehavior.Editable = false;
            this.View1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.View1.OptionsView.ShowGroupPanel = false;
            // 
            // BRB00702
            // 
            this.BRB00702.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRB00702.AppearanceCell.Options.UseFont = true;
            this.BRB00702.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BRB00702.AppearanceHeader.Options.UseFont = true;
            this.BRB00702.Caption = "减震垫供应商";
            this.BRB00702.FieldName = "BRB007";
            this.BRB00702.Name = "BRB00702";
            this.BRB00702.Visible = true;
            this.BRB00702.VisibleIndex = 0;
            // 
            // wait
            // 
            this.wait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.wait.Appearance.Options.UseBackColor = true;
            this.wait.BarAnimationElementThickness = 2;
            this.wait.Caption = "请稍后";
            this.wait.Description = "数据加载中 ...";
            this.wait.Location = new System.Drawing.Point(494, 179);
            this.wait.LookAndFeel.UseDefaultLookAndFeel = false;
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(246, 66);
            this.wait.TabIndex = 37;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FormBrake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 447);
            this.Controls.Add(this.wait);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormBrake";
            this.Text = "制动器组装";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            this.Controls.SetChildIndex(this.wait, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpace.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress . XtraEditors . SplitContainerControl splitContainerControl1;
        private DevExpress . XtraEditors . TextEdit txtProductName;
        private DevExpress . XtraEditors . LabelControl labelControl2;
        private DevExpress . XtraEditors . TextEdit txtProductNum;
        private DevExpress . XtraEditors . LabelControl labelControl1;
        private DevExpress . XtraEditors . TextEdit txtSpace;
        private DevExpress . XtraEditors . LabelControl labelControl3;
        private DevExpress . XtraEditors . TextEdit txtCode;
        private DevExpress . XtraEditors . LabelControl labelControl4;
        private DevExpress . XtraGrid . GridControl gridControl1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView1;
        private DevExpress . XtraGrid . Columns . GridColumn BRB002;
        private DevExpress . XtraGrid . Columns . GridColumn BRB003;
        private DevExpress . XtraGrid . Columns . GridColumn BRB004;
        private DevExpress . XtraGrid . Columns . GridColumn BRB005;
        private DevExpress . XtraEditors . Repository . RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress . XtraGrid . Columns . GridColumn idx;
        private DevExpress . XtraEditors . Repository . RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress . XtraEditors . Repository . RepositoryItemLookUpEdit lupUser;
        private DevExpress . XtraEditors . Repository . RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress . XtraEditors . Repository . RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView2;
        private DevExpress . XtraWaitForm . ProgressPanel wait;
        private System . ComponentModel . BackgroundWorker backgroundWorker1;
        private DevExpress . XtraEditors . Repository . RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress . XtraGrid . Columns . GridColumn U0;
        private DevExpress . XtraEditors . Repository . RepositoryItemButtonEdit resBut;
        private DevExpress . XtraGrid . Columns . GridColumn BRB007;
        private DevExpress . XtraGrid . Columns . GridColumn BRB008;
        private DevExpress . XtraEditors . Repository . RepositoryItemGridLookUpEdit editData;
        private DevExpress . XtraGrid . Views . Grid . GridView View;
        private DevExpress . XtraGrid . Columns . GridColumn BRB00701;
        private DevExpress . XtraEditors . Repository . RepositoryItemGridLookUpEdit editOne;
        private DevExpress . XtraGrid . Views . Grid . GridView View1;
        private DevExpress . XtraGrid . Columns . GridColumn BRB00702;
    }
}