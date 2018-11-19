using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Collections;
using System . Data;
using System . Data . SqlClient;

namespace ProductionErpBll . Dao
{
    public class BrakeDao
    {
        /// <summary>
        /// doed it exists
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public bool getCodeNum ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT COUNT(1) FROM MOXBRA WHERE BRA001='{0}'" ,codeNum );

            if ( !SqlHelper . Exists ( strSql . ToString ( ) ) )
            {
                Add ( codeNum );
                readResult ( codeNum );
            }

            return true;
        }

        /// <summary>
        /// 读取制动器检测结果
        /// </summary>
        /// <param name="codeNum"></param>
        void readResult (string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT BRC005,BRC006,BRC007,BRC008,BRC009 FROM MOXBRC WHERE BRC001='{0}'" ,codeNum );

            DataTable table = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( table == null || table . Rows . Count < 1 )
                return;
            Hashtable SQLString = new Hashtable ( );
            ProductionErpEntity . BrakeBRBEntity model = new ProductionErpEntity . BrakeBRBEntity ( );
            model . BRB001 = codeNum;
            string result = table . Rows [ 0 ] [ "BRC005" ] . ToString ( );
            model . BRB002 = "工频耐压";
            model . BRB007 = string . IsNullOrEmpty ( result ) == true ? null : Convert . ToInt32 ( result ) == 0 ? "不合格" : "合格";
            edit_brb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "BRC006" ] . ToString ( );
            model . BRB002 = "绝缘电阻";
            model . BRB007 = string . IsNullOrEmpty ( result ) == true ? null : Convert . ToInt32 ( result ) == 0 ? "不合格" : "合格";
            edit_brb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "BRC007" ] . ToString ( );
            model . BRB002 = "直流电阻";
            model . BRB007 = string . IsNullOrEmpty ( result ) == true ? null : result;
            edit_brb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "BRC008" ] . ToString ( );
            model . BRB002 = "制动器最低启动电压能吸合";
            model . BRB007 = string . IsNullOrEmpty ( result ) == true ? null : Convert . ToInt32 ( result ) == 0 ? "不合格" : "合格";
            edit_brb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "BRC009" ] . ToString ( );
            model . BRB002 = "制动器开关动作判定";
            model . BRB007 = string . IsNullOrEmpty ( result ) == true ? null : Convert . ToInt32 ( result ) == 0 ? "不合格" : "合格";
            edit_brb ( SQLString ,strSql ,model );
            SqlHelper . ExecuteSqlTran ( SQLString );
        }

        /// <summary>
        /// add data to database
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public bool Add ( string codeNum )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );

            ProductionErpEntity . BrakeBRAEntity _bra = new ProductionErpEntity . BrakeBRAEntity ( );
            ProductionErpEntity . BrakeBRBEntity _brb = new ProductionErpEntity . BrakeBRBEntity ( );

            _bra . BRA001 = _brb . BRB001 = codeNum;
            DataTable table = getWinBase ( codeNum );
            if ( table != null && table . Rows . Count > 0 )
            {
                _bra . BRA002 = table . Rows [ 0 ] [ "SRT003" ] . ToString ( );
                _bra . BRA003 = table . Rows [ 0 ] [ "SRT004" ] . ToString ( );
                _bra . BRA004 = table . Rows [ 0 ] [ "SRT005" ] . ToString ( );
                add_bra ( SQLString ,strSql ,_bra );
            }
            else
                return false;

            _brb . BRB003 = string . Empty;
            _brb . BRB004 = string . Empty;
            _brb . BRB005 = null;
            add_brb_para ( SQLString ,strSql ,_brb );

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        /// <summary>
        /// query data from database
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        DataTable getWinBase ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT SRT003,SRT004,SRT005,SRT008 FROM MOXSRT WHERE SRT008='{0}'" ,codeNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        void add_bra ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity.BrakeBRAEntity _bra )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXBRA (" );
            strSql . Append ( "BRA001,BRA002,BRA003,BRA004) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@BRA001,@BRA002,@BRA003,@BRA004) " );
            SqlParameter [ ] parameter = {
                new SqlParameter("@BRA001",SqlDbType.NVarChar,50),
                new SqlParameter("@BRA002",SqlDbType.NVarChar,50),
                new SqlParameter("@BRA003",SqlDbType.NVarChar,50),
                new SqlParameter("@BRA004",SqlDbType.NVarChar,50)
            };
            parameter [ 0 ] . Value = _bra . BRA001;
            parameter [ 1 ] . Value = _bra . BRA002;
            parameter [ 2 ] . Value = _bra . BRA003;
            parameter [ 3 ] . Value = _bra . BRA004;

            SQLString . Add ( strSql ,parameter );
        }

        void add_brb_para ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . BrakeBRBEntity _brb )
        {
            _brb . BRB002 = "装线圈";
            _brb . BRB003 = "漆包线厂家";
            _brb . BRB006 = 1;
            _brb . BRB007 = "浙江洪波";
            add_brb ( SQLString ,strSql ,_brb );
            _brb . BRB002 = "装电磁铁";
            _brb . BRB003 = "铁芯条码";
            _brb . BRB006 = 2;
            _brb . BRB007 = string . Empty;
            add_brb ( SQLString ,strSql ,_brb );
            _brb . BRB002 = "装减震垫";
            _brb . BRB003 = "减震垫供应商";
            _brb . BRB006 = 3;
            _brb . BRB007 = "杭州万康";
            add_brb ( SQLString ,strSql ,_brb );
            _brb . BRB002 = "装配衔铁";
            _brb . BRB003 = "动板条码";
            _brb . BRB006 = 4;
            _brb . BRB007 = string . Empty;
            add_brb ( SQLString ,strSql ,_brb );
            _brb . BRB002 = "粘摩擦片";
            _brb . BRB003 = "摩擦片条码";
            _brb . BRB006 = 5;
            add_brb ( SQLString ,strSql ,_brb );
            //_brb . BRB002 = "粘摩擦片";
            //_brb . BRB006 = 6;
            //add_brb ( SQLString ,strSql ,_brb );
            //_brb . BRB002 = "装配衔铁";
            //_brb . BRB006 = 7;
            //add_brb ( SQLString ,strSql ,_brb );
            //_brb . BRB002 = "铣摩擦片";
            //_brb . BRB006 = 8;
            //add_brb ( SQLString ,strSql ,_brb );
            //_brb . BRB002 = "装松闸杆";
            //_brb . BRB006 = 9;
            //add_brb ( SQLString ,strSql ,_brb );
            //_brb . BRB002 = "装弹簧";
            //_brb . BRB006 = 10;
            //add_brb ( SQLString ,strSql ,_brb );
            //_brb . BRB002 = "总成";
            //_brb . BRB006 = 11;
            //add_brb ( SQLString ,strSql ,_brb );
            //_brb . BRB002 = "装开关";
            //_brb . BRB006 = 12;
            //add_brb ( SQLString ,strSql ,_brb );
            //_brb . BRB002 = "其他";
            //_brb . BRB006 = 13;
            //add_brb ( SQLString ,strSql ,_brb );
            _brb . BRB002 = "检验";
            _brb . BRB003 = "工频耐压";
            _brb . BRB006 = 6;
            add_brb ( SQLString ,strSql ,_brb );
            _brb . BRB003 = "绝缘电阻";
            _brb . BRB006 = 7;
            add_brb ( SQLString ,strSql ,_brb );
            _brb . BRB003 = "直流电阻";
            _brb . BRB006 = 8;
            add_brb ( SQLString ,strSql ,_brb );
            _brb . BRB003 = "制动器最低启动电压能吸合";
            _brb . BRB006 = 9;
            add_brb ( SQLString ,strSql ,_brb );
            _brb . BRB003 = "制动器开关动作判定";
            _brb . BRB006 = 10;
            add_brb ( SQLString ,strSql ,_brb );
            _brb . BRB003 = "制动器吸合释放噪音";
            _brb . BRB006 = 11;
            add_brb ( SQLString ,strSql ,_brb );
        }

        void add_brb ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . BrakeBRBEntity _brb )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXBRB (" );
            strSql . Append ( "BRB001,BRB002,BRB003,BRB004,BRB005,BRB006,BRB007) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@BRB001,@BRB002,@BRB003,@BRB004,@BRB005,@BRB006,@BRB007) " );
            SqlParameter [ ] parameteer = {
                new SqlParameter("@BRB001",SqlDbType.NVarChar,50),
                new SqlParameter("@BRB002",SqlDbType.NVarChar,50),
                new SqlParameter("@BRB003",SqlDbType.NVarChar,100),
                new SqlParameter("@BRB004",SqlDbType.NVarChar,50),
                new SqlParameter("@BRB005",SqlDbType.NVarChar,50),
                new SqlParameter("@BRB006",SqlDbType.Int,4),
                new SqlParameter("@BRB007",SqlDbType.NVarChar,50)
            };
            parameteer [ 0 ] . Value = _brb . BRB001;
            parameteer [ 1 ] . Value = _brb . BRB002;
            parameteer [ 2 ] . Value = _brb . BRB003;
            parameteer [ 3 ] . Value = _brb . BRB004;
            parameteer [ 4 ] . Value = _brb . BRB005;
            parameteer [ 5 ] . Value = _brb . BRB006;
            parameteer [ 6 ] . Value = _brb . BRB007;

            SQLString . Add ( strSql ,parameteer );
        }

        void edit_brb ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . BrakeBRBEntity _brb )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE MOXBRB SET " );
            strSql . Append ( "BRB007=@BRB007 " );
            strSql . Append ( "WHERE BRB001=@BRB001 AND " );
            strSql . Append ( "BRB002=@BRB002" );
            SqlParameter [ ] parameteer = {
                new SqlParameter("@BRB007",SqlDbType.NVarChar,50),
                new SqlParameter("@BRB001",SqlDbType.NVarChar,50),
                new SqlParameter("@BRB002",SqlDbType.NVarChar,50)
            };
            parameteer [ 0 ] . Value = _brb . BRB007;
            parameteer [ 1 ] . Value = _brb . BRB001;
            parameteer [ 2 ] . Value = _brb . BRB002;

            SQLString . Add ( strSql ,parameteer );
        }

        /// <summary>
        /// get data from database to view 
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public DataTable getTableView ( String codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT A.idx,BRB001,BRB002,BRB003,BRB004,BRB005,BRB007,BRB008 FROM MOXBRB A INNER JOIN MOXART B ON A.BRB002=B.ART001 INNER JOIN MOXARP C ON B.idx=C.ARP003 " );
            strSql . AppendFormat ( "WHERE BRB001='{0}' AND ARP004 LIKE '制动器%' AND ARP001='{1}' ORDER BY BRB006" ,codeNum ,CarpenterBll . UserInformation . UserNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get data from database
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public ProductionErpEntity . BrakeBRAEntity getModel ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT BRA001,BRA002,BRA003,BRA004 FROM MOXBRA " );
            strSql . AppendFormat ( "WHERE BRA001='{0}'" ,codeNum );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                return getModel ( dt . Rows [ 0 ] );
            }
            else
                return null;
        }

        ProductionErpEntity . BrakeBRAEntity getModel ( DataRow row )
        {
            ProductionErpEntity . BrakeBRAEntity _model = new ProductionErpEntity . BrakeBRAEntity ( );
            if ( row != null )
            {
                if ( row [ "BRA001" ] != null && row [ "BRA001" ] . ToString ( ) != string . Empty )
                    _model . BRA001 = row [ "BRA001" ] . ToString ( );
                if ( row [ "BRA002" ] != null && row [ "BRA002" ] . ToString ( ) != string . Empty )
                    _model . BRA002 = row [ "BRA002" ] . ToString ( );
                if ( row [ "BRA003" ] != null && row [ "BRA003" ] . ToString ( ) != string . Empty )
                    _model . BRA003 = row [ "BRA003" ] . ToString ( );
                if ( row [ "BRA004" ] != null && row [ "BRA004" ] . ToString ( ) != string . Empty )
                    _model . BRA004 = row [ "BRA004" ] . ToString ( );
            }

            return _model;
        }

        /// <summary>
        /// edit data to database
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Save ( DataTable table )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );

            ProductionErpEntity . BrakeBRAEntity _bra = new ProductionErpEntity . BrakeBRAEntity ( );
            ProductionErpEntity . BrakeBRBEntity _brb = new ProductionErpEntity . BrakeBRBEntity ( );

            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                _brb . BRB001 = table . Rows [ i ] [ "BRB001" ] . ToString ( );
                _brb . BRB002 = table . Rows [ i ] [ "BRB002" ] . ToString ( );
                _brb . BRB003 = table . Rows [ i ] [ "BRB003" ] . ToString ( );
                _brb . BRB004 = table . Rows [ i ] [ "BRB004" ] . ToString ( );
                if ( string . IsNullOrEmpty ( table . Rows [ i ] [ "BRB005" ] . ToString ( ) ) )
                    _brb . BRB005 = null;
                else
                    _brb . BRB005 = Convert . ToDateTime ( table . Rows [ i ] [ "BRB005" ] . ToString ( ) );
                _brb . idx = string . IsNullOrEmpty ( table . Rows [ i ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "idx" ] . ToString ( ) );
                _brb . BRB007 = table . Rows [ i ] [ "BRB007" ] . ToString ( );
                if ( string . IsNullOrEmpty ( table . Rows [ i ] [ "BRB008" ] . ToString ( ) ) )
                    _brb . BRB008 = null;
                else
                    _brb . BRB008 = Convert . ToInt32 ( table . Rows [ i ] [ "BRB008" ] . ToString ( ) );
                if ( Exists ( _brb . idx ) )
                    edit ( SQLString ,strSql ,_brb );
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        bool Exists ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT COUNT(1) FROM MOXBRB " );
            strSql . AppendFormat ( "WHERE idx={0}" ,idx );

            return SqlHelper . Exists ( strSql . ToString ( ) );
        }

        void edit ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . BrakeBRBEntity _brb )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE MOXBRB SET " );
            strSql . Append ( "BRB002=@BRB002," );
            strSql . Append ( "BRB003=@BRB003," );
            strSql . Append ( "BRB004=@BRB004," );
            strSql . Append ( "BRB005=@BRB005," );
            strSql . Append ( "BRB007=@BRB007," );
            strSql . Append ( "BRB008=@BRB008 " );
            strSql . Append ( "WHERE idx=@idx" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@BRB002",SqlDbType.NVarChar,50),
                new SqlParameter("@BRB003",SqlDbType.NVarChar,100),
                new SqlParameter("@BRB004",SqlDbType.NVarChar,50),
                new SqlParameter("@BRB005",SqlDbType.Date,3),
                new SqlParameter("@idx",SqlDbType.Int),
                new SqlParameter("@BRB007",SqlDbType.NVarChar,50),
                new SqlParameter("@BRB008",SqlDbType.Int)
            };
            parameter [ 0 ] . Value = _brb . BRB002;
            parameter [ 1 ] . Value = _brb . BRB003;
            parameter [ 2 ] . Value = _brb . BRB004;
            parameter [ 3 ] . Value = _brb . BRB005;
            parameter [ 4 ] . Value = _brb . idx;
            parameter [ 5 ] . Value = _brb . BRB007;
            parameter [ 6 ] . Value = _brb . BRB008;
            SQLString . Add ( strSql ,parameter );
        }

        /// <summary>
        /// get print data from datatable
        /// </summary>
        /// <returns></returns>
        public DataTable getPrintOne ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT BRA001,BRA002,BRA003,BRA004 FROM MOXBRA WHERE BRA001='{0}'" ,codeNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get print data from datatable
        /// </summary>
        /// <returns></returns>
        public DataTable getPrintTwo ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT BRB002,REPLACE(BRB003,CHAR(10),'') BRB003,BRB004,BRB005 FROM MOXBRB  WHERE BRB001='{0}' ORDER BY BRB006" ,codeNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取供应商
        /// </summary>
        /// <returns></returns>
        public DataTable getTableSup ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DGA002 BRB007,DGA002 BR FROM TPADGA WHERE DGA961='T'" );
            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
