using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScanner
{
    public interface IPrintmanager
    {
        void PrintDocument(Printer printer);
    }




    public interface IScanmanager
    {
        void ScanDocument(Scanner scaner);
    }
}
