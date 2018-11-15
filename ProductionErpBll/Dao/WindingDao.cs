using System . Data;
using System . Text;
using StudentMgr;
using System;
using System . Collections;
using System . Data . SqlClient;

namespace ProductionErpBll . Dao
{
    public class WindingDao
    {
        /// <summary>
        /// get data list
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="tableNum"></param>
        /// <returns></returns>
        public DataTable getTableOnly ( string columns,string tableNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT DISTINCT {0} FROM {1} ORDER BY {0}" ,columns ,tableNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取工单号
        /// </summary>
        /// <returns></returns>
        public DataTable getTableGD ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT RAA001 FROM SGMRAA LEFT JOIN TPADEA ON DEA001=RAA015 LEFT JOIN (SELECT COUNT(1) COUN,SRT002 FROM MOXSRT INNER JOIN MOXWIE ON WIE005=SRT007 GROUP BY SRT002) A ON RAA001=SRT002 WHERE RAA020='N' AND RAA024='T' and DEA005='01' GROUP BY RAA001,RAA018,COUN HAVING RAA018>ISNULL(COUN,0)" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get user data
        /// </summary>
        /// <returns></returns>
        public DataTable getTableUser ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DISTINCT DBA001 WIE011,DBA002 WIE012 FROM TPADBA WHERE DBA001!='DS' ORDER BY DBA001" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get table of view
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable tableView (string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT B.idx,SRT002,WIE002,WIE003,CONVERT(DATE,RAA006,112)  WIE004,WIE005,WIE006,WIE007,WIE008,WIE009,WIE010,WIB004,WIB005,WIB006,WIB007,WIB008,WIB009,WIB010,WIE011,WIE012,WIE013,WIE014,WIE015,WIE016 FROM MOXWID A INNER JOIN MOXWIE B ON A.WID001=B.WIE001 INNER JOIN MOXWIB C ON B.WIE002=C.WIB001 LEFT JOIN MOXSRT ON SRT007=WIE005  INNER JOIN SGMRAA D ON SRT002=D.RAA001 " );
            strSql . AppendFormat ( "WHERE " + strWhere );
            strSql . Append ( " ORDER BY WIE002" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get table of head
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public ProductionErpEntity . WindingWIDEntity tableHead ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT WID001,WID002,WID003,WID004,WID005 FROM MOXWID " );
            strSql . AppendFormat ( "WHERE " + strWhere );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
                return GetModel ( dt . Rows [ 0 ] );
            else
                return null;
        }

        public ProductionErpEntity . WindingWIDEntity GetModel ( DataRow row )
        {
            ProductionErpEntity . WindingWIDEntity _model = new ProductionErpEntity . WindingWIDEntity ( );
            if ( row != null )
            {
                if ( row [ "WID001" ] != null )
                    _model . WID001 = row [ "WID001" ] . ToString ( );
                if ( row [ "WID002" ] != null )
                    _model . WID002 = row [ "WID002" ] . ToString ( );
                //if ( row [ "WID003" ] != null )
                //    _model . WID003 = row [ "WID003" ] . ToString ( );
                //if ( row [ "WID004" ] != null )
                //    _model . WID004 = row [ "WID004" ] . ToString ( );
                if ( row [ "WID005" ] != null && row [ "WID005" ] . ToString ( ) != "" )
                    _model . WID005 = DateTime . Parse ( row [ "WID005" ] . ToString ( ) );
            }
            return _model;
        }

        /// <summary>
        /// delete a single
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public bool Delete (string oddNum )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM MOXWID WHERE WID001='{0}'" ,oddNum );
            SQLString . Add ( strSql ,null );
            strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM MOXWIE WHERE WIE001='{0}'" ,oddNum );
            SQLString . Add ( strSql ,null );

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        /// <summary>
        /// add data of view to database
        /// </summary>
        /// <param name="table"></param>
        /// <param name="_wid"></param>
        /// <returns></returns>
        public bool Add ( DataTable table ,ProductionErpEntity.WindingWIDEntity _wid )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            _wid . WID001 = getOddNum ( );
            strSql . Append ( "INSERT INTO MOXWID (" );
            strSql . Append ( "WID001,WID002,WID005) " );//,WID003,WID004
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@WID001,@WID002,@WID005) " );//,@WID003,@WID004
            SqlParameter [ ] parameter = {
                new SqlParameter("@WID001",SqlDbType.NVarChar,50),
                new SqlParameter("@WID002",SqlDbType.NVarChar,50),
                //new SqlParameter("@WID003",SqlDbType.NVarChar,50),
                //new SqlParameter("@WID004",SqlDbType.NVarChar,50),
                new SqlParameter("@WID005",SqlDbType.Date,3)
            };
            parameter [ 0 ] . Value = _wid . WID001;
            parameter [ 1 ] . Value = _wid . WID002;
            //parameter [ 2 ] . Value = _wid . WID003;
            //parameter [ 3 ] . Value = _wid . WID004;
            parameter [ 2 ] . Value = _wid . WID005;
            SQLString . Add ( strSql ,parameter );

            ProductionErpEntity . WindingWIEEntity _wie = new ProductionErpEntity . WindingWIEEntity ( );

            _wie . WIE001 = _wid . WID001;

            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                _wie . WIE002 = table . Rows [ i ] [ "WIE002" ] . ToString ( );
                _wie . WIE003 = table . Rows [ i ] [ "WIE003" ] . ToString ( );
                if ( string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE004" ] . ToString ( ) ) )
                    _wie . WIE004 = null;
                else
                    _wie . WIE004 = Convert . ToDateTime ( table . Rows [ i ] [ "WIE004" ] . ToString ( ) );
                _wie . WIE005 = table . Rows [ i ] [ "WIE005" ] . ToString ( );
                _wie . WIE006 = string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE006" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "WIE006" ] . ToString ( ) );
                _wie . WIE007 = table . Rows [ i ] [ "WIE007" ] . ToString ( );
                _wie . WIE008 = string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE008" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "WIE008" ] . ToString ( ) );
                _wie . WIE009 = string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE009" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "WIE009" ] . ToString ( ) );
                _wie . WIE010 = string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE010" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "WIE010" ] . ToString ( ) );
                _wie . WIE011 = table . Rows [ i ] [ "WIE011" ] . ToString ( );
                _wie . WIE012 = table . Rows [ i ] [ "WIE012" ] . ToString ( );
                _wie . WIE013 = string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE013" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "WIE013" ] . ToString ( ) );
                _wie . WIE014 = string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE014" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "WIE014" ] . ToString ( ) );
                _wie . WIE015 = table . Rows [ i ] [ "WIE015" ] . ToString ( );
                if ( string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE016" ] . ToString ( ) ) )
                    _wie . WIE016 = null;
                else
                    _wie . WIE016 = Convert . ToDateTime ( table . Rows [ i ] [ "WIE016" ] . ToString ( ) );
                add_wie ( SQLString ,strSql ,_wie );
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        /// <summary>
        /// get oddNum
        /// </summary>
        /// <returns></returns>
        string getOddNum ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT MAX(WID001) WID001 FROM MOXWID " );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "WID001" ] . ToString ( ) ) )
                    return CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) + "001";
                else
                {
                    if ( dt . Rows [ 0 ] [ "WID001" ] . ToString ( ) . Substring ( 0 ,8 ) . Equals ( CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) ) )
                        return ( Convert . ToInt64 ( dt . Rows [ 0 ] [ "WID001" ] . ToString ( ) ) + 1 ) . ToString ( );
                    else
                        return CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) + "001";
                }
            }
            else
                return CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) + "001";
        }

        void add_wie ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . WindingWIEEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXWIE (" );
            strSql . Append ( "WIE001,WIE002,WIE003,WIE004,WIE005,WIE006,WIE007,WIE008,WIE009,WIE010,WIE011,WIE012,WIE013,WIE014,WIE015,WIE016) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@WIE001,@WIE002,@WIE003,@WIE004,@WIE005,@WIE006,@WIE007,@WIE008,@WIE009,@WIE010,@WIE011,@WIE012,@WIE013,@WIE014,@WIE015,@WIE016) " );
            SqlParameter [ ] parameter = {
                new SqlParameter("@WIE001",SqlDbType.NVarChar,50),
                new SqlParameter("@WIE002",SqlDbType.NVarChar,50),
                new SqlParameter("@WIE003",SqlDbType.NVarChar,50),
                new SqlParameter("@WIE004",SqlDbType.Date,3),
                new SqlParameter("@WIE005",SqlDbType.NVarChar,50),
                new SqlParameter("@WIE006",SqlDbType.Int,4),
                new SqlParameter("@WIE007",SqlDbType.NVarChar,50),
                new SqlParameter("@WIE008",SqlDbType.Int,4),
                new SqlParameter("@WIE009",SqlDbType.Int,4),
                new SqlParameter("@WIE010",SqlDbType.Decimal,9),
                new SqlParameter("@WIE011",SqlDbType.NVarChar,50),
                new SqlParameter("@WIE012",SqlDbType.NVarChar,50),
                new SqlParameter("@WIE013",SqlDbType.Int,4),
                new SqlParameter("@WIE014",SqlDbType.Int,4),
                new SqlParameter("@WIE015",SqlDbType.NVarChar,50),
                new SqlParameter("@WIE016",SqlDbType.Date,3)
            };
            parameter [ 0 ] . Value = _model . WIE001;
            parameter [ 1 ] . Value = _model . WIE002;
            parameter [ 2 ] . Value = _model . WIE003;
            parameter [ 3 ] . Value = _model . WIE004;
            parameter [ 4 ] . Value = _model . WIE005;
            parameter [ 5 ] . Value = _model . WIE006;
            parameter [ 6 ] . Value = _model . WIE007;
            parameter [ 7 ] . Value = _model . WIE008;
            parameter [ 8 ] . Value = _model . WIE009;
            parameter [ 9 ] . Value = _model . WIE010;
            parameter [ 10 ] . Value = _model . WIE011;
            parameter [ 11 ] . Value = _model . WIE012;
            parameter [ 12 ] . Value = _model . WIE013;
            parameter [ 13 ] . Value = _model . WIE014;
            parameter [ 14 ] . Value = _model . WIE015;
            parameter [ 15 ] . Value = _model . WIE016;

            SQLString . Add ( strSql ,parameter );
        }

        /// <summary>
        /// edit data of view to database 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="_wid"></param>
        /// <returns></returns>
        public bool Edit ( DataTable table ,ProductionErpEntity . WindingWIDEntity _wid )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE MOXWID SET " );
            //strSql . Append ( "WID003=@WID003," );
            //strSql . Append ( "WID004=@WID004," );
            strSql . Append ( "WID005=@WID005 " );
            strSql . Append ( "WHERE WID001=@WID001" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@WID001",SqlDbType.NVarChar,50),
                //new SqlParameter("@WID003",SqlDbType.NVarChar,50),
                //new SqlParameter("@WID004",SqlDbType.NVarChar,50),
                new SqlParameter("@WID005",SqlDbType.Date,3)
            };
            parameter [ 0 ] . Value = _wid . WID001;
            //parameter [ 1 ] . Value = _wid . WID003;
            //parameter [ 2 ] . Value = _wid . WID004;
            parameter [ 1 ] . Value = _wid . WID005;
            SQLString . Add ( strSql ,parameter );

            ProductionErpEntity . WindingWIEEntity _wie = new ProductionErpEntity . WindingWIEEntity ( );
            _wie . WIE001 = _wid . WID001;
            DataTable dt = getTable ( _wie . WIE001 );
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                _wie . WIE002 = table . Rows [ i ] [ "WIE002" ] . ToString ( );
                _wie . WIE003 = table . Rows [ i ] [ "WIE003" ] . ToString ( );
                if ( string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE004" ] . ToString ( ) ) )
                    _wie . WIE004 = null;
                else
                    _wie . WIE004 = Convert . ToDateTime ( table . Rows [ i ] [ "WIE004" ] . ToString ( ) );
                _wie . WIE005 = table . Rows [ i ] [ "WIE005" ] . ToString ( );
                _wie . WIE006 = string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE006" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "WIE006" ] . ToString ( ) );
                _wie . WIE007 = table . Rows [ i ] [ "WIE007" ] . ToString ( );
                _wie . WIE008 = string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE008" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "WIE008" ] . ToString ( ) );
                _wie . WIE009 = string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE009" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "WIE009" ] . ToString ( ) );
                _wie . WIE010 = string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE010" ] . ToString ( ) ) == true ? 0 : Convert . ToDecimal ( table . Rows [ i ] [ "WIE010" ] . ToString ( ) );
                _wie . idx = string . IsNullOrEmpty ( table . Rows [ i ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "idx" ] . ToString ( ) );
                _wie . WIE011 = table . Rows [ i ] [ "WIE011" ] . ToString ( );
                _wie . WIE012 = table . Rows [ i ] [ "WIE012" ] . ToString ( );
                _wie . WIE013 = string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE013" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "WIE013" ] . ToString ( ) );
                _wie . WIE014 = string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE014" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "WIE014" ] . ToString ( ) );
                _wie . WIE015 = table . Rows [ i ] [ "WIE015" ] . ToString ( );
                if ( string . IsNullOrEmpty ( table . Rows [ i ] [ "WIE016" ] . ToString ( ) ) )
                    _wie . WIE016 = null;
                else
                    _wie . WIE016 = Convert . ToDateTime ( table . Rows [ i ] [ "WIE016" ] . ToString ( ) );

                if ( dt . Select ( "WIE002='" + _wie . WIE002 + "' AND WIE005='" + _wie . WIE005 + "'" ) . Length > 0 )
                    edit_wie ( SQLString ,strSql ,_wie );
                else
                    add_wie ( SQLString ,strSql ,_wie );
            }

            for ( int i = 0 ; i < dt . Rows . Count ; i++ )
            {
                _wie . idx = string . IsNullOrEmpty ( dt . Rows [ i ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( dt . Rows [ i ] [ "idx" ] . ToString ( ) );
                _wie . WIE002 = dt . Rows [ i ] [ "WIE002" ] . ToString ( );
                _wie . WIE005 = dt . Rows [ i ] [ "WIE005" ] . ToString ( );
                if ( table . Select ( "WIE002='" + _wie . WIE002 + "' AND WIE005='" + _wie . WIE005 + "'" ) . Length < 1 )
                    delete_wie ( SQLString ,strSql ,_wie . idx );
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        /// <summary>
        /// get dataTable
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        DataTable getTable ( string oddNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,WIE002,WIE005 FROM MOXWIE " );
            strSql . AppendFormat ( "WHERE WIE001='{0}'" ,oddNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        void edit_wie ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . WindingWIEEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE MOXWIE SET " );
            strSql . Append ( "WIE007=@WIE007," );
            strSql . Append ( "WIE008=@WIE008," );
            strSql . Append ( "WIE009=@WIE009," );
            strSql . Append ( "WIE010=@WIE010," );
            strSql . Append ( "WIE011=@WIE011," );
            strSql . Append ( "WIE012=@WIE012," );
            strSql . Append ( "WIE013=@WIE013," );
            strSql . Append ( "WIE014=@WIE014," );
            strSql . Append ( "WIE015=@WIE015," );
            strSql . Append ( "WIE016=@WIE016 " );
            strSql . Append ( "WHERE idx=@idx" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@idx",SqlDbType.Int,4),
                new SqlParameter("@WIE007",SqlDbType.NVarChar,50),
                new SqlParameter("@WIE008",SqlDbType.Int,4),
                new SqlParameter("@WIE009",SqlDbType.Int,4),
                new SqlParameter("@WIE010",SqlDbType.Decimal,9),
                new SqlParameter("@WIE011",SqlDbType.NVarChar,50),
                new SqlParameter("@WIE012",SqlDbType.NVarChar,50),
                new SqlParameter("@WIE013",SqlDbType.Int,4),
                new SqlParameter("@WIE014",SqlDbType.Int,4),
                new SqlParameter("@WIE015",SqlDbType.NVarChar,50),
                new SqlParameter("@WIE016",SqlDbType.Date,3)
            };
            parameter [ 0 ] . Value = _model . idx;
            parameter [ 1 ] . Value = _model . WIE007;
            parameter [ 2 ] . Value = _model . WIE008;
            parameter [ 3 ] . Value = _model . WIE009;
            parameter [ 4 ] . Value = _model . WIE010;
            parameter [ 5 ] . Value = _model . WIE011;
            parameter [ 6 ] . Value = _model . WIE012;
            parameter [ 7 ] . Value = _model . WIE013;
            parameter [ 8 ] . Value = _model . WIE014;
            parameter [ 9 ] . Value = _model . WIE015;
            parameter [ 10 ] . Value = _model . WIE016;

            SQLString . Add ( strSql ,parameter );
        }

        void delete_wie ( Hashtable SQLString ,StringBuilder strSql ,int idx )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "DELETE FROM MOXWIE " );
            strSql . AppendFormat ( "WHERE idx={0}" ,idx );

            SQLString . Add ( strSql ,null );
        }

        /// <summary>
        /// get datatable of job num
        /// </summary>
        /// <param name="jobNum"></param>
        /// <returns></returns>
        public DataTable getJobNumIn ( string jobNum )
        {
            string jobNums = string . Empty;
            if ( !string . IsNullOrEmpty ( jobNum ) && jobNum . Contains ( "," ) )
            {
                string [ ] str = jobNum . Split ( ',' );
                foreach ( string s in str )
                {
                    string sss = s . Trim ( );

                    if ( string . IsNullOrEmpty ( jobNums ) )
                        jobNums = "'" + sss + "'";
                    else
                        jobNums = jobNums + "," + "'" + sss + "'";
                }
            }
            else
                jobNums = "'" + jobNum + "'";

            jobNums = jobNums . Trim ( );

            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT SRT002,SRT003 WIE002,SRT005 WIE003,CONVERT(DATE,RAA006,102) WIE004,CASE WHEN SRT007='' THEN CASE WHEN SRT008='' THEN SRT009 ELSE SRT008 END ELSE SRT007 END WIE005,SRT006 WIE006,WIB004,WIB005,WIB006,WIB007,WIB008,WIB009,WIB010 FROM MOXSRT A INNER JOIN SGMRAA B ON A.SRT002=B.RAA001 INNER JOIN MOXWIB C ON A.SRT003=C.WIB001 " );//CONVERT(DATE,RAA003,102) WIE004
            strSql . AppendFormat ( "WHERE SRT002 IN ({0})" ,jobNums );
            
            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get print table 
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public DataTable getPrintOne ( string oddNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT WID001,WID002,WID005 FROM MOXWID " );
            strSql . AppendFormat ( "WHERE WID001='{0}'" ,oddNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get print table
        /// </summary>
        /// <returns></returns>
        public DataTable getPrintTwo ( string OddNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT WIE002,WIE003,WIE004,WIE005,WIE006,WIE007,WIE008,WIE009,WIE010,WIB004,WIB005,WIB006,WIB007,WIB008,WIB009,WIB010,WIB012,WIE012 FROM MOXWID A INNER JOIN MOXWIE B ON A.WID001=B.WIE001 INNER JOIN MOXWIB C ON B.WIE002=C.WIB001 " );
            strSql . AppendFormat ( "WHERE WID001='{0}'" ,OddNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
