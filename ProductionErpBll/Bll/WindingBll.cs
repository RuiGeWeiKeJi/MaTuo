using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace ProductionErpBll . Bll
{
    public class WindingBll
    {
        readonly private Dao.WindingDao _dal=null;
        public WindingBll ( )
        {
            _dal = new Dao . WindingDao ( );
        }

        /// <summary>
        /// get data list
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="tableNum"></param>
        /// <returns></returns>
        public DataTable getTableOnly ( string columns ,string tableNum )
        {
            return _dal . getTableOnly ( columns ,tableNum );
        }


        /// <summary>
        /// 获取工单号
        /// </summary>
        /// <returns></returns>
        public DataTable getTableGD ( )
        {
            return _dal . getTableGD ( );
        }

        /// <summary>
        /// get user data
        /// </summary>
        /// <returns></returns>
        public DataTable getTableUser ( )
        {
            return _dal . getTableUser ( );
        }

        /// <summary>
        /// get table of view
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable tableView ( string strWhere )
        {
            return _dal . tableView ( strWhere );
        }

        /// <summary>
        /// get table of head
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public ProductionErpEntity . WindingWIDEntity tableHead ( string strWhere )
        {
            return _dal . tableHead ( strWhere );
        }

        /// <summary>
        /// 删除一单记录
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public bool Delete ( string oddNum )
        {
            return _dal . Delete ( oddNum );
        }

        /// <summary>
        /// add data of view to database
        /// </summary>
        /// <param name="table"></param>
        /// <param name="_wid"></param>
        /// <returns></returns>
        public bool Add ( DataTable table ,ProductionErpEntity . WindingWIDEntity _wid )
        {
            return _dal . Add ( table ,_wid );
        }


        /// <summary>
        /// edit data of view to database 
        /// </summary>
        /// <param name="table"></param>
        /// <param name="_wid"></param>
        /// <returns></returns>
        public bool Edit ( DataTable table ,ProductionErpEntity . WindingWIDEntity _wid )
        {
            return _dal . Edit ( table ,_wid );
        }

        /// <summary>
        /// get datatable of job num
        /// </summary>
        /// <param name="jobNum"></param>
        /// <returns></returns>
        public DataTable getJobNumIn ( string jobNum )
        {
            return _dal . getJobNumIn ( jobNum );
        }

        /// <summary>
        /// get print table 
        /// </summary>
        /// <param name="oddNum"></param>
        /// <returns></returns>
        public DataTable getPrintOne ( string oddNum )
        {
            return _dal . getPrintOne ( oddNum );
        }

        /// <summary>
        /// get print table
        /// </summary>
        /// <returns></returns>
        public DataTable getPrintTwo ( string OddNum )
        {
            return _dal . getPrintTwo ( OddNum );
        }

    }
}
