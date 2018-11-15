using System . Reflection;
using DevExpress . Utils . Paint;
using System . Data;
using System;
using DevExpress . XtraEditors;

namespace ProductionErp . Operation
{
    public partial class FormStatorCoilQuery :FormBase
    {
        string sign=string.Empty;
        public FormStatorCoilQuery ( string text )
        {
            InitializeComponent ( );
            
            this . Text = text;
            this . sign = text;
            
            Utility . GridViewMoHuSelect . SetFilter ( gridView1 );
            FieldInfo fi = typeof ( XPaint ) . GetField ( "graphics" ,BindingFlags . Static | BindingFlags . NonPublic );
            fi . SetValue ( null ,new DrawXPaint ( ) );

            ProductionErpBll . Bll . SingRowTableBll _bll = new ProductionErpBll . Bll . SingRowTableBll ( );
            DataTable tableView = new DataTable ( ); 

            if ( this . sign . Contains ( "定子" ) )
            {
                tableView = _bll . getTableOnly ( "SRT007" );
                SRT008 . Visible = false;
                SRT009 . Visible = false;
            }
            else if ( this . sign . Contains ( "制动器" ) )
            {
                tableView = _bll . getTableOnly ( "SRT008" );
                SRT007 . Visible = false;
                SRT009 . Visible = false;
            }
            else if ( this . sign . Contains ( "总装配" ) )
            {
                tableView = _bll . getTableOnly ( "SRT009" );
                SRT007 . Visible = false;
                SRT008 . Visible = false;
            }
            gridControl1 . DataSource = tableView;
        }

        private void gridView1_CustomDrawRowIndicator ( object sender ,DevExpress . XtraGrid . Views . Grid . RowIndicatorCustomDrawEventArgs e )
        {
            if ( e . Info . IsRowIndicator && e . RowHandle >= 0 )
            {
                e . Info . DisplayText = ( e . RowHandle + 1 ) . ToString ( );
            }
        }

        string codeNum=string.Empty;
        private void gridView1_DoubleClick ( object sender ,System . EventArgs e )
        {
            int num = gridView1 . FocusedRowHandle;
            if ( num >= 0 && num <= gridView1 . DataRowCount - 1 )
            {
                if ( this . sign . Contains ( "定子" ) )
                    codeNum = gridView1 . GetDataRow ( num ) [ "SRT007" ] . ToString ( );
                else if ( this . sign . Contains ( "制动器" ) )
                    codeNum = gridView1 . GetDataRow ( num ) [ "SRT008" ] . ToString ( );
                else if ( this . sign . Contains ( "总装配" ) )
                    codeNum = gridView1 . GetDataRow ( num ) [ "SRT009" ] . ToString ( );

                if ( !string . IsNullOrEmpty ( codeNum ) )
                    this . DialogResult = System . Windows . Forms . DialogResult . OK;
                else
                    XtraMessageBox . Show ( "条码为空,请重新选择" );
            }
        }

        public string getCodeNum
        {
            get
            {
                return codeNum;
            }
        }

    }
}