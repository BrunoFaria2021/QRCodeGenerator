using QRCodeGenerator.Forms;
using System;
using System.Windows.Forms;

namespace QRCodeGenerator
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void AbrirFormularios(Form oFrm)
        {
            oFrm.MdiParent = this;
            oFrm.Top = 0;
            oFrm.Left= pnlMenu.Size.Width;
            oFrm.Show();
        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {

        }

        private void btnUrlType_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmQRCodeURL());
        }
    }
}
