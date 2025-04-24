namespace Sistema_de_gerenciamento_de_biblioteca
{
    public class Livro : LibraryItem
    {
        public string Genero;
        public string Editora;
        public Livro(string titulo, string autor, int isbn, int ano_da_publicacao, string genero, string editora)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            AnoDaPublicacao = ano_da_publicacao;
            Genero = genero;
            Editora = editora;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Titulo} / {Autor} / {ISBN} / {AnoDaPublicacao} {Genero} / {Editora}");
        }
        
    }
}
