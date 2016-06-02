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
    public partial class StudentFrm : Form
    {
        public StudentFrm()
        {
            InitializeComponent();
            BindClass();
            BindStudent();
        }
        void BindClass()
        {
            string sql = "select ClassId ,ClassName from Class";
            DB db = new DB();
            DataSet ds = db.GetDataSet(sql, "Class");
            cbClass.DataSource = ds.Tables["Class"];
            cbClass.DisplayMember = "ClassName";
            cbClass.ValueMember = "ClassId";
        }
        void BindStudent()
        {
            string sql = "select SNo as 学号,SName as 姓名,Sex as 性别,ClassName as 班级,BirthDate as 出生年月日,Phone as 电话,Email as 邮箱,Adress as 地址 from Student,Class where Student.ClassId=Class.ClassId";
            DB db = new DB();
            DataSet ds = db.GetDataSet(sql,"Student");
            dataGridView1.DataSource = ds.Tables["Student"];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into Student(SNo,SName,Sex,ClassId,BirthDate,Phone,Email,Adress)values("
                 + txtSNo.Text + ",'" + txtSName.Text + "','" + txtSex.Text + "'," + cbClass.SelectedValue + ",'" + txtBirthDate.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtAdress.Text + "')";
             DB db = new DB();
             if (db.ExecuteSQL(sql))
                 MessageBox.Show("学生增加成功");
             else
                 MessageBox.Show("学生增加失败，请检查学号是否已存在");
             BindStudent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select SNo,SName,Sex,ClassName,BirthDate,Phone,Email,Adress from Class,Student where Class.ClassId=Student.ClassId and SName='" + txtSName.Text + "'";
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
