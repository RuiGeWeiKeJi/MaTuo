using DevExpress . Utils . Paint;
using DevExpress . XtraEditors;
using System . Collections . Generic;
using System . Data;
using System . Reflection;

namespace ProductionErp
{
    public partial class FormSingleRow :FormChild
    {
        ProductionErpBll.Bll.SingleRowBll _bll=null;
        DataTable tableView;
        string strWhere="1=1";bool result=false;
        List<string> strList=new List<string>();
        
        public FormSingleRow ( )
        {
            InitializeComponent ( );

            _bll = new ProductionErpBll . Bll . SingleRowBll ( );
            tableView = new DataTable ( );

            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            barMenu . LinksPersistInfo . RemoveAt ( toolExport . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolPrint . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolCancel . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolSave . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolDelete . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolEdit . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolAdd . Id );

            wait . Hide ( );
        }
        
        #region Main
        protected override int Query ( )
        {
            strWhere = "1=1";
            if (! string . IsNullOrEmpty ( cmbGoods . Text ) )
            {
                if ( cmbGoods . Text . Equals ( "全部" ) )
                    strWhere += " AND DED002 IN ('01','02','03')";
                else if ( cmbGoods . Text . Equals ( "定子" ) )
                    strWhere += " AND DED002='01'";
                else if ( cmbGoods . Text . Equals ( "制动器" ) )
                    strWhere += " AND DED002='02'";
                else if ( cmbGoods . Text . Equals ( "总装配" ) )
                    strWhere += " AND DED002='03'";
            }

            wait . Show ( );
            backgroundWorker1 . RunWorkerAsync ( );

            return base . Query ( );

        }
        #endregion

        #region Event
        private void backgroundWorker1_DoWork ( object sender ,System . ComponentModel . DoWorkEventArgs e )
        {
            tableView = _bll . getTableGoods ( strWhere );
        }
        private void backgroundWorker1_RunWorkerCompleted ( object sender ,System . ComponentModel . RunWorkerCompletedEventArgs e )
        {
            if ( e . Error == null )
            {
                wait . Hide ( );
                tableView . Columns . Add ( "check" ,typeof ( System . Boolean ) );
                gridControl1 . DataSource = tableView;
                QueryTool ( );
            }
        }
        private void cmbGoods_KeyPress ( object sender ,System . Windows . Forms . KeyPressEventArgs e )
        {
            if ( e . KeyChar == 8 )
            {
                cmbGoods . SelectedIndex = -1;
            }
        }
        private void gridView1_CustomDrawRowIndicator ( object sender ,DevExpress . XtraGrid . Views . Grid . RowIndicatorCustomDrawEventArgs e )
        {
            if ( e . Info . IsRowIndicator && e . RowHandle >= 0 )
            {
                e . Info . DisplayText = ( e . RowHandle + 1 ) . ToString ( );
            }
        }
        private void gridView1_RowClick ( object sender ,DevExpress . XtraGrid . Views . Grid . RowClickEventArgs e )
        {
            //DataRow row = gridView1 . GetFocusedDataRow ( );
            //if ( row != null )
            //{
            //    if ( row [ "check" ] . ToString ( ) == "True" )
            //    {
            //        row [ "check" ] = false;
            //        if ( strList . Contains ( row [ "RAA001" ] . ToString ( ) + row [ "RAA015" ] . ToString ( ) ) )
            //            strList . Remove ( row [ "RAA001" ] . ToString ( ) + row [ "RAA015" ] . ToString ( ) );
            //    }
            //    else
            //    {
            //        row [ "check" ] = true;
            //        if ( !strList . Contains ( row [ "RAA001" ] . ToString ( ) + row [ "RAA015" ] . ToString ( ) ) )
            //            strList . Add ( row [ "RAA001" ] . ToString ( ) + row [ "RAA015" ] . ToString ( ) );
            //    }
            //}
        }
        #endregion

        #region Click
        private void btnGener_Click ( object sender ,System . EventArgs e )
        {
            int [ ] rows = gridView1 . GetSelectedRows ( );
            if ( rows . Length > 0 )
            {
                DataRow row;
                for ( int i = 0 ; i < rows . Length ; i++ )
                {
                    row = gridView1 . GetDataRow ( i );
                    if ( !strList . Contains ( row [ "RAA001" ] . ToString ( ) + row [ "RAA015" ] . ToString ( ) ) )
                        strList . Add ( row [ "RAA001" ] . ToString ( ) + row [ "RAA015" ] . ToString ( ) );
                }
            }
            if ( strList.Count < 1 )
            {
                XtraMessageBox . Show ( "请选择需要排单的工单" );
                return;
            }
            
            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );

            result = _bll . GenerMOXSRT ( tableView ,strList );
            if ( result )
            {
                XtraMessageBox . Show ( "生产排单成功" );
                strList . Clear ( );
                wait . Show ( );
                backgroundWorker1 . RunWorkerAsync ( );
            }
            else
                XtraMessageBox . Show ( "生成排单失败" );
        }
        #endregion

    }
}