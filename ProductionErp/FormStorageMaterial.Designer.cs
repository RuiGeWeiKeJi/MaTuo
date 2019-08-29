namespace ProductionErp
{
    partial class FormStorageMaterial
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
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lupOrder = new DevExpress.XtraEditors.GridLookUpEdit();
            this.View1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lupProNum = new DevExpress.XtraEditors.GridLookUpEdit();
            this.View2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JDB001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JDB002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEA001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEA002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEA057 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JDB007 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JDA004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DGA002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEA004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.CodeInfo = new DevExpress.XtraEditors.TextEdit();
            this.txtEnd = new DevExpress.XtraEditors.TextEdit();
            this.txtStart = new DevExpress.XtraEditors.TextEdit();
            this.btnBatch = new System.Windows.Forms.Button();
            this.btnAddNewRow = new System.Windows.Forms.Button();
            this.waitPro = new DevExpress.XtraWaitForm.ProgressPanel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idx_one = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STM001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STM002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STM003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STM004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STM005 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STM006 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STM007 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lupOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupProNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 33);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1235, 426);
            this.splitContainerControl1.SplitterPosition = 187;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.btnClear);
            this.splitContainerControl2.Panel1.Controls.Add(this.label2);
            this.splitContainerControl2.Panel1.Controls.Add(this.label1);
            this.splitContainerControl2.Panel1.Controls.Add(this.lupOrder);
            this.splitContainerControl2.Panel1.Controls.Add(this.lupProNum);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.wait);
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1235, 187);
            this.splitContainerControl2.SplitterPosition = 34;
            this.splitContainerControl2.TabIndex = 6;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClear.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(726, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 28);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(434, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "品号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "进货单号：";
            // 
            // lupOrder
            // 
            this.lupOrder.Location = new System.Drawing.Point(95, 8);
            this.lupOrder.Name = "lupOrder";
            this.lupOrder.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lupOrder.Properties.Appearance.Options.UseFont = true;
            this.lupOrder.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lupOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupOrder.Properties.ImmediatePopup = true;
            this.lupOrder.Properties.NullText = "";
            this.lupOrder.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lupOrder.Properties.PopupView = this.View1;
            this.lupOrder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lupOrder.Size = new System.Drawing.Size(176, 20);
            this.lupOrder.TabIndex = 12;
            this.lupOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lupOrder_KeyPress);
            // 
            // View1
            // 
            this.View1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.View1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.View1.Name = "View1";
            this.View1.OptionsBehavior.Editable = false;
            this.View1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.View1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "品号";
            this.gridColumn1.FieldName = "JDB001";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "品名";
            this.gridColumn2.FieldName = "DEA002";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "规格";
            this.gridColumn3.FieldName = "DEA057";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // lupProNum
            // 
            this.lupProNum.Location = new System.Drawing.Point(489, 8);
            this.lupProNum.Name = "lupProNum";
            this.lupProNum.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lupProNum.Properties.Appearance.Options.UseFont = true;
            this.lupProNum.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lupProNum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupProNum.Properties.ImmediatePopup = true;
            this.lupProNum.Properties.NullText = "";
            this.lupProNum.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.lupProNum.Properties.PopupView = this.View2;
            this.lupProNum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lupProNum.Size = new System.Drawing.Size(176, 20);
            this.lupProNum.TabIndex = 14;
            this.lupProNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lupProNum_KeyPress);
            // 
            // View2
            // 
            this.View2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5});
            this.View2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.View2.Name = "View2";
            this.View2.OptionsBehavior.Editable = false;
            this.View2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.View2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "品号";
            this.gridColumn4.FieldName = "DEA001";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "品名";
            this.gridColumn5.FieldName = "DEA002";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // wait
            // 
            this.wait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.wait.Appearance.Options.UseBackColor = true;
            this.wait.BarAnimationElementThickness = 2;
            this.wait.Caption = "请稍后";
            this.wait.Description = "数据加载中 ...";
            this.wait.Location = new System.Drawing.Point(494, 37);
            this.wait.LookAndFeel.UseDefaultLookAndFeel = false;
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(246, 66);
            this.wait.TabIndex = 36;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1235, 141);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idx,
            this.JDB001,
            this.JDB002,
            this.DEA001,
            this.DEA002,
            this.DEA057,
            this.JDB007,
            this.JDA004,
            this.DGA002,
            this.DEA004});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 45;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // idx
            // 
            this.idx.Caption = "编号";
            this.idx.FieldName = "idx";
            this.idx.Name = "idx";
            // 
            // JDB001
            // 
            this.JDB001.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.JDB001.AppearanceCell.Options.UseFont = true;
            this.JDB001.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.JDB001.AppearanceHeader.Options.UseFont = true;
            this.JDB001.Caption = "进货单号";
            this.JDB001.FieldName = "JDB001";
            this.JDB001.Name = "JDB001";
            this.JDB001.Visible = true;
            this.JDB001.VisibleIndex = 0;
            this.JDB001.Width = 103;
            // 
            // JDB002
            // 
            this.JDB002.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.JDB002.AppearanceCell.Options.UseFont = true;
            this.JDB002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.JDB002.AppearanceHeader.Options.UseFont = true;
            this.JDB002.Caption = "序号";
            this.JDB002.FieldName = "JDB002";
            this.JDB002.Name = "JDB002";
            this.JDB002.Visible = true;
            this.JDB002.VisibleIndex = 1;
            this.JDB002.Width = 72;
            // 
            // DEA001
            // 
            this.DEA001.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.DEA001.AppearanceCell.Options.UseFont = true;
            this.DEA001.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.DEA001.AppearanceHeader.Options.UseFont = true;
            this.DEA001.Caption = "品号";
            this.DEA001.FieldName = "DEA001";
            this.DEA001.Name = "DEA001";
            this.DEA001.Visible = true;
            this.DEA001.VisibleIndex = 2;
            this.DEA001.Width = 152;
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
            this.DEA002.Visible = true;
            this.DEA002.VisibleIndex = 3;
            this.DEA002.Width = 162;
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
            this.DEA057.Visible = true;
            this.DEA057.VisibleIndex = 4;
            this.DEA057.Width = 156;
            // 
            // JDB007
            // 
            this.JDB007.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.JDB007.AppearanceCell.Options.UseFont = true;
            this.JDB007.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.JDB007.AppearanceHeader.Options.UseFont = true;
            this.JDB007.Caption = "数量";
            this.JDB007.FieldName = "JDB007";
            this.JDB007.Name = "JDB007";
            this.JDB007.Visible = true;
            this.JDB007.VisibleIndex = 5;
            this.JDB007.Width = 83;
            // 
            // JDA004
            // 
            this.JDA004.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.JDA004.AppearanceCell.Options.UseFont = true;
            this.JDA004.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.JDA004.AppearanceHeader.Options.UseFont = true;
            this.JDA004.Caption = "供应商编号";
            this.JDA004.FieldName = "JDA004";
            this.JDA004.Name = "JDA004";
            this.JDA004.Visible = true;
            this.JDA004.VisibleIndex = 7;
            this.JDA004.Width = 81;
            // 
            // DGA002
            // 
            this.DGA002.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.DGA002.AppearanceCell.Options.UseFont = true;
            this.DGA002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.DGA002.AppearanceHeader.Options.UseFont = true;
            this.DGA002.Caption = "供应商";
            this.DGA002.FieldName = "DGA002";
            this.DGA002.Name = "DGA002";
            this.DGA002.Visible = true;
            this.DGA002.VisibleIndex = 8;
            this.DGA002.Width = 120;
            // 
            // DEA004
            // 
            this.DEA004.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.DEA004.AppearanceCell.Options.UseFont = true;
            this.DEA004.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.DEA004.AppearanceHeader.Options.UseFont = true;
            this.DEA004.Caption = "商品信息条码编号";
            this.DEA004.FieldName = "DEA004";
            this.DEA004.Name = "DEA004";
            this.DEA004.Visible = true;
            this.DEA004.VisibleIndex = 6;
            this.DEA004.Width = 120;
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Horizontal = false;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.CodeInfo);
            this.splitContainerControl3.Panel1.Controls.Add(this.txtEnd);
            this.splitContainerControl3.Panel1.Controls.Add(this.txtStart);
            this.splitContainerControl3.Panel1.Controls.Add(this.btnBatch);
            this.splitContainerControl3.Panel1.Controls.Add(this.btnAddNewRow);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.waitPro);
            this.splitContainerControl3.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(1235, 227);
            this.splitContainerControl3.SplitterPosition = 43;
            this.splitContainerControl3.TabIndex = 37;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // CodeInfo
            // 
            this.CodeInfo.Location = new System.Drawing.Point(95, 13);
            this.CodeInfo.MenuManager = this.barManager1;
            this.CodeInfo.Name = "CodeInfo";
            this.CodeInfo.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeInfo.Properties.Appearance.Options.UseFont = true;
            this.CodeInfo.Size = new System.Drawing.Size(151, 20);
            this.CodeInfo.TabIndex = 4;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(737, 13);
            this.txtEnd.MenuManager = this.barManager1;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Properties.Appearance.Options.UseFont = true;
            this.txtEnd.Size = new System.Drawing.Size(151, 20);
            this.txtEnd.TabIndex = 3;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(556, 13);
            this.txtStart.MenuManager = this.barManager1;
            this.txtStart.Name = "txtStart";
            this.txtStart.Properties.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Properties.Appearance.Options.UseFont = true;
            this.txtStart.Size = new System.Drawing.Size(151, 20);
            this.txtStart.TabIndex = 2;
            // 
            // btnBatch
            // 
            this.btnBatch.AutoSize = true;
            this.btnBatch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBatch.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatch.Location = new System.Drawing.Point(425, 9);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(101, 28);
            this.btnBatch.TabIndex = 1;
            this.btnBatch.Text = "条码批量添加";
            this.btnBatch.UseVisualStyleBackColor = false;
            this.btnBatch.Click += new System.EventHandler(this.btnBatch_Click);
            // 
            // btnAddNewRow
            // 
            this.btnAddNewRow.AutoSize = true;
            this.btnAddNewRow.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddNewRow.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewRow.Location = new System.Drawing.Point(15, 9);
            this.btnAddNewRow.Name = "btnAddNewRow";
            this.btnAddNewRow.Size = new System.Drawing.Size(59, 28);
            this.btnAddNewRow.TabIndex = 0;
            this.btnAddNewRow.Text = "查询";
            this.btnAddNewRow.UseVisualStyleBackColor = false;
            this.btnAddNewRow.Click += new System.EventHandler(this.btnAddNewRow_Click);
            // 
            // waitPro
            // 
            this.waitPro.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.waitPro.Appearance.Options.UseBackColor = true;
            this.waitPro.BarAnimationElementThickness = 2;
            this.waitPro.Caption = "请稍后";
            this.waitPro.Description = "数据加载中 ...";
            this.waitPro.Location = new System.Drawing.Point(494, 40);
            this.waitPro.LookAndFeel.UseDefaultLookAndFeel = false;
            this.waitPro.Name = "waitPro";
            this.waitPro.Size = new System.Drawing.Size(246, 66);
            this.waitPro.TabIndex = 36;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1235, 172);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControl2_KeyPress);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.DarkSeaGreen;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idx_one,
            this.STM001,
            this.STM002,
            this.STM003,
            this.STM004,
            this.STM005,
            this.STM006,
            this.STM007});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.IndicatorWidth = 45;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.STM006, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView2.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView2_CustomDrawRowIndicator);
            // 
            // idx_one
            // 
            this.idx_one.Caption = "编号";
            this.idx_one.FieldName = "idx";
            this.idx_one.Name = "idx_one";
            // 
            // STM001
            // 
            this.STM001.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM001.AppearanceCell.Options.UseFont = true;
            this.STM001.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM001.AppearanceHeader.Options.UseFont = true;
            this.STM001.Caption = "进货单号";
            this.STM001.FieldName = "STM001";
            this.STM001.Name = "STM001";
            this.STM001.OptionsColumn.AllowEdit = false;
            this.STM001.Visible = true;
            this.STM001.VisibleIndex = 1;
            this.STM001.Width = 144;
            // 
            // STM002
            // 
            this.STM002.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM002.AppearanceCell.Options.UseFont = true;
            this.STM002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM002.AppearanceHeader.Options.UseFont = true;
            this.STM002.Caption = "序号";
            this.STM002.FieldName = "STM002";
            this.STM002.Name = "STM002";
            this.STM002.OptionsColumn.AllowEdit = false;
            this.STM002.Visible = true;
            this.STM002.VisibleIndex = 2;
            this.STM002.Width = 117;
            // 
            // STM003
            // 
            this.STM003.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM003.AppearanceCell.Options.UseFont = true;
            this.STM003.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM003.AppearanceHeader.Options.UseFont = true;
            this.STM003.Caption = "品号";
            this.STM003.FieldName = "STM003";
            this.STM003.Name = "STM003";
            this.STM003.OptionsColumn.AllowEdit = false;
            this.STM003.Visible = true;
            this.STM003.VisibleIndex = 3;
            this.STM003.Width = 132;
            // 
            // STM004
            // 
            this.STM004.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM004.AppearanceCell.Options.UseFont = true;
            this.STM004.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM004.AppearanceHeader.Options.UseFont = true;
            this.STM004.Caption = "品名";
            this.STM004.FieldName = "STM004";
            this.STM004.Name = "STM004";
            this.STM004.OptionsColumn.AllowEdit = false;
            this.STM004.Visible = true;
            this.STM004.VisibleIndex = 4;
            this.STM004.Width = 169;
            // 
            // STM005
            // 
            this.STM005.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM005.AppearanceCell.Options.UseFont = true;
            this.STM005.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM005.AppearanceHeader.Options.UseFont = true;
            this.STM005.Caption = "规格";
            this.STM005.FieldName = "STM005";
            this.STM005.Name = "STM005";
            this.STM005.OptionsColumn.AllowEdit = false;
            this.STM005.Visible = true;
            this.STM005.VisibleIndex = 5;
            this.STM005.Width = 119;
            // 
            // STM006
            // 
            this.STM006.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM006.AppearanceCell.Options.UseFont = true;
            this.STM006.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM006.AppearanceHeader.Options.UseFont = true;
            this.STM006.Caption = "条码";
            this.STM006.FieldName = "STM006";
            this.STM006.Name = "STM006";
            this.STM006.OptionsColumn.AllowEdit = false;
            this.STM006.Visible = true;
            this.STM006.VisibleIndex = 6;
            this.STM006.Width = 235;
            // 
            // STM007
            // 
            this.STM007.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM007.AppearanceCell.Options.UseFont = true;
            this.STM007.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.STM007.AppearanceHeader.Options.UseFont = true;
            this.STM007.Caption = "使用状态";
            this.STM007.FieldName = "STM007";
            this.STM007.Name = "STM007";
            this.STM007.Visible = true;
            this.STM007.VisibleIndex = 7;
            this.STM007.Width = 133;
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
            // FormStorageMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 459);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FormStorageMaterial";
            this.Text = "入库材料条码管理作业";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lupOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupProNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodeInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress . XtraEditors . SplitContainerControl splitContainerControl1;
        private DevExpress . XtraGrid . GridControl gridControl1;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView1;
        private DevExpress . XtraGrid . Columns . GridColumn idx;
        private DevExpress . XtraGrid . Columns . GridColumn JDB001;
        private DevExpress . XtraGrid . Columns . GridColumn JDB002;
        private DevExpress . XtraGrid . Columns . GridColumn DEA001;
        private DevExpress . XtraGrid . Columns . GridColumn DEA002;
        private DevExpress . XtraGrid . GridControl gridControl2;
        private DevExpress . XtraGrid . Views . Grid . GridView gridView2;
        private DevExpress . XtraGrid . Columns . GridColumn idx_one;
        private DevExpress . XtraGrid . Columns . GridColumn STM001;
        private DevExpress . XtraGrid . Columns . GridColumn STM002;
        private DevExpress . XtraGrid . Columns . GridColumn STM003;
        private DevExpress . XtraGrid . Columns . GridColumn STM004;
        private DevExpress . XtraGrid . Columns . GridColumn DEA057;
        private DevExpress . XtraGrid . Columns . GridColumn JDB007;
        private DevExpress . XtraGrid . Columns . GridColumn JDA004;
        private DevExpress . XtraGrid . Columns . GridColumn STM005;
        private DevExpress . XtraGrid . Columns . GridColumn STM006;
        private DevExpress . XtraGrid . Columns . GridColumn STM007;
        private DevExpress . XtraEditors . SplitContainerControl splitContainerControl2;
        private System . Windows . Forms . Label label1;
        private System . Windows . Forms . Label label2;
        private System . ComponentModel . BackgroundWorker backgroundWorker1;
        private DevExpress . XtraWaitForm . ProgressPanel wait;
        private DevExpress . XtraWaitForm . ProgressPanel waitPro;
        private System . ComponentModel . BackgroundWorker backgroundWorker2;
        private DevExpress . XtraEditors . SplitContainerControl splitContainerControl3;
        private System . Windows . Forms . Button btnAddNewRow;
        private System . Windows . Forms . Button btnBatch;
        private DevExpress . XtraEditors . TextEdit txtEnd;
        private DevExpress . XtraEditors . TextEdit txtStart;
        private DevExpress . XtraGrid . Columns . GridColumn DGA002;
        private DevExpress . XtraGrid . Columns . GridColumn DEA004;
        private DevExpress . XtraEditors . TextEdit CodeInfo;
        private DevExpress . XtraEditors . GridLookUpEdit lupOrder;
        private DevExpress . XtraGrid . Views . Grid . GridView View1;
        private DevExpress . XtraGrid . Columns . GridColumn gridColumn1;
        private DevExpress . XtraGrid . Columns . GridColumn gridColumn2;
        private DevExpress . XtraGrid . Columns . GridColumn gridColumn3;
        private DevExpress . XtraEditors . GridLookUpEdit lupProNum;
        private DevExpress . XtraGrid . Views . Grid . GridView View2;
        private DevExpress . XtraGrid . Columns . GridColumn gridColumn4;
        private DevExpress . XtraGrid . Columns . GridColumn gridColumn5;
        private System . Windows . Forms . Button btnClear;
    }
}