using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstanteDeLivrosBiblioteca;

namespace EstanteDeLivros
{
    public partial class UC_BookStatus : UserControl
    {
        public bookStatus currentLivro;

        public UC_BookStatus()
        {
            InitializeComponent();
        }

        private void UC_BookStatus_Load(object sender, EventArgs e)
        {

            if (currentLivro.livro.volumeInfo.imageLinks == null || string.IsNullOrEmpty (currentLivro.livro.volumeInfo.imageLinks.thumbnail))
            {
                pic_thumb.ImageLocation = "";
            }
            else
            {
                pic_thumb.ImageLocation = currentLivro.livro.volumeInfo.imageLinks.thumbnail;
            }

           if (string.IsNullOrEmpty (currentLivro.livro.volumeInfo.title))
            {
                lbl_title.Text = "Não encontrado";
            }
            else
            {
                lbl_title.Text = currentLivro.livro.volumeInfo.title;
            }

            if (string.IsNullOrEmpty(currentLivro.status.ToString()))
            {
                lbl_status.Text = "Não encontrado";
            }
            else
            {
                lbl_status.Text = currentLivro.status.ToString();
            }
        }
    }
}
