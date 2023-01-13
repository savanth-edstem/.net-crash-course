using System.Globalization;

TransactionList transactionList = new TransactionList();

void Readfile()
{
    string[] columns;
    string[] stringdate;

    string[] lines = File.ReadAllLines(@"C:\Users\Admin\source\repos\console programming\BankStatement\test.csv");

    foreach (string line in lines)
    {
        columns = line.Split(",");
        stringdate = columns[0].Split("-");
        DateTime parsedDate = DateTime.Parse($"{stringdate[2]}/{stringdate[1]}/{stringdate[0]}", CultureInfo.InvariantCulture);
        DateOnly date = DateOnly.FromDateTime(parsedDate);
        double amount = Convert.ToDouble(columns[1]);
        Transaction transaction = new Transaction(date, amount, columns[2]);
        transactionList.AddTransaction(transaction);
    }
}
try
{
    Readfile();
    transactionList.PrintTransactions();
    Console.WriteLine($"Net Balance: {transactionList.Balance()}");

}
catch (Exception)
{

    throw;
}