using System;
using System.Windows.Forms;

namespace Forms.Telas
{
    public partial class ListaAutor : Form
    {
        public ListaAutor()
        {
            InitializeComponent();
        }

        private void CarregarGrid()
        {
            listView1.Items.Clear();
            
        }

        private void ListaAutor_Load(object sender, EventArgs e)
        {

        }
    }
}
