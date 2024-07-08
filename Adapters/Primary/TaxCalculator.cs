public class TaxCalculator : ITaxCalculator
{
    private readonly ITaxRateRepository _repository;

    public TaxCalculator(ITaxRateRepository repository)
    {
        _repository = repository;
    }

    public double CalculateTaxOn(double amount)
    {
        var taxRate = _repository.GetTaxRate(amount);
        return amount * taxRate;
    }
}