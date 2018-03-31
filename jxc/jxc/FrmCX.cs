using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace jxc
{
    public partial class FrmCX : Form
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;

        public FrmCX()
        {
            InitializeComponent();
        }

        private void FrmCX_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(DBHelper.conStr);
            try
            {
                conn.Open();

                cbGys.Items.Add("(000000)全部");
                string sql = "SELECT '('+bh+')'+mc as bhmc FROM t_khgys ORDER BY bh";
                cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbGys.Items.Add(Convert.ToString(dr["bhmc"]));

                }
                if (cmd != null) cmd.Dispose();
                if (dr != null) dr.Dispose();

                cbJhr.Items.Add("(0000)全部");
                string sql2 = "SELECT '('+bh+')'+xm as bhxm FROM t_zg where qx in (20,21) ORDER BY bh";
                cmd = new SqlCommand(sql2, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbJhr.Items.Add(Convert.ToString(dr["bhxm"]));

                }
                if (dr != null) dr.Dispose();

                cbGys.SelectedIndex = 0;
                if ("21".Equals(jxc.BasicDataInfo.LoginInfo.Qx))
                {
                    cbJhr.SelectedIndex = cbJhr.Items.IndexOf('(' + jxc.BasicDataInfo.LoginInfo.Bh + ')' + jxc.BasicDataInfo.LoginInfo.Xm);
                    cbJhr.Enabled = false;
                }
                else
                {
                    cbJhr.SelectedIndex = 0;
                }
                DateTime dt = DateTime.Now;
                DTPFrom.Value = dt.AddMonths(-1);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null) conn.Close();
                if (cmd != null) cmd.Dispose();
            }
        }

        private void btSelect_Click(object sender, EventArgs e)
        {

            try
            {
                string gysbh = cbGys.Text.Substring(1, 6);
                string jhrbh = cbJhr.Text.Substring(1, 4);
                if ("000000".Equals(gysbh)) gysbh = "%";
                if ("0000".Equals(jhrbh)) jhrbh = "%";

                if (cbRqbx.Checked)
                {
                    this.p_jhdTableAdapter.Fill(this.jhdDataSet.p_jhd, null, null, gysbh, jhrbh);
                }
                else
                {
                    if (Convert.ToDateTime(DTPFrom.Text) > Convert.ToDateTime(DTPTo.Text))
                    {
                        MessageBox.Show("日期范围不正确！", "进货查询", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.p_jhdTableAdapter.Fill(this.jhdDataSet.p_jhd, Convert.ToDateTime(DTPFrom.Text), Convert.ToDateTime(DTPTo.Text), gysbh, jhrbh);
                    }

                }
                //MessageBox.Show(cbGys.Text.Substring(1,6));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

/*        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_jhdTableAdapter.Fill(this.jhdDataSet.p_jhd, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(jhrqfromToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(jhrqtoToolStripTextBox.Text, typeof(System.DateTime))))), gysbhToolStripTextBox.Text, jhrbhToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
 */
    }
}
