using HJie.DataBase.Oracle;
using HJie.Util;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace HJie.DataBase.Repository
{
    /// <summary>
    /// 版 本  V1.0.0.0 华喜敏捷开发框架
    /// Copyright (c) 2013-2017 上海华喜信息技术有限公司
    /// 创建人：华喜-框架开发组
    /// 日 期：2017.03.04
    /// 描 述：数据库建立工厂
    /// </summary>
    public class DbFactory
    {
        /// <summary>
        /// 连接基础库
        /// </summary>
        /// <returns></returns>
        public static IDatabase GetIDatabase()
        {

            string providerName = Config.GetValue("DbName"); //ConfigurationManager.ConnectionStrings["BaseDb"].ProviderName;
            return GetIDatabaseByIoc(GetDbType(providerName).ToString(), Config.GetValue("Oracle"));
        }
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="connString">连接字符串</param>
        /// <param name="DbType">数据库类型</param>
        /// <returns></returns>
        public static IDatabase GetIDatabase(string connString, DatabaseType dbType)
        {
            return GetIDatabaseByIoc(dbType.ToString(), connString);
        }
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="connString">连接字符串</param>
        /// <param name="dbType">数据库类型</param>
        /// <returns></returns>
        public static IDatabase GetIDatabase(string connString, string dbType)
        {
            return GetIDatabaseByIoc(dbType, connString);
        }
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="name">连接配置名称</param>
        /// <returns></returns>
        public static IDatabase GetIDatabase(string name)
        {
            string providerName =Config.GetValue("DbName") ;//ConfigurationManager.ConnectionStrings[name].ProviderName;
            return GetIDatabaseByIoc(GetDbType(providerName).ToString(), name);
        }
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="name">数据库类型</param>
        /// <param name="connString">连接字符串</param>
        /// <returns></returns>
        private static IDatabase GetIDatabaseByIoc(string name, string connString)
        {
            return new Database(connString);
            //return UnityIocHelper.Instance.GetService<IDatabase>(name, new ParameterOverride(
            // "connString", connString));
        }
        /// <summary>
        /// 获取数据库类型
        /// </summary>
        /// <param name="providerName">驱动名称</param>
        /// <returns></returns>
        private static DatabaseType GetDbType(string providerName)
        {
            DatabaseType dbType;
            switch (providerName)
            {
                case "SqlClient":
                    dbType = DatabaseType.SqlServer;
                    break;
                case "MySql":
                    dbType = DatabaseType.MySql;
                    break;
                case "Oracle":
                    dbType = DatabaseType.Oracle;
                    break;
                default:
                    dbType = DatabaseType.SqlServer;
                    break;

                    //case "System.Data.SqlClient":
                    //    dbType = DatabaseType.SqlServer;
                    //    break;
                    //case "MySql.Data.MySqlClient":
                    //    dbType = DatabaseType.MySql;
                    //    break;
                    //case "Oracle.ManagedDataAccess.Client":
                    //    dbType = DatabaseType.Oracle;
                    //    break;
                    //default:
                    //    dbType = DatabaseType.SqlServer;
                    //    break;
            }
            return dbType;
        }
    }
}
