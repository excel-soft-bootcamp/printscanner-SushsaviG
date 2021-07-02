using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScanner
{
    public class PrintManager:IPrintmanager
    {
        public void PrintDocument(Printer printer)
        {
            printer.Print();
        }



    }
}
