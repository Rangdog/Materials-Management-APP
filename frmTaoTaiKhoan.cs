using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLVT
{
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            string macn = "";
            dSDH.EnforceConstraints = false;
            this.dSNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNVTableAdapter.Fill(this.dSDH.DSNV);
            this.nhanVienChuaLapTKTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienChuaLapTKTableAdapter.Fill(this.dSDH.NhanVienChuaLapTK);
            
            
            macn = "CN" + (Program.mChiNhanh + 1).ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Visible = true;
                cmbRole.Items.Clear();
                cmbRole.Items.Add("CONGTY");
            }
            else
            {
                cmbChiNhanh.Visible = false;
                cmbRole.Items.Clear();
                cmbRole.Items.Add("USER");
                cmbRole.Items.Add("CHINHANH");
            }
            cmbRole.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if(txtTenTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Tên tài khoản không được thiếu", "", MessageBoxButtons.OK);
                txtTenTaiKhoan.Focus();
                return;
            }
            if(txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được thiếu", "", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return;
            }
            string cmd = "exec SP_TAOLOGIN " + txtTenTaiKhoan.Text + ", " + txtMatKhau.Text + ", " + cmbHoTenNV.SelectedValue.ToString() + ", '" + cmbRole.SelectedItem.ToString() + "'";
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Tạo tài khoản thành công", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo tài khoản: " + ex.Message, "", MessageBoxButtons.OK);
            }
            finally
            {
                Program.conn.Close();
                sqlcmd.Dispose();
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;

            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.dSNVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSNVTableAdapter.Fill(this.dSDH.DSNV);
                this.nhanVienChuaLapTKTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienChuaLapTKTableAdapter.Fill(this.dSDH.NhanVienChuaLapTK);
            }
        }
    }
}
