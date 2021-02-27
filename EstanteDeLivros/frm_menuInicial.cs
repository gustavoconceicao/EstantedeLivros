using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstanteDeLivros
{
    public partial class frm_menuInicial : Form
    {
        public frm_menuInicial()
        {
            InitializeComponent();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            frm_pesquisar x = new frm_pesquisar();
            x.ShowDialog();
        }

        private void btn_estante_Click(object sender, EventArgs e)
        {
            frm_mostrarListaUser x = new frm_mostrarListaUser();
            x.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_cadastro x = new frm_cadastro();
            x.ShowDialog();
        }

        private void menuInicial_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\cofreSenhas\userData.json"))
            {
                btn_cadastrar.Show();         
            }
            else
            {
                btn_pesquisar.Location = new Point(52, 6);
                btn_estante.Location = new Point(52, 68);
            }
         }
    }
}
