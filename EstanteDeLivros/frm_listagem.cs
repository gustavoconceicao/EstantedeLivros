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
    public partial class frm_listagem : Form
    {
        public Root lista { get; set;}

        public frm_listagem()
        {
            InitializeComponent();
        }

        private void frm_listagem_Load(object sender, EventArgs e)
        {
           for (int i =0; i< lista.items.Count(); i++)
            {
                UC_Book x = new UC_Book();

                if (lista.items[i].volumeInfo == null || lista.items[i].volumeInfo.imageLinks == null || lista.items[i].volumeInfo.imageLinks.thumbnail == null)
                {
                    x.url = "";
                }
                else
                {
                   x.url = lista.items[i].volumeInfo.imageLinks.thumbnail;
                }

                if (lista.items[i].searchInfo == null || string.IsNullOrEmpty(lista.items[i].searchInfo.textSnippet))
                {
                    x.resumo = "Resumo não encontrado";
                }
                else
                {
                    x.resumo = lista.items[i].searchInfo.textSnippet;
                }
                
                x.itemPri = lista.items[i];
                x.Location = new Point(30, 40 * i);
                painel.Controls.Add(x);
            }
        }

        private void painel_Paint(object sender, PaintEventArgs e)
        {
                       
        }
    }
}
