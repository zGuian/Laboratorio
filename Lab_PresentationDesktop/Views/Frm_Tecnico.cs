using Lab_Application.Interfaces;

namespace Lab_PresentationDesktop.Views
{
    public partial class Frm_Tecnico : Form
    {
        private readonly ITecnicoRepository? _repository;

        public Frm_Tecnico()
        {
            InitializeComponent();
        }
    }
}