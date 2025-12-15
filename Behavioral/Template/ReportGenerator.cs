using System.Text;

namespace DesignPatterns.Behavioral.Template;

public sealed class ReportGenerator : DocumentGenerator
{
    protected override void AddHeader(StringBuilder builder)
    {
        builder.AppendLine("=== MONTHLY REPORT ===");
    }

    protected override void AddBody(StringBuilder builder)
    {
        builder.AppendLine("Revenue: $50,000");
        builder.AppendLine("Expenses: $32,000");
        builder.AppendLine("Profit: $18,000");
    }

    protected override void AddFooter(StringBuilder builder)
    {
        builder.AppendLine("Confidential – Internal Use Only");
    }
}