using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScanner
{
    public class ScanManager :IScanmanager
    {
        public void ScanDocument(Scanner scaner)
        {
            scaner.Scan();
        }
    }    
}
