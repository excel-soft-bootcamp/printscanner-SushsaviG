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
            PrintScanner _printscanner = new PrintScanner();
            PrintManager _printmanager = new PrintManager();
            _printmanager.PrintDocument(_printscanner);

        }
    }
}
