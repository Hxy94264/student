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
    public partial class ClassFrm : Form
    {
        public ClassFrm()
        {
            InitializeComponent();
            BindMajor();
            BindClass();
        }
         void BindMajor()
        {
            string sql = "select MajorId ,MajorName from Major";
            DB db = new DB();
            DataSet ds = db.GetDataSet(sql, "Major");
            cbMajor.DataSource = ds.Tables["Major"];
            cbMajor.DisplayMember = "MajorName";
            cbMajor.ValueMember = "MajorId";
            BindClass();
        }

        void BindClass()
        {
            string sql = "select ClassId as 班级编号,ClassName as 班级名称,EntryYear as 入学年份,MajorName as 所属专业 from Major,Class where Major.MajorId=Class.MajorId";
            DB db = new DB();
            DataSet ds = db.GetDataSet(sql, "Class");
            dataGridView1.DataSource = ds.Tables["Class"];
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string sql = "insert into Class(ClassId,ClassName,EntryYear,MajorId)values("
                 + txtClassId.Text + ",'" + txtClassName.Text + "','" + txtEntryYear.Text + "'," + cbMajor.SelectedValue + ")";
            DB db = new DB();
            if (db.ExecuteSQL(sql))
                MessageBox.Show("班级增加成功");
            else
                MessageBox.Show("班级增加失败，请检查班级编号是否已存在");
            BindClass();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string sql = "select * from Class where ClassName='" + txtClassName.Text + "'";
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
