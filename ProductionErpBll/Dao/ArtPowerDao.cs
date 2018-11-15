using System;
using System . Data;
using System . Text;
using StudentMgr;
using System . Collections;
using System . Collections . Generic;
using System . Data . SqlClient;

namespace ProductionErpBll . Dao
{
    public class ArtPowerDao
    {
        /// <summary>
        /// 获取工艺信息
        /// </summary>
        /// <returns></returns>
        public DataTable getArt ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,ART001 ARP003,ART002 ARP004 FROM MOXART" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="personNum"></param>
        /// <returns></returns>
        public DataTable tableView ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT idx,ARP001,ARP002,ARP003,ARP004 FROM MOXARP " );
            strSql . AppendFormat ( "WHERE " + strWhere );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取人员信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetPerson ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DBA001 ARP001,DBA001 ARP,DBA002 ARP002 FROM TPADBA WHERE DBA001!='DS'" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Save ( DataTable table ,List<string> strList)
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            ProductionErpEntity . ArtPowerEntity model = new ProductionErpEntity . ArtPowerEntity ( );
            DataRow row;
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                row = table . Rows [ i ];
                model . ARP001 = row [ "ARP001" ] . ToString ( );
                model . ARP002 = row [ "ARP002" ] . ToString ( );
                model . ARP003 = row [ "ARP003" ] . ToString ( );
                model . ARP004 = row [ "ARP004" ] . ToString ( );
                if ( !Exists ( model ) )
                    add ( SQLString ,strSql ,model );
            }
            if ( strList != null && strList . Count > 0 )
            {
                foreach ( string s in strList )
                {
                    model . idx = Convert . ToInt32 ( s );
                    delete ( SQLString ,strSql ,model );
                }
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        bool Exists ( ProductionErpEntity . ArtPowerEntity model )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT COUNT(1) FROM MOXARP " );
            strSql . Append ( "WHERE ARP001=@ARP001 AND ARP003=@ARP003 AND ARP004=@ARP004" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@ARP001",SqlDbType.NVarChar,50),
                new SqlParameter("@ARP003",SqlDbType.NVarChar,50),
                new SqlParameter("@ARP004",SqlDbType.NVarChar,50)
            };
            parameter [ 0 ] . Value = model . ARP001;
            parameter [ 1 ] . Value = model . ARP003;
            parameter [ 2 ] . Value = model . ARP004;

            return SqlHelper . Exists ( strSql . ToString ( ) ,parameter );
        }

        void add ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . ArtPowerEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXARP (" );
            strSql . Append ( "ARP001,ARP002,ARP003,ARP004) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@ARP001,@ARP002,@ARP003,@ARP004) " );
            SqlParameter [ ] parameter = {
                new SqlParameter("@ARP001",SqlDbType.NVarChar,50),
                new SqlParameter("@ARP002",SqlDbType.NVarChar,50),
                new SqlParameter("@ARP003",SqlDbType.NVarChar,50),
                new SqlParameter("@ARP004",SqlDbType.NVarChar,50)
            };
            parameter [ 0 ] . Value = model . ARP001;
            parameter [ 1 ] . Value = model . ARP002;
            parameter [ 2 ] . Value = model . ARP003;
            parameter [ 3 ] . Value = model . ARP004;
            SQLString . Add ( strSql ,parameter );
        }

        void delete ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . ArtPowerEntity model )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "DELETE FROM MOXARP " );
            strSql . AppendFormat ( "WHERE idx={0}" ,model . idx );

            SQLString . Add ( strSql ,null );
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Delete ( DataTable table )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            ProductionErpEntity . ArtPowerEntity _model = new ProductionErpEntity . ArtPowerEntity ( );
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                _model . idx = string . IsNullOrEmpty ( table . Rows [ i ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "idx" ] . ToString ( ) );
                strSql = new StringBuilder ( );
                strSql . AppendFormat ( "DELETE FROM MOXARP WHERE idx={0}" ,_model . idx );
                SQLString . Add ( strSql ,null );
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

    }
}
