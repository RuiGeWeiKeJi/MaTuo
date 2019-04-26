using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;

namespace ProductionErpEntity
{
    public class BrakeBRCEntity
    {

        private int _idx;
        private string _brc001;
        private string _brc002;
        private string _brc003;
        private string _brc004;
        private bool _brc005;
        private bool _brc006;
        private decimal? _brc007;
        private bool _brc008;
        private bool _brc009;
        private int? _brc010;
        /// <summary>
        /// 
        /// </summary>
        public int idx
        {
            set
            {
                _idx = value;
            }
            get
            {
                return _idx;
            }
        }
        /// <summary>
        /// 条码
        /// </summary>
        public string BRC001
        {
            set
            {
                _brc001 = value;
            }
            get
            {
                return _brc001;
            }
        }
        /// <summary>
        /// 品号
        /// </summary>
        public string BRC002
        {
            set
            {
                _brc002 = value;
            }
            get
            {
                return _brc002;
            }
        }
        /// <summary>
        /// 品名
        /// </summary>
        public string BRC003
        {
            set
            {
                _brc003 = value;
            }
            get
            {
                return _brc003;
            }
        }
        /// <summary>
        /// 规格
        /// </summary>
        public string BRC004
        {
            set
            {
                _brc004 = value;
            }
            get
            {
                return _brc004;
            }
        }
        /// <summary>
        /// 工频耐压  0:不合格  1:合格
        /// </summary>
        public bool BRC005
        {
            set
            {
                _brc005 = value;
            }
            get
            {
                return _brc005;
            }
        }
        /// <summary>
        /// 绝缘电阻      0:不合格  1:合格
        /// </summary>
        public bool BRC006
        {
            set
            {
                _brc006 = value;
            }
            get
            {
                return _brc006;
            }
        }
        /// <summary>
        /// 直流电阻（）
        /// </summary>
        public decimal? BRC007
        {
            set
            {
                _brc007 = value;
            }
            get
            {
                return _brc007;
            }
        }
        /// <summary>
        /// 制动器最低启动电压能吸合
        /// </summary>
        public bool BRC008
        {
            set
            {
                _brc008 = value;
            }
            get
            {
                return _brc008;
            }
        }
        /// <summary>
        /// 制动器开关动作判定
        /// </summary>
        public bool BRC009
        {
            set
            {
                _brc009 = value;
            }
            get
            {
                return _brc009;
            }
        }
        /// <summary>
        /// 制动器吸合释放噪音（dB）
        /// </summary>
        public int? BRC010
        {
            set
            {
                _brc010 = value;
            }
            get
            {
                return _brc010;
            }
        }

    }
}
