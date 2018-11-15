namespace ProductionErp
{
    partial class FormSingleRow
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
            this.btnGener = new DevExpress.XtraEditors.SimpleButton();
            this.cmbGoods = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.RAA001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RAA015 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEA002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEA057 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RAA018 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkOne = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.checkTwo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.checkTre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.lupUser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.wait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGoods.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.btnGener);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmbGoods);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1235, 417);
            this.splitContainerControl1.SplitterPosition = 45;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnGener
            // 
            this.btnGener.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnGener.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGener.Appearance.Options.UseBackColor = true;
            this.btnGener.Appearance.Options.UseFont = true;
            this.btnGener.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnGener.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnGener.Location = new System.Drawing.Point(350, 13);
            this.btnGener.Name = "btnGener";
            this.btnGener.Size = new System.Drawing.Size(93, 23);
            this.btnGener.TabIndex = 13;
            this.btnGener.Text = "生成排单";
            this.btnGener.Click += new System.EventHandler(this.btnGener_Click);
            // 
            // cmbGoods
            // 
            this.cmbGoods.Location = new System.Drawing.Point(95, 14);
            this.cmbGoods.MenuManager = this.barManager1;
            this.cmbGoods.Name = "cmbGoods";
            this.cmbGoods.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGoods.Properties.Appearance.Options.UseFont = true;
            this.cmbGoods.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGoods.Properties.Items.AddRange(new object[] {
            "定子",
            "制动器",
            "总装配",
            "全部"});
            this.cmbGoods.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbGoods.Size = new System.Drawing.Size(172, 20);
            this.cmbGoods.TabIndex = 12;
            this.cmbGoods.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbGoods_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "商品分类：";
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
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4});
            this.gridControl1.Size = new System.Drawing.Size(1235, 360);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RAA001,
            this.RAA015,
            this.DEA002,
            this.DEA057,
            this.RAA018,
            this.checkOne,
            this.checkTwo,
            this.checkTre});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 45;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // RAA001
            // 
            this.RAA001.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.RAA001.AppearanceCell.Options.UseFont = true;
            this.RAA001.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.RAA001.AppearanceHeader.Options.UseFont = true;
            this.RAA001.Caption = "工单号";
            this.RAA001.FieldName = "RAA001";
            this.RAA001.Name = "RAA001";
            this.RAA001.OptionsColumn.AllowEdit = false;
            this.RAA001.Visible = true;
            this.RAA001.VisibleIndex = 1;
            this.RAA001.Width = 116;
            // 
            // RAA015
            // 
            this.RAA015.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.RAA015.AppearanceCell.Options.UseFont = true;
            this.RAA015.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.RAA015.AppearanceHeader.Options.UseFont = true;
            this.RAA015.Caption = "品号";
            this.RAA015.FieldName = "RAA015";
            this.RAA015.Name = "RAA015";
            this.RAA015.OptionsColumn.AllowEdit = false;
            this.RAA015.Visible = true;
            this.RAA015.VisibleIndex = 2;
            this.RAA015.Width = 150;
            // 
            // DEA002
            // 
            this.DEA002.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.DEA002.AppearanceCell.Options.UseFont = true;
            this.DEA002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.DEA002.AppearanceHeader.Options.UseFont = true;
            this.DEA002.Caption = "品名";
            this.DEA002.FieldName = "DEA002";
            this.DEA002.Name = "DEA002";
            this.DEA002.OptionsColumn.AllowEdit = false;
            this.DEA002.Visible = true;
            this.DEA002.VisibleIndex = 3;
            this.DEA002.Width = 160;
            // 
            // DEA057
            // 
            this.DEA057.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.DEA057.AppearanceCell.Options.UseFont = true;
            this.DEA057.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.DEA057.AppearanceHeader.Options.UseFont = true;
            this.DEA057.Caption = "规格";
            this.DEA057.FieldName = "DEA057";
            this.DEA057.Name = "DEA057";
            this.DEA057.OptionsColumn.AllowEdit = false;
            this.DEA057.Visible = true;
            this.DEA057.VisibleIndex = 4;
            this.DEA057.Width = 150;
            // 
            // RAA018
            // 
            this.RAA018.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.RAA018.AppearanceCell.Options.UseFont = true;
            this.RAA018.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.RAA018.AppearanceHeader.Options.UseFont = true;
            this.RAA018.Caption = "数量";
            this.RAA018.FieldName = "RAA018";
            this.RAA018.Name = "RAA018";
            this.RAA018.OptionsColumn.AllowEdit = false;
            this.RAA018.Visible = true;
            this.RAA018.VisibleIndex = 5;
            this.RAA018.Width = 60;
            // 
            // checkOne
            // 
            this.checkOne.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.checkOne.AppearanceCell.Options.UseFont = true;
            this.checkOne.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.checkOne.AppearanceHeader.Options.UseFont = true;
            this.checkOne.Caption = "定子线圈排单";
            this.checkOne.ColumnEdit = this.repositoryItemCheckEdit1;
            this.checkOne.FieldName = "checkOne";
            this.checkOne.Name = "checkOne";
            this.checkOne.OptionsColumn.AllowEdit = false;
            this.checkOne.Visible = true;
            this.checkOne.VisibleIndex = 6;
            this.checkOne.Width = 122;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // checkTwo
            // 
            this.checkTwo.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.checkTwo.AppearanceCell.Options.UseFont = true;
            this.checkTwo.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.checkTwo.AppearanceHeader.Options.UseFont = true;
            this.checkTwo.Caption = "制动器排单";
            this.checkTwo.ColumnEdit = this.repositoryItemCheckEdit2;
            this.checkTwo.FieldName = "checkTwo";
            this.checkTwo.Name = "checkTwo";
            this.checkTwo.OptionsColumn.AllowEdit = false;
            this.checkTwo.Visible = true;
            this.checkTwo.VisibleIndex = 7;
            this.checkTwo.Width = 101;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 0;
            // 
            // checkTre
            // 
            this.checkTre.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.checkTre.AppearanceCell.Options.UseFont = true;
            this.checkTre.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.checkTre.AppearanceHeader.Options.UseFont = true;
            this.checkTre.Caption = "总装配排单";
            this.checkTre.ColumnEdit = this.repositoryItemCheckEdit3;
            this.checkTre.FieldName = "checkTre";
            this.checkTre.Name = "checkTre";
            this.checkTre.OptionsColumn.AllowEdit = false;
            this.checkTre.Visible = true;
            this.checkTre.VisibleIndex = 8;
            this.checkTre.Width = 124;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            this.repositoryItemCheckEdit3.ValueChecked = 1;
            this.repositoryItemCheckEdit3.ValueUnchecked = 0;
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
            this.wait.TabIndex = 36;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FormSingleRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 443);
            this.Controls.Add(this.wait);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormSingleRow";
            this.Text = "排单";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            this.Controls.SetChildIndex(this.wait, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbGoods.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
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
        private DevExpress . XtraGrid . Columns . GridColumn RAA015;
        private DevExpress . XtraEditors . Repository . RepositoryItemLookUpEdit lupUser;
        private DevExpress . XtraGrid . Columns . GridColumn DEA002;
        private DevExpress . XtraGrid . Columns . GridColumn DEA057;
        private DevExpress . XtraGrid . Columns . GridColumn RAA018;
        private DevExpress . XtraGrid . Columns . GridColumn checkOne;
        private DevExpress . XtraGrid . Columns . GridColumn checkTwo;
        private DevExpress . XtraGrid . Columns . GridColumn checkTre;
        private DevExpress . XtraEditors . Repository . RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress . XtraEditors . Repository . RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress . XtraEditors . Repository . RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView2;
        private DevExpress . XtraWaitForm . ProgressPanel wait;
        private System . Windows . Forms . Label label1;
        private DevExpress . XtraEditors . ComboBoxEdit cmbGoods;
        private DevExpress . XtraGrid . Columns . GridColumn RAA001;
        private DevExpress . XtraEditors . Repository . RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress . XtraEditors . Repository . RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress . XtraEditors . Repository . RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private System . ComponentModel . BackgroundWorker backgroundWorker1;
        private DevExpress . XtraEditors . SimpleButton btnGener;
        private DevExpress . XtraEditors . Repository . RepositoryItemCheckEdit repositoryItemCheckEdit4;
    }
}