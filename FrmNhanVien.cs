using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLVT.SubForm;

namespace QLVT
{
    public partial class FrmNhanVien : Form
    {
        int vitri = 0;
        string macn = "";
        bool flagGhi = false;
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }
            if (flagGhi)
            {
                String cmd = "EXEC SP_CHECK_MANV_EXIST " + txtMANV.Text;
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
                    if (ds.Tables[0].Rows.Count > 0 || ds.Tables[1].Rows.Count > 0)
                    {
                        MessageBox.Show("Mã nhân viên bị trùng vui lòng kiểm tra!", "", MessageBoxButtons.OK);
                        txtMANV.Focus();
                        sqlCmd.Dispose();
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
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được thiếu!", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }
            if(txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }
            if(txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Chứng minh nhân dân không được thiếu", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }
            String dateNhap = dptNgaySinh.EditValue.ToString();
            if (dateNhap.Trim() == "")
            {
                MessageBox.Show("Ngày sinh không được thiếu", "", MessageBoxButtons.OK);
                dptNgaySinh.Focus();
                return;
            }
            if(DateTime.Compare(Convert.ToDateTime(dateNhap),DateTime.Now.AddYears(-18)) >= 0)
            {
                MessageBox.Show("Ngày không hợp lệ", "", MessageBoxButtons.OK);
                dptNgaySinh.Focus();
                return;
            }
            if (txtLuong.Text.Trim() == "")
            {
                MessageBox.Show("Lương không được thiếu", "", MessageBoxButtons.OK);
                txtLuong.Focus();
                return;
            }
            if (float.Parse(txtLuong.Text) < 4000000)
            {
                MessageBox.Show("Lương phải >= 4000000", "", MessageBoxButtons.OK);
                txtLuong.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }
            if (cmbChuyenChiNhanh.Visible == false)
            {
                try
                {
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
               if(txtMACN.Text.Substring(2) != (cmbChuyenChiNhanh.SelectedIndex+1).ToString())
                {
                    if(Program.username == txtMANV.Text)
                    {
                        MessageBox.Show("Bạn không thể chuyển chính bản thân mình", "", MessageBoxButtons.OK);
                        return;
                    }

                    string cmd = "SELECT * FROM sys.database_role_members WHERE role_principal_id = (SELECT principal_id FROM sys.database_principals WHERE name = 'CONGTY') AND member_principal_id = (SELECT principal_id FROM sys.database_principals WHERE name = '"+ txtMANV.Text+"' )";
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
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("Nhân viên đang được chọn có role là CONGTY không thể chuyển", "", MessageBoxButtons.OK);
                            txtMANV.Focus();
                            sqlCmd.Dispose();
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
                    cmd = "SELECT name FROM sys.server_principals WHERE sid IN (SELECT sid FROM sys.database_principals WHERE name = '" + txtMANV.Text + "')";
                    string name = "";
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
                    if (name == "")
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
                            MessageBox.Show("Nhân viên mà bạn muốn chuyển đang đăng nhập", "", MessageBoxButtons.OK);
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
                    cmd = "EXEC SP_CHUYEN_NHAN_VIEN " + txtMANV.Text + ", CN" + (cmbChuyenChiNhanh.SelectedIndex+1).ToString();       
                    if(Program.ExecSqlNonQuery(cmd) == 0)
                    {
                        this.nhanVienTableAdapter.Fill(dS.NhanVien);
                    }
                }    
            }
            gcNhanVien.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if(Program.mGroup == "CHINHANH")
            {
                btnChuyenChiNhanh.Enabled = btnTangChuc.Enabled = true;
            }
            flagGhi = false;
            if(cmbChuyenChiNhanh.Visible == true)
            {
                txtHo.Enabled = txtTen.Enabled = txtLuong.Enabled = dptNgaySinh.Enabled = txtDiaChi.Enabled = txtCMND.Enabled = true;
                lblChuyenChiNhanh.Visible = cmbChuyenChiNhanh.Visible = false;
            }
            txtMANV.Enabled = true;
        }

  

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
           
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
        
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dS.DatHang);
            macn = "CN" + (Program.mChiNhanh+1).ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            DataTable dt = (DataTable)Program.bds_dspm.DataSource;
            List<String> list = new List<String>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i]["TENCN"].ToString());
            }
            foreach(String cn in list){
                cmbChuyenChiNhanh.Items.Add(cn);
            }
            cmbChuyenChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled =  true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = btnChuyenChiNhanh.Enabled = btnTangChuc.Enabled = false;
            }
            else if(Program.mGroup == "CHINHANH")
            {
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnChuyenChiNhanh.Enabled = btnTangChuc.Enabled = btnReload.Enabled = true;
                btnPhucHoi.Enabled = btnGhi.Enabled = false;
                cmbChiNhanh.Enabled = false;
            }
            else
            {
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled  = btnReload.Enabled = true;
                btnPhucHoi.Enabled = btnGhi.Enabled = btnTangChuc.Enabled = btnChuyenChiNhanh.Enabled = false;
                cmbChiNhanh.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            flagGhi = true;
            panelControl2.Enabled = true;
            bdsNV.AddNew();
            txtMACN.Text = macn;
            dptNgaySinh.EditValue = "";
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled= btnReload.Enabled = btnXoa.Enabled = btnChuyenChiNhanh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lõi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnXoa.Enabled = btnChuyenChiNhanh.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;
            txtMANV.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 manv = 0;
            if(bdsDatHang.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập đơn đặt hàng", "", MessageBoxButtons.OK);
                return;
            }
            if(bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if(bdsPhieuXuat.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            
            if(MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ??", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                    bdsNV.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(dS.NhanVien);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(dS.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }
            if (bdsNV.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if(cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if(Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.dS.DatHang);
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            this.nhanVienTableAdapter.Fill(dS.NhanVien);
            if (btnThem.Enabled == false) bdsNV.Position = vitri;
            gcNhanVien.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            if (cmbChuyenChiNhanh.Visible == true)
            {
                txtMANV.Enabled = txtHo.Enabled = txtTen.Enabled = txtLuong.Enabled = dptNgaySinh.Enabled = txtDiaChi.Enabled = txtCMND.Enabled = true;
                lblChuyenChiNhanh.Visible = cmbChuyenChiNhanh.Visible = false;
            }
            txtMANV.Enabled = true;
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnChuyenChiNhanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ckTrangThaiXoa.Checked == true)
            {
                MessageBox.Show("Nhân Viên này đã xóa", "", MessageBoxButtons.OK);
                return;
            }
            vitri = bdsNV.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnChuyenChiNhanh.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;
            txtMANV.Enabled = txtHo.Enabled = txtTen.Enabled = txtLuong.Enabled = dptNgaySinh.Enabled = txtDiaChi.Enabled = txtCMND.Enabled = false;
            lblChuyenChiNhanh.Visible = cmbChuyenChiNhanh.Visible = true;
        }

        private void btnTangChuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTangChuc form = new frmTangChuc();
            form.ShowDialog();
        }
    }
}
