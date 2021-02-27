using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstanteDeLivrosBiblioteca
{
   public class ApiBooks
    {
        public static async Task<String> pesquisarLivroPorNome(string titulo)
        {
            List<Root> lista = new List<Root>();
            string response;
            var url = "https://www.googleapis.com/books/v1/volumes?q=" + titulo + "&key=AIzaSyDQRPNINGAH9rUfW5RNdcksQgjT-Ka3TR4";

            using(var http = new HttpClient())
            {
                response = await http.GetStringAsync(url);
            }
            return response;
        }

        public static async Task<String> pesquisarLivroPorNome(string titulo, string autor)
        {
            List<Root> lista = new List<Root>();
            string response;
            var url = "https://www.googleapis.com/books/v1/volumes?q=" + titulo + "+inauthor:" + autor + "&key=AIzaSyDQRPNINGAH9rUfW5RNdcksQgjT-Ka3TR4";

            using (var http = new HttpClient())
            {
                response = await http.GetStringAsync(url);
            }
            return response;
        }


        public static async Task<String> pesquisarLivroPorAutor(string autor)
        {
            List<Root> lista = new List<Root>();
            string response;
            var url = "https://www.googleapis.com/books/v1/volumes?q=" + "+inauthor:" + autor + "&key=AIzaSyDQRPNINGAH9rUfW5RNdcksQgjT-Ka3TR4";

            using (var http = new HttpClient())
            {
                response = await http.GetStringAsync(url);
            }
            return response;
        }
    }
}
