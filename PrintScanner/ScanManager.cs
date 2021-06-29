using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScanner
{
    public class ScanManager:Scanner,IDocument
    {
        
        public void ScanDocument(Scanner scaner)
        {
            scaner.Scan();
        }
    }
    public interface IDocument
    {
        void ScanDocument(Scanner scaner);

    }
}
