
namespace Sistema_de_gerenciamento_de_biblioteca
{
    public class Membro
    {
        public string Nome;
        public int ID;
        public string Email;
        public string NumeroTelefone;

        public Membro(string nome, int id, string email, string numeroTelefone)
        {
            ID = id;
            Nome = nome;
            Email = email;
            NumeroTelefone = numeroTelefone;

        }

        public List<Membro> membro = new List<Membro>();

        public void AdicionarMembro(string nome, int id, string email, string numeroTelefone)
        {
            Membro novoMembro = new Membro(nome, id, email, numeroTelefone);
            membro.Add(novoMembro);
            Console.WriteLine($"{nome} adicionada com sucesso!");
        }

        public void AtualizarDados(string? novoNome, string novoID, string? novoEmail, string? novoTelefone)
        {
            if (!string.IsNullOrWhiteSpace(novoNome))
                Nome = novoNome;

            if (!string.IsNullOrWhiteSpace(novoID))
                Nome = novoID;

            if (!string.IsNullOrWhiteSpace(novoEmail))
                Email = novoEmail;

            if (!string.IsNullOrWhiteSpace(novoTelefone))
                NumeroTelefone = novoTelefone;
        }



        public void RemoverMembro(int id)
        {
            var membroParaRemover = membro.FirstOrDefault(m => m.ID == id);

            if (membroParaRemover != null)
            {
                membro.Remove(membroParaRemover);
                Console.WriteLine($"{membroParaRemover.Nome} foi removido com sucesso!");
            }
            else
            {
                Console.WriteLine($"Nenhum membro com ID {id} foi encontrado.");
            }
        }


        internal void RemoverMembro()
        {
            throw new NotImplementedException();
        }
    }

}
