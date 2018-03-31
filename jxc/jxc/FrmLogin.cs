using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using jxc.BasicDataInfo;
using System.Data.SqlClient;

namespace jxc
{
    public partial class FrmLogin : Form
    {
        static int loginCount;
        private Boolean bResult = false;

        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 验证登陆方法
        /// </summary>
        public void loginValidate()
        {
            if (txtUserName.Text.Trim() == "" || string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("用户名不能为空！", "登陆提示");
                txtUserName.Focus();
            }
            else if (txtPassword.Text.Trim() == "" || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("密码不能为空！", "登陆提示");
                txtPassword.Focus();
            }
            else
            {
                // LoginInfo u = null;
                SqlConnection con = new SqlConnection(DBHelper.conStr);
                try
                {
                    con.Open();
                    if ("admin".Equals(txtUserName.Text.Trim()))
                    {
                        string sql = "select nr from t_cs where mc='adminpass'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            if (Convert.ToString(dr["nr"]).Equals(txtPassword.Text))
                            {
                                LoginInfo.Bh = "admin";
                                LoginInfo.Xm = "管理员";
                                LoginInfo.Qx = "0";
                                bResult = true;
                            }
                            else
                            {
                                loginCount++;
                                tips.ForeColor = Color.Red;
                                tips.Text = "第" + loginCount + "次输入密码错误";
                            }

                        }
                    }
                    else
                    { // 非高级管理员
                        string sql = string.Format("select * from t_zg where " +
                        "bh='{0}' and kl = '{1}'", txtUserName.Text, txtPassword.Text);
                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            LoginInfo.Bh = Convert.ToString(dr["bh"]);
                            LoginInfo.Xm = Convert.ToString(dr["xm"]);
                            LoginInfo.Xb = Convert.ToString(dr["xb"]);
                            LoginInfo.Qx = Convert.ToString(dr["qx"]);
                            bResult = true;
                        }
                        else
                        {
                            loginCount++;
                            tips.ForeColor = Color.Red;
                            tips.Text = "第" + loginCount + "次输入密码错误";
                        }
                        dr.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                if (bResult)
                {
                    // LoginInfo.loginUserInfo = u;
                    // 显示主窗体
                    this.Visible = false;
                    Frm_Main fm = new Frm_Main();
                    fm.Show();
                }

                if (loginCount == 3)
                {
                    MessageBox.Show("登陆错误次数超出限制，程序退出！", "登陆提示");
                    Application.Exit();
                }


            }
        }


        private void btSubmit_Click(object sender, EventArgs e)
        {


            loginValidate();

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserName.Text != "" && txtPassword.Text != "")
                    loginValidate();
                else
                    SendKeys.Send("{TAB}");
            }


        }
    }
}
