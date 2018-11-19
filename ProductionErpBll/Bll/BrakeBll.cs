using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace ProductionErpBll . Bll
{
    public class BrakeBll
    {
        readonly private Dao.BrakeDao _dal=null;
        public BrakeBll ( )
        {
            _dal = new Dao . BrakeDao ( );
        }

        /// <summary>
        /// doed it exists
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public bool getCodeNum ( string codeNum )
        {
            return _dal . getCodeNum ( codeNum );
        }

        /// <summary>
        /// get data from database to view 
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public DataTable getTableView ( String codeNum )
        {
            return _dal . getTableView ( codeNum );
        }

        /// <summary>
        /// get data from database
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public ProductionErpEntity . BrakeBRAEntity getModel ( string codeNum )
        {
            return _dal . getModel ( codeNum );
        }

        /// <summary>
        /// edit data to database
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Save ( DataTable table )
        {
            return _dal . Save ( table );
        }

        /// <summary>
        /// get print data from datatable
        /// </summary>
        /// <returns></returns>
        public DataTable getPrintOne ( string codeNum )
        {
            return _dal . getPrintOne ( codeNum );
        }

        /// <summary>
        /// get print data from datatable
        /// </summary>
        /// <returns></returns>
        public DataTable getPrintTwo ( string codeNum )
        {
            return _dal . getPrintTwo ( codeNum );
        }


        /// <summary>
        /// 获取供应商
        /// </summary>
        /// <returns></returns>
        public DataTable getTableSup ( )
        {
            return _dal . getTableSup ( );
        }

        public DataTable getTableSupOne ( )
        {
            return _dal . getTableSupOne ( );
        }

    }
}
