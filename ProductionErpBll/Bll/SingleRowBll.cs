using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace ProductionErpBll . Bll
{
    public class SingleRowBll
    {
        readonly private Dao.SingleRowDao _dal=null;

        public SingleRowBll ( )
        {
            _dal = new Dao . SingleRowDao ( );
        }

        /// <summary>
        /// 获取产品信息
        /// </summary>
        /// <returns></returns>
        public DataTable getTableGoods ( string strWhere )
        {
            return _dal . getTableGoods ( strWhere );
        }

        /// <summary>
        /// save data to srt
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool GenerMOXSRT ( DataTable table ,List<string> strList)
        {
            return _dal . GenerMOXSRT ( table ,strList );
        }

        /// <summary>
        /// save data to sru
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool GenerMOXSRU ( DataTable table )
        {
            return _dal . GenerMOXSRU ( table );
        }

        /// <summary>
        /// save data to srv
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool GenerMOXSRV ( DataTable table )
        {
            return _dal . GenerMOXSRV ( table );
        }

    }
}
