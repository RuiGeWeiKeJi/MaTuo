
using System . Reflection;
using DevExpress . Utils . Paint;
using System . Data;
using System . Collections . Generic;
using System;
using DevExpress . XtraEditors;
using System . Windows . Forms;

namespace ProductionErp
{
    public partial class FormSingRowTable :FormChild
    {
        ProductionErpBll.Bll.SingRowTableBll _bll=null;
        ProductionErpEntity.SingRowTableSRTEntity model=null;
        DataTable tableViewOne,printOne;
        string strWhere = "1=1";
        List<int> strList=new List<int>();
        
        public FormSingRowTable ( )
        {
            InitializeComponent ( );

            _bll = new ProductionErpBll . Bll . SingRowTableBll ( );
            model = new ProductionErpEntity . SingRowTableSRTEntity ( );


            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            //barMenu . LinksPersistInfo . RemoveAt ( toolExport . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolCancel . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolSave . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolEdit . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolAdd . Id );

            getColumns ( );
        }
         
        #region Main
        protected override int Query ( )
        {
            strWhere = "1=1";

            if ( !string . IsNullOrEmpty ( lupGoods . Text ) )
                strWhere += " AND SRT002='" + lupGoods . Text + "'";
            if ( !string . IsNullOrEmpty ( lupProduct . Text ) )
                strWhere += " AND SRT003='" + lupProduct . EditValue . ToString ( ) + "'";

            tableViewOne = _bll . getTableOne ( strWhere );
            gridControl1 . DataSource = tableViewOne;


            QueryTool ( );

            return base . Query ( );
        }
        protected override int Print ( )
        {
            if ( getChoise ( ) == false )
            {
                XtraMessageBox . Show ( "请选择需要打印的数据" );
                return 0;
            }

            printOne = _bll . getPrintOne ( strList );
            printOne . TableName = "Table";
            Print ( new DataTable [ ] { printOne } ,"条码打印.frx" );

            return base . Print ( );
        }
        protected override int Export ( )
        {
            //if ( getChoise ( ) == false )
            //{
            //    XtraMessageBox . Show ( "请选择需要导出的数据" );
            //    return 0;
            //}

            //printOne = _bll . getPrintOne ( strList );
            //printOne . TableName = "Table";
            //Export ( new DataTable [ ] { printOne } ,"条码打印.frx" );

            ViewExport . ExportToExcel ( this . Text ,gridControl1 );

            return base . Export ( );
        }
        protected override int Delete ( )
        {
            if ( XtraMessageBox . Show ( "确认删除?" ,"删除" ,MessageBoxButtons . OKCancel ) == DialogResult . Cancel )
                return 0;

            if ( getChoise ( ) == false )
            {
                XtraMessageBox . Show ( "请选择需要删除的内容" );
                return 0;
            }

            bool result = _bll . Delete ( strList );
            if ( result )
                XtraMessageBox . Show ( "删除成功,请查询" );
            else
                XtraMessageBox . Show ( "删除失败" );

            return base . Delete ( );
        }
        #endregion

        #region Method
        void getColumns ( )
        {
            lupGoods . Properties . DataSource = _bll . getTableOnly ( "SRT002" ,"MOXSRT" );
            lupGoods . Properties . DisplayMember = "SRT002";
            lupProduct . Properties . DataSource = _bll . getTableOnly ( "SRT003,SRT004,SRT005" ,"MOXSRT" );
            lupProduct . Properties . DisplayMember = "SRT004";
            lupProduct . Properties . ValueMember = "SRT003";
        }
        bool getChoise ( )
        {
            strList . Clear ( );
            int [ ] idxInt = gridView1 . GetSelectedRows ( );
            foreach ( int i in idxInt )
            {
                model . idx = string . IsNullOrEmpty ( gridView1 . GetDataRow ( i ) [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( gridView1 . GetDataRow ( i ) [ "idx" ] . ToString ( ) );
                if ( model . idx > 0 && !strList . Contains ( model . idx ) )
                    strList . Add ( model . idx );
            }
            if ( strList . Count < 1 )
                return false;
            else
                return true;
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
        private void lupGoods_KeyPress ( object sender ,System . Windows . Forms . KeyPressEventArgs e )
        {
            if ( e . KeyChar == 8 )
            {
                lupGoods . EditValue = null;
            }
        }
        private void lupProduct_KeyPress ( object sender ,System . Windows . Forms . KeyPressEventArgs e )
        {
            if ( e . KeyChar == 8 )
            {
                lupProduct . EditValue = null;
            }
        }
        #endregion

    }
}