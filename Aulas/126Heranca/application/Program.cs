// See https://aka.ms/new-console-template for more information


using _126Heranca.entities;

BusinessAccount account = new BusinessAccount(8010, "Bob Brown, 100.0, 500.0");

Console.WriteLine(account.Balance); // get

// account.Balance = 200.0; // set não acessível / atributo não acessível



