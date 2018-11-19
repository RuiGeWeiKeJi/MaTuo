namespace ProductionErp
{
    partial class FormMain
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
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarBase = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemPower = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemProgram = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemConn = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemArt = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemArtPower = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemWindBase = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemSingleRow = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemSingRowTable = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemWinding = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemStatorCoil = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemBrake = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemGeneralAssembly = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemStorageMaterial = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarBase;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarBase});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemPower,
            this.navBarItemProgram,
            this.navBarItemConn,
            this.navBarItemArt,
            this.navBarItemArtPower,
            this.navBarItemWindBase,
            this.navBarItemSingleRow,
            this.navBarItemSingRowTable,
            this.navBarItemWinding,
            this.navBarItemStatorCoil,
            this.navBarItemBrake,
            this.navBarItemGeneralAssembly,
            this.navBarItemStorageMaterial});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 280;
            this.navBarControl1.Size = new System.Drawing.Size(280, 444);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Metropolis");
            // 
            // navBarBase
            // 
            this.navBarBase.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarBase.Appearance.Options.UseFont = true;
            this.navBarBase.Caption = "基础信息";
            this.navBarBase.Expanded = true;
            this.navBarBase.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPower),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemProgram),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemConn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemArt),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemArtPower),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemWindBase),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSingleRow),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSingRowTable),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemWinding),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemStatorCoil),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemBrake),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemGeneralAssembly),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemStorageMaterial)});
            this.navBarBase.Name = "navBarBase";
            // 
            // navBarItemPower
            // 
            this.navBarItemPower.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemPower.Appearance.Options.UseFont = true;
            this.navBarItemPower.Caption = "权限设置";
            this.navBarItemPower.Name = "navBarItemPower";
            this.navBarItemPower.Tag = "FormPower";
            this.navBarItemPower.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemPower_LinkClicked);
            // 
            // navBarItemProgram
            // 
            this.navBarItemProgram.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItemProgram.Appearance.Options.UseFont = true;
            this.navBarItemProgram.Caption = "程序管控";
            this.navBarItemProgram.Name = "navBarItemProgram";
            this.navBarItemProgram.Tag = "";
            this.navBarItemProgram.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemProgram_LinkClicked);
            // 
            // navBarItemConn
            // 
            this.navBarItemConn.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.navBarItemConn.Appearance.Options.UseFont = true;
            this.navBarItemConn.Caption = "连接配置";
            this.navBarItemConn.Name = "navBarItemConn";
            this.navBarItemConn.Tag = "Connection . Form1";
            this.navBarItemConn.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemConn_LinkClicked);
            // 
            // navBarItemArt
            // 
            this.navBarItemArt.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.navBarItemArt.Appearance.Options.UseFont = true;
            this.navBarItemArt.Caption = "工艺信息";
            this.navBarItemArt.Name = "navBarItemArt";
            this.navBarItemArt.Tag = "FormArt";
            this.navBarItemArt.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemArt_LinkClicked);
            // 
            // navBarItemArtPower
            // 
            this.navBarItemArtPower.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.navBarItemArtPower.Appearance.Options.UseFont = true;
            this.navBarItemArtPower.Caption = "工艺权限";
            this.navBarItemArtPower.Name = "navBarItemArtPower";
            this.navBarItemArtPower.Tag = "FormArtPower";
            this.navBarItemArtPower.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemArtPower_LinkClicked);
            // 
            // navBarItemWindBase
            // 
            this.navBarItemWindBase.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.navBarItemWindBase.Appearance.Options.UseFont = true;
            this.navBarItemWindBase.Caption = "绕线基础数据设置";
            this.navBarItemWindBase.Name = "navBarItemWindBase";
            this.navBarItemWindBase.Tag = "FormWindBase";
            this.navBarItemWindBase.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemWindBase_LinkClicked);
            // 
            // navBarItemSingleRow
            // 
            this.navBarItemSingleRow.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.navBarItemSingleRow.Appearance.Options.UseFont = true;
            this.navBarItemSingleRow.Caption = "排单";
            this.navBarItemSingleRow.Name = "navBarItemSingleRow";
            this.navBarItemSingleRow.Tag = "FormSingleRow";
            this.navBarItemSingleRow.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemSingleRow_LinkClicked);
            // 
            // navBarItemSingRowTable
            // 
            this.navBarItemSingRowTable.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.navBarItemSingRowTable.Appearance.Options.UseFont = true;
            this.navBarItemSingRowTable.Caption = "排单表";
            this.navBarItemSingRowTable.Name = "navBarItemSingRowTable";
            this.navBarItemSingRowTable.Tag = "FormSingRowTable";
            this.navBarItemSingRowTable.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemSingRowTable_LinkClicked);
            // 
            // navBarItemWinding
            // 
            this.navBarItemWinding.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.navBarItemWinding.Appearance.Options.UseFont = true;
            this.navBarItemWinding.Caption = "绕线表单";
            this.navBarItemWinding.Name = "navBarItemWinding";
            this.navBarItemWinding.Tag = "FormWinding";
            this.navBarItemWinding.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemWinding_LinkClicked);
            // 
            // navBarItemStatorCoil
            // 
            this.navBarItemStatorCoil.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.navBarItemStatorCoil.Appearance.Options.UseFont = true;
            this.navBarItemStatorCoil.Caption = "定子线圈组装";
            this.navBarItemStatorCoil.Name = "navBarItemStatorCoil";
            this.navBarItemStatorCoil.Tag = "FormStatorCoil";
            this.navBarItemStatorCoil.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemStatorCoil_LinkClicked);
            // 
            // navBarItemBrake
            // 
            this.navBarItemBrake.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.navBarItemBrake.Appearance.Options.UseFont = true;
            this.navBarItemBrake.Caption = "制动器组装";
            this.navBarItemBrake.Name = "navBarItemBrake";
            this.navBarItemBrake.Tag = "FormBrake";
            this.navBarItemBrake.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemBrake_LinkClicked);
            // 
            // navBarItemGeneralAssembly
            // 
            this.navBarItemGeneralAssembly.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.navBarItemGeneralAssembly.Appearance.Options.UseFont = true;
            this.navBarItemGeneralAssembly.Caption = "总装配";
            this.navBarItemGeneralAssembly.Name = "navBarItemGeneralAssembly";
            this.navBarItemGeneralAssembly.Tag = "FormGeneralAssembly";
            this.navBarItemGeneralAssembly.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemGeneralAssembly_LinkClicked);
            // 
            // navBarItemStorageMaterial
            // 
            this.navBarItemStorageMaterial.Appearance.Font = new System.Drawing.Font("宋体", 10.5F);
            this.navBarItemStorageMaterial.Appearance.Options.UseFont = true;
            this.navBarItemStorageMaterial.Caption = "入库材料条码管理程序";
            this.navBarItemStorageMaterial.Name = "navBarItemStorageMaterial";
            this.navBarItemStorageMaterial.Tag = "FormStorageMaterial";
            this.navBarItemStorageMaterial.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemStorageMaterial_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 444);
            this.Controls.Add(this.navBarControl1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "浙江玛拓驱动设备有限公司";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress . XtraNavBar . NavBarControl navBarControl1;
        private DevExpress . XtraNavBar . NavBarGroup navBarBase;
        private DevExpress . XtraBars . PopupMenu popupMenu1;
        private DevExpress . XtraNavBar . NavBarItem navBarItemPower;
        private DevExpress . XtraNavBar . NavBarItem navBarItemProgram;
        private DevExpress . XtraNavBar . NavBarItem navBarItemConn;
        private DevExpress . XtraNavBar . NavBarItem navBarItemArt;
        private DevExpress . XtraNavBar . NavBarItem navBarItemArtPower;
        private DevExpress . XtraNavBar . NavBarItem navBarItemWindBase;
        private DevExpress . XtraNavBar . NavBarItem navBarItemSingleRow;
        private DevExpress . XtraNavBar . NavBarItem navBarItemSingRowTable;
        private DevExpress . XtraNavBar . NavBarItem navBarItemWinding;
        private DevExpress . XtraNavBar . NavBarItem navBarItemStatorCoil;
        private DevExpress . XtraNavBar . NavBarItem navBarItemBrake;
        private DevExpress . XtraNavBar . NavBarItem navBarItemGeneralAssembly;
        private DevExpress . XtraNavBar . NavBarItem navBarItemStorageMaterial;
    }
}