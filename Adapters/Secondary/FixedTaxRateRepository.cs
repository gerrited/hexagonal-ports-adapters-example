public class FixedTaxRateRepository : ITaxRateRepository
{
    public double GetTaxRate(double amount)
    {
        return 0.15;
    }
}