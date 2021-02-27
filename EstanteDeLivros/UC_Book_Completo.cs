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
    public partial class UC_Book_Completo : UserControl
    {

        public livroClasse itemPrincipal;

        public UC_Book_Completo()
        {
            InitializeComponent();
        }

        private void UC_Book_Completo_Load(object sender, EventArgs e)
        {

            if(itemPrincipal.volumeInfo == null)
            {
                lbl_autor.Text = "Não encontrado";
                lbl_data.Text = "Não encontrado";
                lbl_publisher.Text = "Não encontrado";
                lbl_titulo.Text = "Não encontrado";
                pic_icon.ImageLocation = "";
                txtbox_resumo.Text = "Não encontrado";
            }

            if(string.IsNullOrEmpty(string.Join(",", itemPrincipal.volumeInfo.authors)))
            {
                lbl_autor.Text = "Não encontrado";
            }
            else
            {
                lbl_autor.Text = string.Join (",", itemPrincipal.volumeInfo.authors);
            }

            if (string.IsNullOrEmpty(itemPrincipal.volumeInfo.publishedDate))
            {
                lbl_data.Text = "Não encontrado";
            }
            else
            {
                lbl_data.Text = itemPrincipal.volumeInfo.publishedDate;
            }


            if (string.IsNullOrEmpty(itemPrincipal.volumeInfo.publisher))
            {
                lbl_publisher.Text = "Não encontrado";
            }
            else
            {
                lbl_publisher.Text = itemPrincipal.volumeInfo.publisher;
            }


            if (string.IsNullOrEmpty(itemPrincipal.volumeInfo.title))
            {
                lbl_titulo.Text = "Não encontrado";
            }
            else
            {
                lbl_titulo.Text = itemPrincipal.volumeInfo.title;
            }


            if (itemPrincipal.volumeInfo.imageLinks == null || string.IsNullOrEmpty(itemPrincipal.volumeInfo.imageLinks.thumbnail))
            {
                pic_icon.ImageLocation = "";
            }
            else
            {
                pic_icon.ImageLocation = itemPrincipal.volumeInfo.imageLinks.thumbnail;
            }


            if (string.IsNullOrEmpty(itemPrincipal.volumeInfo.description))
            {
                txtbox_resumo.Text = "Não encontrado";
            }
            else
            {
                txtbox_resumo.Text = itemPrincipal.volumeInfo.description;
            }
        }
    }
}
