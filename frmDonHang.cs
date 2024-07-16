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
    public partial class frmDonHang : Form
    {
        int vitri = 0;
        string macn = "";
        bool flagGhi = false;
        public frmDonHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDH);

        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {    

            dSDH.EnforceConstraints = false;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dSDH.DatHang);

            this.dSNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSNVTableAdapter.Fill(this.dSDH.DSNV);

            this.dSKHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSKHOTableAdapter.Fill(this.dSDH.DSKHO);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.dSDH.CTDDH);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dSDH.PhieuNhap);

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.dSDH.Vattu);

            this.ContextMenuStrip = contextMenuStrip1;

            macn = "CN" + (Program.mChiNhanh + 1).ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;

            if (Program.mGroup == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;
            }
            else
            {
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = true;
                btnPhucHoi.Enabled = btnGhi.Enabled = false;
                cmbChiNhanh.Enabled = false;
            }
        }

        private void cmbHoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHoten.SelectedValue == null) return;
            try
            {
                txtMANV.Text = cmbHoten.SelectedValue.ToString();
            }
            catch
            {

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
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.dSDH.DatHang);

                this.dSNVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSNVTableAdapter.Fill(this.dSDH.DSNV);

                this.dSKHOTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dSKHOTableAdapter.Fill(this.dSDH.DSKHO);

                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Fill(this.dSDH.CTDDH);
            }
        }

        private void cmbTenKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenKho.SelectedValue == null) return;
            try
            {
                txtMAKHO.Text = cmbTenKho.SelectedValue.ToString();
            }
            catch
            {

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDatHang.Position;
            flagGhi = true;
            panelControl2.Enabled = true;
            bdsDatHang.AddNew();
            dptNgay.EditValue = "";
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcDatHang.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsDatHang.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcDatHang.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMSDDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã số đơn hàng không được thiếu", "", MessageBoxButtons.OK);
                txtMSDDH.Focus();
                return;
            }
            if(dptNgay.EditValue.ToString() == "")
            {
                MessageBox.Show("ngày không được thiếu", "", MessageBoxButtons.OK);
                dptNgay.Focus();
                return;
            }
            if (DateTime.Compare(Convert.ToDateTime(dptNgay.EditValue.ToString()), DateTime.Now) >= 0)
            {
                MessageBox.Show("Ngày không hợp lệ", "", MessageBoxButtons.OK);
                dptNgay.Focus();
                return;
            }
            if(txtNhaCC.Text.Trim() == "")
            {
                MessageBox.Show("Nhà cung cấp không được thiếu", "", MessageBoxButtons.OK);
                txtNhaCC.Focus();
                return;
            }
            if (flagGhi)
            {
                String cmd = "SP_CHECK_MADDH_EXIST " + txtMSDDH.Text;
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
                        MessageBox.Show("Mã đơn hàng bị trùng vui lòng kiểm tra!", "", MessageBoxButtons.OK);
                        txtMSDDH.Focus();
                        sqlCmd.Dispose();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi kết nối: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                finally
                {
                    DA.Dispose();
                    Program.conn.Close();
                }
            }
            try
            {
                bdsDatHang.EndEdit();
                bdsDatHang.ResetCurrentItem();
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Update(this.dSDH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đơn hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mahddh = "";
            if(bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa đơn hàng vì đã nhập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if(bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa đơn hàng vì đã có chi tiết đặt hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa đơn hàng này??", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mahddh = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MasoDDH"].ToString();
                    bdsDatHang.RemoveCurrent();
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(dSDH.DatHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa kho. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.datHangTableAdapter.Fill(dSDH.DatHang);
                    bdsDatHang.Position = bdsDatHang.Find("MasoDDH", mahddh);
                    return;
                }
            }
            if (bdsDatHang.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDatHang.CancelEdit();
            this.datHangTableAdapter.Fill(dSDH.DatHang);
            if (btnThem.Enabled == false) bdsDatHang.Position = vitri;
            gcDatHang.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.datHangTableAdapter.Fill(this.dSDH.DatHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void tmsThemVatTu_Click(object sender, EventArgs e)
        {
            vitri = bdsCTDDH.Position;
            bdsCTDDH.AddNew();
        }
        private void tmsXoa_Click(object sender, EventArgs e)
        {
            if(bdsCTDDH.Count == 0)
            {
                return;
            }
            string mavt = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này??", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mavt = ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["MAVT"].ToString();
                    bdsCTDDH.RemoveCurrent();
                    this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cTDDHTableAdapter.Update(dSDH.CTDDH);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa kho. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.cTDDHTableAdapter.Fill(dSDH.CTDDH);
                    bdsCTDDH.Position = bdsCTDDH.Find("MAVT", mavt);
                    return;
                }
            }
        }

        private void tmsPhucHoi_Click(object sender, EventArgs e)
        {
            bdsCTDDH.CancelEdit();
            this.cTDDHTableAdapter.Fill(dSDH.CTDDH);
            if (tmsThemVatTu.Enabled == false) bdsCTDDH.Position = vitri;
        }

        private void tmsReload_Click(object sender, EventArgs e)
        {
            try
            {
                this.cTDDHTableAdapter.Fill(this.dSDH.CTDDH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void tmsiGhi_Click(object sender, EventArgs e)
        {
            int col = bdsCTDDH.Count - 1;
            if (((DataRowView)bdsCTDDH[col])["MAVT"].ToString().Trim() == "")
            {
                MessageBox.Show("Vật tư không thể thiếu", "", MessageBoxButtons.OK);
                return;
            }
            if (((DataRowView)bdsCTDDH[col])["SOLUONG"].ToString().Trim() == "")
            {
                MessageBox.Show("Số lượng không thể thiếu", "", MessageBoxButtons.OK);
                return;
            }
            if (Convert.ToInt32(((DataRowView)bdsCTDDH[col])["SOLUONG"].ToString()) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "", MessageBoxButtons.OK);
                return;
            }
            if (((DataRowView)bdsCTDDH[col])["DONGIA"].ToString().Trim() == "")
            {
                MessageBox.Show("Đơn giá không thể thiếu", "", MessageBoxButtons.OK);
                return;
            }
            if (Convert.ToInt32(((DataRowView)bdsCTDDH[col])["DONGIA"].ToString()) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "", MessageBoxButtons.OK);
                return;
            }
            try
            {
                bdsCTDDH.EndEdit();
                bdsCTDDH.ResetCurrentItem();
                this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDDHTableAdapter.Update(this.dSDH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Kho.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
