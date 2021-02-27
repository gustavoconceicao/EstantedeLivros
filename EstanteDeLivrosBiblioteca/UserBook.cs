using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EstanteDeLivrosBiblioteca
{
    public class UserBook
    {
        public List<bookStatus> Livros = new List<bookStatus>();
        public string nome;

        public void salvarDados() {
            File.WriteAllText(@"C:\cofreSenhas\userData.json", JsonConvert.SerializeObject(this));
        }
        public void carregarDados() {

            UserBook user = new UserBook();


            if (File.Exists(@"C:\cofreSenhas\userData.json"))
            {
                using (StreamReader file = File.OpenText(@"C:\cofreSenhas\userData.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    user = (UserBook)serializer.Deserialize(file, typeof(UserBook));
                    this.nome = user.nome;
                    this.Livros = user.Livros;
                }
            }
        }
    }
}
