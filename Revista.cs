namespace Sistema_de_gerenciamento_de_biblioteca
{
    public class Revista : LibraryItem
    {
        public string Volume;
        public string Edicao;

        public Revista(string titulo, string autor, int isbn, int ano_da_publicacao, string genero,
            string editora, string volume, string edicao)
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
            Console.WriteLine($"{Titulo} / {Autor} / {ISBN} / {AnoDaPublicacao} {Volume} / {Edicao}");
        }
    }
}