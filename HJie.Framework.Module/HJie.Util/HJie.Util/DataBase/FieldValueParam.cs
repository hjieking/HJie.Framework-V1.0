using System;
using System.Collections.Generic;
using System.Text;

namespace HJie.Util
{
    /// <summary>
    /// 版 本  V1.0.0.0 华喜敏捷开发框架
    /// Copyright (c) 2013-2017 上海华喜信息技术有限公司
    /// 创建人：华喜-框架开发组
    /// 日 期：2017.03.07
    /// 描 述：数据库参数
    /// </summary>
    public class FieldValueParam
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 数据值
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public int type { get; set; }
    }
}
