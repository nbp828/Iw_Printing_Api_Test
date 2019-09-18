using System;
using System.Collections.Generic;
using System.Text;

namespace IwPrintingCalculator
{
    public class PrintCostCalculator
    {
        public string Calculate(PrintJob job)
        {
            float total = 0.0f;
            float marginPercent = job.ExtraMargin ? 0.16f : 0.11f;


            StringBuilder output = new StringBuilder();

            foreach (PrintJobItem item in job.JobItems)
            {
                float taxPercent = item.IsExempt ? 0.0f : 0.07f;
                string itemName = item.Name;
                float itemPrice = item.Price * taxPercent +
                    item.Price * marginPercent + item.Price;

                StringBuilder sb = new StringBuilder();
                sb.Append(itemName);
                sb.Append(": ");
                sb.Append("$");
                sb.Append(itemPrice);

                output.AppendLine(sb.ToString());
                total += itemPrice;
            }

            output.Append($"total: ${total}");

            return output.ToString();
        }
    }
}
