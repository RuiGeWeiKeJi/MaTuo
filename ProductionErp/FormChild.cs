using System . Data;
using System . Windows . Forms;

namespace ProductionErp
{
    public partial class FormChild :FormBase
    {
        public FormChild ( )
        {
            InitializeComponent ( );

            toolReview . Id = 8;
            toolExamin . Id = 9;
            toolCancellation . Id = 10;
            
            //MessageBox . Show ( toolQuery . Caption + toolQuery . Id + "\n\r" + toolAdd . Caption + toolAdd . Id + "\n\r" + toolEdit . Caption + toolEdit . Id + "\n\r" + toolDelete . Caption + toolDelete . Id + "\n\r" + toolSave . Caption + toolSave . Id + "\n\r" + toolCancel . Caption + toolCancel . Id + "\n\r" + toolPrint . Caption + toolPrint . Id + "\n\r" + toolExport . Caption + toolExport . Id + "\n\r" + toolReview . Caption + toolReview . Id + "\n\r" + toolExamin . Caption + toolExamin . Id + "\n\r" + toolCancellation . Caption + toolCancellation . Id );


            barMenu . LinksPersistInfo . RemoveAt ( toolCancellation . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolExamin . Id );
            barMenu . LinksPersistInfo . RemoveAt ( toolReview . Id );
        }
        
        private void FormChild_Load ( object sender ,System . EventArgs e )
        {
            toolState ( );
            //Power ( );
        }

        void Power ( )
        {
            CarpenterBll . Bll . MainBll _bll = new CarpenterBll . Bll . MainBll ( );
            DataTable dt = _bll . GetDataTableBtnPower ( UserLogin . userNum ,UserLogin . programName );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                string btnPow = string . Empty;
                for ( int i = 0 ; i < dt . Rows . Count ; i++ )
                {
                    btnPow = dt . Rows [ 0 ] [ "POW011" ] . ToString ( );
                    if ( string . IsNullOrEmpty ( btnPow ) )
                        barMenu . LinksPersistInfo . RemoveAt ( toolCancel . Id );
                    else if ( btnPow == "False" )
                        barMenu . LinksPersistInfo . RemoveAt ( toolCancel . Id );
                    btnPow = dt . Rows [ 0 ] [ "POW010" ] . ToString ( );
                    if ( string . IsNullOrEmpty ( btnPow ) )
                        barMenu . LinksPersistInfo . RemoveAt ( toolSave . Id );
                    else if ( btnPow == "False" )
                        barMenu . LinksPersistInfo . RemoveAt ( toolSave . Id );
                    btnPow = dt . Rows [ 0 ] [ "POW007" ] . ToString ( );
                    if ( string . IsNullOrEmpty ( btnPow ) )
                        barMenu . LinksPersistInfo . RemoveAt ( toolEdit . Id );
                    else if ( btnPow == "False" )
                        barMenu . LinksPersistInfo . RemoveAt ( toolEdit . Id );
                    btnPow = dt . Rows [ 0 ] [ "POW006" ] . ToString ( );
                    if ( string . IsNullOrEmpty ( btnPow ) )
                        barMenu . LinksPersistInfo . RemoveAt ( toolDelete . Id );
                    else if ( btnPow == "False" )
                        barMenu . LinksPersistInfo . RemoveAt ( toolDelete . Id );
                    btnPow = dt . Rows [ 0 ] [ "POW005" ] . ToString ( );
                    if ( string . IsNullOrEmpty ( btnPow ) )
                        barMenu . LinksPersistInfo . RemoveAt ( toolAdd . Id );
                    else if ( btnPow == "False" )
                        barMenu . LinksPersistInfo . RemoveAt ( toolAdd . Id );
                    btnPow = dt . Rows [ 0 ] [ "POW004" ] . ToString ( );
                    if ( string . IsNullOrEmpty ( btnPow ) )
                        barMenu . LinksPersistInfo . RemoveAt ( toolQuery . Id );
                    else if ( btnPow == "False" )
                        barMenu . LinksPersistInfo . RemoveAt ( toolQuery . Id );         
                }
            }
            else if ( UserLogin . userNum != "00001" )
            {
                barMenu . Visible = false;

                //foreach ( ToolStripButton btn in toolStrip1 . Items )
                //{
                //    if ( btn . GetType ( ) == typeof ( ToolStripButton ) )
                //    {
                //        ToolStripButton toolBtn = btn as ToolStripButton;
                //        toolStrip1 . Items . Remove ( toolBtn );
                //    }
                //}
            }
        }

        void toolState ( )
        {
            toolQuery . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolAdd . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolEdit . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolSave . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolCancel . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolExport . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
        }

        private void toolQuery_ItemClick ( object sender ,DevExpress . XtraBars . ItemClickEventArgs e )
        {
            Query ( );
        }

        protected virtual int Query ( )
        {
            return 0;
        }

        protected void QueryTool ( )
        {
            toolQuery . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolAdd . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolEdit . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolSave . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolCancel . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolExport . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
        }

        private void toolAdd_ItemClick ( object sender ,DevExpress . XtraBars . ItemClickEventArgs e )
        {
            Add ( );
        }

        protected virtual int Add ( )
        {
            CarpenterBll . UserInformation . TypeOfOper = "新增";
            return 0;
        }

        protected void AddTool ( )
        {
            toolQuery . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolAdd . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolEdit . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolSave . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolCancel . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolExport . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
        }

        private void toolEdit_ItemClick ( object sender ,DevExpress . XtraBars . ItemClickEventArgs e )
        {
            Edit ( );
        }

        protected virtual int Edit ( )
        {
            CarpenterBll . UserInformation . TypeOfOper = "编辑";
            return 0;
        }

        protected void EditTool ( )
        {
            toolQuery . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolAdd . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolEdit . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolSave . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolCancel . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolExport . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
        }

        private void toolDelete_ItemClick ( object sender ,DevExpress . XtraBars . ItemClickEventArgs e )
        {
            Delete ( );
        }

        protected virtual int Delete ( )
        {
            CarpenterBll . UserInformation . TypeOfOper = "删除";
            return 0;
        }

        protected void DeleteTool ( )
        {
            toolQuery . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolAdd . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolEdit . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolSave . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolCancel . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolExport . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
        }

        private void toolSave_ItemClick ( object sender ,DevExpress . XtraBars . ItemClickEventArgs e )
        {
            Save ( );
        }

        protected virtual int Save ( )
        {
            CarpenterBll . UserInformation . TypeOfOper = "保存";
            return 0;
        }

        protected void SaveTool ( )
        {
            toolQuery . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolAdd . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolEdit . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolSave . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolCancel . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolExport . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
        }

        private void toolCancel_ItemClick ( object sender ,DevExpress . XtraBars . ItemClickEventArgs e )
        {
            Cancel ( );
        }

        protected virtual int Cancel ( )
        {
            CarpenterBll . UserInformation . TypeOfOper = "取消";
            return 0;
        }

        protected void CancelTool ( string state )
        {
            if ( state . Equals ( "add" ) )
            {
                toolQuery . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
                toolAdd . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
                toolEdit . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
                toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
                toolSave . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
                toolCancel . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
                toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
                toolExport . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            }
            else if ( state . Equals ( "edit" ) )
            {
                toolQuery . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
                toolAdd . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
                toolEdit . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
                toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
                toolSave . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
                toolCancel . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
                toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
                toolExport . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            }        
        }

        private void toolPrint_ItemClick ( object sender ,DevExpress . XtraBars . ItemClickEventArgs e )
        {
            Print ( );
        }

        protected virtual int Print ( )
        {
            return 0;
        }

        protected void PrintTool ( )
        {
            toolQuery . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolAdd . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolEdit . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolSave . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolCancel . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolExport . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
        }

        private void toolExport_ItemClick ( object sender ,DevExpress . XtraBars . ItemClickEventArgs e )
        {
            Export ( );
        }

        protected virtual int Export ( )
        {
            return 0;
        }

        protected void ExportTool ( )
        {
            toolQuery . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolAdd . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolEdit . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolDelete . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolSave . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolCancel . Visibility = DevExpress . XtraBars . BarItemVisibility . Never;
            toolPrint . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
            toolExport . Visibility = DevExpress . XtraBars . BarItemVisibility . Always;
        }

    }
}