using System;
using System.Collections.Generic;

namespace IwPrintingCalculator
{
    public class PrintJobParser
    {
        public PrintJob Parse(IEnumerable<string> contents)
        {
            bool isExtraMargin = false;
            List<PrintJobItem> items = new List<PrintJobItem>();

            try
            {
                foreach (string content in contents)
                {
                    if (content.ToLower() == "extra-margin")
                    {
                        isExtraMargin = true;
                    }
                    else
                    {
                        string[] tokens = content.Split();

                        string name = tokens[0];
                        float price = float.Parse(tokens[1]);
                        bool isExtempt = tokens.Length > 2 && tokens[2].ToLower()
                            == "exempt" ? true : false;

                        items.Add(new PrintJobItem(name, price, isExtempt));

                    }

                }
            }
            catch (Exception e)
            {
                throw new PrintJobException("Parsing Error", e);
            }

            return new PrintJob(items, isExtraMargin);
        }

    }
}
