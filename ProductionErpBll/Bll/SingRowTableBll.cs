using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace ProductionErpBll . Bll
{
    public class SingRowTableBll
    {
        readonly private Dao.SingRowTableDao _dal=null;
        public SingRowTableBll ( )
        {
            _dal = new Dao . SingRowTableDao ( );
        }

        /// <summary>
        /// get data list
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTableOne ( string strWhere )
        {
            return _dal . getTableOne ( strWhere );
        }

        /// <summary>
        /// get data from database
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        public DataTable getTableOnly ( string column )
        {
            return _dal . getTableOnly ( column );
        }

        /// <summary>
        /// get data list
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTableTwo ( string strWhere )
        {
            return _dal . getTableTwo ( strWhere );
        }

        /// <summary>
        /// get data list
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getTableTre ( string strWhere )
        {
            return _dal . getTableTre ( strWhere );
        }

        /// <summary>
        /// getColumnsTable
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable getTableOnly ( string columns ,string tableName )
        {
            return _dal . getTableOnly ( columns ,tableName );
        }

        /// <summary>
        /// get print table
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public DataTable getPrintOne ( List<int> intList )
        {
            return _dal . getPrintOne ( intList );
        }

        /// <summary>
        /// delete data from database for moxstr
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public bool Delete ( List<int> intList )
        {
            return _dal . Delete ( intList );
        }

    }
}
