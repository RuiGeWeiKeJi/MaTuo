using System . Data;

namespace CarpenterBll . Bll
{
    public class MainBll
    {
        private readonly Dao.MainDao _dao=new Dao.MainDao();

        /// <summary>
        /// 获取权限
        /// </summary>
        /// <param name="userNum"></param>
        /// <returns></returns>
        public DataTable GetDataTablePower ( string userNum )
        {
            return _dao . GetDataTablePower ( userNum );
        }

        /// <summary>
        /// 获取按钮级权限
        /// </summary>
        /// <param name="userNum"></param>
        /// <returns></returns>
        public DataTable GetDataTableBtnPower ( string userNum ,string programNum )
        {
            return _dao . GetDataTableBtnPower ( userNum ,programNum );
        }

        /// <summary>
        /// 获取登录人信息
        /// </summary>
        /// <param name="machine"></param>
        /// <returns></returns>
        public string getUserNum ( string machine )
        {
            return _dao . getUserNum ( machine );
        }

        /// <summary>
        /// 根据IP地址获取登录人信息
        /// </summary>
        /// <returns></returns>
        public string getUserNum ( )
        {
            return _dao . getUserNum ( );
        }

        public string GetLocalIP ( )
        {
            return _dao . GetLocalIP ( );
        }

        /// <summary>
        /// 获取登录人姓名
        /// </summary>
        /// <param name="userNum"></param>
        /// <returns></returns>
        public string getUserName ( string userNum )
        {
            return _dao . getUserName ( userNum );
        }

    }
}
