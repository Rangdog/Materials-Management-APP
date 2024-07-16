using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVT.SubForm
{
    public partial class frmTangChuc : Form
    {
        public frmTangChuc()
        {
            InitializeComponent();
        }

        private void frmTangChuc_Load(object sender, EventArgs e)
        {
            this.NHANVIENUSERTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENUSERTableAdapter.Fill(this.dS.NHANVIENUSER);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTangChuc_Click(object sender, EventArgs e)
        {
            string manv = cmbHoTenNV.SelectedValue.ToString();
            string cmd = "SELECT name FROM sys.server_principals WHERE sid IN (SELECT sid FROM sys.database_principals WHERE name = '"+manv+"')";
            string name = "";
            SqlCommand sqlCmd;
            SqlDataAdapter DA = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                Program.conn.ConnectionString = Program.connstr;
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                sqlCmd = new SqlCommand(cmd, Program.conn);
                DA.SelectCommand = sqlCmd;
                DA.Fill(ds);
                if(ds.Tables[0].Rows.Count > 0)
                {
                    name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong việc thực thi ", "", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lôi kết nối: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            finally
            {
                DA.Dispose();
                Program.conn.Close();
            }
            if(name == "")
            {
                MessageBox.Show("Có lỗi trong việc thực thi ", "", MessageBoxButtons.OK);
                return;
            }
            cmd = "SELECT  SYSTEM_USER where SYSTEM_USER = '" + name + "'";
            DA = new SqlDataAdapter();
            ds = new DataSet();
            try
            {
                Program.conn.ConnectionString = Program.connstr;
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                sqlCmd = new SqlCommand(cmd, Program.conn);
                DA.SelectCommand = sqlCmd;
                DA.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Nhân viên mà bạn muốn tăng chức đang đăng nhập","", MessageBoxButtons.OK);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lôi kết nối: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            finally
            {
                DA.Dispose();
                Program.conn.Close();
            }
            cmd = "EXEC sp_droprolemember 'USER'," + "'" + manv+"'";
            if (Program.ExecSqlNonQuery(cmd) == 0);
            {
                cmd = "EXEC sp_addrolemember 'CHINHANH'," + "'" + manv + "'";
                Program.ExecSqlNonQuery(cmd);
            }
            MessageBox.Show("Thành Công", "", MessageBoxButtons.OK);
            this.NHANVIENUSERTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENUSERTableAdapter.Fill(this.dS.NHANVIENUSER);
        }
    }
}
