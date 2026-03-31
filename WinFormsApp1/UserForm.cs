using Microsoft.Identity.Client;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Entity;
using WinFormsApp1.Entity.vo;
using WinFormsApp1.Helper;

namespace WinFormsApp1
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            uiDataGridView1.AutoGenerateColumns = false;
            queryUser();
        }

        private void queryUser()
        {
            List<UserEntity> list = SqlHelper.GetInstance.Queryable<UserEntity>().ToList();

            var result = SqlHelper.GetInstance.Queryable<UserEntity>()
                 .LeftJoin<UserverAndAuthority>((u, ua) => u.uid == ua.uid)
                 .LeftJoin<AuthorityEntity>((u, ua, a) => ua.aid == a.aid)
                 .Select((u, ua, a) => new
                 {
                     Uid = u.uid,
                     UserName = u.userName,
                     Account = u.accountNumber,
                     Password = u.password,
                     IoManage = a.IoManage,
                     CameraManage = a.CameraManage,
                     LogManage = a.LogManage,
                     CountManage = a.CountManage,
                     UserManage = a.UserManage,
                     Aid = ua.aid,
                 })
                 .ToList();
            Debug.WriteLine(result.Count.ToString());

            this.uiDataGridView1.DataSource = null;
            this.uiDataGridView1.DataSource = result;

        }

        /// <summary>
        /// 打开新增用户窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            EditUserFrom editUserFrom = new();
            editUserFrom.action = queryUser;
            editUserFrom.ShowDialog();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            EditUserFrom editUserFrom = new();
            editUserFrom.action = queryUser;
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (SelectCheckedRow() != 1)
            {
                this.ShowErrorTip("请选择一条数据");
                return;
            }
            UserAuthorityVo vo = SelectItem();
            using (EditUserFrom editUserFrom = new EditUserFrom())
            {
                editUserFrom.Text = "修改用户";
                editUserFrom.editUserText(vo);
                editUserFrom.action = queryUser;
                editUserFrom.ShowDialog();
            }

        }

        public UserAuthorityVo SelectItem()
        {
            foreach (DataGridViewRow item in uiDataGridView1.Rows)
            {
                if (item.Cells[0].Value != null && Convert.ToBoolean(item.Cells[0].Value))
                {
                    UserAuthorityVo vo = new UserAuthorityVo
                    {
                        uid = int.Parse(item.Cells["Uid"].Value.ToString()),
                        aid = int.Parse(item.Cells["Aid"].Value.ToString()),
                        userName = item.Cells["UserName"].Value.ToString(),
                        accountNumber = item.Cells["Account"].Value.ToString(),
                        password = item.Cells["Password"].Value.ToString(),
                        IoManage = Convert.ToBoolean(item.Cells["IoManage"].Value.ToString()),
                        CameraManage = Convert.ToBoolean(item.Cells["CameraManage"].Value.ToString()),
                        LogManage = Convert.ToBoolean(item.Cells["LogManage"].Value.ToString()),
                        CountManage = Convert.ToBoolean(item.Cells["CountManage"].Value.ToString()),
                        UserManage = Convert.ToBoolean(item.Cells["UserManage"].Value.ToString()),
                    };
                    return vo;
                }
            }
            return null;
        }


        private int SelectCheckedRow()
        {
            int count = 0;
            foreach (DataGridViewRow item in uiDataGridView1.Rows)
            {
                if (item.Cells[0].Value != null && Convert.ToBoolean(item.Cells[0].Value))
                {
                    count++;
                }
            }
            return count;
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (SelectCheckedRow() != 1)
            {
                this.ShowErrorTip("请选择一条数据！");
                return;
            }
            SqlHelper.GetInstance.BeginTran();
            try
            {
                foreach (DataGridViewRow item in uiDataGridView1.Rows)
                {
                    if (item.Cells[0].Value != null && Convert.ToBoolean(item.Cells[0].Value))
                    {
                        SqlHelper.GetInstance.Deleteable<UserEntity>()
                            .Where(x => x.uid == SelectItem().uid)
                            .ExecuteCommand();
                        SqlHelper.GetInstance.Deleteable<AuthorityEntity>()
                            .Where(x => x.aid == SelectItem().aid)
                            .ExecuteCommand();
                        SqlHelper.GetInstance.Deleteable<UserverAndAuthority>()
                            .Where(x => x.uid == SelectItem().uid)
                            .ExecuteCommand();

                        this.ShowSuccessTip("删除成功");
                        SqlHelper.GetInstance.CommitTran();
                        this.queryUser();
                    }
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorTip(ex.Message);
                SqlHelper.GetInstance.RollbackTran();
            }
        }
    }
}
