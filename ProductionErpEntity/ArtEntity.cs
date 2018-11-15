using System;


namespace ProductionErpEntity
{
    public sealed class ArtEntity
    {
        private int _idx;
        private string _art001;
        private string _art002;

        public int Idx
        {
            get
            {
                return _idx;
            }

            set
            {
                _idx = value;
            }
        }

        /// <summary>
        /// 工艺名称
        /// </summary>
        public string Art001
        {
            get
            {
                return _art001;
            }

            set
            {
                _art001 = value;
            }
        }

        /// <summary>
        /// 工艺类型
        /// </summary>
        public string Art002
        {
            get
            {
                return _art002;
            }

            set
            {
                _art002 = value;
            }
        }
    }
}
