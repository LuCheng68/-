using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Entity.vo
{
    public class UserAuthorityVo
    {
        public int aid { get; set; }
        public bool IoManage { get; set; }
        public bool CameraManage { get; set; }
        public bool LogManage { get; set; }
        public bool CountManage { get; set; }
        public bool UserManage { get; set; }
        public int uid { get; set; }
        public string userName { get; set; }
        public string accountNumber { get; set; }
        public string password { get; set; }
    }
}
