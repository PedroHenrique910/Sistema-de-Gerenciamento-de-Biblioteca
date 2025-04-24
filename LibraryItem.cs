using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gereciamento_de_biblioteca
{
    public abstract class LibraryItem
    {
        public string? Titulo;
        public string? Autor;
        public int ISBN;
        public int AnoDaPublicacao;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Titulo} / {Autor} / {ISBN} / {AnoDaPublicacao}");
        }
    }
}