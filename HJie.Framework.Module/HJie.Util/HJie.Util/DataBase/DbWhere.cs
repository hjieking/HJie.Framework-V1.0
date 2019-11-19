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
    /// 描 述：数据库查询拼接数据模型
    /// </summary>
    public class DbWhere
    {
        /// <summary>
        /// sql语句
        /// </summary>
        public string sql { get; set; }
        /// <summary>
        /// 查询参数
        /// </summary>
        public List<FieldValueParam> dbParameters { get; set; }
        /// <summary>
        /// 是否递归
        /// </summary>
        public int isrecursion { get; set; }
        /// <summary>
        /// 递归语句
        /// </summary>
        public string recursionsql { get; set; }

    }
}
