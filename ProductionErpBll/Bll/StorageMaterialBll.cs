using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace ProductionErpBll . Bll
{
    public class StorageMaterialBll
    {
        readonly private Dao.StorageMaterialDao _dal=null;
        public StorageMaterialBll ( )
        {
            _dal = new Dao . StorageMaterialDao ( );
        }

        /// <summary>
        /// get order from database
        /// </summary>
        /// <returns></returns>
        public DataTable getTableOrder ( )
        {
            return _dal . getTableOrder ( );
        }

        /// <summary>
        /// get product from database
        /// </summary>
        /// <returns></returns>
        public DataTable getTablePro ( )
        {
            return _dal . getTablePro ( );
        }

        /// <summary>
        /// get datatable from database 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getViewOne ( string strWhere )
        {
            return _dal . getViewOne ( strWhere );
        }

        /// <summary>
        /// get database from database
        /// </summary>
        /// <param name="order"></param>
        /// <param name="num"></param>
        /// <param name="proNum"></param>
        /// <returns></returns>
        public DataTable getViewTwo ( string order ,string num ,string proNum )
        {
            return _dal . getViewTwo ( order ,num ,proNum );
        }


        /// <summary>
        /// 根据同供应商编号和商品信息条码编号,获取最大条码
        /// </summary>
        /// <param name="JDA004"></param>
        /// <param name="DEA004"></param>
        /// <returns></returns>
        public string getMaxCode ( string JDA004 ,string DEA004 )
        {
            return _dal . getMaxCode ( JDA004 ,DEA004 );
        }

        /// <summary>
        /// save data to database 
        /// </summary>
        /// <param name="haTable"></param>
        /// <returns></returns>
        public bool Save ( System . Collections . Hashtable haTable )
        {
            return _dal . Save ( haTable );
        }

        /// <summary>
        /// delete data from database
        /// </summary>
        /// <param name="order"></param>
        /// <param name="num"></param>
        /// <param name="proNum"></param>
        /// <returns></returns>
        public bool Delete ( string order ,string num ,string proNum )
        {
            return _dal . Delete ( order ,num ,proNum );
        }

        /// <summary>
        /// get datatable from database for print 
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public DataTable getPrint ( List<string> intList )
        {
            return _dal . getPrint ( intList );
        }

        /// <summary>
        /// 获取所有供应商编号+品号+年份开头的条码
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public DataTable getAllCode ( string prefix )
        {
            return _dal . getAllCode ( prefix );
        }

        /// <summary>
        /// 得到条码
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public DataTable getCodeOne ( string code )
        {
            return _dal . getCodeOne ( code );
        }
    }
}
