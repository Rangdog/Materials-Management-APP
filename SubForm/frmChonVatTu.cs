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
    public partial class frmChonVatTu : Form
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public frmChonVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChonVatTu_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.VatTuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.VatTuTableAdapter.Fill(this.DS.Vattu);

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            String maVT = ((DataRowView)bdsVatTu.Current)["MAVT"].ToString();
            int soLuongVatTu = int.Parse(((DataRowView)bdsVatTu.Current)["SOLUONGTON"].ToString());

            Program.maVatTuDuocChon = maVT;
            Program.soLuongVatTuDuocChon = soLuongVatTu;

            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
