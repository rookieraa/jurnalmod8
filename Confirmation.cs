using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302220024
{
    internal class Confirmation
    {
        public string en {  get; set; } 
        public string id { get; set; }

        public Confirmation(String en, String id)
        {
            this.en = en;
            this.id = id;
        }
    }
}
