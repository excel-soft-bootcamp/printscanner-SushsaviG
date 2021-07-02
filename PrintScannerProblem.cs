public interface IPrinter{
    void Print();
}

public interface IScanner{
  void Scan();   
}

public class NanoLaserPrinter:IPrinter{
 
    public void Print(){Console.WriteLine("Nano Laser Printer in Action");
    
}
public class Printer:IPrinter
    {
        public void Print() { Console.WriteLine("Print in Action"); }
    }

    public class Scanner:IScanner
    {
        public void Scan() { Console.WriteLine("Scan In Action"); }

    }

    
    public class PrintScanner:IPrinter,IScanner
    {
            public void Print(){
            //Delegate Call To Either NanoLaserPrinter or Printer
            }
            public void Scan(){
            //Delegate Call To Scanner
            }
            
    }

    public class PrintManager
    {
        public void PrintDocument(IPrinter printer)
        {
            printer.Print();
        }
    }
    public class ScanManager
    {
        public void ScanDocument(IScanner scaner)
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
