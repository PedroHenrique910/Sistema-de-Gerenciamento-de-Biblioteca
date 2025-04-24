namespace Sistema_de_gerenciamento_de_biblioteca;
public class Transaction 
{
    public int TransactionID { get; set; }
    public int MemberID { get; set; }
    public LibraryItem Item { get; set; } // Aqui entra o polimorfismo
    public DateTime BorrowDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public DateTime? ActualReturnDate { get; set; }

    public Transaction(int transactionId, int memberId, LibraryItem item, DateTime borrowDate, DateTime returnDate)
    {
        TransactionID = transactionId;
        MemberID = memberId;
        Item = item;
        BorrowDate = borrowDate;
        ReturnDate = returnDate;
        ActualReturnDate = null;
    }

    public bool Borrow()
    {
        if (ReturnDate <= BorrowDate)
        {
            Console.WriteLine("A data de devolução deve ser posterior à data de empréstimo");
            return false;
        }

        Console.WriteLine($"Transação: {TransactionID} - Membro: {MemberID} item emprestado {Item.ItemID} de {BorrowDate.ToShortDateString()} até {ReturnDate.ToShortDateString()}.");
        return true;
    }

    public virtual void ReturnItem(DateTime returnDate)
    {
        ActualReturnDate = returnDate;
        Console.WriteLine($"O item {Item.ItemID} foi devolvido em {returnDate.ToShortDateString()}.");
    }

    public void ProcessTransaction()
    {
        Console.WriteLine($"\nTransação n°{TransactionID} para o membro n° {MemberID}");
        Item.DisplayInfo(); // Polimorfismo funcionando aqui
        Console.WriteLine($"Data do empréstimo: {BorrowDate.ToShortDateString()} | Data de devolução: {ReturnDate.ToShortDateString()}");
    }
}
