using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Collections;
using System . Data . SqlClient;
using CarpenterBll;

namespace ProductionErpBll . Dao
{
    public class StorageMaterialDao
    {
        /// <summary>
        /// get order from database
        /// </summary>
        /// <returns></returns>
        public DataTable getTableOrder ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT A.JDB001,DEA002,DEA057 FROM JSKJDB A INNER JOIN TPADEA B ON A.JDB003=B.DEA001 WHERE DEA009='P'" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get product from database
        /// </summary>
        /// <returns></returns>
        public DataTable getTablePro ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DEA001,DEA002 FROM TPADEA WHERE DEA009='P'" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get datatable from database 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getViewOne (string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT JDB001,JDB002,DEA001,DEA002,DEA057,JDB007,JDA004,DGA002,DEA004 FROM JSKJDB A INNER JOIN TPADEA B ON A.JDB003=B.DEA001 INNER JOIN JSKJDA C ON A.JDB001=C.JDA001 INNER JOIN TPADGA D ON C.JDA004=D.DGA001 " );
            strSql . AppendFormat ( " WHERE DEA009='P' AND DEA960='T' AND {0}" ,strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get database from database
        /// </summary>
        /// <param name="order"></param>
        /// <param name="num"></param>
        /// <param name="proNum"></param>
        /// <returns></returns>
        public DataTable getViewTwo ( string order,string num,string proNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,STM001,STM002,STM003,STM004,STM005,STM006,STM007 FROM MOXSTM  " );
            strSql . AppendFormat ( "WHERE STM001='{0}' AND STM002='{1}' AND STM003='{2}'" ,order ,num ,proNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 根据同供应商编号和商品信息条码编号,获取最大条码
        /// </summary>
        /// <param name="JDA004"></param>
        /// <param name="DEA004"></param>
        /// <returns></returns>
        public string getMaxCode ( string JDA004,string DEA004 )
        {
            DateTime time = UserInformation . dt ( );
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT MAX(STM006) STM006 FROM MOXSTM WHERE STM006 LIKE '{0}%' " ,JDA004 + DEA004 + time . Year );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
                return dt . Rows [ 0 ] [ "STM006" ] . ToString ( );
            else
                return string . Empty;
        }

        /// <summary>
        /// save data to database 
        /// </summary>
        /// <param name="haTable"></param>
        /// <returns></returns>
        public bool Save ( Hashtable haTable )
        {
            if ( haTable != null && haTable . Count > 0 )
            {
                Hashtable SQLString = new Hashtable ( );
                StringBuilder strSql = new StringBuilder ( );
                ProductionErpEntity . StorageMaterialEntity _model = new ProductionErpEntity . StorageMaterialEntity ( );
                DataTable dt = new DataTable ( );
                foreach ( DictionaryEntry d in haTable )
                {
                    dt = ( DataTable ) d . Value;
                    //DataView dv = new DataView ( dt );
                    //dt = null;
                    //dt = dv . ToTable ( true ,"STM006" );
                    if ( dt != null && dt . Rows . Count > 0 )
                    {
                        _model . STM001 = dt . Rows [ 0 ] [ "STM001" ] . ToString ( );
                        _model . STM002 = dt . Rows [ 0 ] [ "STM002" ] . ToString ( );
                        _model . STM003 = dt . Rows [ 0 ] [ "STM003" ] . ToString ( );
                        _model . STM004 = dt . Rows [ 0 ] [ "STM004" ] . ToString ( );
                        _model . STM005 = dt . Rows [ 0 ] [ "STM005" ] . ToString ( );
                        DataTable da = getViewTwo ( _model . STM001 ,_model . STM002 ,_model . STM003 );
                        for ( int i = 0 ; i < dt . Rows . Count ; i++ )
                        {                
                            _model . STM006 = dt . Rows [ i ] [ "STM006" ] . ToString ( );
                            _model . STM007 = dt . Rows [ i ] [ "STM007" ] . ToString ( );
                            if ( da . Select ( "STM006='" + _model . STM006 + "'" ) . Length < 1 )
                                add_stm ( SQLString ,strSql ,_model );
                            else
                                edit_stm ( SQLString ,strSql ,_model );
                        }
                        for ( int k = 0 ; k < da . Rows . Count ; k++ )
                        {
                            _model . idx = string . IsNullOrEmpty ( da . Rows [ k ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( da . Rows [ k ] [ "idx" ] . ToString ( ) );
                            _model . STM006 = da . Rows [ k ] [ "STM006" ] . ToString ( );
                            if ( dt . Select ( "STM006='" + _model . STM006 + "'" ) . Length < 1 )
                                delete_stm ( SQLString ,strSql ,_model );
                        }
                    }
                }

                return SqlHelper . ExecuteSqlTran ( SQLString );
            }
            else
                return false;
        }

        void add_stm (Hashtable SQLString,StringBuilder strSql,ProductionErpEntity.StorageMaterialEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXSTM (" );
            strSql . Append ( "STM001,STM002,STM003,STM004,STM005,STM006,STM007) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@STM001,@STM002,@STM003,@STM004,@STM005,@STM006,@STM007) " );
            SqlParameter [ ] parameter = {
                new SqlParameter("@STM001",SqlDbType.NVarChar,50),
                new SqlParameter("@STM002",SqlDbType.VarChar,50),
                new SqlParameter("@STM003",SqlDbType.NVarChar,20),
                new SqlParameter("@STM004",SqlDbType.NVarChar,20),
                new SqlParameter("@STM005",SqlDbType.NVarChar,20),
                new SqlParameter("@STM006",SqlDbType.NVarChar,50),
                new SqlParameter("@STM007",SqlDbType.NVarChar,20)
            };
            parameter [ 0 ] . Value = _model . STM001;
            parameter [ 1 ] . Value = _model . STM002;
            parameter [ 2 ] . Value = _model . STM003;
            parameter [ 3 ] . Value = _model . STM004;
            parameter [ 4 ] . Value = _model . STM005;
            parameter [ 5 ] . Value = _model . STM006;
            parameter [ 6 ] . Value = _model . STM007;
            SQLString . Add ( strSql ,parameter );
        }

        void edit_stm ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . StorageMaterialEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE MOXSTM SET " );
            strSql . Append ( "STM007=@STM007 " );
            strSql . Append ( "WHERE STM001=@STM001 AND STM002=@STM002 AND STM003=@STM003 AND STM006=@STM006" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@STM001",SqlDbType.NVarChar,50),
                new SqlParameter("@STM002",SqlDbType.VarChar,50),
                new SqlParameter("@STM003",SqlDbType.NVarChar,20),
                new SqlParameter("@STM006",SqlDbType.NVarChar,50),
                new SqlParameter("@STM007",SqlDbType.NVarChar,20)
            };
            parameter [ 0 ] . Value = _model . STM001;
            parameter [ 1 ] . Value = _model . STM002;
            parameter [ 2 ] . Value = _model . STM003;
            parameter [ 3 ] . Value = _model . STM006;
            parameter [ 4 ] . Value = _model . STM007;
            SQLString . Add ( strSql ,parameter );
        }

        void delete_stm ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . StorageMaterialEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "DELETE FROM MOXSTM " );
            strSql . AppendFormat ( "WHERE idx={0}" ,_model . idx );
            SQLString . Add ( strSql ,null );
        }

        /// <summary>
        /// delete data from database
        /// </summary>
        /// <param name="order"></param>
        /// <param name="num"></param>
        /// <param name="proNum"></param>
        /// <returns></returns>
        public bool Delete ( string order,string num,string proNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "DELETE FROM MOXSTM " );
            strSql . AppendFormat ( "WHERE STM001=@STM001 AND STM002=@STM002 AND STM003=@STM003" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@STM001",SqlDbType.NVarChar,50),
                new SqlParameter("@STM002",SqlDbType.VarChar,50),
                new SqlParameter("@STM003",SqlDbType.NVarChar,20)
            };
            parameter [ 0 ] . Value = order;
            parameter [ 1 ] . Value = num;
            parameter [ 2 ] . Value = proNum;

            int row = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) ,parameter );
            if ( row > 0 )
                return true;
            else
                return false;
        }

        /// <summary>
        /// get datatable from database for print 
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public DataTable getPrint ( List<string> intList )
        {
            string str = string . Empty;
            foreach ( string s in intList )
            {
                if ( string . IsNullOrEmpty ( str ) )
                    str = "'" + s + "'";
                else
                    str = str + "," + "'" + s + "'";
            }
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT STM001,STM002,STM003,STM004,STM005,STM006,STM007 FROM MOXSTM WHERE STM006 IN ({0})" ,str );
            
            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取所有供应商编号+品号+年份开头的条码
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public DataTable getAllCode ( string prefix )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT DISTINCT STM006 FROM MOXSTM WHERE STM006 LIKE '{0}%'" ,prefix );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 得到条码
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public DataTable getCodeOne ( string code )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,STM001,STM002,STM003,STM004,STM005,STM006,STM007 FROM MOXSTM  " );
            strSql . AppendFormat ( "WHERE STM006='{0}' " ,code );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
