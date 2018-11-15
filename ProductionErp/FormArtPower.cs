
using DevExpress . Utils . Paint;
using DevExpress . XtraEditors;
using System;
using System . Collections . Generic;
using System . Data;
using System . Reflection;
using System . Windows . Forms;

namespace ProductionErp
{
    //(DataRowView)itemlookUpEdit.GetDataSourceRowByKeyValue(e.Value)).Row
    //gvDetailMateriel_CellValueChanging
    
    public partial class FormArtPower :FormChild
    {
        ProductionErpEntity.ArtPowerEntity _model=null;
        ProductionErpBll.Bll.ArtPowerBll _bll=null;

        DataTable tableView,tablePerson,tableArt;

        string strWhere="1=1",state=string.Empty;
        bool result=false;
        List<string> strList=null;
        
        public FormArtPower ( )
        {
            InitializeComponent ( );

            _model = new ProductionErpEntity . ArtPowerEntity ( );
            _bll = new ProductionErpBll . Bll . ArtPowerBll ( );
            tableView = new DataTable ( );
            tablePerson = new DataTable ( );
            tableArt = new DataTable ( );
            strList = new List<string> ( );

            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            Utility . GridViewMoHuSelect . SetFilter ( repositoryItemSearchLookUpEdit1View );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            barMenu . LinksPersistInfo . RemoveAt ( toolExport . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolPrint . Id );

            wait . Hide ( );
            gridView1 . OptionsBehavior . Editable = false;

            tablePerson= _bll . tablePerson ( );
            lupPerson . Properties . DataSource = tablePerson;
            lupPerson . Properties . DisplayMember = "ARP002";
            lupPerson . Properties . ValueMember = "ARP001";

            getPerson ( );

            tableArt = _bll . getArt ( );
            resArt . DataSource = tableArt;
            resArt . DisplayMember = "ARP003";
            resArt . ValueMember = "idx";
        }

        #region Main
        protected override int Query ( )
        {
            strWhere = "1=1";
            if ( !string . IsNullOrEmpty ( lupPerson . Text ) )
                strWhere = strWhere + " AND ARP001='" + lupPerson . EditValue . ToString ( ) + "'";

            wait . Show ( );
            backgroundWorker1 . RunWorkerAsync ( );

            return base . Query ( );
        }
        protected override int Add ( )
        {
            state = "add";
            gridView1 . OptionsBehavior . Editable = true;
            tableView = _bll . tableView ( "1=2" );
            gridControl1 . DataSource = tableView;
            
            AddTool ( );

            return base . Add ( );
        }
        protected override int Edit ( )
        {
            state = "edit";
            gridView1 . OptionsBehavior . Editable = true;

            EditTool ( );

            return base . Edit ( );
        }
        protected override int Save ( )
        {
            if ( checkView ( ) == false )
                return 0;

            result = _bll . Save ( tableView ,strList );
            if ( result )
            {
                XtraMessageBox . Show ( "保存成功" );
                Query ( );
                strList . Clear ( );
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
        protected override int Delete ( )
        {
            if ( XtraMessageBox . Show ( "确认删除?" ,"删除" ,MessageBoxButtons . OKCancel ) == DialogResult . Cancel )
                return 0;
            if ( tableView == null || tableView . Rows . Count < 1 )
            {
                XtraMessageBox . Show ( "请查询需要删除的数据" );
                return 0;
            }

            result = _bll . Delete ( tableView );
            if ( result )
            {
                XtraMessageBox . Show ( "删除成功" );
                tableView = null;
                gridControl1 . DataSource = null;
                DeleteTool ( );
            }
            else
                XtraMessageBox . Show ( "删除失败,请重试" );

            return base . Delete ( );
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
        private void backgroundWorker1_DoWork ( object sender ,System . ComponentModel . DoWorkEventArgs e )
        {
            tableView = _bll . tableView ( strWhere );
        }
        private void backgroundWorker1_RunWorkerCompleted ( object sender ,System . ComponentModel . RunWorkerCompletedEventArgs e )
        {
            if ( e . Error == null )
            {
                wait . Hide ( );
                gridView1 . OptionsBehavior . Editable = false;
                gridControl1 . DataSource = tableView;
                QueryTool ( );
                if ( tableView . Rows . Count <1  )
                {
                    toolEdit . Visibility = toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
                }
            }
        }
        private void lupUser_EditValueChanged ( object sender ,System . EventArgs e )
        {
            DevExpress . XtraEditors . BaseEdit edit = gridView1 . ActiveEditor;
            switch ( gridView1 . FocusedColumn . FieldName )
            {
                case "ARP001":             
                string str = tablePerson . Select ( "ARP001='" + edit . EditValue + "'" ) [ 0 ] [ "ARP002" ] . ToString ( );
                gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "ARP002" ] ,str );
                break;
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
                    _model . idx = string . IsNullOrEmpty ( gridView1 . GetDataRow ( num ) [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( gridView1 . GetDataRow ( num ) [ "idx" ] . ToString ( ) );
                    if ( _model . idx > 0 && !strList . Contains ( _model . idx . ToString ( ) ) )
                        strList . Add ( _model . idx . ToString ( ) );
                    tableView . Rows . RemoveAt ( num );
                    gridControl1 . RefreshDataSource ( );
                }
            }
        }
        private void lupPerson_KeyPress ( object sender ,System . Windows . Forms . KeyPressEventArgs e )
        {
            if ( e . KeyChar == 8 )
            {
                lupPerson . EditValue = null;
            }
        }
        private void resArt_EditValueChanged ( object sender ,System . EventArgs e )
        {
            DevExpress . XtraEditors . BaseEdit edit = gridView1 . ActiveEditor;
            switch ( gridView1 . FocusedColumn . FieldName )
            {
                case "ARP003":
                {
                    if ( edit . EditValue != null )
                    {
                        string str = tableArt . Select ( "idx='" + edit . EditValue + "'" ) [ 0 ] [ "ARP004" ] . ToString ( );
                        gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "ARP004" ] ,str );
                    }
                }
                break;
            }
        }
        #endregion

        #region Method
        void getPerson ( )
        {
            lupUser . DataSource = tablePerson;
            lupUser . DisplayMember = "ARP001";
            lupUser . ValueMember = "ARP";
        }
        bool checkView ( )
        {
            result = true;
            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );
            DataRow row;
            for ( int i = 0 ; i < gridView1 . DataRowCount  ; i++ )
            {
                row = gridView1 . GetDataRow ( i );
                _model . ARP001 = row [ "ARP001" ] . ToString ( );
                _model . ARP002 = row [ "ARP002" ] . ToString ( );
                _model . ARP003 = row [ "ARP003" ] . ToString ( );
                _model . ARP004 = row [ "ARP004" ] . ToString ( );
                row . ClearErrors ( );
                if ( string . IsNullOrEmpty ( _model . ARP001 ) )
                {
                    row . SetColumnError ( "ARP001" ,"不可为空" );
                    result= false;
                    break;
                }
                if ( string . IsNullOrEmpty ( _model . ARP002 ) )
                {
                    row . SetColumnError ( "ARP002" ,"不可为空" );
                    result = false;
                    break;
                }
                if ( string . IsNullOrEmpty ( _model . ARP003 ) )
                {
                    row . SetColumnError ( "ARP003" ,"不可为空" );
                    result = false;
                    break;
                }
                if ( string . IsNullOrEmpty ( _model . ARP004 ) )
                {
                    row . SetColumnError ( "ARP004" ,"不可为空" );
                    result = false;
                    break;
                }
            }

            return result;
        }
        #endregion

    }
}