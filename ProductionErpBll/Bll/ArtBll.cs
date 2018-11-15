using System;
using System . Collections . Generic;
using System . Data;
using System . Linq;
using System . Text;

namespace ProductionErpBll . Bll
{
    public class ArtBll
    {
        private readonly Dao.ArtDao _dal=null;

        public ArtBll ( )
        {
            _dal = new Dao . ArtDao ( );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable ( )
        {
            return _dal . GetDataTable ( );
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public bool Delete ( int idx )
        {
            return _dal . Delete ( idx );
        }


        /// <summary>
        /// 保存数据到数据库
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Save ( DataTable table,List<int> intList )
        {
            return _dal . Save ( table ,intList );
        }
    }
}
