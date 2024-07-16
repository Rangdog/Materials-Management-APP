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
    public partial class frmChonDonHang : Form
    {
        public frmChonDonHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChonDonHang_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.DatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DatHangTableAdapter.Fill(this.DS.DatHang);

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsDatHang.Current));
            String maNV = drv["MANV"].ToString().Trim();
            String maDDH = drv["MasoDDH"].ToString().Trim();
            String maKho = drv["MAKHO"].ToString().Trim();

            if (Program.username != maNV)
            {
                MessageBox.Show("Không thể lập phiếu trên đơn đặt hàng do người khác tạo", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            Program.maDonDatHangDuocChon = maDDH;
            Program.maKhoDuocChon = maKho;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
