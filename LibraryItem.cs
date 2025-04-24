namespace Sistema_de_gerenciamento_de_biblioteca
{
    public abstract class LibraryItem
    {
        public string? Titulo;
        public string? Autor;
        public int ISBN;
        public int AnoDaPublicacao;
        public int ItemID;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Titulo} / {Autor} / {ISBN} / {AnoDaPublicacao}");
        }
    }
}