using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// klasa potrzebna do wyświetlania w terminalu wartosci tablicy tab 
namespace karcioszki
{
    internal class DebugTextWriter:TextWriter
    {
        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }

        //Required
        public override void Write(char value)
        {
            Debug.Write(value);

        }

        //Added for efficiency
        public override void Write(string value)
        {
            Debug.Write(value);
        }

        //Added for efficiency
        public override void WriteLine(string value)
        {
            Debug.WriteLine(value);
        }
    }
}
