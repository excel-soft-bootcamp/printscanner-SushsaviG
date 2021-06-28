public class Printer
    {
        public void Print() { Console.WriteLine("Print in Action"); }
    }

    public class Scanner
    {
        public void Scan() { Console.WriteLine("Scan In Action"); }

    }

    
    public class PrintScanner
    {

    }

    public class PrintManager
    {
        public void PrintDocument(Printer printer)
        {
            printer.Print();
        }
    }
    public class ScanManager
    {
        public void ScanDocument(Scanner scaner)
        {
            scaner.Scan();
        }
    }

    public class EntrypointClass
    {

        public static void Main()
        {
            Printer _printerRef = new Printer();
            Scanner _scannerRef = new Scanner();

            PrintManager _printManager = new PrintManager();
            _printManager.PrintDocument(_printerRef);

            ScanManager _scanManager = new ScanManager();
            _scanManager.ScanDocument(_scannerRef);

            PrintScanner _printScanner = new PrintScanner();
            _printManager.PrintDocument(_printScanner);
            _scanManager.ScanDocument(_printScanner);


        }
    }
