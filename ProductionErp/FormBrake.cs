using System . ComponentModel;
using System . Data;
using DevExpress . XtraEditors;
using DevExpress . Utils . Paint;
using System . Reflection;
using System;
using System . Drawing;

namespace ProductionErp
{
    public partial class FormBrake :FormChild
    {
        ProductionErpEntity.BrakeBRAEntity _bra=null;
        ProductionErpEntity.BrakeBRBEntity _brb=null;
        ProductionErpBll.Bll.BrakeBll _bll=null;
        DataTable tableView,tablePrintOne,tablePrintTwo,tableSup; bool result=false;
        
        public FormBrake ( )
        {
            InitializeComponent ( );

            _bra = new ProductionErpEntity . BrakeBRAEntity ( );
            _brb = new ProductionErpEntity . BrakeBRBEntity ( );
            _bll = new ProductionErpBll . Bll . BrakeBll ( );
            tableView = new DataTable ( );

            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            barMenu . LinksPersistInfo . RemoveAt ( toolExport . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolDelete . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolAdd . Id );

            wait . Hide ( );
            gridView1 . OptionsBehavior . Editable = false;

            tableSup = _bll . getTableSup ( );
            editData . DataSource = tableSup;
            editData . DisplayMember = "BRB007";
            editData . ValueMember = "BR";

            DataTable tableOne = tableSup . Copy ( );
            editOne . DataSource = tableOne;
            editOne . DisplayMember = "BRB007";
            editOne . ValueMember = "BR";
        }
        
        #region Main
        protected override int Query ( )
        {
            Operation . FormStatorCoilQuery from = new Operation . FormStatorCoilQuery ( "制动器组装" );
            if ( from . ShowDialog ( ) == System . Windows . Forms . DialogResult . OK )
            {
                _bra . BRA001 = _brb . BRB001 = from . getCodeNum;

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
            tablePrintOne . TableName = "MOXBRA";
            tablePrintTwo = _bll . getPrintTwo ( txtCode . Text );
            tablePrintTwo . TableName = "MOXBRB";

            Print ( new DataTable [ ] { tablePrintOne ,tablePrintTwo } ,"制动器组装过程卡片.frx" );

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
            _bll . getCodeNum ( _brb . BRB001 );
            tableView = _bll . getTableView ( _bra . BRA001 );
            _bra = _bll . getModel ( _bra . BRA001 );
        }
        private void backgroundWorker1_RunWorkerCompleted ( object sender ,RunWorkerCompletedEventArgs e )
        {
            if ( e . Error == null )
            {
                wait . Hide ( );
                gridControl1 . DataSource = tableView;
                txtProductNum . Text = _bra . BRA002;
                txtProductName . Text = _bra . BRA003;
                txtSpace . Text = _bra . BRA004;
                txtCode . Text = _bra . BRA001;
                QueryTool ( );
                gridView1 . OptionsBehavior . Editable = false;
            }
        }
        private void gridView1_CustomRowCellEditForEditing ( object sender ,DevExpress . XtraGrid . Views . Grid . CustomRowCellEditEventArgs e )
        {
            int num = e . RowHandle;
            if ( num >= 0 && num <= gridView1 . DataRowCount - 1 )
            {
                string str = gridView1 . GetDataRow ( num ) [ "BRB003" ] . ToString ( );
                //if ( e . Column . Name == "BRB007" )
                //{
                //    if ( str . Contains ( "工频耐压" ) || str . Contains ( "绝缘电阻" ) || str . Contains ( "直流电阻" ) || str . Contains ( "制动器最低启动电压能吸合" ) || str . Contains ( "制动器开关动作判定" ) )
                //    {
                //        e . Column . OptionsColumn . AllowEdit = false;
                //    }
                //    else
                //        e . Column . OptionsColumn . AllowEdit = true;
                //}
                str = gridView1 . GetDataRow ( num ) [ "BRB002" ] . ToString ( );
                if ( e . Column . Name == "BRB007" && str . Contains ( "装线圈" ) )
                {
                    e . RepositoryItem = editData;
                    //editData . ValueMember = "浙江洪波";
                }
                else if ( e . Column . Name == "BRB007" && str . Contains ( "装减震垫" ) )
                {
                    e . RepositoryItem = editOne;
                    //editOne . ValueMember = "杭州万康";
                }
            }
        }
        private void gridView1_ShowingEditor ( object sender ,CancelEventArgs e )
        {
            int num = gridView1 . FocusedRowHandle;
            if ( num >= 0 && num <= gridView1 . DataRowCount - 1 )
            {
                _brb . BRB003 = gridView1 . GetDataRow ( num ) [ "BRB003" ] . ToString ( );
                if ( gridView1 . FocusedColumn . FieldName == "BRB007" && !string . IsNullOrEmpty ( _brb . BRB003 ) && ( _brb . BRB003 . Equals ( "工频耐压" ) || _brb . BRB003 . Equals ( "绝缘电阻" ) || _brb . BRB003 . Equals ( "直流电阻" ) || _brb . BRB003 . Equals ( "制动器最低启动电压能吸合" ) || _brb . BRB003 . Equals ( "制动器开关动作判定" )  ) )
                {
                    e . Cancel = true;
                }
            }
        }
        private void resBut_Click ( object sender ,System . EventArgs e )
        {
            DataRow row = gridView1 . GetFocusedDataRow ( );
            if ( row != null )
            {
                _brb . BRB004 = row [ "BRB004" ] . ToString ( );

                if ( string . IsNullOrEmpty ( _brb . BRB004 ) )
                {
                    row [ "BRB004" ] = UserLogin . userName;
                    row [ "BRB005" ] = UserLogin . userDt;
                }
                else if ( _brb . BRB004 . Equals ( UserLogin . userName ) )
                {
                    row [ "BRB004" ] = string . Empty;
                    row [ "BRB005" ] = DBNull . Value;
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
                if ( e . Column . FieldName == "BRB003" )
                {
                    string strTemp = gridView1 . GetRowCellValue ( e . RowHandle ,"BRB002" ) . ToString ( ) . Trim ( );
                    if ( strTemp . Equals ( "绕线圈" ) || strTemp . Equals ( "装电磁铁" ) || strTemp . Equals ( "粘摩擦片" ) || strTemp . Equals ( "装配衔铁" ) || strTemp . Equals ( "装弹簧" ) )
                    {
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
                _brb . BRB002 = row [ "BRB002" ] . ToString ( );
                _brb . BRB003 = row [ "BRB003" ] . ToString ( );
                _brb . BRB004 = row [ "BRB004" ] . ToString ( );
                if ( ( _brb . BRB002 . Equals ( "绕线圈" ) || _brb . BRB002 . Equals ( "装电磁铁" ) || _brb . BRB002 . Equals ( "粘摩擦片" ) || _brb . BRB002 . Equals ( "装配衔铁" ) || _brb . BRB002 . Equals ( "装弹簧" ) ) && !string . IsNullOrEmpty ( _brb . BRB003 ) && string . IsNullOrEmpty ( _brb . BRB004 ) )
                {
                    row . SetColumnError ( "BRB004" ,"请签字  " );
                    result = false;
                    break;
                }
            }

            return result;
        }
        #endregion

    }
}
