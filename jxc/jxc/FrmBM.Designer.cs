namespace jxc
{
    partial class FrmBM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBM));
            this.zgzyDataSet = new jxc.zgzyDataSet();
            this.t_bmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_bmTableAdapter = new jxc.zgzyDataSetTableAdapters.t_bmTableAdapter();
            this.tableAdapterManager = new jxc.zgzyDataSetTableAdapters.TableAdapterManager();
            this.t_zgTableAdapter = new jxc.zgzyDataSetTableAdapters.t_zgTableAdapter();
            this.t_zyTableAdapter = new jxc.zgzyDataSetTableAdapters.t_zyTableAdapter();
            this.t_bmBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.t_bmBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.t_bmDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.负责人 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tzgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tzyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmBindingNavigator)).BeginInit();
            this.t_bmBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zgzyDataSet
            // 
            this.zgzyDataSet.DataSetName = "zgzyDataSet";
            this.zgzyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_bmBindingSource
            // 
            this.t_bmBindingSource.DataMember = "t_bm";
            this.t_bmBindingSource.DataSource = this.zgzyDataSet;
            // 
            // t_bmTableAdapter
            // 
            this.t_bmTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.t_bmTableAdapter = this.t_bmTableAdapter;
            this.tableAdapterManager.t_zgTableAdapter = this.t_zgTableAdapter;
            this.tableAdapterManager.t_zyTableAdapter = this.t_zyTableAdapter;
            this.tableAdapterManager.UpdateOrder = jxc.zgzyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_zgTableAdapter
            // 
            this.t_zgTableAdapter.ClearBeforeFill = true;
            // 
            // t_zyTableAdapter
            // 
            this.t_zyTableAdapter.ClearBeforeFill = true;
            // 
            // t_bmBindingNavigator
            // 
            this.t_bmBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_bmBindingNavigator.BindingSource = this.t_bmBindingSource;
            this.t_bmBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_bmBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_bmBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.t_bmBindingNavigatorSaveItem});
            this.t_bmBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_bmBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_bmBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_bmBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_bmBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_bmBindingNavigator.Name = "t_bmBindingNavigator";
            this.t_bmBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_bmBindingNavigator.Size = new System.Drawing.Size(580, 25);
            this.t_bmBindingNavigator.TabIndex = 0;
            this.t_bmBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // t_bmBindingNavigatorSaveItem
            // 
            this.t_bmBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_bmBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_bmBindingNavigatorSaveItem.Image")));
            this.t_bmBindingNavigatorSaveItem.Name = "t_bmBindingNavigatorSaveItem";
            this.t_bmBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_bmBindingNavigatorSaveItem.Text = "保存数据";
            this.t_bmBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_bmBindingNavigatorSaveItem_Click);
            // 
            // t_bmDataGridView
            // 
            this.t_bmDataGridView.AutoGenerateColumns = false;
            this.t_bmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_bmDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.负责人});
            this.t_bmDataGridView.DataSource = this.t_bmBindingSource;
            this.t_bmDataGridView.Location = new System.Drawing.Point(0, 28);
            this.t_bmDataGridView.Name = "t_bmDataGridView";
            this.t_bmDataGridView.RowTemplate.Height = 23;
            this.t_bmDataGridView.Size = new System.Drawing.Size(447, 214);
            this.t_bmDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bh";
            this.dataGridViewTextBoxColumn1.HeaderText = "bh";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn2.HeaderText = "mc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fzrbh";
            this.dataGridViewTextBoxColumn3.HeaderText = "fzrbh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // 负责人
            // 
            this.负责人.DataPropertyName = "fzrbh";
            this.负责人.DataSource = this.tzgBindingSource;
            this.负责人.DisplayMember = "xm";
            this.负责人.HeaderText = "负责人";
            this.负责人.Name = "负责人";
            this.负责人.ValueMember = "bh";
            // 
            // tzgBindingSource
            // 
            this.tzgBindingSource.DataMember = "t_zg";
            this.tzgBindingSource.DataSource = this.zgzyDataSet;
            // 
            // tzyBindingSource
            // 
            this.tzyBindingSource.DataMember = "t_zy";
            this.tzyBindingSource.DataSource = this.zgzyDataSet;
            // 
            // FrmBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 297);
            this.Controls.Add(this.t_bmDataGridView);
            this.Controls.Add(this.t_bmBindingNavigator);
            this.Name = "FrmBM";
            this.Text = "进销存管理系统登陆_入门案例";
            this.Load += new System.EventHandler(this.FrmBM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zgzyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmBindingNavigator)).EndInit();
            this.t_bmBindingNavigator.ResumeLayout(false);
            this.t_bmBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_bmDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tzyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private zgzyDataSet zgzyDataSet;
        private System.Windows.Forms.BindingSource t_bmBindingSource;
        private zgzyDataSetTableAdapters.t_bmTableAdapter t_bmTableAdapter;
        private zgzyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_bmBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton t_bmBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView t_bmDataGridView;
        private zgzyDataSetTableAdapters.t_zyTableAdapter t_zyTableAdapter;
        private System.Windows.Forms.BindingSource tzyBindingSource;
        private zgzyDataSetTableAdapters.t_zgTableAdapter t_zgTableAdapter;
        private System.Windows.Forms.BindingSource tzgBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn 负责人;
    }
}