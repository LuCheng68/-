using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Entity
{
    [SugarTable("xs_su")]
    public class AuthorityEntity
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int aid { get; set; }
        public bool IoManage { get; set; }
        public bool CameraManage { get; set; }
        public bool LogManage { get; set; }
        public bool CountManage { get; set; }
        public bool UserManage { get; set; }

    }
}
