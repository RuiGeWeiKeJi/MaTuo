using System . Reflection;
using DevExpress . Utils . Paint;
using System . Data;
using DevExpress . XtraEditors;
using System;
using System . Windows . Forms;
using System . Drawing;

namespace ProductionErp
{
    public partial class FormWinding :FormChild
    {
        ProductionErpEntity.WindingWIDEntity _wid=null;
        ProductionErpEntity.WindingWIEEntity _wie=null;
        ProductionErpBll.Bll.WindingBll _bll=null;
        DataTable tableView,tableOddNum,printOne,printTwo,UserInfo;
        string strWhere="1=1",state=string.Empty;
        bool result=false;
        
        public FormWinding ( )
        {
            InitializeComponent ( );

            _wid = new ProductionErpEntity . WindingWIDEntity ( );
            _wie = new ProductionErpEntity . WindingWIEEntity ( );
            _bll = new ProductionErpBll . Bll . WindingBll ( );
            tableView = new DataTable ( );

            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            wait . Hide ( );

            //barMenu . LinksPersistInfo . RemoveAt ( toolExport . Id );

            getOddNum ( );
            lupGoods . Properties . DataSource = _bll . getTableGD ( );
            lupGoods . Properties . DisplayMember = "RAA001";

            UserInfo = _bll . getTableUser ( );
            secUser . DataSource = UserInfo;
            secUser . DisplayMember = "WIE011";
            secUser . ValueMember = "WIE011";

            controlUnEnable ( );
        }
        
        #region Main
        protected override int Query ( )
        {
            strWhere = "1=1";
            if ( string . IsNullOrEmpty ( lupOddnNum . Text ) )
            {
                XtraMessageBox . Show ( "请选择单号" );
                return 0;
            }
            if ( !string . IsNullOrEmpty ( lupOddnNum . Text ) )
                strWhere += " AND WID001='" + lupOddnNum . Text + "'";
            //if ( !string . IsNullOrEmpty ( lupJobNum . Text ) )
            //    strWhere += " AND WID002='" + lupJobNum . Text + "'";
            //if ( !string . IsNullOrEmpty ( lupPerson . Text ) )
            //    strWhere += " AND WID003='" + lupPerson . EditValue + "'";

            wait . Show ( );
            backgroundWorker1 . RunWorkerAsync ( );

            return base . Query ( );
        }
        protected override int Add ( )
        {
            state = "add";
            controlEnable ( );
            controlClear ( );
            AddTool ( );
            tableView = _bll . tableView ( "1=2" );
            gridControl1 . DataSource = tableView;

            

            return base . Add ( );
        }
        protected override int Edit ( )
        {
            state = "edit";
            controlEnable ( );
            EditTool ( );
            lupGoods . Enabled = false;

            return base . Edit ( );
        }
        protected override int Delete ( )
        {
            if ( XtraMessageBox . Show ( "确认删除?" ,"删除" ,MessageBoxButtons . OKCancel ) == DialogResult . Cancel )
                return 0;
            if ( string . IsNullOrEmpty ( lupOddnNum.Text ) )
            {
                XtraMessageBox . Show ( "请选择需要删除的单据" );
                return 0;
            }
            _wid . WID001 = lupOddnNum . Text;
            result = _bll . Delete ( _wid . WID001 );
            if ( result )
            {
                XtraMessageBox . Show ( "删除成功" );
                DeleteTool ( );
                controlUnEnable ( );
                controlClear ( );
                getOddNum ( );
            }
            else
                XtraMessageBox . Show ( "删除失败" );

            return base . Delete ( );
        }
        protected override int Save ( )
        {
            if ( string . IsNullOrEmpty ( lupGoods . Text ) )
            {
                XtraMessageBox . Show ( "请选择排单号" );
                return 0;
            }
            if ( string . IsNullOrEmpty ( dateEdit . Text ) )
            {
                XtraMessageBox . Show ( "请选择派工时间" );
                return 0;
            }

            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );

            //if ( checkValue ( ) == false )
            //    return 0;

            if ( tableView . Rows . Count < 1 )
            {
                XtraMessageBox . Show ( "请增加需要排单的数据" );
                return 0;
            }

            getValue ( );

            if ( state . Equals ( "add" ) )
                result = _bll . Add ( tableView ,_wid );
            else
                result = _bll . Edit ( tableView ,_wid );

            if ( result )
            {
                XtraMessageBox . Show ( "保存成功" );
                controlUnEnable ( );
                SaveTool ( );
                getOddNum ( );
            }
            else
                XtraMessageBox . Show ( "保存失败,请重试" );

            return base . Save ( );
        }
        protected override int Cancel ( )
        {
            CancelTool ( state );
            controlUnEnable ( );

            return base . Cancel ( );
        }
        protected override int Print ( )
        {
            getPrintTable ( );

            Print ( new DataTable [ ] { printOne ,printTwo } ,"绕线表单.frx" );

            return base . Print ( );
        }
        protected override int Export ( )
        {
            getPrintTable ( );

            Export ( new DataTable [ ] { printOne ,printTwo } ,"绕线表单.frx" );

            return base . Export ( );
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
            _wid = _bll . tableHead ( strWhere );
            tableView = _bll . tableView ( strWhere );
            tableOddNum = _bll . getTableOnly ( "WID001" ,"MOXWID" );
        }
        private void backgroundWorker1_RunWorkerCompleted ( object sender ,System . ComponentModel . RunWorkerCompletedEventArgs e )
        {
            if ( e . Error == null )
            {
                wait . Hide ( );

                lupUserInfo . DataSource = _bll . getTableUser ( );
                lupUserInfo . DisplayMember = "DBA002";
                lupUserInfo . ValueMember = "DBA001";

                gridControl1 . DataSource = tableView;

                lupOddnNum . Properties . DataSource = tableOddNum;
                lupOddnNum . Properties . DisplayMember = "WID001";

                lupOddnNum . Text = _wid . WID001;

                if ( _wid != null )
                {
                    lupGoods . Text = _wid . WID002;
                    //lupUserIn . EditValue = _wid . WID003;
                    dateEdit . Text = _wid . WID005 . ToString ( );
                }
                QueryTool ( );
                controlUnEnable ( );
            }
        }
        private void btnAdd_Click ( object sender ,EventArgs e )
        {
            if ( string . IsNullOrEmpty ( lupGoods . Text ) )
            {
                XtraMessageBox . Show ( "请选择排单号" );
                return;
            }

            DataTable dt = _bll . getJobNumIn ( lupGoods . Text );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                for ( int i = 0 ; i < dt . Rows . Count ; i++ )
                {
                    DataRow row = dt . Rows [ i ];
                    _wie . WIE002 = row [ "WIE002" ] . ToString ( );
                    _wie . WIE005 = row [ "WIE005" ] . ToString ( );

                    if ( tableView . Select ( "WIE002='" + _wie . WIE002 + "' AND WIE005='" + _wie . WIE005 + "'" ) . Length < 1 )
                    {
                        DataRow rowOne = tableView . NewRow ( );
                        rowOne [ "WIE002" ] = _wie . WIE002;
                        rowOne [ "WIE003" ] = row [ "WIE003" ];
                        rowOne [ "WIE004" ] = row [ "WIE004" ];
                        rowOne [ "WIE005" ] = _wie . WIE005;
                        rowOne [ "WIE006" ] = row [ "WIE006" ];
                        rowOne [ "WIB004" ] = row [ "WIB004" ];
                        rowOne [ "WIB005" ] = row [ "WIB005" ];
                        rowOne [ "WIB006" ] = row [ "WIB006" ];
                        rowOne [ "WIB007" ] = row [ "WIB007" ];
                        rowOne [ "WIB008" ] = row [ "WIB008" ];
                        rowOne [ "WIB009" ] = row [ "WIB009" ];
                        rowOne [ "WIB010" ] = row [ "WIB010" ];
                        rowOne [ "WIE011" ] = string . Empty;
                        rowOne [ "WIE012" ] = string . Empty;
                        rowOne [ "SRT002" ] = row [ "SRT002" ];
                        tableView . Rows . Add ( rowOne );
                    }
                }
            }

        }
        private void gridView1_ShowingEditor ( object sender ,System . ComponentModel . CancelEventArgs e )
        {
            if ( gridView1 . DataRowCount > 0 )
            {
                if ( gridView1 . FocusedColumn . FieldName == "WIE007" )
                {
                    e . Cancel = true;
                }
                DataRow rowCheck = null;
                DataRow rowOne;
                int num = gridView1 . FocusedRowHandle;
                if ( num > 0 && num < gridView1 . DataRowCount - 1 )
                {
                    rowCheck = gridView1 . GetDataRow ( num - 1 );
                    rowOne = gridView1 . GetDataRow ( num );
                    if ( !rowCheck [ "WIB006" ] . ToString ( ) . Trim ( ) . Equals ( rowOne [ "WIB006" ] . ToString ( ) . Trim ( ) ) || !rowCheck [ "WIB009" ] . ToString ( ) . Trim ( ) . Equals ( rowOne [ "WIB009" ] . ToString ( ) . Trim ( ) ) && gridView1 . FocusedColumn . FieldName == "WIE007" )
                    {
                        e . Cancel = false;
                        //rowCheck = rowOne;
                    }
                }
            }
        }
        private void gridView1_CustomDrawCell ( object sender ,DevExpress . XtraGrid . Views . Base . RowCellCustomDrawEventArgs e )
        {
            if ( e . RowHandle >= 0 && e . RowHandle <= gridView1 . DataRowCount - 1 )
            {
                DevExpress . Utils . AppearanceDefault appGreen = new DevExpress . Utils . AppearanceDefault
                    ( Color . Black ,Color . Yellow ,Color . Empty ,Color . SeaShell ,System . Drawing . Drawing2D . LinearGradientMode . Horizontal );

                DataRow rowCheck = null;
                DataRow rowOne;

                rowCheck = gridView1 . GetDataRow ( e . RowHandle - 1 );
                rowOne = gridView1 . GetDataRow ( e . RowHandle );
                if ( rowCheck != null && rowOne != null )
                {
                    if ( e . Column . FieldName == "WIE007" )
                    {
                        if ( !rowCheck [ "WIB006" ] . ToString ( ) . Trim ( ) . Equals ( rowOne [ "WIB006" ] . ToString ( ) . Trim ( ) ) || !rowCheck [ "WIB009" ] . ToString ( ) . Trim ( ) . Equals ( rowOne [ "WIB009" ] . ToString ( ) . Trim ( ) ) && gridView1 . FocusedColumn . FieldName == "WIE007" )
                        {
                            DevExpress . Utils . AppearanceHelper . Apply ( e . Appearance ,appGreen );
                        }
                    }
                }

                if ( e . Column . FieldName == "WIE012" || e . Column . FieldName == "WIE013" || e . Column . FieldName == "WIE014" )
                {
                    DevExpress . Utils . AppearanceHelper . Apply ( e . Appearance ,appGreen );
                }
            }
        }
        private void gridView1_KeyPress ( object sender ,KeyPressEventArgs e )
        {
            if ( e . KeyChar == 13 )
            {
                int [ ] seleRow = gridView1 . GetSelectedRows ( );
                if ( seleRow . Length < 1 )
                {
                    XtraMessageBox . Show ( "请选择需要删除的内容" );
                    return;
                }
                if ( XtraMessageBox . Show ( "确认删除选中项?" ,"确认" ,MessageBoxButtons . OKCancel ) == DialogResult . Cancel )
                    return;
                Array . Reverse ( seleRow );
                foreach ( int i in seleRow )
                {
                    tableView . Rows . RemoveAt ( i );
                }
                gridControl1 . RefreshDataSource ( );
            }
        }
        private void lupUserInfo_EditValueChanged ( object sender ,EventArgs e )
        {
            DevExpress . XtraEditors . BaseEdit edit = gridView1 . ActiveEditor;
            DataRow row = gridView1 . GetFocusedDataRow ( );
            if ( row != null )
            {
                row = tableView . Rows [ gridView1 . FocusedRowHandle ];
                row . BeginEdit ( );
                row [ "WIE011" ] = edit . EditValue . ToString ( );
                row [ "WIE012" ] = edit . Text;
                row . EndEdit ( );
                gridControl1 . RefreshDataSource ( );
            }
        }
        private void secUser_EditValueChanged ( object sender ,EventArgs e )
        {
            DevExpress . XtraEditors . BaseEdit edit = gridView1 . ActiveEditor;
            switch ( gridView1 . FocusedColumn . FieldName )
            {
                case "WIE011":
                if ( edit . EditValue != null )
                {
                    gridView1 . SetFocusedRowCellValue ( gridView1 . Columns [ "WIE012" ] ,UserInfo . Select ( "WIE011='" + edit . EditValue . ToString ( ) + "'" ) [ 0 ] [ "WIE012" ] . ToString ( ) );
                }
                break;
            }
        }
        private void btnQ_Click ( object sender ,EventArgs e )
        {
            DataRow row = gridView1 . GetFocusedDataRow ( );
            if ( row != null )
            {
                //row = tableView . Rows [ gridView1 . FocusedRowHandle ];
                //row . BeginEdit ( );
                if ( row [ "WIE015" ] . ToString ( ) . Equals ( UserLogin . userName ) )
                {
                    row [ "WIE015" ] = string . Empty;
                    row [ "WIE016" ] = DBNull . Value;
                }
                else if ( string . IsNullOrEmpty ( row [ "WIE015" ] . ToString ( ) ) )
                {
                    row [ "WIE015" ] = UserLogin . userName;
                    row [ "WIE016" ] = UserLogin . userDt;
                }
                //row . EndEdit ( );
                //gridControl1 . RefreshDataSource ( );
            }
        }
        private void btnQ_ButtonClick ( object sender ,DevExpress . XtraEditors . Controls . ButtonPressedEventArgs e )
        {
           
        }
        #endregion

        #region Method
        void controlUnEnable ( )
        {
            lupGoods . Enabled =dateEdit . Enabled = false;
            gridView1 . OptionsBehavior . Editable = false;
            btnAdd . Enabled = false;
        }
        void controlEnable ( )
        {
            lupGoods . Enabled =  dateEdit . Enabled = true;
            gridView1 . OptionsBehavior . Editable = true;
            btnAdd . Enabled = true;
        }
        void controlClear ( )
        {
            tableView = null;
            gridControl1 . DataSource = null;
            lupGoods . EditValue =  null;
            dateEdit . Text = string . Empty;
        }
        void getValue ( )
        {
            _wid . WID001 = lupOddnNum . Text;
            _wid . WID002 = lupGoods . Text;
            _wid . WID005 = Convert . ToDateTime ( dateEdit . Text );
        }
        void getOddNum ( )
        {
            tableOddNum = _bll . getTableOnly ( "WID001" ,"MOXWID" );
            lupOddnNum . Properties . DataSource = tableOddNum;
            lupOddnNum . Properties . DisplayMember = "WID001";
            lupOddnNum . Text = _wid . WID001;
        }
        void getPrintTable ( )
        {
            printOne = _bll . getPrintOne ( _wid . WID001 );
            printOne . TableName = "MOXWID";
            printTwo = _bll . getPrintTwo ( _wid . WID001 );
            printTwo . TableName = "MOXWIE";
        }
        bool checkValue ( )
        {
            result = true;
            for ( int i = 0 ; i < gridView1 . DataRowCount ; i++ )
            {
                DataRow row = gridView1 . GetDataRow ( i );
                if ( string . IsNullOrEmpty ( row [ "WIE011" ] . ToString ( ) ) )
                {
                    XtraMessageBox . Show ( "人员信息不可为空" );
                    result = false;
                    return result;
                }
                return result;
            }
            return true;
        }
        #endregion

    }
}






