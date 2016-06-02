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
    public partial class TeacherFrm : Form
    {
        public TeacherFrm()
        {
            InitializeComponent();
            BindMajor();
            BindTeacher();
        }
        void BindMajor()
        {
            string sql = "select MajorId ,MajorName from Major";
            DB db = new DB();
            DataSet ds = db.GetDataSet(sql, "Major");
            cbMajor.DataSource = ds.Tables["Major"];
            cbMajor.DisplayMember = "MajorName";
            cbMajor.ValueMember = "MajorId";
            BindTeacher();
        }
        void BindTeacher()
        {
            string sql = "select TNo as 工号,TName as 姓名,MajorName as 专业,Sex as 性别,Phone as 电话,Email as 邮箱,Adress as 地址 from Teacher,Major where Teacher.MajorId=Major.MajorId";
            DB db = new DB();
            DataSet ds = db.GetDataSet(sql, "Teacher");
            dataGridView1.DataSource = ds.Tables["Teacher"];
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into Teacher(TNo,TName,Sex,MajorId,Phone,Email,Adress)values('"
                 + txtTNo.Text + "','" + txtTName.Text + "','" + txtSex.Text + "'," + cbMajor.SelectedValue + ",'" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtAdress.Text + "')";
            DB db = new DB();
            if (db.ExecuteSQL(sql))
                MessageBox.Show("教师增加成功");
            else
                MessageBox.Show("教师信息增加失败，请检查工号号是否已存在");
            BindTeacher();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select TNo,TName,Sex,MajorName,Phone,Email,Adress from Major,Teacher where Major.MajorId=Teacher.MajorId and TName='" + txtTName.Text + "'";
            DB db = new DB();
            DataSet ds = db.GetDataSet(sql, "a");
            dataGridView1.DataSource = ds.Tables["a"];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
