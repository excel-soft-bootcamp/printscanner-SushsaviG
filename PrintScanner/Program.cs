using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScanner
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer print = new Printer();
            Scanner _scan = new Scanner();

            ScanManager _scanManager = new ScanManager();
            _scanManager.ScanDocument(_scan);

            PrintManager _print = new PrintManager();
            _print.PrintDocument(print);

             PrintScanner _printScanner = new PrintScanner();
            _scanManager.ScanDocument(_printScanner);
            _print.PrintDocument(_PrintScanner);
           
    
        }
    }
}
