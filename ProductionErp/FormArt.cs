
using DevExpress . Utils . Paint;
using DevExpress . XtraEditors;
using System;
using System . Collections . Generic;
using System . Data;
using System . Reflection;
using System . Windows . Forms;

namespace ProductionErp
{
    public partial class FormArt :FormChild
    {
        DataTable tableView;
        ProductionErpEntity.ArtEntity _model=null;
        ProductionErpBll.Bll.ArtBll _bll=null;
        bool result=false;
        List<int> intList=new List<int>();
        
        public FormArt ( )
        {
            InitializeComponent ( );

            tableView = new DataTable ( );
            _model = new ProductionErpEntity . ArtEntity ( );
            _bll = new ProductionErpBll . Bll . ArtBll ( );

            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );


            barMenu . LinksPersistInfo . RemoveAt ( toolExport . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolPrint . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolEdit . Id );
                    
            gridView1 . OptionsBehavior . Editable = false;
        }

        #region Main
        protected override int Query ( )
        {
            tableView = _bll . GetDataTable ( );
            gridControl1 . DataSource = tableView;
            QueryTool ( );
            gridView1 . OptionsBehavior . Editable = false;

            return base . Query ( );
        }
        protected override int Add ( )
        {
            gridView1 . OptionsBehavior . Editable = true;
            tableView = _bll . GetDataTable ( );
            gridControl1 . DataSource = tableView;

            AddTool ( );

            return base . Add ( );
        }
        protected override int Save ( )
        {
            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );

            result = _bll . Save ( tableView ,intList );
            if ( result )
            {
                XtraMessageBox . Show ( "保存成功" );
                Query ( );
            }
            else
                XtraMessageBox . Show ( "保存失败,请重试" );

            return base . Save ( );
        }
        protected override int Delete ( )
        {
            if ( XtraMessageBox . Show ( "确认删除?" ,"删除" ,MessageBoxButtons . OKCancel ) == DialogResult . Cancel )
                return 0;

            if ( _model . Idx < 1 )
            {
                XtraMessageBox . Show ( "请选择需要删除的内容" );
                return 0;
            }

            result = _bll . Delete ( _model . Idx );
            if ( result )
            {
                XtraMessageBox . Show ( "删除成功" );
                Query ( );
            }
            else
                XtraMessageBox . Show ( "删除失败,请重试" );

            return base . Delete ( );
        }
        protected override int Cancel ( )
        {
            gridView1 . OptionsBehavior . Editable = false;
            CancelTool ( "edit" );

            return base . Cancel ( );
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
        private void gridView1_RowClick ( object sender ,DevExpress . XtraGrid . Views . Grid . RowClickEventArgs e )
        {
            int num = gridView1 . FocusedRowHandle;
            if ( num >= 0 && num <= gridView1 . DataRowCount - 1 )
            {
                _model . Idx = string . IsNullOrEmpty ( gridView1 . GetDataRow ( num ) [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( gridView1 . GetDataRow ( num ) [ "idx" ] . ToString ( ) );
            }
        }
        private void gridControl1_KeyPress ( object sender ,System . Windows . Forms . KeyPressEventArgs e )
        {
            if ( e . KeyChar == 13 )
            {
                if ( XtraMessageBox . Show ( "确认删除?" ,"删除" ,MessageBoxButtons . OKCancel ) == DialogResult . Cancel )
                    return;
                int num = gridView1 . FocusedRowHandle;
                if ( num >= 0 && num <= gridView1 . DataRowCount - 1 )
                {
                    _model . Idx = string . IsNullOrEmpty ( gridView1 . GetDataRow ( num ) [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( gridView1 . GetDataRow ( num ) [ "idx" ] . ToString ( ) );
                    intList . Add ( _model . Idx );
                    tableView . Rows . RemoveAt ( num );
                    gridControl1 . RefreshDataSource ( );
                }
            }
        }
        #endregion

    }
}





