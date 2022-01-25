using DataInfrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

string connectionString = await File.ReadAllTextAsync("D:/Revature/ConnectionStrings/BankedSQL_P2.txt");

DbContextOptionsBuilder<BankedDBContext> builder = new();
builder
    .UseSqlServer(connectionString)
    .LogTo(message => Debug.WriteLine(message), LogLevel.Information);
DbContextOptions<BankedDBContext> options = builder.Options;

using (BankedDBContext context = new(options))
{
    // Pull data from database

    //List<Expense> expenses = await context.Expenses.ToListAsync();

    //Console.WriteLine("Here are some expenses:");
    //foreach (var expense in expenses)
    //{
    //    Console.WriteLine($"====================");
    //    Console.WriteLine($"ID: {expense.ExpenseOptionsId}");
    //    Console.WriteLine($"Amount: {expense.ExpenseAmount}");
    //    Console.WriteLine($"Frequency: {expense.EspenseFrequency}");
    //    Console.WriteLine($"Ending: {expense.ExpenseEnding}");
    //    Console.WriteLine($"Severity: {expense.SeverityOfNeed}");
    //}

    // Execute a query using LINQ and at least one lambda expression

    //List<Income> myIncomes = await context.Incomes
    //    .Where(i => i.IncomeOptionsId == 1)
    //    .ToListAsync();

    //Console.WriteLine("Here are some expenses:");

    //foreach (var income in myIncomes)
    //{
    //    Console.WriteLine($"====================");
    //    Console.WriteLine($"ID: {income.IncomeOptionsId}");
    //    Console.WriteLine($"Amount: {income.IncomeAmount}");
    //    Console.WriteLine($"Pay Schedule: {income.PaySchedule}");
    //}

    //UserPassword user = await context.UserPasswords
    //.FirstAsync(u => u.UserName == "shaul");
    //bool isIt = user.UserName == "shaul";

    //Console.WriteLine();
    //Console.WriteLine($"Is it? {isIt}");

    // Execute a single query involving more than one table

    Loan loan = context.Loans.First(l => l.UserPasswordsId == 1);
    //loan.UserPasswordsId = 1;
    context.Entry(loan).Reference(l => l.UserPasswords).Load();
}