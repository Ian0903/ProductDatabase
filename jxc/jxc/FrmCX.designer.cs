namespace jxc
{
    partial class FrmCX
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
            this.PnlUp = new System.Windows.Forms.Panel();
            this.GrpJhd = new System.Windows.Forms.GroupBox();
            this.cbRqbx = new System.Windows.Forms.CheckBox();
            this.DTPFrom = new System.Windows.Forms.DateTimePicker();
            this.DTPTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGys = new System.Windows.Forms.ComboBox();
            this.cbJhr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btSelect = new System.Windows.Forms.Button();
            this.p_jhdDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_jhdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jhdDataSet = new jxc.jhdDataSet();
            this.p_jhdTableAdapter = new jxc.jhdDataSetTableAdapters.p_jhdTableAdapter();
            this.tableAdapterManager = new jxc.jhdDataSetTableAdapters.TableAdapterManager();
            this.PnlUp.SuspendLayout();
            this.GrpJhd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_jhdDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_jhdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jhdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlUp
            // 
            this.PnlUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlUp.Controls.Add(this.btSelect);
            this.PnlUp.Controls.Add(this.label4);
            this.PnlUp.Controls.Add(this.label3);
            this.PnlUp.Controls.Add(this.cbJhr);
            this.PnlUp.Controls.Add(this.cbGys);
            this.PnlUp.Controls.Add(this.label2);
            this.PnlUp.Controls.Add(this.DTPTo);
            this.PnlUp.Controls.Add(this.label1);
            this.PnlUp.Controls.Add(this.DTPFrom);
            this.PnlUp.Controls.Add(this.cbRqbx);
            this.PnlUp.Location = new System.Drawing.Point(12, 12);
            this.PnlUp.Name = "PnlUp";
            this.PnlUp.Size = new System.Drawing.Size(659, 114);
            this.PnlUp.TabIndex = 0;
            // 
            // GrpJhd
            // 
            this.GrpJhd.Controls.Add(this.p_jhdDataGridView);
            this.GrpJhd.Location = new System.Drawing.Point(12, 143);
            this.GrpJhd.Name = "GrpJhd";
            this.GrpJhd.Size = new System.Drawing.Size(665, 311);
            this.GrpJhd.TabIndex = 1;
            this.GrpJhd.TabStop = false;
            this.GrpJhd.Text = "进货单";
            // 
            // cbRqbx
            // 
            this.cbRqbx.AutoSize = true;
            this.cbRqbx.Checked = true;
            this.cbRqbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRqbx.Location = new System.Drawing.Point(21, 47);
            this.cbRqbx.Name = "cbRqbx";
            this.cbRqbx.Size = new System.Drawing.Size(72, 16);
            this.cbRqbx.TabIndex = 0;
            this.cbRqbx.Text = "日期不限";
            this.cbRqbx.UseVisualStyleBackColor = true;
            // 
            // DTPFrom
            // 
            this.DTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFrom.Location = new System.Drawing.Point(119, 22);
            this.DTPFrom.Name = "DTPFrom";
            this.DTPFrom.Size = new System.Drawing.Size(147, 21);
            this.DTPFrom.TabIndex = 1;
            // 
            // DTPTo
            // 
            this.DTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTo.Location = new System.Drawing.Point(119, 59);
            this.DTPTo.Name = "DTPTo";
            this.DTPTo.Size = new System.Drawing.Size(147, 21);
            this.DTPTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "从";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "到";
            // 
            // cbGys
            // 
            this.cbGys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGys.FormattingEnabled = true;
            this.cbGys.Location = new System.Drawing.Point(354, 28);
            this.cbGys.Name = "cbGys";
            this.cbGys.Size = new System.Drawing.Size(121, 20);
            this.cbGys.TabIndex = 3;
            // 
            // cbJhr
            // 
            this.cbJhr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJhr.FormattingEnabled = true;
            this.cbJhr.Location = new System.Drawing.Point(354, 65);
            this.cbJhr.Name = "cbJhr";
            this.cbJhr.Size = new System.Drawing.Size(121, 20);
            this.cbJhr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "供应商";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "进货人";
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(510, 38);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(78, 33);
            this.btSelect.TabIndex = 7;
            this.btSelect.Text = "查询(&C)";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // p_jhdDataGridView
            // 
            this.p_jhdDataGridView.AutoGenerateColumns = false;
            this.p_jhdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.p_jhdDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.p_jhdDataGridView.DataSource = this.p_jhdBindingSource;
            this.p_jhdDataGridView.Location = new System.Drawing.Point(6, 20);
            this.p_jhdDataGridView.Name = "p_jhdDataGridView";
            this.p_jhdDataGridView.RowTemplate.Height = 23;
            this.p_jhdDataGridView.Size = new System.Drawing.Size(653, 285);
            this.p_jhdDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bh";
            this.dataGridViewTextBoxColumn3.HeaderText = "编号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gysbh";
            this.dataGridViewTextBoxColumn4.HeaderText = "供应商编号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gysmc";
            this.dataGridViewTextBoxColumn5.HeaderText = "供应商名称";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "jhrbh";
            this.dataGridViewTextBoxColumn6.HeaderText = "进货人编号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "jhrxm";
            this.dataGridViewTextBoxColumn7.HeaderText = "进货人";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "je";
            this.dataGridViewTextBoxColumn8.HeaderText = "金额";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // p_jhdBindingSource
            // 
            this.p_jhdBindingSource.DataMember = "p_jhd";
            this.p_jhdBindingSource.DataSource = this.jhdDataSet;
            // 
            // jhdDataSet
            // 
            this.jhdDataSet.DataSetName = "jhdDataSet";
            this.jhdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_jhdTableAdapter
            // 
            this.p_jhdTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.t_khgysTableAdapter = null;
            this.tableAdapterManager.t_zgTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = jxc.jhdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 459);
            this.Controls.Add(this.GrpJhd);
            this.Controls.Add(this.PnlUp);
            this.Name = "FrmCX";
            this.Text = "进货查询统计";
            this.Load += new System.EventHandler(this.FrmCX_Load);
            this.PnlUp.ResumeLayout(false);
            this.PnlUp.PerformLayout();
            this.GrpJhd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_jhdDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_jhdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jhdDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlUp;
        private System.Windows.Forms.GroupBox GrpJhd;
        private System.Windows.Forms.CheckBox cbRqbx;
        private System.Windows.Forms.DateTimePicker DTPTo;
        private System.Windows.Forms.DateTimePicker DTPFrom;
        private System.Windows.Forms.ComboBox cbJhr;
        private System.Windows.Forms.ComboBox cbGys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSelect;
        private jhdDataSet jhdDataSet;
        private System.Windows.Forms.BindingSource p_jhdBindingSource;
        private jhdDataSetTableAdapters.p_jhdTableAdapter p_jhdTableAdapter;
        private jhdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView p_jhdDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}