using System;
namespace IwPrintingCalculator
{
    public class PrintJobException : Exception
    {
        public PrintJobException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
