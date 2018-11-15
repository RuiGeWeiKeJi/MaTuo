using System . Data;
using System . Data . SqlClient;
using System . Text;
using StudentMgr;
using System . Windows . Forms;
using System . Diagnostics;
using System . Threading;
using System;
using System . Text . RegularExpressions;

namespace CarpenterBll . Dao
{
    public class MainDao
    {
        /// <summary>
        /// 获取权限
        /// </summary>
        /// <param name="userNum"></param>
        /// <returns></returns>
        public DataTable GetDataTablePower ( string userNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT A.idx,A.POW002,B.DBA002,A.POW003,FOR001,POW013 FROM MOXPOW A LEFT JOIN TPADBA B ON A.POW002=B.DBA001 LEFT JOIN MOXFOR C ON A.POW003=C.FOR002 " );
            strSql . Append ( "WHERE DBA001=@DBA001" );
            SqlParameter [ ] parameter = {
                new SqlParameter("@DBA001",SqlDbType.NVarChar,20)
            };
            parameter [ 0 ] . Value = userNum;

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) ,parameter );
        }

        /// <summary>
        /// 获取按钮级权限
        /// </summary>
        /// <param name="userNum"></param>
        /// <returns></returns>
        public DataTable GetDataTableBtnPower ( string userNum ,string programNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT POW004,POW005,POW006,POW007,POW008,POW009,POW010,POW011,POW012,POW013 FROM MOXPOW A LEFT JOIN MOXEMP B ON A.POW002=B.EMP001 LEFT JOIN MOXFOR C ON A.POW003=C.FOR002 " );
            strSql . Append ( "WHERE EMP001=@EMP001 AND FOR002=@FOR002" );

            SqlParameter [ ] parameter = {
                new SqlParameter("@EMP001",SqlDbType.NVarChar,20),
                new SqlParameter("@FOR002",SqlDbType.NVarChar,20)
            };
            parameter [ 0 ] . Value = userNum;
            parameter [ 1 ] . Value = programNum;

            return SqlHelper . ExecuteDataTable ( strSql . ToString ( ) ,parameter );
        }

        /// <summary>
        /// 获取登录人编号
        /// </summary>
        /// <param name="machine"></param>
        /// <returns></returns>
        public string getUserNum ( string machine )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT DISTINCT BWA901 FROM TPASYS.dbo.TPABWA WHERE BWA001=UPPER('{0}')" ,machine );
            //MessageBox . Show ( strSql . ToString ( ) );
            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "BWA901" ] . ToString ( ) ) )
                    return string . Empty;
                else
                    return dt . Rows [ 0 ] [ "BWA901" ] . ToString ( );
            }
            else
                return string . Empty;
        }

        /// <summary>
        /// 根据IP地址获取登录人编号
        /// </summary>
        /// <returns></returns>
        public string getUserNum ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT DISTINCT BMA003 FROM TPASYS.dbo.TPABMA WHERE BMA001=(SELECT MAX(BMA001) FROM TPASYS.dbo.TPABMA WHERE BMA011='{0}' GROUP BY YEAR(BMA006),MONTH(BMA006),DAY(BMA006) HAVING YEAR(MAX(BMA006))=YEAR(GETDATE()) AND MONTH(MAX(BMA006))=MONTH(GETDATE()) AND DAY(MAX(BMA006))=DAY(GETDATE()))" ,GetLocalIP ( ) );
            
            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
                return dt . Rows [ 0 ] [ "BMA003" ] . ToString ( );
            else
                return string . Empty;
        }

        /// <summary>  
        /// 获取当前使用的IP  
        /// </summary>  
        /// <returns></returns>  
        public string GetLocalIP ( )
        {
            string result = RunApp ( "route" ,"print" ,true );
            Match m = Regex . Match ( result ,@"0.0.0.0\s+0.0.0.0\s+(\d+.\d+.\d+.\d+)\s+(\d+.\d+.\d+.\d+)" );
            if ( m . Success )
            {
                return m . Groups [ 2 ] . Value;
            }
            else
            {
                try
                {
                    System . Net . Sockets . TcpClient c = new System . Net . Sockets . TcpClient ( );
                    c . Connect ( "www.baidu.com" ,80 );
                    string ip = ( ( System . Net . IPEndPoint ) c . Client . LocalEndPoint ) . Address . ToString ( );
                    c . Close ( );
                    return ip;
                }
                catch ( Exception )
                {
                    return null;
                }
            }
        }

        /// <summary>  
        /// 获取本机主DNS  
        /// </summary>  
        /// <returns></returns>  
        public  string GetPrimaryDNS ( )
        {
            string result = RunApp ( "nslookup" ,"" ,true );
            Match m = Regex . Match ( result ,@"\d+\.\d+\.\d+\.\d+" );
            if ( m . Success )
            {
                return m . Value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>  
        /// 运行一个控制台程序并返回其输出参数。  
        /// </summary>  
        /// <param name="filename">程序名</param>  
        /// <param name="arguments">输入参数</param>  
        /// <returns></returns>  
        public  string RunApp ( string filename ,string arguments ,bool recordLog )
        {
            try
            {
                if ( recordLog )
                {
                    Trace . WriteLine ( filename + " " + arguments );
                }
                Process proc = new Process ( );
                proc . StartInfo . FileName = filename;
                proc . StartInfo . CreateNoWindow = true;
                proc . StartInfo . Arguments = arguments;
                proc . StartInfo . RedirectStandardOutput = true;
                proc . StartInfo . UseShellExecute = false;
                proc . Start ( );

                using ( System . IO . StreamReader sr = new System . IO . StreamReader ( proc . StandardOutput . BaseStream ,Encoding . Default ) )
                {
                    //string txt = sr.ReadToEnd();  
                    //sr.Close();  
                    //if (recordLog)  
                    //{  
                    //    Trace.WriteLine(txt);  
                    //}  
                    //if (!proc.HasExited)  
                    //{  
                    //    proc.Kill();  
                    //}  
                    //上面标记的是原文，下面是我自己调试错误后自行修改的  
                    Thread . Sleep ( 100 );           //貌似调用系统的nslookup还未返回数据或者数据未编码完成，程序就已经跳过直接执行  
                                                      //txt = sr.ReadToEnd()了，导致返回的数据为空，故睡眠令硬件反应  
                    if ( !proc . HasExited )         //在无参数调用nslookup后，可以继续输入命令继续操作，如果进程未停止就直接执行  
                    {                            //txt = sr.ReadToEnd()程序就在等待输入，而且又无法输入，直接掐住无法继续运行  
                        proc . Kill ( );
                    }
                    string txt = sr . ReadToEnd ( );
                    sr . Close ( );
                    if ( recordLog )
                        Trace . WriteLine ( txt );
                    return txt;
                }
            }
            catch ( Exception ex )
            {
                Trace . WriteLine ( ex );
                return ex . Message;
            }
        }

        /// <summary>
        /// 获取登录人姓名
        /// </summary>
        /// <param name="userNum"></param>
        /// <returns></returns>
        public string getUserName ( string userNum )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . AppendFormat ( "SELECT DBA002 FROM TPADBA WHERE DBA001='{0}'" ,userNum );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
                return dt . Rows [ 0 ] [ "DBA002" ] . ToString ( );
            else
                return null;
        }

    }
}
