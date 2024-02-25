using Lab_PresentationDesktop.Views;

namespace Lab_PresentationDesktop.FormularioViews
{
    public partial class Frm_Principal : Form
    {
        private bool TelaAbertaForm = false;

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void MnuStrip_registro_Click(object sender, EventArgs e)
        {
            if (TelaAbertaForm == false)
            {
                TelaAbertaForm = true;
                Frm_Tecnico tecnicoMDI = new()
                {
                    MdiParent = this
                };
                tecnicoMDI.Show();
                tecnicoMDI.FormClosing += FechaForm_FormClosing;
            }
            else
            {
                MessageBox.Show("Já possui uma aba aberta", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FechaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaAbertaForm = false;
        }
    }
}