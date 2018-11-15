using System . Text;
using StudentMgr;
using System . Data;
using System . Collections;
using System . Collections . Generic;
using System . Data . SqlClient;
using System;

namespace ProductionErpBll . Dao
{
    public class ArtDao
    {
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,ART001,ART002 FROM MOXART " );
            strSql . Append ( "ORDER BY idx" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "DELETE FROM MOXART " );
            strSql . AppendFormat ( "WHERE idx={0}" ,idx );

            int row = SqlHelper . ExecuteNonQuery ( strSql . ToString ( ) );
            if ( row > 0 )
                return true;
            else
                return false;
        }

        /// <summary>
        /// 保存数据到数据库
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Save ( DataTable table ,List<int> intList )
        {
            //StringBuilder strSql = new StringBuilder ( );
            //strSql . Append ( "SELECT idx,ART001,ART002 FROM MOXART WHERE 1=2" );

            //return SqlHelper . UpdateToSql ( table ,strSql . ToString ( ) );


            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            ProductionErpEntity . ArtEntity _model = new ProductionErpEntity . ArtEntity ( );
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                _model . Idx = string . IsNullOrEmpty ( table . Rows [ i ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "idx" ] . ToString ( ) );
                _model . Art001 = table . Rows [ i ] [ "ART001" ] . ToString ( );
                _model . Art002 = table . Rows [ i ] [ "ART002" ] . ToString ( );
                if ( Exists ( _model ) == false )
                {
                    if ( _model . Idx < 1 )
                        add_art ( SQLString ,strSql ,_model );
                    else
                        edit_art ( SQLString ,strSql ,_model );
                }
            }

            foreach ( int id in intList )
            {
                _model . Idx = id;
                delete_art ( SQLString ,strSql ,_model );
            }


            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        bool Exists ( ProductionErpEntity . ArtEntity _model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT COUNT(1) FROM MOXART " );
            strSql . Append ( "WHERE ART001=@ART001 AND ART002=@ART002" );
            SqlParameter [ ] parameter = {
                   new SqlParameter("@ART001",SqlDbType.NVarChar,50),
                   new SqlParameter("@ART002",SqlDbType.NVarChar,50)
            };
            parameter [ 0 ] . Value = _model . Art001;
            parameter [ 1 ] . Value = _model . Art002;

            return SqlHelper . Exists ( strSql . ToString ( ) ,parameter );
        }

        void add_art ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . ArtEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXART (" );
            strSql . Append ( "ART001,ART002) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@ART001,@ART002) " );
            SqlParameter [ ] parameter = {
                   new SqlParameter("@ART001",SqlDbType.NVarChar,50),
                   new SqlParameter("@ART002",SqlDbType.NVarChar,50)
            };
            parameter [ 0 ] . Value = _model . Art001;
            parameter [ 1 ] . Value = _model . Art002;

            SQLString . Add ( strSql ,parameter );
        }

        void edit_art ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . ArtEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE MOXART SET " );
            strSql . Append ( "ART001=@ART001," );
            strSql . Append ( "ART002=@ART002 " );
            strSql . Append ( " WHERE idx=@idx " );
            SqlParameter [ ] parameter = {
                   new SqlParameter("@ART001",SqlDbType.NVarChar,50),
                   new SqlParameter("@ART002",SqlDbType.NVarChar,50),
                   new SqlParameter("@idx",SqlDbType.Int,4)
            };
            parameter [ 0 ] . Value = _model . Art001;
            parameter [ 1 ] . Value = _model . Art002;
            parameter [ 2 ] . Value = _model . Idx;

            SQLString . Add ( strSql ,parameter );
        }

        void delete_art ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . ArtEntity _model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "DELETE FROM MOXART " );
            strSql . AppendFormat ( "WHERE idx={0}" ,_model . Idx );

            SQLString . Add ( strSql ,null );
        }

    }
}
