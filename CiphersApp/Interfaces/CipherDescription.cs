using System;
using System.Collections.Generic;
using System.Text;

namespace CiphersApp.Interfaces
{
    interface CipherDescription
    {
        public int CipherNumber { get; set; }
        public string Name { get;set; }
        public string ShortDescription { get; set; }
    }
}
