namespace GengdanContactsMIS_WinForm
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系部管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.专业管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.班级管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系部管理ToolStripMenuItem,
            this.专业管理ToolStripMenuItem,
            this.班级管理ToolStripMenuItem,
            this.学生管理ToolStripMenuItem,
            this.教师管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系部管理ToolStripMenuItem
            // 
            this.系部管理ToolStripMenuItem.Name = "系部管理ToolStripMenuItem";
            this.系部管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.系部管理ToolStripMenuItem.Text = "系部管理";
            this.系部管理ToolStripMenuItem.Click += new System.EventHandler(this.系部管理ToolStripMenuItem_Click);
            // 
            // 专业管理ToolStripMenuItem
            // 
            this.专业管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.专业管理ToolStripMenuItem.Name = "专业管理ToolStripMenuItem";
            this.专业管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.专业管理ToolStripMenuItem.Text = "专业管理";
            this.专业管理ToolStripMenuItem.Click += new System.EventHandler(this.专业管理ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // 班级管理ToolStripMenuItem
            // 
            this.班级管理ToolStripMenuItem.Name = "班级管理ToolStripMenuItem";
            this.班级管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.班级管理ToolStripMenuItem.Text = "班级管理";
            this.班级管理ToolStripMenuItem.Click += new System.EventHandler(this.班级管理ToolStripMenuItem_Click);
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            this.学生管理ToolStripMenuItem.Click += new System.EventHandler(this.学生管理ToolStripMenuItem_Click);
            // 
            // 教师管理ToolStripMenuItem
            // 
            this.教师管理ToolStripMenuItem.Name = "教师管理ToolStripMenuItem";
            this.教师管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.教师管理ToolStripMenuItem.Text = "教师管理";
            this.教师管理ToolStripMenuItem.Click += new System.EventHandler(this.教师管理ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(476, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "退出登录";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 358);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "耿丹学院信息管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系部管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 专业管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
    }
}

