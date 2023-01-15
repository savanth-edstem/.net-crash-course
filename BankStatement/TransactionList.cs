
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
        foreach (var balance in _transactions)
        {
            totalAmount += balance.Amount;

        }
        return totalAmount;
    }
    public Transaction MostSpend()
    {
        double mostSpendAmount=0;
        Transaction mostSpend= null;
        foreach (var spendItem in _transactions)
        {
            if (spendItem.Amount < mostSpendAmount)
            {
                mostSpendAmount = spendItem.Amount;
                mostSpend = spendItem;
            }            
        }
        return mostSpend;
        
    }
    public double MonthlyExpense(DateOnly startDate, DateOnly endDate)
    {
        double expense=0.0;
        foreach (var expenseItem in _transactions)
        {
            if (expenseItem.Date > startDate && expenseItem.Date < endDate) {
                if (expenseItem.Amount<0) 
                {
                    expense -= expenseItem.Amount;
                }
            }
        }
        return expense;
    }
}