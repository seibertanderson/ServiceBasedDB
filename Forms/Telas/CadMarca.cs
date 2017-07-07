using Entidade;
using Servico;
using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class CadMarca : Form
    {
        private bool isEdicao = false;
        private Marca marca = new Marca();
        private MarcaDao dao = new MarcaDao();        
        public CadMarca()
        {
            InitializeComponent();
        }        
        public CadMarca(Marca marca)
        {
            InitializeComponent();
            isEdicao = true;
            MarcaDao dao = new MarcaDao();
            this.marca = dao.BuscarId(marca.mar_id);

            txtDescricao.Text = this.marca.mar_descricao;
        }        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Descrição Inválida");
                return;
            }
            
            marca.mar_descricao = txtDescricao.Text;
            if (isEdicao == true)
            {
                dao.Alterar(marca);
                MessageBox.Show("Cadastro Alterado!");
            }
            else
            {
                dao.Inserir(marca);
                MessageBox.Show("Cadastro Realizado!");
            }            
            Close();
        }

        private void CadMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
