
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EstanteDeLivrosBiblioteca
{
    public class Json2Obj
    {
        public string Json { get; set; }
       
        public Root transformarJsonObj()
        {
            Root resultado = JsonConvert.DeserializeObject<Root>(Json);

            return resultado;
        }
    }
}
