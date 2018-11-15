using System . Data;
using System . Windows . Forms;

namespace ProductionErp
{
    public partial class FormMain :FormBase
    {
        public FormMain ( )
        {
            InitializeComponent ( );
        }

        private void FormMain_Load ( object sender ,System . EventArgs e )
        {
            CarpenterBll . Bll . MainBll _bll = new CarpenterBll . Bll . MainBll ( );
            UserLogin . userNum = CarpenterBll . UserInformation . UserNum = _bll . getUserNum ( );
            if ( string . IsNullOrEmpty ( UserLogin . userNum ) )
                this . Close ( );
            else
            {
                UserLogin . userName = CarpenterBll . UserInformation . UserName = _bll . getUserName ( UserLogin . userNum );
                ShowMenuByUser ( );
            }
        }

        #region premission setting

        void ShowMenuByUser ( )
        {
            Power ( navBarBase );
        }

        void Power ( DevExpress . XtraNavBar . NavBarGroup pnl )
        {
            if ( UserLogin . userNum . Equals ( "DS" ) )
                return;
            CarpenterBll . Bll . MainBll _bll = new CarpenterBll . Bll . MainBll ( );
            DataTable dt = _bll . GetDataTablePower ( UserLogin . userNum );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                foreach ( DevExpress . XtraNavBar . NavBarItem cn in pnl . NavBar . Items )
                {
                    if ( !string . IsNullOrEmpty ( cn . Tag . ToString ( ) ) )
                    {
                        if ( dt . Select ( "POW003='" + cn . Tag . ToString ( ) + "'" ) . Length < 1 )
                            cn . Visible = false;
                        else
                            cn . Visible = true;
                    }
                    else
                        cn . Visible = false;
                }
            }
            else
            {
                foreach ( DevExpress . XtraNavBar . NavBarItem cn in pnl . NavBar . Items )
                {
                    cn . Visible = false;
                }
            }
        }

        #endregion

        #region BarClick
        //程序管控
        private void navBarItemProgram_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            FormBase form = new FormProgramControl ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        //权限设置
        private void navBarItemPower_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            FormBase form = new FormPower ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        //连接参数设置
        private void navBarItemConn_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            Connection . Form1 form = new Connection . Form1 ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        //工艺信息
        private void navBarItemArt_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            FormBase form = new FormArt ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        //工艺权限
        private void navBarItemArtPower_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            FormBase form = new FormArtPower ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        //绕线基础数据设置
        private void navBarItemWindBase_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            FormBase form = new FormWindBase ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        //排单
        private void navBarItemSingleRow_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            FormBase form = new FormSingleRow ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        //排单表
        private void navBarItemSingRowTable_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            FormBase form = new FormSingRowTable ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        //绕线表单
        private void navBarItemWinding_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            FormBase form = new FormWinding ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        //定子绕圈组装
        private void navBarItemStatorCoil_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            FormBase form = new FormStatorCoil ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        //制动器组装
        private void navBarItemBrake_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            FormBase form = new FormBrake ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        //总装配
        private void navBarItemGeneralAssembly_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            FormBase form = new FormGeneralAssembly ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        //入库材料条码管理程序
        private void navBarItemStorageMaterial_LinkClicked ( object sender ,DevExpress . XtraNavBar . NavBarLinkEventArgs e )
        {
            FormBase form = new FormStorageMaterial ( );
            UserLogin . programName = CarpenterBll . UserInformation . ProgramName = form . Name;
            form . Show ( );
        }
        #endregion

    }
}
