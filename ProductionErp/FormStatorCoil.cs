using System . Reflection;
using DevExpress . Utils . Paint;
using System . Data;
using System;
using DevExpress . XtraEditors;
using FastReport;
using System . Drawing;

namespace ProductionErp
{
    public partial class FormStatorCoil :FormChild
    {
        ProductionErpEntity.StatorCoilSTCEntity _stc=null;
        ProductionErpEntity.StatorCoilSTDEntity _std=null;
        ProductionErpBll.Bll.StatorCoilBll _bll=null;
        DataTable tableView,tablePrintOne,tablePrintTwo,tablePow;
        Report report=new Report();
        
        public FormStatorCoil ( )
        {
            InitializeComponent ( );

            _stc = new ProductionErpEntity . StatorCoilSTCEntity ( );
            _std = new ProductionErpEntity . StatorCoilSTDEntity ( );
            _bll = new ProductionErpBll . Bll . StatorCoilBll ( );
            tableView = new DataTable ( );
            tablePow = new DataTable ( );

            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            Utility . GridViewMoHuSelect . SetFilter ( View );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            barMenu . LinksPersistInfo . RemoveAt ( toolExport . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolDelete . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolAdd . Id );
            
            wait . Hide ( );
            controlUnEnable ( );

            DataTable userTable = _bll . getUserDataTable ( );
            txtUser . Properties . DataSource = userTable;
            txtUser . Properties . DisplayMember = "DBA002";
            txtUser . Properties . ValueMember = "DBA001";
        }
        
        #region Main
        protected override int Query ( )
        {
            Operation . FormStatorCoilQuery from = new Operation . FormStatorCoilQuery ( "定子绕圈组装" );
            if ( from . ShowDialog ( ) == System . Windows . Forms . DialogResult . OK )
            {
                _stc = new ProductionErpEntity . StatorCoilSTCEntity ( );
                _stc . STC001 = from . getCodeNum;

                wait . Show ( );
                backgroundWorker1 . RunWorkerAsync ( );
            }

            return base . Query ( );
        }
        protected override int Edit ( )
        {
            EditTool ( );
            controlEnable ( );

            return base . Edit ( );
        }
        protected override int Save ( )
        {
            if ( checkValue ( ) == false )
                return 0;
            getValue ( );

            bool result = _bll . Save ( _stc ,tableView );
            if ( result )
            {
                XtraMessageBox . Show ( "保存成功" );
                SaveTool ( );
                controlUnEnable ( );
            }
            else
                XtraMessageBox . Show ( "保存失败" );

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
            getPrintTable ( );

            Print ( new DataTable [ ] { tablePrintOne ,tablePrintTwo } ,"定子线圈组装过程卡片.frx" );

            return base . Print ( );
        }
        #endregion
        
        #region Event
        //Cell Merge
        private void gridView1_CellMerge ( object sender ,DevExpress . XtraGrid . Views . Grid . CellMergeEventArgs e )
        {
            int rowOne = e . RowHandle1;
            int rowTwo = e . RowHandle2;
            string valueOne = gridView1 . GetDataRow ( rowOne ) [ "STD002" ] . ToString ( );
            string valueTwo = gridView1 . GetDataRow ( rowTwo ) [ "STD002" ] . ToString ( );
            if ( valueOne != valueTwo )
            {
                e . Handled = true;
            }
        }
        private void gridView1_CustomDrawRowIndicator ( object sender ,DevExpress . XtraGrid . Views . Grid . RowIndicatorCustomDrawEventArgs e )
        {
            if ( e . Info . IsRowIndicator && e . RowHandle >= 0 )
            {
                e . Info . DisplayText = ( e . RowHandle + 1 ) . ToString ( );
            }
        }
        private void backgroundWorker1_DoWork ( object sender ,System . ComponentModel . DoWorkEventArgs e )
        {
            _bll . getCodeNum ( _stc . STC001 );
            tableView = _bll . tableView ( _stc . STC001 );
            _stc = _bll . getModel ( _stc . STC001 );
            //tablePow = _bll . getDataTablePowForArt ( UserLogin . userNum ,"定子线圈" );
        }
        private void backgroundWorker1_RunWorkerCompleted ( object sender ,System . ComponentModel . RunWorkerCompletedEventArgs e )
        {
            if ( e . Error == null )
            {
                wait . Hide ( );
                gridControl1 . DataSource = tableView;
                QueryTool ( );
                controlUnEnable ( );
                if ( _stc == null )
                    return;
                txtVoltage . Text = _stc . STC002 . ToString ( ) + "V";
                txtSpace . Text = _stc . STC004;
                txtLength . Text = _stc . STC005 . ToString ( );
                txtNum . Text = _stc . STC006;
                txtJobNum . Text = _stc . STC003;
                txtCodeNum . Text = _stc . STC001;
                txtUser . EditValue = _stc . STC007;
            }
        }
        private void gridView1_CustomRowCellEditForEditing ( object sender ,DevExpress . XtraGrid . Views . Grid . CustomRowCellEditEventArgs e )
        {
            int num = e . RowHandle;
            if ( num >= 0 && num <= gridView1 . DataRowCount - 1 )
            {
                string str = gridView1 . GetDataRow ( num ) [ "STD003" ] . ToString ( );
                if ( e . Column . Name == "STD004" && ( str . Contains ( "确认线圈匝数" ) ) )
                {
                    e . Column . OptionsColumn . AllowEdit = false;
                }
                else
                {
                    e . Column . OptionsColumn . AllowEdit = true;
                }
                if ( e . Column . Name == "STD004" && ( str . Contains ( "线包尺寸用卡板检验合格" ) || str . Contains ( "外观整齐，无漏绑" ) || str . Contains ( "槽楔整齐，无歪斜" ) || str . Contains ( "漆包线无破损" ) || str . Contains ( "绝缘纸维修剪" ) || str . Contains ( "引出线长度不够" ) || str . Contains ( "曹契装配不合格" ) || str . Contains ( "铁芯叠片翘起" ) || str . Contains ( "虚焊" ) || str . Contains ( "线包高度超出" ) || str . Contains ( "绑线松紧不够" ) || str . Contains ( "耐压2260V,测试一分钟无击穿" ) || str . Contains ( "匝间检验合格" ) ) )
                {
                    //e . RepositoryItem = new DevExpress . XtraEditors . Repository . RepositoryItemCheckEdit ( );
                    //e . RepositoryItem = new DevExpress . XtraEditors . Repository . RepositoryItemImageComboBox ( );
                    //DevExpress . XtraEditors . Repository . RepositoryItemImageComboBox cb = new DevExpress . XtraEditors . Repository . RepositoryItemImageComboBox ( );
                    //cb . Items . Add ( "合格" );
                    //cb . Items . Add ( "不合格" );
                    //cb . TextEditStyle = DevExpress . XtraEditors . Controls . TextEditStyles . DisableTextEditor;
                    e . RepositoryItem = repositoryItemComboBox2;
                }
            }
        }
        private void gridView1_ShowingEditor ( object sender ,System . ComponentModel . CancelEventArgs e )
        {
            int num = gridView1 . FocusedRowHandle;
            if ( num >= 0 && num <= gridView1 . DataRowCount - 1 )
            {
                string str = gridView1 . GetDataRow ( num ) [ "STD003" ] . ToString ( );
                if ( gridView1 . FocusedColumn . FieldName == "STD004" && ( str . Contains ( "确认线圈匝数" ) || str . Equals ( "接头数量" ) || str . Contains ( "确认线圈组数" ) || str . Contains ( "引出线规格(平方)" ) || str . Contains ( "引出线长度(mm)" ) || str . Contains ( "耐压2260V,测试一分钟无击穿" ) || str . Contains ( "匝间检验合格" ) || str . Contains ( "绝缘电阻(MΩ)" ) || str . Contains ( "(黄-绿)线间电阻(Ω)" ) || str . Contains ( "(绿-红)线间电阻(Ω)" ) || str . Contains ( "(黄-红)线间电阻(Ω)" ) || str . Contains ( "环境温度(℃)" ) || str . Contains ( "电阻不平衡度" ) || str . Contains ( "并联路数" ) ) )
                {
                    e . Cancel = true;
                }
                string stUser = gridView1 . GetDataRow ( num ) [ "STD007" ] . ToString ( );
                if ( gridView1 . FocusedColumn . FieldName == "STD004" && !string . IsNullOrEmpty ( stUser ) && !stUser . Equals ( UserLogin . userName ) )
                {
                    e . Cancel = true;
                }
                if ( gridView1 . FocusedColumn . FieldName == "STD006" && !string . IsNullOrEmpty ( stUser ) && !stUser . Equals ( UserLogin . userName ) )
                {
                    e . Cancel = true;
                }

                if ( num > 0 )
                {
                    _std . STD002 = gridView1 . GetDataRow ( num - 1 ) [ "STD002" ] . ToString ( );
                    string strSTD002 = gridView1 . GetDataRow ( num ) [ "STD002" ] . ToString ( );
                    if ( gridView1 . FocusedColumn . FieldName == "STD006" && _std . STD002 . Equals ( strSTD002 ) )
                    {
                        e . Cancel = true;
                    }
                }
            }
        }
        private void resButton_Click ( object sender ,EventArgs e )
        {
            DataRow row = gridView1 . GetFocusedDataRow ( );
            if ( row != null )
            {
                _std . STD007 = row [ "STD007" ] . ToString ( );
                _std . STD002 = row [ "STD002" ] . ToString ( );
                if ( string . IsNullOrEmpty ( _std . STD007 ) )
                {
                    for ( int i = 0 ; i < gridView1 . DataRowCount ; i++ )
                    {
                        row = gridView1 . GetDataRow ( i );
                        if ( row [ "STD002" ] . ToString ( ) . Equals ( _std . STD002 ) )
                        {
                            row [ "STD007" ] = UserLogin . userName;
                            row [ "STD008" ] = UserLogin . userDt;
                        }
                    }
                }
                else if ( _std . STD007 . Equals ( UserLogin . userName ) )
                {
                    for ( int i = 0 ; i < gridView1 . DataRowCount ; i++ )
                    {
                        row = gridView1 . GetDataRow ( i );
                        if ( row [ "STD002" ] . ToString ( ) . Equals ( _std . STD002 ) )
                        {
                            row [ "STD007" ] = string . Empty;
                            row [ "STD008" ] = DBNull . Value;
                        }
                    }
                }
            }
        }
        private void gridView1_RowCellStyle ( object sender ,DevExpress . XtraGrid . Views . Grid . RowCellStyleEventArgs e )
        {
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
                if ( e . Column . FieldName == "STD004" )
                {
                    string strTemp = gridView1 . GetRowCellValue ( e . RowHandle ,"STD003" ) . ToString ( ) . Trim ( );
                    string strMessage = gridView1 . GetRowCellValue ( e . RowHandle ,"STD004" ) . ToString ( ) . Trim ( );
                    if ( /*strTemp . Equals ( "接头数量" ) ||*/ strTemp . Equals ( "确认接头数量" ) || strTemp . Equals ( "焊接接头数量" ) || strTemp . Equals ( "出线端线尺寸合格" ) || strTemp . Equals ( "非出线端线包尺寸合格" )  || strTemp . Equals ( "线包尺寸用卡板检验合格" ) || strTemp . Equals ( "外观整齐，无漏绑" ) || strTemp . Equals ( "槽楔整齐，无歪斜" ) || strTemp . Equals ( "漆包线无破损" ) || strTemp . Equals ( "线包尺寸用卡板检验合格%" ) || strTemp . Equals ( "绝缘纸维修剪" ) || strTemp . Equals ( "引出线长度不够" ) || strTemp . Equals ( "曹契装配不合格" ) || strTemp . Equals ( "铁芯叠片翘起" ) || strTemp . Equals ( "虚焊" ) || strTemp . Equals ( "线包高度超出" ) || strTemp . Equals ( "绑线松紧不够" ) )
                    {
                        DevExpress . Utils . AppearanceHelper . Apply ( e . Appearance ,appYellow );
                    }
                }
            }
        }
        #endregion

        #region Method
        void controlEnable ( )
        {
            txtLength . Enabled = txtNum . Enabled = txtUser . Enabled = true;
            gridView1 . OptionsBehavior . Editable = true;
        }
        void controlUnEnable ( )
        {
            txtLength . Enabled = txtNum . Enabled = txtUser . Enabled = false;
            gridView1 . OptionsBehavior . Editable = false;
        }
        void getValue ( )
        {
            _stc . STC001 = txtCodeNum . Text;
            _stc . STC005 = string . IsNullOrEmpty ( txtLength . Text ) == true ? 0 : Convert . ToInt32 ( txtLength . Text );
            _stc . STC006 = txtNum . Text;
            _stc . STC007 = txtUser . EditValue . ToString ( );
            _stc . STC008 = txtUser . Text;
        }
        void getPrintTable ( )
        {
            tablePrintOne = _bll . getPrintOne ( _stc . STC001 );
            tablePrintOne . TableName = "MOXSTC";
            tablePrintTwo = _bll . getPrintTwo ( _stc . STC001 );
            tablePrintTwo . TableName = "MOXSTD";
        }
        bool checkValue ( )
        {
            bool result = true;
            gridView1 . CloseEditor ( );
            gridView1 . UpdateCurrentRow ( );
            DataRow row;
            for ( int i = 0 ; i < gridView1 . DataRowCount ; i++ )
            {
                row = gridView1 . GetDataRow ( i );
                if ( row != null )
                {
                    _std . STD003 = row [ "STD003" ] . ToString ( );
                    _std . STD004 = row [ "STD004" ] . ToString ( );
                    _std . STD006 = string . IsNullOrEmpty ( row [ "STD006" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( row [ "STD006" ] . ToString ( ) );
                    _std . STD007 = row [ "STD007" ] . ToString ( );
                    //row . ClearErrors ( );
                    if ( ( _std . STD003 . Equals ( "确认线圈匝数" ) || _std . STD003 . Equals ( "确认接头数量" ) || _std . STD003 . Equals ( "引出线规格(平方)" ) || _std . STD003 . Equals ( "耐压2260V,测试一分钟无击穿" ) ) && _std . STD006 > 0 && string . IsNullOrEmpty ( _std . STD007 ) )
                    {
                        //row . SetColumnError ( "STD007" ,"请签字  " );
                        XtraMessageBox . Show ( "请签字" );
                        result = false;
                        break;
                    }
                    if ( ( _std . STD003 . Equals ( "接头数量" ) || _std . STD003 . Equals ( "确认接头数量" ) || _std . STD003 . Equals ( "焊接接头数量" ) || _std . STD003 . Equals ( "出线端线尺寸合格" ) || _std . STD003 . Equals ( "非出线端线包尺寸合格" ) || _std . STD003 . Equals ( "耐压2260V，测试一分钟无击穿" ) || _std . STD003 . Equals ( "匝间检验合格" ) || _std . STD003 . Equals ( "绝缘电阻(MΩ)" ) || _std . STD003 . Equals ( "(绿-红)线间电阻(Ω)" ) || _std . STD003 . Equals ( "(黄-红)线间电阻(Ω)" ) || _std . STD003 . Equals ( "(黄-绿)线间电阻(Ω)" ) || _std . STD003 . Equals ( "环境温度(℃)" ) || _std . STD003 . Equals ( "电阻不平衡度" ) || _std . STD003 . Equals ( "线包尺寸用卡板检验合格%" ) || _std . STD003 . Equals ( "外观整齐，无漏绑" ) || _std . STD003 . Equals ( "槽楔整齐，无歪斜" ) || _std . STD003 . Equals ( "漆包线无破损" ) || _std . STD003 . Equals ( "绝缘纸维修剪" ) || _std . STD003 . Equals ( "引出线长度不够" ) || _std . STD003 . Equals ( "曹契装配不合格" ) || _std . STD003 . Equals ( "铁芯叠片翘起" ) || _std . STD003 . Equals ( "虚焊" ) || _std . STD003 . Equals ( "线包高度超出" ) || _std . STD003 . Equals ( "绑线松紧不够" ) ) && !string . IsNullOrEmpty ( _std . STD004 ) && string . IsNullOrEmpty ( _std . STD007 ) )
                    {
                        //row . SetColumnError ( "STD007" ,"请签字  " );
                        XtraMessageBox . Show ( "请签字" );
                        result = false;
                        break;
                    }
                }
            }

            if ( string . IsNullOrEmpty ( txtSM . Text ) )
            {
                XtraMessageBox . Show ( "扫描条码不可为空" );
                return false;
            }

            if ( !txtCodeNum . Text . Equals ( txtSM . Text ) )
            {
                XtraMessageBox . Show ( "条码和扫描条码不一致,请核实" );
                return false;
            }


            return result;
        }
        #endregion

    }
}