using System . Text;
using StudentMgr;
using System . Data;
using System . Collections;
using System;
using System . Data . SqlClient;
using System . Collections . Generic;

namespace ProductionErpBll . Dao
{
    public class SingleRowDao
    {
        /// <summary>
        /// get product information
        /// </summary>
        /// <returns></returns>
        public DataTable getTableGoods ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT RAA001,RAA015,CONVERT(DECIMAL(11,0),RAA018) RAA018,RAA021,DEA057,DEA002,DEA004,CASE WHEN DED002='01' THEN 1 ELSE 0 END checkOne,CASE WHEN DED002='02' THEN 1 ELSE 0 END checkTwo,CASE WHEN DED002='03' THEN 1 ELSE 0 END checkTre FROM SGMRAA A INNER JOIN TPADEA B ON A.RAA015=B.DEA001 INNER JOIN TPADED C ON B.DEA005=C.DED002 WHERE RAA020='N' AND RAA024='T' AND (RAA032='F' OR RAA032='')  " );//
            strSql . Append ( "AND " + strWhere );
            
            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// save data to srt
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool GenerMOXSRT ( DataTable table ,List<string> idxList )
        {
            ProductionErpEntity . SingRowTableSRTEntity _model = new ProductionErpEntity . SingRowTableSRTEntity ( );
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            Hashtable strList = new Hashtable ( );
            int checkOne = 0, checkTwo = 0, checkTre = 0;

            _model . SRT001 = getOddNum_SRT ( );
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                checkOne = string . IsNullOrEmpty ( table . Rows [ i ] [ "checkOne" ] . ToString ( ) ) == true ? 0 : ( int ) table . Rows [ i ] [ "checkOne" ];
                checkTwo = string . IsNullOrEmpty ( table . Rows [ i ] [ "checkTwo" ] . ToString ( ) ) == true ? 0 : ( int ) table . Rows [ i ] [ "checkTwo" ];
                checkTre = string . IsNullOrEmpty ( table . Rows [ i ] [ "checkTre" ] . ToString ( ) ) == true ? 0 : ( int ) table . Rows [ i ] [ "checkTre" ];

                _model . SRT002 = table . Rows [ i ] [ "RAA001" ] . ToString ( );
                _model . SRT003 = table . Rows [ i ] [ "RAA015" ] . ToString ( );
                if ( idxList . Contains ( _model . SRT002 + _model . SRT003 ) )
                {
                    _model . SRT006 = string . IsNullOrEmpty ( table . Rows [ i ] [ "RAA018" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "RAA018" ] . ToString ( ) );
                    _model . SRT006 = Exists_SRT ( _model );
                    if ( _model . SRT006 > 0 )
                    {
                        _model . SRT004 = table . Rows [ i ] [ "DEA002" ] . ToString ( );
                        _model . SRT005 = table . Rows [ i ] [ "DEA057" ] . ToString ( );
                        _model . SRT007 = _model . SRT008 = _model . SRT009 = string . Empty;
                        _model . SRT010 = table . Rows [ i ] [ "RAA021" ] . ToString ( );
                        for ( int k = 0 ; k < _model . SRT006 ; k++ )
                        {
                            if ( checkOne == 1 )
                                _model . SRT007 = "000" + codeNum_SRT ( _model . SRT003 ,table . Rows [ i ] [ "DEA004" ] . ToString ( ) ,strList ,"SRT007" );
                            if ( checkTwo == 1 )
                                _model . SRT008 = "000" + codeNum_SRT ( _model . SRT003 ,table . Rows [ i ] [ "DEA004" ] . ToString ( ) ,strList ,"SRT008" );
                            if ( checkTre == 1 )
                                _model . SRT009 = "000" + codeNum_SRT ( _model . SRT003 ,table . Rows [ i ] [ "DEA004" ] . ToString ( ) ,strList ,"SRT009" );
                            add_SRT ( SQLString ,strSql ,_model );
                        }
                        edit_raa ( SQLString ,strSql ,_model );
                    }
                }
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        /// <summary>
        /// does it exists job number and product num
        /// </summary>
        /// <param name="_model"></param>
        /// <returns></returns>
        int Exists_SRT ( ProductionErpEntity . SingRowTableSRTEntity _model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT {0}-COUNT(1) COUN FROM MOXSRT " ,_model . SRT006 );
            strSql . AppendFormat ( "WHERE SRT002='{0}' AND SRT003='{1}'" ,_model . SRT002 ,_model . SRT003 );
            //strSql . AppendFormat ( "WHERE  SRT003='{0}'" ,_model . SRT003 );

            DataTable da = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( da != null && da . Rows . Count > 0 )
                return string . IsNullOrEmpty ( da . Rows [ 0 ] [ "COUN" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( da . Rows [ 0 ] [ "COUN" ] . ToString ( ) );
            else
                return 0;
        }

        /// <summary>
        /// get single row num
        /// </summary>
        /// <returns></returns>
        string getOddNum_SRT ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT MAX(SRT001) SRT001 FROM MOXSRT" );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "SRT001" ] . ToString ( ) ) )
                    return CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) + "001";
                else
                {
                    if ( dt . Rows [ 0 ] [ "SRT001" ] . ToString ( ) . Substring ( 0 ,8 ) . Equals ( CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) ) )
                        return ( Convert . ToInt64 ( dt . Rows [ 0 ] [ "SRT001" ] . ToString ( ) ) + 1 ) . ToString ( );
                    else
                        return CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) + "001";
                }
            }
            else
                return CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) + "001";
        }

        /// <summary>
        /// get code num of same job number
        /// </summary>
        /// <param name="jobNumber"></param>
        /// <returns></returns>
        string codeNum_SRT ( string jobNumber ,string dea004 ,Hashtable strList ,string columns)
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT MAX({0}) {0} FROM MOXSRT " ,columns );
            strSql . AppendFormat ( "WHERE SRT003='{0}' AND {2} LIKE '000{1}%'" ,jobNumber ,dea004 ,columns );

            string codeNum = string . Empty;
            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( dt . Rows [ 0 ] [ columns ] . ToString ( ) ) )
                    codeNum = string . Empty;
                else
                    codeNum = dt . Rows [ 0 ] [ columns ] . ToString ( );
            }
            else
                codeNum = string . Empty;

            if ( string . IsNullOrEmpty ( codeNum ) )
            {
                codeNum = dea004 + CarpenterBll . UserInformation . dt ( ) . Year . ToString ( ) . Substring ( 2 ,2 ) + "00001";
                if ( strList . ContainsKey ( jobNumber ) )
                {
                    codeNum = strList [ jobNumber ] . ToString ( );
                    codeNum = ( Convert . ToInt64 ( codeNum ) + 1 ) . ToString ( );
                    strList . Remove ( jobNumber );
                    strList . Add ( jobNumber ,codeNum );
                }
                else
                    strList . Add ( jobNumber ,codeNum );
            }
            else
            {
                if ( strList . ContainsKey ( jobNumber ) )
                {
                    codeNum = strList [ jobNumber ] . ToString ( );
                    codeNum = ( Convert . ToInt64 ( codeNum ) + 1 ) . ToString ( );
                    strList . Remove ( jobNumber );
                    strList . Add ( jobNumber ,codeNum );
                }
                else
                {
                    codeNum = ( Convert . ToInt64 ( codeNum ) + 1 ) . ToString ( );
                    strList . Add ( jobNumber ,codeNum );
                }
            }

            return codeNum;
        }

        /// <summary>
        /// add srt
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="_model"></param>
        void add_SRT ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . SingRowTableSRTEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXSRT (" );
            strSql . Append ( "SRT001,SRT002,SRT003,SRT004,SRT005,SRT006,SRT007,SRT008,SRT009,SRT010) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@SRT001,@SRT002,@SRT003,@SRT004,@SRT005,@SRT006,@SRT007,@SRT008,@SRT009,@SRT010) " );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@SRT001", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRT002", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRT003", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRT004", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRT005", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRT006", SqlDbType.Int,4),
                    new SqlParameter("@SRT007", SqlDbType.VarChar,50),
                    new SqlParameter("@SRT008", SqlDbType.VarChar,50),
                    new SqlParameter("@SRT009", SqlDbType.VarChar,50),
                    new SqlParameter("@SRT010", SqlDbType.VarChar,100)
            };
            parameters [ 0 ] . Value = model . SRT001;
            parameters [ 1 ] . Value = model . SRT002;
            parameters [ 2 ] . Value = model . SRT003;
            parameters [ 3 ] . Value = model . SRT004;
            parameters [ 4 ] . Value = model . SRT005;
            parameters [ 5 ] . Value = 1;
            parameters [ 6 ] . Value = model . SRT007;
            parameters [ 7 ] . Value = model . SRT008;
            parameters [ 8 ] . Value = model . SRT009;
            parameters [ 9 ] . Value = model . SRT010;

            SQLString . Add ( strSql ,parameters );
        }

        /// <summary>
        /// edit sign to sgmraa
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="model"></param>
        void edit_raa ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . SingRowTableSRTEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE SGMRAA SET " );
            strSql . Append ( "RAA032='T' " );
            strSql . AppendFormat ( "WHERE RAA001='{0}'" ,model . SRT002 );

            SQLString . Add ( strSql ,null );
        }

        /// <summary>
        /// save data to sru
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool GenerMOXSRU ( DataTable table )
        {
            ProductionErpEntity . SingRowTableSRUEntity _model = new ProductionErpEntity . SingRowTableSRUEntity ( );
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            Hashtable strList = new Hashtable ( );
            bool check = false;

            _model . SRU001 = getOddNum_SRU ( );
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                check = string . IsNullOrEmpty ( table . Rows [ i ] [ "checkTwo" ] . ToString ( ) ) == true ? false : ( bool ) table . Rows [ i ] [ "checkTwo" ];
                if ( check )
                {
                    _model . SRU002 = table . Rows [ i ] [ "RAA001" ] . ToString ( );
                    _model . SRU003 = table . Rows [ i ] [ "RAA015" ] . ToString ( );
                    if ( Exists_SRU ( _model ) )
                    {
                        _model . SRU004 = table . Rows [ i ] [ "DEA002" ] . ToString ( );
                        _model . SRU005 = table . Rows [ i ] [ "DEA057" ] . ToString ( );
                        _model . SRU006 = string . IsNullOrEmpty ( table . Rows [ i ] [ "RAA018" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "RAA018" ] . ToString ( ) );
                        _model . SRU007 = codeNum_SRU ( _model . SRU002 ,table . Rows [ i ] [ "DEA004" ] . ToString ( ) ,strList );
                        add_SRU ( SQLString ,strSql ,_model );
                    }
                }
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );

        }

        /// <summary>
        /// get single row num
        /// </summary>
        /// <returns></returns>
        string getOddNum_SRU ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT MAX(SRU001) SRU001 FROM MOXSRU" );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "SRU001" ] . ToString ( ) ) )
                    return CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) + "001";
                else
                {
                    if ( dt . Rows [ 0 ] [ "SRU001" ] . ToString ( ) . Substring ( 0 ,8 ) . Equals ( CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) ) )
                        return ( Convert . ToInt64 ( dt . Rows [ 0 ] [ "SRU001" ] . ToString ( ) ) + 1 ) . ToString ( );
                    else
                        return CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) + "001";
                }
            }
            else
                return CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) + "001";
        }

        /// <summary>
        /// does it exists job number and product num
        /// </summary>
        /// <param name="_model"></param>
        /// <returns></returns>
        bool Exists_SRU ( ProductionErpEntity . SingRowTableSRUEntity _model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT COUNT(1) FROM MOXSRU " );
            strSql . AppendFormat ( "WHERE SRU002='{0}' AND SRU003='{1}'" ,_model . SRU002 ,_model . SRU003 );

            return SqlHelper . Exists ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get code num of same job number
        /// </summary>
        /// <param name="jobNumber"></param>
        /// <returns></returns>
        string codeNum_SRU ( string jobNumber ,string dea004 ,Hashtable strList )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT MAX(SRU007) SRU007 FROM MOXSRU " );
            strSql . AppendFormat ( "WHERE SRU002='{0}'" ,jobNumber );

            string codeNum = string . Empty;
            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "SRU007" ] . ToString ( ) ) )
                    codeNum = string . Empty;
                else
                    codeNum = dt . Rows [ 0 ] [ "SRU007" ] . ToString ( );
            }
            else
                codeNum = string . Empty;

            if ( string . IsNullOrEmpty ( codeNum ) )
            {
                codeNum = dea004 + CarpenterBll . UserInformation . dt ( ) . Year . ToString ( ) . Substring ( 2 ,2 ) + "00001";
                if ( strList . ContainsKey ( jobNumber ) )
                {
                    codeNum = strList [ jobNumber ] . ToString ( );
                    codeNum = ( Convert . ToInt64 ( codeNum ) + 1 ) . ToString ( );
                    strList . Remove ( jobNumber );
                    strList . Add ( jobNumber ,codeNum );
                }
                else
                    strList . Add ( jobNumber ,codeNum );
            }
            else
            {
                if ( strList . ContainsKey ( jobNumber ) )
                {
                    codeNum = strList [ jobNumber ] . ToString ( );
                    codeNum = ( Convert . ToInt64 ( codeNum ) + 1 ) . ToString ( );
                    strList . Remove ( jobNumber );
                    strList . Add ( jobNumber ,codeNum );
                }
                else
                {
                    codeNum = ( Convert . ToInt64 ( codeNum ) + 1 ) . ToString ( );
                    strList . Add ( jobNumber ,codeNum );
                }
            }

            return codeNum;
        }

        /// <summary>
        /// add sru
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="_model"></param>
        void add_SRU ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . SingRowTableSRUEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXSRU (" );
            strSql . Append ( "SRU001,SRU002,SRU003,SRU004,SRU005,SRU006,SRU007) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@SRU001,@SRU002,@SRU003,@SRU004,@SRU005,@SRU006,@SRU007) " );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@SRU001", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRU002", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRU003", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRU004", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRU005", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRU006", SqlDbType.Int,4),
                    new SqlParameter("@SRU007", SqlDbType.VarChar,50)
            };
            parameters [ 0 ] . Value = model . SRU001;
            parameters [ 1 ] . Value = model . SRU002;
            parameters [ 2 ] . Value = model . SRU003;
            parameters [ 3 ] . Value = model . SRU004;
            parameters [ 4 ] . Value = model . SRU005;
            parameters [ 5 ] . Value = model . SRU006;
            parameters [ 6 ] . Value = model . SRU007;

            SQLString . Add ( strSql ,parameters );
        }

        /// <summary>
        /// save data to srv
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool GenerMOXSRV ( DataTable table )
        {
            ProductionErpEntity . SingRowTableSRVEntity _model = new ProductionErpEntity . SingRowTableSRVEntity ( );
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            Hashtable strList = new Hashtable ( );
            bool check = false;

            _model . SRV001 = getOddNum_SRU ( );
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                check = string . IsNullOrEmpty ( table . Rows [ i ] [ "checkTre" ] . ToString ( ) ) == true ? false : ( bool ) table . Rows [ i ] [ "checkTre" ];
                if ( check )
                {
                    _model . SRV002 = table . Rows [ i ] [ "RAA001" ] . ToString ( );
                    _model . SRV003 = table . Rows [ i ] [ "RAA015" ] . ToString ( );
                    if ( Exists_SRV ( _model ) )
                    {
                        _model . SRV004 = table . Rows [ i ] [ "DEA002" ] . ToString ( );
                        _model . SRV005 = table . Rows [ i ] [ "DEA057" ] . ToString ( );
                        _model . SRV006 = string . IsNullOrEmpty ( table . Rows [ i ] [ "RAA018" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "RAA018" ] . ToString ( ) );
                        _model . SRV007 = codeNum_SRV ( _model . SRV002 ,table . Rows [ i ] [ "DEA004" ] . ToString ( ) ,strList );
                        add_SRV ( SQLString ,strSql ,_model );
                    }
                }
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );

        }

        /// <summary>
        /// get single row num
        /// </summary>
        /// <returns></returns>
        string getOddNum_SRV ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT MAX(SRV001) SRV001 FROM MOXSRV" );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "SRV001" ] . ToString ( ) ) )
                    return CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) + "001";
                else
                {
                    if ( dt . Rows [ 0 ] [ "SRV001" ] . ToString ( ) . Substring ( 0 ,8 ) . Equals ( CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) ) )
                        return ( Convert . ToInt64 ( dt . Rows [ 0 ] [ "SRV001" ] . ToString ( ) ) + 1 ) . ToString ( );
                    else
                        return CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) + "001";
                }
            }
            else
                return CarpenterBll . UserInformation . dt ( ) . ToString ( "yyyyMMdd" ) + "001";
        }

        /// <summary>
        /// does it exists job number and product num
        /// </summary>
        /// <param name="_model"></param>
        /// <returns></returns>
        bool Exists_SRV ( ProductionErpEntity . SingRowTableSRVEntity _model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT COUNT(1) FROM MOXSRV " );
            strSql . AppendFormat ( "WHERE SRV002='{0}' AND SRV003='{1}'" ,_model . SRV002 ,_model . SRV003 );

            return SqlHelper . Exists ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get code num of same job number
        /// </summary>
        /// <param name="jobNumber"></param>
        /// <returns></returns>
        string codeNum_SRV ( string jobNumber ,string dea004 ,Hashtable strList )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT MAX(SRV007) SRV007 FROM MOXSRV " );
            strSql . AppendFormat ( "WHERE SRV002='{0}'" ,jobNumber );

            string codeNum = string . Empty;
            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "SRV007" ] . ToString ( ) ) )
                    codeNum = string . Empty;
                else
                    codeNum = dt . Rows [ 0 ] [ "SRV007" ] . ToString ( );
            }
            else
                codeNum = string . Empty;

            if ( string . IsNullOrEmpty ( codeNum ) )
            {
                codeNum = dea004 + CarpenterBll . UserInformation . dt ( ) . Year . ToString ( ) . Substring ( 2 ,2 ) + "00001";
                if ( strList . ContainsKey ( jobNumber ) )
                {
                    codeNum = strList [ jobNumber ] . ToString ( );
                    codeNum = ( Convert . ToInt64 ( codeNum ) + 1 ) . ToString ( );
                    strList . Remove ( jobNumber );
                    strList . Add ( jobNumber ,codeNum );
                }
                else
                    strList . Add ( jobNumber ,codeNum );
            }
            else
            {
                if ( strList . ContainsKey ( jobNumber ) )
                {
                    codeNum = strList [ jobNumber ] . ToString ( );
                    codeNum = ( Convert . ToInt64 ( codeNum ) + 1 ) . ToString ( );
                    strList . Remove ( jobNumber );
                    strList . Add ( jobNumber ,codeNum );
                }
                else
                {
                    codeNum = ( Convert . ToInt64 ( codeNum ) + 1 ) . ToString ( );
                    strList . Add ( jobNumber ,codeNum );
                }
            }

            return codeNum;
        }

        /// <summary>
        /// add srv
        /// </summary>
        /// <param name="SQLString"></param>
        /// <param name="strSql"></param>
        /// <param name="_model"></param>
        void add_SRV ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . SingRowTableSRVEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXSRV (" );
            strSql . Append ( "SRV001,SRV002,SRV003,SRV004,SRV005,SRV006,SRV007) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@SRV001,@SRV002,@SRV003,@SRV004,@SRV005,@SRV006,@SRV007) " );
            SqlParameter [ ] parameters = {
                    new SqlParameter("@SRV001", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRV002", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRV003", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRV004", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRV005", SqlDbType.NVarChar,50),
                    new SqlParameter("@SRV006", SqlDbType.Int,4),
                    new SqlParameter("@SRV007", SqlDbType.VarChar,50)
            };
            parameters [ 0 ] . Value = model . SRV001;
            parameters [ 1 ] . Value = model . SRV002;
            parameters [ 2 ] . Value = model . SRV003;
            parameters [ 3 ] . Value = model . SRV004;
            parameters [ 4 ] . Value = model . SRV005;
            parameters [ 5 ] . Value = model . SRV006;
            parameters [ 6 ] . Value = model . SRV007;

            SQLString . Add ( strSql ,parameters );
        }

    }
}
