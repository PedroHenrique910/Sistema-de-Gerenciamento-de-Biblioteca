using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gereciamento_de_biblioteca
{
    public class Revista : LibraryItem
    {
        public string Volume;
        public int Edicao;

        public Revista(string titulo, string autor, int isbn, int ano_da_publicacao, string genero,
            string editora, string volume, int edicao)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            AnoDaPublicacao = ano_da_publicacao;
            Volume = volume;
            Edicao = edicao;
        }

            public override void DisplayInfo()
        {
            Console.WriteLine($"{Volume} / {Edicao}");
        }
    }
}