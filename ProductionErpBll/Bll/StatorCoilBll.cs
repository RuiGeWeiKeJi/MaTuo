using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace ProductionErpBll . Bll
{
    public class StatorCoilBll
    {
        readonly private Dao.StatorCoilDao _dal=null;
        public StatorCoilBll ( )
        {
            _dal = new Dao . StatorCoilDao ( );
        }

        /// <summary>
        /// Does it Exists
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public bool getCodeNum ( string codeNum )
        {
            return _dal . getCodeNum ( codeNum );
        }


        /// <summary>
        /// query dataTable from database
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public DataTable tableView ( string codeNum )
        {
            return _dal . tableView ( codeNum );
        }

        /// <summary>
        /// query dataSet from database
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public ProductionErpEntity . StatorCoilSTCEntity getModel ( string codeNum )
        {
            return _dal . getModel ( codeNum );

        }


        /// <summary>
        /// edit data from view to database
        /// </summary>
        /// <param name="_stc"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Save ( ProductionErpEntity . StatorCoilSTCEntity _stc ,DataTable table )
        {
            return _dal . Save ( _stc ,table );
        }

        /// <summary>
        /// getPrintOne
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public DataTable getPrintOne ( string codeNum )
        {
            return _dal . getPrintOne ( codeNum );
        }

        /// <summary>
        /// getPrintTwo
        /// </summary>
        /// <param name="codeNum"></param>
        /// <returns></returns>
        public DataTable getPrintTwo ( string codeNum )
        {
            return _dal . getPrintTwo ( codeNum );
        }

        /// <summary>
        /// get table from database
        /// </summary>
        /// <param name="userNum"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public DataTable getDataTablePowForArt ( string userNum ,string item )
        {
            return _dal . getDataTablePowForArt ( userNum ,item );
        }

        /// <summary>
        /// 获取人员信息
        /// </summary>
        /// <returns></returns>
        public DataTable getUserDataTable ( )
        {
            return _dal . getUserDataTable ( );
        }

    }
}
