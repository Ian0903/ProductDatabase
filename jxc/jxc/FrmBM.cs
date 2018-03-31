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
    public partial class FrmBM : Form
    {
        public FrmBM()
        {
            InitializeComponent();
        }

        private void t_bmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_bmBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zgzyDataSet);

        }

        private void FrmBM_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“zgzyDataSet.t_zg”中。您可以根据需要移动或删除它。
            this.t_zgTableAdapter.Fill(this.zgzyDataSet.t_zg);
            // TODO: 这行代码将数据加载到表“zgzyDataSet.t_zy”中。您可以根据需要移动或删除它。
            this.t_zyTableAdapter.Fill(this.zgzyDataSet.t_zy);
            // TODO: 这行代码将数据加载到表“zgzyDataSet.t_bm”中。您可以根据需要移动或删除它。
            this.t_bmTableAdapter.Fill(this.zgzyDataSet.t_bm);

        }
    }
}
