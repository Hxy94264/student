using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace GengdanContactsMIS_WinForm
{
    public partial class DepartmentFrm : Form
    {
        //string conStr;
        DB db;
        public DepartmentFrm()
        {
            //conStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString(); 
            InitializeComponent();
            db = new DB();
            BindDepartment();
        }
        void BindDepartment() {
           /* //string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\GengdanContactsDB.accdb";
            
            OleDbConnection con = new OleDbConnection(conStr);
            string sql = "select DepartmentId as 系部编号,DepartmentName as 系部名称 from Department";
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Department");
            dataGridView1.DataSource = ds.Tables["Department"];*/
            string sql = "select DepartmentId as 系部编号,DepartmentName as 系部名称 from Department";
            DataSet ds = db.GetDataSet(sql, "Department");
            dataGridView1.DataSource = ds.Tables["Department"];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           /*// string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\GengdanContactsDB.accdb";

            OleDbConnection con = new OleDbConnection(conStr);
            string sql = "insert into Department(DepartmentId,DepartmentName)values(" + txtDepartmentId.Text + ",'" + txtDepartmentName.Text + "')";
            OleDbCommand cmd = new OleDbCommand(sql,con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("系部信息增加成功!");
            con.Close();
            BindDepartment();*/
            string sql = "insert into Department(DepartmentId,DepartmentName)values(" + txtDepartmentId.Text + ",'" + txtDepartmentName.Text + "')";
            db.ExecuteSQL(sql);
            BindDepartment();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string DepartmentId = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            string DepartmentName = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            string sql = "update Department set DepartmentName='" + DepartmentName + "' where DepartmentId=" + DepartmentId;
            db.ExecuteSQL(sql);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string DepartmentId = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = "delete from Department where DepartmentId=" + DepartmentId;
            db.ExecuteSQL(sql);
            BindDepartment();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          
            /*string sql = "select * from Department where DepartmentId="+txtDepartmentId.Text;
            DataSet ds = db.GetDataSet(sql, "d");
            dataGridView1.DataSource = ds.Tables["d"];*/
            string sql = "select * from Department where DepartmentName='" + txtDepartmentName.Text+"'";
            DataSet ds = db.GetDataSet(sql, "d");
            dataGridView1.DataSource = ds.Tables["d"];

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
