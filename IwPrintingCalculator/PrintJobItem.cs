namespace IwPrintingCalculator
{
    public class PrintJobItem
    {
        public PrintJobItem(string name, float price, bool isExempt = false)
        {
            this.Name = name;
            this.Price = price;
            this.IsExempt = isExempt;
        }

        public string Name { get; private set; }
        public float Price { get; private set; }
        public bool IsExempt { get; private set; }
    }
}