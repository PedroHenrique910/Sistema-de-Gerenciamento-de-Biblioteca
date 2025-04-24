public class Transaction 
{
    public int TransactionID;
    public int MemberID;
    public int LibraryItemID;
    public int BorrowDate ;
    public int ReturnDate;
    public DateTime? ActualReturnDate;
    
    
    public Transaction(int transactionId, int memberId, int libraryItemId, int borrowDate, int returnDate)
    {
        TransactionID = transactionId;
        MemberID = memberId;
        LibraryItemID = libraryItemId;
        BorrowDate = borrowDate;
        ReturnDate = returnDate;
        ActualReturnDate = null;
    }


    public bool Borrow(int transactionId, int memberId, int itemId, int borrowDate, int returnDate)
    {
        // Basic validation
        if (returnDate <= borrowDate)
        {
            Console.WriteLine("Return date must be after borrow date.");
            return false;
        }


        Console.WriteLine($"Transaction {TransactionID} - Member {MemberID} borrowed item {LibraryItemID} from {BorrowDate} to {ReturnDate}.");
        return true;
        
    }

     public void ReturnItem(DateTime returnDate)
    {
        ActualReturnDate = returnDate;
        Console.WriteLine($"Item {LibraryItemID} returned on {returnDate.ToShortDateString()}.");
    }

}
