using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace ProductionErpBll . Bll
{
    public class WindBaseBll
    {
        private readonly Dao.WindBaseDao _dal=null;
        public WindBaseBll ( )
        {
            _dal = new Dao . WindBaseDao ( );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable tableView ( string strWhere )
        {
            return _dal . tableView ( strWhere );
        }

        /// <summary>
        /// 获取商品信息
        /// </summary>
        /// <returns></returns>
        public DataTable tableGood ( )
        {
            return _dal . tableGood ( );
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Delete ( DataTable table )
        {
            return _dal . Delete ( table );
        }
        public bool Delete ( int idx )
        {
            return _dal . Delete ( idx );
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Save ( DataTable table )
        {
            return _dal . Save ( table );
        }

    }
}
