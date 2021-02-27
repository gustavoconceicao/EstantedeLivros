using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstanteDeLivrosBiblioteca;

namespace EstanteDeLivros
{
    public partial class frm_pesquisar : Form
    {
        Json2Obj js = new Json2Obj();
        Root listaItems = new Root();
        string json;

        public frm_pesquisar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(txtbox_input.Text) && string.IsNullOrEmpty(txt_input_ator.Text))
            {
                MessageBox.Show("Você precisa informar ao menos uma das informações", "Falha na entrada de informações", MessageBoxButtons.OK);
            }

            if (string.IsNullOrEmpty(txt_input_ator.Text) && !string.IsNullOrEmpty(txtbox_input.Text))
            {
                json = await ApiBooks.pesquisarLivroPorNome(txtbox_input.Text);                
            }

            if (!string.IsNullOrEmpty(txt_input_ator.Text) && string.IsNullOrEmpty(txtbox_input.Text))
            {
                json = await ApiBooks.pesquisarLivroPorAutor(txt_input_ator.Text);                
            }

            if (!string.IsNullOrEmpty(txt_input_ator.Text) && !string.IsNullOrEmpty(txtbox_input.Text))
            {
                json = await ApiBooks.pesquisarLivroPorNome(txtbox_input.Text, txt_input_ator.Text);               
            }

            js.Json = json;
            listaItems = js.transformarJsonObj();
            lbl_resultado.Text = listaItems.items.Count().ToString();
            btn_listar.Show();
            lbl_footer.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            frm_listagem f = new frm_listagem();
            f.lista = listaItems;
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_mostrarListaUser F = new frm_mostrarListaUser();
            F.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frm_mostrarListaUser F = new frm_mostrarListaUser();
            F.ShowDialog();
        }
    }
}
