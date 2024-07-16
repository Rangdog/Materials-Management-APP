using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using QLVT.SubForm;

namespace QLVT
{
    public partial class frmPhieuXuat : Form
    {
        int viTri = 0;
        String maChiNhanh = "";

        BindingSource bds = null; // Chứa những dữ liệu đang làm việc
        GridControl gc = null;  // Chứa grid view đang làm việc

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuXuat.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.PhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PhieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPXTableAdapter.Fill(this.DS.CTPX);
            maChiNhanh = "CN" + (Program.mChiNhanh + 1).ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            cmbChiNhanh.Enabled = false;

        }

        private void btnCheDoPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMenu.Links[0].Caption = "Phiếu Xuất";
            bds = bdsPhieuXuat;
            gc = gcPhieuXuat;

            txtMaPX.Enabled = dteNgay.Enabled = txtMaNV.Enabled = txtMaKho.Enabled = txtMaKho.Enabled = false;
            txtHoTen.Enabled = btnChonKhoHang.Enabled = true;

            txtMaVTCTPX.Enabled = btnChonVatTu.Enabled = txtSoLuongCTPX.Enabled = txtDonGiaCTPX.Enabled = false;

            gcPhieuXuat.Enabled = gcCTPX.Enabled = true;

            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = false;
                btnMenu.Enabled = btnThoat.Enabled = btnLamMoi.Enabled = true;
                pnlNhapLieu.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                btnMenu.Enabled = true;
                btnThem.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnHoanTac.Enabled = btnThoat.Enabled = true;
                if (bdsPhieuXuat.Count > 0)
                {
                    btnXoa.Enabled = true;
                }
                else
                {
                    btnXoa.Enabled = false;
                }
            }
        }

        private void btnCheDoChiTietPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMenu.Links[0].Caption = "Chi Tiết Phiếu Xuất";
            bds = bdsCTPX;
            gc = gcCTPX;

            txtMaPX.Enabled = dteNgay.Enabled = txtHoTen.Enabled = txtMaNV.Enabled = btnChonKhoHang.Enabled = txtMaKho.Enabled = false;

            txtMaVTCTPX.Enabled = txtSoLuongCTPX.Enabled = txtDonGiaCTPX.Enabled = false;
            gcCTPX.Enabled = gcPhieuXuat.Enabled = true;
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = false;
                btnMenu.Enabled = btnThoat.Enabled = btnLamMoi.Enabled = true;
                pnlNhapLieu.Enabled = false;
            }
            if (Program.mGroup == "CHINHANH" || Program.mGroup == "USER")
            {
                cmbChiNhanh.Enabled = false;
                btnMenu.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnHoanTac.Enabled = btnThoat.Enabled = true;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bds.Position;
            bds.AddNew();
            if (btnMenu.Links[0].Caption == "Phiếu Xuất")
            {
                txtMaPX.Enabled = txtHoTen.Enabled = btnChonKhoHang.Enabled = true;
                dteNgay.Enabled = txtMaVTCTPX.Enabled = btnChonVatTu.Enabled = txtSoLuongCTPX.Enabled = txtDonGiaCTPX.Enabled = false;

                dteNgay.EditValue = DateTime.Now;
                txtMaNV.Text = Program.username;
                txtMaKho.Text = Program.maKhoDuocChon;

                ((DataRowView)(bdsPhieuXuat.Current))["NGAY"] = DateTime.Now;
                ((DataRowView)(bdsPhieuXuat.Current))["MANV"] = Program.username;
                ((DataRowView)(bdsPhieuXuat.Current))["MAKHO"] = Program.maKhoDuocChon;
            }

            if (btnMenu.Links[0].Caption == "Chi Tiết Phiếu Xuất")
            {
                DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNV = drv["MANV"].ToString();
                if (Program.username != maNV)
                {
                    MessageBox.Show("Không thể thêm chi tiết phiếu xuất trên phiếu do người khác tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                ((DataRowView)(bdsCTPX.Current))["MAPX"] = ((DataRowView)(bdsPhieuXuat.Current))["MAPX"];
                ((DataRowView)(bdsCTPX.Current))["MAVT"] = Program.maVatTuDuocChon;

                txtMaVTCTPX.Enabled = false;
                btnChonVatTu.Enabled = txtSoLuongCTPX.Enabled = txtDonGiaCTPX.Enabled = true;
                txtSoLuongCTPX.EditValue = txtDonGiaCTPX.EditValue = 1;
            }

            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnMenu.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnHoanTac.Enabled = true;
            gcPhieuXuat.Enabled = gcCTPX.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String cheDo = (btnMenu.Links[0].Caption == "Phiếu Xuất") ? "Phiếu Xuất" : "Chi Tiết Phiếu Xuất";
            DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
            String maNV = drv["MANV"].ToString();
            if (cheDo == "Phiếu Xuất")
            {

                if (Program.username != maNV)
                {
                    MessageBox.Show("Không xóa chi tiết phiếu xuất do người khác lập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (bdsCTPX.Count > 0)
                {
                    MessageBox.Show("Không thể xóa phiếu xuất vì đã có chi tiết phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            if (cheDo == "Chi Tiết Phiếu Xuất")
            {
                if (Program.username != maNV)
                {
                    MessageBox.Show("Không thể xóa chi tiết phiếu xuất do người khác lập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bds.Position;
                    if (cheDo == "Phiếu Xuất")
                    {
                        bdsPhieuXuat.RemoveCurrent();
                    }
                    if (cheDo == "Chi Tiết Phiếu Nhập")
                    {
                        bdsCTPX.RemoveCurrent();
                    }

                    this.PhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PhieuXuatTableAdapter.Update(this.DS.PhieuXuat);

                    this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPXTableAdapter.Update(this.DS.CTPX);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.PhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PhieuXuatTableAdapter.Update(this.DS.PhieuXuat);

                    this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPXTableAdapter.Update(this.DS.CTPX);

                    bds.Position = viTri;
                    return;
                }
            }
        }
        private bool kiemTraDuLieu(String cheDo)
        {
            if (cheDo == "Phiếu Xuất")
            {
                DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNV = drv["MANV"].ToString();
                if (Program.username != maNV)
                {
                    MessageBox.Show("Không thể sửa phiếu xuất do người khác tạo", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtMaPX.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu xuất !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPX.Focus();
                    return false;
                }
                if (txtMaPX.Text.Length > 8)
                {
                    MessageBox.Show("Mã phiếu xuất không thể quá 8 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPX.Focus();
                    return false;
                }
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("Tên khách hàng không được bỏ trống !", "Thông báo", MessageBoxButtons.OK);
                    txtHoTen.Focus();
                    return false;
                }
                if (txtHoTen.Text.Length > 100)
                {
                    MessageBox.Show("Tên khách hàng không quá 100 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtHoTen.Focus();
                    return false;
                }
                if (txtMaKho.Text == "")
                {
                    MessageBox.Show("Mã kho không được để trống !", "Thông báo", MessageBoxButtons.OK);
                    txtMaKho.Focus();
                    return false;
                }
            }
            if (cheDo == "Chi Tiết Phiếu Xuất")
            {
                DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNV = drv["MANV"].ToString();
                if (Program.username != maNV)
                {
                    MessageBox.Show("Không thể thêm chi tiết phiếu xuất với phiếu xuất do người khác tạo !", "Thông báo", MessageBoxButtons.OK);
                    bdsCTPX.RemoveCurrent();
                    return false;
                }
                if (txtMaPX.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu xuất !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPX.Focus();
                    return false;
                }
                if (txtMaPX.Text.Length > 8)
                {
                    MessageBox.Show("Mã phiếu xuất không thể quá 8 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPX.Focus();
                    return false;
                }
                if (txtMaVTCTPX.Text == "")
                {
                    MessageBox.Show("Mã vật tư không được để trống !", "Thông báo", MessageBoxButtons.OK);
                    txtMaVTCTPX.Focus();
                    return false;
                }
                if (txtMaVTCTPX.Text.Length > 4)
                {
                    MessageBox.Show("Mã vật tư không quá 4 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtMaVTCTPX.Focus();
                    return false;
                }
                if (txtSoLuongCTPX.Value < 0 || txtSoLuongCTPX.Value > Program.soLuongVatTuDuocChon)
                {
                    MessageBox.Show("Số lượng vật tư không thể bé hơn 0 & lớn hơn số lượng vật tư đang có trong kho hàng !", "Thông báo", MessageBoxButtons.OK);
                    txtSoLuongCTPX.Focus();
                    return false;
                }
                if (txtDonGiaCTPX.Value < 0)
                {
                    MessageBox.Show("Đơn giá không thể bé hơn 0 VND !", "Thông báo", MessageBoxButtons.OK);
                    txtDonGiaCTPX.Focus();
                    return false;
                }

            }
            return true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String cheDo = (btnMenu.Links[0].Caption == "Phiếu Xuất") ? "Phiếu Xuất" : "Chi Tiết Phiếu Xuất";
            if (!kiemTraDuLieu(cheDo))
            {
                return;
            }
            String maPX = txtMaPX.Text.Trim();
            try
            {
                bdsPhieuXuat.EndEdit();
                bdsCTPX.EndEdit();

                this.PhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PhieuXuatTableAdapter.Update(this.DS.PhieuXuat);

                this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPXTableAdapter.Update(this.DS.CTPX);

                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi không thành công!", "Lỗi", MessageBoxButtons.OK);
                return;
            }
            gcCTPX.Enabled = gcPhieuXuat.Enabled = true;
            pnlNhapLieu.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = btnMenu.Enabled = true;
            btnGhi.Enabled = btnHoanTac.Enabled = false;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bds.CancelEdit();
            bds.RemoveCurrent();
            if (btnThem.Enabled == false)
            {
                if (btnMenu.Links[0].Caption == "Phiếu Xuất")
                {
                    txtMaPX.Enabled = dteNgay.Enabled = txtMaNV.Enabled = txtMaKho.Enabled = false;
                    txtHoTen.Enabled = btnChonKhoHang.Enabled = true;
                }
                if (btnMenu.Links[0].Caption == "Chi Tiết Phiếu Xuất")
                {
                    txtMaPX.Enabled = txtMaVTCTPX.Enabled = btnChonVatTu.Enabled = false;
                    txtSoLuongCTPX.Enabled = txtDonGiaCTPX.Enabled = true;

                }
                bds.Position = viTri;
            }
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnMenu.Enabled = btnThoat.Enabled = true;
            gcCTPX.Enabled = gcPhieuXuat.Enabled = true;

            btnGhi.Enabled = btnHoanTac.Enabled;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.PhieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
                this.CTPXTableAdapter.Fill(this.DS.CTPX);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới. Hãy thử lại.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnChonKhoHang_Click(object sender, EventArgs e)
        {
            frmChonKhoHang form = new frmChonKhoHang();
            form.ShowDialog();

            txtMaKho.Text = Program.maKhoDuocChon;
        }

        private void btnChonVatTu_Click(object sender, EventArgs e)
        {
            frmChonVatTu form = new frmChonVatTu();
            form.ShowDialog();

            txtMaVTCTPX.Text = Program.maVatTuDuocChon;
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
                this.PhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PhieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

                this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPXTableAdapter.Fill(this.DS.CTPX);
            }
        }
    }
}
