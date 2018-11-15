using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;
using StudentMgr;
using System . Collections;

namespace ProductionErpBll . Dao
{
    public class SingRowTableDao
    {
        /// <summary>
        /// get data list
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTableOne ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,SRT001,SRT002,SRT003,SRT004,SRT005,SRT006,SRT007,SRT008,SRT009 FROM MOXSRT " );
            strSql . AppendFormat ( "WHERE " + strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get data from database
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        public DataTable getTableOnly ( string column )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT idx,SRT001,SRT002,SRT003,SRT004,SRT005,SRT006,{0} FROM MOXSRT " ,column );
            strSql . AppendFormat ( "WHERE {0}!='' AND {0} IS NOT NULL" ,column );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get data list
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTableTwo ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,SRU001,SRU002,SRU003,SRU004,SRU005,SRU006,SRU007 FROM MOXSRU " );
            strSql . AppendFormat ( "WHERE " + strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get data list
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTableTre ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,SRV001,SRV002,SRV003,SRV004,SRV005,SRV006,SRV007 FROM MOXSRV " );
            strSql . AppendFormat ( "WHERE " + strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }
        
        /// <summary>
        /// getColumnsTable
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable getTableOnly ( string columns,string tableName )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT DISTINCT {0} FROM {1} ORDER BY {0}" ,columns ,tableName );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get print table
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public DataTable getPrintOne ( List<int> intList)
        {
            string str = string . Empty;
            foreach ( int i in intList )
            {
                if ( str == string . Empty )
                    str = i . ToString ( );
                else
                    str = str + "," + i . ToString ( );
            }
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT CASE WHEN SRT007='' THEN CASE WHEN SRT008='' THEN SRT009 ELSE SRT008 END ELSE SRT007 END SRT,SRT001,SRT002,SRT003,SRT004,SRT005,SRT006,SRT007,SRT008,SRT009 FROM MOXSRT " );
            strSql . AppendFormat ( "WHERE idx IN ({0}) ORDER BY SRT007" ,str );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// delete data from database for moxstr
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public bool Delete ( List<int> intList )
        {
            string str = string . Join ( "," ,intList . ToArray ( ) );
            ArrayList SQLString = new ArrayList ( );
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE SGMRAA SET " );
            strSql . Append ( "RAA032='F' " );
            strSql . AppendFormat ( "WHERE RAA001 IN (SELECT DISTINCT SRT002 FROM MOXSRT WHERE idx IN ({0}))" ,str );
            SQLString . Add ( strSql . ToString ( ) );
            strSql = new StringBuilder ( );
            strSql . Append ( "DELETE FROM MOXSRT " );
            strSql . AppendFormat ( "WHERE idx IN ({0})" ,str );
            SQLString . Add ( strSql . ToString ( ) );

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

    }
}
