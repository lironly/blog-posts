/// <summary>
/// Class used for calculating tax.
/// </summary>
public class GoodTaxCalculator
{
    private const float BASE_REDUCTION_VALUE = .30f;
    private const int SOCIAL_SECURITY_CONTRIBUTIONS = 125;

    /// <summary>
    /// Method used for calculating tax that would be reduced salary.
    /// </summary>
    /// <param name="salary">
    ///     The salary that would be
    ///     processed for tax calculation.
    /// </param>
    /// <returns>
    ///     The tax that would be reduced from
    ///     the provided salary.
    /// </returns>
    public float Execute(int salary)
    {
        
        return (salary * BASE_REDUCTION_VALUE) - SOCIAL_SECURITY_CONTRIBUTIONS;
    }
}
