using Xceed.Document.NET;
using Xceed.Words.NET;

namespace InvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // test creation of docx file
            
            Enterpreneur enterpreneur = new Enterpreneur
            {
                Id = 1,
                PartyName = "Перевізник",
                FullName = "ФОП Кохан Володимир Володимирович",
                ActualAddress = "80320, Львівська обл., Львівський рн., с. Потелич, вул. Зелена, 113",
                PostAddress = "80320, Львівська обл., Львівський рн., с. Потелич, вул. Зелена, 113",
                TaxPayerId = "25803805497",
                BankAccount = "UA713257960000026004300113273",
                BankName = "Філія Львівське обласне управління АТ \"ОЩАДБАНК\"",
                BankId = "325796",
            };

            Company company = new Company(enterpreneur);

            var doc = DocX.Create("Document.docx");
            
            doc.SetDefaultFont(new Font("Times New Roman"), 12);
            
            doc.InsertParagraph(enterpreneur.GetFullDetailsString());

            doc.InsertParagraph(company.GetFullDetailsString());
            
            doc.Save();
        }
    }
}