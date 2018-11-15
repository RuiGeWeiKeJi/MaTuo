using StudentMgr;
using System;
using System . Data;
using System . Text;

namespace CarpenterBll
{
    public static class UserInformation
    {
        private static string _userName;
        /// <summary>
        /// 登录者
        /// </summary>
        public static string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }

        private static string _userNum;
        /// <summary>
        /// 登录者
        /// </summary>
        public static string UserNum
        {
            get
            {
                return _userNum;
            }
            set
            {
                _userNum = value;
            }
        }

        private static string _programName;
        /// <summary>
        /// 程序
        /// </summary>
        public static string ProgramName
        {
            get
            {
                return _programName;
            }
            set
            {
                _programName = value;
            }
        }

        private static string _typeOfOper;
        /// <summary>
        /// 操作类型
        /// </summary>
        public static string TypeOfOper
        {
            get
            {
                return _typeOfOper;
            }
            set
            {
                _typeOfOper = value;
            }
        }

        public static DateTime dt ( )
        {
            StringBuilder strSql = new StringBuilder ( );
            strSql . Append ( "SELECT GETDATE() t " );

            DataTable dt = SqlHelper . ExecuteDataTable ( strSql . ToString ( ) );
            if ( dt != null && dt . Rows . Count > 0 )
            {
                if ( string . IsNullOrEmpty ( dt . Rows [ 0 ] [ "t" ] . ToString ( ) ) )
                    return DateTime . Now;
                else
                    return Convert . ToDateTime ( dt . Rows [ 0 ] [ "t" ] . ToString ( ) );
            }
            else
                return DateTime . Now;
        }

    }
}
