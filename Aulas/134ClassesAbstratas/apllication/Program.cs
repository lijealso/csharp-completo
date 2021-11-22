// See https://aka.ms/new-console-template for more information


using _134ClassesAbstratas.entities;

// Cannot create an instance of the abstract class or interface 'interface'
// Account acc1 = new Account(1001, "Alex", 500.0);
// Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

// acc1.Withdraw(10.0);
//acc2.Withdraw(10.0);

// Console.WriteLine(acc1.Balance);
// Console.WriteLine(acc2.Balance);

List<Account> list = new List<Account>();

list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.0));
list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

double sum = 0.0;

foreach(Account account in list)
{
    sum += account.Balance;
}

Console.WriteLine("Total balance: " + sum.ToString("F2"));

foreach (Account item in list)
{
    item.Withdraw(10.0);
}

foreach (Account item in list)
{
    Console.WriteLine("Updated balance for account "
        + item.Number
        + ": "
        + item.Balance.ToString("F2")
        );
}



