using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class frmVatTu : Form
    {
        String maChiNhanh = "";
        int viTri = 0;

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public frmVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VatTuTableAdapter.Fill(this.DS.Vattu);

            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);

            this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPXTableAdapter.Fill(this.DS.CTPX);

            maChiNhanh = "CN" + (Program.mChiNhanh + 1).ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true; // bật tắt theo phân quyền
                btnThem.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnHoanTac.Enabled = false;

            }
            else
            {
                cmbChiNhanh.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnHoanTac.Enabled = true;
                cmbChiNhanh.Enabled = true;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsVatTu.Position;
            pnlNhapLieu.Enabled = true;
            gcVatTu.Enabled = false;

            bdsVatTu.AddNew();
            spnSLT.Value = 1;

            btnGhi.Enabled = btnHoanTac.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnLamMoi.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsVatTu.Position;
            pnlNhapLieu.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLamMoi.Enabled = false;
            btnGhi.Enabled = btnHoanTac.Enabled = true;
            gcVatTu.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaVT.Text == "")
            {
                MessageBox.Show("Mã vật tư không được trống", "Thông báo", MessageBoxButtons.OK);
                txtMaVT.Focus();
                return;
            }
            if (txtTenVT.Text == "")
            {
                MessageBox.Show("Tên vật tư không được trống", "Thông báo", MessageBoxButtons.OK);
                txtTenVT.Focus();
                return;
            }
            if (txtDVT.Text == "")
            {
                MessageBox.Show("Đơn vị tính không được trống", "Thông báo", MessageBoxButtons.OK);
                txtDVT.Focus();
                return;
            }
            if (spnSLT.Value < 0)
            {
                MessageBox.Show("Số lượng tồn không được nhỏ hơn 0", "Thông báo", MessageBoxButtons.OK);
                spnSLT.Focus();
                return;
            }
            try
            {
                bdsVatTu.EndEdit();
                bdsVatTu.ResetCurrentItem();
                this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.VatTuTableAdapter.Update(this.DS.Vattu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi vật tư. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcVatTu.Enabled = true;
            pnlNhapLieu.Enabled = false;
            btnGhi.Enabled = btnHoanTac.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư vì đã lập đơn đặt hàng", "", MessageBoxButtons.OKCancel);
            }
            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư vì đã lập phiếu nhập", "", MessageBoxButtons.OKCancel);
            }
            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư vì đã lập phiếu xuất", "", MessageBoxButtons.OKCancel);
            }
            if (MessageBox.Show("Bạn có muốn xóa vật tư này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdsVatTu.Position;
                    bdsVatTu.RemoveCurrent();

                    this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.VatTuTableAdapter.Update(this.DS.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa vât tư. Hãy xóa lại. \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.VatTuTableAdapter.Fill(this.DS.Vattu);
                    bdsVatTu.Position = viTri;
                    return;
                }
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVatTu.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsVatTu.Position = viTri;
            }
            pnlNhapLieu.Enabled = false;
            gcVatTu.Enabled = true;

            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnThem.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHoanTac.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.VatTuTableAdapter.Fill(this.DS.Vattu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới: " + ex.Message, "", MessageBoxButtons.OKCancel);
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
                this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.VatTuTableAdapter.Fill(this.DS.Vattu);

                this.CTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

                this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPNTableAdapter.Fill(this.DS.CTPN);

                this.CTPXTableAdapter.Connection.ConnectionString = Program.connstr;
                this.CTPXTableAdapter.Fill(this.DS.CTPX);
            }
        }
    }
}
