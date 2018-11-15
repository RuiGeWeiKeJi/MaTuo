using System . Data;
using System . Text;
using StudentMgr;
using System . Collections;
using System;

namespace ProductionErpBll . Dao
{
    public class WindBaseDao
    {
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable tableView ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,WIB001,WIB002,WIB003,WIB004,WIB005,WIB006,WIB007,WIB008,WIB009,WIB010,WIB011,WIB012,WIB013 FROM MOXWIB " );
            strSql . Append ( "WHERE " + strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取商品信息
        /// </summary>
        /// <returns></returns>
        public DataTable tableGood ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DEA001 WIB001,DEA001 WIB,DEA002 WIB002,DEA057 WIB003 FROM TPADEA WHERE DEA005='01'" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Delete ( DataTable table )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            ProductionErpEntity . WindBaseEntity _model = new ProductionErpEntity . WindBaseEntity ( );
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                _model . idx = string . IsNullOrEmpty ( table . Rows [ i ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "idx" ] . ToString ( ) );
                strSql = new StringBuilder ( );
                strSql . AppendFormat ( "DELETE FROM MOXWIB WHERE idx={0}" ,_model . idx );
                SQLString . Add ( strSql ,null );
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );

            strSql = new StringBuilder ( );
            strSql . AppendFormat ( "DELETE FROM MOXWIB WHERE idx={0}" ,idx );

            int row = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) );
            if ( row > 0 )
                return true;
            else
                return false;
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Save ( DataTable table )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,WIB001,WIB002,WIB003,WIB004,WIB005,WIB006,WIB007,WIB008,WIB009,WIB010,WIB011,WIB012,WIB013 FROM MOXWIB WHERE 1=2" );

            return SqlHelper . UpdateToSql ( table ,strSql . ToString ( ) );
        }

    }
}
