using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScanner
{
   public class PrintManager:Printer,Idocument
    {
        
        public void PrintDocument(Printer printer)
        {
            printer.Print();
        }
    }
    public interface Idocument
    {
        void PrintDocument(Printer printer)
    }
}
