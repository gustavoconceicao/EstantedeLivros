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
    public partial class UC_Book : UserControl
    {
        public string url;
        public string resumo;

        public livroClasse itemPri;


        public UC_Book()
        {
            InitializeComponent();
        }

        private void UC_Book_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(url))
            {
                picbox_icon.ImageLocation = "";
            }
            else
            {
                picbox_icon.ImageLocation = url;
            }

            if (string.IsNullOrEmpty(url))
            {
                txtbox_resumo.Text = "Não encontrado";
            }
            else
            {
                txtbox_resumo.Text = resumo;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            UC_Book_Completo F = new UC_Book_Completo();
            F.itemPrincipal = itemPri;

            frm_bookCompleto X = new frm_bookCompleto();
            X.Controls.Add(F);
            X.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            frm_statusLeitura F = new frm_statusLeitura();
            F.livro = itemPri;
            F.ShowDialog();
        }
    }
}
