using SqlSugar;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp1.Entity
{
    [SugarTable("xs_user")]
    public class UserEntity
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int uid { get; set; }
        public string userName { get; set; }
        public string accountNumber { get; set; }
        public string password { get; set; }
        public DateTime createTime { get; set; }
        public DateTime updateTime { get; set; }

    }
}
