using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace WinFormsApp1.Helper
{
    public class SqlHelper
    {
        private SqlHelper()
        {
        }

        private static SqlSugarClient instance;

        public static SqlSugarClient GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SqlSugarClient(new ConnectionConfig()
                    {
                        ConnectionString = ConfigurationManager.AppSettings["SqlServerConfig"].ToString(),
                        DbType = DbType.SqlServer,
                        IsAutoCloseConnection = true
                    });
                }
                return instance;

            }
        }
    }
}
