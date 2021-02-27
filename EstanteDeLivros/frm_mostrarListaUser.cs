using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstanteDeLivros
{
    public partial class frm_mostrarListaUser : Form
    {
        public frm_mostrarListaUser()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_mostrarListaUser_Load(object sender, EventArgs e)
        {
            lbl_nome.Text = Program.user.nome;
           for (int i =0; i<Program.user.Livros.Count(); i++)
            {
                UC_BookStatus f = new UC_BookStatus();
                f.currentLivro = Program.user.Livros[i];
                panel.Controls.Add(f);
            }
        }
    }
}
