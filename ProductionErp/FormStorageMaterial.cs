using System . Reflection;
using DevExpress . Utils . Paint;
using System . Data;
using System . Collections;
using DevExpress . XtraEditors;
using System;
using System . Windows . Forms;
using System . Collections . Generic;

namespace ProductionErp
{
    public partial class FormStorageMaterial :FormChild
    {
        ProductionErpBll.Bll.StorageMaterialBll _bll=null;
        ProductionErpEntity.StorageMaterialEntity _model=null;

        DataTable tableViewOne,tableViewTwo;
        string strWhere="1=1";
        Hashtable tableHa;
        Hashtable tableList;
        
        public FormStorageMaterial ( )
        {
            InitializeComponent ( );

            tableViewOne = new DataTable ( );
            tableViewTwo = new DataTable ( );
            tableHa = new Hashtable ( );
            tableList = new Hashtable ( );
            _bll = new ProductionErpBll . Bll . StorageMaterialBll ( );
            _model = new ProductionErpEntity . StorageMaterialEntity ( );

            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            Utility . GridViewMoHuSelect . SetFilter ( gridView2 );
            Utility . GridViewMoHuSelect . SetFilter ( View1 );
            Utility . GridViewMoHuSelect . SetFilter ( View2 );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            barMenu . LinksPersistInfo . RemoveAt ( toolExport . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolAdd . Id );

            controlUnEnable ( );
            wait . Hide ( );
            waitPro . Hide ( );

            lupOrder . Properties . DataSource = _bll . getTableOrder ( );
            lupOrder . Properties . DisplayMember = "JDB001";
            lupOrder . Properties . ValueMember = "JDB001";
            lupProNum . Properties . DataSource = _bll . getTablePro ( );
            lupProNum . Properties . DisplayMember = "DEA001";
            lupProNum . Properties . ValueMember = "DEA001";
        }
        
        #region Main
        protected override int Query ( )
        {
            strWhere = "1=1";
            if ( !string . IsNullOrEmpty ( lupOrder . Text ) )
                strWhere += " AND JDB001='" + lupOrder . Text + "'";
            if ( !string . IsNullOrEmpty ( lupProNum . Text ) )
                strWhere += " AND DEA001='" + lupProNum . Text + "'";

            wait . Show ( );
            backgroundWorker1 . RunWorkerAsync ( );

            return base . Query ( );
        }
        protected override int Edit ( )
        {
            EditTool ( );
            controlEnable ( );

            return base . Edit ( );
        }
        protected override int Delete ( )
        {
            if ( string . IsNullOrEmpty ( _model . STM001 ) )
            {
                XtraMessageBox . Show ( "请选择进货单号" );
                return 0;
            }
            if ( XtraMessageBox . Show ( "确认删除?" ,"删除" ,MessageBoxButtons . OKCancel ) == DialogResult . Cancel )
                return 0;
            bool result = _bll . Delete ( _model . STM001 ,_model . STM002 ,_model . STM003 );
            if ( result )
            {
                XtraMessageBox . Show ( "成功删除" );
                if ( tableHa . ContainsKey ( _model . STM001 + _model . STM002 + _model . STM003 ) )
                    tableHa . Remove ( _model . STM001 + _model . STM002 + _model . STM003 );
                tableViewTwo . Rows . Clear ( );
                gridControl2 . DataSource = null;
                controlUnEnable ( );
            }
            else
                XtraMessageBox . Show ( "删除失败" );

            return base . Delete ( );
        }
        protected override int Save ( )
        {
            if ( tableHa != null && tableHa . Count > 0 )
            {
                bool result = _bll . Save ( tableHa );
                if ( result )
                {
                    XtraMessageBox . Show ( "保存成功" );
                    SaveTool ( );
                    controlUnEnable ( );
                }
                else
                    XtraMessageBox . Show ( "保存失败" );
            }
            else
            {
                SaveTool ( );
                controlUnEnable ( );
            }

            return base . Save ( );
        }
        protected override int Cancel ( )
        {
            CancelTool ( "edit" );
            controlUnEnable ( );

            return base . Cancel ( );
        }
        protected override int Print ( )
        {
            List<string> intList = new List<string> ( );
            int [ ] rows = gridView2 . GetSelectedRows ( );
            foreach ( int i in rows )
            {
                DataRow row = gridView2 . GetDataRow ( i );
                _model . STM006 = row [ "STM006" ] . ToString ( );
                intList . Add ( _model . STM006 );
            }

            DataTable da = _bll . getPrint ( intList );
            if ( da == null )
                return 0;
            da . TableName = "Table";
            Print ( new DataTable [ ] { da } ,"入库材料条码打印.frx" );

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
        private void gridView2_CustomDrawRowIndicator ( object sender ,DevExpress . XtraGrid . Views . Grid . RowIndicatorCustomDrawEventArgs e )
        {
            if ( e . Info . IsRowIndicator && e . RowHandle >= 0 )
            {
                e . Info . DisplayText = ( e . RowHandle + 1 ) . ToString ( );
            }
        }
        private void backgroundWorker1_DoWork ( object sender ,System . ComponentModel . DoWorkEventArgs e )
        {
            tableViewOne = _bll . getViewOne ( strWhere );
        }
        private void backgroundWorker1_RunWorkerCompleted ( object sender ,System . ComponentModel . RunWorkerCompletedEventArgs e )
        {
            if ( e . Error == null )
            {
                wait . Hide ( );
                gridControl1 . DataSource = tableViewOne;
                tableHa . Clear ( );
                tableViewTwo . Rows . Clear ( );
                QueryTool ( );
                controlUnEnable ( );
            }
        }
        private void gridView1_RowClick ( object sender ,DevExpress . XtraGrid . Views . Grid . RowClickEventArgs e )
        {
            //decimal len = 0;

            DataRow row = gridView1 . GetFocusedDataRow ( );
            if ( row == null )
                return;
            _model . STM001 = row [ "JDB001" ] . ToString ( );
            _model . STM002 = row [ "JDB002" ] . ToString ( );
            _model . STM003 = row [ "DEA001" ] . ToString ( );
            _model . STM004 = row [ "DEA002" ] . ToString ( );
            _model . STM005 = row [ "DEA057" ] . ToString ( );
            _model . STM009 = row [ "JDA004" ] . ToString ( );
            _model . STM010 = row [ "DEA004" ] . ToString ( );
            _model . STM012 = _model . STM009 + _model . STM010 + +DateTime . Now . Year + "00001";

            gridView2 . CloseEditor ( );
            gridView2 . UpdateCurrentRow ( );

            if ( tableHa != null )
            {
                if ( tableHa . ContainsKey ( _model . STM001 + _model . STM002 + _model . STM003 ) )
                    tableViewTwo = ( DataTable ) tableHa [ _model . STM001 + _model . STM002 + _model . STM003 ];
                else
                    getTableViewTwoTable ( );
            }
            else
                getTableViewTwoTable ( );

            if ( tableHa != null )
            {
                if ( tableHa . ContainsKey ( _model . STM001 + _model . STM002 + _model . STM003 ) )
                {
                    tableHa . Remove ( _model . STM001 + _model . STM002 + _model . STM003 );
                    tableHa . Add ( _model . STM001 + _model . STM002 + _model . STM003 ,tableViewTwo );
                }
                else
                    tableHa . Add ( _model . STM001 + _model . STM002 + _model . STM003 ,tableViewTwo );
            }

            if ( tableHa == null || tableHa . Count < 1 )
            {
                tableHa . Add ( _model . STM001 + _model . STM002 + _model . STM003 ,tableViewTwo );
            }

            gridControl2 . DataSource = tableViewTwo;
            gridControl2 . Refresh ( );

        }
        private void backgroundWorker2_DoWork ( object sender ,System . ComponentModel . DoWorkEventArgs e )
        {
            tableViewTwo = _bll . getViewTwo ( _model . STM001 ,_model . STM002 ,_model . STM003 );
        }
        private void backgroundWorker2_RunWorkerCompleted ( object sender ,System . ComponentModel . RunWorkerCompletedEventArgs e )
        {
            if ( e . Error == null )
            {
                waitPro . Hide ( );
                gridControl2 . DataSource = tableViewTwo;
            }
        }
        private void lupOrder_KeyPress ( object sender ,System . Windows . Forms . KeyPressEventArgs e )
        {
            if ( e . KeyChar == 8 )
            {
                lupOrder . EditValue = null;
            }
        }
        private void lupProNum_KeyPress ( object sender ,System . Windows . Forms . KeyPressEventArgs e )
        {
            if ( e . KeyChar == 8 )
            {
                lupProNum . EditValue = null;
            }
        }
        private void btnAddNewRow_Click ( object sender ,System . EventArgs e )
        {
            if ( string . IsNullOrEmpty ( CodeInfo . Text ) )
            {
                XtraMessageBox . Show ( "请录入条码" );
                return;
            }

            tableViewTwo = _bll . getCodeOne ( CodeInfo . Text );
            gridControl2 . DataSource = tableViewTwo;
        }
        private void btnBatch_Click ( object sender ,System . EventArgs e )
        {
            if ( string . IsNullOrEmpty ( _model . STM009 ) )
            {
                XtraMessageBox . Show ( "请选择供应商编号" );
                return;
            }
            if ( string . IsNullOrEmpty ( _model . STM003 ) )
            {
                XtraMessageBox . Show ( "请选择品号" );
                return;
            }
            if ( string . IsNullOrEmpty ( txtStart . Text ) )
            {
                XtraMessageBox . Show ( "请填写开始序列号" );
                return;
            }
            if ( string . IsNullOrEmpty ( txtEnd . Text ) )
            {
                XtraMessageBox . Show ( "请填写结束序列号" );
                return;
            }
            int outResult = 0;
            if ( int . TryParse ( txtStart . Text ,out outResult ) == false )
            {
                XtraMessageBox . Show ( "请重新填写开始序列号" );
                return;
            }
            outResult = 0;
            if ( int . TryParse ( txtEnd . Text ,out outResult ) == false )
            {
                XtraMessageBox . Show ( "请重新填写结束序列号" );
                return;
            }
            string startCode = string . Empty, endCode = string . Empty;
            startCode = txtStart . Text;
            endCode = txtEnd . Text;
            if ( Convert . ToInt32 ( txtEnd . Text ) - Convert . ToInt32 ( txtStart . Text ) < 1 )
            {
                startCode = txtEnd . Text;
                endCode = txtStart . Text;
            }
            gridView2 . CloseEditor ( );
            gridView2 . UpdateCurrentRow ( );

            string code = string . Empty, year = DateTime . Now . Year . ToString ( );

            List<string> codeList = new List<string> ( );
            for ( long i = Convert . ToInt64 ( startCode ) ; i <= Convert . ToInt64 ( endCode ) ; i++ )
            {
                code = _model . STM009 + _model . STM010 + year + startCode . PadLeft ( 5 ,'0' );
                codeList . Add ( code );
                startCode = ( Convert . ToInt64 ( startCode ) + 1 ) . ToString ( );
            }

            code = String . Empty;
            List<string> removeCode = new List<string> ( );
            if ( tableHa != null || tableHa . Count > 0 )
            {
                foreach ( DataTable table in tableHa . Values )
                {
                    if ( table != null && table . Rows . Count > 0 )
                    {
                        foreach ( string s in codeList )
                        {
                            if ( table . Select ( "STM006='" + s + "'" ) . Length > 0 )
                                removeCode . Add ( s );
                        }
                        if ( removeCode . Count > 0 )
                        {
                            foreach ( string s in removeCode )
                            {
                                if ( code == string . Empty )
                                    code = s;
                                else
                                code = code + ",\n\r" + s;
                                codeList . Remove ( s );
                            }
                            removeCode . Clear ( );
                        }
                    }
                }
            }


            if ( codeList . Count < 1 )
                return;
            removeCode . Clear ( );

            if ( tableViewTwo != null && tableViewTwo . Rows . Count > 0 )
            {
                foreach ( string s in codeList )
                {
                    if ( tableViewTwo . Select ( "STM006='" + s + "'" ) . Length > 0 )
                        removeCode . Add ( s );
                }
                if ( removeCode . Count > 0 )
                {
                    foreach ( string s in removeCode )
                    {
                        if ( code == string . Empty )
                            code = s;
                        else
                            code = code + ",\n\r" + s;
                        codeList . Remove ( s );
                    }
                    removeCode . Clear ( );
                }
            }

            if ( codeList . Count < 1 )
                return;

            DataTable table1 = getAllCode ( );
            if ( table1 != null && table1 . Rows . Count > 0 )
            {
                foreach ( string s in codeList )
                {
                    if ( table1 . Select ( "STM006='" + s + "'" ) . Length > 0 )
                        removeCode . Add ( s );
                }
                if ( removeCode . Count > 0 )
                {
                    foreach ( string s in removeCode )
                    {
                        if ( code == string . Empty )
                            code = s;
                        else
                            code = code + ",\n\r" + s;
                        codeList . Remove ( s );
                    }
                    removeCode . Clear ( );
                }
            }
            if ( code != string . Empty )
                XtraMessageBox . Show ( "条码:\n\r" + code + "\n\r已经存在" ,"提示" );

            if ( codeList . Count < 1 )
                return;

            foreach ( string s in codeList )
            {
                _model . STM006 = s;
                addRowTo ( );
            }

            gridControl2 . Refresh ( );
        }
        private void gridControl2_KeyPress ( object sender ,KeyPressEventArgs e )
        {
            if ( e . KeyChar == 13 )
            {
                DataRow row = gridView2 . GetFocusedDataRow ( );
                if ( row != null )
                {
                    if ( XtraMessageBox . Show ( "确认删除?" ,"删除" ,MessageBoxButtons . OKCancel ) == DialogResult . Cancel )
                        return;
                    tableViewTwo . Rows . Remove ( row );
                    if ( tableHa . ContainsKey ( _model . STM001 + _model . STM002 + _model . STM003 ) )
                    {
                        tableHa . Remove ( _model . STM001 + _model . STM002 + _model . STM003 );
                        tableHa . Add ( _model . STM001 + _model . STM002 + _model . STM003 ,tableViewTwo );
                    }
                    gridControl2 . Refresh ( );
                }
            }
        }
        private void btnClear_Click ( object sender ,EventArgs e )
        {
            lupOrder . EditValue = lupProNum . EditValue = null;
            lupProNum . Text = lupOrder . Text = string . Empty;
        }
        #endregion

        #region Method
        void getTableViewTwoTable ( )
        {
            //waitPro . Show ( );
            //backgroundWorker2 . RunWorkerAsync ( );
            tableViewTwo = _bll . getViewTwo ( _model . STM001 ,_model . STM002 ,_model . STM003 );
            gridControl2 . DataSource = tableViewTwo;
        }
        void controlUnEnable ( )
        {
            gridView2 . OptionsBehavior . Editable = false;
            btnBatch . Enabled = false;
            txtEnd . Enabled = txtStart . Enabled = false;
            tableHa = new Hashtable ( );
            tableList = new Hashtable ( );
        }
        void controlEnable ( )
        {
            gridView2 . OptionsBehavior . Editable = true;
            txtEnd . Enabled = txtStart . Enabled = true;
            btnBatch . Enabled = btnAddNewRow . Enabled = true;
            tableHa = new Hashtable ( );
            tableList = new Hashtable ( );
        }
        void addRowTo ( )
        {
            DataRow row = tableViewTwo . NewRow ( );
            row [ "STM001" ] = _model . STM001;
            row [ "STM002" ] = _model . STM002;
            row [ "STM003" ] = _model . STM003;
            row [ "STM004" ] = _model . STM004;
            row [ "STM005" ] = _model . STM005;
            row [ "STM006" ] = _model . STM006;
            tableViewTwo . Rows . Add ( row );
            if ( tableHa . ContainsKey ( _model . STM001 + _model . STM002 + _model . STM003 ) )
            {
                tableHa . Remove ( _model . STM001 + _model . STM002 + _model . STM003 );
                tableHa . Add ( _model . STM001 + _model . STM002 + _model . STM003 ,tableViewTwo );
            }
            else
                tableHa . Add ( _model . STM001 + _model . STM002 + _model . STM003 ,tableViewTwo );

            gridControl2 . DataSource = tableViewTwo;
        }
        DataTable getAllCode ( )
        {
            DataTable table = _bll . getAllCode ( _model . STM009 + _model . STM010 + DateTime . Now . Year . ToString ( ) );
            return table;
        }
        string getMaxCodeForSame ( string JDA004 ,string DEA004 )
        {
            return _bll . getMaxCode ( JDA004 ,DEA004 );
        }
        #endregion

    }
}




