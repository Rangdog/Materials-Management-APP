using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.SubForm
{
    public partial class frmChonChiTietDonHang : Form
    {
        public frmChonChiTietDonHang()
        {
            InitializeComponent();
        }

        private void cTDDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCTDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChonChiTietDonHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsCTDDH.Current));
            String maDDH = drv["MasoDDH"].ToString().Trim();
            String maVT = drv["MAVT"].ToString().Trim();
            int soLuong = int.Parse(drv["SOLUONG"].ToString().Trim());
            int donGia = int.Parse(drv["DONGIA"].ToString().Trim());
            Program.maDonDatHangChiTietDuocChon = maDDH;
            if (Program.maDonDatHangChiTietDuocChon != Program.maDonDatHangDuocChon)
            {
                MessageBox.Show("Bạn phải chọn chi tiết đơn hàng có mã đơn hàng là " + Program.maDonDatHangDuocChon, "Thông báp", MessageBoxButtons.OK);
                return;
            }

            Program.maVatTuDuocChon = maVT;
            Program.soLuongVatTuDuocChon = soLuong;
            Program.donGiaDuocChon = donGia;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
