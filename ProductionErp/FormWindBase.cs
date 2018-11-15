using System . Data;
using System . Reflection;
using DevExpress . Utils . Paint;
using DevExpress . XtraEditors;
using System . Windows . Forms;
using System;

namespace ProductionErp
{
    public partial class FormWindBase :FormChild
    {
        ProductionErpEntity.WindBaseEntity _model=null;
        ProductionErpBll.Bll.WindBaseBll _bll=null;
        DataTable tableView,tableGoods;
        string strWhere="1=1",state=string.Empty;
        bool result=false;
        
        public FormWindBase ( )
        {
            InitializeComponent ( );

            _model = new ProductionErpEntity . WindBaseEntity ( );
            _bll = new ProductionErpBll . Bll . WindBaseBll ( );
            tableView = new DataTable ( );

            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            Utility . GridViewMoHuSelect . SetFilter ( repositoryItemSearchLookUpEdit1View );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            barMenu . LinksPersistInfo . RemoveAt ( toolExport . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolPrint . Id );

            wait . Hide ( );
            gridView1 . OptionsBehavior . Editable = false;

            tableGoods = _bll . tableGood ( );
            lupGoods . Properties . DataSource = tableGoods;
            lupGoods . Properties . DisplayMember = "WIB002";
            lupGoods . Properties . ValueMember = "WIB001";

            secUser . DataSource = tableGoods;
            secUser . DisplayMember = "WIB001";
            secUser . ValueMember = "WIB001";

            //lupUser . DataSource = tableGoods;
            //lupUser . DisplayMember = "WIB001";
            //lupUser . ValueMember = "WIB";
        }
        
        #region Main
        protected override int Query ( )
        {
            strWhere = "1=1";
            if ( !string . IsNullOrEmpty ( lupGoods . Text ) )
                strWhere = strWhere + " AND WIB001='" + lupGoods . EditValue . ToString ( ) + "'";

            wait . Show ( );
            backgroundWorker1 . RunWorkerAsync ( );

            return base . Query ( );
        }
        protected override int Add ( )
        {
            state = "add";

            wait . Show ( );
            backgroundWorker2 . RunWorkerAsync ( );

            return base . Add ( );
        }
        protected override int Edit ( )
        {
            state = "edit";
            gridView1 . OptionsBehavior . Editable = true;

            EditTool ( );

            return base . Edit ( );
        }
        protected override int Delete ( )
        {
            if ( tableView == null || tableView . Rows . Count < 1 )
            {
                XtraMessageBox . Show ( "请查询需要删除的数据" );
                return 0;
            }
            DataRow row = gridView1 . GetFocusedDataRow ( );
            if ( row != null )
            {
                if ( XtraMessageBox . Show ( "确认删除?" ,"删除" ,MessageBoxButtons . OKCancel ) == DialogResult . Cancel )
                    return 0;
            }

            _model . idx = string . IsNullOrEmpty ( row [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( row [ "idx" ] . ToString ( ) );
            result = _bll . Delete ( _model.idx );
            if ( result )
            {
                XtraMessageBox . Show ( "删除成功" );
                tableView . Rows . Remove ( row );
                gridControl1 . Refresh ( );
            }
            else
                XtraMessageBox . Show ( "删除失败,请重试" );

            return base . Delete ( );
        }
        protected override int Save ( )
        {
            if ( checkView ( ) == false )
                return 0;

            result = _bll . Save ( tableView );
            if ( result )
            {
                XtraMessageBox . Show ( "保存成功" );
                Query ( );
            }
            else
                XtraMessageBox . Show ( "保存失败,请重试" );

            return base . Save ( );
        }
        protected override int Cancel ( )
        {
            CancelTool ( state );
            gridView1 . OptionsBehavior . Editable = false;

            return base . Cancel ( );
        }
        #endregion

        #region Event
        private void lupUser_EditValueChanged ( object sender ,System . EventArgs e )
        {
            
        }
        private void secUser_EditValueChanged ( object sender ,System . EventArgs e )
        {
            DevExpress . XtraEditors . BaseEdit edit = gridView1 . ActiveEditor;
            switch ( gridView1 . FocusedColumn . FieldName )
            {
                case "WIB001":
                if ( edit . EditValue != null )
                {
                    _model . WIB002 = tableGoods . Select ( "WIB001='" + edit . EditValue + "'" ) [ 0 ] [ "WIB002" ] . ToString ( );
                    _model . WIB003 = tableGoods . Select ( "WIB001='" + edit . EditValue + "'" ) [ 0 ] [ "WIB003" ] . ToString ( );
                    gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "WIB002" ] ,_model . WIB002 );
                    gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "WIB003" ] ,_model . WIB003 );
                }
                break;
            }
        }
        private void gridView1_CustomDrawRowIndicator ( object sender ,DevExpress . XtraGrid . Views . Grid . RowIndicatorCustomDrawEventArgs e )
        {
            if ( e . Info . IsRowIndicator && e . RowHandle >= 0 )
            {
                e . Info . DisplayText = ( e . RowHandle + 1 ) . ToString ( );
            }
        }
        private void gridControl1_KeyPress ( object sender ,System . Windows . Forms . KeyPressEventArgs e )
        {
            if ( e . KeyChar == 13 )
            {
                int num = gridView1 . FocusedRowHandle;
                if ( num >= 0 && num <= gridView1 . DataRowCount - 1 )
                {
                    if ( XtraMessageBox . Show ( "确认删除?" ,"删除" ,MessageBoxButtons . OKCancel ) == DialogResult . Cancel )
                        return;

                    tableView . Rows [ num ] . Delete ( );
                    gridControl1 . Refresh ( );
                }
            }
        }
        private void lupGoods_KeyPress ( object sender ,KeyPressEventArgs e )
        {
            if ( e . KeyChar == 8 )
            {
                lupGoods . EditValue = null;
            }
        }
        private void backgroundWorker1_DoWork ( object sender ,System . ComponentModel . DoWorkEventArgs e )
        {
            tableView = _bll . tableView ( strWhere );
        }
        private void backgroundWorker1_RunWorkerCompleted ( object sender ,System . ComponentModel . RunWorkerCompletedEventArgs e )
        {
            if ( e . Error == null )
            {
                wait . Hide ( );
                gridControl1 . DataSource = tableView;
                QueryTool ( );
                gridView1 . OptionsBehavior . Editable = false;
                if ( tableView . Rows . Count < 1 )
                {
                    toolEdit . Visibility = toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
                }
            }
        }
        private void backgroundWorker2_DoWork ( object sender ,System . ComponentModel . DoWorkEventArgs e )
        {
            tableView = _bll . tableView ( strWhere );
        }
        private void backgroundWorker2_RunWorkerCompleted ( object sender ,System . ComponentModel . RunWorkerCompletedEventArgs e )
        {
            if ( e . Error == null )
            {
                wait . Hide ( );
                gridControl1 . DataSource = tableView;
                gridView1 . OptionsBehavior . Editable = true;
                AddTool ( );
                if ( tableView . Rows . Count < 1 )
                {
                    toolEdit . Visibility = toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
                }
            }
        }
        #endregion

        #region Method
        bool checkView ( )
        {
            result = true;

            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );

            DataRow row;
            for ( int i = 0 ; i < gridView1 . DataRowCount ; i++ )
            {
                row = gridView1 . GetDataRow ( i );
                _model . WIB001 = row [ "WIB001" ] . ToString ( );
                row . ClearErrors ( );
                if ( string . IsNullOrEmpty ( _model . WIB001 ) )
                {
                    row . SetColumnError ( "WIB001" ,"不可为空" );
                    result = false;
                    break;
                }
            }

            return result;
        }
        #endregion

    }
}