
namespace InvoiceGenerator;

public class Company : Enterpreneur
{
    public Company(Company other) : base(other) {}
    
    public Company(Enterpreneur other) : base(other) {}
    
    public override string GetFullDetailsString()
    {
        var details = base.GetFullDetailsString();

        details = details.Replace("РНОКПП", "ЄДРПОУ");

        return details;
    }
}