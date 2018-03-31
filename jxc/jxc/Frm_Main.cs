using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using jxc.BasicDataInfo;

namespace jxc
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MnuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult key = MessageBox.Show("确定要关闭窗体吗？", "确定", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (key == DialogResult.No);
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            setRight();
            tslb_name.Text = "登陆信息：欢迎您！" + LoginInfo.Xm;
            tslb_time.Text = DateTime.Now.ToString("yyyy年MM月dd日");

        }
        /// <summary>
        /// 菜单权限设置
        /// </summary>
        private void setRight()
        {
            if ("20".Equals(LoginInfo.Qx))
            {
                MnuXs.Enabled = false;
                MnuXt.Enabled = false;

            }
            else if ("21".Equals(LoginInfo.Qx))
            {
                MnuXt.Enabled = false;
            }
            else if ("30".Equals(LoginInfo.Qx))
            {
                MnuJh.Enabled = false;
                MnuXt.Enabled = false;
            }
            else if ("31".Equals(LoginInfo.Qx))
            {
                MnuXt.Enabled = false;
            }
            else if ("0".Equals(LoginInfo.Qx))
            { // 高级管理员
                MnuBm.Enabled = true;
                MnuZy.Enabled = true;
                MnuKhGys.Enabled = true;
                MnuSp.Enabled = true;
                MnuJh.Enabled = true;
                MnuXs.Enabled = true;
               

            }
        }

        private void MnuZg_Click(object sender, EventArgs e)
        {
            frm_zgInfo frm_zg = new frm_zgInfo();
            frm_zg.Show();

        }

        private void MnuBm_Click(object sender, EventArgs e)
        {
            FrmBM frm_bm = new FrmBM();
            frm_bm.Show();
        }

        private void MnuJhLr_Click(object sender, EventArgs e)
        {
            FrmJH frm_jh = new FrmJH();
            frm_jh.Show();
        }

        private void MnuJhCxTj_Click(object sender, EventArgs e)
        {
            FrmCX frm_cx = new FrmCX();
            frm_cx.Show();
        }


        



    }
}
