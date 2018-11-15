using FastReport;
using FastReport . Export . Xml;
using System;
using System . Collections . Generic;
using System . ComponentModel;
using System . Data;
using System . Drawing;
using System . Linq;
using System . Text;
using System . Windows . Forms;

namespace ProductionErp
{
    public partial class FormBase :DevExpress . XtraEditors . XtraForm
    {
        protected static DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel=new DevExpress.LookAndFeel.DefaultLookAndFeel();

        public FormBase ( )
        {
            InitializeComponent ( );
            defaultLookAndFeel . LookAndFeel . SkinName = "Office 2013";
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="printFile"></param>
        protected void Print ( DataTable [ ] dt ,string printFile )
        {
            DataSet ds = new DataSet ( );
            if ( dt . Length > 0 )
            {
                for ( int i = 0 ; i < dt . Length ; i++ )
                {
                    ds . Tables . Add ( dt [ i ] );
                }
            }

            if ( ds != null && ds . Tables . Count > 0 )
            {
                string file = Application . StartupPath + "\\" + printFile + "";
                Report report = new Report ( );
                report . Load ( file );
                report . RegisterData ( ds );
                report . Show ( );
            }

        }

        /// <summary>
        /// 导出Execl
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="printFile"></param>
        protected void Export ( DataTable [ ] dt ,string printFile )
        {
            DataSet ds = new DataSet ( );
            if ( dt . Length > 0 )
            {
                for ( int i = 0 ; i < dt . Length ; i++ )
                {
                    ds . Tables . Add ( dt [ i ] );
                }
            }

            if ( ds != null && ds . Tables . Count > 0 )
            {
                string file = Application . StartupPath + "\\" + printFile + "";
                Report report = new Report ( );
                report . Load ( file );
                report . RegisterData ( ds );
                report . Prepare ( );
                XMLExport exprots = new XMLExport ( );
                exprots . Export ( report );
            }
        }

    }
}
