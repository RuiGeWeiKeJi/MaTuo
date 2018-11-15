using System . Collections . Generic;
using System . Data;

namespace ProductionErpBll . Bll
{
    public class ArtPowerBll
    {
        private readonly Dao.ArtPowerDao _dal=null;
        public ArtPowerBll ( )
        {
            _dal = new Dao . ArtPowerDao ( );
        }

        /// <summary>
        /// 获取工艺信息
        /// </summary>
        /// <returns></returns>
        public DataTable getArt ( )
        {
            return _dal . getArt ( );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="personNum"></param>
        /// <returns></returns>
        public DataTable tableView ( string strWhere )
        {
            return _dal . tableView ( strWhere );
        }

        /// <summary>
        /// 获取人员信息
        /// </summary>
        /// <returns></returns>
        public DataTable tablePerson ( )
        {
            return _dal . GetPerson ( );
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Save ( DataTable table ,List<string> strList)
        {
            return _dal . Save ( table ,strList );
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool Delete ( DataTable table )
        {
            return _dal . Delete ( table );
        }
    }
}
