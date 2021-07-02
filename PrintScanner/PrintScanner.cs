using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScanner
{

    public class PrintScanner:IPrintmanager,IScanmanager
    {
        public void PrintDocument(Printer printer)
        {
            printer.Print();
        }
        public void ScanDocument(Scanner scaner)
        {
            scaner.Scan();
        }


    }






}
    
    