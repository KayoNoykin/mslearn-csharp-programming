// Bring in the Billing namespace

using Calc = Billing.Calculator;

// Set up the order

double subtotal = 49.99;

// Calculate tax and total

double tax = Calc.CalculateTax(subtotal);
double total = Calc.CalculateTotal(subtotal, tax);

double outOfStateSubtotal = 80.00;
double outOfStateTax = Calc.CalculateTax(outOfStateSubtotal, taxRate: 0.05);
double outOfStateTotal = Calc.CalculateTotal(outOfStateSubtotal, outOfStateTax);

// Print the receipt

Console.WriteLine($"Subtotal: {subtotal:C}");
Console.WriteLine($"Tax :     {tax:C}");
Console.WriteLine($"Total:    {total:C}");

Console.WriteLine($"\nOut-of-state subtotal: {outOfStateSubtotal:C}");
Console.WriteLine($"Out-of-state tax:      {outOfStateTax:C}");
Console.WriteLine($"Out-of-state total:    {outOfStateTotal:C}");