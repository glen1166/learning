using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Class3
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [ColumnSet("商品编码", 26, 20, AutoWidth = true)]
        public string ProdNo { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [ColumnSet("名称", 27, 30, AutoWidth = true)]
        public string ProdName { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [ColumnSet("规格", 28, 25, AutoWidth = true)]
        public string Spec { get; set; }
    }
}
