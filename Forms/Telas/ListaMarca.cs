using Entidade;
using Servico;
using System;
using System.Windows.Forms;

namespace Forms
{
    public partial class ListaMarca : Form
    {
        public ListaMarca()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            listView1.Items.Clear();
            MarcaDao dao = new MarcaDao();
            foreach (Marca m in dao.ListarTodas())
            {
                ListViewItem item = new ListViewItem(m.mar_id.ToString());
                item.SubItems.Add(m.mar_descricao);
                listView1.Items.Add(item);
            }
        }
        private void FiltrarGrid()
        {
            for (int i = listView1.Items.Count - 1; -1 < i; i--)
            {
                if (listView1.Items[i].SubItems[1].Text.StartsWith(txtBusca.Text) == false)
                {
                    listView1.Items[i].Remove();
                }
            }
            listView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CadMarca cad = new CadMarca();
            cad.ShowDialog();
            CarregarGrid();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult Pergunta = MessageBox.Show("Você te certeza que deseja Excluir?", "Atenção!", MessageBoxButtons.YesNo);
                if (Pergunta == DialogResult.Yes)
                {
                    MarcaDao dao = new MarcaDao();
                    int codigo = Convert.ToInt32(listView1.SelectedItems[0].Text);
                    dao.Excluir(codigo);
                    CarregarGrid();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro Selecionado!");
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Marca marca = new Marca();
                marca.mar_id = Convert.ToInt32(listView1.SelectedItems[0].Text);
                CadMarca cad = new CadMarca(marca);
                cad.ShowDialog();
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Nenhum Registro Selecionado!");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusca.Text))
            {
                CarregarGrid();
            }
            else
            {
                FiltrarGrid();
            }
        }
    }
}
