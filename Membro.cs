namespace Sistema_de_gereciamento_de_biblioteca
{
    public class Membro
    {
        public string? Nome;
        public int ID;
        public string? Email;
        public string NumeroTelefone;

        public Membro(int id, string nome, string email, string numeroTelefone)
        {
            ID = id;
            Nome = nome;
            Email = email;
            NumeroTelefone = numeroTelefone;
        }

        public List<Membro> membro = new List<Membro>();

        public void AdicionarMembro(int id, string nome, string email, string numeroTelefone)
        {
            Membro novoMembro = new Membro(id, nome, email, numeroTelefone);
            membro.Add(novoMembro);
            Console.WriteLine($"Pessoa {nome} adicionada com sucesso!");
        }

         public void AtualizarMembro(int id, string? novoNome, string? novoEmail, string? novoTelefone)
        {
            var pessoa = membro.FirstOrDefault(p => p.ID == id);

            if (pessoa != null)
            {
                if (!string.IsNullOrWhiteSpace(novoNome))
                    pessoa.Nome = novoNome;

                if (!string.IsNullOrWhiteSpace(novoEmail))
                    pessoa.Email = novoEmail;

                if (!string.IsNullOrWhiteSpace(novoTelefone))
                    pessoa.NumeroTelefone = novoTelefone;

                Console.WriteLine($"Pessoa com ID {id} atualizada com sucesso!");
            }

            else
            {
                Console.WriteLine($"Pessoa com ID {id} não encontrada.");
            }

        }
        
        public void RemoverMembro(int id, string nome, string email, string numeroTelefone)
        {
            Membro novoMembro = new Membro(id, nome, email, numeroTelefone);
            membro.Remove(novoMembro);
            Console.WriteLine($"Pessoa {nome} foi removido com sucesso!");
        }

    }

}
