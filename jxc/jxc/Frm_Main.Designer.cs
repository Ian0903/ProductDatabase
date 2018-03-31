namespace jxc
{
    partial class Frm_Main
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslb_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslb_name = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuFz = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuZg = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBm = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuZy = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuKhGys = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSp = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuJh = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuJhLr = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuJhCxTj = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuXs = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuXsLr = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuXsCxTj = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuXt = new System.Windows.Forms.ToolStripMenuItem();
            this.设置口令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslb_time,
            this.tslb_name});
            this.statusStrip1.Location = new System.Drawing.Point(0, 405);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(849, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslb_time
            // 
            this.tslb_time.Name = "tslb_time";
            this.tslb_time.Size = new System.Drawing.Size(0, 17);
            // 
            // tslb_name
            // 
            this.tslb_name.Name = "tslb_name";
            this.tslb_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tslb_name.Size = new System.Drawing.Size(131, 17);
            this.tslb_name.Text = "toolStripStatusLabel1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(348, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ver1.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "《数据库原理与应用SQL Server 2008》_杨宇俊";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "进销存数据库管理系统";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFz,
            this.MnuJh,
            this.MnuXs,
            this.库存管理ToolStripMenuItem,
            this.MnuXt,
            this.MnuQuit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuFz
            // 
            this.MnuFz.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuZg,
            this.MnuBm,
            this.MnuZy,
            this.MnuKhGys,
            this.MnuSp});
            this.MnuFz.Name = "MnuFz";
            this.MnuFz.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.MnuFz.Size = new System.Drawing.Size(82, 21);
            this.MnuFz.Text = "辅助管理(&F)";
            // 
            // MnuZg
            // 
            this.MnuZg.Name = "MnuZg";
            this.MnuZg.Size = new System.Drawing.Size(172, 22);
            this.MnuZg.Text = "职工管理";
            this.MnuZg.Click += new System.EventHandler(this.MnuZg_Click);
            // 
            // MnuBm
            // 
            this.MnuBm.Enabled = false;
            this.MnuBm.Name = "MnuBm";
            this.MnuBm.Size = new System.Drawing.Size(172, 22);
            this.MnuBm.Text = "部门管理";
            this.MnuBm.Click += new System.EventHandler(this.MnuBm_Click);
            // 
            // MnuZy
            // 
            this.MnuZy.Enabled = false;
            this.MnuZy.Name = "MnuZy";
            this.MnuZy.Size = new System.Drawing.Size(172, 22);
            this.MnuZy.Text = "专业管理";
            // 
            // MnuKhGys
            // 
            this.MnuKhGys.Enabled = false;
            this.MnuKhGys.Name = "MnuKhGys";
            this.MnuKhGys.Size = new System.Drawing.Size(172, 22);
            this.MnuKhGys.Text = "客户与供应商管理";
            // 
            // MnuSp
            // 
            this.MnuSp.Enabled = false;
            this.MnuSp.Name = "MnuSp";
            this.MnuSp.Size = new System.Drawing.Size(172, 22);
            this.MnuSp.Text = "商品管理";
            // 
            // MnuJh
            // 
            this.MnuJh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuJhLr,
            this.MnuJhCxTj});
            this.MnuJh.Name = "MnuJh";
            this.MnuJh.Size = new System.Drawing.Size(81, 21);
            this.MnuJh.Text = "进货管理(&J)";
            // 
            // MnuJhLr
            // 
            this.MnuJhLr.Name = "MnuJhLr";
            this.MnuJhLr.Size = new System.Drawing.Size(152, 22);
            this.MnuJhLr.Text = "进货";
            this.MnuJhLr.Click += new System.EventHandler(this.MnuJhLr_Click);
            // 
            // MnuJhCxTj
            // 
            this.MnuJhCxTj.Name = "MnuJhCxTj";
            this.MnuJhCxTj.Size = new System.Drawing.Size(152, 22);
            this.MnuJhCxTj.Text = "进货查询统计";
            this.MnuJhCxTj.Click += new System.EventHandler(this.MnuJhCxTj_Click);
            // 
            // MnuXs
            // 
            this.MnuXs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuXsLr,
            this.MnuXsCxTj});
            this.MnuXs.Name = "MnuXs";
            this.MnuXs.Size = new System.Drawing.Size(84, 21);
            this.MnuXs.Text = "销售管理(&X)";
            // 
            // MnuXsLr
            // 
            this.MnuXsLr.Name = "MnuXsLr";
            this.MnuXsLr.Size = new System.Drawing.Size(148, 22);
            this.MnuXsLr.Text = "销售";
            // 
            // MnuXsCxTj
            // 
            this.MnuXsCxTj.Name = "MnuXsCxTj";
            this.MnuXsCxTj.Size = new System.Drawing.Size(148, 22);
            this.MnuXsCxTj.Text = "销售查询统计";
            // 
            // 库存管理ToolStripMenuItem
            // 
            this.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem";
            this.库存管理ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.库存管理ToolStripMenuItem.Text = "库存管理(&K)";
            // 
            // MnuXt
            // 
            this.MnuXt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置口令ToolStripMenuItem});
            this.MnuXt.Name = "MnuXt";
            this.MnuXt.Size = new System.Drawing.Size(83, 21);
            this.MnuXt.Text = "系统管理(&S)";
            // 
            // 设置口令ToolStripMenuItem
            // 
            this.设置口令ToolStripMenuItem.Name = "设置口令ToolStripMenuItem";
            this.设置口令ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.设置口令ToolStripMenuItem.Text = "设置口令";
            // 
            // MnuQuit
            // 
            this.MnuQuit.Name = "MnuQuit";
            this.MnuQuit.Size = new System.Drawing.Size(59, 21);
            this.MnuQuit.Text = "退出(&T)";
            this.MnuQuit.Click += new System.EventHandler(this.MnuQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jxc.Properties.Resources.xs;
            this.pictureBox1.Location = new System.Drawing.Point(515, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 427);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frm_Main";
            this.Text = "进销存管理系统登陆_入门案例";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslb_time;
        private System.Windows.Forms.ToolStripStatusLabel tslb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuFz;
        private System.Windows.Forms.ToolStripMenuItem MnuZg;
        private System.Windows.Forms.ToolStripMenuItem MnuBm;
        private System.Windows.Forms.ToolStripMenuItem MnuZy;
        private System.Windows.Forms.ToolStripMenuItem MnuKhGys;
        private System.Windows.Forms.ToolStripMenuItem MnuSp;
        private System.Windows.Forms.ToolStripMenuItem MnuJh;
        private System.Windows.Forms.ToolStripMenuItem MnuJhLr;
        private System.Windows.Forms.ToolStripMenuItem MnuJhCxTj;
        private System.Windows.Forms.ToolStripMenuItem MnuXs;
        private System.Windows.Forms.ToolStripMenuItem MnuXsLr;
        private System.Windows.Forms.ToolStripMenuItem MnuXsCxTj;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuXt;
        private System.Windows.Forms.ToolStripMenuItem 设置口令ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuQuit;
    }
}