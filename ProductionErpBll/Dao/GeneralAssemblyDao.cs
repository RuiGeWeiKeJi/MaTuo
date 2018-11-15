using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Data . SqlClient;
using System . Collections;
using System . Data;

namespace ProductionErpBll . Dao
{
    public class GeneralAssemblyDao
    {
        /// <summary>
        /// doed it exists
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public bool getCodeNum ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT COUNT(1) FROM MOXGEA WHERE GEA001='{0}'" ,codeNum );

            if ( !SqlHelper . Exists ( strSql . ToString ( ) ) )
            {
                Add ( codeNum );
            }

            return true;
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

            ProductionErpEntity . GeneralAssemblyGEAEntity _gea = new ProductionErpEntity . GeneralAssemblyGEAEntity ( );
            ProductionErpEntity . GeneralAssemblyGEBEntity _geb = new ProductionErpEntity . GeneralAssemblyGEBEntity ( );

            _gea . GEA001 = _geb . GEB001 = codeNum;
            DataTable table = getWinBase ( codeNum );
            if ( table != null && table . Rows . Count > 0 )
            {
                _gea . GEA002 = table . Rows [ 0 ] [ "SRT003" ] . ToString ( );
                _gea . GEA003 = table . Rows [ 0 ] [ "SRT004" ] . ToString ( );
                _gea . GEA004 = table . Rows [ 0 ] [ "SRT005" ] . ToString ( );
                add_gea ( SQLString ,strSql ,_gea );
            }
            else
                return false;

            _geb . GEB003 = string . Empty;
            _geb . GEB004 = string . Empty;
            _geb . GEB005 = null;
            _geb . GEB007 = null;
            add_geb_para ( SQLString ,strSql ,_geb );

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
            strSql . AppendFormat ( "SELECT SRT003,SRT004,SRT005,SRT008 FROM MOXSRT WHERE SRT009='{0}'" ,codeNum );
            
            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        void add_gea ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . GeneralAssemblyGEAEntity _gea )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXGEA (" );
            strSql . Append ( "GEA001,GEA002,GEA003,GEA004) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@GEA001,@GEA002,@GEA003,@GEA004) " );
            SqlParameter [ ] parameter = {
                new SqlParameter("@GEA001",SqlDbType.NVarChar,50),
                new SqlParameter("@GEA002",SqlDbType.NVarChar,50),
                new SqlParameter("@GEA003",SqlDbType.NVarChar,50),
                new SqlParameter("@GEA004",SqlDbType.NVarChar,50)
            };
            parameter [ 0 ] . Value = _gea . GEA001;
            parameter [ 1 ] . Value = _gea . GEA002;
            parameter [ 2 ] . Value = _gea . GEA003;
            parameter [ 3 ] . Value = _gea . GEA004;

            SQLString . Add ( strSql ,parameter );
        }

        void add_geb_para ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . GeneralAssemblyGEBEntity _geb )
        {
            _geb . GEB002 = "组装曳引轮+转子";
            _geb . GEB006 = 1;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "贴磁钢";
            _geb . GEB006 = 2;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "装齿圈";
            _geb . GEB006 = 3;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "装轴承";
            _geb . GEB006 = 4;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "组装机座+定子线圈";
            _geb . GEB006 = 5;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "定、转子压合";
            _geb . GEB006 = 6;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "喷漆";
            _geb . GEB006 = 7;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "装制动器";
            _geb . GEB006 = 8;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "接线盒等";
            _geb . GEB006 = 9;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "成品检验";
            _geb . GEB006 = 10;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "铭牌";
            _geb . GEB006 = 11;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "出货检验";
            _geb . GEB003 = "1、耐压：电机绕组与机壳间" + "\n\r" + "2、绝缘电阻：电机绕组" + "\n\r" + "3、制动器在最低启动电压能吸合" + "\n\r" + "4、空载电压、空载电流、频率" + "\n\r" + "5、空载振动、空载噪音" + "\n\r" + "6、单臂制动力矩（电流法）、两只制动器分别测试，记录电机电流折算制动力矩" + "\n\r" + "7、制动器吸合、释放噪音" + "\n\r" + "8、制动器开关动作（5次）";
            _geb . GEB006 = 12;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "包装箱";
            _geb . GEB006 = 13;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "入库";
            _geb . GEB006 = 14;
            add_geb ( SQLString ,strSql ,_geb );
        }

        void add_geb ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity .GeneralAssemblyGEBEntity _geb )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXGEB (" );
            strSql . Append ( "GEB001,GEB002,GEB003,GEB004,GEB005,GEB006,GEB007) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@GEB001,@GEB002,@GEB003,@GEB004,@GEB005,@GEB006,@GEB007) " );
            SqlParameter [ ] parameteer = {
                new SqlParameter("@GEB001",SqlDbType.NVarChar,50),
                new SqlParameter("@GEB002",SqlDbType.NVarChar,50),
                new SqlParameter("@GEB003",SqlDbType.NVarChar,200),
                new SqlParameter("@GEB004",SqlDbType.NVarChar,200),
                new SqlParameter("@GEB005",SqlDbType.NVarChar,50),
                new SqlParameter("@GEB006",SqlDbType.Int,4),
                new SqlParameter("@GEB007",SqlDbType.Date,3)
            };
            parameteer [ 0 ] . Value = _geb . GEB001;
            parameteer [ 1 ] . Value = _geb . GEB002;
            parameteer [ 2 ] . Value = _geb . GEB003;
            parameteer [ 3 ] . Value = _geb . GEB004;
            parameteer [ 4 ] . Value = _geb . GEB005;
            parameteer [ 5 ] . Value = _geb . GEB006;
            parameteer [ 6 ] . Value = _geb . GEB007;

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
            strSql . Append ( "SELECT A.idx,GEB001,GEB002,GEB003,GEB004,GEB005,GEB007 FROM MOXGEB A INNER JOIN MOXART B ON A.GEB002=B.ART001 INNER JOIN MOXARP C ON B.idx=C.ARP003 " );
            strSql . AppendFormat ( "WHERE GEB001='{0}' AND ARP004 LIKE '总装配%' AND ARP001='{1}' ORDER BY GEB006" ,codeNum ,CarpenterBll . UserInformation . UserNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get data from database
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public ProductionErpEntity . GeneralAssemblyGEAEntity getModel ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT GEA001,GEA002,GEA003,GEA004 FROM MOXGEA " );
            strSql . AppendFormat ( "WHERE GEA001='{0}'" ,codeNum );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                return getModel ( dt . Rows [ 0 ] );
            }
            else
                return null;
        }

        ProductionErpEntity . GeneralAssemblyGEAEntity getModel ( DataRow row )
        {
            ProductionErpEntity . GeneralAssemblyGEAEntity _model = new ProductionErpEntity . GeneralAssemblyGEAEntity ( );
            if ( row != null )
            {
                if ( row [ "GEA001" ] != null && row [ "GEA001" ] . ToString ( ) != string . Empty )
                    _model . GEA001 = row [ "GEA001" ] . ToString ( );
                if ( row [ "GEA002" ] != null && row [ "GEA002" ] . ToString ( ) != string . Empty )
                    _model . GEA002 = row [ "GEA002" ] . ToString ( );
                if ( row [ "GEA003" ] != null && row [ "GEA003" ] . ToString ( ) != string . Empty )
                    _model . GEA003 = row [ "GEA003" ] . ToString ( );
                if ( row [ "GEA004" ] != null && row [ "GEA004" ] . ToString ( ) != string . Empty )
                    _model . GEA004 = row [ "GEA004" ] . ToString ( );
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

            ProductionErpEntity . GeneralAssemblyGEAEntity _gea = new ProductionErpEntity . GeneralAssemblyGEAEntity ( );
            ProductionErpEntity . GeneralAssemblyGEBEntity _geb = new ProductionErpEntity . GeneralAssemblyGEBEntity ( );

            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                _geb . GEB001 = table . Rows [ i ] [ "GEB001" ] . ToString ( );
                _geb . GEB002 = table . Rows [ i ] [ "GEB002" ] . ToString ( );
                _geb . GEB003 = table . Rows [ i ] [ "GEB003" ] . ToString ( );
                _geb . GEB004 = table . Rows [ i ] [ "GEB004" ] . ToString ( );
                _geb . GEB005 = table . Rows [ i ] [ "GEB005" ] . ToString ( );
                if ( table . Rows [ i ] [ "GEB007" ] == null )
                    _geb . GEB007 = null;
                else
                    _geb . GEB007 = Convert . ToDateTime ( table . Rows [ i ] [ "GEB007" ] . ToString ( ) );
                _geb . idx = string . IsNullOrEmpty ( table . Rows [ i ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "idx" ] . ToString ( ) );
                if ( Exists ( _geb . idx ) )
                    edit ( SQLString ,strSql ,_geb );
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        bool Exists ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT COUNT(1) FROM MOXGEB " );
            strSql . AppendFormat ( "WHERE idx={0}" ,idx );

            return SqlHelper . Exists ( strSql . ToString ( ) );
        }

        void edit ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . GeneralAssemblyGEBEntity _geb )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE MOXGEB SET " );
            strSql . Append ( "GEB002=@GEB002," );
            strSql . Append ( "GEB003=@GEB003," );
            strSql . Append ( "GEB004=@GEB004," );
            strSql . Append ( "GEB005=@GEB005," );
            strSql . Append ( "GEB007=@GEB007 " );
            strSql . Append ( "WHERE idx=@idx" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@GEB002",SqlDbType.NVarChar,50),
                new SqlParameter("@GEB003",SqlDbType.NVarChar,200),
                new SqlParameter("@GEB004",SqlDbType.NVarChar,200),
                new SqlParameter("@GEB005",SqlDbType.NVarChar,50),
                new SqlParameter("@GEB007",SqlDbType.Date,3),
                new SqlParameter("@idx",SqlDbType.NVarChar,50)
            };
            parameter [ 0 ] . Value = _geb . GEB002;
            parameter [ 1 ] . Value = _geb . GEB003;
            parameter [ 2 ] . Value = _geb . GEB004;
            parameter [ 3 ] . Value = _geb . GEB005;
            parameter [ 4 ] . Value = _geb . GEB007;
            parameter [ 5 ] . Value = _geb . idx;
            SQLString . Add ( strSql ,parameter );
        }

        /// <summary>
        /// get print data from datatable
        /// </summary>
        /// <returns></returns>
        public DataTable getPrintOne ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT GEA001,GEA002,GEA003,GEA004 FROM MOXGEA WHERE GEA001='{0}'" ,codeNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get print data from datatable
        /// </summary>
        /// <returns></returns>
        public DataTable getPrintTwo ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT GEB002,REPLACE(GEB003,CHAR(10),'') GEB003,GEB004,GEB005 FROM MOXGEB  WHERE GEB001='{0}' ORDER BY GEB006" ,codeNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }
    }
}
