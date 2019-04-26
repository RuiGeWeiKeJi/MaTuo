using System . Data;
using System . Text;
using StudentMgr;
using System . Collections;
using System . Data . SqlClient;
using System;

namespace ProductionErpBll . Dao
{
    public class StatorCoilDao
    {
        /// <summary>
        /// Does it Exists
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public bool getCodeNum ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT COUNT(1) FROM MOXSTC WHERE STC001='{0}'" ,codeNum );
            
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
        bool Add ( string codeNum )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            
            ProductionErpEntity . StatorCoilSTCEntity _stc = new ProductionErpEntity . StatorCoilSTCEntity ( );
            ProductionErpEntity . StatorCoilSTDEntity _std = new ProductionErpEntity . StatorCoilSTDEntity ( );
            _stc . STC001 = _std . STD001= codeNum;
            string zaS = string.Empty, zS = string . Empty, pfS = string . Empty, psG = string . Empty;
            DataTable dt = getWinBase ( codeNum );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                _stc . STC002 = string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "WIB010" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( dt . Rows [ 0 ] [ "WIB010" ] . ToString ( ) );
                _stc . STC003 = dt . Rows [ 0 ] [ "SRT002" ] . ToString ( );
                _stc . STC004 = dt . Rows [ 0 ] [ "WIB003" ] . ToString ( );
                zaS = dt . Rows [ 0 ] [ "WIB004" ] . ToString ( );
                zS = dt . Rows [ 0 ] [ "WIB005" ] . ToString ( );
                pfS = dt . Rows [ 0 ] [ "WIB012" ] . ToString ( );
                psG = dt . Rows [ 0 ] [ "WIB013" ] . ToString ( );

                add_stc ( SQLString ,strSql ,_stc );
            }
            else
                return false;
            
            _std . STD006 = 0;
            _std . STD007 = string . Empty;
            _std . STD008 = null;
            std_para ( SQLString ,strSql ,_std ,zaS ,zS ,pfS ,psG );

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
            //(CASE WHEN SRT007='' THEN CASE WHEN SRT008='' THEN SRT009 ELSE SRT008 END END)
            strSql . AppendFormat ( "SELECT WIB003,WIB010,WIB004,WIB005,WIB012,WIB013,SRT002 FROM MOXWIB A INNER JOIN MOXSRT B ON A.WIB001=B.SRT003 WHERE SRT007='{0}'" ,codeNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        DataTable getOtherData ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT RES005,RES006,RES007,RES008,RES009,RES010,RES011,RES012 FROM MOXRES WHERE RES001='{0}'" ,codeNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        DataTable getBL ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT WIB011 FROM MOXWIB A INNER JOIN MOXSRT B ON A.WIB001=B.SRT003 AND A.WIB003=B.SRT005 WHERE SRT007='{0}'" ,codeNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        void add_stc ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . StatorCoilSTCEntity _stc )
        {
            _stc . STC005 = 0;
            _stc . STC006 = string . Empty;
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXSTC (" );
            strSql . Append ( "STC001,STC002,STC003,STC004,STC005,STC006) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@STC001,@STC002,@STC003,@STC004,@STC005,@STC006) " );
            SqlParameter [ ] parameter = {
                new SqlParameter("@STC001",SqlDbType.NVarChar,50),
                new SqlParameter("@STC002",SqlDbType.Int,4),
                new SqlParameter("@STC003",SqlDbType.NVarChar,50),
                new SqlParameter("@STC004",SqlDbType.NVarChar,50),
                new SqlParameter("@STC005",SqlDbType.Int,4),
                new SqlParameter("@STC006",SqlDbType.NVarChar,50)
            };
            parameter [ 0 ] . Value = _stc . STC001;
            parameter [ 1 ] . Value = _stc . STC002;
            parameter [ 2 ] . Value = _stc . STC003;
            parameter [ 3 ] . Value = _stc . STC004;
            parameter [ 4 ] . Value = _stc . STC005;
            parameter [ 5 ] . Value = _stc . STC006;

            SQLString . Add ( strSql ,parameter );
        }

        void std_para ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . StatorCoilSTDEntity _std ,string zaS ,string zS ,string pfS ,string psG )
        {
            DataTable dt = getOtherData ( _std . STD001 );
            bool result = false;
            if ( dt != null && dt . Rows . Count > 0 )
                result = true;
            _std . STD002 = "绕线";
            _std . STD003 = "确认线圈匝数";
            _std . STD004 = zaS . ToString ( );
            _std . STD005 = "匝数测试仪";
            _std . STD010 = "1";
            _std . STD011 = "0";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "确认线圈组数";
            _std . STD004 = zS . ToString ( );
            _std . STD005 = "目测";
            _std . STD010 = "1";
            _std . STD011 = "1";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "接头数量";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD010 = "1";
            _std . STD011 = "2";
            add_std ( SQLString ,strSql ,_std );
            DataTable dl = getBL ( _std . STD001 );
            if ( dl != null && dl . Rows . Count > 0 )
            {
                if ( dl . Rows [ 0 ] [ "WIB011" ] != null )
                    _std . STD004 = dl . Rows [ 0 ] [ "WIB011" ] . ToString ( );
                else
                    _std . STD004 = string . Empty;
            }
            _std . STD003 = "并联路数";         
            _std . STD005 = "目测";
            _std . STD010 = "1";
            _std . STD011 = "3";
            add_std ( SQLString ,strSql ,_std );
            _std . STD002 = "嵌线";
            _std . STD003 = "确认接头数量";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD010 = "2";
            _std . STD011 = "4";
            add_std ( SQLString ,strSql ,_std );
            //_std . STD002 = "绑扎整形焊接";
            _std . STD003 = "引出线规格(平方)";
            _std . STD004 = pfS . ToString ( );
            _std . STD005 = "目测";
            _std . STD010 = "3";
            _std . STD011 = "5";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "引出线长度(mm)";
            _std . STD004 = psG . ToString ( );
            _std . STD005 = "钢尺";
            _std . STD010 = "3";
            _std . STD011 = "6";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "焊接接头数量";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD010 = "3";
            _std . STD011 = "7";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "出线端线尺寸合格";
            _std . STD004 = string . Empty;
            _std . STD005 = "钢尺";
            _std . STD010 = "3";
            _std . STD011 = "8";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "非出线端线包尺寸合格";
            _std . STD004 = string . Empty;
            _std . STD005 = "钢尺";
            _std . STD010 = "3";
            _std . STD011 = "9";
            add_std ( SQLString ,strSql ,_std );
            _std . STD002 = "检验";
            _std . STD003 = "耐压2260V,测试一分钟无击穿";
            if ( result && dt . Rows [ 0 ] [ "RES005" ] != null )
                _std . STD004 = dt . Rows [ 0 ] [ "RES005" ] . ToString ( );
            else
                _std . STD004 = string . Empty;
            _std . STD005 = "耐压测试仪";
            _std . STD010 = "4";
            _std . STD011 = "10";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "匝间检验合格";
            if ( result && dt . Rows [ 0 ] [ "RES006" ] != null )
                _std . STD004 = dt . Rows [ 0 ] [ "RES006" ] . ToString ( );
            else
                _std . STD004 = string . Empty;
            _std . STD005 = "匝间测试仪";
            _std . STD011 = "11";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "绝缘电阻(MΩ)";
            if ( result && dt . Rows [ 0 ] [ "RES007" ] != null )
                _std . STD004 = dt . Rows [ 0 ] [ "RES007" ] . ToString ( );
            else
                _std . STD004 = string . Empty;
            _std . STD005 = "摇表";
            _std . STD011 = "12";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "(黄-绿)线间电阻(Ω)";
            if ( result && dt . Rows [ 0 ] [ "RES008" ] != null )
                _std . STD004 = dt . Rows [ 0 ] [ "RES008" ] . ToString ( );
            else
                _std . STD004 = string . Empty;
            _std . STD005 = string . Empty;
            _std . STD011 = "13";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "(绿-红)线间电阻(Ω)";
            if ( result && dt . Rows [ 0 ] [ "RES009" ] != null )
                _std . STD004 = dt . Rows [ 0 ] [ "RES009" ] . ToString ( );
            else
                _std . STD004 = string . Empty;
            _std . STD005 = string . Empty;
            _std . STD011 = "14";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "(黄-红)线间电阻(Ω)";
            if ( result && dt . Rows [ 0 ] [ "RES010" ] != null )
                _std . STD004 = dt . Rows [ 0 ] [ "RES010" ] . ToString ( );
            else
                _std . STD004 = string . Empty;
            _std . STD005 = string . Empty;
            _std . STD011 = "15";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "环境温度(℃)";
            if ( result && dt . Rows [ 0 ] [ "RES011" ] != null )
                _std . STD004 = dt . Rows [ 0 ] [ "RES011" ] . ToString ( );
            else
                _std . STD004 = string . Empty;
            _std . STD005 = "温度计";
            _std . STD011 = "16";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "电阻不平衡度";
            if ( result && dt . Rows [ 0 ] [ "RES012" ] != null )
                _std . STD004 = dt . Rows [ 0 ] [ "RES012" ] . ToString ( );
            else
                _std . STD004 = string . Empty;
            _std . STD005 = "计算器";
            _std . STD011 = "17";
            add_std ( SQLString ,strSql ,_std );
            //_std . STD003 = "三相电阻偏差不大于平均值的2%";
            //_std . STD004 = string . Empty;
            //_std . STD005 = "直流低电阻测试仪";
            //_std . STD011 = "18";
            //add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "线包尺寸用卡板检验合格%";
            _std . STD004 = string . Empty;
            _std . STD005 = "检具";
            _std . STD011 = "19";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "外观整齐，无漏绑";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD011 = "20";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "槽楔整齐，无歪斜";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD011 = "21";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "漆包线无破损";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD011 = "22";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "绝缘纸维修剪";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD011 = "23";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "引出线长度不够";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD011 = "24";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "曹契装配不合格";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD011 = "25";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "铁芯叠片翘起";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD011 = "26";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "虚焊";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD011 = "27";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "线包高度超出";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD011 = "28";
            add_std ( SQLString ,strSql ,_std );
            _std . STD003 = "绑线松紧不够";
            _std . STD004 = string . Empty;
            _std . STD005 = "目测";
            _std . STD011 = "29";
            add_std ( SQLString ,strSql ,_std );
        }

        void add_std ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . StatorCoilSTDEntity _std )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "INSERT INTO MOXSTD (" );
            strSql . Append ( "STD001,STD002,STD003,STD004,STD005,STD006,STD007,STD008,STD010,STD011) " );
            strSql . Append ( "VALUES (" );
            strSql . Append ( "@STD001,@STD002,@STD003,@STD004,@STD005,@STD006,@STD007,@STD008,@STD010,@STD011) " );
            SqlParameter [ ] parameter = {
                new SqlParameter("@STD001",SqlDbType.NVarChar,50),
                new SqlParameter("@STD002",SqlDbType.NVarChar,50),
                new SqlParameter("@STD003",SqlDbType.NVarChar,50),
                new SqlParameter("@STD004",SqlDbType.NVarChar,50),
                new SqlParameter("@STD005",SqlDbType.NVarChar,50),
                new SqlParameter("@STD006",SqlDbType.Int,4),
                new SqlParameter("@STD007",SqlDbType.NVarChar,50),
                new SqlParameter("@STD008",SqlDbType.Date,3),
                new SqlParameter("@STD010",SqlDbType.NChar,10),
                new SqlParameter("@STD011",SqlDbType.NChar,10)
            };
            parameter [ 0 ] . Value = _std . STD001;
            parameter [ 1 ] . Value = _std . STD002;
            parameter [ 2 ] . Value = _std . STD003;
            parameter [ 3 ] . Value = _std . STD004;
            parameter [ 4 ] . Value = _std . STD005;
            parameter [ 5 ] . Value = _std . STD006;
            parameter [ 6 ] . Value = _std . STD007;
            parameter [ 7 ] . Value = _std . STD008;
            parameter [ 8 ] . Value = _std . STD010;
            parameter [ 9 ] . Value = _std . STD011;

            SQLString . Add ( strSql ,parameter );
        }

        void edit_std ( Hashtable SQLString ,ProductionErpEntity . StatorCoilSTDEntity _std )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE MOXSTD SET " );
            strSql . Append ( "STD004=@STD004 " );
            strSql . Append ( "WHERE STD001=@STD001 AND STD002=@STD002 AND STD003=@STD003" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@STD001",SqlDbType.NVarChar,50),
                new SqlParameter("@STD002",SqlDbType.NVarChar,50),
                new SqlParameter("@STD003",SqlDbType.NVarChar,50),
                new SqlParameter("@STD004",SqlDbType.NVarChar,50)
            };
            parameter [ 0 ] . Value = _std . STD001;
            parameter [ 1 ] . Value = _std . STD002;
            parameter [ 2 ] . Value = _std . STD003;
            parameter [ 3 ] . Value = _std . STD004;
            SQLString . Add ( strSql ,parameter );
        }

        /// <summary>
        /// query dataTable from database
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public DataTable tableView ( string codeNum )
        {
            Hashtable SQLString = new Hashtable ( );
            ProductionErpEntity . StatorCoilSTDEntity _std = new ProductionErpEntity . StatorCoilSTDEntity ( );
            _std . STD001 = codeNum;
            DataTable dt = getOtherData ( codeNum );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                _std . STD002 = "检验";
                _std . STD003 = "耐压2260V,测试一分钟无击穿";
                if ( dt . Rows [ 0 ] [ "RES005" ] != null )
                    _std . STD004 = dt . Rows [ 0 ] [ "RES005" ] . ToString ( );
                else
                    _std . STD004 = string . Empty;
                if ( _std . STD004 != string . Empty )
                    edit_std ( SQLString ,_std );
                _std . STD003 = "匝间检验合格";
                if ( dt . Rows [ 0 ] [ "RES006" ] != null )
                    _std . STD004 = dt . Rows [ 0 ] [ "RES006" ] . ToString ( );
                else
                    _std . STD004 = string . Empty;
                if ( _std . STD004 != string . Empty )
                    edit_std ( SQLString ,_std );
                _std . STD003 = "绝缘电阻(MΩ)";
                if ( dt . Rows [ 0 ] [ "RES007" ] != null )
                    _std . STD004 = dt . Rows [ 0 ] [ "RES007" ] . ToString ( );
                else
                    _std . STD004 = string . Empty;
                if ( _std . STD004 != string . Empty )
                    edit_std ( SQLString ,_std );
                _std . STD003 = "(黄-绿)线间电阻(Ω)";
                if ( dt . Rows [ 0 ] [ "RES008" ] != null )
                    _std . STD004 = dt . Rows [ 0 ] [ "RES008" ] . ToString ( );
                else
                    _std . STD004 = string . Empty;
                if ( _std . STD004 != string . Empty )
                    edit_std ( SQLString ,_std );
                _std . STD003 = "(绿-红)线间电阻(Ω)";
                if ( dt . Rows [ 0 ] [ "RES009" ] != null )
                    _std . STD004 = dt . Rows [ 0 ] [ "RES009" ] . ToString ( );
                else
                    _std . STD004 = string . Empty;
                if ( _std . STD004 != string . Empty )
                    edit_std ( SQLString ,_std );
                _std . STD003 = "(黄-红)线间电阻(Ω)";
                if ( dt . Rows [ 0 ] [ "RES010" ] != null )
                    _std . STD004 = dt . Rows [ 0 ] [ "RES010" ] . ToString ( );
                else
                    _std . STD004 = string . Empty;
                if ( _std . STD004 != string . Empty )
                    edit_std ( SQLString ,_std );
                _std . STD003 = "环境温度(℃)";
                if ( dt . Rows [ 0 ] [ "RES011" ] != null )
                    _std . STD004 = dt . Rows [ 0 ] [ "RES011" ] . ToString ( );
                else
                    _std . STD004 = string . Empty;
                if ( _std . STD004 != string . Empty )
                    edit_std ( SQLString ,_std );
                _std . STD003 = "电阻不平衡度";
                if ( dt . Rows [ 0 ] [ "RES012" ] != null )
                    _std . STD004 = dt . Rows [ 0 ] [ "RES012" ] . ToString ( );
                else
                    _std . STD004 = string . Empty;
                if ( _std . STD004 != string . Empty )
                    edit_std ( SQLString ,_std );
            }
            DataTable dl = getBL ( codeNum );
            if ( dl != null && dl . Rows . Count > 0 )
            {
                if ( dl . Rows [ 0 ] [ "WIB011" ] != null )
                    _std . STD004 = dl . Rows [ 0 ] [ "WIB011" ] . ToString ( );
                else
                    _std . STD004 = string . Empty;
                _std . STD003 = "并联路数";
                _std . STD002 = "绕线";
                if ( _std . STD004 != string . Empty )
                    edit_std ( SQLString ,_std );
            }
            StringBuilder strSql = new StringBuilder ( );
            if ( SqlHelper . ExecuteSqlTran ( SQLString ) )
            {
                strSql . Append ( "SELECT DISTINCT A.idx,STD001,STD002,STD003,CASE WHEN STD004='True' THEN '合格' WHEN STD004='False' THEN '不合格' WHEN STD003='接头数量' THEN CONVERT(VARCHAR,ISNULL(WIE013,0)) ELSE STD004 END STD004,STD005,CASE STD002 WHEN '绕线' THEN ISNULL(WIE014,0) ELSE STD006 END STD006,CASE STD002 WHEN '绕线' THEN WIE015 ELSE STD007 END STD007,CASE STD002 WHEN '绕线' THEN WIE016 ELSE STD008 END STD008,STD012,STD013,STD010,STD011 FROM MOXSTD A LEFT JOIN MOXART B ON A.STD002=B.ART001 LEFT JOIN MOXARP C ON B.idx=C.ARP003 LEFT JOIN MOXWIE D ON A.STD001=D.WIE005 " );
                strSql . AppendFormat ( "WHERE STD001='{0}' AND ARP004 LIKE '定子%' AND ARP001='{1}' ORDER BY STD010,STD011" ,codeNum ,CarpenterBll . UserInformation . UserNum );             
            }
            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// query dataSet from database
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public ProductionErpEntity . StatorCoilSTCEntity getModel ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT STC001,STC002,STC003,STC004,STC005,STC006,STC007,STC008 FROM MOXSTC " );
            strSql . AppendFormat ( "WHERE STC001='{0}'" ,codeNum );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
                return GetModel ( dt . Rows [ 0 ] );
            else
                return null;
        }

        public ProductionErpEntity . StatorCoilSTCEntity GetModel ( DataRow row )
        {
            ProductionErpEntity . StatorCoilSTCEntity _model = new ProductionErpEntity . StatorCoilSTCEntity ( );

            if ( row != null )
            {
                if ( row [ "STC001" ] != null && row [ "STC001" ] . ToString ( ) != string . Empty )
                    _model . STC001 = row [ "STC001" ] . ToString ( );
                else
                    _model . STC001 = string . Empty;
                if ( row [ "STC002" ] != null && row [ "STC002" ] . ToString ( ) != string . Empty )
                    _model . STC002 = int . Parse ( row [ "STC002" ] . ToString ( ) );
                else
                    _model . STC002 = 0;
                if ( row [ "STC003" ] != null && row [ "STC003" ] . ToString ( ) != string . Empty )
                    _model . STC003 = row [ "STC003" ] . ToString ( );
                else
                    _model . STC003 = string . Empty;
                if ( row [ "STC004" ] != null && row [ "STC004" ] . ToString ( ) != string . Empty )
                    _model . STC004 = row [ "STC004" ] . ToString ( );
                else
                    _model . STC004 = string . Empty;
                if ( row [ "STC005" ] != null && row [ "STC005" ] . ToString ( ) != string . Empty )
                    _model . STC005 = int . Parse ( row [ "STC005" ] . ToString ( ) );
                else
                    _model . STC005 = 0;
                if ( row [ "STC006" ] != null && row [ "STC006" ] . ToString ( ) != string . Empty )
                    _model . STC006 = row [ "STC006" ] . ToString ( );
                else
                    _model . STC006 = string . Empty;
                if ( row [ "STC007" ] != null && row [ "STC007" ] . ToString ( ) != string . Empty )
                    _model . STC007 = row [ "STC007" ] . ToString ( );
                else
                    _model . STC007 = string . Empty;
                if ( row [ "STC008" ] != null && row [ "STC008" ] . ToString ( ) != string . Empty )
                    _model . STC008 = row [ "STC008" ] . ToString ( );
                else
                    _model . STC008 = string . Empty;
            }

            return _model;
        }

        /// <summary>
        /// edit data from view to database
        /// </summary>
        /// <param name="_stc"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Save ( ProductionErpEntity . StatorCoilSTCEntity _stc ,DataTable table )
        {
            Hashtable SQLString = new Hashtable ( );
            StringBuilder strSql = new StringBuilder ( );
            edit_stc ( SQLString ,strSql ,_stc );
            ProductionErpEntity . StatorCoilSTDEntity _std = new ProductionErpEntity . StatorCoilSTDEntity ( );
            _std . STD001 = _stc . STC001;
            for ( int i = 0 ; i < table . Rows . Count ; i++ )
            {
                _std . idx = string . IsNullOrEmpty ( table . Rows [ i ] [ "idx" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "idx" ] . ToString ( ) );
                _std . STD004 = table . Rows [ i ] [ "STD004" ] . ToString ( );
                _std . STD006 = string . IsNullOrEmpty ( table . Rows [ i ] [ "STD006" ] . ToString ( ) ) == true ? 0 : Convert . ToInt32 ( table . Rows [ i ] [ "STD006" ] . ToString ( ) );
                _std . STD007 = table . Rows [ i ] [ "STD007" ] . ToString ( );
                if ( string . IsNullOrEmpty ( table . Rows [ i ] [ "STD008" ] . ToString ( ) ) )
                    _std . STD008 = null;
                else
                    _std . STD008 = Convert . ToDateTime ( table . Rows [ i ] [ "STD008" ] . ToString ( ) );
                _std . STD012 = table . Rows [ i ] [ "STD012" ] . ToString ( );
                _std . STD013 = table . Rows [ i ] [ "STD013" ] . ToString ( );
                edit_std ( SQLString ,strSql ,_std );
            }

            return SqlHelper . ExecuteSqlTran ( SQLString );
        }

        void edit_stc ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . StatorCoilSTCEntity _stc )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE MOXSTC SET " );
            strSql . Append ( "STC005=@STC005," );
            strSql . Append ( "STC006=@STC006," );
            strSql . Append ( "STC007=@STC007," );
            strSql . Append ( "STC008=@STC008 " );
            strSql . Append ( "WHERE STC001=@STC001" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@STC001",SqlDbType.NVarChar,50),
                new SqlParameter("@STC005",SqlDbType.Int,4),
                new SqlParameter("@STC006",SqlDbType.NVarChar,50),
                new SqlParameter("@STC007",SqlDbType.NVarChar,50),
                new SqlParameter("@STC008",SqlDbType.NVarChar,50)
            };
            parameter [ 0 ] . Value = _stc . STC001;
            parameter [ 1 ] . Value = _stc . STC005;
            parameter [ 2 ] . Value = _stc . STC006;
            parameter [ 3 ] . Value = _stc . STC007;
            parameter [ 4 ] . Value = _stc . STC008;
            SQLString . Add ( strSql ,parameter );
        }

        void edit_std ( Hashtable SQLString ,StringBuilder strSql ,ProductionErpEntity . StatorCoilSTDEntity _std )
        {
            strSql = new StringBuilder ( );
            strSql . Append ( "UPDATE MOXSTD SET " );
            strSql . Append ( "STD004=@STD004," );
            strSql . Append ( "STD006=@STD006," );
            strSql . Append ( "STD007=@STD007," );
            strSql . Append ( "STD008=@STD008," );
            strSql . Append ( "STD012=@STD012," );
            strSql . Append ( "STD013=@STD013 " );
            strSql . Append ( "WHERE idx=@idx" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@idx",SqlDbType.Int,4),
                new SqlParameter("@STD004",SqlDbType.NVarChar,50),
                new SqlParameter("@STD006",SqlDbType.Int,4),
                new SqlParameter("@STD007",SqlDbType.NVarChar,50),
                new SqlParameter("@STD008",SqlDbType.Date,3),
                new SqlParameter("@STD012",SqlDbType.NVarChar,50),
                new SqlParameter("@STD013",SqlDbType.NVarChar,50)
            };
            parameter [ 0 ] . Value = _std . idx;
            parameter [ 1 ] . Value = _std . STD004;
            parameter [ 2 ] . Value = _std . STD006;
            parameter [ 3 ] . Value = _std . STD007;
            parameter [ 4 ] . Value = _std . STD008;
            parameter [ 5 ] . Value = _std . STD012;
            parameter [ 6 ] . Value = _std . STD013;
            SQLString . Add ( strSql ,parameter );
        }

        /// <summary>
        /// getPrintOne
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public DataTable getPrintOne ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT STC001,STC002,STC003,STC004,STC005,STC006 FROM MOXSTC " );
            strSql . AppendFormat ( "WHERE STC001='{0}'" ,codeNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// getPrintTwo
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public DataTable getPrintTwo ( string codeNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT STD001,STD002,STD003,STD004,STD005,STD006,STD007,STD008 FROM MOXSTD " );
            strSql . AppendFormat ( "WHERE STD001='{0}' ORDER BY STD010,STD011 " ,codeNum );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// get table from database
        /// </summary>
        /// <param name="userNum"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public DataTable getDataTablePowForArt ( string userNum,string item )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT B.ART001 FROM MOXARP A INNER JOIN MOXART B ON A.ARP003=B.idx WHERE ARP001='{0}' AND ARP004='{1}'" ,userNum ,item );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

        /// <summary>
        /// 获取人员信息
        /// </summary>
        /// <returns></returns>
        public DataTable getUserDataTable ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT DBA001,DBA002 FROM TPADBA" );

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
        }

    }
}
