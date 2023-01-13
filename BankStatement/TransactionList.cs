
class TransactionList
{
    private readonly List<Transaction> _transactions;

    public TransactionList()
    {
        _transactions = new List<Transaction>();
    }

    public void AddTransaction(Transaction transaction)
    {
        _transactions.Add(transaction);
       
    }
    public void PrintTransactions()
    {
        foreach (var item in _transactions)
        {
            Console.WriteLine(item);

        }
    }
    public double Balance()
    {
        double totalAmount=0.0;
        foreach (var item in _transactions)
        {
            totalAmount += item.Amount;          

        }
        return totalAmount;
    }
}