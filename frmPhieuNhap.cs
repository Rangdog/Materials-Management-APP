using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using QLVT.SubForm;

namespace QLVT
{
    public partial class frmPhieuNhap : Form
    {
        String maChiNhanh = "";
        int viTri = 0;

        BindingSource bds = null; // Chứa những dữ liệu đang làm việc
        GridControl gc = null;  // Chứa grid view đang làm việc

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuNhap.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.PhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PhieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);

            maChiNhanh = "CN" + (Program.mChiNhanh + 1).ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            cmbChiNhanh.Enabled = false;
        }

        private void btnCheDoPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMenu.Links[0].Caption = "Phiếu Nhập";

            bds = bdsPhieuNhap;
            gc = gcPhieuNhap;

            txtMaPN.Enabled = dteNgay.Enabled = txtMaPN.Enabled = txtMaKho.Enabled = false;
            txtMaDDH.Enabled = txtMaVTCTPN.Enabled = txtSoLuongCTPN.Enabled = txtDonGiaCTPN.Enabled = false;
            btnChonDonHang.Enabled = btnChonChiTietDonHang.Enabled = false;

            if (Program.mGroup == "CONGTY")
            {
                // CONGTY chỉ được xem dữ liệu
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = false;
                btnMenu.Enabled = btnThoat.Enabled = btnLamMoi.Enabled = true;
                pnlNhapLieu.Enabled = false;
            }
            else
            {
                //CHINHANH & USER có thể xem - xóa - sửa dữ liệu nhưng không thể chuyển chi nhánh khác
                cmbChiNhanh.Enabled = false;

                btnMenu.Enabled = true;
                btnThem.Enabled = btnGhi.Enabled = btnLamMoi.Enabled = btnHoanTac.Enabled = btnThoat.Enabled = true;
                if (bdsPhieuNhap.Count > 0)
                {
                    btnXoa.Enabled = true;
                }
                else
                {
                    btnXoa.Enabled = false;
                }

            }
        }

        private void btnCheDoChiTietPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMenu.Links[0].Caption = "Chi Tiết Phiếu Nhập";

            bds = bdsCTPN;
            gc = gcPhieuNhap;

            txtMaPN.Enabled = dteNgay.Enabled = txtMaPN.Enabled = txtMaKho.Enabled = false;
            txtMaDDH.Enabled = txtMaVTCTPN.Enabled = txtSoLuongCTPN.Enabled = txtDonGiaCTPN.Enabled = false;
            btnChonDonHang.Enabled = btnChonChiTietDonHang.Enabled = false;

            gcPhieuNhap.Enabled = gcChiTietPhieuNhap.Enabled = true;

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
                btnXoa.Enabled = false;

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bds.Position;
            bds.AddNew();

            if (btnMenu.Links[0].Caption == "Phiếu Nhập")
            {
                txtMaPN.Enabled = true;

                dteNgay.EditValue = DateTime.Now;
                dteNgay.Enabled = false;

                txtMaDDH.Enabled = false;
                btnChonDonHang.Enabled = true;

                txtMaNV.Text = Program.username;
                txtMaKho.Text = Program.maKhoDuocChon;

                ((DataRowView)(bdsPhieuNhap.Current))["NGAY"] = DateTime.Now;
                ((DataRowView)(bdsPhieuNhap.Current))["MasoDDH"] = Program.maDonDatHangDuocChon;
                ((DataRowView)(bdsPhieuNhap.Current))["MANV"] = Program.username;
                ((DataRowView)(bdsPhieuNhap.Current))["MAKHO"] = Program.maKhoDuocChon;
            }
            if (btnMenu.Links[0].Caption == "Chi Tiết Phiếu Nhập")
            {
                DataRowView drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNV = drv["MANV"].ToString();
                if (Program.username != maNV)
                {
                    MessageBox.Show("Không thể thêm chi tiết phiếu nhập trên phiếu nhập của người khác tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                // Gắn tự động 
                ((DataRowView)(bdsCTPN.Current))["MAPN"] = ((DataRowView)(bdsPhieuNhap.Current))["MAPN"];
                ((DataRowView)(bdsCTPN.Current))["MAVT"] = Program.maVatTuDuocChon;
                ((DataRowView)(bdsCTPN.Current))["SOLUONG"] = Program.soLuongVatTuDuocChon;
                ((DataRowView)(bdsCTPN.Current))["DONGIA"] = Program.donGiaDuocChon;

                btnChonChiTietDonHang.Enabled = true;
                txtSoLuongCTPN.Enabled = txtDonGiaCTPN.Enabled = true;

            }

            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = btnMenu.Enabled = false;
            btnGhi.Enabled = btnHoanTac.Enabled = true;
            gcPhieuNhap.Enabled = gcChiTietPhieuNhap.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cheDo = (btnMenu.Links[0].Caption == "Phiếu Nhập") ? "Phiếu Nhập" : "Chi Tiết Phiếu Nhập";
            if (cheDo == "Phiếu Nhập")
            {
                DataRowView drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNV = drv["MANV"].ToString().Trim();
                if (Program.username != maNV)
                {
                    MessageBox.Show("Không thể xóa phiếu nhập do người khác lập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsCTPN.Count > 0)
                {
                    MessageBox.Show("Không thể xóa phiếu nhập vì đã có chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            if (cheDo == "Chi Tiết Phiếu Nhập")
            {
                DataRowView drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNV = drv["MANV"].ToString().Trim();
                if (Program.username != maNV)
                {
                    MessageBox.Show("Không thể xóa chi tiết phiếu nhập do người khác lập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bds.Position;
                    if (cheDo == "Phiếu Nhập")
                    {
                        bdsPhieuNhap.RemoveCurrent();
                    }
                    if (cheDo == "Chi Tiết Phiếu Nhập")
                    {
                        bdsCTPN.RemoveCurrent();
                    }
                    this.PhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PhieuNhapTableAdapter.Update(this.DS.PhieuNhap);

                    this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPNTableAdapter.Update(this.DS.CTPN);

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa không thành công. Bạn hãy xóa lại", "Thông báo", MessageBoxButtons.OK);
                    this.PhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.PhieuNhapTableAdapter.Update(this.DS.PhieuNhap);

                    this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.CTPNTableAdapter.Update(this.DS.CTPN);

                    bds.Position = viTri;
                    return;
                }

            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String cheDo = (btnMenu.Links[0].Caption == "Phiếu Nhập") ? "Phiếu Nhập" : "Chi Tiết Phiếu Nhập";

            String maPN = txtMaPN.Text.Trim();
            try
            {
                bdsPhieuNhap.EndEdit();
                bdsCTPN.EndEdit();
                this.PhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PhieuNhapTableAdapter.Update(this.DS.PhieuNhap);
                this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPNTableAdapter.Update(this.DS.CTPN);
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi không thành công!" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                return;
            }
            gcChiTietPhieuNhap.Enabled = gcPhieuNhap.Enabled = true;
            pnlNhapLieu.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHoanTac.Enabled = false;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                if (btnMenu.Links[0].Caption == "Phiếu Nhập")
                {
                    txtMaDDH.Enabled = dteNgay.Enabled = txtMaKho.Enabled = btnChonDonHang.Enabled = false;
                }
                if (btnMenu.Links[0].Caption == "Chi Tiết Phiếu Nhập")
                {
                    txtMaDDH.Enabled = btnChonChiTietDonHang.Enabled = txtMaVTCTPN.Enabled = txtSoLuongCTPN.Enabled = txtDonGiaCTPN.Enabled = btnXoa.Enabled = false;
                }

            }
            bds.CancelEdit();
            bds.RemoveCurrent();
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnMenu.Enabled = btnThoat.Enabled = true;
            gcChiTietPhieuNhap.Enabled = gcPhieuNhap.Enabled = true;

            btnGhi.Enabled = btnHoanTac.Enabled;
            bds.Position = viTri;
            return;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.PhieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                this.CTPNTableAdapter.Fill(this.DS.CTPN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới dữ liệu \n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
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
                this.PhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PhieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

                this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPNTableAdapter.Fill(this.DS.CTPN);
            }
        }

        private void btnChonDonHang_Click(object sender, EventArgs e)
        {
            frmChonDonHang form = new frmChonDonHang();
            form.ShowDialog();

            txtMaDDH.Text = Program.maDonDatHangDuocChon;
            txtMaKho.Text = Program.maKhoDuocChon;
        }

        private void btnChonChiTietDonHang_Click(object sender, EventArgs e)
        {
            Program.maDonDatHangDuocChon = ((DataRowView)bdsPhieuNhap.Current)["MasoDDH"].ToString().Trim();
            frmChonChiTietDonHang form = new frmChonChiTietDonHang();
            form.ShowDialog();

            txtMaVTCTPN.Text = Program.maVatTuDuocChon;
            txtSoLuongCTPN.Value = Program.soLuongVatTuDuocChon;
            txtDonGiaCTPN.Value = Program.donGiaDuocChon;
        }
    }
}
