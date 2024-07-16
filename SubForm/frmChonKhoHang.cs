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
    public partial class frmChonKhoHang : Form
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public frmChonKhoHang()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChonKhoHang_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.KhoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KhoTableAdapter.Fill(this.DS.Kho);

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            String maKho = ((DataRowView)bdsKho.Current)["MAKHO"].ToString();
            Program.maKhoDuocChon = maKho;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
