/// <summary>
/// Class used for calculating tax.
/// </summary>
public class BadTaxCalculator
{
    /// <summary>
    /// Method used for calculating salary tax.
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
        return (salary * .30) - 125; // Bad code due to magic values
    }
}
