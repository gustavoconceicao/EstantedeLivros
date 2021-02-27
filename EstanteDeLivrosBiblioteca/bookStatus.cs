using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanteDeLivrosBiblioteca
{
    public enum statusLeitura
    {
        Ja_li,
        Planejo_Ler,
        Recomendo_a_leitura
    }

    public class bookStatus
    {
        public livroClasse livro;
        public statusLeitura status;

        public bookStatus(statusLeitura status, livroClasse livro)
        {
            this.livro = livro;
            this.status = status;
        }
    }
}
