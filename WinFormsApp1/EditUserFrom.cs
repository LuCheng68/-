using Microsoft.Identity.Client;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Entity;
using WinFormsApp1.Entity.vo;
using WinFormsApp1.Helper;

namespace WinFormsApp1
{
    public partial class EditUserFrom : Form
    {
        public Action action;
        public UserAuthorityVo vo;
        public EditUserFrom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uiTextBox1.Text.Trim()))
            {
                this.ShowErrorTip("请输入用户名！");
                return;
            }
            if (string.IsNullOrEmpty(uiTextBox2.Text.Trim()))
            {
                this.ShowErrorTip("请输入账号！");
                return;
            }
            if (string.IsNullOrEmpty(uiTextBox3.Text.Trim()))
            {
                this.ShowErrorTip("请输入密码！");
                return;
            }
            if (!uiTextBox4.Text.Trim().Equals(uiTextBox3.Text.Trim()))
            {
                this.ShowErrorTip("确认密码不一致！");
                return;
            }

            if (vo == null)
            {
                saveUser();
                return;
            }
            editUser();

        }

        private void editUser()
        {
            ////事务
            SqlHelper.GetInstance.BeginTran();

            try
            {
                UserEntity user = new UserEntity()
                {
                    uid = vo.uid,
                    userName = uiTextBox1.Text.Trim(),
                    accountNumber = uiTextBox2.Text.Trim(),
                    password = uiTextBox3.Text.Trim(),
                    updateTime = DateTime.Now
                };
                AuthorityEntity authority = new()
                {
                    aid = vo.aid,
                    IoManage = uiCheckBox1.Checked,
                    CameraManage = uiCheckBox4.Checked,
                    LogManage = uiCheckBox2.Checked,
                    CountManage = uiCheckBox3.Checked,
                    UserManage = uiCheckBox5.Checked
                };
                SqlHelper.GetInstance.Updateable(user).ExecuteCommand();
                SqlHelper.GetInstance.Updateable(authority).ExecuteCommand();
                this.ShowSuccessTip("修改成功！");
                Thread.Sleep(500);
                action();
                this.Close();

            }
            catch (Exception ex)
            {
                // 👇 很关键：把错误打印出来！
                MessageBox.Show(ex.Message);
                //失败回滚事务
                SqlHelper.GetInstance.RollbackTran();
                this.ShowErrorTip("添加失败！");
                return;
            }
        }

        public void saveUser()
        {
            if (SqlHelper.GetInstance.Queryable<UserEntity>().Where(x => x.accountNumber.Equals(uiTextBox2.Text.Trim())).ToList().Count > 0)
            {
                this.ShowErrorTip("账号已存在");
                return;
            }
            ////事务
            SqlHelper.GetInstance.BeginTran();

            try
            {
                int uid = SqlHelper.GetInstance.Insertable(new UserEntity
                {
                    userName = uiTextBox1.Text.Trim(),
                    accountNumber = uiTextBox2.Text.Trim(),
                    password = uiTextBox3.Text.Trim(),
                    createTime = DateTime.Now,
                    updateTime = DateTime.Now
                }).ExecuteReturnIdentity();

                int aid = SqlHelper.GetInstance.Insertable(new AuthorityEntity
                {
                    IoManage = uiCheckBox1.Checked,
                    CameraManage = uiCheckBox4.Checked,
                    LogManage = uiCheckBox2.Checked,
                    CountManage = uiCheckBox3.Checked,
                    UserManage = uiCheckBox5.Checked,
                }).ExecuteReturnIdentity();

                SqlHelper.GetInstance.Insertable(new UserverAndAuthority
                {
                    uid = uid,
                    aid = aid
                }).ExecuteCommand();

                //全部成功提交事务
                SqlHelper.GetInstance.CommitTran();
                this.ShowSuccessTip("添加成功！");
                action();
                this.Close();
            }
            catch (Exception ex)
            {
                // 👇 很关键：把错误打印出来！
                MessageBox.Show(ex.Message);
                //失败回滚事务
                SqlHelper.GetInstance.RollbackTran();
                this.ShowErrorTip("添加失败！");
                return;
            }
        }



        /// <summary>
        /// 全选/不全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton3_Click(object sender, EventArgs e)
        {
            foreach (Control item in uiGroupBox2.Controls)
            {
                if (!(item is UICheckBox))
                {
                    continue;
                }
                UICheckBox checkBox = item as UICheckBox;
                checkBox.Checked = !uiCheckBox1.Checked;
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void editUserText(UserAuthorityVo vo)
        {
            this.uiTextBox1.Text = vo.userName;
            this.uiTextBox2.Text = vo.accountNumber;
            this.uiTextBox3.Text = vo.password;
            this.uiCheckBox1.Checked = vo.IoManage;
            this.uiCheckBox2.Checked = vo.LogManage;
            this.uiCheckBox3.Checked = vo.CountManage;
            this.uiCheckBox4.Checked = vo.CountManage;
            this.uiCheckBox5.Checked = vo.UserManage;
        }
    }
}

