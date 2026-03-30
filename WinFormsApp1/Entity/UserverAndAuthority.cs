using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Entity
{
    [SugarTable("xs_user_a")]
    public class UserverAndAuthority
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }
        public int uid { get; set; }
        public int aid { get; set; }

    }
}
