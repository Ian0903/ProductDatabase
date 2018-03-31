using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jxc
{
    public partial class frm_zgInfo : Form
    {
        public frm_zgInfo()
        {
            InitializeComponent();
        }



        private void t_zgBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.t_zgBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.zgzyDataSet);
                MessageBox.Show("保存数据成功！", "职工数据编辑");
            }
            catch (Exception ex)
            {
                MessageBox.Show("未满18周岁吧？", "出错啦！");
                MessageBox.Show(ex.Message);
            }

        }

        private void frm_zgInfo_Load(object sender, EventArgs e)
        {

            if ("0".Equals(jxc.BasicDataInfo.LoginInfo.Qx))
            {
                // TODO: 这行代码将数据加载到表“zgzyDataSet.t_zg”中。您可以根据需要移动或删除它。
                this.t_zgTableAdapter.Fill(this.zgzyDataSet.t_zg);
                // TODO: 这行代码将数据加载到表“zgzyDataSet.t_bm”中。您可以根据需要移动或移除它。
                this.t_bmTableAdapter.Fill(this.zgzyDataSet.t_bm);
                // TODO: 这行代码将数据加载到表“zgzyDataSet.t_zy”中。您可以根据需要移动或删除它。
                this.t_zyTableAdapter.Fill(this.zgzyDataSet.t_zy);
            }
            else
            {
                // TODO: 这行代码将数据加载到表“zgzyDataSet.t_zg”中。您可以根据需要移动或移除它。
                this.t_zgTableAdapter.FillBybh(this.zgzyDataSet.t_zg, jxc.BasicDataInfo.LoginInfo.Bh);
                // TODO: 这行代码将数据加载到表“zgzyDataSet.t_bm”中。您可以根据需要移动或移除它。
                this.t_bmTableAdapter.FillBybh(this.zgzyDataSet.t_bm, jxc.BasicDataInfo.LoginInfo.Bh);
                // TODO: 这行代码将数据加载到表“zgzyDataSet.t_zy”中。您可以根据需要移动或删除它。
                this.t_zyTableAdapter.FillBybh(this.zgzyDataSet.t_zy, jxc.BasicDataInfo.LoginInfo.Bh);
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                bhTextBox.Enabled = false;
                bmbhTextBox.Enabled = false;
                
            }
        




            
            
            

        }
    }
}
