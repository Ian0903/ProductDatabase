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
    public partial class FrmJH : Form
    {
        private SqlConnection conn = null;
        public FrmJH()
        {
            InitializeComponent();
        }

        private void FrmJH_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jhdDataSet.t_zg”中。您可以根据需要移动或删除它。
            this.t_zgTableAdapter.Fill(this.jhdDataSet.t_zg);
            // TODO: 这行代码将数据加载到表“jhdDataSet.t_khgys”中。您可以根据需要移动或删除它。
            this.t_khgysTableAdapter.Fill(this.jhdDataSet.t_khgys);
            // TODO: 这行代码将数据加载到表“jhdDataSet.v_jhd”中。您可以根据需要移动或删除它。
            this.v_jhdTableAdapter.Fill(this.jhdDataSet.v_jhd);

            conn = new SqlConnection(DBHelper.conStr);

        }

        private void v_jhdDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                //this.t_jhmxTableAdapter.FillByJhrqXh(this.jhdDataSet.t_jhmx, ((DateTime)(Convert.ChangeType(v_jhdDataGridView.CurrentRow.Cells[0].Value, typeof(DateTime)))), ((short)(Convert.ChangeType(v_jhdDataGridView.CurrentRow.Cells[1].Value, typeof(short)))));
                this.t_jhmxTableAdapter.FillByJhrqXh(this.jhdDataSet.t_jhmx, Convert.ToDateTime(v_jhdDataGridView.CurrentRow.Cells[0].Value), Convert.ToInt16(v_jhdDataGridView.CurrentRow.Cells[1].Value));
                txtJhrq.Text = v_jhdDataGridView.CurrentRow.Cells[0].Value.ToString();
                txtXh.Text = v_jhdDataGridView.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

 /*       private void t_jhmxDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.v_spTableAdapter.FillBySpbh(this.jhdDataSet.v_sp, t_jhmxDataGridView.CurrentRow.Cells[0].Value.ToString());

        }*/

        private void btJhdInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            try
            {
                if (MessageBox.Show("确定要添加进货单？", "进货", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("dbo.p_insjhd", conn);
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter sqlParme;
                    sqlParme = cmd.Parameters.Add("@gysbh", SqlDbType.Char);
                    sqlParme.Direction = ParameterDirection.Input;
                    sqlParme.Value = cbgysbh.SelectedValue.ToString();
                    sqlParme = cmd.Parameters.Add("@jhrbh", SqlDbType.Char);
                    sqlParme.Direction = ParameterDirection.Input;
                    sqlParme.Value = cbjhrbh.SelectedValue.ToString();

                    sqlParme = cmd.Parameters.Add("@jhrq", SqlDbType.Char);
                    sqlParme.Value = "";
                    sqlParme = cmd.Parameters.Add("@xh", SqlDbType.Char);
                    sqlParme.Value = "";

                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        MessageBox.Show("成功插入数据！");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null) conn.Close();
                if (cmd != null) cmd.Dispose();
            }
        }

        private void btJhmxInsert_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定要添加该商品？", "进货", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtSpbh.Text.Trim() == "" || numJhsl.Value == 0 || txtJhdj.Text.Trim() == "")
                {
                    MessageBox.Show("请把数据填写完整!");
                    return;
                }
                string strSQL = "insert into t_jhmx values(";
                strSQL += "'" + txtJhrq.Text;   //
                strSQL += "','" + txtXh.Text;
                strSQL += "','" + txtSpbh.Text;
                strSQL += "'," + Convert.ToInt16(numJhsl.Value);
                strSQL += "," + Convert.ToInt16(txtJhdj.Text);
                strSQL += ")";
                SqlCommand cmd = null;
                try
                {
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = strSQL;
                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        MessageBox.Show("成功插入数据！");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conn != null) conn.Close();
                    if (cmd != null) cmd.Dispose();
                }

                this.t_jhmxTableAdapter.FillByJhrqXh(this.jhdDataSet.t_jhmx, Convert.ToDateTime(v_jhdDataGridView.CurrentRow.Cells[0].Value), Convert.ToInt16(v_jhdDataGridView.CurrentRow.Cells[1].Value));
            }
            
        }

        private void btRK_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DBHelper.conStr);
            SqlCommand cmd = null;
            try
            {
                if (t_jhmxDataGridView.CurrentRow.Cells[0].Value.ToString() == null)
                {
                    MessageBox.Show("当前进货单没有明细项，不能入库!", "进货", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (MessageBox.Show("确实要将当前进货单入库吗？\n进货单号：" + v_jhdDataGridView.CurrentRow.Cells[6].Value.ToString(), "进货", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("dbo.p_rk", conn);
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter sqlParme;
                    sqlParme = cmd.Parameters.Add("@jhrqtmp", SqlDbType.DateTime);  //.Char
                    sqlParme.Direction = ParameterDirection.Input;
                    sqlParme.Value = Convert.ToDateTime(v_jhdDataGridView.CurrentRow.Cells[0].Value.ToString()); //v_jhdDataGridView  Value
                    sqlParme = cmd.Parameters.Add("@xhtmp", SqlDbType.Int);        //.Char
                    sqlParme.Direction = ParameterDirection.Input;
                    sqlParme.Value = Convert.ToInt16(v_jhdDataGridView.CurrentRow.Cells[1].Value.ToString());

                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        MessageBox.Show("进货单入库成功！");
                    }

                }
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

        private void t_jhmxDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.v_spTableAdapter.FillBySpbh(this.jhdDataSet.v_sp, t_jhmxDataGridView.CurrentRow.Cells[0].Value.ToString());
        }

/*         private void fillBySpbhToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.v_spTableAdapter.FillBySpbh(this.jhdDataSet.v_sp, spbhToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       private void fillByJhrqXhToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_jhmxTableAdapter.FillByJhrqXh(this.jhdDataSet.t_jhmx, ((System.DateTime)(System.Convert.ChangeType(jhrqToolStripTextBox.Text, typeof(System.DateTime)))), ((short)(System.Convert.ChangeType(bhToolStripTextBox.Text, typeof(short)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/
    }
}
