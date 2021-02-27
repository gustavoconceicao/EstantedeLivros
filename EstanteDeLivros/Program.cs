using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstanteDeLivrosBiblioteca;


namespace EstanteDeLivros
{
    static class Program
    {
        public static UserBook user = new UserBook();
        
        [STAThread]      

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.user.nome = "Username";
            Program.user.carregarDados();


            Application.Run(new frm_menuInicial());
        }
    }
}
