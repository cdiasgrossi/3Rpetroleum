using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizzon3REnergySysPDFtoXML {
    public class Helper {        
        public static string ReadResource(string File) {
            var po = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
            Stream St = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(File);
            StreamReader Tr = new StreamReader(St);
            return Tr.ReadToEnd();
        }
    }
}
