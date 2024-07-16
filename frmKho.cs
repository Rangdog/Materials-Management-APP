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
    public partial class frmKho : Form
    {
        int vitri = 0;
        string macn = "";
        bool flagGhi = false;
        public frmKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSKHO);

        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            dSKHO.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dSKHO.Kho);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dSKHO.PhieuXuat);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dSKHO.PhieuNhap);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dSKHO.DatHang);

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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            flagGhi = true;
            panelControl2.Enabled = true;
            bdsKho.AddNew();
            txtMACN.Text = macn;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcKho.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcKho.Enabled = false;
            txtMaKho.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String makho = "";
            if(bdsDatHang.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho vì đã lập đơn hàng", "", MessageBoxButtons.OK);
                return;
            }
            if(bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho vì đã lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if(bdsPhieuXuat.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho vì đã lập phiếu xuất", "", MessageBoxButtons.OK);
            }
            if(MessageBox.Show("Bạn có thật sự muốn xóa Kho này??", "",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    makho = ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString();
                    bdsKho.RemoveCurrent();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(dSKHO.Kho);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa kho. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(dSKHO.Kho);
                    bdsKho.Position = bdsKho.Find("MAKHO", makho);
                    return;
                }
            }
            if(bdsKho.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được thiếu", "", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return;
            }
            if (flagGhi)
            {
                String cmd = "SP_CHECK_MAKHO_EXIST " + txtMaKho.Text;
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
                        MessageBox.Show("Mã Kho bị trùng vui lòng kiểm tra!", "", MessageBoxButtons.OK);
                        txtMaKho.Focus();
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
            if (txtTenKho.Text.Trim() == "")
            {
                MessageBox.Show("Tên Kho không được thiếu", "", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được thiếu", "", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return;
            }  
            try
            {
                bdsKho.EndEdit();
                bdsKho.ResetCurrentItem();
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Update(this.dSKHO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Kho.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcKho.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            flagGhi = false;
            txtMaKho.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKho.CancelEdit();
            this.khoTableAdapter.Fill(dSKHO.Kho);
            if (btnThem.Enabled == false) bdsKho.Position = vitri;
            gcKho.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnReload.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            txtMaKho.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.dSKHO.Kho);
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

        private void txtMaKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
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
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.dSKHO.Kho);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.dSKHO.PhieuXuat);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dSKHO.PhieuNhap);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.dSKHO.DatHang);
            }
        }
    }
}
