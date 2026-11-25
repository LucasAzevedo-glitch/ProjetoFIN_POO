using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPessoal
{
    public class LivroLido
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string Status { get; set; }
        public int Nota { get; set; }
        public DateTime DataLeitura { get; set; }

        public static List<LivroLido> ListaLivros = new List<LivroLido>();
    }
}
