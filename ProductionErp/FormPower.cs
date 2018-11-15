using System;
using System . Data;
using System . Windows . Forms;
using DevExpress . XtraEditors;
using System . Reflection;
using DevExpress . Utils . Paint;

namespace ProductionErp
{
    public partial class FormPower :FormChild
    {
        CarpenterBll.Bll.PowerBll _bll=null;
        CarpenterEntity.PowerEntity _model=null;
        string nameOfPerson=string.Empty,nameOfProgram=string.Empty;
        
        public FormPower ( )
        {
            InitializeComponent ( );
            
            _bll = new CarpenterBll . Bll . PowerBll ( );
            _model = new CarpenterEntity . PowerEntity ( );

            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );


            barMenu . LinksPersistInfo . RemoveAt ( toolExport . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolPrint . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolCancel . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolSave . Id );

            lupPerson . Properties . DataSource = _bll . GetPerson ( );
            lupPerson . Properties . DisplayMember = "DBA002";
            lupPerson . Properties . ValueMember = "DBA001";
            lupProgram . Properties . DataSource = _bll . GetProgram ( );
            lupProgram . Properties . DisplayMember = "FOR001";
            lupProgram . Properties . ValueMember = "FOR002";
        }

        #region Main
        protected override int Query ( )
        {
            string strWhere = "1=1";
            if ( !string . IsNullOrEmpty ( lupPerson . Text ) )
                strWhere = strWhere + " AND POW002='" + lupPerson . EditValue . ToString ( ) + "'";
            if ( !string . IsNullOrEmpty ( lupProgram . Text ) )
                strWhere = strWhere + " AND POW003='" + lupProgram . EditValue . ToString ( ) + "'";

            DataTable tableQuery = _bll . GetDataTable ( strWhere );
            gridControl1 . DataSource = tableQuery;

            QueryTool ( );

            return 0;
        }
        protected override int Delete ( )
        {
            if ( _model . idx < 1 )
            {
                XtraMessageBox . Show ( "请选择需要删除的内容" );
                return 0;
            }
            if ( XtraMessageBox . Show ( "确定删除选中内容?" ,"删除?" ,MessageBoxButtons . OKCancel ) == DialogResult . OK )
            {
                bool result = _bll . Delete ( _model . idx );
                if ( result == true )
                {
                    XtraMessageBox . Show ( "删除成功" );
                    Query ( );
                }
                else
                    XtraMessageBox . Show ( "删除失败,请重试" );
            }

            return 0;
        }
        protected override int Add ( )
        {
            Operation . PowerEdit form = new Operation . PowerEdit ( "增加" ,_model ,nameOfPerson ,nameOfProgram ,"add" );
            form . StartPosition = FormStartPosition . CenterScreen;
            DialogResult result = form . ShowDialog ( );
            if ( result == System . Windows . Forms . DialogResult . OK )
            {
                Query ( );
            }

            return 0;
        }
        protected override int Edit ( )
        {
            if ( _model . idx < 1 )
            {
                XtraMessageBox . Show ( "请选择需要编辑的内容" );
                return 0;
            }

            edit ( );

            return 0;
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
                DataRow row = gridView1 . GetDataRow ( num );
                _model . idx = string . IsNullOrEmpty ( row [ "idx" ] . ToString ( ) ) == true ? 0 : int . Parse ( row [ "idx" ] . ToString ( ) );
                _model . POW002 = row [ "POW002" ] . ToString ( );
                _model . POW003 = row [ "POW003" ] . ToString ( );
                _model . POW004 = string . IsNullOrEmpty ( row [ "POW004" ] . ToString ( ) ) == true ? false : bool . Parse ( row [ "POW004" ] . ToString ( ) );
                _model . POW005 = string . IsNullOrEmpty ( row [ "POW005" ] . ToString ( ) ) == true ? false : bool . Parse ( row [ "POW005" ] . ToString ( ) );
                _model . POW006 = string . IsNullOrEmpty ( row [ "POW006" ] . ToString ( ) ) == true ? false : bool . Parse ( row [ "POW006" ] . ToString ( ) );
                _model . POW007 = string . IsNullOrEmpty ( row [ "POW007" ] . ToString ( ) ) == true ? false : bool . Parse ( row [ "POW007" ] . ToString ( ) );
                _model . POW008 = string . IsNullOrEmpty ( row [ "POW008" ] . ToString ( ) ) == true ? false : bool . Parse ( row [ "POW008" ] . ToString ( ) );
                _model . POW009 = string . IsNullOrEmpty ( row [ "POW009" ] . ToString ( ) ) == true ? false : bool . Parse ( row [ "POW009" ] . ToString ( ) );
                _model . POW010 = string . IsNullOrEmpty ( row [ "POW010" ] . ToString ( ) ) == true ? false : bool . Parse ( row [ "POW010" ] . ToString ( ) );
                _model . POW011 = string . IsNullOrEmpty ( row [ "POW011" ] . ToString ( ) ) == true ? false : bool . Parse ( row [ "POW011" ] . ToString ( ) );
                _model . POW012 = string . IsNullOrEmpty ( row [ "POW012" ] . ToString ( ) ) == true ? false : bool . Parse ( row [ "POW012" ] . ToString ( ) );
                _model . POW013 = string . IsNullOrEmpty ( row [ "POW013" ] . ToString ( ) ) == true ? false : bool . Parse ( row [ "POW013" ] . ToString ( ) );
                _model . POW016 = string . IsNullOrEmpty ( row [ "POW016" ] . ToString ( ) ) == true ? false : bool . Parse ( row [ "POW016" ] . ToString ( ) );
                _model . POW017 = string . IsNullOrEmpty ( row [ "POW017" ] . ToString ( ) ) == true ? false : bool . Parse ( row [ "POW017" ] . ToString ( ) );
                nameOfPerson = row [ "DBA002" ] . ToString ( );
                nameOfProgram = row [ "FOR001" ] . ToString ( );
            }
        }
        private void gridView1_DoubleClick ( object sender ,EventArgs e )
        {
            CarpenterBll . UserInformation . TypeOfOper = "编辑";
            edit ( );
        }
        private void lupPerson_KeyPress ( object sender ,KeyPressEventArgs e )
        {
            if ( e . KeyChar == 8 )
            {
                lupPerson . EditValue = null;
            }
        }
        private void lupProgram_KeyPress ( object sender ,KeyPressEventArgs e )
        {
            if ( e . KeyChar == 8 )
            {
                lupProgram . EditValue = null;
            }
        }
        #endregion

        #region Method
        void edit ( )
        {
            Operation . PowerEdit form = new Operation . PowerEdit ( "编辑" ,_model ,nameOfPerson ,nameOfProgram ,"edit" );
            form . StartPosition = FormStartPosition . CenterScreen;
            DialogResult result = form . ShowDialog ( );
            if ( result == System . Windows . Forms . DialogResult . OK )
            {
                Query ( );
            }
        }
        #endregion

    }
}