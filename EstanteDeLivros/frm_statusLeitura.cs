using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstanteDeLivrosBiblioteca;

namespace EstanteDeLivros
{
    public partial class frm_statusLeitura : Form
    {
        public livroClasse livro;


        public frm_statusLeitura()
        {
            InitializeComponent();
        }

        private void frm_statusLeitura_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(livro.volumeInfo.title))
            {
                lbl_nomeLivro.Text = "Não encontrado";
            }
            else
            {
                lbl_nomeLivro.Text = livro.volumeInfo.title;
            }

            if (livro.volumeInfo.imageLinks == null || string.IsNullOrEmpty( livro.volumeInfo.imageLinks.thumbnail))
            {
                pic_thumb.ImageLocation = "";
            }
            else
            {
                pic_thumb.ImageLocation = livro.volumeInfo.imageLinks.thumbnail;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookStatus book = new bookStatus(statusLeitura.Ja_li, livro);
            Program.user.Livros.Add(book);
            MessageBox.Show("Você adicionou" + livro.volumeInfo.title + " a sua lista de livros lidos", "Confirmação", MessageBoxButtons.OK);
            Program.user.salvarDados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookStatus book = new bookStatus(statusLeitura.Planejo_Ler, livro);
            Program.user.Livros.Add(book);

            MessageBox.Show("Você adicionou" + livro.volumeInfo.title + " a sua lista de livros para ler " , "Confirmação", MessageBoxButtons.OK);
            Program.user.salvarDados();
        }
    }
}
