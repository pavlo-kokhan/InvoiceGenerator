using System.Text;

namespace InvoiceGenerator;

public class Enterpreneur
{
    public int Id { get; set; }
    public string PartyName { get; set; }
    public string FullName { get; set; }
    public string ActualAddress { get; set; }
    public string PostAddress { get; set; }
    public string TaxPayerId { get; set; }
    public string BankAccount { get; set; }
    public string BankName { get; set; }
    public string BankId { get; set; }

    public Enterpreneur()
    {
        Id = -1;
        PartyName = FullName = ActualAddress = PostAddress = TaxPayerId = 
            BankAccount = BankName = BankId = string.Empty;
    }

    public Enterpreneur(Enterpreneur other)
    {
        Id = other.Id;
        PartyName = other.PartyName;
        FullName = other.FullName;
        ActualAddress = other.ActualAddress;
        PostAddress = other.PostAddress;
        TaxPayerId = other.TaxPayerId;
        BankAccount = other.BankAccount;
        BankName = other.BankName;
        BankId = other.BankId;
    }

    public virtual string GetFullDetailsString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{PartyName}:");
        sb.AppendLine(FullName);
        sb.AppendLine($"Фізична адреса: {ActualAddress}");
        sb.AppendLine($"Поштова адреса: {PostAddress}");
        sb.AppendLine($"РНОКПП: {TaxPayerId}");
        sb.AppendLine($"р/р: {BankAccount}");
        sb.AppendLine(BankName);
        sb.AppendLine($"МФО: {BankId}");

        return sb.ToString();
    }
}