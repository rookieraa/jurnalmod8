using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302220024
{
    internal class BankTransferConfig
    {
        public string lang { set; get; }
        public Transfer Transfer { set; get; } 
        public List<string> methods { set; get; }
        public Confirmation Confirmation { set; get; }

        public BankTransferConfig() { }
        public BankTransferConfig(string lang, Transfer transfer, List<string> methods, Confirmation confirmation)
        {
            this.lang = lang;
            Transfer = transfer;
            this.methods = methods;
            Confirmation = confirmation;
        }
    }
}
