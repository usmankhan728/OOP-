namespace task2.cs
{
   public class Transaction
    {
        // Data members
        public int id;
        public string productName;
        public double amount;
        public string date;
        public string time;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create first transaction object
            Transaction t1 = new Transaction();

            // Initialize t1 with values
            t1.id = 101;
            t1.productName = "Laptop";
            t1.amount = 50000;
            t1.date = "01/10/2026";
            t1.time = "10:00 AM";

            // Create second transaction object
            Transaction t2 = new Transaction();

            // Copy values from t1 to t2
            t2.id = t1.id;
            t2.productName = t1.productName;
            t2.amount = t1.amount;
            t2.date = t1.date;
            t2.time = t1.time;

            // Print both objects before changes
            Console.WriteLine("BEFORE CHANGES");

            Console.WriteLine("\nTransaction 1");
            Console.WriteLine($"ID: {t1.id}");
            Console.WriteLine($"Product: {t1.productName}");
            Console.WriteLine($"Amount: {t1.amount}");

            Console.WriteLine("\nTransaction 2");
            Console.WriteLine($"ID: {t2.id}");
            Console.WriteLine($"Product: {t2.productName}");
            Console.WriteLine($"Amount: {t2.amount}");

            // Modify first transaction
            t1.productName = "Mobile";
            t1.amount = 30000;

            // Modify second transaction
            t2.productName = "Keyboard";
            t2.amount = 2500;

            // Print both objects after changes
            Console.WriteLine("\n\nAFTER CHANGES");

            Console.WriteLine("\nTransaction 1");
            Console.WriteLine($"ID: {t1.id}");
            Console.WriteLine($"Product: {t1.productName}");
            Console.WriteLine($"Amount: {t1.amount}");

            Console.WriteLine("\nTransaction 2");
            Console.WriteLine($"ID: {t2.id}");
            Console.WriteLine($"Product: {t2.productName}");
            Console.WriteLine($"Amount: {t2.amount}");

            Console.ReadKey();

        }
    }
}
