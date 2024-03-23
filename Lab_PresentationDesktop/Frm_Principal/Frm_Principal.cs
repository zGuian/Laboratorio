using AutoMapper;
using Lab_Application.Interfaces;
using Lab_Application.Services;
using Lab_PresentationDesktop.Views;

namespace Lab_PresentationDesktop.FormularioViews
{
    public partial class Frm_Principal : Form
    {
        private bool TelaAbertaForm = false;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IUsuarioServices _usuarioServices;

        public Frm_Principal()
        {
            InitializeComponent();
        }

        public Frm_Principal(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _usuarioServices = new UsuarioServices(_usuarioRepository, _mapper);
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

        private void CadastraNovoStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void FechaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaAbertaForm = false;
        }
    }
}