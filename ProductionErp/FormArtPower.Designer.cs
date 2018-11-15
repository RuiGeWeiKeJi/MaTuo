namespace ProductionErp
{
    partial class FormArtPower
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ARP001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lupUser = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ARP002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ARP003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ARP004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.idx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lupPerson = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.wait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.resArt = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ARP00301 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ARP00401 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
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
            this.resArt});
            this.gridControl1.Size = new System.Drawing.Size(1059, 377);
            this.gridControl1.TabIndex = 5;
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
            this.ARP001,
            this.ARP002,
            this.ARP003,
            this.ARP004,
            this.idx});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 45;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // ARP001
            // 
            this.ARP001.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ARP001.AppearanceCell.Options.UseFont = true;
            this.ARP001.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ARP001.AppearanceHeader.Options.UseFont = true;
            this.ARP001.Caption = "人员编号";
            this.ARP001.ColumnEdit = this.lupUser;
            this.ARP001.FieldName = "ARP001";
            this.ARP001.Name = "ARP001";
            this.ARP001.Visible = true;
            this.ARP001.VisibleIndex = 0;
            this.ARP001.Width = 218;
            // 
            // lupUser
            // 
            this.lupUser.AutoHeight = false;
            this.lupUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupUser.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARP001", 80, "编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARP002", 80, "姓名")});
            this.lupUser.Name = "lupUser";
            this.lupUser.NullText = "";
            this.lupUser.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lupUser.PopupWidth = 200;
            this.lupUser.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lupUser.EditValueChanged += new System.EventHandler(this.lupUser_EditValueChanged);
            // 
            // ARP002
            // 
            this.ARP002.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ARP002.AppearanceCell.Options.UseFont = true;
            this.ARP002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ARP002.AppearanceHeader.Options.UseFont = true;
            this.ARP002.Caption = "人员姓名";
            this.ARP002.FieldName = "ARP002";
            this.ARP002.Name = "ARP002";
            this.ARP002.OptionsColumn.AllowEdit = false;
            this.ARP002.Visible = true;
            this.ARP002.VisibleIndex = 1;
            this.ARP002.Width = 290;
            // 
            // ARP003
            // 
            this.ARP003.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ARP003.AppearanceCell.Options.UseFont = true;
            this.ARP003.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ARP003.AppearanceHeader.Options.UseFont = true;
            this.ARP003.Caption = "工序内容";
            this.ARP003.ColumnEdit = this.resArt;
            this.ARP003.FieldName = "ARP003";
            this.ARP003.Name = "ARP003";
            this.ARP003.Visible = true;
            this.ARP003.VisibleIndex = 2;
            this.ARP003.Width = 350;
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
            // ARP004
            // 
            this.ARP004.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ARP004.AppearanceCell.Options.UseFont = true;
            this.ARP004.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ARP004.AppearanceHeader.Options.UseFont = true;
            this.ARP004.Caption = "工艺类型";
            this.ARP004.FieldName = "ARP004";
            this.ARP004.Name = "ARP004";
            this.ARP004.OptionsColumn.AllowEdit = false;
            this.ARP004.Visible = true;
            this.ARP004.VisibleIndex = 3;
            this.ARP004.Width = 330;
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
            // idx
            // 
            this.idx.Caption = "编号";
            this.idx.FieldName = "idx";
            this.idx.Name = "idx";
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
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 26);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.lupPerson);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1059, 428);
            this.splitContainerControl1.SplitterPosition = 39;
            this.splitContainerControl1.TabIndex = 6;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lupPerson
            // 
            this.lupPerson.Location = new System.Drawing.Point(95, 10);
            this.lupPerson.Name = "lupPerson";
            this.lupPerson.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lupPerson.Properties.Appearance.Options.UseFont = true;
            this.lupPerson.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupPerson.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARP001", 35, "编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARP002", 55, "姓名")});
            this.lupPerson.Properties.NullText = "";
            this.lupPerson.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lupPerson.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lupPerson.Size = new System.Drawing.Size(148, 20);
            this.lupPerson.TabIndex = 8;
            this.lupPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lupPerson_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "人员信息：";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // wait
            // 
            this.wait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.wait.Appearance.Options.UseBackColor = true;
            this.wait.BarAnimationElementThickness = 2;
            this.wait.Caption = "请稍后";
            this.wait.Description = "数据加载中 ...";
            this.wait.Location = new System.Drawing.Point(406, 194);
            this.wait.LookAndFeel.UseDefaultLookAndFeel = false;
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(246, 66);
            this.wait.TabIndex = 34;
            // 
            // resArt
            // 
            this.resArt.AutoHeight = false;
            this.resArt.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.resArt.Name = "resArt";
            this.resArt.NullText = "";
            this.resArt.View = this.repositoryItemSearchLookUpEdit1View;
            this.resArt.EditValueChanged += new System.EventHandler(this.resArt_EditValueChanged);
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
            this.ARP00301,
            this.ARP00401});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsBehavior.Editable = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ARP00301
            // 
            this.ARP00301.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARP00301.AppearanceCell.Options.UseFont = true;
            this.ARP00301.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ARP00301.AppearanceHeader.Options.UseFont = true;
            this.ARP00301.Caption = "工艺内容";
            this.ARP00301.FieldName = "ARP003";
            this.ARP00301.Name = "ARP00301";
            this.ARP00301.Visible = true;
            this.ARP00301.VisibleIndex = 0;
            // 
            // ARP00401
            // 
            this.ARP00401.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ARP00401.AppearanceCell.Options.UseFont = true;
            this.ARP00401.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ARP00401.AppearanceHeader.Options.UseFont = true;
            this.ARP00401.Caption = "工艺类型";
            this.ARP00401.FieldName = "ARP004";
            this.ARP00401.Name = "ARP00401";
            this.ARP00401.Visible = true;
            this.ARP00401.VisibleIndex = 1;
            // 
            // FormArtPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 454);
            this.Controls.Add(this.wait);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormArtPower";
            this.Text = "工艺权限";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            this.Controls.SetChildIndex(this.wait, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lupPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress . XtraGrid . GridControl gridControl1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView1;
        private DevExpress . XtraGrid . Columns . GridColumn ARP003;
        private DevExpress . XtraGrid . Columns . GridColumn ARP004;
        private DevExpress . XtraEditors . Repository . RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress . XtraGrid . Columns . GridColumn idx;
        private DevExpress . XtraGrid . Columns . GridColumn ARP001;
        private DevExpress . XtraGrid . Columns . GridColumn ARP002;
        private DevExpress . XtraEditors . Repository . RepositoryItemLookUpEdit lupUser;
        private DevExpress . XtraEditors . Repository . RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress . XtraEditors . SplitContainerControl splitContainerControl1;
        private DevExpress . XtraEditors . LookUpEdit lupPerson;
        private System . Windows . Forms . Label label1;
        private System . ComponentModel . BackgroundWorker backgroundWorker1;
        private DevExpress . XtraWaitForm . ProgressPanel wait;
        private DevExpress . XtraEditors . Repository . RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress . XtraGrid . Views . Grid . GridView repositoryItemGridLookUpEdit1View;
        private DevExpress . XtraEditors . Repository . RepositoryItemSearchLookUpEdit resArt;
        private DevExpress . XtraGrid . Views . Grid . GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress . XtraGrid . Columns . GridColumn ARP00301;
        private DevExpress . XtraGrid . Columns . GridColumn ARP00401;
    }
}