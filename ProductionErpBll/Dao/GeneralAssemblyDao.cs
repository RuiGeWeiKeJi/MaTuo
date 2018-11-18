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
                readResult ( codeNum );
            }

            return true;
        }

        void readResult ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT GEC005,GEC006,GEC007,GEC008,GEC009,GEC010,GEC011,GEC012,GEC013,GEC014,GEC015,GEC017,GEC018,GEC019,GEC020,GEC023,GEC024,GEC025,GEC026,GEC027 FROM MOXGEC WHERE GEC001='{0}'" ,codeNum );

            DataTable table = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( table == null || table . Rows . Count < 1 )
                return;
            Hashtable SQLString = new Hashtable ( );
            ProductionErpEntity . GeneralAssemblyGEBEntity model = new ProductionErpEntity . GeneralAssemblyGEBEntity ( );
            model . GEB001 = codeNum;
            string result = table . Rows [ 0 ] [ "GEC005" ] . ToString ( );
            model . GEB003 = "耐压（电机线圈对机壳）";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : Convert . ToInt32 ( result ) == 0 ? "不合格" : "合格";
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC006" ] . ToString ( );
            model . GEB003 = "耐压（制动器线圈对机壳）";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : Convert . ToInt32 ( result ) == 0 ? "不合格" : "合格";
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC007" ] . ToString ( );
            model . GEB003 = "绝缘（电机线圈对机壳）";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : Convert . ToInt32 ( result ) == 0 ? "不合格" : "合格";
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC008" ] . ToString ( );
            model . GEB003 = "绝缘（制动器线圈对机壳）";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : Convert . ToInt32 ( result ) == 0 ? "不合格" : "合格";
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC009" ] . ToString ( );
            model . GEB003 = "直流电阻UV";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : result;
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC010" ] . ToString ( );
            model . GEB003 = "直流电阻UW";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : result;
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC011" ] . ToString ( );
            model . GEB003 = "直流电阻VW";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : result;
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC012" ] . ToString ( );
            model . GEB003 = "直流电阻平均值";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : result;
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC013" ] . ToString ( );
            model . GEB003 = "直流电阻判定结果";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : Convert . ToInt32 ( result ) == 0 ? "不合格" : "合格";
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC014" ] . ToString ( );
            model . GEB003 = "制动器电阻数值1";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : result;
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC015" ] . ToString ( );
            model . GEB003 = "制动器电阻数值2";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : result;
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC017" ] . ToString ( );
            model . GEB003 = "振动速度";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : result;
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC018" ] . ToString ( );
            model . GEB003 = "制动器最低启动电压能吸合";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : result;
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC019" ] . ToString ( );
            model . GEB003 = "检测制动器开关动作次数";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : result;
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC023" ] . ToString ( );
            model . GEB003 = "制动力矩(电流法）1";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : Convert . ToInt32 ( result ) == 0 ? "不合格" : "合格";
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC024" ] . ToString ( );
            model . GEB003 = "制动力矩(电流法）2";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : Convert . ToInt32 ( result ) == 0 ? "不合格" : "合格";
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC025" ] . ToString ( );
            model . GEB003 = "空载电流";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : result;
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC026" ] . ToString ( );
            model . GEB003 = "空载电压";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : Convert . ToInt32 ( result ) == 0 ? "不合格" : "合格";
            edit_geb ( SQLString ,strSql ,model );
            result = table . Rows [ 0 ] [ "GEC027" ] . ToString ( );
            model . GEB003 = "空载功率";
            model . GEB004 = string . IsNullOrEmpty ( result ) == true ? null : result;
            edit_geb ( SQLString ,strSql ,model );

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
            _geb . GEB002 = "装曳引轮和转子";
            _geb . GEB003 = "曳引轮条码";
            _geb . GEB006 = 1;
            _geb . GEB008 = "压轴承";
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "转子条码";
            _geb . GEB006 = 2;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "贴磁钢";
            _geb . GEB003 = "磁钢条码";
            _geb . GEB006 = 3;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "压轴承";
            _geb . GEB003 = "大轴承条码";
            _geb . GEB006 = 4;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "小轴承条码";
            _geb . GEB006 = 5;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "转轴条码";
            _geb . GEB006 = 6;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "压线圈";
            _geb . GEB003 = "机座条码";
            _geb . GEB006 = 7;
            _geb . GEB008 = "压线圈";
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "压线圈";
            _geb . GEB003 = "定子绕组条码";
            _geb . GEB006 = 8;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "总装合成";
            _geb . GEB003 = "制动器条码";
            _geb . GEB006 = 9;
            _geb . GEB008 = "静音房";
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "装制动器";
            _geb . GEB003 = "编码器条码";
            _geb . GEB006 = 10;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB002 = "检验";
            _geb . GEB003 = "耐压（电机线圈对机壳）";
            _geb . GEB006 = 11;
            _geb . GEB008 = "";
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "耐压（制动器线圈对机壳）";
            _geb . GEB006 = 12;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "绝缘（电机线圈对机壳）";
            _geb . GEB006 = 13;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "绝缘（制动器线圈对机壳）";
            _geb . GEB006 = 14;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "直流电阻UV";
            _geb . GEB006 = 15;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "直流电阻UW";
            _geb . GEB006 = 16;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "直流电阻VW";
            _geb . GEB006 = 17;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "直流电阻平均值";
            _geb . GEB006 = 18;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "直流电阻判定结果";
            _geb . GEB006 = 19;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "制动器电阻数值1";
            _geb . GEB006 = 20;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "制动器电阻数值2";
            _geb . GEB006 = 21;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "噪音";
            _geb . GEB006 = 22;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "振动速度";
            _geb . GEB006 = 23;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "制动器最低启动电压能吸合";
            _geb . GEB006 = 24;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "检测制动器开关动作次数";
            _geb . GEB006 = 25;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "制动器吸合噪音";
            _geb . GEB006 = 26;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "制动器释放噪音";
            _geb . GEB006 = 27;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "制动力矩(电流法）1";
            _geb . GEB006 = 28;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "制动力矩(电流法）2";
            _geb . GEB006 = 29;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "空载电流";
            _geb . GEB006 = 30;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "空载电压";
            _geb . GEB006 = 31;
            add_geb ( SQLString ,strSql ,_geb );
            _geb . GEB003 = "空载功率";
            _geb . GEB006 = 32;
            add_geb ( SQLString ,strSql ,_geb );
        }

        void add_geb ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity .GeneralAssemblyGEBEntity _geb )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXGEB (" );
            strSql . Append ( "GEB001,GEB002,GEB003,GEB004,GEB005,GEB006,GEB007,GEB008) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@GEB001,@GEB002,@GEB003,@GEB004,@GEB005,@GEB006,@GEB007,@GEB008) " );
            SqlParameter [ ] parameteer = {
                new SqlParameter("@GEB001",SqlDbType.NVarChar,50),
                new SqlParameter("@GEB002",SqlDbType.NVarChar,50),
                new SqlParameter("@GEB003",SqlDbType.NVarChar,200),
                new SqlParameter("@GEB004",SqlDbType.NVarChar,200),
                new SqlParameter("@GEB005",SqlDbType.NVarChar,50),
                new SqlParameter("@GEB006",SqlDbType.Int,4),
                new SqlParameter("@GEB007",SqlDbType.Date,3),
                new SqlParameter("@GEB008",SqlDbType.NVarChar,50)
            };
            parameteer [ 0 ] . Value = _geb . GEB001;
            parameteer [ 1 ] . Value = _geb . GEB002;
            parameteer [ 2 ] . Value = _geb . GEB003;
            parameteer [ 3 ] . Value = _geb . GEB004;
            parameteer [ 4 ] . Value = _geb . GEB005;
            parameteer [ 5 ] . Value = _geb . GEB006;
            parameteer [ 6 ] . Value = _geb . GEB007;
            parameteer [ 7 ] . Value = _geb . GEB008;

            SQLString . Add ( strSql ,parameteer );
        }

        void edit_geb ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . GeneralAssemblyGEBEntity _geb )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE MOXGEB SET " );
            strSql . Append ( "GEB002=@GEB002 " );
            strSql . Append ( "WHERE GEB001=@GEB001 AND GEB003=@GEB003" );
            SqlParameter [ ] parameteer = {
                new SqlParameter("@GEB001",SqlDbType.NVarChar,50),
                new SqlParameter("@GEB002",SqlDbType.NVarChar,50),
                new SqlParameter("@GEB003",SqlDbType.NVarChar,200)
            };
            parameteer [ 0 ] . Value = _geb . GEB001;
            parameteer [ 1 ] . Value = _geb . GEB002;
            parameteer [ 2 ] . Value = _geb . GEB003;

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
            strSql . Append ( "SELECT A.idx,GEB001,GEB002,GEB003,GEB004,GEB005,GEB007,GEB008,GEB009 FROM MOXGEB A INNER JOIN MOXART B ON A.GEB003=B.ART001 INNER JOIN MOXARP C ON B.idx=C.ARP003 " );
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
