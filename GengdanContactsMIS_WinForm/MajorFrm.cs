using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GengdanContactsMIS_WinForm
{
    public partial class MajorFrm : Form
    {
        public MajorFrm()
        {
            InitializeComponent();
            BindDepartment();
            BindMajor();
        }

        void BindDepartment()
        {
            string sql = "select DepartmentId ,DepartmentName from Department";
            DB db = new DB();
            DataSet ds = db.GetDataSet(sql, "Department");
            cbDepartment.DataSource = ds.Tables["Department"];
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "DepartmentId";
            BindMajor();
        }

        void BindMajor()
        {
            string sql = "select MajorId as 专业编号,MajorName as 专业名称,DepartmentName as 所属系部 from Major,Department where Department.DepartmentId=Major.DepartmentId";
            DB db = new DB();
            DataSet ds = db.GetDataSet(sql, "Major");
            dataGridView1.DataSource = ds.Tables["Major"];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into Major(MajorId,MajorName,DepartmentId)values("
                 + txtMajorId.Text + ",'" + txtMajorName.Text + "'," + cbDepartment.SelectedValue + ")";
            DB db = new DB();
            if (db.ExecuteSQL(sql))
                MessageBox.Show("专业增加成功");
            else
                MessageBox.Show("专业增加失败，请检查专业编号是否已存在");
            BindMajor();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Major where MajorName='" + txtMajorName.Text + "'";
            DB db = new DB();
            DataSet ds = db.GetDataSet(sql, "d");
            dataGridView1.DataSource = ds.Tables["d"];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
