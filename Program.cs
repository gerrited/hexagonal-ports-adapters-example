var repository = new FixedTaxRateRepository();
var calculator = new TaxCalculator(repository);

var amount = 1000000;
var tax = calculator.CalculateTaxOn(amount);
Console.WriteLine($"{tax:0,000.00} taxes for {amount:0,000.00}");
