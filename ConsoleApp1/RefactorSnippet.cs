namespace ClassLibrary1;

public class RefactorSnippet
{
    class InvoiceDetails
    {
        public readonly string _customer;
        public readonly double _outstanding;

        public InvoiceDetails()
        {
            _customer = string.Empty;
            _outstanding = 0;
        }

        
    }

    class PrintManager : InvoiceDetails
    {
        public void PrintOwing(InvoiceDetails invoice)
        {
            PrintBanner();
            PrintDetails(invoice._customer, _outstanding);
        }
        
        private void PrintBanner()
        {
            // Print banner logic goes here
            Console.WriteLine("***** Invoice *****");
        }

        private void PrintDetails(string customer, double outstanding)
        {
            Console.WriteLine($"name: {customer}");
            Console.WriteLine($"amount: {outstanding}");
        }
        
        
        
        
    }
}