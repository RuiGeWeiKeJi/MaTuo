namespace ProductionErp
{
    partial class FormSingRowTable
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lupProduct = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lupGoods = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SRT001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SRT002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SRT003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SRT004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SRT005 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SRT006 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SRT007 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SRT008 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SRT009 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.lupUser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.RAA021 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupGoods.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 33);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.lupProduct);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.lupGoods);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1240, 414);
            this.splitContainerControl1.SplitterPosition = 30;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lupProduct
            // 
            this.lupProduct.Location = new System.Drawing.Point(367, 7);
            this.lupProduct.Name = "lupProduct";
            this.lupProduct.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lupProduct.Properties.Appearance.Options.UseFont = true;
            this.lupProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupProduct.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRT003", 100, "品号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRT004", 100, "品名"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRT005", 100, "规格")});
            this.lupProduct.Properties.NullText = "";
            this.lupProduct.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lupProduct.Properties.PopupWidth = 500;
            this.lupProduct.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lupProduct.Size = new System.Drawing.Size(176, 20);
            this.lupProduct.TabIndex = 14;
            this.lupProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lupProduct_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(312, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "品号：";
            // 
            // lupGoods
            // 
            this.lupGoods.Location = new System.Drawing.Point(80, 7);
            this.lupGoods.Name = "lupGoods";
            this.lupGoods.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lupGoods.Properties.Appearance.Options.UseFont = true;
            this.lupGoods.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupGoods.Properties.NullText = "";
            this.lupGoods.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lupGoods.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lupGoods.Properties.ShowHeader = false;
            this.lupGoods.Size = new System.Drawing.Size(176, 20);
            this.lupGoods.TabIndex = 12;
            this.lupGoods.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lupGoods_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "工单号：";
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
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3});
            this.gridControl1.Size = new System.Drawing.Size(1240, 372);
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
            this.SRT001,
            this.SRT002,
            this.SRT003,
            this.SRT004,
            this.SRT005,
            this.SRT006,
            this.SRT007,
            this.SRT008,
            this.SRT009,
            this.idx,
            this.RAA021});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 45;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // SRT001
            // 
            this.SRT001.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT001.AppearanceCell.Options.UseFont = true;
            this.SRT001.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT001.AppearanceHeader.Options.UseFont = true;
            this.SRT001.Caption = "排单号";
            this.SRT001.FieldName = "SRT001";
            this.SRT001.Name = "SRT001";
            this.SRT001.Visible = true;
            this.SRT001.VisibleIndex = 1;
            this.SRT001.Width = 113;
            // 
            // SRT002
            // 
            this.SRT002.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT002.AppearanceCell.Options.UseFont = true;
            this.SRT002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT002.AppearanceHeader.Options.UseFont = true;
            this.SRT002.Caption = "工单号";
            this.SRT002.FieldName = "SRT002";
            this.SRT002.Name = "SRT002";
            this.SRT002.OptionsColumn.AllowEdit = false;
            this.SRT002.Visible = true;
            this.SRT002.VisibleIndex = 2;
            this.SRT002.Width = 107;
            // 
            // SRT003
            // 
            this.SRT003.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT003.AppearanceCell.Options.UseFont = true;
            this.SRT003.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT003.AppearanceHeader.Options.UseFont = true;
            this.SRT003.Caption = "品号";
            this.SRT003.FieldName = "SRT003";
            this.SRT003.Name = "SRT003";
            this.SRT003.OptionsColumn.AllowEdit = false;
            this.SRT003.Visible = true;
            this.SRT003.VisibleIndex = 3;
            this.SRT003.Width = 134;
            // 
            // SRT004
            // 
            this.SRT004.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT004.AppearanceCell.Options.UseFont = true;
            this.SRT004.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT004.AppearanceHeader.Options.UseFont = true;
            this.SRT004.Caption = "品名";
            this.SRT004.FieldName = "SRT004";
            this.SRT004.Name = "SRT004";
            this.SRT004.OptionsColumn.AllowEdit = false;
            this.SRT004.Visible = true;
            this.SRT004.VisibleIndex = 4;
            this.SRT004.Width = 106;
            // 
            // SRT005
            // 
            this.SRT005.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT005.AppearanceCell.Options.UseFont = true;
            this.SRT005.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT005.AppearanceHeader.Options.UseFont = true;
            this.SRT005.Caption = "规格";
            this.SRT005.FieldName = "SRT005";
            this.SRT005.Name = "SRT005";
            this.SRT005.OptionsColumn.AllowEdit = false;
            this.SRT005.Visible = true;
            this.SRT005.VisibleIndex = 5;
            this.SRT005.Width = 117;
            // 
            // SRT006
            // 
            this.SRT006.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT006.AppearanceCell.Options.UseFont = true;
            this.SRT006.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT006.AppearanceHeader.Options.UseFont = true;
            this.SRT006.Caption = "数量";
            this.SRT006.FieldName = "SRT006";
            this.SRT006.Name = "SRT006";
            this.SRT006.OptionsColumn.AllowEdit = false;
            this.SRT006.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SRT006", "{0}")});
            this.SRT006.Visible = true;
            this.SRT006.VisibleIndex = 6;
            this.SRT006.Width = 77;
            // 
            // SRT007
            // 
            this.SRT007.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT007.AppearanceCell.Options.UseFont = true;
            this.SRT007.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT007.AppearanceHeader.Options.UseFont = true;
            this.SRT007.Caption = "定子条码";
            this.SRT007.FieldName = "SRT007";
            this.SRT007.Name = "SRT007";
            this.SRT007.Visible = true;
            this.SRT007.VisibleIndex = 8;
            this.SRT007.Width = 72;
            // 
            // SRT008
            // 
            this.SRT008.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT008.AppearanceCell.Options.UseFont = true;
            this.SRT008.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT008.AppearanceHeader.Options.UseFont = true;
            this.SRT008.Caption = "制动器条码";
            this.SRT008.FieldName = "SRT008";
            this.SRT008.Name = "SRT008";
            this.SRT008.Visible = true;
            this.SRT008.VisibleIndex = 9;
            this.SRT008.Width = 78;
            // 
            // SRT009
            // 
            this.SRT009.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT009.AppearanceCell.Options.UseFont = true;
            this.SRT009.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.SRT009.AppearanceHeader.Options.UseFont = true;
            this.SRT009.Caption = "总装配条码";
            this.SRT009.FieldName = "SRT009";
            this.SRT009.Name = "SRT009";
            this.SRT009.Visible = true;
            this.SRT009.VisibleIndex = 10;
            this.SRT009.Width = 91;
            // 
            // idx
            // 
            this.idx.Caption = "编号";
            this.idx.FieldName = "idx";
            this.idx.Name = "idx";
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
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // RAA021
            // 
            this.RAA021.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.RAA021.AppearanceCell.Options.UseFont = true;
            this.RAA021.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.RAA021.AppearanceHeader.Options.UseFont = true;
            this.RAA021.Caption = "备注";
            this.RAA021.FieldName = "RAA021";
            this.RAA021.Name = "RAA021";
            this.RAA021.ToolTip = "工单单头";
            this.RAA021.Visible = true;
            this.RAA021.VisibleIndex = 7;
            this.RAA021.Width = 124;
            // 
            // FormSingRowTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 447);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormSingRowTable";
            this.Text = "排单表";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lupProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupGoods.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress . XtraEditors . SplitContainerControl splitContainerControl1;
        private DevExpress . XtraEditors . LookUpEdit lupGoods;
        private System . Windows . Forms . Label label1;
        private DevExpress . XtraEditors . LookUpEdit lupProduct;
        private System . Windows . Forms . Label label2;
        private DevExpress . XtraGrid . GridControl gridControl1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView1;
        private DevExpress . XtraGrid . Columns . GridColumn SRT002;
        private DevExpress . XtraGrid . Columns . GridColumn SRT003;
        private DevExpress . XtraGrid . Columns . GridColumn SRT004;
        private DevExpress . XtraGrid . Columns . GridColumn SRT005;
        private DevExpress . XtraGrid . Columns . GridColumn SRT006;
        private DevExpress . XtraGrid . Columns . GridColumn SRT007;
        private DevExpress . XtraEditors . Repository . RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress . XtraEditors . Repository . RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress . XtraEditors . Repository . RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress . XtraEditors . Repository . RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress . XtraEditors . Repository . RepositoryItemLookUpEdit lupUser;
        private DevExpress . XtraEditors . Repository . RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress . XtraEditors . Repository . RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView2;
        private DevExpress . XtraGrid . Columns . GridColumn SRT001;
        private DevExpress . XtraScheduler . SchedulerStorage schedulerStorage1;
        private DevExpress . XtraGrid . Columns . GridColumn SRT008;
        private DevExpress . XtraGrid . Columns . GridColumn SRT009;
        private DevExpress . XtraGrid . Columns . GridColumn idx;
        private DevExpress.XtraGrid.Columns.GridColumn RAA021;
    }
}