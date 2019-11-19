using System;
using System.Collections.Generic;
using System.Text;

namespace HJie.DataBase
{
    /// <summary>
    /// 版 本  V1.0.0.0 华喜敏捷开发框架
    /// Copyright (c) 2013-2017 上海华喜信息技术有限公司
    /// 创建人：华喜-框架开发组
    /// 日 期：2017.03.04
    /// 描 述：数据库类型枚举
    /// </summary>
    public enum DatabaseType
    {
        /// <summary>
        /// 数据库类型：SqlServer
        /// </summary>
        SqlServer,
        /// <summary>
        /// 数据库类型：MySql
        /// </summary>
        MySql,
        /// <summary>
        /// 数据库类型：Oracle
        /// </summary>
        Oracle,
        /// <summary>
        /// 数据库类型：Access
        /// </summary>
        Access,
        /// <summary>
        /// 数据库类型：SQLite
        /// </summary>
        SQLite
    }
}
