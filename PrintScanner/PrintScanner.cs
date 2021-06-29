using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScanner
{

    public class PrintScanner:PrintManager,Idocument,IDocument
    {
        public void PrintDocument(Printer printer)
        {
            printer.Print();
        }
        public void ScanDocument(Scanner scaner)
        {
            scaner.Scan();
        }
        public void Print() { Console.WriteLine("Print in Action"); }


    }






}
    
    