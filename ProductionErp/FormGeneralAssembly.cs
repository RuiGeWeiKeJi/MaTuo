using System . ComponentModel;
using System . Data;
using DevExpress . XtraEditors;
using System . Reflection;
using DevExpress . Utils . Paint;
using System;
using System . Drawing;

namespace ProductionErp
{
    public partial class FormGeneralAssembly :FormChild
    {
        ProductionErpEntity.GeneralAssemblyGEAEntity _gea=null;
        ProductionErpEntity .GeneralAssemblyGEBEntity _geb=null;
        ProductionErpBll.Bll.GeneralAssemblyBll _bll=null;
        DataTable tableView,tablePrintOne,tablePrintTwo; bool result=false;
        
        public FormGeneralAssembly ( )
        {
            InitializeComponent ( );
            
            _gea = new ProductionErpEntity . GeneralAssemblyGEAEntity ( );
            _geb = new ProductionErpEntity . GeneralAssemblyGEBEntity ( );
            _bll = new ProductionErpBll . Bll . GeneralAssemblyBll ( );

            tableView = new DataTable ( );

            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            barMenu . LinksPersistInfo . RemoveAt ( toolExport . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolDelete . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolAdd . Id );

            wait . Hide ( );
            gridView1 . OptionsBehavior . Editable = false;
        }
        
        #region Main
        protected override int Query ( )
        {
            Operation . FormStatorCoilQuery from = new Operation . FormStatorCoilQuery ( "总装配" );
            if ( from . ShowDialog ( ) == System . Windows . Forms . DialogResult . OK )
            {
                _gea . GEA001 = _geb . GEB001 = from . getCodeNum;
                
                wait . Show ( );
                backgroundWorker1 . RunWorkerAsync ( );
            }

            return base . Query ( );
        }
        protected override int Edit ( )
        {
            EditTool ( );
            gridView1 . OptionsBehavior . Editable = true;

            return base . Edit ( );
        }
        protected override int Save ( )
        {
            if ( checkValue ( ) == false )
                return 0;

            result = _bll . Save ( tableView );
            if ( result )
            {
                XtraMessageBox . Show ( "保存成功" );
                SaveTool ( );
                gridView1 . OptionsBehavior . Editable = false;
            }
            else
                XtraMessageBox . Show ( "保存失败" );

            return base . Save ( );
        }
        protected override int Cancel ( )
        {
            CancelTool ( "edit" );
            gridView1 . OptionsBehavior . Editable = false;

            return base . Cancel ( );
        }
        protected override int Print ( )
        {
            if ( string . IsNullOrEmpty ( txtCode . Text ) )
            {
                XtraMessageBox . Show ( "请选择条码等信息" );
                return 0;
            }
            tablePrintOne = _bll . getPrintOne ( txtCode . Text );
            tablePrintOne . TableName = "MOXGEA";
            tablePrintTwo = _bll . getPrintTwo ( txtCode . Text );
            tablePrintTwo . TableName = "MOXGEB";

            Print ( new DataTable [ ] { tablePrintOne ,tablePrintTwo } ,"总装配.frx" );

            return base . Print ( );
        }
        #endregion

        #region Event
        private void gridView1_CustomDrawRowIndicator ( object sender ,DevExpress . XtraGrid . Views . Grid . RowIndicatorCustomDrawEventArgs e )
        {
            if ( e . Info . IsRowIndicator && e . RowHandle >= 0 )
            {
                e . Info . DisplayText = ( e . RowHandle + 1 ) . ToString ( );
            }
        }
        private void backgroundWorker1_DoWork ( object sender ,DoWorkEventArgs e )
        {
            _bll . getCodeNum ( _gea . GEA001 );
            tableView = _bll . getTableView ( _gea . GEA001 );
            _gea = _bll . getModel ( _gea . GEA001 );
        }
        private void backgroundWorker1_RunWorkerCompleted ( object sender ,RunWorkerCompletedEventArgs e )
        {
            if ( e . Error == null )
            {
                wait . Hide ( );
                gridControl1 . DataSource = tableView;
                txtProductNum . Text = _gea . GEA002;
                txtProductName . Text = _gea . GEA003;
                txtSpace . Text = _gea . GEA004;
                txtCode . Text = _gea . GEA001;
                txtRemark . Text = _gea . GEA005;
                QueryTool ( );
                gridView1 . OptionsBehavior . Editable = false;
            }
        }
        private void resBut_Click ( object sender ,System . EventArgs e )
        {
            DataRow row = gridView1 . GetFocusedDataRow ( );
            if ( row != null )
            {
                _geb . GEB005 = row [ "GEB005" ] . ToString ( );
                if ( string . IsNullOrEmpty ( _geb . GEB005 ) )
                {
                    row [ "GEB005" ] = UserLogin . userName;
                    row [ "GEB007" ] = UserLogin . userDt;
                }
                else if ( _geb . GEB005 . Equals ( UserLogin . userName ) )
                {
                    row [ "GEB005" ] = string . Empty;
                    row [ "GEB007" ] = DBNull . Value;
                }
            }
        }
        private void gridView1_ShowingEditor ( object sender ,CancelEventArgs e )
        {
            int num = gridView1 . FocusedRowHandle;
            if ( num >= 0 && num <= gridView1 . DataRowCount - 1 )
            {
                _geb . GEB004 = gridView1 . GetDataRow ( num ) [ "GEB004" ] . ToString ( );
                if ( gridView1 . FocusedColumn . FieldName == "GEB003" && ( _geb . GEB002 . Equals ( "耐压（电机线圈对机壳）" ) || _geb . GEB002 . Equals ( "耐压（制动器线圈对机壳）" ) || _geb . GEB002 . Equals ( "绝缘（电机线圈对机壳）" ) || _geb . GEB002 . Equals ( "绝缘（制动器线圈对机壳）" ) || _geb . GEB002 . Equals ( "直流电阻UV" ) || _geb . GEB002 . Equals ( "直流电阻UW" ) || _geb . GEB002 . Equals ( "直流电阻VW" ) || _geb . GEB002 . Equals ( "直流电阻平均值" ) || _geb . GEB002 . Equals ( "直流电阻判定结果" ) || _geb . GEB002 . Equals ( "制动器电阻数值1" ) || _geb . GEB002 . Equals ( "制动器电阻数值2" ) || _geb . GEB002 . Equals ( "振动速度" ) || _geb . GEB002 . Equals ( "制动器最低启动电压能吸合" ) || _geb . GEB002 . Equals ( "检测制动器开关动作次数" ) || _geb . GEB002 . Equals ( "制动力矩(电流法）1" ) || _geb . GEB002 . Equals ( "制动力矩(电流法）2" ) || _geb . GEB002 . Equals ( "空载电流" ) || _geb . GEB002 . Equals ( "空载电压" ) || _geb . GEB002 . Equals ( "空载功率" ) ) )
                {
                    e . Cancel = true;
                }
            }
        }
        private void gridView1_CustomDrawCell ( object sender ,DevExpress . XtraGrid . Views . Base . RowCellCustomDrawEventArgs e )
        {
            if ( e . RowHandle >= 0 && e . RowHandle <= gridView1 . DataRowCount - 1 )
            {
                DevExpress . Utils . AppearanceDefault appRed = new DevExpress . Utils . AppearanceDefault
                     ( Color . Black ,Color . Red ,Color . Empty ,Color . SeaShell ,System . Drawing . Drawing2D . LinearGradientMode . Horizontal );
                DevExpress . Utils . AppearanceDefault appYellow = new DevExpress . Utils . AppearanceDefault
                    ( Color . Black ,Color . Yellow ,Color . Empty ,Color . SeaShell ,System . Drawing . Drawing2D . LinearGradientMode . Horizontal );
                DevExpress . Utils . AppearanceDefault appGreen = new DevExpress . Utils . AppearanceDefault
                    ( Color . Black ,Color . Green ,Color . Empty ,Color . SeaShell ,System . Drawing . Drawing2D . LinearGradientMode . Horizontal );
                string strTemp = gridView1 . GetRowCellValue ( e . RowHandle ,"GEB002" ) . ToString ( ) . Trim ( );
                if ( e . Column . FieldName == "GEB003" )
                {
                    if ( strTemp . Equals ( "组装曳引轮+转子" ) || strTemp . Equals ( "贴磁钢" ) || strTemp . Equals ( "装轴承" ) || strTemp . Equals ( "组装机座+定子线圈" ) || strTemp . Equals ( "装制动器" ) || strTemp . Equals ( "成品检验" ) || strTemp . Equals ( "噪音(dB)" ) || strTemp . Equals ( "制动器吸合噪音(dB)" ) || strTemp . Equals ( "制动器释放噪音(dB)" ) )
                    {
                        //黄色
                        DevExpress . Utils . AppearanceHelper . Apply ( e . Appearance ,appYellow );
                    }
                }
                if ( e . Column . FieldName == "GEB004" )
                {
                    if ( strTemp . Equals ( "组装曳引轮+转子" ) || strTemp . Equals ( "组装机座+定子线圈" ))
                    {
                        //红色
                        DevExpress . Utils . AppearanceHelper . Apply ( e . Appearance ,appRed );
                    }
                    if ( strTemp . Equals ( "噪音(dB)" ) || strTemp . Equals ( "制动器吸合噪音(dB)" ) || strTemp . Equals ( "制动器释放噪音(dB)" ) )
                    {
                        //红色
                        DevExpress . Utils . AppearanceHelper . Apply ( e . Appearance ,appYellow );
                    }
                }
            }
        }
        #endregion

        #region Method
        bool checkValue ( )
        {
            bool result = true;
            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );
            DataRow row;
            for ( int i = 0 ; i < gridView1 . DataRowCount ; i++ )
            {
                row = gridView1 . GetDataRow ( i );
                row . ClearErrors ( );
                _geb . GEB002 = row [ "GEB002" ] . ToString ( );
                _geb . GEB003 = row [ "GEB003" ] . ToString ( );
                _geb . GEB004 = row [ "GEB004" ] . ToString ( );
                _geb . GEB005 = row [ "GEB005" ] . ToString ( );
                if ( ( _geb . GEB002 . Equals ( "组装曳引轮+转子" ) || _geb . GEB002 . Equals ( "贴磁钢" ) || _geb . GEB002 . Equals ( "装轴承" ) || _geb . GEB002 . Equals ( "组装机座+定子线圈" ) || _geb . GEB002 . Equals ( "装制动器" ) || _geb . GEB002 . Equals ( "成品检验" ) ) && !string . IsNullOrEmpty ( _geb . GEB003 ) && string . IsNullOrEmpty ( _geb . GEB005 ) )
                {
                    row . SetColumnError ( "GEB005" ,"请签字  " );
                    result = false;
                    break;
                }
                if ( ( _geb . GEB002 . Equals ( "组装曳引轮+转子" ) || _geb . GEB002 . Equals ( "组装机座+定子线圈" )  ) && !string . IsNullOrEmpty ( _geb . GEB004 ) && string . IsNullOrEmpty ( _geb . GEB005 ) )
                {
                    row . SetColumnError ( "GEB005" ,"请签字  " );
                    result = false;
                    break;
                }
            }
            return result;
        }
        #endregion

    }
}





