using System.Text;

namespace DesignPatterns.Behavioral.Template;

public sealed class InvoiceGenerator : DocumentGenerator
{
    protected override void AddHeader(StringBuilder builder)
    {
        builder.AppendLine("=== INVOICE ===");
    }

    protected override void AddBody(StringBuilder builder)
    {
        builder.AppendLine("Customer: ACME Corp");
        builder.AppendLine("Items:");
        builder.AppendLine("- Laptop: $1200");
        builder.AppendLine("- Mouse: $25");
        builder.AppendLine("Total: $1225");
    }
}