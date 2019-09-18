using System;
using System.Collections.Generic;
using System.Linq;

namespace IwPrintingCalculator
{
    public class PrintJob
    {
        public PrintJob(IEnumerable<PrintJobItem> jobItems,
            bool extraMargin = false)
        {
            if (jobItems is null || jobItems.Count() < 1)
            {
                throw new ArgumentException(
                    $"{nameof(jobItems)} is a null or empty collection");
            }

            this.JobItems = jobItems;
            this.ExtraMargin = extraMargin;
        }

        public IEnumerable<PrintJobItem> JobItems { get; private set; }
        public bool ExtraMargin { get; private set; }
    }
}
