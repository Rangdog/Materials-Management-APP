using DevExpress.XtraEditors;
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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtLogin.Text; Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;
            Program.mChiNhanh = cmbChiNhanh.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy nhập dữ liệu\n Bạn xem lại username, password");
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.conn.Close();
            Program.myReader.Close();
            Program.frmChinh.HienThiMenu();
            Program.frmChinh.ribDanhMuc.Visible = true;
            Program.frmChinh.ribBaoCao.Visible = true;
            Program.frmChinh.ribNghiepVu.Visible = true;
            if(Program.mGroup != "USER")
            {
                Program.frmChinh.btnTaoTaiKhoan.Enabled = true;
            }
            Program.frmChinh.btnDangXuat.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch(Exception)
            {

            }
        }

        private void layDSPM(string cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.SelectCommand.CommandTimeout = 600;
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN"; cmbChiNhanh.ValueMember = "TENSERVER";
        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publicsher;
                conn_publisher.Open();
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc. \nBạn xem lại tên Server của Publisher, và tên CSDL trong chuỗi kết nối.\n" + e.Message);
                return 0;
            }
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            layDSPM("SELECT * FROM DS_PHANMANH");
            cmbChiNhanh.SelectedIndex = 1; cmbChiNhanh.SelectedIndex = 0;
        }
    }
}