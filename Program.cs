using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLVT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publicsher = @"Data Source=LAPTOP-DOUILK3I;Initial Catalog=QLVT;User ID=sa;Password=123456";
        public static String connstr_window_mode1 = @"Data Source=LAPTOP-DOUILK3I\SERVER1;Initial Catalog=QLVT;integrated security=true";
        public static String connstr_window_mode2 = @"Data Source=LAPTOP-DOUILK3I\SERVER2;Initial Catalog=QLVT;integrated security=true";
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLVT";
        public static String remotelogin = "htkn";
        public static String remotepassword = "123456";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChiNhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();

        /* maKhoDuocChon lưu trữ kho được chọn phục vụ cho btnChonKhoHang \
        * maDonDatHangDuocChon phục vụ cho tạo mới phiếu nhập
        */
        public static String maKhoDuocChon = "";
        public static String maVatTuDuocChon = "";
        public static String maDonDatHangDuocChon = "";
        public static String maDonDatHangChiTietDuocChon = "";
        public static int soLuongVatTuDuocChon = 0;
        public static int donGiaDuocChon = 0;

        public static frmMain frmChinh;
        public static int KetNoi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                connstr = "Data Source=" + servername + "; Initial Catalog=" + database + ";User Id=" + mlogin + ";Password=" + password;
                conn.ConnectionString = connstr;
                conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc. \nBạn xem lại tên user name và password.\n" + e.Message);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch(Exception e)
            {
                conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strLenh)
        {
            SqlCommand sqlCmd = new SqlCommand(strLenh, conn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;
            }
        }
        public static int ExecSqlNonQueryadd(String strLenh, String constr)
        {
            conn.ConnectionString = constr;
            SqlCommand sqlCmd = new SqlCommand(strLenh, conn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
