using ApplicationArq.Interfaces;
using Domain.Entities;

namespace Presentation.Views
{
    public partial class Frm_Tecnico : Form
    {
        private readonly ITecnicoRepository _repository;

        public Frm_Tecnico()
        {
            InitializeComponent();
        }

        private void Btn_Carregar_Click(object sender, EventArgs e)
        {
            var nome = "Guian";
            var id = 1;
            _repository.InserirTecnico(nome);
        }
    }
}
