using System.Collections.Generic;

namespace EmployeeMonthlyPayslip.Models
{
    public interface ITaxCode
    {
        IEnumerable<TaxBracket> Brackets { get; }
    }
}
