using System;
using Sistema_de_gerenciamento_de_biblioteca;

class Program
{
    static void Main(string[] args)
    {

        Membro membro1 = new Membro("Sebastião", 4125, "sebastião@gmail.com", "11 95151-6161");
        membro1.AdicionarMembro(membro1.Nome, membro1.ID, membro1.Email, membro1.NumeroTelefone);
        Console.WriteLine($"Pessoa adicionada: {membro1.Nome}, id: {membro1.ID}, email: {membro1.Email}, telefone: {membro1.NumeroTelefone}");

        membro1.AtualizarDados("Sebastião", "4125", "sebastião@gmail.com", "11 95151-6161");
        Console.WriteLine("\nDeseja atualizar os dados do membro? (s/n): ");
        string? desejaAtualizar = Console.ReadLine();

        if (desejaAtualizar?.ToLower() == "s")
        {
            string? novoNome = null;
            string? novoID = null;
            string? novoEmail = null;
            string? novoTelefone = null;

            Console.Write("Novo nome (pressione Enter para manter o atual): ");
            novoNome = Console.ReadLine();

            Console.Write("\nNovo ID (pressione Enter para manter o atual): ");
            novoID = Console.ReadLine();

            Console.Write("\nNovo email (pressione Enter para manter o atual): ");
            novoEmail = Console.ReadLine();

            Console.Write("\nNovo telefone (pressione Enter para manter o atual): ");
            novoTelefone = Console.ReadLine();

            membro1.AtualizarDados(novoNome, novoID!, novoEmail, novoTelefone);
        }
        else
        {
            Console.WriteLine("\nNenhuma atualização feita. Continuando o programa normalmente...");
        }

        Console.Write("\nDigite o ID do membro que deseja remover: ");
        int idRemover = int.Parse(Console.ReadLine()!); // ou int.TryParse se quiser mais seguro
        if (membro1 == null)
        {
            membro1!.RemoverMembro(idRemover);
            Console.WriteLine("Membro não encontrado.");
            return;
        }

        Livro livro1 = new Livro("Força do Brasil", "Nicolas", 123456, 2008, "Artigo", "Editora Brasil");
        Transaction transacaoLivro = new Transaction(
            transactionId: 1,
            memberId: 101,
            item: livro1,
            borrowDate: DateTime.Now,
            returnDate: DateTime.Now.AddDays(7)
        );

        transacaoLivro.Borrow();
        transacaoLivro.ProcessTransaction();


        Revista revista1 = new Revista("Clean Code", "Júlia", 123456, 2010, "Tecnologo", "Editora Brasil", "Volume 2", "Edição 5");

        Transaction transacaoRevista = new Transaction(
            transactionId: 2,
            memberId: 102,
            item: revista1,
            borrowDate: DateTime.Now,
            returnDate: DateTime.Now.AddDays(5)
        );

        transacaoRevista.Borrow();
        transacaoRevista.ProcessTransaction();

    }
}