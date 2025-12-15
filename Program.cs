using DesignPatterns.Behavioral.Template;

DocumentGenerator invoice = new InvoiceGenerator();
DocumentGenerator report = new ReportGenerator();

Console.WriteLine(invoice.Generate());
Console.WriteLine();
Console.WriteLine(report.Generate());
